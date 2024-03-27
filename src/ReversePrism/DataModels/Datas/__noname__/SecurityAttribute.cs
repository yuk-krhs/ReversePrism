using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186671910 ModelPrimitiveType string string string String
    // 018 Value                                    000186671910 ModelPrimitiveType string string string String
    public partial class SecurityAttribute
    {
        public string                                   Name                                    { get; set; }
        public string                                   Value                                   { get; set; }

        public static SecurityAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SecurityAttribute();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0270D6B69B28 0x10 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Value                                     = GetString(new IntPtr(p + 0x018)); // 0270D6B69B48 0x18 Value                       ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
