using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ShadeSniper.FifaSharp.FifaSharp.Api.Models;


public class SentTransferListItems
{
    [JsonPropertyName("itemData")]
    public List<Item> ItemData { get; set; } = new();

    public class Item
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("pile")]
        public string Pile { get; set; } = "trade";
    }
}