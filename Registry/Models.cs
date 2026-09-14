using System.Text.Json.Serialization;
using YStreamUtils.SDK.Plugin;

namespace YStreamUtils.SDK.Registry;

public class RegistryDistribution
{
    [JsonPropertyName("plugins")]
    public List<PluginManifest> Plugins { get; init; } = [];
}