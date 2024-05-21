using System.Text.Json.Serialization;
using PartyDotNet.Enums.Discord;

namespace PartyDotNet.Models.Discord;

public class Author
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;
    [JsonPropertyName("clan")]
    public Clan? Clan { get; set; }
    [JsonPropertyName("bot")]
    public bool? Bot { get; set; }
    [JsonPropertyName("flags")]
    public Flag Flags { get; set; }
    [JsonPropertyName("avatar")]
    public string? Avatar { get; set; }
    [JsonPropertyName("banner")]
    public string? Banner { get; set; }
    [JsonPropertyName("username")]
    public string Username { get; set; } = string.Empty;
    [JsonPropertyName("global_name")]
    public string? GlobalName { get; set; }
    [JsonPropertyName("accent_color")]
    public int? AccentColor { get; set; }
    [JsonPropertyName("banner_color")]
    public int? BannerColor { get; set; }
    [JsonPropertyName("premium_type")]
    public PremiumType? PremiumType { get; set; }
    [JsonPropertyName("public_flags")]
    public Flag PublicFlags { get; set; }
    [JsonPropertyName("discriminator")]
    public string Discriminator { get; set; } = string.Empty;
    [JsonPropertyName("avatar_decoration_data")]
    public Decoration? Decoration { get; set; }
}