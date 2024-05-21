using System.Text.Json.Serialization;
using PartyDotNet.Converters;

namespace PartyDotNet.Models;

public class CommentRevision
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("content")]
    public string Content { get; set; } = string.Empty;
    [JsonPropertyName("added"), JsonConverter(typeof(DateTimeOffsetIso8601Converter))]
    public DateTimeOffset Added { get; set; }
}