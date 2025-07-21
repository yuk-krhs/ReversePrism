using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 X                                        ModelPrimitiveType uint uint uint UInt32
    // 014 Y                                        ModelPrimitiveType uint uint uint UInt32
    // 018 Z                                        ModelPrimitiveType uint uint uint UInt32
    // 01C W                                        ModelPrimitiveType uint uint uint UInt32
    public partial class DebuggerProxy : DataModel
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
            var value   = new DebuggerProxy() { Pointer= p0 };

            value.X                                         = GetUInt32(new IntPtr(p + 0x010)); // 0x10 X                           ( ModelPrimitiveType uint uint uint UInt32 )
            value.Y                                         = GetUInt32(new IntPtr(p + 0x014)); // 0x14 Y                           ( ModelPrimitiveType uint uint uint UInt32 )
            value.Z                                         = GetUInt32(new IntPtr(p + 0x018)); // 0x18 Z                           ( ModelPrimitiveType uint uint uint UInt32 )
            value.W                                         = GetUInt32(new IntPtr(p + 0x01C)); // 0x1C W                           ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
