using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace MupenSharp
{
    public unsafe interface ICore : IDisposable
    {
        Types.Error PluginGetVersion(ref Types.PluginTypes pluginType, ref int pluginVersion, ref int apiVersion, byte** namePtr, ref int capabilities);
        Types.Error CoreGetAPIVersions(int* configVersion, int* debugVersion, int* vidextVersion, int* extraVersion);

        IntPtr CoreErrorMessage(Types.Error errorCode);

        Types.Error PluginStartup(IntPtr libPtr, void* unk1, Types.Plugin.Delegates.PluginStartupCallbackDelegate callback);

        Types.Error PluginShutdown();
    }
}
