using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BitOffset                                0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 014 SizeInBits                               0001866992B0 ModelPrimitiveType uint uint uint UInt32
    public partial class BitRegion : DataModel
    {
        public uint                                     BitOffset                               { get; set; }
        public uint                                     SizeInBits                              { get; set; }

        public static BitRegion? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BitRegion() { Pointer= p0 };

            value.BitOffset                                 = GetUInt32(new IntPtr(p + 0x010)); // 0246677734A8 0x10 BitOffset                   ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.SizeInBits                                = GetUInt32(new IntPtr(p + 0x014)); // 0246677734C8 0x14 SizeInBits                  ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
