using System.Text.Json.Serialization;

namespace PartyDotNet.Models.Discord;

public class Channel
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
}