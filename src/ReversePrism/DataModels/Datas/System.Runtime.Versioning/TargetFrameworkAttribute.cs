using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FrameworkName                            ModelPrimitiveType string string string String
    // 018 FrameworkDisplayName                     ModelPrimitiveType string string string String
    public partial class TargetFrameworkAttribute : DataModel
    {
        public string                                   FrameworkName                           { get; set; }
        public string                                   FrameworkDisplayName                    { get; set; }

        public static TargetFrameworkAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TargetFrameworkAttribute() { Pointer= p0 };

            value.FrameworkName                             = GetString(new IntPtr(p + 0x010)); // 0x10 FrameworkName               ( ModelPrimitiveType string string string String )
            value.FrameworkDisplayName                      = GetString(new IntPtr(p + 0x018)); // 0x18 FrameworkDisplayName        ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
