using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 X                                        000186598100 ModelPrimitiveType bool bool bool Bool
    // 011 Y                                        000186598100 ModelPrimitiveType bool bool bool Bool
    // 012 Z                                        000186598100 ModelPrimitiveType bool bool bool Bool
    public partial class bool3
    {
        public bool                                     X                                       { get; set; }
        public bool                                     Y                                       { get; set; }
        public bool                                     Z                                       { get; set; }

        public static bool3? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new bool3();

            value.X                                         = GetBool(new IntPtr(p + 0x010)); // 0270D7E0B818 0x10 X                           ( 000186598100 ModelPrimitiveType bool bool bool Bool )
            value.Y                                         = GetBool(new IntPtr(p + 0x011)); // 0270D7E0B838 0x11 Y                           ( 000186598100 ModelPrimitiveType bool bool bool Bool )
            value.Z                                         = GetBool(new IntPtr(p + 0x012)); // 0270D7E0B858 0x12 Z                           ( 000186598100 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
