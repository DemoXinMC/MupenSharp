using System;
using System.Collections.Generic;
using System.Text;

namespace MupenSharp.Types
{
    public unsafe struct ROMHeader
    {
        byte init_PI_BSB_DOM1_LAT_REG;
        byte init_PI_BSB_DOM1_PGS_REG;
        byte init_PI_BSB_DOM1_PWD_REG;
        byte init_PI_BSB_DOM1_PGS_REG2;
        uint ClockRate;
        uint PC;
        uint Release;
        uint CRC1;
        uint CRC2;
        fixed uint Unknown[2];
        fixed byte Name[20];
        uint Unknown2;
        uint ManufacturerID;
        ushort CartridgeID;
        ushort CountryCode;
    }
}
