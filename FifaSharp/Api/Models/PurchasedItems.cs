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
    public List<ItemData> Items { get; set; } = default!;

    [JsonPropertyName("duplicateItemIdList")]
    public List<DuplicateItemIdList> DuplicateItems { get; set; } = default!;

    public class DuplicateItemIdList
    {
        [JsonPropertyName("itemId")]
        public int ItemId { get; set; }

        [JsonPropertyName("duplicateItemId")]
        public long DuplicateItemId { get; set; }
    }

    public class ItemData
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

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

        [JsonPropertyName("cardsubtypeid")]
        public int CardSubTypeId { get; set; }

        [JsonPropertyName("lastSalePrice")]
        public int LastSalePrice { get; set; }

        [JsonPropertyName("injuryType")]
        public string InjuryType { get; set; } = default!;

        [JsonPropertyName("injuryGames")]
        public int InjuryGames { get; set; }

        [JsonPropertyName("preferredPosition")]
        public string PreferredPosition { get; set; } = default!;

        [JsonPropertyName("statsList")]
        public List<object> StatsList { get; set; } = default!;

        [JsonPropertyName("lifetimeStats")]
        public List<object> LifetimeStats { get; set; } = default!;

        [JsonPropertyName("contract")]
        public int Contract { get; set; }

        [JsonPropertyName("teamid")]
        public int TeamId { get; set; }

        [JsonPropertyName("rareflag")]
        public int RareFlag { get; set; }

        [JsonPropertyName("playStyle")]
        public int PlayStyle { get; set; }

        [JsonPropertyName("leagueId")]
        public int LeagueId { get; set; }

        [JsonPropertyName("loyaltyBonus")]
        public int LoyaltyBonus { get; set; }

        [JsonPropertyName("pile")]
        public int Pile { get; set; }

        [JsonPropertyName("nation")]
        public int Nation { get; set; }

        [JsonPropertyName("resourceGameYear")]
        public int ResourceGameYear { get; set; }

        [JsonPropertyName("groups")]
        public List<int> Groups { get; set; } = default!;

        [JsonPropertyName("attributeArray")]
        public List<int> AttributeArray { get; set; } = default!;

        [JsonPropertyName("skillmoves")]
        public int Skillmoves { get; set; }

        [JsonPropertyName("weakfootabilitytypecode")]
        public int WeakFootAbilityTypeCode { get; set; }

        [JsonPropertyName("attackingworkrate")]
        public int AttackingWorkRate { get; set; }

        [JsonPropertyName("defensiveworkrate")]
        public int DefensiveWorkRate { get; set; }

        [JsonPropertyName("preferredfoot")]
        public int PreferredFoot { get; set; }

        [JsonPropertyName("possiblePositions")]
        public List<string> PossiblePositions { get; set; } = default!;

        [JsonPropertyName("gender")]
        public int Gender { get; set; }

        [JsonPropertyName("guidAssetId")]
        public string GuidAssetId { get; set; } = default!;

        [JsonPropertyName("baseTraits")]
        public List<int> BaseTraits { get; set; } = default!;

        [JsonPropertyName("iconTraits")]
        public List<int> IconTraits { get; set; } = default!;
    }
}



