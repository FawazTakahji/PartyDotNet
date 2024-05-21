using System.Text.Json.Serialization;
using PartyDotNet.Converters;

namespace PartyDotNet.Models;

public class Comment
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;
    [JsonPropertyName("parent_id")]
    public string? ParentId { get; set; } = string.Empty;
    [JsonPropertyName("commenter")]
    public string Commenter { get; set; } = string.Empty;
    [JsonPropertyName("commenter_name")]
    public string CommenterName { get; set; } = string.Empty;
    [JsonPropertyName("content")]
    public string Content { get; set; } = string.Empty;
    [JsonPropertyName("published"), JsonConverter(typeof(DateTimeOffsetIso8601Converter))]
    public DateTimeOffset Published { get; set; }
    [JsonPropertyName("revisions")]
    public List<CommentRevision> Revisions { get; set; } = [];
}