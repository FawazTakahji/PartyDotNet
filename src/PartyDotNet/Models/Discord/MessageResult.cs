using System.Text.Json.Serialization;

namespace PartyDotNet.Models.Discord;

public class MessageResult : MessageBase
{
    [JsonPropertyName("file_id")]
    public int FileId { get; set; }
}