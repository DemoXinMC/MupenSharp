using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace MupenSharp.Types
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MediaLoader
    {
        public delegate IntPtr GetGBCartROMDelegate(IntPtr cbData, int controllerNumber);
        public delegate IntPtr GetGBCartRAMDelegate(IntPtr cbData, int controllerNumber);
        public delegate IntPtr GetDDROMDelegate(IntPtr cbData);
        public delegate IntPtr GetDDDiskDelegate(IntPtr cbData);

        public IntPtr Data;
        public GetGBCartROMDelegate GetGBCartROM;
        public GetGBCartRAMDelegate GetGBCartRAM;
        public GetDDROMDelegate GetDDROM;
        public GetDDDiskDelegate GetDDDisk;
    }
}
