using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 SpectralLut                              ModelClassType TextureParameter TextureParameter TextureParameter Pointer
    // 038 Intensity                                ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    public partial class ChromaticAberration : DataModel
    {
        public TextureParameter?                        SpectralLut                             { get; set; }
        public FloatParameter?                          Intensity                               { get; set; }

        public static ChromaticAberration? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChromaticAberration() { Pointer= p0 };

            value.SpectralLut                               = GetObject<TextureParameter>(new IntPtr(p + 0x030), ReversePrism.DataModels.TextureParameter.FromPointer); // 0x30 SpectralLut                 ( ModelClassType TextureParameter TextureParameter TextureParameter Pointer )
            value.Intensity                                 = GetObject<FloatParameter>(new IntPtr(p + 0x038), ReversePrism.DataModels.FloatParameter.FromPointer); // 0x38 Intensity                   ( ModelClassType FloatParameter FloatParameter FloatParameter Pointer )

            return value;
        }
    }
}
