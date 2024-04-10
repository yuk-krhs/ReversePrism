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
    // 01C W                                        0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 000 zero                                     uint4 IL2CPP_TYPE_VALUETYPE
    public partial class uint4 : DataModel
    {
        public uint                                     X                                       { get; set; }
        public uint                                     Y                                       { get; set; }
        public uint                                     Z                                       { get; set; }
        public uint                                     W                                       { get; set; }

        public static uint4? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new uint4() { Pointer= p0 };

            value.X                                         = GetUInt32(new IntPtr(p + 0x010)); // 0245A15DBA80 0x10 X                           ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.Y                                         = GetUInt32(new IntPtr(p + 0x014)); // 0245A15DBAA0 0x14 Y                           ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.Z                                         = GetUInt32(new IntPtr(p + 0x018)); // 0245A15DBAC0 0x18 Z                           ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.W                                         = GetUInt32(new IntPtr(p + 0x01C)); // 0245A15DBAE0 0x1C W                           ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
