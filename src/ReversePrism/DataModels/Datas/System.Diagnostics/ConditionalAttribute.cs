using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ConditionString                          ModelPrimitiveType string string string String
    public partial class ConditionalAttribute : DataModel
    {
        public string                                   ConditionString                         { get; set; }

        public static ConditionalAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConditionalAttribute() { Pointer= p0 };

            value.ConditionString                           = GetString(new IntPtr(p + 0x010)); // 0x10 ConditionString             ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
