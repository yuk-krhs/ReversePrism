using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0A0 MixerBehaviour                           0001865FC230 ModelClassType SwayBoneWindMixerBehaviour SwayBoneWindMixerBehaviour SwayBoneWindMixerBehaviour Pointer
    public partial class SwayBoneWindTrack
    {
        public SwayBoneWindMixerBehaviour?              MixerBehaviour                          { get; set; }

        public static SwayBoneWindTrack? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SwayBoneWindTrack();

            value.MixerBehaviour                            = GetObject<SwayBoneWindMixerBehaviour>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.SwayBoneWindMixerBehaviour.FromPointer); // 0270D4E001F8 0xA0 MixerBehaviour              ( 0001865FC230 ModelClassType SwayBoneWindMixerBehaviour SwayBoneWindMixerBehaviour SwayBoneWindMixerBehaviour Pointer )

            return value;
        }
    }
}
