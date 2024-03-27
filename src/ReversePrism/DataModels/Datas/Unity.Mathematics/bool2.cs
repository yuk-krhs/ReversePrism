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
    public partial class bool2
    {
        public bool                                     X                                       { get; set; }
        public bool                                     Y                                       { get; set; }

        public static bool2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new bool2();

            value.X                                         = GetBool(new IntPtr(p + 0x010)); // 0270D7DCAD40 0x10 X                           ( 000186598100 ModelPrimitiveType bool bool bool Bool )
            value.Y                                         = GetBool(new IntPtr(p + 0x011)); // 0270D7DCAD60 0x11 Y                           ( 000186598100 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
