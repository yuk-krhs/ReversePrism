using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 sortFilterSaveData                       SavableJsonObject`1<IdolListSCSortFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 018 UserSelfViewModel                        ModelClassType ProfileUserSalfViewModel ProfileUserSalfViewModel ProfileUserSalfViewModel Pointer
    // 020 Canceller                                ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    // 028 SCharaDetailDisposable                   ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class ProfileSupportCharaSelectPopupSequencer : DataModel
    {
        public ProfileUserSalfViewModel?                UserSelfViewModel                       { get; set; }
        public AutoCancellationTokenSource              Canceller                               { get; set; }
        public IDisposable?                             SCharaDetailDisposable                  { get; set; }

        public static ProfileSupportCharaSelectPopupSequencer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileSupportCharaSelectPopupSequencer() { Pointer= p0 };

            value.UserSelfViewModel                         = GetObject<ProfileUserSalfViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProfileUserSalfViewModel.FromPointer); // 0x18 UserSelfViewModel           ( ModelClassType ProfileUserSalfViewModel ProfileUserSalfViewModel ProfileUserSalfViewModel Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x020)); // 0x20 Canceller                   ( ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )
            value.SCharaDetailDisposable                    = GetObject<IDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.IDisposable.FromPointer); // 0x28 SCharaDetailDisposable      ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
