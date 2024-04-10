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
    // 030 factory                                  IOverlayViewFactory`1<IProfileUserSelfOverlayView> IL2CPP_TYPE_GENERICINST
    // 038 ViewModel                                0001865C5E90 ModelClassType ProfileUserSalfViewModel ProfileUserSalfViewModel ProfileUserSalfViewModel Pointer
    // 040 CatetoryTabSelectIndex                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 044 HistoryTabSelectIndex                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 048 View                                     0001865FFA30 ModelClassType IProfileUserSelfOverlayView IProfileUserSelfOverlayView IProfileUserSelfOverlayView Pointer
    // 050 Canceller                                000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
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

            value.ViewModel                                 = GetObject<ProfileUserSalfViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProfileUserSalfViewModel.FromPointer); // 0246666E0D78 0x38 ViewModel                   ( 0001865C5E90 ModelClassType ProfileUserSalfViewModel ProfileUserSalfViewModel ProfileUserSalfViewModel Pointer )
            value.CatetoryTabSelectIndex                    = GetInt32(new IntPtr(p + 0x040)); // 0246666E0D98 0x40 CatetoryTabSelectIndex      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.HistoryTabSelectIndex                     = GetInt32(new IntPtr(p + 0x044)); // 0246666E0DB8 0x44 HistoryTabSelectIndex       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.View                                      = GetObject<IProfileUserSelfOverlayView>(new IntPtr(p + 0x048), ReversePrism.DataModels.IProfileUserSelfOverlayView.FromPointer); // 0246666E0DD8 0x48 View                        ( 0001865FFA30 ModelClassType IProfileUserSelfOverlayView IProfileUserSelfOverlayView IProfileUserSelfOverlayView Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x050)); // 0246666E0DF8 0x50 Canceller                   ( 000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )

            return value;
        }
    }
}
