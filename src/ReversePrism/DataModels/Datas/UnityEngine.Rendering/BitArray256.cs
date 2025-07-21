using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Data1                                    ModelPrimitiveType ulong ulong ulong UInt64
    // 018 Data2                                    ModelPrimitiveType ulong ulong ulong UInt64
    // 020 Data3                                    ModelPrimitiveType ulong ulong ulong UInt64
    // 028 Data4                                    ModelPrimitiveType ulong ulong ulong UInt64
    public partial class BitArray256 : DataModel
    {
        public ulong                                    Data1                                   { get; set; }
        public ulong                                    Data2                                   { get; set; }
        public ulong                                    Data3                                   { get; set; }
        public ulong                                    Data4                                   { get; set; }

        public static BitArray256? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BitArray256() { Pointer= p0 };

            value.Data1                                     = GetUInt64(new IntPtr(p + 0x010)); // 0x10 Data1                       ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Data2                                     = GetUInt64(new IntPtr(p + 0x018)); // 0x18 Data2                       ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Data3                                     = GetUInt64(new IntPtr(p + 0x020)); // 0x20 Data3                       ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Data4                                     = GetUInt64(new IntPtr(p + 0x028)); // 0x28 Data4                       ( ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
