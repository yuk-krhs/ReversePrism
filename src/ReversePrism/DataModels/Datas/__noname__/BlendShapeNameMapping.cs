using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LipWidthOpenName                         0001866722E0 ModelPrimitiveType string string string String
    // 018 LipHeightOpenName                        0001866722E0 ModelPrimitiveType string string string String
    // 020 TonguePosition                           0001866722E0 ModelPrimitiveType string string string String
    // 028 LipWidthCloseName                        0001866722E0 ModelPrimitiveType string string string String
    // 030 A                                        0001866722E0 ModelPrimitiveType string string string String
    // 038 I                                        0001866722E0 ModelPrimitiveType string string string String
    // 040 U                                        0001866722E0 ModelPrimitiveType string string string String
    // 048 E                                        0001866722E0 ModelPrimitiveType string string string String
    // 050 O                                        0001866722E0 ModelPrimitiveType string string string String
    public partial class BlendShapeNameMapping : DataModel
    {
        public string                                   LipWidthOpenName                        { get; set; }
        public string                                   LipHeightOpenName                       { get; set; }
        public string                                   TonguePosition                          { get; set; }
        public string                                   LipWidthCloseName                       { get; set; }
        public string                                   A                                       { get; set; }
        public string                                   I                                       { get; set; }
        public string                                   U                                       { get; set; }
        public string                                   E                                       { get; set; }
        public string                                   O                                       { get; set; }

        public static BlendShapeNameMapping? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BlendShapeNameMapping() { Pointer= p0 };

            value.LipWidthOpenName                          = GetString(new IntPtr(p + 0x010)); // 02466BC27210 0x10 LipWidthOpenName            ( 0001866722E0 ModelPrimitiveType string string string String )
            value.LipHeightOpenName                         = GetString(new IntPtr(p + 0x018)); // 02466BC27230 0x18 LipHeightOpenName           ( 0001866722E0 ModelPrimitiveType string string string String )
            value.TonguePosition                            = GetString(new IntPtr(p + 0x020)); // 02466BC27250 0x20 TonguePosition              ( 0001866722E0 ModelPrimitiveType string string string String )
            value.LipWidthCloseName                         = GetString(new IntPtr(p + 0x028)); // 02466BC27270 0x28 LipWidthCloseName           ( 0001866722E0 ModelPrimitiveType string string string String )
            value.A                                         = GetString(new IntPtr(p + 0x030)); // 02466BC27290 0x30 A                           ( 0001866722E0 ModelPrimitiveType string string string String )
            value.I                                         = GetString(new IntPtr(p + 0x038)); // 02466BC272B0 0x38 I                           ( 0001866722E0 ModelPrimitiveType string string string String )
            value.U                                         = GetString(new IntPtr(p + 0x040)); // 02466BC272D0 0x40 U                           ( 0001866722E0 ModelPrimitiveType string string string String )
            value.E                                         = GetString(new IntPtr(p + 0x048)); // 02466BC272F0 0x48 E                           ( 0001866722E0 ModelPrimitiveType string string string String )
            value.O                                         = GetString(new IntPtr(p + 0x050)); // 02466BC27310 0x50 O                           ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
