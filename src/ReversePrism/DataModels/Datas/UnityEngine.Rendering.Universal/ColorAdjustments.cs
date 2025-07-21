using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 PostExposure                             ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 040 Contrast                                 ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer
    // 048 ColorFilter                              ModelClassType ColorParameter ColorParameter ColorParameter Pointer
    // 050 HueShift                                 ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer
    // 058 Saturation                               ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer
    public partial class ColorAdjustments : DataModel
    {
        public FloatParameter?                          PostExposure                            { get; set; }
        public ClampedFloatParameter?                   Contrast                                { get; set; }
        public ColorParameter?                          ColorFilter                             { get; set; }
        public ClampedFloatParameter?                   HueShift                                { get; set; }
        public ClampedFloatParameter?                   Saturation                              { get; set; }

        public static ColorAdjustments? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColorAdjustments() { Pointer= p0 };

            value.PostExposure                              = GetObject<FloatParameter>(new IntPtr(p + 0x038), ReversePrism.DataModels.FloatParameter.FromPointer); // 0x38 PostExposure                ( ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.Contrast                                  = GetObject<ClampedFloatParameter>(new IntPtr(p + 0x040), ReversePrism.DataModels.ClampedFloatParameter.FromPointer); // 0x40 Contrast                    ( ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer )
            value.ColorFilter                               = GetObject<ColorParameter>(new IntPtr(p + 0x048), ReversePrism.DataModels.ColorParameter.FromPointer); // 0x48 ColorFilter                 ( ModelClassType ColorParameter ColorParameter ColorParameter Pointer )
            value.HueShift                                  = GetObject<ClampedFloatParameter>(new IntPtr(p + 0x050), ReversePrism.DataModels.ClampedFloatParameter.FromPointer); // 0x50 HueShift                    ( ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer )
            value.Saturation                                = GetObject<ClampedFloatParameter>(new IntPtr(p + 0x058), ReversePrism.DataModels.ClampedFloatParameter.FromPointer); // 0x58 Saturation                  ( ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer )

            return value;
        }
    }
}
