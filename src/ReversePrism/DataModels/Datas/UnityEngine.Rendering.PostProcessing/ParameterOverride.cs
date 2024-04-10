using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OverrideState                            000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class ParameterOverride : DataModel
    {
        public bool                                     OverrideState                           { get; set; }

        public static ParameterOverride? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ParameterOverride() { Pointer= p0 };

            value.OverrideState                             = GetBool(new IntPtr(p + 0x010)); // 0245A60DB870 0x10 OverrideState               ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
