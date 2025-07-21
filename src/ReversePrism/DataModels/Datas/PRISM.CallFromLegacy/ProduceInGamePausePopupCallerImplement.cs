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
    // 040 ViewModel                                ModelClassType ProduceInGamePausePopupViewModel ProduceInGamePausePopupViewModel ProduceInGamePausePopupViewModel Pointer
    // 048 IsShowPopup                              ModelPrimitiveType bool bool bool Bool
    // 049 IsClosingPopup                           ModelPrimitiveType bool bool bool Bool
    public partial class ProduceInGamePausePopupCallerImplement : DataModel
    {
        public ProduceInGamePausePopupViewModel?        ViewModel                               { get; set; }
        public bool                                     IsShowPopup                             { get; set; }
        public bool                                     IsClosingPopup                          { get; set; }

        public static ProduceInGamePausePopupCallerImplement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceInGamePausePopupCallerImplement() { Pointer= p0 };

            value.ViewModel                                 = GetObject<ProduceInGamePausePopupViewModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProduceInGamePausePopupViewModel.FromPointer); // 0x40 ViewModel                   ( ModelClassType ProduceInGamePausePopupViewModel ProduceInGamePausePopupViewModel ProduceInGamePausePopupViewModel Pointer )
            value.IsShowPopup                               = GetBool(new IntPtr(p + 0x048)); // 0x48 IsShowPopup                 ( ModelPrimitiveType bool bool bool Bool )
            value.IsClosingPopup                            = GetBool(new IntPtr(p + 0x049)); // 0x49 IsClosingPopup              ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
