using System.Text.Json.Serialization;

namespace PartyDotNet.Models.Discord;

public class Decoration
{
    [JsonPropertyName("asset")]
    public string Asset { get; set; } = string.Empty;
    [JsonPropertyName("sku_id")]
    public string SkuId { get; set; } = string.Empty;
}