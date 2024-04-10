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
    public partial class EnumMemberAttribute : DataModel
    {
        public string                                   Value                                   { get; set; }
        public bool                                     IsValueSetExplicitly                    { get; set; }

        public static EnumMemberAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnumMemberAttribute() { Pointer= p0 };

            value.Value                                     = GetString(new IntPtr(p + 0x010)); // 0245A66698E0 0x10 Value                       ( 000186671910 ModelPrimitiveType string string string String )
            value.IsValueSetExplicitly                      = GetBool(new IntPtr(p + 0x018)); // 0245A6669900 0x18 IsValueSetExplicitly        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
