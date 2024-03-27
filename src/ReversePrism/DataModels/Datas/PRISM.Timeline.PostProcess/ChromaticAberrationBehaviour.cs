using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Enable                                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 018 SpectralLut                              000186685F20 ModelClassType Texture2D Texture2D Texture2D Pointer
    // 020 Intensity                                000186666050 ModelPrimitiveType float float float Single
    public partial class ChromaticAberrationBehaviour
    {
        public bool                                     Enable                                  { get; set; }
        public Texture2D?                               SpectralLut                             { get; set; }
        public float                                    Intensity                               { get; set; }

        public static ChromaticAberrationBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChromaticAberrationBehaviour();

            value.Enable                                    = GetBool(new IntPtr(p + 0x010)); // 0270D5074AA8 0x10 Enable                      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.SpectralLut                               = GetObject<Texture2D>(new IntPtr(p + 0x018), ReversePrism.DataModels.Texture2D.FromPointer); // 0270D5074AC8 0x18 SpectralLut                 ( 000186685F20 ModelClassType Texture2D Texture2D Texture2D Pointer )
            value.Intensity                                 = GetSingle(new IntPtr(p + 0x020)); // 0270D5074AE8 0x20 Intensity                   ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
