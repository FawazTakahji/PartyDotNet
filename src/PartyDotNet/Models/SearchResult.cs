using System.Text.Json.Serialization;
using PartyDotNet.Converters;
using PartyDotNet.Models.Discord;

namespace PartyDotNet.Models;

public class SearchResult
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
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
    [JsonPropertyName("posts")]
    public List<PostResult>? Posts { get; set; }
    [JsonPropertyName("discord_posts")]
    public List<MessageResult>? DiscordPosts { get; set; }
}