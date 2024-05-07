using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FifaSharp.Api.Models;

public class FutAccountInfo
{
    [JsonPropertyName("userAccountInfo")]
    public PersonaInfo Info { get; set; } = default!;

    [JsonPropertyName("nucEnabled")]
    public bool NucEnabled { get; set; }

    public class PersonaInfo
    {
        [JsonPropertyName("personas")]
        public Persona[] Personas { get; set; } = default!;
    }

    public class Persona
    {
        [JsonPropertyName("personaId")]
        public UInt64 Id { get; set; }

        [JsonPropertyName("personaName")]
        public string Name { get; set; } = default!;

        [JsonPropertyName("returningUser")]
        public int ReturningUser { get; set; }

        [JsonPropertyName("onlineAccess")]
        public bool OnlineAccess { get; set; }

        [JsonPropertyName("trial")]
        public bool Trial { get; set; }

        [JsonPropertyName("userState")]
        public object UserState { get; set; } = default!; // TODO:

        [JsonPropertyName("userClubList")]
        public Club[] UserClubList { get; set; } = default!;

        [JsonPropertyName("trialFree")]
        public bool TrialFree { get; set; }
    }

    public class Club
    {
        [JsonPropertyName("year")]
        public string Year { get; set; } = default!;

        [JsonPropertyName("assetId")]
        public int AssetId { get; set; }

        [JsonPropertyName("teamId")]
        public int TeamId { get; set; }

        [JsonPropertyName("lastAccessTime")]
        public int LastAccessTime { get; set; }

        [JsonPropertyName("platform")]
        public string Platform { get; set; } = default!;

        [JsonPropertyName("clubName")]
        public string ClubName { get; set; } = default!;

        [JsonPropertyName("clubAbbr")]
        public string ClubAbbr { get; set; } = default!;

        [JsonPropertyName("established")]
        public int Established { get; set; }

        [JsonPropertyName("divisionOnline")]
        public int DivisionOnline { get; set; }

        [JsonPropertyName("badgeId")]
        public int BadgeId { get; set; }

        [JsonPropertyName("skuAccessList")]
        public Dictionary<string, long> SkuAccessList { get; set; } = default!;

        [JsonPropertyName("activeHomeKit")]
        public int ActiveHomeKit { get; set; }

        [JsonPropertyName("activeCaptain")]
        public int ActiveCaptain { get; set; }
    }
}

