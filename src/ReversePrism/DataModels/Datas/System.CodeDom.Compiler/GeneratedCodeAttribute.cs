using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Tool                                     000186672F10 ModelPrimitiveType string string string String
    // 018 Version                                  000186672F10 ModelPrimitiveType string string string String
    public partial class GeneratedCodeAttribute : DataModel
    {
        public string                                   Tool                                    { get; set; }
        public string                                   Version                                 { get; set; }

        public static GeneratedCodeAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GeneratedCodeAttribute() { Pointer= p0 };

            value.Tool                                      = GetString(new IntPtr(p + 0x010)); // 024667A0A208 0x10 Tool                        ( 000186672F10 ModelPrimitiveType string string string String )
            value.Version                                   = GetString(new IntPtr(p + 0x018)); // 024667A0A228 0x18 Version                     ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
