using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Ascii_Left                               0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 014 Ascii_Right                              0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 018 Key                                      0001866992B0 ModelPrimitiveType uint uint uint UInt32
    public partial class KerningPairKey
    {
        public uint                                     Ascii_Left                              { get; set; }
        public uint                                     Ascii_Right                             { get; set; }
        public uint                                     Key                                     { get; set; }

        public static KerningPairKey? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new KerningPairKey();

            value.Ascii_Left                                = GetUInt32(new IntPtr(p + 0x010)); // 0270DA630F60 0x10 Ascii_Left                  ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.Ascii_Right                               = GetUInt32(new IntPtr(p + 0x014)); // 0270DA630F80 0x14 Ascii_Right                 ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.Key                                       = GetUInt32(new IntPtr(p + 0x018)); // 0270DA630FA0 0x18 Key                         ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
