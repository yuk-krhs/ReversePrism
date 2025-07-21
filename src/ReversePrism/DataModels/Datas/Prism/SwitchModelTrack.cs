using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0A0 MixerBehaviour                           ModelClassType SwitchModelMixerBehaviour SwitchModelMixerBehaviour SwitchModelMixerBehaviour Pointer
    public partial class SwitchModelTrack : DataModel
    {
        public SwitchModelMixerBehaviour?               MixerBehaviour                          { get; set; }

        public static SwitchModelTrack? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SwitchModelTrack() { Pointer= p0 };

            value.MixerBehaviour                            = GetObject<SwitchModelMixerBehaviour>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.SwitchModelMixerBehaviour.FromPointer); // 0xA0 MixerBehaviour              ( ModelClassType SwitchModelMixerBehaviour SwitchModelMixerBehaviour SwitchModelMixerBehaviour Pointer )

            return value;
        }
    }
}
