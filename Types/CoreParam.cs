using System;
using System.Collections.Generic;
using System.Text;

namespace MupenSharp.Types
{
    public enum CoreParam
    {
        EmulatorState = 1,
        VideoMode,
        SaveStateSlot,
        SpeedFactor,
        SpeedLimiter,
        VideoSize,
        AudioVolume,
        AudioMute,
        InputGameShark,
        StateLoadComplete,
        StateSaveComplete
    }
}
