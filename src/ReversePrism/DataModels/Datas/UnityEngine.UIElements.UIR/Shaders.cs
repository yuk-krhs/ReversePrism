using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_AtlasBlit                              string IL2CPP_TYPE_STRING
    // 008 k_Editor                                 string IL2CPP_TYPE_STRING
    // 010 K_Runtime                                000186674040 ModelPrimitiveType string string string String
    // 018 K_RuntimeWorld                           000186674040 ModelPrimitiveType string string string String
    // 020 K_GraphView                              000186674040 ModelPrimitiveType string string string String
    // 028 K_ColorConversionBlit                    000186674040 ModelPrimitiveType string string string String
    public partial class Shaders
    {
        public string                                   K_Runtime                               { get; set; }
        public string                                   K_RuntimeWorld                          { get; set; }
        public string                                   K_GraphView                             { get; set; }
        public string                                   K_ColorConversionBlit                   { get; set; }

        public static Shaders? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Shaders();

            value.K_Runtime                                 = GetString(new IntPtr(p + 0x010)); // 027006878D30 0x10 K_Runtime                   ( 000186674040 ModelPrimitiveType string string string String )
            value.K_RuntimeWorld                            = GetString(new IntPtr(p + 0x018)); // 027006878D50 0x18 K_RuntimeWorld              ( 000186674040 ModelPrimitiveType string string string String )
            value.K_GraphView                               = GetString(new IntPtr(p + 0x020)); // 027006878D70 0x20 K_GraphView                 ( 000186674040 ModelPrimitiveType string string string String )
            value.K_ColorConversionBlit                     = GetString(new IntPtr(p + 0x028)); // 027006878D90 0x28 K_ColorConversionBlit       ( 000186674040 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
