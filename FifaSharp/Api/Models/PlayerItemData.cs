using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaSharp.Api.Models;

using System.Text.Json.Serialization;

public class PlayerItemData
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

    [JsonPropertyName("loansInfo")]
    public LoanInfo? LoansInfo { get; set; } = default!;

    [JsonPropertyName("loyaltyBonus")]
    public int LoyaltyBonus { get; set; }

    [JsonPropertyName("pile")]
    public int Pile { get; set; }

    [JsonPropertyName("nation")]
    public int Nation { get; set; }

    [JsonPropertyName("resourceGameYear")]
    public int ResourceGameYear { get; set; }

    [JsonPropertyName("guidAssetId")]
    public string GuidAssetId { get; set; } = default!;

    [JsonPropertyName("attributeArray")]
    public List<int> AttributeArray { get; set; } = default!;

    [JsonPropertyName("skillmoves")]
    public int SkillMoves { get; set; }

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

    [JsonPropertyName("baseTraits")]
    public List<int> BaseTraits { get; set; } = default!;

    [JsonPropertyName("iconTraits")]
    public List<int> IconTraits { get; set; } = default!;

    [JsonPropertyName("groups")]
    public List<int> Groups { get; set; } = default!;

    [JsonPropertyName("attributeList")]
    public List<object> AttributeList { get; set; } = default!;

    [JsonPropertyName("cardassetid")]
    public int? CardAssetId { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = default!;

    [JsonPropertyName("weightrare")]
    public int? WeightRare { get; set; }

    [JsonPropertyName("amount")]
    public int? Amount { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; } = default!;

    [JsonPropertyName("detaildescription")]
    public string DetailDescription { get; set; } = default!;

    [JsonPropertyName("lifetimeAssists")]
    public int? LifetimeAssists { get; set; }

    [JsonPropertyName("marketDataMinPrice")]
    public int? MarketDataMinPrice { get; set; }

    [JsonPropertyName("marketDataMaxPrice")]
    public int? MarketDataMaxPrice { get; set; }

    [JsonPropertyName("marketAverage")]
    public int? MarketAverage { get; set; }

    [JsonPropertyName("assists")]
    public int? Assists { get; set; }

    [JsonPropertyName("plusRoles")]
    public List<int> PlusRoles { get; set; } = new();

    [JsonPropertyName("plusPlusRoles")]
    public List<int>? PlusPlusRoles { get; set; }

    [JsonPropertyName("lifetimeStatsArray")]
    public List<int>? LifetimeStatsArray { get; set; }

    public class LoanInfo
    {
        [JsonPropertyName("loanType")]
        public string LoanType { get; set; } = default!;

        [JsonPropertyName("loanValue")]
        public int LoanValue { get; set; }
    }
}
