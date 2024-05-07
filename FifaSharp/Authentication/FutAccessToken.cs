using System;
using System.Diagnostics;

namespace FifaSharp.Authentication;

public class FutAccessToken
{
    public string Token { get; set; }
    public TimeSpan ExpiresIn { get; set; }
    private Stopwatch _sw;

    public FutAccessToken(string token, TimeSpan expiration)
    {
        Token = token;
        ExpiresIn = expiration;
        _sw = Stopwatch.StartNew();
    }

    /// <summary>
    /// Used for one use tokens.
    /// </summary>
    /// <param name="token"></param>
    public FutAccessToken(string token) : this(token, TimeSpan.FromSeconds(1))
    {
    }

    public bool IsExpired
    {
        get => _sw.Elapsed >= ExpiresIn;
    }
}
