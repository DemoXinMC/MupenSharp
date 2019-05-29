using System;
using System.Collections.Generic;
using System.Text;

namespace MupenSharp.Types
{
    public enum Command
    {
        NoOp = 0,
        RomOpen,
        RomClose,
        RomGetHeader,
        RomGetSettings,
        Execute,
        Stop,
        Pause,
        Resume,
        CoreStateQuery,
        StateLoad,
        StateSave,
        StateSetSlot,
        SendSDLKeyDown,
        SendSDLKeyUp,
        SetFrameCallback,
        TakeNextScreenshot,
        CoreStateSet,
        ReadScreen,
        Reset,
        AdvanceFrame,
        SetMediaLoader
    }
}
