using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 Intensity                                0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 038 Threshold                                0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 040 SoftKnee                                 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 048 Clamp                                    0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 050 Diffusion                                0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 058 AnamorphicRatio                          0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 060 Color                                    0001865D1170 ModelClassType ColorParameter ColorParameter ColorParameter Pointer
    // 068 DirtTexture                              0001866553C0 ModelClassType TextureParameter TextureParameter TextureParameter Pointer
    // 070 DirtIntensity                            0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 078 Tiling                                   000186775E00 ModelClassType Vector2Parameter Vector2Parameter Vector2Parameter Pointer
    // 080 Brightness                               0001865D1170 ModelClassType ColorParameter ColorParameter ColorParameter Pointer
    public partial class LdrBloom : DataModel
    {
        public FloatParameter?                          Intensity                               { get; set; }
        public FloatParameter?                          Threshold                               { get; set; }
        public FloatParameter?                          SoftKnee                                { get; set; }
        public FloatParameter?                          Clamp                                   { get; set; }
        public FloatParameter?                          Diffusion                               { get; set; }
        public FloatParameter?                          AnamorphicRatio                         { get; set; }
        public ColorParameter?                          Color                                   { get; set; }
        public TextureParameter?                        DirtTexture                             { get; set; }
        public FloatParameter?                          DirtIntensity                           { get; set; }
        public Vector2Parameter?                        Tiling                                  { get; set; }
        public ColorParameter?                          Brightness                              { get; set; }

        public static LdrBloom? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LdrBloom() { Pointer= p0 };

            value.Intensity                                 = GetObject<FloatParameter>(new IntPtr(p + 0x030), ReversePrism.DataModels.FloatParameter.FromPointer); // 0245A60DB700 0x30 Intensity                   ( 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.Threshold                                 = GetObject<FloatParameter>(new IntPtr(p + 0x038), ReversePrism.DataModels.FloatParameter.FromPointer); // 0245A60DB720 0x38 Threshold                   ( 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.SoftKnee                                  = GetObject<FloatParameter>(new IntPtr(p + 0x040), ReversePrism.DataModels.FloatParameter.FromPointer); // 0245A60DB740 0x40 SoftKnee                    ( 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.Clamp                                     = GetObject<FloatParameter>(new IntPtr(p + 0x048), ReversePrism.DataModels.FloatParameter.FromPointer); // 0245A60DB760 0x48 Clamp                       ( 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.Diffusion                                 = GetObject<FloatParameter>(new IntPtr(p + 0x050), ReversePrism.DataModels.FloatParameter.FromPointer); // 0245A60DB780 0x50 Diffusion                   ( 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.AnamorphicRatio                           = GetObject<FloatParameter>(new IntPtr(p + 0x058), ReversePrism.DataModels.FloatParameter.FromPointer); // 0245A60DB7A0 0x58 AnamorphicRatio             ( 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.Color                                     = GetObject<ColorParameter>(new IntPtr(p + 0x060), ReversePrism.DataModels.ColorParameter.FromPointer); // 0245A60DB7C0 0x60 Color                       ( 0001865D1170 ModelClassType ColorParameter ColorParameter ColorParameter Pointer )
            value.DirtTexture                               = GetObject<TextureParameter>(new IntPtr(p + 0x068), ReversePrism.DataModels.TextureParameter.FromPointer); // 0245A60DB7E0 0x68 DirtTexture                 ( 0001866553C0 ModelClassType TextureParameter TextureParameter TextureParameter Pointer )
            value.DirtIntensity                             = GetObject<FloatParameter>(new IntPtr(p + 0x070), ReversePrism.DataModels.FloatParameter.FromPointer); // 0245A60DB800 0x70 DirtIntensity               ( 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.Tiling                                    = GetObject<Vector2Parameter>(new IntPtr(p + 0x078), ReversePrism.DataModels.Vector2Parameter.FromPointer); // 0245A60DB820 0x78 Tiling                      ( 000186775E00 ModelClassType Vector2Parameter Vector2Parameter Vector2Parameter Pointer )
            value.Brightness                                = GetObject<ColorParameter>(new IntPtr(p + 0x080), ReversePrism.DataModels.ColorParameter.FromPointer); // 0245A60DB840 0x80 Brightness                  ( 0001865D1170 ModelClassType ColorParameter ColorParameter ColorParameter Pointer )

            return value;
        }
    }
}
