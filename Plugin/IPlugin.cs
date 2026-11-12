using System.Text.Json;

namespace YStreamUtils.SDK.Plugin;

public interface IPlugin
{
    Task InitializeAsync() => Task.CompletedTask;
    Task SettingsUpdatedAsync(string newSettings) => Task.CompletedTask;
}

public abstract class PluginBase<TSettings> : IPlugin, IAsyncDisposable
    where TSettings : class, new()
{
    private static readonly JsonSerializerOptions SerializerOptions = new()
    {
        PropertyNameCaseInsensitive = true
    };

    private TSettings Settings { get; set; } = new();

    public virtual Task InitializeAsync() => Task.CompletedTask;

    async Task IPlugin.SettingsUpdatedAsync(string newSettings)
    {
        Settings = string.IsNullOrWhiteSpace(newSettings)
            ? new TSettings()
            : JsonSerializer.Deserialize<TSettings>(newSettings, SerializerOptions) ?? new TSettings();

        await OnSettingsUpdatedAsync(Settings);
    }

    protected abstract Task OnSettingsUpdatedAsync(TSettings settings);

    public ValueTask DisposeAsync() => OnDisposeAsync();

    protected virtual ValueTask OnDisposeAsync() => ValueTask.CompletedTask;
}