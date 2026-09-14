using Jint;
using Jint.Native;

namespace YStreamUtils.SDK.Plugin;

public interface IPlugin
{
    JsObject CreatePluginObject(Engine vm);
}