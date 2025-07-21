using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 WrapNonExceptionThrows                   ModelPrimitiveType bool bool bool Bool
    public partial class RuntimeCompatibilityAttribute : DataModel
    {
        public bool                                     WrapNonExceptionThrows                  { get; set; }

        public static RuntimeCompatibilityAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RuntimeCompatibilityAttribute() { Pointer= p0 };

            value.WrapNonExceptionThrows                    = GetBool(new IntPtr(p + 0x010)); // 0x10 WrapNonExceptionThrows      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
