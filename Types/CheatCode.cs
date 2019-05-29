using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace MupenSharp.Types
{
    [StructLayout(LayoutKind.Sequential)]
    public struct CheatCode
    {
        uint Address;
        int Value;
    }
}
