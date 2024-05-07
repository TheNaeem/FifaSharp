using System;

namespace FifaSharp.Api.Schema;

public class SidTokenResponse
{
    public string? protocol { get; set; }
    public string? ipPort { get; set; }
    public DateTime serverTime { get; set; }
    public DateTime lastOnlineTime { get; set; }
    public string? sid { get; set; }
    public string? phishingToken { get; set; }
}

