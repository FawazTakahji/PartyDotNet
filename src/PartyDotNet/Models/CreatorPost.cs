using System.Text.Json.Serialization;
using PartyDotNet.Converters;

namespace PartyDotNet.Models;

public class CreatorPost : Post
{
    [JsonPropertyName("embed")]
    public Embed? Embed { get; set; }
    [JsonPropertyName("shared_file")]
    public bool SharedFile { get; set; }
    [JsonPropertyName("added"), JsonConverter(typeof(DateTimeOffsetIso8601Converter))]
    public DateTimeOffset Added { get; set; }
    [JsonPropertyName("edited"), JsonConverter(typeof(DateTimeOffsetIso8601Converter))]
    public DateTimeOffset? Edited { get; set; }
    [JsonPropertyName("poll")]
    public Poll? Poll { get; set; }
    [JsonPropertyName("tags"), JsonConverter(typeof(TagsConverter))]
    public List<string>? Tags { get; set; }
    [JsonPropertyName("next")]
    public string? Next { get; set; }
    [JsonPropertyName("prev")]
    public string? Previous { get; set; }
}