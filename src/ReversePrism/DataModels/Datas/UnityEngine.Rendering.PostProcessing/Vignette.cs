using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 Mode                                     ModelClassType VignetteModeParameter VignetteModeParameter VignetteModeParameter Pointer
    // 038 Color                                    ModelClassType ColorParameter ColorParameter ColorParameter Pointer
    // 040 Center                                   ModelClassType Vector2Parameter Vector2Parameter Vector2Parameter Pointer
    // 048 Intensity                                ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 050 Smoothness                               ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 058 Roundness                                ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 060 Rounded                                  ModelClassType BoolParameter BoolParameter BoolParameter Pointer
    // 068 Mask                                     ModelClassType TextureParameter TextureParameter TextureParameter Pointer
    // 070 Opacity                                  ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    public partial class Vignette : DataModel
    {
        public VignetteModeParameter?                   Mode                                    { get; set; }
        public ColorParameter?                          Color                                   { get; set; }
        public Vector2Parameter?                        Center                                  { get; set; }
        public FloatParameter?                          Intensity                               { get; set; }
        public FloatParameter?                          Smoothness                              { get; set; }
        public FloatParameter?                          Roundness                               { get; set; }
        public BoolParameter?                           Rounded                                 { get; set; }
        public TextureParameter?                        Mask                                    { get; set; }
        public FloatParameter?                          Opacity                                 { get; set; }

        public static Vignette? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Vignette() { Pointer= p0 };

            value.Mode                                      = GetObject<VignetteModeParameter>(new IntPtr(p + 0x030), ReversePrism.DataModels.VignetteModeParameter.FromPointer); // 0x30 Mode                        ( ModelClassType VignetteModeParameter VignetteModeParameter VignetteModeParameter Pointer )
            value.Color                                     = GetObject<ColorParameter>(new IntPtr(p + 0x038), ReversePrism.DataModels.ColorParameter.FromPointer); // 0x38 Color                       ( ModelClassType ColorParameter ColorParameter ColorParameter Pointer )
            value.Center                                    = GetObject<Vector2Parameter>(new IntPtr(p + 0x040), ReversePrism.DataModels.Vector2Parameter.FromPointer); // 0x40 Center                      ( ModelClassType Vector2Parameter Vector2Parameter Vector2Parameter Pointer )
            value.Intensity                                 = GetObject<FloatParameter>(new IntPtr(p + 0x048), ReversePrism.DataModels.FloatParameter.FromPointer); // 0x48 Intensity                   ( ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.Smoothness                                = GetObject<FloatParameter>(new IntPtr(p + 0x050), ReversePrism.DataModels.FloatParameter.FromPointer); // 0x50 Smoothness                  ( ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.Roundness                                 = GetObject<FloatParameter>(new IntPtr(p + 0x058), ReversePrism.DataModels.FloatParameter.FromPointer); // 0x58 Roundness                   ( ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.Rounded                                   = GetObject<BoolParameter>(new IntPtr(p + 0x060), ReversePrism.DataModels.BoolParameter.FromPointer); // 0x60 Rounded                     ( ModelClassType BoolParameter BoolParameter BoolParameter Pointer )
            value.Mask                                      = GetObject<TextureParameter>(new IntPtr(p + 0x068), ReversePrism.DataModels.TextureParameter.FromPointer); // 0x68 Mask                        ( ModelClassType TextureParameter TextureParameter TextureParameter Pointer )
            value.Opacity                                   = GetObject<FloatParameter>(new IntPtr(p + 0x070), ReversePrism.DataModels.FloatParameter.FromPointer); // 0x70 Opacity                     ( ModelClassType FloatParameter FloatParameter FloatParameter Pointer )

            return value;
        }
    }
}
