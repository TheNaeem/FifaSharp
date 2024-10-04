using FifaSharp.Api.Enums;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FifaSharp.Api.Models;

public class RushEvents
{
    [JsonPropertyName("eventList")]
    public List<Event> EventList { get; set; } = new();

    public class Event
    {
        [JsonPropertyName("eventId")]
        public int EventId { get; set; }

        [JsonPropertyName("eventName")]
        public string EventName { get; set; } = default!;

        [JsonPropertyName("startTime")]
        public int StartTime { get; set; }

        [JsonPropertyName("endTime")]
        public int EndTime { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; } = default!;

        [JsonPropertyName("priority")]
        public int Priority { get; set; }

        [JsonPropertyName("hardRequirements")]
        public List<HardRequirement> HardRequirements { get; set; } = new();

        public List<EvoRequirement> GetRequirements()
        {
            List<EvoRequirement> ret = new();

            EvoRequirement curr = new();

            foreach (var req in HardRequirements)
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

    public class HardRequirement
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
}