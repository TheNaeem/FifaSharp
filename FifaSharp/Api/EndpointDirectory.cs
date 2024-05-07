namespace FifaSharp.Api;

public static class EndpointDirectory
{
    public const string BASE_URL = "utas.mob.v2.prd.futc-ext.gcp.ea.com";
    public const string CLIENT_ID = "FC24_JS_WEB_APP";
    public const string CREATE_TOKEN = $"https://accounts.ea.com/connect/auth?hide_create=true&display=web2%2Flogin&scope=basic.identity+offline+signin+basic.entitlement+basic.persona&release_type=prod&response_type=token&redirect_uri=https%3A%2F%2Fwww.ea.com%2Fea-sports-fc%2Fultimate-team%2Fweb-app%2Fauth.html&accessToken=&locale=en_US&prompt=login&client_id={CLIENT_ID}&fid={{0}}";
    public const string CREATE_ACCESS_TOKEN = $"https://accounts.ea.com/connect/auth?response_type=token&redirect_uri=nucleus%3Arest&prompt=none&client_id={CLIENT_ID}";
    public const string CREATE_ORIGIN_ACCESS_TOKEN = "https://accounts.ea.com/connect/auth?response_type=token&redirect_uri=nucleus%3Arest&prompt=none&client_id=ORIGIN_JS_SDK";
    public const string CREATE_AUTH_CODE = "https://accounts.ea.com/connect/auth?client_id=FUTWEB_BK_OL_SERVER&redirect_uri=nucleus:rest&response_type=code&access_token={0}&release_type=prod&client_sequence=ut-auth";
    public const string CREATE_AUTH_FID = $"https://accounts.ea.com/connect/auth?accessToken=&client_id={CLIENT_ID}&display=web2/login&hide_create=true&locale=en_US&prompt=login&redirect_uri=https://www.ea.com/ea-sports-fc/ultimate-team/web-app/auth.html&release_type=prod&response_type=token&scope=basic.identity+offline+signin+basic.entitlement+basic.persona";
    public const string CREATE_SID = $"https://{BASE_URL}/ut/auth";
}
