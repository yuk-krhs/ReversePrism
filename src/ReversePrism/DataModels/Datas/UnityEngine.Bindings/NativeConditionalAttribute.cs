using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Condition                                ModelPrimitiveType string string string String
    // 018 Enabled                                  ModelPrimitiveType bool bool bool Bool
    public partial class NativeConditionalAttribute : DataModel
    {
        public string                                   Condition                               { get; set; }
        public bool                                     Enabled                                 { get; set; }

        public static NativeConditionalAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeConditionalAttribute() { Pointer= p0 };

            value.Condition                                 = GetString(new IntPtr(p + 0x010)); // 0x10 Condition                   ( ModelPrimitiveType string string string String )
            value.Enabled                                   = GetBool(new IntPtr(p + 0x018)); // 0x18 Enabled                     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
