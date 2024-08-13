using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FifaSharp.Api.Models;

public class PlayerAttributes
{
    [JsonPropertyName("defId")]
    public int DefId { get; set; }

    [JsonPropertyName("version")]
    public int Version { get; set; }

    [JsonPropertyName("rating")]
    public int Rating { get; set; }

    [JsonPropertyName("ingameattribs")]
    public List<int> InGameAttribs { get; set; } = default!;

    [JsonPropertyName("mainOutfieldAttributes")]
    public List<int> MainOutfieldAttributes { get; set; } = default!;

    [JsonPropertyName("mainGoalkeepAttributes")]
    public List<object> MainGoalkeepAttributes { get; set; } = default!;

    [JsonPropertyName("baseTraits")]
    public List<int> BaseTraits { get; set; } = default!;

    [JsonPropertyName("iconTraits")]
    public List<int> IconTraits { get; set; } = default!;

    [JsonPropertyName("rolePlus")]
    public List<object> RolePlus { get; set; } = default!;

    [JsonPropertyName("rolePlusPlus")]
    public List<object> RolePlusPlus { get; set; } = default!;
}
