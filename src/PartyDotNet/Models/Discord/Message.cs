using System.Text.Json.Serialization;
using PartyDotNet.Converters;

namespace PartyDotNet.Models.Discord;

public class Message : MessageBase
{
    [JsonPropertyName("author")]
    public Author Author { get; set; } = new();
    [JsonPropertyName("added"), JsonConverter(typeof(DateTimeOffsetIso8601Converter))]
    public DateTimeOffset Added { get; set; }
    [JsonPropertyName("edited"), JsonConverter(typeof(DateTimeOffsetIso8601Converter))]
    public DateTimeOffset? Edited { get; set; }
}