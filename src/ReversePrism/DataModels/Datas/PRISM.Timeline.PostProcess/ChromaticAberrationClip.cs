using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Behaviour                                0001865AC4A0 ModelClassType ChromaticAberrationBehaviour ChromaticAberrationBehaviour ChromaticAberrationBehaviour Pointer
    public partial class ChromaticAberrationClip
    {
        public ChromaticAberrationBehaviour?            Behaviour                               { get; set; }

        public static ChromaticAberrationClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChromaticAberrationClip();

            value.Behaviour                                 = GetObject<ChromaticAberrationBehaviour>(new IntPtr(p + 0x018), ReversePrism.DataModels.ChromaticAberrationBehaviour.FromPointer); // 0270D5074B68 0x18 Behaviour                   ( 0001865AC4A0 ModelClassType ChromaticAberrationBehaviour ChromaticAberrationBehaviour ChromaticAberrationBehaviour Pointer )

            return value;
        }
    }
}
