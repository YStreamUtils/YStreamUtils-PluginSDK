namespace YStreamUtils.SDK.Plugin;

public interface IPlugin
{
    public Task SettingsUpdated(string newSettings);
}