using System.Text.Json.Serialization;

namespace PartyDotNet.Models;

public class FavoritePost : CreatorPost
{
    [JsonPropertyName("faved_seq")]
    public int FavedSequence { get; set; }
}