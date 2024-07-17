using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FifaSharp.Api.Models;

public class SquadBuildingChallenges
{
    [JsonPropertyName("categories")]
    public List<Category> Categories { get; set; } = default!;

    public class Award
    {
        [JsonPropertyName("value")]
        public int Value { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; } = default!;

        [JsonPropertyName("halId")]
        public int HalId { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("isUntradeable")]
        public bool IsUntradeable { get; set; }

        [JsonPropertyName("loan")]
        public int Loan { get; set; }

        [JsonPropertyName("loanType")]
        public string LoanType { get; set; } = default!;

        [JsonPropertyName("itemData")]
        public ItemData ItemData { get; set; } = default!;
    }

    public class Category
    {
        [JsonPropertyName("categoryId")]
        public int CategoryId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        [JsonPropertyName("priority")]
        public int Priority { get; set; }

        [JsonPropertyName("sets")]
        public List<Set> Sets { get; set; } = default!;
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

        [JsonPropertyName("loansInfo")]
        public LoansInfo LoansInfo { get; set; } = default!;

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
        public int WeakFootAbilityTypCcode { get; set; }

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
        public int? Weightrare { get; set; }

        [JsonPropertyName("amount")]
        public int? Amount { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; } = default!;

        [JsonPropertyName("detaildescription")]
        public string DetailDescription { get; set; } = default!;
    }

    public class LoansInfo
    {
        [JsonPropertyName("loanType")]
        public string LoanType { get; set; } = default!;

        [JsonPropertyName("loanValue")]
        public int LoanValue { get; set; }
    }
    public class Set
    {
        [JsonPropertyName("setId")]
        public int SetId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        [JsonPropertyName("priority")]
        public int Priority { get; set; }

        [JsonPropertyName("categoryId")]
        public int CategoryId { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; } = default!;

        [JsonPropertyName("challengesCount")]
        public int ChallengesCount { get; set; }

        [JsonPropertyName("hidden")]
        public bool Hidden { get; set; }

        [JsonPropertyName("tagged")]
        public int Tagged { get; set; }

        [JsonPropertyName("endTime")]
        public int EndTime { get; set; }

        [JsonPropertyName("repeatable")]
        public bool Repeatable { get; set; }

        [JsonPropertyName("repeatabilityMode")]
        public string RepeatabilityMode { get; set; } = default!;

        [JsonPropertyName("challengesCompletedCount")]
        public int ChallengesCompletedCount { get; set; }

        [JsonPropertyName("awards")]
        public List<Award> Awards { get; set; } = default!;

        [JsonPropertyName("tutorial")]
        public bool Tutorial { get; set; }

        [JsonPropertyName("timesCompleted")]
        public int TimesCompleted { get; set; }

        [JsonPropertyName("taggedByProduction")]
        public bool TaggedByProduction { get; set; }

        [JsonPropertyName("taggedByUser")]
        public bool TaggedByUser { get; set; }

        [JsonPropertyName("setImageId")]
        public string SetImageId { get; set; } = default!;

        [JsonPropertyName("releaseTime")]
        public int ReleaseTime { get; set; }

        [JsonPropertyName("startTime")]
        public int? StartTime { get; set; }

        [JsonPropertyName("repeats")]
        public int? Repeats { get; set; }

        [JsonPropertyName("repeatRefreshInterval")]
        public int? RepeatRefreshInterval { get; set; }

        [JsonPropertyName("timesCompletedInInterval")]
        public int? TimesCompletedInInterval { get; set; }

        [JsonPropertyName("lastCompletedTime")]
        public int? LastCompletedTime { get; set; }

        [JsonPropertyName("rewardPreviewImageId")]
        public string RewardPreviewImageId { get; set; } = default!;
    }
}