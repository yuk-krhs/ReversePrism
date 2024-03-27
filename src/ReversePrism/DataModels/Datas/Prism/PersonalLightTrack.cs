using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0A0 MixerBehaviour                           000186737790 ModelClassType PersonalLightMixerBehaviour PersonalLightMixerBehaviour PersonalLightMixerBehaviour Pointer
    public partial class PersonalLightTrack
    {
        public PersonalLightMixerBehaviour?             MixerBehaviour                          { get; set; }

        public static PersonalLightTrack? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PersonalLightTrack();

            value.MixerBehaviour                            = GetObject<PersonalLightMixerBehaviour>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.PersonalLightMixerBehaviour.FromPointer); // 027005BE1A50 0xA0 MixerBehaviour              ( 000186737790 ModelClassType PersonalLightMixerBehaviour PersonalLightMixerBehaviour PersonalLightMixerBehaviour Pointer )

            return value;
        }
    }
}
