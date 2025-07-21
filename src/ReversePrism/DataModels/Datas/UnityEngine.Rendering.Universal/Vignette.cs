using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Color                                    ModelClassType ColorParameter ColorParameter ColorParameter Pointer
    // 040 Center                                   ModelClassType Vector2Parameter Vector2Parameter Vector2Parameter Pointer
    // 048 Intensity                                ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer
    // 050 Smoothness                               ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer
    // 058 Rounded                                  ModelClassType BoolParameter BoolParameter BoolParameter Pointer
    public partial class Vignette : DataModel
    {
        public ColorParameter?                          Color                                   { get; set; }
        public Vector2Parameter?                        Center                                  { get; set; }
        public ClampedFloatParameter?                   Intensity                               { get; set; }
        public ClampedFloatParameter?                   Smoothness                              { get; set; }
        public BoolParameter?                           Rounded                                 { get; set; }

        public static Vignette? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Vignette() { Pointer= p0 };

            value.Color                                     = GetObject<ColorParameter>(new IntPtr(p + 0x038), ReversePrism.DataModels.ColorParameter.FromPointer); // 0x38 Color                       ( ModelClassType ColorParameter ColorParameter ColorParameter Pointer )
            value.Center                                    = GetObject<Vector2Parameter>(new IntPtr(p + 0x040), ReversePrism.DataModels.Vector2Parameter.FromPointer); // 0x40 Center                      ( ModelClassType Vector2Parameter Vector2Parameter Vector2Parameter Pointer )
            value.Intensity                                 = GetObject<ClampedFloatParameter>(new IntPtr(p + 0x048), ReversePrism.DataModels.ClampedFloatParameter.FromPointer); // 0x48 Intensity                   ( ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer )
            value.Smoothness                                = GetObject<ClampedFloatParameter>(new IntPtr(p + 0x050), ReversePrism.DataModels.ClampedFloatParameter.FromPointer); // 0x50 Smoothness                  ( ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer )
            value.Rounded                                   = GetObject<BoolParameter>(new IntPtr(p + 0x058), ReversePrism.DataModels.BoolParameter.FromPointer); // 0x58 Rounded                     ( ModelClassType BoolParameter BoolParameter BoolParameter Pointer )

            return value;
        }
    }
}
