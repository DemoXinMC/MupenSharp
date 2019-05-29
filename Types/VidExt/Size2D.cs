using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace MupenSharp.Types.VidExt
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Size2D
    {
        uint Width;
        uint Height;
    }
}
