using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Compliant                                000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class CLSCompliantAttribute
    {
        public bool                                     Compliant                               { get; set; }

        public static CLSCompliantAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CLSCompliantAttribute();

            value.Compliant                                 = GetBool(new IntPtr(p + 0x010)); // 0270D6992318 0x10 Compliant                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
