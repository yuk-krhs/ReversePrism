using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 onApplyProduceOptionSubject              Subject`1<ProduceOptionSaveData> IL2CPP_TYPE_GENERICINST
    // 028 onClickRetryButtonSubject                Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 030 onClickGiveUpButtonSubject               Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 038 onHidePopupSubject                       Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 040 factory                                  PopupViewFactory`1<IProduceInGamePausePopupView> IL2CPP_TYPE_GENERICINST
    // 048 ViewModel                                00018655A5A0 ModelClassType ProduceInGamePausePopupViewModel ProduceInGamePausePopupViewModel ProduceInGamePausePopupViewModel Pointer
    // 050 IsShowPopup                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 051 IsClosingPopup                           000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ProduceInGamePausePopupCallerImplement
    {
        public ProduceInGamePausePopupViewModel?        ViewModel                               { get; set; }
        public bool                                     IsShowPopup                             { get; set; }
        public bool                                     IsClosingPopup                          { get; set; }

        public static ProduceInGamePausePopupCallerImplement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceInGamePausePopupCallerImplement();

            value.ViewModel                                 = GetObject<ProduceInGamePausePopupViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.ProduceInGamePausePopupViewModel.FromPointer); // 0270DB9D8AE0 0x48 ViewModel                   ( 00018655A5A0 ModelClassType ProduceInGamePausePopupViewModel ProduceInGamePausePopupViewModel ProduceInGamePausePopupViewModel Pointer )
            value.IsShowPopup                               = GetBool(new IntPtr(p + 0x050)); // 0270DB9D8B00 0x50 IsShowPopup                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsClosingPopup                            = GetBool(new IntPtr(p + 0x051)); // 0270DB9D8B20 0x51 IsClosingPopup              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
