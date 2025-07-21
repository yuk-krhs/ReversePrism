using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 sortFilterSaveData                       SavableJsonObject`1<ProfileAchievementSortFilterSaveData> IL2CPP_TYPE_GENERICINST
    // 018 isNewSaveData                            SavableJsonObject`1<ProfileAchievementIsNewSaveData> IL2CPP_TYPE_GENERICINST
    // 020 UserSelfViewModel                        ModelClassType ProfileUserSalfViewModel ProfileUserSalfViewModel ProfileUserSalfViewModel Pointer
    // 028 Canceller                                ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    public partial class ProfileAchievementSelectPopupSequencer : DataModel
    {
        public ProfileUserSalfViewModel?                UserSelfViewModel                       { get; set; }
        public AutoCancellationTokenSource              Canceller                               { get; set; }

        public static ProfileAchievementSelectPopupSequencer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileAchievementSelectPopupSequencer() { Pointer= p0 };

            value.UserSelfViewModel                         = GetObject<ProfileUserSalfViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProfileUserSalfViewModel.FromPointer); // 0x20 UserSelfViewModel           ( ModelClassType ProfileUserSalfViewModel ProfileUserSalfViewModel ProfileUserSalfViewModel Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x028)); // 0x28 Canceller                   ( ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )

            return value;
        }
    }
}
