using System.Text.Json.Serialization;

namespace PartyDotNet.Models;

public class RevisionPost : CreatorPost
{
    [JsonPropertyName("revision_id")]
    public int RevisionId { get; set; }
}