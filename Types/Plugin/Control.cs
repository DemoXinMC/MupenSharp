using System.Runtime.InteropServices;

namespace MupenSharp.Types.Plugin
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Control
    {
        int Present;
        int RawData;
        int Plugin;
    }
}
