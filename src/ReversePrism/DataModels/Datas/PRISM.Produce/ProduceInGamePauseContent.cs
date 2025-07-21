using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 InGameType                               ModelEnumType InGameType InGameType InGameType Int32
    // 028 onPause                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 030 onUnPause                                Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 038 onApplyProduceOption                     Subject`1<ProduceOptionSaveData> IL2CPP_TYPE_GENERICINST
    // 040 onClickRetry                             Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 048 onClickGiveUp                            Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 050 PauseButton                              ModelClassType UIButton UIButton UIButton Pointer
    // 058 BlackBG                                  ModelClassType GameObject GameObject GameObject Pointer
    // 060 PopupCaller                              ModelClassType ProduceInGamePausePopupCaller ProduceInGamePausePopupCaller ProduceInGamePausePopupCaller Pointer
    // 068 ChallengeTourPopupCaller                 ModelClassType ChallengeTourInGamePausePopupCaller ChallengeTourInGamePausePopupCaller ChallengeTourInGamePausePopupCaller Pointer
    // 070 SuspendUnPauseButton                     ModelClassType UIButton UIButton UIButton Pointer
    public partial class ProduceInGamePauseContent : DataModel
    {
        public InGameType                               InGameType                              { get; set; }
        public UIButton?                                PauseButton                             { get; set; }
        public GameObject?                              BlackBG                                 { get; set; }
        public ProduceInGamePausePopupCaller?           PopupCaller                             { get; set; }
        public ChallengeTourInGamePausePopupCaller?     ChallengeTourPopupCaller                { get; set; }
        public UIButton?                                SuspendUnPauseButton                    { get; set; }

        public static ProduceInGamePauseContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceInGamePauseContent() { Pointer= p0 };

            value.InGameType                                = (InGameType)GetInt32(new IntPtr(p + 0x020)); // 0x20 InGameType                  ( ModelEnumType InGameType InGameType InGameType Int32 )
            value.PauseButton                               = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0x50 PauseButton                 ( ModelClassType UIButton UIButton UIButton Pointer )
            value.BlackBG                                   = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 BlackBG                     ( ModelClassType GameObject GameObject GameObject Pointer )
            value.PopupCaller                               = GetObject<ProduceInGamePausePopupCaller>(new IntPtr(p + 0x060), ReversePrism.DataModels.ProduceInGamePausePopupCaller.FromPointer); // 0x60 PopupCaller                 ( ModelClassType ProduceInGamePausePopupCaller ProduceInGamePausePopupCaller ProduceInGamePausePopupCaller Pointer )
            value.ChallengeTourPopupCaller                  = GetObject<ChallengeTourInGamePausePopupCaller>(new IntPtr(p + 0x068), ReversePrism.DataModels.ChallengeTourInGamePausePopupCaller.FromPointer); // 0x68 ChallengeTourPopupCaller    ( ModelClassType ChallengeTourInGamePausePopupCaller ChallengeTourInGamePausePopupCaller ChallengeTourInGamePausePopupCaller Pointer )
            value.SuspendUnPauseButton                      = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 0x70 SuspendUnPauseButton        ( ModelClassType UIButton UIButton UIButton Pointer )

            return value;
        }
    }
}
