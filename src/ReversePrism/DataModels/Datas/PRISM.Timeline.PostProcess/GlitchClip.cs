using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Behaviour                                000186679DF0 ModelClassType GlitchBehaviour GlitchBehaviour GlitchBehaviour Pointer
    public partial class GlitchClip
    {
        public GlitchBehaviour?                         Behaviour                               { get; set; }

        public static GlitchClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GlitchClip();

            value.Behaviour                                 = GetObject<GlitchBehaviour>(new IntPtr(p + 0x018), ReversePrism.DataModels.GlitchBehaviour.FromPointer); // 0270D50752F8 0x18 Behaviour                   ( 000186679DF0 ModelClassType GlitchBehaviour GlitchBehaviour GlitchBehaviour Pointer )

            return value;
        }
    }
}
