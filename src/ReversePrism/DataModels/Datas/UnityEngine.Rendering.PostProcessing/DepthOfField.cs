using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 DepthDownSampleLevel                     000186713C40 ModelClassType IntParameter IntParameter IntParameter Pointer
    // 038 DownSampleLevel                          000186713C40 ModelClassType IntParameter IntParameter IntParameter Pointer
    // 040 FocusDistance                            0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 048 Aperture                                 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 050 FocalLength                              0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 058 KernelSize                               00018676B770 ModelClassType KernelSizeParameter KernelSizeParameter KernelSizeParameter Pointer
    public partial class DepthOfField
    {
        public IntParameter?                            DepthDownSampleLevel                    { get; set; }
        public IntParameter?                            DownSampleLevel                         { get; set; }
        public FloatParameter?                          FocusDistance                           { get; set; }
        public FloatParameter?                          Aperture                                { get; set; }
        public FloatParameter?                          FocalLength                             { get; set; }
        public KernelSizeParameter?                     KernelSize                              { get; set; }

        public static DepthOfField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DepthOfField();

            value.DepthDownSampleLevel                      = GetObject<IntParameter>(new IntPtr(p + 0x030), ReversePrism.DataModels.IntParameter.FromPointer); // 027006122468 0x30 DepthDownSampleLevel        ( 000186713C40 ModelClassType IntParameter IntParameter IntParameter Pointer )
            value.DownSampleLevel                           = GetObject<IntParameter>(new IntPtr(p + 0x038), ReversePrism.DataModels.IntParameter.FromPointer); // 027006122488 0x38 DownSampleLevel             ( 000186713C40 ModelClassType IntParameter IntParameter IntParameter Pointer )
            value.FocusDistance                             = GetObject<FloatParameter>(new IntPtr(p + 0x040), ReversePrism.DataModels.FloatParameter.FromPointer); // 0270061224A8 0x40 FocusDistance               ( 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.Aperture                                  = GetObject<FloatParameter>(new IntPtr(p + 0x048), ReversePrism.DataModels.FloatParameter.FromPointer); // 0270061224C8 0x48 Aperture                    ( 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.FocalLength                               = GetObject<FloatParameter>(new IntPtr(p + 0x050), ReversePrism.DataModels.FloatParameter.FromPointer); // 0270061224E8 0x50 FocalLength                 ( 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.KernelSize                                = GetObject<KernelSizeParameter>(new IntPtr(p + 0x058), ReversePrism.DataModels.KernelSizeParameter.FromPointer); // 027006122508 0x58 KernelSize                  ( 00018676B770 ModelClassType KernelSizeParameter KernelSizeParameter KernelSizeParameter Pointer )

            return value;
        }
    }
}
