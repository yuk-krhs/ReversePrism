using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 onPause                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 028 onUnPause                                Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 030 PauseButton                              0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 038 BlackBG                                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 PopupCaller                              000186558D00 ModelClassType ProduceInGamePausePopupCaller ProduceInGamePausePopupCaller ProduceInGamePausePopupCaller Pointer
    // 048 SuspendUnPauseButton                     0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    public partial class ProduceInGamePauseContent : DataModel
    {
        public UIButton?                                PauseButton                             { get; set; }
        public GameObject?                              BlackBG                                 { get; set; }
        public ProduceInGamePausePopupCaller?           PopupCaller                             { get; set; }
        public UIButton?                                SuspendUnPauseButton                    { get; set; }

        public static ProduceInGamePauseContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceInGamePauseContent() { Pointer= p0 };

            value.PauseButton                               = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 024665C308F8 0x30 PauseButton                 ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BlackBG                                   = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 024665C30918 0x38 BlackBG                     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.PopupCaller                               = GetObject<ProduceInGamePausePopupCaller>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProduceInGamePausePopupCaller.FromPointer); // 024665C30938 0x40 PopupCaller                 ( 000186558D00 ModelClassType ProduceInGamePausePopupCaller ProduceInGamePausePopupCaller ProduceInGamePausePopupCaller Pointer )
            value.SuspendUnPauseButton                      = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 024665C30958 0x48 SuspendUnPauseButton        ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )

            return value;
        }
    }
}
