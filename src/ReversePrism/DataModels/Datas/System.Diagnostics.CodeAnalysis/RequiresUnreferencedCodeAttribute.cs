using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Message                                  ModelPrimitiveType string string string String
    // 018 Url                                      ModelPrimitiveType string string string String
    public partial class RequiresUnreferencedCodeAttribute : DataModel
    {
        public string                                   Message                                 { get; set; }
        public string                                   Url                                     { get; set; }

        public static RequiresUnreferencedCodeAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RequiresUnreferencedCodeAttribute() { Pointer= p0 };

            value.Message                                   = GetString(new IntPtr(p + 0x010)); // 0x10 Message                     ( ModelPrimitiveType string string string String )
            value.Url                                       = GetString(new IntPtr(p + 0x018)); // 0x18 Url                         ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
