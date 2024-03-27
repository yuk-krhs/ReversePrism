using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Increment                                00018669C270 ModelPrimitiveType ulong ulong ulong UInt64
    // 018 State                                    00018669B890 ModelPrimitiveType ulong ulong ulong UInt64
    public partial class PcgRandom
    {
        public ulong                                    Increment                               { get; set; }
        public ulong                                    State                                   { get; set; }

        public static PcgRandom? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PcgRandom();

            value.Increment                                 = GetUInt64(new IntPtr(p + 0x010)); // 027004FAC5A8 0x10 Increment                   ( 00018669C270 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.State                                     = GetUInt64(new IntPtr(p + 0x018)); // 027004FAC5C8 0x18 State                       ( 00018669B890 ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
