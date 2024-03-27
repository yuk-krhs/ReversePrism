using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DisplayName                              000186671910 ModelPrimitiveType string string string String
    // 018 Internal_name                            000186671910 ModelPrimitiveType string string string String
    public partial class Display
    {
        public string                                   DisplayName                             { get; set; }
        public string                                   Internal_name                           { get; set; }

        public static Display? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Display();

            value.DisplayName                               = GetString(new IntPtr(p + 0x010)); // 0270D6AA10E8 0x10 DisplayName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.Internal_name                             = GetString(new IntPtr(p + 0x018)); // 0270D6AA1108 0x18 Internal_name               ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
