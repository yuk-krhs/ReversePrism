using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 factory                                  IPopupViewFactory`1<IProfileSupportCharaSelectPopupView> IL2CPP_TYPE_GENERICINST
    // 018 sortFilterSaveData                       SavableJsonObject`1<IdolListSCSortFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 020 UserSelfViewModel                        0001865C6380 ModelClassType ProfileUserSalfViewModel ProfileUserSalfViewModel ProfileUserSalfViewModel Pointer
    // 028 Canceller                                000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    // 030 SCharaDetailDisposable                   0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class ProfileSupportCharaSelectPopupSequencer
    {
        public ProfileUserSalfViewModel?                UserSelfViewModel                       { get; set; }
        public AutoCancellationTokenSource              Canceller                               { get; set; }
        public IDisposable?                             SCharaDetailDisposable                  { get; set; }

        public static ProfileSupportCharaSelectPopupSequencer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileSupportCharaSelectPopupSequencer();

            value.UserSelfViewModel                         = GetObject<ProfileUserSalfViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProfileUserSalfViewModel.FromPointer); // 0270D668DEE8 0x20 UserSelfViewModel           ( 0001865C6380 ModelClassType ProfileUserSalfViewModel ProfileUserSalfViewModel ProfileUserSalfViewModel Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x028)); // 0270D668DF08 0x28 Canceller                   ( 000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )
            value.SCharaDetailDisposable                    = GetObject<IDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.IDisposable.FromPointer); // 0270D668DF28 0x30 SCharaDetailDisposable      ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
