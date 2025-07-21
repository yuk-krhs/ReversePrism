using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IHomeCharacterMessagePanelView IHomeCharacterMessagePanelView IHomeCharacterMessagePanelView Pointer
    // 018 ScenarioManager                          ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer
    // 020 CharaId                                  ModelPrimitiveType int int int Int32
    // 024 IsInitialized                            ModelPrimitiveType bool bool bool Bool
    // 028 VoiceCharaIndex                          ModelPrimitiveType int int int Int32
    public partial class HomeLoginBonusCharacterMessagePresenter : DataModel
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
            var value   = new HomeLoginBonusCharacterMessagePresenter() { Pointer= p0 };

            value.View                                      = GetObject<IHomeCharacterMessagePanelView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IHomeCharacterMessagePanelView.FromPointer); // 0x10 View                        ( ModelClassType IHomeCharacterMessagePanelView IHomeCharacterMessagePanelView IHomeCharacterMessagePanelView Pointer )
            value.ScenarioManager                           = GetObject<ScenarioManager>(new IntPtr(p + 0x018), ReversePrism.DataModels.ScenarioManager.FromPointer); // 0x18 ScenarioManager             ( ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer )
            value.CharaId                                   = GetInt32(new IntPtr(p + 0x020)); // 0x20 CharaId                     ( ModelPrimitiveType int int int Int32 )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x024)); // 0x24 IsInitialized               ( ModelPrimitiveType bool bool bool Bool )
            value.VoiceCharaIndex                           = GetInt32(new IntPtr(p + 0x028)); // 0x28 VoiceCharaIndex             ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
