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
        public PlayerItemData ItemData { get; set; } = default!;
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