using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ThrowsException                          000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class NativeThrowsAttribute
    {
        public bool                                     ThrowsException                         { get; set; }

        public static NativeThrowsAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeThrowsAttribute();

            value.ThrowsException                           = GetBool(new IntPtr(p + 0x010)); // 027006979A70 0x10 ThrowsException             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
