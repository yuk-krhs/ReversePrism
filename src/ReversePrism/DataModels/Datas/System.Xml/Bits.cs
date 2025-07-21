using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MASK_0101010101010101                    uint IL2CPP_TYPE_U4
    // 004 MASK_0011001100110011                    uint IL2CPP_TYPE_U4
    // 008 MASK_0000111100001111                    uint IL2CPP_TYPE_U4
    // 00C MASK_0000000011111111                    uint IL2CPP_TYPE_U4
    // 010 MASK_1111111111111111                    ModelPrimitiveType uint uint uint UInt32
    public partial class Bits : DataModel
    {
        public uint                                     MASK_1111111111111111                   { get; set; }

        public static Bits? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Bits() { Pointer= p0 };

            value.MASK_1111111111111111                     = GetUInt32(new IntPtr(p + 0x010)); // 0x10 MASK_1111111111111111       ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
