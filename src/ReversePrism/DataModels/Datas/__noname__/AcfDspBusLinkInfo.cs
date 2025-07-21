using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     ModelEnumType AcfDspBusLinkType AcfDspBusLinkType AcfDspBusLinkType Int32
    // 014 SendLevel                                ModelPrimitiveType float float float Single
    // 018 BusNo                                    ModelPrimitiveType ushort ushort ushort UInt16
    // 01A BusId                                    ModelPrimitiveType ushort ushort ushort UInt16
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

            value.Type                                      = (AcfDspBusLinkType)GetInt32(new IntPtr(p + 0x010)); // 0x10 Type                        ( ModelEnumType AcfDspBusLinkType AcfDspBusLinkType AcfDspBusLinkType Int32 )
            value.SendLevel                                 = GetSingle(new IntPtr(p + 0x014)); // 0x14 SendLevel                   ( ModelPrimitiveType float float float Single )
            value.BusNo                                     = GetUInt16(new IntPtr(p + 0x018)); // 0x18 BusNo                       ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.BusId                                     = GetUInt16(new IntPtr(p + 0x01A)); // 0x1A BusId                       ( ModelPrimitiveType ushort ushort ushort UInt16 )

            return value;
        }
    }
}
