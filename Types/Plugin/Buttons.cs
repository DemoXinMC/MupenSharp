using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace MupenSharp.Types.Plugin
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Buttons
    {
        byte Buttons1;
        byte Buttons2;
        sbyte XAxis;
        sbyte YAxis;
    }
}
