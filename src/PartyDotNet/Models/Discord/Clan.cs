using System.Text.Json.Serialization;

namespace PartyDotNet.Models.Discord;

public class Clan
{
    [JsonPropertyName("tag")]
    public string Tag { get; set; } = string.Empty;
    [JsonPropertyName("badge")]
    public string Badge { get; set; } = string.Empty;
    [JsonPropertyName("identity_enabled")]
    public bool IdentityEnabled { get; set; }
    [JsonPropertyName("identity_guild_id")]
    public string IdentityGuildId { get; set; } = string.Empty;
}