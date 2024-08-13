# FifaSharp

## Usage 

```csharp
string? GetOneTimeCode()
{
    Console.Write("Enter the 2fa code sent to your email: ");
    return Console.ReadLine();
}

void CacheCookie(string cookie)
{
    File.WriteAllText("cookie_cache.txt", cookies);
}

var client = new FutClient();

bool success = await client.TryLoginAsync("johndoe@gmail.com", "password", GetOneTimeCode, true, CacheCookie);
```

## Caching Logins

Logins are cached using the cookies. After successfully logging in once with email and password you can get the login cookies with the `GetLoginCookies` method or the optional `onCacheCookies` parameter in `TryLoginAsync`, which you can see an example of above.

Once you have the cookies cached somewhere, to log in again without using your password or going through the 2FA process, just pass the cookies you cached into `TryLoginAsync`.

```csharp
// just a simple example of how you can use the cached login

if (File.Exists("cookie_cache.txt")
{
  string cachedCookie = File.ReadAllText("cookie_cache.txt");
  await client.TryLoginAsync(cachedCookies);
}
```
