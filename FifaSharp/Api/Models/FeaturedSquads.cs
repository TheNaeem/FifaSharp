using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FifaSharp.Api.Models;

public class FeaturedSquads
{
    [JsonPropertyName("featuredSquads")]
    public List<Squad> Squads { get; set; } = default!;

    public class Squad
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        [JsonPropertyName("rating")]
        public int Rating { get; set; }

        [JsonPropertyName("formation")]
        public string Formation { get; set; } = default!;
    }
}


