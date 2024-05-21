using System.Text.Json.Serialization;
using PartyDotNet.Converters;

namespace PartyDotNet.Models.Pixiv;

public class FanCard
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("user_id")]
    public string UserId { get; set; } = string.Empty;
    [JsonPropertyName("file_id")]
    public int FileId { get; set; }
    [JsonPropertyName("last_checked_at"), JsonConverter(typeof(DateTimeOffsetIso8601Converter))]
    public DateTimeOffset LastCheckedAt { get; set; }
    [JsonPropertyName("price")]
    public string Price { get; set; } = string.Empty;
    [JsonPropertyName("hash")]
    public string Hash { get; set; } = string.Empty;
    [JsonPropertyName("mtime"), JsonConverter(typeof(DateTimeOffsetIso8601Converter))]
    public DateTimeOffset MTime { get; set; }
    [JsonPropertyName("ctime"), JsonConverter(typeof(DateTimeOffsetIso8601Converter))]
    public DateTimeOffset CTime { get; set; }
    [JsonPropertyName("mime")]
    public string Mime { get; set; } = string.Empty;
    [JsonPropertyName("ext")]
    public string Extension { get; set; } = string.Empty;
    [JsonPropertyName("added"), JsonConverter(typeof(DateTimeOffsetIso8601Converter))]
    public DateTimeOffset Added { get; set; }
    [JsonPropertyName("size")]
    public int Size { get; set; }
}