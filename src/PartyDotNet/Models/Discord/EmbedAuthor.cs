using System.Text.Json.Serialization;

namespace PartyDotNet.Models.Discord;

public class EmbedAuthor
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    [JsonPropertyName("url")]
    public string? Url { get; set; }
    [JsonPropertyName("icon_url")]
    public string? IconUrl { get; set; }
    [JsonPropertyName("proxy_icon_url")]
    public string? ProxyIconUrl { get; set; }
}