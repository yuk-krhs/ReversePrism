using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ReturnValue                              0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class NotNullWhenAttribute
    {
        public bool                                     ReturnValue                             { get; set; }

        public static NotNullWhenAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NotNullWhenAttribute();

            value.ReturnValue                               = GetBool(new IntPtr(p + 0x010)); // 0270D8671FE8 0x10 ReturnValue                 ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
