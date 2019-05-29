using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace MupenSharp.Types
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ROMSettings
    {
        fixed char GoodName[256];
        fixed char MD5[33];
        byte SaveType;
        /// <summary>
        /// Rom status on a scale from 0-5
        /// </summary>
        byte Status;

        /// <summary>
        /// Local players 0-4, 2/3/4 way Netplay indicated by 5/6/7
        /// </summary>
        byte Players;

        /// <summary>
        /// 0 - No, 1 - Yes boolean for rumble support
        /// </summary>
        byte Rumble;

        /// <summary>
        /// 0 - No, 1 - Yes boolean for transfer pak support
        /// </summary>
        byte TransferPak;

        /// <summary>
        /// 0 - No, 1 - Yes boolean for memory pak support
        /// </summary>
        byte MemPak;

        /// <summary>
        /// 0 - No, 1 - Yes boolean for bio pak support
        /// </summary>
        byte BioPak;
    }
}
