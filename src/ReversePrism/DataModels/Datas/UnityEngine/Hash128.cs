using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 U64_0                                    00018669BB50 ModelPrimitiveType ulong ulong ulong UInt64
    // 018 U64_1                                    00018669BB50 ModelPrimitiveType ulong ulong ulong UInt64
    // 000 kConst                                   ulong IL2CPP_TYPE_U8
    public partial class Hash128 : DataModel
    {
        public ulong                                    U64_0                                   { get; set; }
        public ulong                                    U64_1                                   { get; set; }

        public static Hash128? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Hash128() { Pointer= p0 };

            value.U64_0                                     = GetUInt64(new IntPtr(p + 0x010)); // 0245A23379F0 0x10 U64_0                       ( 00018669BB50 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.U64_1                                     = GetUInt64(new IntPtr(p + 0x018)); // 0245A2337A10 0x18 U64_1                       ( 00018669BB50 ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
