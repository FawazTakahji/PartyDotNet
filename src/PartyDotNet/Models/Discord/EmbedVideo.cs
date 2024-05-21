using System.Text.Json.Serialization;

namespace PartyDotNet.Models.Discord;

public class EmbedVideo : EmbedMedia
{
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}