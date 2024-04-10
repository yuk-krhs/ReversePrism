using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 Mode                                     000186525540 ModelClassType VignetteModeParameter VignetteModeParameter VignetteModeParameter Pointer
    // 038 Color                                    0001865D1170 ModelClassType ColorParameter ColorParameter ColorParameter Pointer
    // 040 Center                                   000186775E00 ModelClassType Vector2Parameter Vector2Parameter Vector2Parameter Pointer
    // 048 Intensity                                0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 050 Smoothness                               0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 058 Roundness                                0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 060 Rounded                                  000186768DE0 ModelClassType BoolParameter BoolParameter BoolParameter Pointer
    // 068 Mask                                     0001866553C0 ModelClassType TextureParameter TextureParameter TextureParameter Pointer
    // 070 Opacity                                  0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer
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

            value.Mode                                      = GetObject<VignetteModeParameter>(new IntPtr(p + 0x030), ReversePrism.DataModels.VignetteModeParameter.FromPointer); // 0245A6553298 0x30 Mode                        ( 000186525540 ModelClassType VignetteModeParameter VignetteModeParameter VignetteModeParameter Pointer )
            value.Color                                     = GetObject<ColorParameter>(new IntPtr(p + 0x038), ReversePrism.DataModels.ColorParameter.FromPointer); // 0245A65532B8 0x38 Color                       ( 0001865D1170 ModelClassType ColorParameter ColorParameter ColorParameter Pointer )
            value.Center                                    = GetObject<Vector2Parameter>(new IntPtr(p + 0x040), ReversePrism.DataModels.Vector2Parameter.FromPointer); // 0245A65532D8 0x40 Center                      ( 000186775E00 ModelClassType Vector2Parameter Vector2Parameter Vector2Parameter Pointer )
            value.Intensity                                 = GetObject<FloatParameter>(new IntPtr(p + 0x048), ReversePrism.DataModels.FloatParameter.FromPointer); // 0245A65532F8 0x48 Intensity                   ( 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.Smoothness                                = GetObject<FloatParameter>(new IntPtr(p + 0x050), ReversePrism.DataModels.FloatParameter.FromPointer); // 0245A6553318 0x50 Smoothness                  ( 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.Roundness                                 = GetObject<FloatParameter>(new IntPtr(p + 0x058), ReversePrism.DataModels.FloatParameter.FromPointer); // 0245A6553338 0x58 Roundness                   ( 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.Rounded                                   = GetObject<BoolParameter>(new IntPtr(p + 0x060), ReversePrism.DataModels.BoolParameter.FromPointer); // 0245A6553358 0x60 Rounded                     ( 000186768DE0 ModelClassType BoolParameter BoolParameter BoolParameter Pointer )
            value.Mask                                      = GetObject<TextureParameter>(new IntPtr(p + 0x068), ReversePrism.DataModels.TextureParameter.FromPointer); // 0245A6553378 0x68 Mask                        ( 0001866553C0 ModelClassType TextureParameter TextureParameter TextureParameter Pointer )
            value.Opacity                                   = GetObject<FloatParameter>(new IntPtr(p + 0x070), ReversePrism.DataModels.FloatParameter.FromPointer); // 0245A6553398 0x70 Opacity                     ( 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer )

            return value;
        }
    }
}
