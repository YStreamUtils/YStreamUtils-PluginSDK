namespace YStreamUtils.SDK.Plugin;

[AttributeUsage(AttributeTargets.Assembly)]
public sealed class PluginManifestAttribute(
    string name,
    string version,
    string description,
    string sourceOwner,
    string sourceRepository,
    string[] permissions,
    string[] authors)
    : Attribute
{
    public string Name { get; } = name;
    public string Version { get; } = version;
    public string Description { get; } = description;
    public string SourceOwner { get; } = sourceOwner;
    public string SourceRepository { get; } = sourceRepository;
    public string[] Permissions { get; } = permissions;
    public string[] Authors { get; } = authors;

    public Type? SettingsType { get; set; }

    public PluginManifest ToManifest() => new()
    {
        Name = Name,
        Version = Version,
        Permissions = [.. Permissions],
        Authors = [.. Authors],
        Source = new SourceConfig { Owner = SourceOwner, Repository = SourceRepository },
        Documentation = new DocumentationConfig { Description = Description }
    };
}