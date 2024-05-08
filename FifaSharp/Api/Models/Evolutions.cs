using System.Text.Json.Serialization;

namespace FifaSharp.Api.Models;

public class Evolutions
{
    [JsonPropertyName("activeSlotsCount")]
    public int ActiveSlotsCount { get; set; }

    [JsonPropertyName("inactiveSlotsCount")]
    public int InactiveSlotsCount { get; set; }

    [JsonPropertyName("availableSlotsCount")]
    public int AvailableSlotsCount { get; set; }

    [JsonPropertyName("slots")]
    public List<Slot> Slots { get; set; } = default!;

    [JsonPropertyName("extraNotificationSlots")]
    public List<object> ExtraNotificationSlots { get; set; } = default!;

    public class AcademyTopReward
    {
        [JsonPropertyName("value")]
        public int Value { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }
    }

    public class Award
    {
        [JsonPropertyName("value")]
        public int Value { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }
    }

    public class Currency
    {
        [JsonPropertyName("funds")]
        public int Funds { get; set; }

        [JsonPropertyName("finalFunds")]
        public int FinalFunds { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;
    }

    public class ElgReq
    {
        [JsonPropertyName("type")]
        public string Type { get; set; } = default!;

        [JsonPropertyName("eligibilitySlot")]
        public int EligibilitySlot { get; set; }

        [JsonPropertyName("eligibilityKey")]
        public int EligibilityKey { get; set; }

        [JsonPropertyName("eligibilityValue")]
        public int EligibilityValue { get; set; }
    }

    public class Level
    {
        [JsonPropertyName("level")]
        public int LevelNum { get; set; }

        [JsonPropertyName("levelState")]
        public string LevelState { get; set; } = default!;

        [JsonPropertyName("awards")]
        public List<Award> Awards { get; set; } = default!;

        [JsonPropertyName("objectives")]
        public List<Objective> Objectives { get; set; } = default!;
    }

    public class Objective
    {
        [JsonPropertyName("objectiveId")]
        public int ObjectiveId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        [JsonPropertyName("description")]
        public string Description { get; set; } = default!;

        [JsonPropertyName("takeMeThereLink")]
        public string TakeMeThereLink { get; set; } = default!;

        [JsonPropertyName("gameArea")]
        public int GameArea { get; set; }

        [JsonPropertyName("isWeb")]
        public bool IsWeb { get; set; }

        [JsonPropertyName("multiplier")]
        public int Multiplier { get; set; }

        [JsonPropertyName("priority")]
        public int Priority { get; set; }
    }

    public class RandomPlayerPreview
    {
        [JsonPropertyName("itemData")]
        public PlayerData ItemData { get; set; } = default!;

        [JsonPropertyName("academyBonusesPerLevel")]
        public object AcademyBonusesPerLevel { get; set; } = default!;
    }

    public class Slot
    {
        [JsonPropertyName("slotImage")]
        public string SlotImage { get; set; } = default!;

        [JsonPropertyName("slotName")]
        public string SlotName { get; set; } = default!;

        [JsonPropertyName("slotDescription")]
        public string SlotDescription { get; set; } = default!;

        [JsonPropertyName("endTime")]
        public int EndTime { get; set; }

        [JsonPropertyName("endTimePurchaseVisibility")]
        public int EndTimePurchaseVisibility { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; } = default!;

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("elgReqs")]
        public List<ElgReq> ElgReqs { get; set; } = default!;

        [JsonPropertyName("levels")]
        public List<Level> Levels { get; set; } = default!;

        [JsonPropertyName("currencies")]
        public List<Currency> Currencies { get; set; } = default!;

        [JsonPropertyName("randomPlayerPreview")]
        public RandomPlayerPreview RandomPlayerPreview { get; set; } = default!;

        [JsonPropertyName("rewardsDisplayTopCount")]
        public int RewardsDisplayTopCount { get; set; }

        [JsonPropertyName("totalRewardsCount")]
        public int TotalRewardsCount { get; set; }

        [JsonPropertyName("academyTopRewards")]
        public List<AcademyTopReward> AcademyTopRewards { get; set; } = default!;

        [JsonPropertyName("categoryId")]
        public int CategoryId { get; set; }
    }
}