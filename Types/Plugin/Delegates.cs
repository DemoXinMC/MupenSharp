using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace MupenSharp.Types.Plugin
{
    public static class Delegates
    {
        public delegate void PluginStartupCallbackDelegate(IntPtr unk, int unk1, [MarshalAs(UnmanagedType.LPStr)]string unk2);
        public delegate void VoidFuncDelegate();
    }
}
