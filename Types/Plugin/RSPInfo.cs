using System.Runtime.InteropServices;

namespace MupenSharp.Types.Plugin
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct RSPInfo
    {
        byte* RDRAM;
        byte* DMEM;
        byte* IMEM;

        uint* MI_INTR_REG;

        uint* SP_MEM_ADDR_REG;
        uint* SP_DRAM_ADDR_REG;
        uint* SP_RD_LEN_REG;
        uint* SP_WR_LEN_REG;
        uint* SP_STATUS_REG;
        uint* SP_DMA_FULL_REG;
        uint* SP_DMA_BUSY_REG;
        uint* SP_PC_REG;
        uint* SP_SEMAPHORE_REG;

        uint* DPC_START_REG;
        uint* DPC_END_REG;
        uint* DPC_CURRENT_REG;
        uint* DPC_STATUS_REG;
        uint* DPC_CLOCK_REG;
        uint* DPC_BUFBUSY_REG;
        uint* DPC_PIPEBUSY_REG;
        uint* DPC_TMEM_REG;

        Delegates.VoidFuncDelegate CheckInterrupts;
        Delegates.VoidFuncDelegate ProcessDlistList;
        Delegates.VoidFuncDelegate ProcessAlistList;
        Delegates.VoidFuncDelegate ProcessRdpList;
        Delegates.VoidFuncDelegate ShowCFB;
    }
}
