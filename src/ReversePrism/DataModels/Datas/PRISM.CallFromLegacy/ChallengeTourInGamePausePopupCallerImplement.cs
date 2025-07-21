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
    // 040 ViewModel                                ModelClassType ChallengeTourInGamePausePopupViewModel ChallengeTourInGamePausePopupViewModel ChallengeTourInGamePausePopupViewModel Pointer
    public partial class ChallengeTourInGamePausePopupCallerImplement : DataModel
    {
        public ChallengeTourInGamePausePopupViewModel?  ViewModel                               { get; set; }

        public static ChallengeTourInGamePausePopupCallerImplement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourInGamePausePopupCallerImplement() { Pointer= p0 };

            value.ViewModel                                 = GetObject<ChallengeTourInGamePausePopupViewModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.ChallengeTourInGamePausePopupViewModel.FromPointer); // 0x40 ViewModel                   ( ModelClassType ChallengeTourInGamePausePopupViewModel ChallengeTourInGamePausePopupViewModel ChallengeTourInGamePausePopupViewModel Pointer )

            return value;
        }
    }
}
