using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0A0 M_PostPlaybackState                      00018668A020 ModelEnumType PostPlaybackState PostPlaybackState PostPlaybackState Int32
    // 0A8 M_ActivationMixer                        00018667E9C0 ModelClassType ActivationMixerPlayable ActivationMixerPlayable ActivationMixerPlayable Pointer
    public partial class ActivationTrack
    {
        public PostPlaybackState                        M_PostPlaybackState                     { get; set; }
        public ActivationMixerPlayable?                 M_ActivationMixer                       { get; set; }

        public static ActivationTrack? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ActivationTrack();

            value.M_PostPlaybackState                       = (PostPlaybackState)GetInt32(new IntPtr(p + 0x0A0)); // 0270DB232AE8 0xA0 M_PostPlaybackState         ( 00018668A020 ModelEnumType PostPlaybackState PostPlaybackState PostPlaybackState Int32 )
            value.M_ActivationMixer                         = GetObject<ActivationMixerPlayable>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.ActivationMixerPlayable.FromPointer); // 0270DB232B08 0xA8 M_ActivationMixer           ( 00018667E9C0 ModelClassType ActivationMixerPlayable ActivationMixerPlayable ActivationMixerPlayable Pointer )

            return value;
        }
    }
}
