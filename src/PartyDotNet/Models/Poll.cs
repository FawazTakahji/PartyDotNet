using System.Text.Json.Serialization;
using PartyDotNet.Converters;

namespace PartyDotNet.Models;

public class Poll
{
    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;
    [JsonPropertyName("choices")]
    public List<PollChoice>? Choices { get; set; }
    [JsonPropertyName("closes_at"), JsonConverter(typeof(DateTimeOffsetIso8601Converter))]
    public DateTimeOffset ClosesAt { get; set; }
    [JsonPropertyName("created_at"), JsonConverter(typeof(DateTimeOffsetIso8601Converter))]
    public DateTimeOffset CreatedAt { get; set; }
    [JsonPropertyName("description")]
    public string? Description { get; set; }
    [JsonPropertyName("allows_multiple")]
    public bool AllowsMultiple { get; set; }
}