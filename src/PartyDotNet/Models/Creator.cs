using System.Text.Json.Serialization;
using PartyDotNet.Converters;
using PartyDotNet.Enums;

namespace PartyDotNet.Models;

public class Creator
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    [JsonPropertyName("service")]
    public Service Service { get; set; }
    [JsonPropertyName("indexed"), JsonConverter(typeof(DateTimeOffsetUnixConverter))]
    public DateTimeOffset Indexed { get; set; }
    [JsonPropertyName("updated"), JsonConverter(typeof(DateTimeOffsetUnixConverter))]
    public DateTimeOffset Updated { get; set; }
    [JsonPropertyName("favorited")]
    public int Favorited { get; set; }
}