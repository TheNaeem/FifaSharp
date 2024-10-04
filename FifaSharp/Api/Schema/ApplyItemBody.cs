using System.Text.Json.Serialization;

namespace FifaSharp.Api.Schema;

public class ApplyItemBody
{
    [JsonPropertyName("apply")]
    public List<object> Apply { get; set; } = new();
}
