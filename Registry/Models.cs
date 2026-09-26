using System.Text.Json.Serialization;
using YStreamUtils.SDK.Plugin;

namespace YStreamUtils.SDK.Registry;

public class RegistryDistribution
{
    [JsonPropertyName("name")]
    public string Name { get; set; } =  string.Empty;
    
    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;
    
    [JsonPropertyName("source")]
    public SourceConfig Source { get; set; } = new()
    {
        Repository = "Not Initialized",
        Owner =  "Not Initialized"
    };
    
    [JsonPropertyName("plugins")]
    public List<PluginManifest> Plugins { get; init; } = [];
}