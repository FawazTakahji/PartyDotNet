using System.Text.Json.Serialization;
using PartyDotNet.Converters;

namespace PartyDotNet.Models.Discord;

public class Embed
{
    [JsonPropertyName("title")]
    public string? Title { get; set; }
    [JsonPropertyName("type")]
    public string? Type { get; set; }
    [JsonPropertyName("description")]
    public string? Description { get; set; }
    [JsonPropertyName("url")]
    public string? Url { get; set; }
    [JsonPropertyName("timestamp"), JsonConverter(typeof(DateTimeOffsetIso8601Converter))]
    public DateTimeOffset? Timestamp { get; set; }
    [JsonPropertyName("color")]
    public int? Color { get; set; }
    [JsonPropertyName("footer")]
    public EmbedFooter? Footer { get; set; }
    [JsonPropertyName("image")]
    public EmbedImage? Image { get; set; }
    [JsonPropertyName("thumbnail")]
    public EmbedImage? Thumbnail { get; set; }
    [JsonPropertyName("video")]
    public EmbedVideo? Video { get; set; }
    [JsonPropertyName("provider")]
    public EmbedProvider? Provider { get; set; }
    [JsonPropertyName("author")]
    public EmbedAuthor? Author { get; set; }
    [JsonPropertyName("fields")]
    public List<EmbedField>? Fields { get; set; }
}