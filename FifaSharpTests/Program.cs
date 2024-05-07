using FifaSharp;
using FifaSharp.Api.Models;
using FifaSharpTests;
using System.Net;
using System.Text.Json;

const string CACHE_FILE = "cookie.txt";
const string LOGIN_FILE = "login.json";
async Task<string?> GetOneTimeCode()
{
    Console.Write("Enter your 2fa code: ");
    return Console.ReadLine();
}

void CacheCookie(string cookie)
{
    File.WriteAllText(CACHE_FILE, cookie);
}

if (!File.Exists(LOGIN_FILE))
{
    File.WriteAllText(LOGIN_FILE, JsonSerializer.Serialize(new LoginDetails()));
    Console.WriteLine("Login file created. Fill it out and restart this.");

    Console.ReadKey();
    return;
}

var client = new FutClient();

if (!File.Exists(CACHE_FILE) ||
    !await client.TryLoginAsync(File.ReadAllText(CACHE_FILE)))
{
    var login = JsonSerializer.Deserialize<LoginDetails>(
     File.ReadAllText(LOGIN_FILE));

    if (!await client.TryLoginAsync(login.Email, login.Password, GetOneTimeCode, CacheCookie))
        return;
}

Console.WriteLine(client.PersonaName);
