using System.Text.Json.Serialization;
using YStreamUtils_PluginSDK.Plugin;

namespace YStreamUtils_PluginSDK.Registry;

public class RegistryDistribution
{
    [JsonPropertyName("plugins")]
    public List<PluginManifest> Plugins { get; init; } = [];
}