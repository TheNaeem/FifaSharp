using RestSharp;
using RestSharp.Authenticators;
using System.Threading.Tasks;

namespace FifaSharp.Authentication;

public class FutAuthenticator : IAuthenticator
{
    public string Cookies { get; set; } = string.Empty;

    public FutAuthenticator()
    {

    }

    public FutAuthenticator(string cookies)
    {
        Cookies = cookies;
    }

    public ValueTask Authenticate(RestClient client, RestRequest request)
    {
        request.AddOrUpdateHeader("Cookie", Cookies);

        return new();
    }
}
