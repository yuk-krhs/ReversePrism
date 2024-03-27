using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Message                                  000186671910 ModelPrimitiveType string string string String
    // 018 Error                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ObsoleteAttribute
    {
        public string                                   Message                                 { get; set; }
        public bool                                     Error                                   { get; set; }

        public static ObsoleteAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObsoleteAttribute();

            value.Message                                   = GetString(new IntPtr(p + 0x010)); // 0270D69EF330 0x10 Message                     ( 000186671910 ModelPrimitiveType string string string String )
            value.Error                                     = GetBool(new IntPtr(p + 0x018)); // 0270D69EF350 0x18 Error                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
