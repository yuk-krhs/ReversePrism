using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 GradingMode                              ModelEnumType ColorGradingMode ColorGradingMode ColorGradingMode Int32
    // 014 LutSize                                  ModelPrimitiveType int int int Int32
    // 018 UseFastSRGBLinearConversion              ModelPrimitiveType bool bool bool Bool
    // 019 SupportDataDrivenLensFlare               ModelPrimitiveType bool bool bool Bool
    public partial class PostProcessingData : DataModel
    {
        public ColorGradingMode                         GradingMode                             { get; set; }
        public int                                      LutSize                                 { get; set; }
        public bool                                     UseFastSRGBLinearConversion             { get; set; }
        public bool                                     SupportDataDrivenLensFlare              { get; set; }

        public static PostProcessingData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PostProcessingData() { Pointer= p0 };

            value.GradingMode                               = (ColorGradingMode)GetInt32(new IntPtr(p + 0x010)); // 0x10 GradingMode                 ( ModelEnumType ColorGradingMode ColorGradingMode ColorGradingMode Int32 )
            value.LutSize                                   = GetInt32(new IntPtr(p + 0x014)); // 0x14 LutSize                     ( ModelPrimitiveType int int int Int32 )
            value.UseFastSRGBLinearConversion               = GetBool(new IntPtr(p + 0x018)); // 0x18 UseFastSRGBLinearConversion ( ModelPrimitiveType bool bool bool Bool )
            value.SupportDataDrivenLensFlare                = GetBool(new IntPtr(p + 0x019)); // 0x19 SupportDataDrivenLensFlare  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
