using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ParameterValue                           ModelPrimitiveType bool bool bool Bool
    public partial class DoesNotReturnIfAttribute : DataModel
    {
        public bool                                     ParameterValue                          { get; set; }

        public static DoesNotReturnIfAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DoesNotReturnIfAttribute() { Pointer= p0 };

            value.ParameterValue                            = GetBool(new IntPtr(p + 0x010)); // 0x10 ParameterValue              ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
