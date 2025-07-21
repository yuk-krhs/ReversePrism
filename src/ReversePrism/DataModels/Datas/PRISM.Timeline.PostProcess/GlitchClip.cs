using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Behaviour                                ModelClassType GlitchBehaviour GlitchBehaviour GlitchBehaviour Pointer
    public partial class GlitchClip : DataModel
    {
        public GlitchBehaviour?                         Behaviour                               { get; set; }

        public static GlitchClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GlitchClip() { Pointer= p0 };

            value.Behaviour                                 = GetObject<GlitchBehaviour>(new IntPtr(p + 0x018), ReversePrism.DataModels.GlitchBehaviour.FromPointer); // 0x18 Behaviour                   ( ModelClassType GlitchBehaviour GlitchBehaviour GlitchBehaviour Pointer )

            return value;
        }
    }
}
