using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScenarioManager                          ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer
    // 018 VoicePlayer                              ModelClassType InGameResultVoicePlayer InGameResultVoicePlayer InGameResultVoicePlayer Pointer
    // 020 Model3dLoader                            ModelClassType Model3dLoaderForProduceInGameResult Model3dLoaderForProduceInGameResult Model3dLoaderForProduceInGameResult Pointer
    public partial class InGameResultScriptController : DataModel
    {
        public ScenarioManager?                         ScenarioManager                         { get; set; }
        public InGameResultVoicePlayer?                 VoicePlayer                             { get; set; }
        public Model3dLoaderForProduceInGameResult?     Model3dLoader                           { get; set; }

        public static InGameResultScriptController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InGameResultScriptController() { Pointer= p0 };

            value.ScenarioManager                           = GetObject<ScenarioManager>(new IntPtr(p + 0x010), ReversePrism.DataModels.ScenarioManager.FromPointer); // 0x10 ScenarioManager             ( ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer )
            value.VoicePlayer                               = GetObject<InGameResultVoicePlayer>(new IntPtr(p + 0x018), ReversePrism.DataModels.InGameResultVoicePlayer.FromPointer); // 0x18 VoicePlayer                 ( ModelClassType InGameResultVoicePlayer InGameResultVoicePlayer InGameResultVoicePlayer Pointer )
            value.Model3dLoader                             = GetObject<Model3dLoaderForProduceInGameResult>(new IntPtr(p + 0x020), ReversePrism.DataModels.Model3dLoaderForProduceInGameResult.FromPointer); // 0x20 Model3dLoader               ( ModelClassType Model3dLoaderForProduceInGameResult Model3dLoaderForProduceInGameResult Model3dLoaderForProduceInGameResult Pointer )

            return value;
        }
    }
}
