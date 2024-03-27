using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_InternalSpectralLut                    000186685A20 ModelClassType Texture2D Texture2D Texture2D Pointer
    public partial class ChromaticAberrationRenderer
    {
        public Texture2D?                               M_InternalSpectralLut                   { get; set; }

        public static ChromaticAberrationRenderer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChromaticAberrationRenderer();

            value.M_InternalSpectralLut                     = GetObject<Texture2D>(new IntPtr(p + 0x020), ReversePrism.DataModels.Texture2D.FromPointer); // 027006579C30 0x20 M_InternalSpectralLut       ( 000186685A20 ModelClassType Texture2D Texture2D Texture2D Pointer )

            return value;
        }
    }
}
