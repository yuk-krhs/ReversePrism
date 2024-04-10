using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TotalHighScoreRateView                   0001866716D0 ModelClassType MusicRateView MusicRateView MusicRateView Pointer
    // 028 TotalTechnicalRatingView                 0001866716D0 ModelClassType MusicRateView MusicRateView MusicRateView Pointer
    // 030 LiveClearCountView                       0001865B6960 ModelClassType ProfileFriendUserProfileLivePanelView ProfileFriendUserProfileLivePanelView ProfileFriendUserProfileLivePanelView Pointer
    // 038 FullComboCountView                       0001865B6960 ModelClassType ProfileFriendUserProfileLivePanelView ProfileFriendUserProfileLivePanelView ProfileFriendUserProfileLivePanelView Pointer
    // 040 AllGrateCountView                        0001865B6960 ModelClassType ProfileFriendUserProfileLivePanelView ProfileFriendUserProfileLivePanelView ProfileFriendUserProfileLivePanelView Pointer
    // 048 AllPerfectCountView                      0001865B6960 ModelClassType ProfileFriendUserProfileLivePanelView ProfileFriendUserProfileLivePanelView ProfileFriendUserProfileLivePanelView Pointer
    // 050 FesUnitRankView                          0001865B8E50 ModelClassType ProfileFriendUserProgressFesUnitRankView ProfileFriendUserProgressFesUnitRankView ProfileFriendUserProgressFesUnitRankView Pointer
    // 058 EpisordClearCountView                    0001865B8950 ModelClassType ProfileFriendUserProgressEpisordClearCountView ProfileFriendUserProgressEpisordClearCountView ProfileFriendUserProgressEpisordClearCountView Pointer
    // 060 ViewModel                                0001865B9A40 ModelClassType ProfileFriendUserViewModel ProfileFriendUserViewModel ProfileFriendUserViewModel Pointer
    // 068 onUnitRankDetail                         Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class ProfileFriendUserProgressListView : DataModel
    {
        public MusicRateView?                           TotalHighScoreRateView                  { get; set; }
        public MusicRateView?                           TotalTechnicalRatingView                { get; set; }
        public ProfileFriendUserProfileLivePanelView?   LiveClearCountView                      { get; set; }
        public ProfileFriendUserProfileLivePanelView?   FullComboCountView                      { get; set; }
        public ProfileFriendUserProfileLivePanelView?   AllGrateCountView                       { get; set; }
        public ProfileFriendUserProfileLivePanelView?   AllPerfectCountView                     { get; set; }
        public ProfileFriendUserProgressFesUnitRankView? FesUnitRankView                         { get; set; }
        public ProfileFriendUserProgressEpisordClearCountView? EpisordClearCountView                   { get; set; }
        public ProfileFriendUserViewModel?              ViewModel                               { get; set; }

        public static ProfileFriendUserProgressListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileFriendUserProgressListView() { Pointer= p0 };

            value.TotalHighScoreRateView                    = GetObject<MusicRateView>(new IntPtr(p + 0x020), ReversePrism.DataModels.MusicRateView.FromPointer); // 02466B7C3F90 0x20 TotalHighScoreRateView      ( 0001866716D0 ModelClassType MusicRateView MusicRateView MusicRateView Pointer )
            value.TotalTechnicalRatingView                  = GetObject<MusicRateView>(new IntPtr(p + 0x028), ReversePrism.DataModels.MusicRateView.FromPointer); // 02466B7C3FB0 0x28 TotalTechnicalRatingView    ( 0001866716D0 ModelClassType MusicRateView MusicRateView MusicRateView Pointer )
            value.LiveClearCountView                        = GetObject<ProfileFriendUserProfileLivePanelView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProfileFriendUserProfileLivePanelView.FromPointer); // 02466B7C3FD0 0x30 LiveClearCountView          ( 0001865B6960 ModelClassType ProfileFriendUserProfileLivePanelView ProfileFriendUserProfileLivePanelView ProfileFriendUserProfileLivePanelView Pointer )
            value.FullComboCountView                        = GetObject<ProfileFriendUserProfileLivePanelView>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProfileFriendUserProfileLivePanelView.FromPointer); // 02466B7C3FF0 0x38 FullComboCountView          ( 0001865B6960 ModelClassType ProfileFriendUserProfileLivePanelView ProfileFriendUserProfileLivePanelView ProfileFriendUserProfileLivePanelView Pointer )
            value.AllGrateCountView                         = GetObject<ProfileFriendUserProfileLivePanelView>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProfileFriendUserProfileLivePanelView.FromPointer); // 02466B7C4010 0x40 AllGrateCountView           ( 0001865B6960 ModelClassType ProfileFriendUserProfileLivePanelView ProfileFriendUserProfileLivePanelView ProfileFriendUserProfileLivePanelView Pointer )
            value.AllPerfectCountView                       = GetObject<ProfileFriendUserProfileLivePanelView>(new IntPtr(p + 0x048), ReversePrism.DataModels.ProfileFriendUserProfileLivePanelView.FromPointer); // 02466B7C4030 0x48 AllPerfectCountView         ( 0001865B6960 ModelClassType ProfileFriendUserProfileLivePanelView ProfileFriendUserProfileLivePanelView ProfileFriendUserProfileLivePanelView Pointer )
            value.FesUnitRankView                           = GetObject<ProfileFriendUserProgressFesUnitRankView>(new IntPtr(p + 0x050), ReversePrism.DataModels.ProfileFriendUserProgressFesUnitRankView.FromPointer); // 02466B7C4050 0x50 FesUnitRankView             ( 0001865B8E50 ModelClassType ProfileFriendUserProgressFesUnitRankView ProfileFriendUserProgressFesUnitRankView ProfileFriendUserProgressFesUnitRankView Pointer )
            value.EpisordClearCountView                     = GetObject<ProfileFriendUserProgressEpisordClearCountView>(new IntPtr(p + 0x058), ReversePrism.DataModels.ProfileFriendUserProgressEpisordClearCountView.FromPointer); // 02466B7C4070 0x58 EpisordClearCountView       ( 0001865B8950 ModelClassType ProfileFriendUserProgressEpisordClearCountView ProfileFriendUserProgressEpisordClearCountView ProfileFriendUserProgressEpisordClearCountView Pointer )
            value.ViewModel                                 = GetObject<ProfileFriendUserViewModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.ProfileFriendUserViewModel.FromPointer); // 02466B7C4090 0x60 ViewModel                   ( 0001865B9A40 ModelClassType ProfileFriendUserViewModel ProfileFriendUserViewModel ProfileFriendUserViewModel Pointer )

            return value;
        }
    }
}
