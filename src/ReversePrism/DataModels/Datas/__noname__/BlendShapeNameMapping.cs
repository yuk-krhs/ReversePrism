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
    public partial class BlendShapeNameMapping
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
            var value   = new BlendShapeNameMapping();

            value.LipWidthOpenName                          = GetString(new IntPtr(p + 0x010)); // 0270DBBA6CF0 0x10 LipWidthOpenName            ( 0001866722E0 ModelPrimitiveType string string string String )
            value.LipHeightOpenName                         = GetString(new IntPtr(p + 0x018)); // 0270DBBA6D10 0x18 LipHeightOpenName           ( 0001866722E0 ModelPrimitiveType string string string String )
            value.TonguePosition                            = GetString(new IntPtr(p + 0x020)); // 0270DBBA6D30 0x20 TonguePosition              ( 0001866722E0 ModelPrimitiveType string string string String )
            value.LipWidthCloseName                         = GetString(new IntPtr(p + 0x028)); // 0270DBBA6D50 0x28 LipWidthCloseName           ( 0001866722E0 ModelPrimitiveType string string string String )
            value.A                                         = GetString(new IntPtr(p + 0x030)); // 0270DBBA6D70 0x30 A                           ( 0001866722E0 ModelPrimitiveType string string string String )
            value.I                                         = GetString(new IntPtr(p + 0x038)); // 0270DBBA6D90 0x38 I                           ( 0001866722E0 ModelPrimitiveType string string string String )
            value.U                                         = GetString(new IntPtr(p + 0x040)); // 0270DBBA6DB0 0x40 U                           ( 0001866722E0 ModelPrimitiveType string string string String )
            value.E                                         = GetString(new IntPtr(p + 0x048)); // 0270DBBA6DD0 0x48 E                           ( 0001866722E0 ModelPrimitiveType string string string String )
            value.O                                         = GetString(new IntPtr(p + 0x050)); // 0270DBBA6DF0 0x50 O                           ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
