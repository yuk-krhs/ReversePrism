using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0A0 MixerBehaviour                           0001865FB3F0 ModelClassType SwayBoneRateMixerBehaviour SwayBoneRateMixerBehaviour SwayBoneRateMixerBehaviour Pointer
    public partial class SwayBoneRateTrack
    {
        public SwayBoneRateMixerBehaviour?              MixerBehaviour                          { get; set; }

        public static SwayBoneRateTrack? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SwayBoneRateTrack();

            value.MixerBehaviour                            = GetObject<SwayBoneRateMixerBehaviour>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.SwayBoneRateMixerBehaviour.FromPointer); // 0270D4DFFAB8 0xA0 MixerBehaviour              ( 0001865FB3F0 ModelClassType SwayBoneRateMixerBehaviour SwayBoneRateMixerBehaviour SwayBoneRateMixerBehaviour Pointer )

            return value;
        }
    }
}
