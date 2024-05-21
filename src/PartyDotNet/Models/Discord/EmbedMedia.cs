using System.Text.Json.Serialization;

namespace PartyDotNet.Models.Discord;

public class EmbedMedia
{
    [JsonPropertyName("proxy_url")]
    public string? ProxyUrl { get; set; }
    [JsonPropertyName("height")]
    public int? Height { get; set; }
    [JsonPropertyName("width")]
    public int? Width { get; set; }
}