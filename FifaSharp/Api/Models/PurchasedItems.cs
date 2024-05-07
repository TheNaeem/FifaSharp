using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FifaSharp.Api.Models;


public class PurchasedItems
{
    [JsonPropertyName("itemData")]
    public Itemdata[] Items { get; set; }

    [JsonPropertyName("duplicateItemIdList")]
    public DuplicateItem[] DuplicateItemIdList { get; set; }

    public class Itemdata
    {
        public long id { get; set; }
        public int timestamp { get; set; }
        public string formation { get; set; }
        public bool untradeable { get; set; }
        public int assetId { get; set; }
        public int rating { get; set; }
        public string itemType { get; set; }
        public int resourceId { get; set; }
        public int owners { get; set; }
        public int discardValue { get; set; }
        public string itemState { get; set; }
        public int cardsubtypeid { get; set; }
        public int lastSalePrice { get; set; }
        public string injuryType { get; set; }
        public int injuryGames { get; set; }
        public string preferredPosition { get; set; }
        public int contract { get; set; }
        public int teamid { get; set; }
        public int rareflag { get; set; }
        public int playStyle { get; set; }
        public int leagueId { get; set; }
        public int assists { get; set; }
        public int lifetimeAssists { get; set; }
        public int loyaltyBonus { get; set; }
        public int pile { get; set; }
        public int nation { get; set; }
        public int marketDataMinPrice { get; set; }
        public int marketDataMaxPrice { get; set; }
        public int resourceGameYear { get; set; }
        public string guidAssetId { get; set; }
        public int[] groups { get; set; }
        public int[] attributeArray { get; set; }
        public int[] statsArray { get; set; }
        public int[] lifetimeStatsArray { get; set; }
        public int skillmoves { get; set; }
        public int weakfootabilitytypecode { get; set; }
        public int attackingworkrate { get; set; }
        public int defensiveworkrate { get; set; }
        public int preferredfoot { get; set; }
        public string[] possiblePositions { get; set; }
    }

    public class DuplicateItem
    {
        public long itemId { get; set; }
        public long duplicateItemId { get; set; }
    }
}

