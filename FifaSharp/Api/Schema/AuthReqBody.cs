namespace FifaSharp.Api.Schema;


public class AuthReqBody
{
    public int clientVersion = 1;
    public string ds = string.Empty;
    public string gameSku = "FFA24XSX"; // TODO:
    public Identification identification = new();
    public bool isReadOnly = false;
    public string locale = "en-US";
    public string method = "authcode";
    public UInt64 nucleusPersonaId = 0;
    public int priorityLevel = 4;
    public string sku = "FUT24WEB";

    public class Identification
    {
        public string authCode = string.Empty;
        public string redirectUrl = "nucleus:rest";
        public string tid = "RETAIL";
    }
}



