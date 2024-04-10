using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScenarioManager                          0001866C9D90 ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer
    // 018 VoicePlayer                              0001866D9AC0 ModelClassType InGameResultVoicePlayer InGameResultVoicePlayer InGameResultVoicePlayer Pointer
    public partial class InGameResultScriptController : DataModel
    {
        public ScenarioManager?                         ScenarioManager                         { get; set; }
        public InGameResultVoicePlayer?                 VoicePlayer                             { get; set; }

        public static InGameResultScriptController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InGameResultScriptController() { Pointer= p0 };

            value.ScenarioManager                           = GetObject<ScenarioManager>(new IntPtr(p + 0x010), ReversePrism.DataModels.ScenarioManager.FromPointer); // 02466A227658 0x10 ScenarioManager             ( 0001866C9D90 ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer )
            value.VoicePlayer                               = GetObject<InGameResultVoicePlayer>(new IntPtr(p + 0x018), ReversePrism.DataModels.InGameResultVoicePlayer.FromPointer); // 02466A227678 0x18 VoicePlayer                 ( 0001866D9AC0 ModelClassType InGameResultVoicePlayer InGameResultVoicePlayer InGameResultVoicePlayer Pointer )

            return value;
        }
    }
}
