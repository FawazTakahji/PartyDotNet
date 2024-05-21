using System.Text.Json;
using System.Text.Json.Serialization;

namespace PartyDotNet.Converters;

public class TagsConverter : JsonConverter<List<string>>
{
    public override List<string>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return reader.TokenType switch
        {
            JsonTokenType.StartArray
                => ((JsonConverter<List<string>?>)JsonSerializerOptions.Default.GetConverter(typeof(List<string>)))
                .Read(ref reader, typeToConvert, options),

            JsonTokenType.String => ParseString(ref reader),
            _ => throw new JsonException($"Unexpected token type {reader.TokenType}")
        };
    }

    public override void Write(Utf8JsonWriter writer, List<string> value, JsonSerializerOptions options)
        => ((JsonConverter<List<string>>)JsonSerializerOptions.Default.GetConverter(typeof(List<string>)))
            .Write(writer, value, options);

    private List<string> ParseString(ref Utf8JsonReader reader)
    {
        string? str;

        try
        {
            str = reader.GetString();
        }
        catch (Exception ex)
        {
            return [];
        }

        if (string.IsNullOrEmpty(str))
            return [];

        return str.TrimStart('{')
            .TrimEnd('}')
            .Replace("\"", "")
            .Split(",")
            .ToList();
    }
}