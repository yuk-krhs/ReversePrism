using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Rule                                     000186672F10 ModelPrimitiveType string string string String
    public partial class TypeInferenceRuleAttribute : DataModel
    {
        public string                                   Rule                                    { get; set; }

        public static TypeInferenceRuleAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeInferenceRuleAttribute() { Pointer= p0 };

            value.Rule                                      = GetString(new IntPtr(p + 0x010)); // 0245A6864498 0x10 Rule                        ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
