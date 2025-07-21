using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 Intensity                                ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 038 IntensityX                               ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 040 IntensityY                               ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 048 CenterX                                  ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 050 CenterY                                  ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 058 Scale                                    ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    public partial class LensDistortion : DataModel
    {
        public FloatParameter?                          Intensity                               { get; set; }
        public FloatParameter?                          IntensityX                              { get; set; }
        public FloatParameter?                          IntensityY                              { get; set; }
        public FloatParameter?                          CenterX                                 { get; set; }
        public FloatParameter?                          CenterY                                 { get; set; }
        public FloatParameter?                          Scale                                   { get; set; }

        public static LensDistortion? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LensDistortion() { Pointer= p0 };

            value.Intensity                                 = GetObject<FloatParameter>(new IntPtr(p + 0x030), ReversePrism.DataModels.FloatParameter.FromPointer); // 0x30 Intensity                   ( ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.IntensityX                                = GetObject<FloatParameter>(new IntPtr(p + 0x038), ReversePrism.DataModels.FloatParameter.FromPointer); // 0x38 IntensityX                  ( ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.IntensityY                                = GetObject<FloatParameter>(new IntPtr(p + 0x040), ReversePrism.DataModels.FloatParameter.FromPointer); // 0x40 IntensityY                  ( ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.CenterX                                   = GetObject<FloatParameter>(new IntPtr(p + 0x048), ReversePrism.DataModels.FloatParameter.FromPointer); // 0x48 CenterX                     ( ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.CenterY                                   = GetObject<FloatParameter>(new IntPtr(p + 0x050), ReversePrism.DataModels.FloatParameter.FromPointer); // 0x50 CenterY                     ( ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.Scale                                     = GetObject<FloatParameter>(new IntPtr(p + 0x058), ReversePrism.DataModels.FloatParameter.FromPointer); // 0x58 Scale                       ( ModelClassType FloatParameter FloatParameter FloatParameter Pointer )

            return value;
        }
    }
}
