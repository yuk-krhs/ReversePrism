using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 X                                        ModelPrimitiveType bool bool bool Bool
    // 011 Y                                        ModelPrimitiveType bool bool bool Bool
    // 012 Z                                        ModelPrimitiveType bool bool bool Bool
    // 013 W                                        ModelPrimitiveType bool bool bool Bool
    public partial class bool4 : DataModel
    {
        public bool                                     X                                       { get; set; }
        public bool                                     Y                                       { get; set; }
        public bool                                     Z                                       { get; set; }
        public bool                                     W                                       { get; set; }

        public static bool4? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new bool4() { Pointer= p0 };

            value.X                                         = GetBool(new IntPtr(p + 0x010)); // 0x10 X                           ( ModelPrimitiveType bool bool bool Bool )
            value.Y                                         = GetBool(new IntPtr(p + 0x011)); // 0x11 Y                           ( ModelPrimitiveType bool bool bool Bool )
            value.Z                                         = GetBool(new IntPtr(p + 0x012)); // 0x12 Z                           ( ModelPrimitiveType bool bool bool Bool )
            value.W                                         = GetBool(new IntPtr(p + 0x013)); // 0x13 W                           ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
