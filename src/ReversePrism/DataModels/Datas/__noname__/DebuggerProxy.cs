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
    public partial class DebuggerProxy
    {
        public uint                                     X                                       { get; set; }
        public uint                                     Y                                       { get; set; }
        public uint                                     Z                                       { get; set; }
        public uint                                     W                                       { get; set; }

        public static DebuggerProxy? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebuggerProxy();

            value.X                                         = GetUInt32(new IntPtr(p + 0x010)); // 0270D7EA58A8 0x10 X                           ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.Y                                         = GetUInt32(new IntPtr(p + 0x014)); // 0270D7EA58C8 0x14 Y                           ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.Z                                         = GetUInt32(new IntPtr(p + 0x018)); // 0270D7EA58E8 0x18 Z                           ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.W                                         = GetUInt32(new IntPtr(p + 0x01C)); // 0270D7EA5908 0x1C W                           ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
