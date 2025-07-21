using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LipWidthOpenName                         ModelPrimitiveType string string string String
    // 018 LipHeightOpenName                        ModelPrimitiveType string string string String
    // 020 TonguePosition                           ModelPrimitiveType string string string String
    // 028 LipWidthCloseName                        ModelPrimitiveType string string string String
    // 030 A                                        ModelPrimitiveType string string string String
    // 038 I                                        ModelPrimitiveType string string string String
    // 040 U                                        ModelPrimitiveType string string string String
    // 048 E                                        ModelPrimitiveType string string string String
    // 050 O                                        ModelPrimitiveType string string string String
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

            value.LipWidthOpenName                          = GetString(new IntPtr(p + 0x010)); // 0x10 LipWidthOpenName            ( ModelPrimitiveType string string string String )
            value.LipHeightOpenName                         = GetString(new IntPtr(p + 0x018)); // 0x18 LipHeightOpenName           ( ModelPrimitiveType string string string String )
            value.TonguePosition                            = GetString(new IntPtr(p + 0x020)); // 0x20 TonguePosition              ( ModelPrimitiveType string string string String )
            value.LipWidthCloseName                         = GetString(new IntPtr(p + 0x028)); // 0x28 LipWidthCloseName           ( ModelPrimitiveType string string string String )
            value.A                                         = GetString(new IntPtr(p + 0x030)); // 0x30 A                           ( ModelPrimitiveType string string string String )
            value.I                                         = GetString(new IntPtr(p + 0x038)); // 0x38 I                           ( ModelPrimitiveType string string string String )
            value.U                                         = GetString(new IntPtr(p + 0x040)); // 0x40 U                           ( ModelPrimitiveType string string string String )
            value.E                                         = GetString(new IntPtr(p + 0x048)); // 0x48 E                           ( ModelPrimitiveType string string string String )
            value.O                                         = GetString(new IntPtr(p + 0x050)); // 0x50 O                           ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
