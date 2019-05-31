using System.Runtime.InteropServices;

namespace MupenSharp.Types.Plugin
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct AudioInfo
    {
        byte* RDRAM;
        byte* DMEM;
        byte* IMEM;

        uint* MI_INTR_REG;

        uint* AI_DRAM_ADDR_REG;
        uint* AI_LEN_REG;
        uint* AI_CONTROL_REG;
        uint* AI_STATUS_REG;
        uint* AI_DACRATE_REG;
        uint* AI_BITRATE_REG;

        Delegates.VoidFuncDelegate CheckInterrupts;
    }
}
