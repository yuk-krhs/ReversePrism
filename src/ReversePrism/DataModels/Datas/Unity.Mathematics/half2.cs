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
    // 000 zero                                     half2 IL2CPP_TYPE_VALUETYPE
    public partial class half2
    {
        public half                                     X                                       { get; set; }
        public half                                     Y                                       { get; set; }

        public static half2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new half2();

            value.X                                         = (half)GetInt32(new IntPtr(p + 0x010)); // 0270D7E4F288 0x10 X                           ( 0001865EE010 ModelEnumType half half half Int32 )
            value.Y                                         = (half)GetInt32(new IntPtr(p + 0x012)); // 0270D7E4F2A8 0x12 Y                           ( 0001865EE010 ModelEnumType half half half Int32 )

            return value;
        }
    }
}
