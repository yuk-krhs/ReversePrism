using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FrameworkName                            000186671910 ModelPrimitiveType string string string String
    // 018 FrameworkDisplayName                     000186671910 ModelPrimitiveType string string string String
    public partial class TargetFrameworkAttribute
    {
        public string                                   FrameworkName                           { get; set; }
        public string                                   FrameworkDisplayName                    { get; set; }

        public static TargetFrameworkAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TargetFrameworkAttribute();

            value.FrameworkName                             = GetString(new IntPtr(p + 0x010)); // 0270D6BECDA8 0x10 FrameworkName               ( 000186671910 ModelPrimitiveType string string string String )
            value.FrameworkDisplayName                      = GetString(new IntPtr(p + 0x018)); // 0270D6BECDC8 0x18 FrameworkDisplayName        ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
