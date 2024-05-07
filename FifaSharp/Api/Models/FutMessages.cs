using System.Text.Json.Serialization;

namespace FifaSharp.Api.Models;


public class FutMessages
{
    [JsonPropertyName("messageList")]
    public Message[] MessageList { get; set; } = default!;

    public class Message
    {
        [JsonPropertyName("trackingTag")]
        public string TrackingTag { get; set; } = default!;

        [JsonPropertyName("screen")]
        public string Screen { get; set; } = default!;

        [JsonPropertyName("messageId")]
        public int MessageId { get; set; }

        [JsonPropertyName("priority")]
        public int Priority { get; set; }

        [JsonPropertyName("tmtLink")]
        public string TmtLink { get; set; } = default!;

        [JsonPropertyName("displayTime")]
        public int DisplayTime { get; set; }

        [JsonPropertyName("trackurls")]
        public object TrackUrls { get; set; } = default!;

        [JsonPropertyName("subtype")]
        public string Subtype { get; set; } = default!;

        [JsonPropertyName("doNotDisplay")]
        public string DoNotDisplay { get; set; } = default!;

        [JsonPropertyName("renders")]
        public Render[] Renders { get; set; } = default!;

        [JsonPropertyName("promotions")]
        public object[] Promotions { get; set; } = default!;
    }

    public class Render
    {
        [JsonPropertyName("type")]
        public string Type { get; set; } = default!;

        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        [JsonPropertyName("value")]
        public string Value { get; set; } = default!;

        [JsonPropertyName("attributes")]
        public RenderAttributes Attributes { get; set; } = default!;
    }

    public class RenderAttributes
    {
        [JsonPropertyName("style")]
        public string Style { get; set; } = default!;

        [JsonPropertyName("size")]
        public string Size { get; set; } = default!;

        [JsonPropertyName("alignment")]
        public string Alignment { get; set; } = default!;

        [JsonPropertyName("colour")]
        public string Colour { get; set; } = default!;

        [JsonPropertyName("highlightColour")]
        public string HighlightColour { get; set; } = default!;

        [JsonPropertyName("renderType")]
        public string RenderType { get; set; } = default!;

        [JsonPropertyName("countdownTime")]
        public string CountdownTime { get; set; } = default!;

        [JsonPropertyName("localId")]
        public string LocalId { get; set; } = default!;
    }
}

