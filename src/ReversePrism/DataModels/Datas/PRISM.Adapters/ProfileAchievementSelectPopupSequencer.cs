using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 factory                                  IPopupViewFactory`1<IProfileAchievementSelectPopupView> IL2CPP_TYPE_GENERICINST
    // 018 sortFilterSaveData                       SavableJsonObject`1<ProfileAchievementSortFilterSaveData> IL2CPP_TYPE_GENERICINST
    // 020 isNewSaveData                            SavableJsonObject`1<ProfileAchievementIsNewSaveData> IL2CPP_TYPE_GENERICINST
    // 028 UserSelfViewModel                        0001865C6380 ModelClassType ProfileUserSalfViewModel ProfileUserSalfViewModel ProfileUserSalfViewModel Pointer
    // 030 Canceller                                000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    public partial class ProfileAchievementSelectPopupSequencer
    {
        public ProfileUserSalfViewModel?                UserSelfViewModel                       { get; set; }
        public AutoCancellationTokenSource              Canceller                               { get; set; }

        public static ProfileAchievementSelectPopupSequencer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileAchievementSelectPopupSequencer();

            value.UserSelfViewModel                         = GetObject<ProfileUserSalfViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProfileUserSalfViewModel.FromPointer); // 0270D66898F0 0x28 UserSelfViewModel           ( 0001865C6380 ModelClassType ProfileUserSalfViewModel ProfileUserSalfViewModel ProfileUserSalfViewModel Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x030)); // 0270D6689910 0x30 Canceller                   ( 000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )

            return value;
        }
    }
}
