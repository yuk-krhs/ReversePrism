using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 DepthDownSampleLevel                     ModelClassType IntParameter IntParameter IntParameter Pointer
    // 038 DownSampleLevel                          ModelClassType IntParameter IntParameter IntParameter Pointer
    // 040 FocusDistance                            ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 048 Aperture                                 ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 050 FocalLength                              ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 058 KernelSize                               ModelClassType KernelSizeParameter KernelSizeParameter KernelSizeParameter Pointer
    public partial class DepthOfField : DataModel
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
            var value   = new DepthOfField() { Pointer= p0 };

            value.DepthDownSampleLevel                      = GetObject<IntParameter>(new IntPtr(p + 0x030), ReversePrism.DataModels.IntParameter.FromPointer); // 0x30 DepthDownSampleLevel        ( ModelClassType IntParameter IntParameter IntParameter Pointer )
            value.DownSampleLevel                           = GetObject<IntParameter>(new IntPtr(p + 0x038), ReversePrism.DataModels.IntParameter.FromPointer); // 0x38 DownSampleLevel             ( ModelClassType IntParameter IntParameter IntParameter Pointer )
            value.FocusDistance                             = GetObject<FloatParameter>(new IntPtr(p + 0x040), ReversePrism.DataModels.FloatParameter.FromPointer); // 0x40 FocusDistance               ( ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.Aperture                                  = GetObject<FloatParameter>(new IntPtr(p + 0x048), ReversePrism.DataModels.FloatParameter.FromPointer); // 0x48 Aperture                    ( ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.FocalLength                               = GetObject<FloatParameter>(new IntPtr(p + 0x050), ReversePrism.DataModels.FloatParameter.FromPointer); // 0x50 FocalLength                 ( ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.KernelSize                                = GetObject<KernelSizeParameter>(new IntPtr(p + 0x058), ReversePrism.DataModels.KernelSizeParameter.FromPointer); // 0x58 KernelSize                  ( ModelClassType KernelSizeParameter KernelSizeParameter KernelSizeParameter Pointer )

            return value;
        }
    }
}
