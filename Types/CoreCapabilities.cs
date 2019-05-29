using System;
using System.Collections.Generic;
using System.Text;

namespace MupenSharp.Types
{
    [Flags]
    public enum CoreCapabilities
    {
        DynamicRecompilation = 1,
        Debugger = 2,
        Compare = 4
    }
}
