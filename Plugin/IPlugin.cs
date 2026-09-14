using Jint;
using Jint.Native;

namespace YStreamUtils_PluginSDK.Plugin;

public interface IPlugin
{
    JsObject CreatePluginObject(Engine vm);
}