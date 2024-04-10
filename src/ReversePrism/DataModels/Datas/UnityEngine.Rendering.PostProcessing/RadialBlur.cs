using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 QualityLevel                             000186608520 ModelClassType RadialBlurQualityParameter RadialBlurQualityParameter RadialBlurQualityParameter Pointer
    // 038 BlurRadius                               0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 040 RadialCenterX                            0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 048 RadialCenterY                            0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 050 RotateIntensity                          0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    public partial class RadialBlur : DataModel
    {
        public RadialBlurQualityParameter?              QualityLevel                            { get; set; }
        public FloatParameter?                          BlurRadius                              { get; set; }
        public FloatParameter?                          RadialCenterX                           { get; set; }
        public FloatParameter?                          RadialCenterY                           { get; set; }
        public FloatParameter?                          RotateIntensity                         { get; set; }

        public static RadialBlur? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RadialBlur() { Pointer= p0 };

            value.QualityLevel                              = GetObject<RadialBlurQualityParameter>(new IntPtr(p + 0x030), ReversePrism.DataModels.RadialBlurQualityParameter.FromPointer); // 0245A6551F98 0x30 QualityLevel                ( 000186608520 ModelClassType RadialBlurQualityParameter RadialBlurQualityParameter RadialBlurQualityParameter Pointer )
            value.BlurRadius                                = GetObject<FloatParameter>(new IntPtr(p + 0x038), ReversePrism.DataModels.FloatParameter.FromPointer); // 0245A6551FB8 0x38 BlurRadius                  ( 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.RadialCenterX                             = GetObject<FloatParameter>(new IntPtr(p + 0x040), ReversePrism.DataModels.FloatParameter.FromPointer); // 0245A6551FD8 0x40 RadialCenterX               ( 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.RadialCenterY                             = GetObject<FloatParameter>(new IntPtr(p + 0x048), ReversePrism.DataModels.FloatParameter.FromPointer); // 0245A6551FF8 0x48 RadialCenterY               ( 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.RotateIntensity                           = GetObject<FloatParameter>(new IntPtr(p + 0x050), ReversePrism.DataModels.FloatParameter.FromPointer); // 0245A6552018 0x50 RotateIntensity             ( 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer )

            return value;
        }
    }
}
