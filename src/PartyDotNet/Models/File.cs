using System.Text.Json.Serialization;

namespace PartyDotNet.Models;

public class File
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    [JsonPropertyName("path")]
    public string Path { get; set; } = string.Empty;
}