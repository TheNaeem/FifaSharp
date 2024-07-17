using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FifaSharp.Api.Models;

public class ObjectiveGroups
{
    [JsonPropertyName("categoryId")]
    public int CategoryId { get; set; }

    [JsonPropertyName("priority")]
    public int Priority { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = default!;

    [JsonPropertyName("groupsList")]
    public List<GroupsList> Objectives { get; set; } = default!;

    [JsonPropertyName("type")]
    public int Type { get; set; }

    public class Award
    {
        [JsonPropertyName("value")]
        public int Value { get; set; }

        [JsonPropertyName("untradeable")]
        public bool Untradeable { get; set; }

        [JsonPropertyName("halId")]
        public int HalId { get; set; }

        [JsonPropertyName("awardType")]
        public string AwardType { get; set; } = default!;

        [JsonPropertyName("assetId")]
        public int AssetId { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("setId")]
        public int SetId { get; set; }

        [JsonPropertyName("itemData")]
        public object ItemData { get; set; } = default!;

        [JsonPropertyName("itemDataReduced")]
        public ItemDataReduced? ReducedItemData { get; set; }
    }

    public class GroupsList
    {
        [JsonPropertyName("groupId")]
        public int GroupId { get; set; }

        [JsonPropertyName("startTime")]
        public int StartTime { get; set; }

        [JsonPropertyName("endTime")]
        public int EndTime { get; set; }

        [JsonPropertyName("priority")]
        public int Priority { get; set; }

        [JsonPropertyName("visibilityTime")]
        public int VisibilityTime { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; } = default!;

        [JsonPropertyName("subTitle")]
        public string SubTitle { get; set; } = default!;

        [JsonPropertyName("groupType")]
        public int GroupType { get; set; }

        [JsonPropertyName("timesCompleted")]
        public int timesCompleted { get; set; }

        [JsonPropertyName("repeatabilityMode")]
        public string RepeatabilityMode { get; set; } = default!;

        [JsonPropertyName("groupState")]
        public int GroupState { get; set; }

        [JsonPropertyName("awardsList")]
        public List<Award> AwardsList { get; set; } = default!;

        [JsonPropertyName("objectives")]
        public List<Objective> Objectives { get; set; } = default!;

        [JsonPropertyName("guidAssetId")]
        public string GuidAssetId { get; set; } = default!;

        [JsonPropertyName("tileEnabled")]
        public bool TileEnabled { get; set; }

        [JsonPropertyName("headerAssetExists")]
        public bool HeaderAssetExists { get; set; }

        [JsonPropertyName("backgroundAssetExists")]
        public bool BackgroundAssetExists { get; set; }

        [JsonPropertyName("tileAssetExists")]
        public bool TileAssetExists { get; set; }

        [JsonPropertyName("repeats")]
        public int? Repeats { get; set; }

        [JsonPropertyName("refreshInterval")]
        public int? RefreshInterval { get; set; }
    }

    public class ItemDataReduced
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

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

        [JsonPropertyName("discardValue")]
        public int DiscardValue { get; set; }

        [JsonPropertyName("cardsubtypeid")]
        public int CardSubtypeId { get; set; }

        [JsonPropertyName("attributeList")]
        public List<object> AttributeList { get; set; } = default!;

        [JsonPropertyName("attributeArray")]
        public List<int> AttributeArray { get; set; } = default!;

        [JsonPropertyName("teamId")]
        public int TeamId { get; set; }

        [JsonPropertyName("rareflag")]
        public int RareFlag { get; set; }

        [JsonPropertyName("leagueId")]
        public int LeagueId { get; set; }

        [JsonPropertyName("cardassetid")]
        public int CardAssetId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        [JsonPropertyName("authenticity")]
        public bool Authenticity { get; set; }

        [JsonPropertyName("preferredPosition")]
        public string PreferredPosition { get; set; } = default!;

        [JsonPropertyName("nation")]
        public int? Nation { get; set; }

        [JsonPropertyName("guidAssetId")]
        public string GuidAssetId { get; set; } = default!;

        [JsonPropertyName("skillmoves")]
        public int? SkillMoves { get; set; }

        [JsonPropertyName("weakfootabilitytypecode")]
        public int? WeakFootAbilityTypeCode { get; set; }

        [JsonPropertyName("possiblePositions")]
        public List<string> PossiblePositions { get; set; } = default!;

        [JsonPropertyName("loans")]
        public int? Loans { get; set; }

        [JsonPropertyName("loansInfo")]
        public LoansInfo? LoansInfo { get; set; } = default!;

        [JsonPropertyName("amount")]
        public int? Amount { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; } = default!;

        [JsonPropertyName("category")]
        public int? Category { get; set; }

        [JsonPropertyName("rankId")]
        public int? RankId { get; set; }
    }

    public class LoansInfo
    {
        [JsonPropertyName("loanType")]
        public string LoanType { get; set; } = default!;

        [JsonPropertyName("loanValue")]
        public int LoanValue { get; set; }
    }

    public class Objective
    {
        [JsonPropertyName("objectiveId")]
        public int ObjectiveId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        [JsonPropertyName("description")]
        public string Description { get; set; } = default!;

        [JsonPropertyName("shortDescription")]
        public string ShortDescription { get; set; } = default!;

        [JsonPropertyName("imageBase")]
        public string ImageBase { get; set; } = default!;

        [JsonPropertyName("takeMeThereLink")]
        public string TakeMeThereLink { get; set; } = default!;

        [JsonPropertyName("isWeb")]
        public bool IsWeb { get; set; }

        [JsonPropertyName("awards")]
        public List<Award> Awards { get; set; } = default!;

        [JsonPropertyName("state")]
        public string State { get; set; } = default!;

        [JsonPropertyName("currentProgress")]
        public int CurrentProgress { get; set; }

        [JsonPropertyName("multiplier")]
        public int Multiplier { get; set; }

        [JsonPropertyName("priority")]
        public int Priority { get; set; }
    }
}


