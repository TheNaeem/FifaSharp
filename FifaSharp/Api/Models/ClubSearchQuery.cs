using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FifaSharp.Api.Models;

using System.Text.Json.Serialization;

public class ClubSearchQuery
{
    [JsonPropertyName("count")]
    public int Count { get; set; } = 91;

    [JsonPropertyName("ovrMax")]
    public int OvrMax { get; set; } = 99;

    [JsonPropertyName("ovrMin")]
    public int OvrMin { get; set; } = 45;

    /// <summary>
    /// Player ID to search. Can search multiple players at once if ID's are separated by comma.
    /// </summary>
    [JsonPropertyName("defId")]
    public string? DefId { get; set; }

    /// <summary>
    /// Players to exclude from search. Can exclude multiple players at once if ID's are separated by comma.
    /// </summary>
    [JsonPropertyName("excldef")]
    public string? ExclDef { get; set; }

    [JsonPropertyName("searchAltPositions")]
    public bool SearchAltPositions { get; set; } = true;

    /// <summary>
    /// "desc" for descending. "asc" for ascending.
    /// </summary>
    [JsonPropertyName("sort")]
    public string Sort { get; set; } = "desc";

    /// <summary>
    /// Set to "ovr" to sort by rating. "value" to sort by quick sell value.
    /// </summary>
    [JsonPropertyName("sortBy")]
    public string SortBy { get; set; } = "value";

    [JsonPropertyName("start")]
    public int Start { get; set; } = 0;

    [JsonPropertyName("type")]
    public string Type { get; set; } = "player";

    [JsonPropertyName("excludeLoans")]
    public bool? ExcludeLoans { get; set; }

    /// <summary>
    /// Evolution players only filter.
    /// </summary>
    [JsonPropertyName("isAcademyPlayer")]
    public bool? IsAcademyPlayer { get; set; }

    [JsonPropertyName("isUntradeable")]
    public bool? IsUntradeable { get; set; }

    [JsonPropertyName("league")]
    public int? League { get; set; }

    [JsonPropertyName("nation")]
    public int? Nation { get; set; }

    [JsonPropertyName("playStyle")]
    public int? ChemistryStyleId { get; set; }

    [JsonPropertyName("position")]
    public string? Position { get; set; }

    /// <summary>
    /// Set this to "SP" if you want to query by Special cards.
    /// </summary>

    [JsonPropertyName("rare")]
    public string? Rare { get; set; }

    /// <summary>
    /// Can be "bronze" or "silver" or "gold"
    /// </summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    [JsonPropertyName("rarityIds")]
    public string? RarityIds { get; set; }

    /// <summary>
    /// Set this to "desc" to sort by Most Recent.
    /// </summary>
    [JsonPropertyName("acquiredDate")]
    public string? AcquiredDate { get; set; }

    [JsonPropertyName("team")]
    public int? Team { get; set; }
}

