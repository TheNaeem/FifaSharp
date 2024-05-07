using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ShadeSniper.FifaSharp.FifaSharp.Api.Models;


public class UpdateTransferListStatus
{
    public UpdateTransferListStatus() { }

    public UpdateTransferListStatus(HttpStatusCode statusCode)
    {
        this.StatusCode = statusCode;
    }
    public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.OK;

    [JsonPropertyName("itemData")]
    public Item[] ItemData { get; set; } = default!;

    public class Item
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("pile")]
        public string Pile { get; set; } = default!;

        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
