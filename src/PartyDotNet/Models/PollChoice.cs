using System.Text.Json.Serialization;

namespace PartyDotNet.Models;

public class PollChoice
{
    [JsonPropertyName("text")]
    public string Text { get; set; } = string.Empty;
    [JsonPropertyName("votes")]
    public int Votes { get; set; }
}