using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 X                                        0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 014 Y                                        0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 018 Z                                        0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 000 zero                                     uint3 IL2CPP_TYPE_VALUETYPE
    public partial class uint3 : DataModel
    {
        public uint                                     X                                       { get; set; }
        public uint                                     Y                                       { get; set; }
        public uint                                     Z                                       { get; set; }

        public static uint3? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new uint3() { Pointer= p0 };

            value.X                                         = GetUInt32(new IntPtr(p + 0x010)); // 0245A15D4B10 0x10 X                           ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.Y                                         = GetUInt32(new IntPtr(p + 0x014)); // 0245A15D4B30 0x14 Y                           ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.Z                                         = GetUInt32(new IntPtr(p + 0x018)); // 0245A15D4B50 0x18 Z                           ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
