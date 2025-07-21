using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ReturnValue                              ModelPrimitiveType bool bool bool Bool
    public partial class NotNullWhenAttribute : DataModel
    {
        public bool                                     ReturnValue                             { get; set; }

        public static NotNullWhenAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NotNullWhenAttribute() { Pointer= p0 };

            value.ReturnValue                               = GetBool(new IntPtr(p + 0x010)); // 0x10 ReturnValue                 ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
