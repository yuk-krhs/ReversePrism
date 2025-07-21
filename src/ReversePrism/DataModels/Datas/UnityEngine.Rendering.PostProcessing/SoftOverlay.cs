using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 DownSampleLevel                          ModelClassType IntParameter IntParameter IntParameter Pointer
    // 038 Weight                                   ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 040 ScalingWeight                            ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 048 Diffusion                                ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    public partial class SoftOverlay : DataModel
    {
        public IntParameter?                            DownSampleLevel                         { get; set; }
        public FloatParameter?                          Weight                                  { get; set; }
        public FloatParameter?                          ScalingWeight                           { get; set; }
        public FloatParameter?                          Diffusion                               { get; set; }

        public static SoftOverlay? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SoftOverlay() { Pointer= p0 };

            value.DownSampleLevel                           = GetObject<IntParameter>(new IntPtr(p + 0x030), ReversePrism.DataModels.IntParameter.FromPointer); // 0x30 DownSampleLevel             ( ModelClassType IntParameter IntParameter IntParameter Pointer )
            value.Weight                                    = GetObject<FloatParameter>(new IntPtr(p + 0x038), ReversePrism.DataModels.FloatParameter.FromPointer); // 0x38 Weight                      ( ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.ScalingWeight                             = GetObject<FloatParameter>(new IntPtr(p + 0x040), ReversePrism.DataModels.FloatParameter.FromPointer); // 0x40 ScalingWeight               ( ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.Diffusion                                 = GetObject<FloatParameter>(new IntPtr(p + 0x048), ReversePrism.DataModels.FloatParameter.FromPointer); // 0x48 Diffusion                   ( ModelClassType FloatParameter FloatParameter FloatParameter Pointer )

            return value;
        }
    }
}
