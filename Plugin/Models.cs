using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace YStreamUtils_PluginSDK.Plugin;

[AttributeUsage(AttributeTargets.Assembly)]
public abstract class PluginManifest : Attribute
{
    [Required]
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [Required]
    [JsonPropertyName("version")]
    public required string Version { get; init; }

    [Required]
    [JsonPropertyName("permissions")]
    public required List<string> Permissions { get; init; }

    [Required]
    [JsonPropertyName("authors")]
    public required List<string> Authors { get; init; }

    [Required]
    [JsonPropertyName("source")]
    public required SourceConfig Source { get; init; }

    [Required]
    [JsonPropertyName("documentation")]
    public required DocumentationConfig Documentation { get; init; }
}

public abstract record SourceConfig
{
    [Required]
    [JsonPropertyName("repository")]
    public required string Repository { get; init; }

    [Required]
    [JsonPropertyName("owner")]
    public required string Owner { get; init; }
}

public abstract class DocumentationConfig
{
    [Required]
    [JsonPropertyName("description")]
    public required string Description { get; init; }
}
