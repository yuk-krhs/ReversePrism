using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0A0 M_TrackProperties                        000186718290 ModelClassType AudioMixerProperties AudioMixerProperties AudioMixerProperties Pointer
    public partial class AudioTrack : DataModel
    {
        public AudioMixerProperties?                    M_TrackProperties                       { get; set; }

        public static AudioTrack? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AudioTrack() { Pointer= p0 };

            value.M_TrackProperties                         = GetObject<AudioMixerProperties>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.AudioMixerProperties.FromPointer); // 02466B2CB980 0xA0 M_TrackProperties           ( 000186718290 ModelClassType AudioMixerProperties AudioMixerProperties AudioMixerProperties Pointer )

            return value;
        }
    }
}
