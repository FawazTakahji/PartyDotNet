using System.Text.Json.Serialization;
using PartyDotNet.Converters;

namespace PartyDotNet.Models.Discord;

public class MessageBase
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;
    [JsonPropertyName("server")]
    public string Server { get; set; } = string.Empty;
    [JsonPropertyName("channel")]
    public string Channel { get; set; } = string.Empty;
    [JsonPropertyName("content")]
    public string Content { get; set; } = string.Empty;
    [JsonPropertyName("substring"), JsonInclude]
    private string Substring { set => Content = value; }
    [JsonPropertyName("published"), JsonConverter(typeof(DateTimeOffsetIso8601Converter))]
    public DateTimeOffset Published { get; set; }
    [JsonPropertyName("embeds")]
    public List<Embed> Embeds { get; set; } = [];
    [JsonPropertyName("mentions")]
    public List<Author> Mentions { get; set; } = [];
    [JsonPropertyName("attachments")]
    public List<File> Attachments { get; set; } = [];

}