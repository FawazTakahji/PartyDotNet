using System.Text.Json.Serialization;
using PartyDotNet.Converters;

namespace PartyDotNet.Models;

public class FavoriteCreator : Profile
{
    [JsonPropertyName("faved_seq")]
    public int FavedSequence { get; set; }
    [JsonPropertyName("last_imported"), JsonConverter(typeof(DateTimeOffsetIso8601Converter))]
    public DateTimeOffset LastImported { get; set; }
}