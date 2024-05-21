using System.Text.Json.Serialization;

namespace PartyDotNet.Models.Discord;

public class EmbedProvider
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}