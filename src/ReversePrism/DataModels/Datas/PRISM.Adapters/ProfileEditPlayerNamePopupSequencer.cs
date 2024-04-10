using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 editPlayerNameFactory                    IPopupViewFactory`1<IProfileEditPlayerNamePopupView> IL2CPP_TYPE_GENERICINST
    // 018 editPlayerNameConfirmFactory             IPopupViewFactory`1<IProfileEditPlayerNameConfirmPopupView> IL2CPP_TYPE_GENERICINST
    // 020 ViewModel                                0001865C6380 ModelClassType ProfileUserSalfViewModel ProfileUserSalfViewModel ProfileUserSalfViewModel Pointer
    // 028 Canceller                                000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    public partial class ProfileEditPlayerNamePopupSequencer : DataModel
    {
        public ProfileUserSalfViewModel?                ViewModel                               { get; set; }
        public AutoCancellationTokenSource              Canceller                               { get; set; }

        public static ProfileEditPlayerNamePopupSequencer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileEditPlayerNamePopupSequencer() { Pointer= p0 };

            value.ViewModel                                 = GetObject<ProfileUserSalfViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProfileUserSalfViewModel.FromPointer); // 0246666FB608 0x20 ViewModel                   ( 0001865C6380 ModelClassType ProfileUserSalfViewModel ProfileUserSalfViewModel ProfileUserSalfViewModel Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x028)); // 0246666FB628 0x28 Canceller                   ( 000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )

            return value;
        }
    }
}
