using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Mode                                     ModelClassType MotionBlurModeParameter MotionBlurModeParameter MotionBlurModeParameter Pointer
    // 040 Quality                                  ModelClassType MotionBlurQualityParameter MotionBlurQualityParameter MotionBlurQualityParameter Pointer
    // 048 Intensity                                ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer
    // 050 Clamp                                    ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer
    public partial class MotionBlur : DataModel
    {
        public MotionBlurModeParameter?                 Mode                                    { get; set; }
        public MotionBlurQualityParameter?              Quality                                 { get; set; }
        public ClampedFloatParameter?                   Intensity                               { get; set; }
        public ClampedFloatParameter?                   Clamp                                   { get; set; }

        public static MotionBlur? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MotionBlur() { Pointer= p0 };

            value.Mode                                      = GetObject<MotionBlurModeParameter>(new IntPtr(p + 0x038), ReversePrism.DataModels.MotionBlurModeParameter.FromPointer); // 0x38 Mode                        ( ModelClassType MotionBlurModeParameter MotionBlurModeParameter MotionBlurModeParameter Pointer )
            value.Quality                                   = GetObject<MotionBlurQualityParameter>(new IntPtr(p + 0x040), ReversePrism.DataModels.MotionBlurQualityParameter.FromPointer); // 0x40 Quality                     ( ModelClassType MotionBlurQualityParameter MotionBlurQualityParameter MotionBlurQualityParameter Pointer )
            value.Intensity                                 = GetObject<ClampedFloatParameter>(new IntPtr(p + 0x048), ReversePrism.DataModels.ClampedFloatParameter.FromPointer); // 0x48 Intensity                   ( ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer )
            value.Clamp                                     = GetObject<ClampedFloatParameter>(new IntPtr(p + 0x050), ReversePrism.DataModels.ClampedFloatParameter.FromPointer); // 0x50 Clamp                       ( ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer )

            return value;
        }
    }
}
