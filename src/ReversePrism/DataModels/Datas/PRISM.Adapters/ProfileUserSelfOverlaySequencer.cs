using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 pIdolSortFilterSaveData                  SavableJsonObject`1<IdolListPISortFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 018 achievementSortFilterSaveData            SavableJsonObject`1<ProfileAchievementSortFilterSaveData> IL2CPP_TYPE_GENERICINST
    // 020 achievementIsNewSaveData                 SavableJsonObject`1<ProfileAchievementIsNewSaveData> IL2CPP_TYPE_GENERICINST
    // 028 supportCharaSourtFilterSaveData          SavableJsonObject`1<IdolListSCSortFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 030 ViewModel                                ModelClassType ProfileUserSalfViewModel ProfileUserSalfViewModel ProfileUserSalfViewModel Pointer
    // 038 CatetoryTabSelectIndex                   ModelPrimitiveType int int int Int32
    // 03C HistoryTabSelectIndex                    ModelPrimitiveType int int int Int32
    // 040 View                                     ModelClassType IProfileUserSelfOverlayView IProfileUserSelfOverlayView IProfileUserSelfOverlayView Pointer
    // 048 Canceller                                ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    public partial class ProfileUserSelfOverlaySequencer : DataModel
    {
        public ProfileUserSalfViewModel?                ViewModel                               { get; set; }
        public int                                      CatetoryTabSelectIndex                  { get; set; }
        public int                                      HistoryTabSelectIndex                   { get; set; }
        public IProfileUserSelfOverlayView?             View                                    { get; set; }
        public AutoCancellationTokenSource              Canceller                               { get; set; }

        public static ProfileUserSelfOverlaySequencer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileUserSelfOverlaySequencer() { Pointer= p0 };

            value.ViewModel                                 = GetObject<ProfileUserSalfViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProfileUserSalfViewModel.FromPointer); // 0x30 ViewModel                   ( ModelClassType ProfileUserSalfViewModel ProfileUserSalfViewModel ProfileUserSalfViewModel Pointer )
            value.CatetoryTabSelectIndex                    = GetInt32(new IntPtr(p + 0x038)); // 0x38 CatetoryTabSelectIndex      ( ModelPrimitiveType int int int Int32 )
            value.HistoryTabSelectIndex                     = GetInt32(new IntPtr(p + 0x03C)); // 0x3C HistoryTabSelectIndex       ( ModelPrimitiveType int int int Int32 )
            value.View                                      = GetObject<IProfileUserSelfOverlayView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IProfileUserSelfOverlayView.FromPointer); // 0x40 View                        ( ModelClassType IProfileUserSelfOverlayView IProfileUserSelfOverlayView IProfileUserSelfOverlayView Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x048)); // 0x48 Canceller                   ( ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )

            return value;
        }
    }
}
