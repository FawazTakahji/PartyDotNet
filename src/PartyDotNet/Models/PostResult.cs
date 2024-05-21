using System.Text.Json.Serialization;

namespace PartyDotNet.Models;

public class PostResult : Post
{
    [JsonPropertyName("file_id")]
    public int FileId { get; set; }
}