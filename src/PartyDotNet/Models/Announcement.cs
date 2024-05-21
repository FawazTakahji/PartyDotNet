using System.Text.Json.Serialization;
using PartyDotNet.Converters;
using PartyDotNet.Enums;

namespace PartyDotNet.Models;

public class Announcement
{
    [JsonPropertyName("user_id")]
    public string UserId { get; set; } = string.Empty;
    [JsonPropertyName("hash")]
    public string Hash { get; set; } = string.Empty;
    [JsonPropertyName("content")]
    public string Content { get; set; } = string.Empty;
    [JsonPropertyName("added"), JsonConverter(typeof(DateTimeOffsetIso8601Converter))]
    public DateTimeOffset? Added { get; set; }
    [JsonPropertyName("published"), JsonConverter(typeof(DateTimeOffsetIso8601Converter))]
    public DateTimeOffset Published { get; set; }
    [JsonPropertyName("service")]
    public Service Service { get; set; }
}