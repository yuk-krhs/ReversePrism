using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Condition                                000186671910 ModelPrimitiveType string string string String
    // 018 Enabled                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class NativeConditionalAttribute
    {
        public string                                   Condition                               { get; set; }
        public bool                                     Enabled                                 { get; set; }

        public static NativeConditionalAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeConditionalAttribute();

            value.Condition                                 = GetString(new IntPtr(p + 0x010)); // 027006978BB8 0x10 Condition                   ( 000186671910 ModelPrimitiveType string string string String )
            value.Enabled                                   = GetBool(new IntPtr(p + 0x018)); // 027006978BD8 0x18 Enabled                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
