using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 OnAudioConfigurationChanged              AudioConfigurationChangeHandler IL2CPP_TYPE_CLASS
    // 008 OnAudioSystemShuttingDown                Action IL2CPP_TYPE_CLASS
    // 010 OnAudioSystemStartedUp                   000186679C50 ModelClassType Action Action Action Pointer
    public partial class AudioSettings
    {
        public Action?                                  OnAudioSystemStartedUp                  { get; set; }

        public static AudioSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AudioSettings();

            value.OnAudioSystemStartedUp                    = GetObject<Action>(new IntPtr(p + 0x010), ReversePrism.DataModels.Action.FromPointer); // 0270021BCE88 0x10 OnAudioSystemStartedUp      ( 000186679C50 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
