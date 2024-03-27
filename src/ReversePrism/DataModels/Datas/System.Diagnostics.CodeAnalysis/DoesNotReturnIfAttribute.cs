using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ParameterValue                           0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class DoesNotReturnIfAttribute
    {
        public bool                                     ParameterValue                          { get; set; }

        public static DoesNotReturnIfAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DoesNotReturnIfAttribute();

            value.ParameterValue                            = GetBool(new IntPtr(p + 0x010)); // 0270D86721B8 0x10 ParameterValue              ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
