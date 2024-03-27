using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     000186567B00 ModelClassType IHomeCharacterMessagePanelView IHomeCharacterMessagePanelView IHomeCharacterMessagePanelView Pointer
    // 018 ScenarioManager                          0001866C9D90 ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer
    // 020 CharaId                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 IsInitialized                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 VoiceCharaIndex                          0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class HomeLoginBonusCharacterMessagePresenter
    {
        public IHomeCharacterMessagePanelView?          View                                    { get; set; }
        public ScenarioManager?                         ScenarioManager                         { get; set; }
        public int                                      CharaId                                 { get; set; }
        public bool                                     IsInitialized                           { get; set; }
        public int                                      VoiceCharaIndex                         { get; set; }

        public static HomeLoginBonusCharacterMessagePresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeLoginBonusCharacterMessagePresenter();

            value.View                                      = GetObject<IHomeCharacterMessagePanelView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IHomeCharacterMessagePanelView.FromPointer); // 0270D636EBD8 0x10 View                        ( 000186567B00 ModelClassType IHomeCharacterMessagePanelView IHomeCharacterMessagePanelView IHomeCharacterMessagePanelView Pointer )
            value.ScenarioManager                           = GetObject<ScenarioManager>(new IntPtr(p + 0x018), ReversePrism.DataModels.ScenarioManager.FromPointer); // 0270D636EBF8 0x18 ScenarioManager             ( 0001866C9D90 ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer )
            value.CharaId                                   = GetInt32(new IntPtr(p + 0x020)); // 0270D636EC18 0x20 CharaId                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x024)); // 0270D636EC38 0x24 IsInitialized               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.VoiceCharaIndex                           = GetInt32(new IntPtr(p + 0x028)); // 0270D636EC58 0x28 VoiceCharaIndex             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
