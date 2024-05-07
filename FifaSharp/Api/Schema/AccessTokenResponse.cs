namespace FifaSharp.Api.Schema;

public class AccessTokenResponse
{
    public string? access_token { get; set; }
    public string? token_type { get; set; }
    public string? expires_in { get; set; }
}

