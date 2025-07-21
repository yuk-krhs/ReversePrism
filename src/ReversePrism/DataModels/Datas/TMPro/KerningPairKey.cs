using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Ascii_Left                               ModelPrimitiveType uint uint uint UInt32
    // 014 Ascii_Right                              ModelPrimitiveType uint uint uint UInt32
    // 018 Key                                      ModelPrimitiveType uint uint uint UInt32
    public partial class KerningPairKey : DataModel
    {
        public uint                                     Ascii_Left                              { get; set; }
        public uint                                     Ascii_Right                             { get; set; }
        public uint                                     Key                                     { get; set; }

        public static KerningPairKey? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new KerningPairKey() { Pointer= p0 };

            value.Ascii_Left                                = GetUInt32(new IntPtr(p + 0x010)); // 0x10 Ascii_Left                  ( ModelPrimitiveType uint uint uint UInt32 )
            value.Ascii_Right                               = GetUInt32(new IntPtr(p + 0x014)); // 0x14 Ascii_Right                 ( ModelPrimitiveType uint uint uint UInt32 )
            value.Key                                       = GetUInt32(new IntPtr(p + 0x018)); // 0x18 Key                         ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
