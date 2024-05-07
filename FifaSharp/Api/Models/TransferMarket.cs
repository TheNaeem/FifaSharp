using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FifaSharp.Api.Models;


public class TransferMarket
{
    public TransferMarket() { } 

    public TransferMarket(HttpStatusCode statusCode)
    {
        this.StatusCode = statusCode;
    }

    public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.OK;

    [JsonPropertyName("auctionInfo")]
    public Transfer[] Transfers { get; set; } = default!;

    [JsonPropertyName("bidTokens")]
    public object? BidTokens { get; set; } // TODO: 
}
