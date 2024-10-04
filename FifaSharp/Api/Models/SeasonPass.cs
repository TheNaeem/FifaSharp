using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FifaSharp.Api.Models;

public class SeasonPass
{
    [JsonPropertyName("title")]
    public string Title { get; set; } = default!;

    [JsonPropertyName("subtitle")]
    public string Subtitle { get; set; } = default!;

    [JsonPropertyName("startTime")]
    public int StartTime { get; set; }

    [JsonPropertyName("endTime")]
    public int EndTime { get; set; }

    [JsonPropertyName("serverCrtTime")]
    public int ServerCrtTime { get; set; }

    [JsonPropertyName("scmpChosenRewardDtos")]
    public List<ScmpChosenRewardDto> Rewards { get; set; } = default!;

    [JsonPropertyName("xp")]
    public int Xp { get; set; }

    public class ScmpChosenRewardDto
    {
        [JsonPropertyName("levelId")]
        public int LevelId { get; set; }

        [JsonPropertyName("chosenOption")]
        public int ChosenOption { get; set; }

        [JsonPropertyName("state")]
        public int State { get; set; }

        [JsonPropertyName("xpThreshold")]
        public int XpThreshold { get; set; }

        [JsonPropertyName("rewardOptionList")]
        public List<RewardOptionList> RewardOptionList { get; set; } = default!;
    }

    public class Award
    {
        [JsonPropertyName("untradeable")]
        public bool Untradeable { get; set; }

        [JsonPropertyName("awardId")]
        public int AwardId { get; set; }

        [JsonPropertyName("halId")]
        public int HalId { get; set; }

        [JsonPropertyName("awardType")]
        public string AwardType { get; set; } = default!;

        [JsonPropertyName("awardValue")]
        public int AwardValue { get; set; }

        [JsonPropertyName("awardCount")]
        public int AwardCount { get; set; }

        [JsonPropertyName("loan")]
        public int? Loan { get; set; }

        [JsonPropertyName("loanType")]
        public string LoanType { get; set; } = default!;

        [JsonPropertyName("itemData")]
        public ItemData ItemData { get; set; } = default!;
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
        public int Cardassetid { get; set; }

        [JsonPropertyName("value")]
        public int Value { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        [JsonPropertyName("description")]
        public string Description { get; set; } = default!;

        [JsonPropertyName("attributeArray")]
        public List<int> AttributeArray { get; set; } = default!;

        [JsonPropertyName("authenticity")]
        public bool Authenticity { get; set; }

        [JsonPropertyName("showCasePriority")]
        public int ShowCasePriority { get; set; }

        [JsonPropertyName("category")]
        public int? Category { get; set; }

        [JsonPropertyName("weightrare")]
        public int? Weightrare { get; set; }

        [JsonPropertyName("header")]
        public string Header { get; set; } = default!;

        [JsonPropertyName("biodescription")]
        public string BioDescription { get; set; } = default!;

        [JsonPropertyName("chantsCount")]
        public int? ChantsCount { get; set; }

        [JsonPropertyName("injuryType")]
        public string InjuryType { get; set; } = default!;

        [JsonPropertyName("injuryGames")]
        public int? InjuryGames { get; set; }

        [JsonPropertyName("preferredPosition")]
        public string PreferredPosition { get; set; } = default!;

        [JsonPropertyName("contract")]
        public int? Contract { get; set; }

        [JsonPropertyName("playStyle")]
        public int? PlayStyle { get; set; }

        [JsonPropertyName("nation")]
        public int? Nation { get; set; }

        [JsonPropertyName("guidAssetId")]
        public string GuidAssetId { get; set; } = default!;

        [JsonPropertyName("groups")]
        public List<int> Groups { get; set; } = default!;

        [JsonPropertyName("skillmoves")]
        public int? SkillMoves { get; set; }

        [JsonPropertyName("weakfootabilitytypecode")]
        public int? WeakFootAbilityTypeCode { get; set; }

        [JsonPropertyName("attackingworkrate")]
        public int? AttackingWorkRate { get; set; }

        [JsonPropertyName("defensiveworkrate")]
        public int? DefensiveWorkRate { get; set; }

        [JsonPropertyName("preferredfoot")]
        public int? PreferredFoot { get; set; }

        [JsonPropertyName("possiblePositions")]
        public List<string> PossiblePositions { get; set; } = default!;

        [JsonPropertyName("gender")]
        public int? Gender { get; set; }

        [JsonPropertyName("baseTraits")]
        public List<int> BaseTraits { get; set; } = default!;

        [JsonPropertyName("iconTraits")]
        public List<int> IconTraits { get; set; } = default!;
    }

    public class RewardOptionList
    {
        [JsonPropertyName("optionId")]
        public int OptionId { get; set; }

        [JsonPropertyName("hiddenReward")]
        public bool HiddenReward { get; set; }

        [JsonPropertyName("defaultOption")]
        public bool DefaultOption { get; set; }

        [JsonPropertyName("awards")]
        public List<Award> Awards { get; set; } = default!;

        [JsonPropertyName("rewardTile")]
        public string RewardTile { get; set; } = default!;
    }
}
