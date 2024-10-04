using FifaSharp.Api.Enums;
using System.Collections.Generic;
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

        [JsonPropertyName("guidAssetId")]
        public string? GuidAssetId { get; set; }
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
        public int CardSubtypeId { get; set; }

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

        [JsonPropertyName("pile")]
        public int Pile { get; set; }

        [JsonPropertyName("nation")]
        public int Nation { get; set; }

        [JsonPropertyName("guidAssetId")]
        public string GuidAssetId { get; set; } = default!;

        [JsonPropertyName("groups")]
        public List<int> Groups { get; set; } = default!;

        [JsonPropertyName("attributeArray")]
        public List<int> AttributeArray { get; set; } = default!;

        [JsonPropertyName("skillmoves")]
        public int SkillMoves { get; set; }

        [JsonPropertyName("weakfootabilitytypecode")]
        public int WeakFootAbilityTypeCode { get; set; }

        [JsonPropertyName("attackingworkrate")]
        public int AttackingWorkrate { get; set; }

        [JsonPropertyName("defensiveworkrate")]
        public int DefensiveWorkrate { get; set; }

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
    }

    public class AcademyBonus
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("totalBonus")]
        public int TotalBonus { get; set; }

        [JsonPropertyName("stringValue")]
        public string? StringValue { get; set; }
    }

    /// <summary>
    /// Evolution stages
    /// </summary>
    public class AcademyBonusesPerLevel
    {
        [JsonPropertyName("0")]
        public List<AcademyBonus>? EvoStart { get; set; }

        [JsonPropertyName("1")]
        public List<AcademyBonus>? FirstLevel { get; set; }

        [JsonPropertyName("2")]
        public List<AcademyBonus>? SecondLevel { get; set; }

        [JsonPropertyName("3")]
        public List<AcademyBonus>? ThirdLevel { get; set; }
    }

    public class RandomPlayerPreview
    {
        [JsonPropertyName("itemData")]
        public ItemData ItemData { get; set; } = default!;

        [JsonPropertyName("academyBonusesPerLevel")]
        public AcademyBonusesPerLevel AcademyBonusesPerLevel { get; set; } = default!;
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

        public List<EvoRequirement> GetRequirements()
        {
            List<EvoRequirement> ret = new();

            EvoRequirement curr = new();

            foreach (var req in ElgReqs)
            {
                switch (req.Type)
                {
                    case "PLAYER_ATTRIBUTE":
                        curr.Attr = (AcademyEligibilityAttribute)req.EligibilityValue;
                        break;
                    case "SCOPE":
                        curr.Scope = req.EligibilityValue;
                        break;
                    case "ACADEMY_PLAYER_SLOTTING":
                        curr.Value = req.EligibilityValue;
                        ret.Add(curr);
                        curr = new();
                        break;
                }
            }

            return ret;
        }
    }
}
