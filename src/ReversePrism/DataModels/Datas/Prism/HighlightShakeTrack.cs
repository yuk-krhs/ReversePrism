using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0A0 MixerBehaviour                           ModelClassType HighlightShakeMixerBehaviour HighlightShakeMixerBehaviour HighlightShakeMixerBehaviour Pointer
    public partial class HighlightShakeTrack : DataModel
    {
        public HighlightShakeMixerBehaviour?            MixerBehaviour                          { get; set; }

        public static HighlightShakeTrack? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HighlightShakeTrack() { Pointer= p0 };

            value.MixerBehaviour                            = GetObject<HighlightShakeMixerBehaviour>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.HighlightShakeMixerBehaviour.FromPointer); // 0xA0 MixerBehaviour              ( ModelClassType HighlightShakeMixerBehaviour HighlightShakeMixerBehaviour HighlightShakeMixerBehaviour Pointer )

            return value;
        }
    }
}
