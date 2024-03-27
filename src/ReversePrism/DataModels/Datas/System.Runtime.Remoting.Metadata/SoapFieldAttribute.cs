using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 ElementName                              000186671910 ModelPrimitiveType string string string String
    // 030 IsElement                                000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class SoapFieldAttribute
    {
        public string                                   ElementName                             { get; set; }
        public bool                                     IsElement                               { get; set; }

        public static SoapFieldAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SoapFieldAttribute();

            value.ElementName                               = GetString(new IntPtr(p + 0x028)); // 0270D6BE6D80 0x28 ElementName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.IsElement                                 = GetBool(new IntPtr(p + 0x030)); // 0270D6BE6DA0 0x30 IsElement                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
