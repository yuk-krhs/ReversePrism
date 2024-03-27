using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 X                                        0001865EE010 ModelEnumType half half half Int32
    // 012 Y                                        0001865EE010 ModelEnumType half half half Int32
    // 014 Z                                        0001865EE010 ModelEnumType half half half Int32
    // 016 W                                        0001865EE010 ModelEnumType half half half Int32
    // 000 zero                                     half4 IL2CPP_TYPE_VALUETYPE
    public partial class half4
    {
        public half                                     X                                       { get; set; }
        public half                                     Y                                       { get; set; }
        public half                                     Z                                       { get; set; }
        public half                                     W                                       { get; set; }

        public static half4? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new half4();

            value.X                                         = (half)GetInt32(new IntPtr(p + 0x010)); // 0270D7E923E8 0x10 X                           ( 0001865EE010 ModelEnumType half half half Int32 )
            value.Y                                         = (half)GetInt32(new IntPtr(p + 0x012)); // 0270D7E92408 0x12 Y                           ( 0001865EE010 ModelEnumType half half half Int32 )
            value.Z                                         = (half)GetInt32(new IntPtr(p + 0x014)); // 0270D7E92428 0x14 Z                           ( 0001865EE010 ModelEnumType half half half Int32 )
            value.W                                         = (half)GetInt32(new IntPtr(p + 0x016)); // 0270D7E92448 0x16 W                           ( 0001865EE010 ModelEnumType half half half Int32 )

            return value;
        }
    }
}
