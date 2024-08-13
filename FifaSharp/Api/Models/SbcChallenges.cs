using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FifaSharp.Api.Models;

public class SbcChallenges
{
    [JsonPropertyName("challenges")]
    public List<Challenge> Challenges { get; set; } = default!;

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

    public class Challenge
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        [JsonPropertyName("priority")]
        public int Priority { get; set; } 

        [JsonPropertyName("status")]
        public string Status { get; set; } = default!;

        [JsonPropertyName("setId")]
        public int SetId { get; set; } 

        [JsonPropertyName("description")]
        public string Description { get; set; } = default!;

        [JsonPropertyName("challengeId")]
        public int ChallengeId { get; set; } 

        [JsonPropertyName("endTime")]
        public int EndTime { get; set; } 

        [JsonPropertyName("repeatable")]
        public bool Repeatable { get; set; } 

        [JsonPropertyName("formation")]
        public string Formation { get; set; } = default!;

        [JsonPropertyName("timesCompleted")]
        public int TimesCompleted { get; set; }

        [JsonPropertyName("elgReq")]
        public List<ElgReq> ElgReq { get; set; } = default!;

        [JsonPropertyName("elgDesc")]
        public List<object> ElgDesc { get; set; } = default!;

        [JsonPropertyName("awards")]
        public List<Award> Awards { get; set; } = default!;

        [JsonPropertyName("elgOperation")]
        public string ElgOperation { get; set; } = default!;

        [JsonPropertyName("tutorial")]
        public int Tutorial { get; set; } 

        [JsonPropertyName("type")]
        public string Type { get; set; } = default!;

        [JsonPropertyName("lastCompleteTime")]
        public int LastCompleteTime { get; set; } 

        [JsonPropertyName("challengeImageId")]
        public string ChallengeImageId { get; set; } = default!;
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
        public int Rareflag { get; set; } 

        [JsonPropertyName("playStyle")]
        public int PlayStyle { get; set; } 

        [JsonPropertyName("leagueId")]
        public int LeagueId { get; set; } 

        [JsonPropertyName("loans")]
        public int Loans { get; set; }

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
    }

    public class LoansInfo
    {
        [JsonPropertyName("loanType")]
        public string LoanType { get; set; } = default!;

        [JsonPropertyName("loanValue")]
        public int LoanValue { get; set; } 
    }
}
