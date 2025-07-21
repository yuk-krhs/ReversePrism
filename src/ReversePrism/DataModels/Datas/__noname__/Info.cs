using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LipWidth                                 ModelPrimitiveType float float float Single
    // 014 LipHeight                                ModelPrimitiveType float float float Single
    // 018 TonguePosition                           ModelPrimitiveType float float float Single
    // 01C IsLipWidthReleased                       ModelPrimitiveType bool bool bool Bool
    // 01D IsLipHeightReleased                      ModelPrimitiveType bool bool bool Bool
    // 01E IsLipToungueReleased                     ModelPrimitiveType bool bool bool Bool
    public partial class Info : DataModel
    {
        public float                                    LipWidth                                { get; set; }
        public float                                    LipHeight                               { get; set; }
        public float                                    TonguePosition                          { get; set; }
        public bool                                     IsLipWidthReleased                      { get; set; }
        public bool                                     IsLipHeightReleased                     { get; set; }
        public bool                                     IsLipToungueReleased                    { get; set; }

        public static Info? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Info() { Pointer= p0 };

            value.LipWidth                                  = GetSingle(new IntPtr(p + 0x010)); // 0x10 LipWidth                    ( ModelPrimitiveType float float float Single )
            value.LipHeight                                 = GetSingle(new IntPtr(p + 0x014)); // 0x14 LipHeight                   ( ModelPrimitiveType float float float Single )
            value.TonguePosition                            = GetSingle(new IntPtr(p + 0x018)); // 0x18 TonguePosition              ( ModelPrimitiveType float float float Single )
            value.IsLipWidthReleased                        = GetBool(new IntPtr(p + 0x01C)); // 0x1C IsLipWidthReleased          ( ModelPrimitiveType bool bool bool Bool )
            value.IsLipHeightReleased                       = GetBool(new IntPtr(p + 0x01D)); // 0x1D IsLipHeightReleased         ( ModelPrimitiveType bool bool bool Bool )
            value.IsLipToungueReleased                      = GetBool(new IntPtr(p + 0x01E)); // 0x1E IsLipToungueReleased        ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
