using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 DownSampleLevel                          000186713C40 ModelClassType IntParameter IntParameter IntParameter Pointer
    // 038 Intensity                                0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 040 Threshold                                0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 048 SoftKnee                                 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 050 Clamp                                    0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 058 Diffusion                                0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 060 AnamorphicRatio                          0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 068 Color                                    0001865D1170 ModelClassType ColorParameter ColorParameter ColorParameter Pointer
    // 070 DirtTexture                              0001866553C0 ModelClassType TextureParameter TextureParameter TextureParameter Pointer
    // 078 DirtIntensity                            0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 080 Tiling                                   000186775E00 ModelClassType Vector2Parameter Vector2Parameter Vector2Parameter Pointer
    // 088 Brightness                               0001865D1170 ModelClassType ColorParameter ColorParameter ColorParameter Pointer
    public partial class Bloom
    {
        public IntParameter?                            DownSampleLevel                         { get; set; }
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

        public static Bloom? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Bloom();

            value.DownSampleLevel                           = GetObject<IntParameter>(new IntPtr(p + 0x030), ReversePrism.DataModels.IntParameter.FromPointer); // 02700655EF20 0x30 DownSampleLevel             ( 000186713C40 ModelClassType IntParameter IntParameter IntParameter Pointer )
            value.Intensity                                 = GetObject<FloatParameter>(new IntPtr(p + 0x038), ReversePrism.DataModels.FloatParameter.FromPointer); // 02700655EF40 0x38 Intensity                   ( 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.Threshold                                 = GetObject<FloatParameter>(new IntPtr(p + 0x040), ReversePrism.DataModels.FloatParameter.FromPointer); // 02700655EF60 0x40 Threshold                   ( 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.SoftKnee                                  = GetObject<FloatParameter>(new IntPtr(p + 0x048), ReversePrism.DataModels.FloatParameter.FromPointer); // 02700655EF80 0x48 SoftKnee                    ( 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.Clamp                                     = GetObject<FloatParameter>(new IntPtr(p + 0x050), ReversePrism.DataModels.FloatParameter.FromPointer); // 02700655EFA0 0x50 Clamp                       ( 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.Diffusion                                 = GetObject<FloatParameter>(new IntPtr(p + 0x058), ReversePrism.DataModels.FloatParameter.FromPointer); // 02700655EFC0 0x58 Diffusion                   ( 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.AnamorphicRatio                           = GetObject<FloatParameter>(new IntPtr(p + 0x060), ReversePrism.DataModels.FloatParameter.FromPointer); // 02700655EFE0 0x60 AnamorphicRatio             ( 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.Color                                     = GetObject<ColorParameter>(new IntPtr(p + 0x068), ReversePrism.DataModels.ColorParameter.FromPointer); // 02700655F000 0x68 Color                       ( 0001865D1170 ModelClassType ColorParameter ColorParameter ColorParameter Pointer )
            value.DirtTexture                               = GetObject<TextureParameter>(new IntPtr(p + 0x070), ReversePrism.DataModels.TextureParameter.FromPointer); // 02700655F020 0x70 DirtTexture                 ( 0001866553C0 ModelClassType TextureParameter TextureParameter TextureParameter Pointer )
            value.DirtIntensity                             = GetObject<FloatParameter>(new IntPtr(p + 0x078), ReversePrism.DataModels.FloatParameter.FromPointer); // 02700655F040 0x78 DirtIntensity               ( 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.Tiling                                    = GetObject<Vector2Parameter>(new IntPtr(p + 0x080), ReversePrism.DataModels.Vector2Parameter.FromPointer); // 02700655F060 0x80 Tiling                      ( 000186775E00 ModelClassType Vector2Parameter Vector2Parameter Vector2Parameter Pointer )
            value.Brightness                                = GetObject<ColorParameter>(new IntPtr(p + 0x088), ReversePrism.DataModels.ColorParameter.FromPointer); // 02700655F080 0x88 Brightness                  ( 0001865D1170 ModelClassType ColorParameter ColorParameter ColorParameter Pointer )

            return value;
        }
    }
}
