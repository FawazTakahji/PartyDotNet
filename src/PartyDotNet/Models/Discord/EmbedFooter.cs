using System.Text.Json.Serialization;

namespace PartyDotNet.Models.Discord;

public class EmbedFooter
{
    [JsonPropertyName("text")]
    public string Text { get; set; } = string.Empty;
    [JsonPropertyName("icon_url")]
    public string? IconUrl { get; set; }
    [JsonPropertyName("proxy_icon_url")]
    public string? ProxyIconUrl { get; set; }
}