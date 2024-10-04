using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FifaSharp.Api.Models;

public class UnassignedItems
{
    [JsonPropertyName("itemData")]
    public List<ItemData> Items { get; set; } = default!;

    public class ItemData
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("timestamp")]
        public int Timestamp { get; set; }

        [JsonPropertyName("formation")]
        public string Formation { get; set; } = default!;

        [JsonPropertyName("untradeable")]
        public bool Untradeable { get; set; }

        [JsonPropertyName("assetId")]
        public int AssetId { get; set; }

        [JsonPropertyName("rating")]
        public int Rating { get; set; }

        [JsonPropertyName("itemType")]
        public string ItemType { get; set; } = default!;

        [JsonPropertyName("resourceId")]
        public int ResourceId { get; set; }

        [JsonPropertyName("owners")]
        public int Owners { get; set; }

        [JsonPropertyName("discardValue")]
        public int DiscardValue { get; set; }

        [JsonPropertyName("itemState")]
        public string ItemState { get; set; } = default!;

        [JsonPropertyName("cardsubtypeid")]
        public int Cardsubtypeid { get; set; }

        [JsonPropertyName("lastSalePrice")]
        public int LastSalePrice { get; set; }

        [JsonPropertyName("statsList")]
        public List<object> StatsList { get; set; } = default!;

        [JsonPropertyName("lifetimeStats")]
        public List<object> LifetimeStats { get; set; } = default!;

        [JsonPropertyName("attributeList")]
        public List<object> AttributeList { get; set; } = default!;

        [JsonPropertyName("teamid")]
        public int TeamId { get; set; }

        [JsonPropertyName("rareflag")]
        public int RareFlag { get; set; }

        [JsonPropertyName("leagueId")]
        public int LeagueId { get; set; }

        [JsonPropertyName("pile")]
        public int Pile { get; set; }

        [JsonPropertyName("cardassetid")]
        public int CardAssetId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        [JsonPropertyName("weightrare")]
        public int WeightRare { get; set; }

        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; } = default!;

        [JsonPropertyName("detaildescription")]
        public string DetailDescription { get; set; } = default!;

        [JsonPropertyName("marketDataMinPrice")]
        public int MarketDataMinPrice { get; set; }

        [JsonPropertyName("marketDataMaxPrice")]
        public int MarketDataMaxPrice { get; set; }

        [JsonPropertyName("resourceGameYear")]
        public int ResourceGameYear { get; set; }
    }
}


