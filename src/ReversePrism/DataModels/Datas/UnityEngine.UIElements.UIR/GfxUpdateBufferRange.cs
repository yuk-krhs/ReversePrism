using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OffsetFromWriteStart                     0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 014 Size                                     0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 018 source                                   <uint> IL2CPP_TYPE_U
    public partial class GfxUpdateBufferRange
    {
        public uint                                     OffsetFromWriteStart                    { get; set; }
        public uint                                     Size                                    { get; set; }

        public static GfxUpdateBufferRange? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GfxUpdateBufferRange();

            value.OffsetFromWriteStart                      = GetUInt32(new IntPtr(p + 0x010)); // 02700685F340 0x10 OffsetFromWriteStart        ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.Size                                      = GetUInt32(new IntPtr(p + 0x014)); // 02700685F360 0x14 Size                        ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
