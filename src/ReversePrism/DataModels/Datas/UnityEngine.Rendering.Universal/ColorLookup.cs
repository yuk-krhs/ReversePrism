using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Texture                                  ModelClassType TextureParameter TextureParameter TextureParameter Pointer
    // 040 Contribution                             ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer
    public partial class ColorLookup : DataModel
    {
        public TextureParameter?                        Texture                                 { get; set; }
        public ClampedFloatParameter?                   Contribution                            { get; set; }

        public static ColorLookup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColorLookup() { Pointer= p0 };

            value.Texture                                   = GetObject<TextureParameter>(new IntPtr(p + 0x038), ReversePrism.DataModels.TextureParameter.FromPointer); // 0x38 Texture                     ( ModelClassType TextureParameter TextureParameter TextureParameter Pointer )
            value.Contribution                              = GetObject<ClampedFloatParameter>(new IntPtr(p + 0x040), ReversePrism.DataModels.ClampedFloatParameter.FromPointer); // 0x40 Contribution                ( ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer )

            return value;
        }
    }
}
