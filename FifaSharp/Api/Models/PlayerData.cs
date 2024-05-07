using System.Text.Json.Serialization;

namespace FifaSharp.Api.Models;

public class PlayerData
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
    public int QuickSellValue { get; set; }

    [JsonPropertyName("itemState")]
    public string ItemState { get; set; } = default!;

    [JsonPropertyName("cardsubtypeid")]
    public int CardSubtypeId { get; set; }

    [JsonPropertyName("lastSalePrice")]
    public int LastSalePrice { get; set; }

    [JsonPropertyName("statsList")]
    public object[] StatsList { get; set; } = default!; // TODO:

    [JsonPropertyName("lifetimeStats")]
    public object[] LifetimeStats { get; set; } = default!;

    [JsonPropertyName("attributeList")]
    public object[] AttributeList { get; set; } = default!;

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

    [JsonPropertyName("weightrare")]
    public int WeightRare { get; set; }

    [JsonPropertyName("amount")]
    public int Amount { get; set; }

    [JsonPropertyName("marketDataMinPrice")]
    public int MarketDataMinPrice { get; set; }

    [JsonPropertyName("marketDataMaxPrice")]
    public int MarketDataMaxPrice { get; set; }

    [JsonPropertyName("resourceGameYear")]
    public int ResourceGameYear { get; set; }

    [JsonPropertyName("bronze")]
    public int Bronze { get; set; }

    [JsonPropertyName("silver")]
    public int Silver { get; set; }

    [JsonPropertyName("gold")]
    public int Gold { get; set; }

    [JsonPropertyName("injuryType")]
    public string InjuryType { get; set; } = default!;

    [JsonPropertyName("injuryGames")]
    public int InjuryGames { get; set; }

    [JsonPropertyName("preferredPosition")]
    public string PreferredPosition { get; set; } = default!;

    [JsonPropertyName("contract")]
    public int Contract { get; set; }

    [JsonPropertyName("playStyle")]
    public int PlayStyle { get; set; }

    [JsonPropertyName("assists")]
    public int Assists { get; set; }

    [JsonPropertyName("lifetimeAssists")]
    public int LifetimeAssists { get; set; }

    [JsonPropertyName("LoyaltyBonus")]
    public int LoyaltyBonus { get; set; }

    [JsonPropertyName("nation")]
    public int Nation { get; set; }

    [JsonPropertyName("attributeArray")]
    public int[] AttributeArray { get; set; } = default!;

    [JsonPropertyName("statsArray")]
    public int[] StatsArray { get; set; } = default!;

    [JsonPropertyName("lifetimeStatsArray")]
    public int[] LifetimeStatsArray { get; set; } = default!;

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
    public string[] PossiblePositions { get; set; } = default!;

    [JsonPropertyName("guidAssetId")]
    public string GuidAssetId { get; set; } = default!;

    [JsonPropertyName("groups")]
    public int[] Groups { get; set; } = default!;
}
