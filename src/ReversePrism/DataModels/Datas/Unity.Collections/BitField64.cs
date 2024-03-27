using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Value                                    00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64
    public partial class BitField64
    {
        public ulong                                    Value                                   { get; set; }

        public static BitField64? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BitField64();

            value.Value                                     = GetUInt64(new IntPtr(p + 0x010)); // 0270D988AD60 0x10 Value                       ( 00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
