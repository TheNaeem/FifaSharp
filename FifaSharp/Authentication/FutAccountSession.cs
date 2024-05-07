using FifaSharp.Api;
using FifaSharp.Api.Models;
using FifaSharp.Api.Schema;
using System.Text.Json;
using RestSharp;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using Serilog;

namespace FifaSharp.Authentication;

public class FutAccountSession
{
    public FutAuthClient AuthClient { get; init; }
    private FutAccessToken? _bearer = null;
    private FutAccessToken? _sid = null;
    private UInt64 _personaId;
    private long _pidId;
    private string _gameSku = default!;

    public FutAccountSession(FutAuthClient client)
    {
        AuthClient = client;
    }

    public FutAccountSession(string cookie)
    {
        AuthClient = new(cookie);
    }

    /// <summary>
    /// Used to retrieve the auth code and other stuff.
    /// </summary>
    /// <param name="token"></param>
    /// <returns></returns>
    public bool TryGetBearerToken([NotNullWhen(true)] out FutAccessToken? token)
    {
        token = null;

        if (_bearer is null || _bearer.IsExpired)
        {
            var request = new RestRequest(EndpointDirectory.CREATE_ACCESS_TOKEN);
            var response = AuthClient.Execute<AccessTokenResponse>(request);

            if (!response.IsSuccessful ||
                response.Data is null ||
                string.IsNullOrEmpty(response.Data.access_token) ||
                string.IsNullOrEmpty(response.Data.expires_in))
            {
                Log.Error("Request to create access token unsuccessful. Status code {code}", response.StatusCode);
                return false;
            }

            _bearer = new(response.Data.access_token,
                TimeSpan.FromSeconds(int.Parse(response.Data.expires_in)));
        }

        token = _bearer;

        return true;
    }

    /// <summary>
    /// Should be a one time use token.
    /// </summary>
    /// <param name="token"></param>
    /// <returns></returns>
    public bool TryGetAuthCode([NotNullWhen(true)] out FutAccessToken? token)
    {
        token = null;

        if (!TryGetBearerToken(out var bearer))
            return false;

        using var client = new RestClient();

        var request = new RestRequest(
            string.Format(EndpointDirectory.CREATE_AUTH_CODE, bearer.Token), Method.Get);

        var response = client.Execute(request);

        if (!response.IsSuccessful || string.IsNullOrEmpty(response.Content))
            return false;

        using var doc = JsonDocument.Parse(response.Content);

        if (!doc.RootElement.TryGetProperty("code", out var codeProp))
            return false;

        var code = codeProp.GetString();

        if (string.IsNullOrEmpty(code))
            return false;

        token = new(code);

        return true;
    }

    public bool TryGetSidToken([NotNullWhen(true)] out FutAccessToken? token)
    {
        token = null;

        if (!TryGetAuthCode(out var authCode))
            return false;

        using var client = new RestClient();

        var body = new AuthReqBody();
        body.identification.authCode = authCode.Token;
        body.nucleusPersonaId = _personaId;
        body.gameSku = _gameSku;

        var request = new RestRequest(EndpointDirectory.CREATE_SID, Method.Post);
        //request.Timeout = 2000;
        request.AddHeader("X-UT-PHISHING-TOKEN", 0);
        request.AddHeader("Content-Type", "application/json");
        request.AddParameter("application/json", JsonConvert.SerializeObject(body), ParameterType.RequestBody);

        var res = client.Execute(request, Method.Post);

        if (!res.IsSuccessful || res.Headers is null)
            return false;

        var sid = res.Headers.FirstOrDefault(x => x.Name == "X-UT-SID");

        if (sid is null || sid.Value is not string sidStr)
            return false;

        token = new(sidStr);

        return true;
    }

    public async Task<RestResponse> ProcessRequestAsync(UriBuilder uri, Method method = Method.Get)
       => await ProcessRequestAsync(new(uri.Uri, method));

    public async Task<RestResponse> ProcessRequestAsync(Uri uri, Method method = Method.Get)
        => await ProcessRequestAsync(new(uri, method));
    public async Task<RestResponse> ProcessRequestAsync(string url, Method method = Method.Get)
        => await ProcessRequestAsync(new(url, method));

    public async Task<RestResponse> ProcessRequestAsync(RestRequest request)
    {
        if (_sid is null)
            TryGetSidToken(out _sid);

        using var client = new RestClient();

        if (_sid is not null)
            request.AddOrUpdateHeader("X-UT-SID", _sid.Token);

        request.AddOrUpdateHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/108.0.0.0 Safari/537.36");

        var response = await client.ExecuteAsync(request);

        if (response.StatusCode == HttpStatusCode.Unauthorized && TryGetBearerToken(out _sid))
        {
            request.AddOrUpdateHeader("X-UT-SID", _sid.Token);
            response = await client.ExecuteAsync(request);
        }

        return response;
    }

    public async Task<RestResponse> ProcessUserRequestAsync(string url, Method method = Method.Get, int timeout = 0)
       => await ProcessUserRequestAsync(new(url, method), timeout);

    public async Task<RestResponse> ProcessUserRequestAsync(RestRequest request, int timeout = 0)
    {
        if (timeout != 0)
            request.Timeout = timeout;

        if (TryGetAuthCode(out var authCode))
        {
            request.AddOrUpdateHeader("Easw-Session-Data-Nucleus-Id", _pidId);
            request.AddOrUpdateHeader("Nucleus-Access-Code", authCode.Token);
            request.AddOrUpdateHeader("Nucleus-Redirect-Url", "nucleus:rest");
        }

        using var client = new RestClient();

        return await client.ExecuteAsync(request);
    }

    /// <summary>
    /// Should only be called when creating the Fut Client so the persona data can be retrived.
    /// </summary>
    /// <returns></returns>
    public async Task<FutAccountInfo.Persona?> TryLoadPersonaAsync(FutClient client)
    {
        var identity = await client.RetrieveIdentityAsync();

        if (identity is null)
        {
            Log.Error("Identity data null. Returning.");
            return default;
        }

        _pidId = identity.PidId;

        var accountInfo = await client.RetrieveAccountInfoAsync();

        if (accountInfo is null)
        {
            Log.Error("Account info data null. Returning.");
            return default;
        }

        var persona = accountInfo.Info.Personas.FirstOrDefault();

        if (persona is null)
        {
            Log.Error("Persona data null. Returning.");
            return default;
        }

        _personaId = persona.Id;

        var club = persona.UserClubList.Length == 1 ? persona.UserClubList.FirstOrDefault() : persona.UserClubList.FirstOrDefault(x => x.Year == "2024");

        if (club is null || club.SkuAccessList.Count == 0)
        {
            Log.Error("Could not retrieve gamesku. Returning.");
            return default;
        }

        _gameSku = club.SkuAccessList.First().Key;

        return persona;
    }
}
