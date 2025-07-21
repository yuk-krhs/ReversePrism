using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 SkipIterations                           ModelClassType ClampedIntParameter ClampedIntParameter ClampedIntParameter Pointer
    // 040 Threshold                                ModelClassType MinFloatParameter MinFloatParameter MinFloatParameter Pointer
    // 048 Intensity                                ModelClassType MinFloatParameter MinFloatParameter MinFloatParameter Pointer
    // 050 Scatter                                  ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer
    // 058 Clamp                                    ModelClassType MinFloatParameter MinFloatParameter MinFloatParameter Pointer
    // 060 Tint                                     ModelClassType ColorParameter ColorParameter ColorParameter Pointer
    // 068 HighQualityFiltering                     ModelClassType BoolParameter BoolParameter BoolParameter Pointer
    // 070 Downscale                                ModelClassType DownscaleParameter DownscaleParameter DownscaleParameter Pointer
    // 078 MaxIterations                            ModelClassType ClampedIntParameter ClampedIntParameter ClampedIntParameter Pointer
    // 080 DirtTexture                              ModelClassType TextureParameter TextureParameter TextureParameter Pointer
    // 088 DirtIntensity                            ModelClassType MinFloatParameter MinFloatParameter MinFloatParameter Pointer
    public partial class Bloom : DataModel
    {
        public ClampedIntParameter?                     SkipIterations                          { get; set; }
        public MinFloatParameter?                       Threshold                               { get; set; }
        public MinFloatParameter?                       Intensity                               { get; set; }
        public ClampedFloatParameter?                   Scatter                                 { get; set; }
        public MinFloatParameter?                       Clamp                                   { get; set; }
        public ColorParameter?                          Tint                                    { get; set; }
        public BoolParameter?                           HighQualityFiltering                    { get; set; }
        public DownscaleParameter?                      Downscale                               { get; set; }
        public ClampedIntParameter?                     MaxIterations                           { get; set; }
        public TextureParameter?                        DirtTexture                             { get; set; }
        public MinFloatParameter?                       DirtIntensity                           { get; set; }

        public static Bloom? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Bloom() { Pointer= p0 };

            value.SkipIterations                            = GetObject<ClampedIntParameter>(new IntPtr(p + 0x038), ReversePrism.DataModels.ClampedIntParameter.FromPointer); // 0x38 SkipIterations              ( ModelClassType ClampedIntParameter ClampedIntParameter ClampedIntParameter Pointer )
            value.Threshold                                 = GetObject<MinFloatParameter>(new IntPtr(p + 0x040), ReversePrism.DataModels.MinFloatParameter.FromPointer); // 0x40 Threshold                   ( ModelClassType MinFloatParameter MinFloatParameter MinFloatParameter Pointer )
            value.Intensity                                 = GetObject<MinFloatParameter>(new IntPtr(p + 0x048), ReversePrism.DataModels.MinFloatParameter.FromPointer); // 0x48 Intensity                   ( ModelClassType MinFloatParameter MinFloatParameter MinFloatParameter Pointer )
            value.Scatter                                   = GetObject<ClampedFloatParameter>(new IntPtr(p + 0x050), ReversePrism.DataModels.ClampedFloatParameter.FromPointer); // 0x50 Scatter                     ( ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer )
            value.Clamp                                     = GetObject<MinFloatParameter>(new IntPtr(p + 0x058), ReversePrism.DataModels.MinFloatParameter.FromPointer); // 0x58 Clamp                       ( ModelClassType MinFloatParameter MinFloatParameter MinFloatParameter Pointer )
            value.Tint                                      = GetObject<ColorParameter>(new IntPtr(p + 0x060), ReversePrism.DataModels.ColorParameter.FromPointer); // 0x60 Tint                        ( ModelClassType ColorParameter ColorParameter ColorParameter Pointer )
            value.HighQualityFiltering                      = GetObject<BoolParameter>(new IntPtr(p + 0x068), ReversePrism.DataModels.BoolParameter.FromPointer); // 0x68 HighQualityFiltering        ( ModelClassType BoolParameter BoolParameter BoolParameter Pointer )
            value.Downscale                                 = GetObject<DownscaleParameter>(new IntPtr(p + 0x070), ReversePrism.DataModels.DownscaleParameter.FromPointer); // 0x70 Downscale                   ( ModelClassType DownscaleParameter DownscaleParameter DownscaleParameter Pointer )
            value.MaxIterations                             = GetObject<ClampedIntParameter>(new IntPtr(p + 0x078), ReversePrism.DataModels.ClampedIntParameter.FromPointer); // 0x78 MaxIterations               ( ModelClassType ClampedIntParameter ClampedIntParameter ClampedIntParameter Pointer )
            value.DirtTexture                               = GetObject<TextureParameter>(new IntPtr(p + 0x080), ReversePrism.DataModels.TextureParameter.FromPointer); // 0x80 DirtTexture                 ( ModelClassType TextureParameter TextureParameter TextureParameter Pointer )
            value.DirtIntensity                             = GetObject<MinFloatParameter>(new IntPtr(p + 0x088), ReversePrism.DataModels.MinFloatParameter.FromPointer); // 0x88 DirtIntensity               ( ModelClassType MinFloatParameter MinFloatParameter MinFloatParameter Pointer )

            return value;
        }
    }
}
