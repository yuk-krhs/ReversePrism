using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Intensity                                ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer
    // 040 XMultiplier                              ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer
    // 048 YMultiplier                              ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer
    // 050 Center                                   ModelClassType Vector2Parameter Vector2Parameter Vector2Parameter Pointer
    // 058 Scale                                    ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer
    public partial class LensDistortion : DataModel
    {
        public ClampedFloatParameter?                   Intensity                               { get; set; }
        public ClampedFloatParameter?                   XMultiplier                             { get; set; }
        public ClampedFloatParameter?                   YMultiplier                             { get; set; }
        public Vector2Parameter?                        Center                                  { get; set; }
        public ClampedFloatParameter?                   Scale                                   { get; set; }

        public static LensDistortion? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LensDistortion() { Pointer= p0 };

            value.Intensity                                 = GetObject<ClampedFloatParameter>(new IntPtr(p + 0x038), ReversePrism.DataModels.ClampedFloatParameter.FromPointer); // 0x38 Intensity                   ( ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer )
            value.XMultiplier                               = GetObject<ClampedFloatParameter>(new IntPtr(p + 0x040), ReversePrism.DataModels.ClampedFloatParameter.FromPointer); // 0x40 XMultiplier                 ( ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer )
            value.YMultiplier                               = GetObject<ClampedFloatParameter>(new IntPtr(p + 0x048), ReversePrism.DataModels.ClampedFloatParameter.FromPointer); // 0x48 YMultiplier                 ( ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer )
            value.Center                                    = GetObject<Vector2Parameter>(new IntPtr(p + 0x050), ReversePrism.DataModels.Vector2Parameter.FromPointer); // 0x50 Center                      ( ModelClassType Vector2Parameter Vector2Parameter Vector2Parameter Pointer )
            value.Scale                                     = GetObject<ClampedFloatParameter>(new IntPtr(p + 0x058), ReversePrism.DataModels.ClampedFloatParameter.FromPointer); // 0x58 Scale                       ( ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer )

            return value;
        }
    }
}
