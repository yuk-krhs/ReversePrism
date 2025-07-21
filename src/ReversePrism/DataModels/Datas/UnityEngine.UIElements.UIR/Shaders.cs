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
    // 010 K_Runtime                                ModelPrimitiveType string string string String
    // 018 K_RuntimeWorld                           ModelPrimitiveType string string string String
    // 020 K_GraphView                              ModelPrimitiveType string string string String
    // 028 K_ColorConversionBlit                    ModelPrimitiveType string string string String
    public partial class Shaders : DataModel
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
            var value   = new Shaders() { Pointer= p0 };

            value.K_Runtime                                 = GetString(new IntPtr(p + 0x010)); // 0x10 K_Runtime                   ( ModelPrimitiveType string string string String )
            value.K_RuntimeWorld                            = GetString(new IntPtr(p + 0x018)); // 0x18 K_RuntimeWorld              ( ModelPrimitiveType string string string String )
            value.K_GraphView                               = GetString(new IntPtr(p + 0x020)); // 0x20 K_GraphView                 ( ModelPrimitiveType string string string String )
            value.K_ColorConversionBlit                     = GetString(new IntPtr(p + 0x028)); // 0x28 K_ColorConversionBlit       ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
