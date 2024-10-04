using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FifaSharp.Api.Models;

public class FutSquad
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("valid")]
    public bool Valid { get; set; }

    [JsonPropertyName("personaId")]
    public int? PersonaId { get; set; }

    [JsonPropertyName("formation")]
    public string Formation { get; set; } = default!;

    [JsonPropertyName("rating")]
    public object Rating { get; set; } = default!;

    [JsonPropertyName("chemistry")]
    public int Chemistry { get; set; }

    [JsonPropertyName("manager")]
    public List<Manager> ManagerData { get; set; } = default!;

    [JsonPropertyName("players")]
    public List<Player> Players { get; set; } = default!;

    [JsonPropertyName("dreamSquad")]
    public bool DreamSquad { get; set; }

    [JsonPropertyName("changed")]
    public int? Changed { get; set; }

    [JsonPropertyName("squadName")]
    public string SquadName { get; set; } = default!;

    [JsonPropertyName("starRating")]
    public int StarRating { get; set; }

    [JsonPropertyName("captain")]
    public long Captain { get; set; }

    [JsonPropertyName("kicktakers")]
    public List<Kicktaker> KickTakers { get; set; } = default!;

    [JsonPropertyName("actives")]
    public List<ActiveTeam> Actives { get; set; } = default!;

    [JsonPropertyName("newSquad")]
    public object NewSquad { get; set; } = default!;

    [JsonPropertyName("squadType")]
    public string SquadType { get; set; } = default!;

    [JsonPropertyName("custom")]
    public object Custom { get; set; } = default!;

    [JsonPropertyName("tactics")]
    public List<Tactic> Tactics { get; set; } = default!;

    public class ActiveTeam
    {
        [JsonPropertyName("id")]
        public object Id { get; set; } = default!;

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

        [JsonPropertyName("itemState")]
        public string ItemState { get; set; } = default!;

        [JsonPropertyName("cardsubtypeid")]
        public int CardSubtypeId { get; set; }

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

        [JsonPropertyName("category")]
        public int Category { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        [JsonPropertyName("description")]
        public string Description { get; set; } = default!;

        [JsonPropertyName("biodescription")]
        public string BioDescription { get; set; } = default!;

        [JsonPropertyName("stadiumid")]
        public int StadiumId { get; set; }

        [JsonPropertyName("capacity")]
        public int Capacity { get; set; }

        [JsonPropertyName("resourceGameYear")]
        public int ResourceGameYear { get; set; }

        [JsonPropertyName("tifoSupportType")]
        public int TifoSupportType { get; set; }

        [JsonPropertyName("tifoRestricted")]
        public bool TifoRestricted { get; set; }

        [JsonPropertyName("bannerRestricted")]
        public bool BannerRestricted { get; set; }

        [JsonPropertyName("ballRestricted")]
        public bool BallRestricted { get; set; }

        [JsonPropertyName("preferredTime1")]
        public int PreferredTime1 { get; set; }

        [JsonPropertyName("preferredTime2")]
        public int PreferredTime2 { get; set; }

        [JsonPropertyName("preferredWeather")]
        public int PreferredWeather { get; set; }

        [JsonPropertyName("undiscardable")]
        public bool Undiscardable { get; set; }

        [JsonPropertyName("tier")]
        public int Tier { get; set; }

        [JsonPropertyName("myStadium")]
        public bool MyStadium { get; set; }

        [JsonPropertyName("value")]
        public int? Value { get; set; }

        [JsonPropertyName("weightrare")]
        public int? Weightrare { get; set; }

        [JsonPropertyName("header")]
        public string Header { get; set; } = default!;

        [JsonPropertyName("chantsCount")]
        public int? ChantsCount { get; set; }

        [JsonPropertyName("attributeArray")]
        public List<int> AttributeArray { get; set; } = default!;

        [JsonPropertyName("authenticity")]
        public bool? Authenticity { get; set; }

        [JsonPropertyName("showCasePriority")]
        public int? ShowCasePriority { get; set; }

        [JsonPropertyName("manufacturer")]
        public string Manufacturer { get; set; } = default!;

        [JsonPropertyName("year")]
        public int? Year { get; set; }

        [JsonPropertyName("isPlatformSpecific")]
        public bool? IsPlatformSpecific { get; set; }
    }

    public class Instruction
    {
        [JsonPropertyName("index")]
        public int Index { get; set; }

        [JsonPropertyName("value")]
        public int Value { get; set; }
    }

    public class ItemData
    {
        [JsonPropertyName("id")]
        public object Id { get; set; } = default!;

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

        [JsonPropertyName("itemState")]
        public string ItemState { get; set; } = default!;

        [JsonPropertyName("cardsubtypeid")]
        public int Cardsubtypeid { get; set; }

        [JsonPropertyName("lastSalePrice")]
        public int LastSalePrice { get; set; }

        [JsonPropertyName("injuryType")]
        public string InjuryType { get; set; } = default!;

        [JsonPropertyName("injuryGames")]
        public int InjuryGames { get; set; }

        [JsonPropertyName("preferredPosition")]
        public string PreferredPosition { get; set; } = default!;

        [JsonPropertyName("contract")]
        public int Contract { get; set; }

        [JsonPropertyName("teamid")]
        public int Teamid { get; set; }

        [JsonPropertyName("rareflag")]
        public int Rareflag { get; set; }

        [JsonPropertyName("playStyle")]
        public int PlayStyle { get; set; }

        [JsonPropertyName("leagueId")]
        public int LeagueId { get; set; }

        [JsonPropertyName("assists")]
        public int Assists { get; set; }

        [JsonPropertyName("lifetimeAssists")]
        public int LifetimeAssists { get; set; }

        [JsonPropertyName("loyaltyBonus")]
        public int LoyaltyBonus { get; set; }

        [JsonPropertyName("pile")]
        public int Pile { get; set; }

        [JsonPropertyName("nation")]
        public int Nation { get; set; }

        [JsonPropertyName("marketDataMinPrice")]
        public int MarketDataMinPrice { get; set; }

        [JsonPropertyName("marketDataMaxPrice")]
        public int MarketDataMaxPrice { get; set; }

        [JsonPropertyName("resourceGameYear")]
        public int ResourceGameYear { get; set; }

        [JsonPropertyName("guidAssetId")]
        public string GuidAssetId { get; set; } = default!;

        [JsonPropertyName("groups")]
        public List<int> Groups { get; set; } = default!;

        [JsonPropertyName("attributeArray")]
        public List<int> AttributeArray { get; set; } = default!;

        [JsonPropertyName("statsArray")]
        public List<int> StatsArray { get; set; } = default!;

        [JsonPropertyName("lifetimeStatsArray")]
        public List<int> LifetimeStatsArray { get; set; } = default!;

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

        [JsonPropertyName("dream")]
        public bool? Dream { get; set; }

        [JsonPropertyName("statsList")]
        public List<object> StatsList { get; set; } = default!;

        [JsonPropertyName("lifetimeStats")]
        public List<object> LifetimeStats { get; set; } = default!;

        [JsonPropertyName("morale")]
        public int? Morale { get; set; }

        [JsonPropertyName("fitness")]
        public int? Fitness { get; set; }

        [JsonPropertyName("training")]
        public int? Training { get; set; }

        [JsonPropertyName("suspension")]
        public int? Suspension { get; set; }

        [JsonPropertyName("attributeList")]
        public List<object> AttributeList { get; set; } = default!;
    }

    public class Kicktaker
    {
        [JsonPropertyName("id")]
        public object Id { get; set; } = default!;

        [JsonPropertyName("index")]
        public int Index { get; set; }
    }

    public class Manager
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

        [JsonPropertyName("itemState")]
        public string ItemState { get; set; } = default!;

        [JsonPropertyName("cardsubtypeid")]
        public int Cardsubtypeid { get; set; }

        [JsonPropertyName("lastSalePrice")]
        public int LastSalePrice { get; set; }

        [JsonPropertyName("statsList")]
        public List<object> StatsList { get; set; } = default!;

        [JsonPropertyName("lifetimeStats")]
        public List<object> LifetimeStats { get; set; } = default!;

        [JsonPropertyName("contract")]
        public int Contract { get; set; }

        [JsonPropertyName("attributeList")]
        public List<object> AttributeList { get; set; } = default!;

        [JsonPropertyName("teamid")]
        public int Teamid { get; set; }

        [JsonPropertyName("rareflag")]
        public int Rareflag { get; set; }

        [JsonPropertyName("leagueId")]
        public int LeagueId { get; set; }

        [JsonPropertyName("pile")]
        public int Pile { get; set; }

        [JsonPropertyName("nation")]
        public int Nation { get; set; }

        [JsonPropertyName("firstName")]
        public string FirstName { get; set; } = default!;

        [JsonPropertyName("lastName")]
        public string LastName { get; set; } = default!;

        [JsonPropertyName("negotiation")]
        public int Negotiation { get; set; }

        [JsonPropertyName("resourceGameYear")]
        public int ResourceGameYear { get; set; }

        [JsonPropertyName("gender")]
        public int Gender { get; set; }

        [JsonPropertyName("itemPronoun")]
        public int ItemPronoun { get; set; }
    }

    public class Player
    {
        [JsonPropertyName("index")]
        public int Index { get; set; }

        [JsonPropertyName("itemData")]
        public ItemData ItemData { get; set; } = default!;

        [JsonPropertyName("loyaltyBonus")]
        public int LoyaltyBonus { get; set; }

        [JsonPropertyName("kitNumber")]
        public int KitNumber { get; set; }

        [JsonPropertyName("chemistry")]
        public int Chemistry { get; set; }

        [JsonPropertyName("rank")]
        public int? Rank { get; set; }
    }

    public class Position
    {
        [JsonPropertyName("index")]
        public int Index { get; set; }

        [JsonPropertyName("value")]
        public int Value { get; set; }
    }

    public class Style
    {
        [JsonPropertyName("index")]
        public int Index { get; set; }

        [JsonPropertyName("value")]
        public int Value { get; set; }
    }

    public class Tactic
    {
        [JsonPropertyName("squadId")]
        public int SquadId { get; set; }

        [JsonPropertyName("tactic")]
        public string TacticName { get; set; } = default!;

        [JsonPropertyName("lastUpdateTime")]
        public int LastUpdateTime { get; set; }

        [JsonPropertyName("formation")]
        public string Formation { get; set; } = default!;

        [JsonPropertyName("positions")]
        public List<Position> Positions { get; set; } = default!;

        [JsonPropertyName("instructions")]
        public List<Instruction> Instructions { get; set; } = default!;

        [JsonPropertyName("styles")]
        public List<Style> Styles { get; set; } = default!;
    }

}