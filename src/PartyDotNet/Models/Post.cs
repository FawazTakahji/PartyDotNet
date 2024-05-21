using System.Text.Json.Serialization;
using PartyDotNet.Converters;
using PartyDotNet.Enums;

namespace PartyDotNet.Models;

public class Post
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;
    [JsonPropertyName("user")]
    public string User { get; set; } = string.Empty;
    [JsonPropertyName("service")]
    public Service Service { get; set; }
    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;
    [JsonPropertyName("content")]
    public string Content { get; set; } = string.Empty;
    [JsonPropertyName("substring"), JsonInclude]
    private string Substring { set => Content = value; }
    [JsonPropertyName("published"), JsonConverter(typeof(DateTimeOffsetIso8601Converter))]
    public DateTimeOffset Published { get; set; }
    [JsonPropertyName("file")]
    public File File { get; set; } = new();
    [JsonPropertyName("attachments")]
    public List<File> Attachments { get; set; } = [];
}