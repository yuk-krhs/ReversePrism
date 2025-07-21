using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Behaviour                                ModelClassType ChromaticAberrationBehaviour ChromaticAberrationBehaviour ChromaticAberrationBehaviour Pointer
    public partial class ChromaticAberrationClip : DataModel
    {
        public ChromaticAberrationBehaviour?            Behaviour                               { get; set; }

        public static ChromaticAberrationClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChromaticAberrationClip() { Pointer= p0 };

            value.Behaviour                                 = GetObject<ChromaticAberrationBehaviour>(new IntPtr(p + 0x018), ReversePrism.DataModels.ChromaticAberrationBehaviour.FromPointer); // 0x18 Behaviour                   ( ModelClassType ChromaticAberrationBehaviour ChromaticAberrationBehaviour ChromaticAberrationBehaviour Pointer )

            return value;
        }
    }
}
