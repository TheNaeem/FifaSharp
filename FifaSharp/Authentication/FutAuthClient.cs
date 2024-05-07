using FifaSharp.Api;
using RestSharp;
using RestSharp.Authenticators;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace FifaSharp.Authentication;

public class FutAuthClient : RestClient
{
    public string? SessionId { get; set; }
    private Dictionary<string, string> _cookies = new();

    public FutAuthClient(string cookies) : this()
    {
        Authenticator = new FutAuthenticator(cookies);
    }

    public FutAuthClient() : base()
    {
        this.AddDefaultHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/116.0.0.0 Safari/537.36");
        this.AddDefaultHeader("Connection", "keep-alive");
    }

    private async Task<bool> TryRetrieveCookiesAsync()
    {
        Authenticator = new FutAuthenticator();

        var response = await ExecuteAsync(new("https://www.ea.com/ea-sports-fc/ultimate-team/web-app/"));

        if (!response.IsSuccessful ||
           response.Cookies is null)
        {
            Log.Error("Request to retrieve cookies failed with status code {code}.", response.StatusCode);
            return false;
        }

        //UpdateCookies(response.Cookies, "ealocale", "EDGESCAPE_COUNTRY", "EDGESCAPE_COUNTRY", "EDGESCAPE_REGION");

        //var configResponse = await ExecuteAsync(new("https://www.ea.com/ea-sports-fc/ultimate-team/web-app/content/24B23FDE-7835-41C2-87A2-F453DFDB2E82/2024/fut/config/companion/remoteConfig.json"));

        return true;
    }

    private async Task<bool> TryFindSessionIdAsync()
    {
        var fidResponse = await ExecuteAsync(new(EndpointDirectory.CREATE_AUTH_FID)); 
        
        if (!fidResponse.IsSuccessful || string.IsNullOrEmpty(fidResponse.Content))
        {
            Log.Error("Response to get FID failed with status code {code}", fidResponse.StatusCode);
            return false;
        }

        var fidMatches = Regex.Matches(fidResponse.Content, "'fid': \"(.*?)\"");

        if (fidMatches.Count <= 0)
        {
            Log.Error("Could not find FID in response. Returning.");
            return false;
        }

        SessionId = fidMatches.First().Value.Split('\"')[1];

        return true;
    }

    public async Task<FutAccountSession?> TryCreateSessionAsync(string email, string pw, Func<Task<string?>> on2fa)
    {
        if (!await TryRetrieveCookiesAsync() || !await TryFindSessionIdAsync())
            return null;

        var loginResponse = await ExecuteAsync(new("https://signin.ea.com/p/juno/login?fid=" + SessionId));

        if (!loginResponse.IsSuccessful || loginResponse.Cookies is null || loginResponse.ResponseUri is null)
        {
            Log.Error("Login response failed with status code {code}", loginResponse.StatusCode);
            return null;
        }

        //UpdateCookies(loginResponse.Cookies, "signin-cookie", "JSESSIONID");

        var executeRequest = new RestRequest(loginResponse.ResponseUri);
        await ExecuteAsync(executeRequest);

        executeRequest.AddParameter("email", email);
        executeRequest.AddParameter("regionCode", "US");
        executeRequest.AddParameter("phoneNumber", string.Empty);
        executeRequest.AddParameter("password", pw);
        executeRequest.AddParameter("_eventId", "submit");
        executeRequest.AddParameter("cid", string.Empty);
        executeRequest.AddParameter("showAgeUp", true);
        executeRequest.AddParameter("thirdPartyCaptchaResponse", string.Empty);
        executeRequest.AddParameter("loginMethod", "emailPassword");
        executeRequest.AddParameter("_rememberMe", "on");
        executeRequest.AddParameter("rememberMe", "on");

        var executeResponse = this.Post(executeRequest);

        if (!executeResponse.IsSuccessful || string.IsNullOrEmpty(executeResponse.Content) || executeResponse.ResponseUri is null)
        {
            Log.Error("Log in execution response failed with status code {code}", executeResponse.StatusCode);
            return null;
        }

        if (executeResponse.Content.Contains("Two Factor Log In"))
        {
            Log.Information("2fa required for account.");

            RestRequest send2fa = new(executeResponse.ResponseUri); // sends the code to the email
            send2fa.AddParameter("codeType", "EMAIL");
            send2fa.AddParameter("maskedDestination", email);
            send2fa.AddParameter("_eventId", "submit");

            var submitResponse = this.Post(send2fa);
            var oneTimeCode = await on2fa();

            if (string.IsNullOrEmpty(oneTimeCode) || submitResponse.ResponseUri is null)
            {
                Log.Error("Request to send 2fa code failed with status code {code}", submitResponse.StatusCode);
                return null;
            }

            var twoFaCodeReq = new RestRequest(submitResponse.ResponseUri);
            twoFaCodeReq.AddParameter("oneTimeCode", oneTimeCode);
            twoFaCodeReq.AddParameter("_trustThisDevice", "on");
            twoFaCodeReq.AddParameter("trustThisDevice", "on");
            twoFaCodeReq.AddParameter("_eventId", "submit");

            var codeResponse = this.Post(twoFaCodeReq);

            if (codeResponse.Cookies is null)
            {
                Log.Error("2fa code submission failed with status code {code}", codeResponse.StatusCode);
                return null;
            }

            UpdateCookies(codeResponse.Cookies, "_nx_mpcid", "osc"); // make this appear
        }

        RemoveCookies("signin-cookie", "JSESSIONID");

        var createTokenReq = new RestRequest(
                string.Format(EndpointDirectory.CREATE_TOKEN, SessionId));

        var createTokenResponse = Execute(createTokenReq);

        if (!createTokenResponse.IsSuccessful || createTokenResponse.Cookies is null)
        {
            Log.Error("Create token request failed with status code {code}", createTokenResponse.StatusCode);
            return null;
        }

        UpdateCookies(createTokenResponse.Cookies, "sid", "remid");

        return new(this);
    }

    public string? GetCookie()
        => (Authenticator as FutAuthenticator)?.Cookies;

    private void UpdateCookies(CookieCollection cookies, params string[] names)
    {
        bool cookiesChanged = false;

        foreach (var c in cookies)
        {
            var cook = c.ToString();

            if (string.IsNullOrEmpty(cook))
                continue;

            var split = cook.Split('=');

            if (split.Length < 2)
                continue;

            string cookieName = split[0];
            string cookieValue = split[1];

            if (names.Length > 0 && !names.Contains(cookieName))
                continue;

            if (!_cookies.ContainsKey(cookieName) /* || _cookies[cookieName] != cookieValue */)
            {
                cookiesChanged = true;
                _cookies[cookieName] = cookieValue;
            }
        }

        if (!cookiesChanged)
            return;

        RefreshAuthenticatorCookies();
    }

    private void AddCookie(string name, string val)
    {
        _cookies[name] = val;
        RefreshAuthenticatorCookies();
    }

    private void RemoveCookies(params string[] names)
    {
        foreach (var n in names)
        {
            if (_cookies.ContainsKey(n))
                _cookies.Remove(n);
        }

        RefreshAuthenticatorCookies();
    }

    private void RefreshAuthenticatorCookies()
    {
        var authenticator = Authenticator as FutAuthenticator;

        if (authenticator is null)
            return;

        authenticator.Cookies = string.Empty;

        foreach (var (k, v) in _cookies)
        {
            authenticator.Cookies += $"{k}={v}; ";
        }
    }
}
