using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Value                                    0001866992B0 ModelPrimitiveType uint uint uint UInt32
    public partial class BitField32
    {
        public uint                                     Value                                   { get; set; }

        public static BitField32? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BitField32();

            value.Value                                     = GetUInt32(new IntPtr(p + 0x010)); // 0270D988A6C8 0x10 Value                       ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
