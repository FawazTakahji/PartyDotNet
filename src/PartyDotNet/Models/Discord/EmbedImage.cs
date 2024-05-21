using System.Text.Json.Serialization;

namespace PartyDotNet.Models.Discord;

public class EmbedImage : EmbedMedia
{
    [JsonPropertyName("url")]
    public string Url { get; set; } = string.Empty;
}