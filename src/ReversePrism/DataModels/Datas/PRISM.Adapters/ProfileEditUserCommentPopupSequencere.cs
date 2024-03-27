using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 editCommentFactory                       IPopupViewFactory`1<IProfileEditUserCommentPopupView> IL2CPP_TYPE_GENERICINST
    // 018 ViewModel                                0001865C6380 ModelClassType ProfileUserSalfViewModel ProfileUserSalfViewModel ProfileUserSalfViewModel Pointer
    // 020 Canceller                                000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    public partial class ProfileEditUserCommentPopupSequencere
    {
        public ProfileUserSalfViewModel?                ViewModel                               { get; set; }
        public AutoCancellationTokenSource              Canceller                               { get; set; }

        public static ProfileEditUserCommentPopupSequencere? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileEditUserCommentPopupSequencere();

            value.ViewModel                                 = GetObject<ProfileUserSalfViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProfileUserSalfViewModel.FromPointer); // 0270D668C498 0x18 ViewModel                   ( 0001865C6380 ModelClassType ProfileUserSalfViewModel ProfileUserSalfViewModel ProfileUserSalfViewModel Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x020)); // 0270D668C4B8 0x20 Canceller                   ( 000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )

            return value;
        }
    }
}
