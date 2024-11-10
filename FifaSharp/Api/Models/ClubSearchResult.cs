using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FifaSharp.Api.Models;

public class ClubSearchResult
{
    public ClubSearchResult() { }

    public ClubSearchResult(HttpStatusCode statusCode)
    {
        this.StatusCode = statusCode;
    }

    public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.OK;

    [JsonPropertyName("itemData")]
    public List<PlayerItemData> ItemData { get; set; } = default!; 
}