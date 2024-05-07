using FifaSharp;
using FifaSharp.Api.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaSharpTests;

public class Snipex
{
    private FutClient _client;
    private int _amount;
    private List<Func<TransferMarketQuery, TransferMarketQuery>> changes = new();
    public required TransferMarketQuery Query { get; set; }

    public Snipex(FutClient client, int amount)
    {
        _client = client;
        _amount = amount;

        for (var i = 0; i < 9; i++)
        {
            changes.Add((input) =>
            {
                input.MinBuyNow += 50;
                return input;
            });
        }

        changes.Add((input) =>
        {
            input.MaxBid = Query.MaxBuyNow - 100;
            return input;
        });

        for (var i = 0; i < 9; i++)
        {
            changes.Add((input) =>
            {
                input.MinBuyNow -= 50;
                return input;
            });
        }

        changes.Add((input) =>
        {
            input.MaxBid = null;
            return input;
        });
    }

    public async Task Run()
    {
        int currentWait = 0;
        int currentAmount = 0;

        var waits = new int[]
        {
            1200,
            1200,
            1200,
            2500,
            2500,
            1200,
            1200,
            1200,
            2500,
            2500,
            3000,
            1200,
            2500,
            2500,
            1200,
            2500,
            12000
        };

        while (true)
        {
            for (int i = 0; i < changes.Count; i++)
            {
                await Task.Delay(waits[currentWait]);

                currentWait++;

                if (currentWait >= waits.Length)
                    currentWait = 0;

                var transfers = await _client.QueryTransferMarketAsync(changes[i](Query));

                if (transfers is null || transfers.Transfers is null || transfers.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    Console.WriteLine("Request failed", Console.ForegroundColor = ConsoleColor.Red);
                    currentAmount = _amount;
                    break;
                }

                if (transfers.Transfers.Length == 0)
                {
                    Console.WriteLine("Found none, continuing.");
                    continue;
                }

                var first = transfers.Transfers[0];

                if (first is null)
                {
                    continue;
                }

                var result = await _client.BidOnTransferAsync(first, first.BuyNowPrice);

                if (result is null || result.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    Console.WriteLine($"Missed one for {first.BuyNowPrice}", Console.ForegroundColor = ConsoleColor.Red);

                    continue;
                }

                Console.WriteLine($"Bought one for {first.BuyNowPrice}!", Console.ForegroundColor = ConsoleColor.Green);

                currentAmount++;

                if (currentAmount >= _amount)
                    break;
            }

            if (currentAmount >= _amount)
                break;
        }
    }

    private static TransferMarketQuery DecreaseBuyNow(TransferMarketQuery inQuery)
    {
        inQuery.MinBuyNow -= 50;
        return inQuery;
    }

    private static TransferMarketQuery IncreaseBuyNow(TransferMarketQuery inQuery)
    {
        inQuery.MinBuyNow += 50;
        return inQuery;
    }
}
