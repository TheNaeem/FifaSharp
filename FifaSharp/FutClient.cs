using FifaSharp.Api;
using FifaSharp.Api.Enums;
using FifaSharp.Api.Models;
using FifaSharp.Authentication;
using RestSharp;
using Serilog;
using ShadeSniper.FifaSharp.FifaSharp.Api.Models;
using ShadeSniper.FifaSharp.FifaSharp.Api.Schema;
using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace FifaSharp;

public class FutClient
{
    public string PersonaName { get; private set; } = default!;
    public UInt64 PersonaId { get; private set; }

    private string _cookies = string.Empty;
    private FutAccountSession _session = default!;

    public FutClient() { }

    /// <summary>
    /// Logs into the account from cached cookies. 
    /// </summary>
    /// <param name="cookies">Login cookies.</param>
    /// <returns>True if successful.</returns>
    public bool TryLogin(string cookies)
        => TryLoginAsync(cookies).GetAwaiter().GetResult();

    public async Task<bool> TryLoginAsync(string cookies)
    {
        _session = new(cookies);

        var persona = await _session.TryLoadPersonaAsync(this);

        if (persona is null)
        {
            Log.Error("Persona data is null. Returning.");
            return false;
        }

        PersonaName = persona.Name;
        PersonaId = persona.Id;

        Log.Information("Successfully loaded persona for {name} ({id})", persona.Name, persona.Id);

        return true;
    }

    /// <summary>
    /// Logs into the account.
    /// </summary>
    /// <param name="email">Account email.</param>
    /// <param name="password">Account password.</param>
    /// <param name="onTwoFactorCode">Function that should return the 2fa login code if it's required.</param>
    /// <param name="onCacheCookies">Optional function parameter that passes in the login cookies so it can be cached for future logins.</param>
    /// <returns>True if successful.</returns>
    public bool TryLogin(string email, string password, Func<Task<string?>> onTwoFactorCode, Action<string>? onCacheCookies = null)
        => TryLoginAsync(email, password, onTwoFactorCode, onCacheCookies).GetAwaiter().GetResult();


    /// <summary>
    /// Asynchronously logs into the account.
    /// </summary>
    /// <param name="email">Account email.</param>
    /// <param name="password">Account password.</param>
    /// <param name="onTwoFactorCode">Function that should return the 2fa login code if it's required.</param>
    /// <param name="onCacheCookies">Optional function parameter that passes in the login cookies so it can be cached for future logins.</param>
    /// <returns>True if successful.</returns>
    public async Task<bool> TryLoginAsync(string email, string password, Func<Task<string?>> onTwoFactorCode, Action<string>? onCacheCookies = null)
    {
        var auth = new FutAuthClient();
        var session = await auth.TryCreateSessionAsync(email, password, onTwoFactorCode);

        if (session is null)
            return false;

        _session = session;

        var cookie = auth.GetCookie();

        if (onCacheCookies is not null && !string.IsNullOrEmpty(cookie))
        {
            onCacheCookies(cookie);
        }

        var persona = await _session.TryLoadPersonaAsync(this);

        if (persona is null)
        {
            Log.Error("Persona data null. Returning.");
            return false;
        }

        PersonaName = persona.Name;
        PersonaId = persona.Id;

        return true;
    }

    /// <summary>
    /// Returns the login cookies. Should be used to cache logins so you don't have to go through the login process repeatedly. 
    /// </summary>
    /// <returns>Cookies. Yum.</returns>
    public string GetLoginCookies()
    {
        return _cookies;
    }

    /// <summary>
    /// Asynchronously retrives the accounts trade pile, which contains transfer data and account coins.
    /// </summary>
    /// <returns>TradePile. Can be null.</returns>
    public async Task<TradePile?> RetrieveTradePileAsync()
    {
        var response = await _session.ProcessRequestAsync($"https://{EndpointDirectory.BASE_URL}/ut/game/fc24/tradepile");

        if (!response.IsSuccessful || string.IsNullOrEmpty(response.Content))
            return default;

        return JsonSerializer.Deserialize<TradePile>(response.Content);
    }

    /// <summary>
    /// Contains FUT account info.
    /// </summary>
    /// <returns>Fut account info. Can be null.</returns>
    public async Task<FutAccountInfo?> RetrieveAccountInfoAsync()
    {
        var response = await _session.ProcessUserRequestAsync($"https://{EndpointDirectory.BASE_URL}/ut/game/fc24/v2/user/accountinfo?filterConsoleLogin=true&sku=FUT24WEB&returningUserGameYear=2024&clientVersion=1", timeout: 4000);

        if (!response.IsSuccessful || string.IsNullOrEmpty(response.Content))
        {
            Log.Error("Account info request failed. Status code {code}.", response.StatusCode);
            return default;
        }

        return JsonSerializer.Deserialize<FutAccountInfo>(response.Content);
    }

    /// <summary>
    /// Contains EA account information such as email, date of birth, etc.
    /// </summary>
    /// <returns>Identity. Can be null.</returns>
    public async Task<Identity?> RetrieveIdentityAsync()
    {
        using var client = new RestClient();
        var request = new RestRequest("https://gateway.ea.com/proxy/identity/pids/me");

        if (!_session.TryGetBearerToken(out var bearer))
            return default;

        request.AddOrUpdateHeader("Authorization", $"Bearer {bearer.Token}");

        var response = await client.ExecuteAsync(request);

        if (!response.IsSuccessful || string.IsNullOrEmpty(response.Content))
        {
            Log.Error("Identity request failed. Status code {code}.", response.StatusCode);
            return default;
        }

        return JsonSerializer.Deserialize<IdentityWrapper>(response.Content)?.Pid;
    }

    /// <summary>
    /// Retrieves the news messages that you see when you open Ultimate Team.
    /// </summary>
    /// <returns>The messsages. Can be null.</returns>
    public async Task<FutMessages?> RetrieveMessagesAsync()
    {
        var response = await _session.ProcessRequestAsync($"https://{EndpointDirectory.BASE_URL}/ut/game/fifa23/message/list/template?nucPersId={PersonaId}&screen=webfuthub");

        if (!response.IsSuccessful || string.IsNullOrEmpty(response.Content))
            return default;

        return JsonSerializer.Deserialize<FutMessages>(response.Content);
    }

    /// <summary>
    /// Search the transfer market.
    /// </summary>
    /// <param name="query"></param>
    /// <returns>The search result. Can be null.</returns>
    public async Task<TransferMarket?> QueryTransferMarketAsync(TransferMarketQuery query)
    {
        UriBuilder uri = new($"https://{EndpointDirectory.BASE_URL}/ut/game/fc24/transfermarket");

        uri.Query = $"num={query.ResultsNum}&start={query.ResultsStart}";

        string typeStr = query.ItemType switch
        {
            FutItemType.Player => "player",
            _ => "player"
        };

        uri.Query += $"&type={typeStr}";

        if (!string.IsNullOrEmpty(query.Position))
            uri.Query += $"&pos={query.Position}";

        if (query.ItemId is not null)
            uri.Query += $"&maskedDefId={query.ItemId}";

        if (!string.IsNullOrEmpty(query.Zone))
            uri.Query += $"&zone={query.Zone}";

        if (query.Nationality is not null)
            uri.Query += $"&nat={query.Nationality}";

        if (!string.IsNullOrEmpty(query.Quality))
            uri.Query += $"&lev={query.Quality}";

        if (query.League is not null)
            uri.Query += $"&leag={query.League}";

        if (query.Club is not null)
            uri.Query += $"&team={query.Club}";

        if (query.RarityId is not null)
            uri.Query += $"&rarityIds={query.RarityId}";

        if (query.MinBuyNow is not null)
            uri.Query += $"&minb={query.MinBuyNow}";

        if (query.MinBid is not null)
            uri.Query += $"&micr={query.MinBid}";

        if (query.MaxBid is not null)
            uri.Query += $"&macr={query.MaxBid}";

        if (query.MaxBuyNow is not null)
            uri.Query += $"&maxb={query.MaxBuyNow}";

        var response = await _session.ProcessRequestAsync(uri);

        if (!response.IsSuccessful || string.IsNullOrEmpty(response.Content))
            return new(response.StatusCode);

        return JsonSerializer.Deserialize<TransferMarket>(response.Content);
    }

    public async Task<BidResult?> BidOnTransferAsync(Transfer transfer, int amount)
        => await BidOnTransferAsync(transfer.TradeId, amount);

    public async Task<BidResult?> BidOnTransferAsync(long tradeId, int amount)
    {
        var request = new RestRequest($"https://{EndpointDirectory.BASE_URL}/ut/game/fc24/trade/{tradeId}/bid", Method.Put);
        request.AddHeader("Content-Type", "application/json");
        request.AddHeader("Cache-Control", "no-cache");
        request.AddParameter("application/json", $"{{\"bid\":{amount}}}", ParameterType.RequestBody);

        var response = await _session.ProcessRequestAsync(request);

        if (!response.IsSuccessful || string.IsNullOrEmpty(response.Content))
            return new(response.StatusCode);

        return JsonSerializer.Deserialize<BidResult>(response.Content);
    }

    public async Task<UpdateTransferListStatus?> SendItemsToTransferListAsync(params long[] itemIds)
    {
        var request = new RestRequest($"https://{EndpointDirectory.BASE_URL}/ut/game/fifa23/item", Method.Put);
        request.AddHeader("Content-Type", "application/json");
        request.AddHeader("Cache-Control", "no-cache");

        var body = new SentTransferListItems();

        foreach (var item in itemIds)
            body.ItemData.Add(new()
            {
                Id = item
            });

        request.AddParameter("application/json", JsonSerializer.Serialize(body), ParameterType.RequestBody);

        var response = await _session.ProcessRequestAsync(request);

        if (!response.IsSuccessful || string.IsNullOrEmpty(response.Content))
            return new(response.StatusCode);

        return JsonSerializer.Deserialize<UpdateTransferListStatus>(response.Content); 
    }

    public async Task<ListTransferStatus?> ListItemOnTransferMarketAsync(long id, int buyNowPrice, int startingBid, TimeSpan duration)
    {
        var body = new ListItemBody()
        {
            buyNowPrice = buyNowPrice,
            duration = (int)duration.TotalSeconds,
            startingBid = startingBid,
            itemData = new()
            {
                id = id
            }
        };

        var request = new RestRequest($"https://{EndpointDirectory.BASE_URL}/ut/game/fifa23/auctionhouse", Method.Post);
        request.AddHeader("Content-Type", "application/json");
        request.AddHeader("Cache-Control", "no-cache");
        request.AddParameter("application/json", JsonSerializer.Serialize(body), ParameterType.RequestBody);

        var response = await _session.ProcessRequestAsync(request);

        if (!response.IsSuccessful || string.IsNullOrEmpty(response.Content))
            return new(response.StatusCode);

        return JsonSerializer.Deserialize<ListTransferStatus>(response.Content);
    }

    public async Task<Evolutions?> RetrieveEvolutionsAsync(EvolutionsStatus status = EvolutionsStatus.NotStarted)
    {
        string slotStatus = string.Empty;

        if (status == EvolutionsStatus.NotStarted)
            slotStatus = "NOT_STARTED";
        else slotStatus = "STARTED";

        var response = await _session.ProcessRequestAsync($"https://{EndpointDirectory.BASE_URL}/ut/game/fc24/academy/hub?offset=0&count=100&sortOrder=asc&slotStatus={slotStatus}");

        if (!response.IsSuccessful || string.IsNullOrEmpty(response.Content))
            return default;

        return JsonSerializer.Deserialize<Evolutions>(response.Content);
    }
}
