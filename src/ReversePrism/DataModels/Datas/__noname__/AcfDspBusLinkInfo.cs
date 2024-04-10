using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     000186546810 ModelEnumType AcfDspBusLinkType AcfDspBusLinkType AcfDspBusLinkType Int32
    // 014 SendLevel                                000186666050 ModelPrimitiveType float float float Single
    // 018 BusNo                                    000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 01A BusId                                    000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    public partial class AcfDspBusLinkInfo : DataModel
    {
        public AcfDspBusLinkType                        Type                                    { get; set; }
        public float                                    SendLevel                               { get; set; }
        public ushort                                   BusNo                                   { get; set; }
        public ushort                                   BusId                                   { get; set; }

        public static AcfDspBusLinkInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AcfDspBusLinkInfo() { Pointer= p0 };

            value.Type                                      = (AcfDspBusLinkType)GetInt32(new IntPtr(p + 0x010)); // 02466ACD9F58 0x10 Type                        ( 000186546810 ModelEnumType AcfDspBusLinkType AcfDspBusLinkType AcfDspBusLinkType Int32 )
            value.SendLevel                                 = GetSingle(new IntPtr(p + 0x014)); // 02466ACD9F78 0x14 SendLevel                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.BusNo                                     = GetUInt16(new IntPtr(p + 0x018)); // 02466ACD9F98 0x18 BusNo                       ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.BusId                                     = GetUInt16(new IntPtr(p + 0x01A)); // 02466ACD9FB8 0x1A BusId                       ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )

            return value;
        }
    }
}
