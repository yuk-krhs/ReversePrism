using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Value                                    000186671910 ModelPrimitiveType string string string String
    // 018 IsValueSetExplicitly                     000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class EnumMemberAttribute
    {
        public string                                   Value                                   { get; set; }
        public bool                                     IsValueSetExplicitly                    { get; set; }

        public static EnumMemberAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnumMemberAttribute();

            value.Value                                     = GetString(new IntPtr(p + 0x010)); // 0270066A0D08 0x10 Value                       ( 000186671910 ModelPrimitiveType string string string String )
            value.IsValueSetExplicitly                      = GetBool(new IntPtr(p + 0x018)); // 0270066A0D28 0x18 IsValueSetExplicitly        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
