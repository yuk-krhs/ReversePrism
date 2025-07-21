using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Byte0000                                 ModelPrimitiveType ulong ulong ulong UInt64
    // 018 Byte0008                                 ModelPrimitiveType ulong ulong ulong UInt64
    public partial class FixedBytes16Align8 : DataModel
    {
        public ulong                                    Byte0000                                { get; set; }
        public ulong                                    Byte0008                                { get; set; }

        public static FixedBytes16Align8? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FixedBytes16Align8() { Pointer= p0 };

            value.Byte0000                                  = GetUInt64(new IntPtr(p + 0x010)); // 0x10 Byte0000                    ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Byte0008                                  = GetUInt64(new IntPtr(p + 0x018)); // 0x18 Byte0008                    ( ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
