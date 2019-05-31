using System.Runtime.InteropServices;

namespace MupenSharp.Types.Plugin
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct GFXInfo
    {
        byte* HEADER;  /* This is the rom header (first 40h bytes of the rom) */
        byte* RDRAM;
        byte* DMEM;
        byte* IMEM;

        uint* MI_INTR_REG;

        uint* DPC_START_REG;
        uint* DPC_END_REG;
        uint* DPC_CURRENT_REG;
        uint* DPC_STATUS_REG;
        uint* DPC_CLOCK_REG;
        uint* DPC_BUFBUSY_REG;
        uint* DPC_PIPEBUSY_REG;
        uint* DPC_TMEM_REG;

        uint* VI_STATUS_REG;
        uint* VI_ORIGIN_REG;
        uint* VI_WIDTH_REG;
        uint* VI_INTR_REG;
        uint* VI_V_CURRENT_LINE_REG;
        uint* VI_TIMING_REG;
        uint* VI_V_SYNC_REG;
        uint* VI_H_SYNC_REG;
        uint* VI_LEAP_REG;
        uint* VI_H_START_REG;
        uint* VI_V_START_REG;
        uint* VI_V_BURST_REG;
        uint* VI_X_SCALE_REG;
        uint* VI_Y_SCALE_REG;

        Delegates.VoidFuncDelegate CheckInterrupts;

        /// <summary>
        /// The GFX_INFO.version parameter was added in version 2.5.1 of the core. Plugins should ensure the core is at least this version before attempting to read GFX_INFO.version.
        /// </summary>
        uint version;

        /// <summary>
        /// SP_STATUS_REG was added in version 2 of GFX_INFO.version.
        /// Plugins should only attempt to read these values if GFX_INFO.version is at least 2.
        /// 
        /// The RSP plugin should set (HALT | BROKE | TASKDONE) *before* calling ProcessDList.
        /// It should not modify SP_STATUS_REG after ProcessDList has returned.
        /// This will allow the GFX plugin to unset these bits if it needs.
        /// </summary>
        uint* SP_STATUS_REG;

        /// <summary>
        /// RDRAM_SIZE was added in version 2 of GFX_INFO.version.
        /// Plugins should only attempt to read these values if GFX_INFO.version is at least 2.
        /// </summary>
        uint* RDRAM_SIZE;
    }
}
