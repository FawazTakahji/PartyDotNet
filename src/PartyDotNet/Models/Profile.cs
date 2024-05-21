using System.Text.Json.Serialization;
using PartyDotNet.Converters;
using PartyDotNet.Enums;

namespace PartyDotNet.Models;

public class Profile
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    [JsonPropertyName("service")]
    public Service Service { get; set; }
    [JsonPropertyName("indexed"), JsonConverter(typeof(DateTimeOffsetIso8601Converter))]
    public DateTimeOffset Indexed { get; set; }
    [JsonPropertyName("updated"), JsonConverter(typeof(DateTimeOffsetIso8601Converter))]
    public DateTimeOffset Updated { get; set; }
    [JsonPropertyName("public_id")]
    public string? PublicId { get; set; }
    [JsonPropertyName("relation_id")]
    public int? RelationId { get; set; }
}