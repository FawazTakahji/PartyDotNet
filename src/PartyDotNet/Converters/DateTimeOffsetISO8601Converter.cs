using System.Text.Json;
using System.Text.Json.Serialization;

namespace PartyDotNet.Converters;

public class DateTimeOffsetIso8601Converter : JsonConverter<DateTimeOffset>
{
    public override DateTimeOffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.GetString() is not { } str)
            return DateTimeOffset.MinValue;

        return DateTimeOffset.Parse(str);
    }

    public override void Write(Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString("O"));
    }
}