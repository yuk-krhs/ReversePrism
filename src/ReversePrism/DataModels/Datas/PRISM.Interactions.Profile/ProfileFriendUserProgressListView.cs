using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TotalHighScoreRateView                   ModelClassType MusicRateView MusicRateView MusicRateView Pointer
    // 028 TotalTechnicalRatingView                 ModelClassType MusicRateView MusicRateView MusicRateView Pointer
    // 030 LiveClearCountView                       ModelClassType ProfileLiveCountView ProfileLiveCountView ProfileLiveCountView Pointer
    // 038 FullComboCountView                       ModelClassType ProfileLiveCountView ProfileLiveCountView ProfileLiveCountView Pointer
    // 040 AllGrateCountView                        ModelClassType ProfileLiveCountView ProfileLiveCountView ProfileLiveCountView Pointer
    // 048 AllPerfectCountView                      ModelClassType ProfileLiveCountView ProfileLiveCountView ProfileLiveCountView Pointer
    // 050 AllShinyCountView                        ModelClassType ProfileLiveCountView ProfileLiveCountView ProfileLiveCountView Pointer
    // 058 FesUnitRankView                          ModelClassType ProfileFriendUserProgressFesUnitRankView ProfileFriendUserProgressFesUnitRankView ProfileFriendUserProgressFesUnitRankView Pointer
    // 060 EpisordClearCountView                    ModelClassType ProfileFriendUserProgressEpisordClearCountView ProfileFriendUserProgressEpisordClearCountView ProfileFriendUserProgressEpisordClearCountView Pointer
    // 068 onUnitRankDetail                         Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class ProfileFriendUserProgressListView : DataModel
    {
        public MusicRateView?                           TotalHighScoreRateView                  { get; set; }
        public MusicRateView?                           TotalTechnicalRatingView                { get; set; }
        public ProfileLiveCountView?                    LiveClearCountView                      { get; set; }
        public ProfileLiveCountView?                    FullComboCountView                      { get; set; }
        public ProfileLiveCountView?                    AllGrateCountView                       { get; set; }
        public ProfileLiveCountView?                    AllPerfectCountView                     { get; set; }
        public ProfileLiveCountView?                    AllShinyCountView                       { get; set; }
        public ProfileFriendUserProgressFesUnitRankView? FesUnitRankView                         { get; set; }
        public ProfileFriendUserProgressEpisordClearCountView? EpisordClearCountView                   { get; set; }

        public static ProfileFriendUserProgressListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileFriendUserProgressListView() { Pointer= p0 };

            value.TotalHighScoreRateView                    = GetObject<MusicRateView>(new IntPtr(p + 0x020), ReversePrism.DataModels.MusicRateView.FromPointer); // 0x20 TotalHighScoreRateView      ( ModelClassType MusicRateView MusicRateView MusicRateView Pointer )
            value.TotalTechnicalRatingView                  = GetObject<MusicRateView>(new IntPtr(p + 0x028), ReversePrism.DataModels.MusicRateView.FromPointer); // 0x28 TotalTechnicalRatingView    ( ModelClassType MusicRateView MusicRateView MusicRateView Pointer )
            value.LiveClearCountView                        = GetObject<ProfileLiveCountView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProfileLiveCountView.FromPointer); // 0x30 LiveClearCountView          ( ModelClassType ProfileLiveCountView ProfileLiveCountView ProfileLiveCountView Pointer )
            value.FullComboCountView                        = GetObject<ProfileLiveCountView>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProfileLiveCountView.FromPointer); // 0x38 FullComboCountView          ( ModelClassType ProfileLiveCountView ProfileLiveCountView ProfileLiveCountView Pointer )
            value.AllGrateCountView                         = GetObject<ProfileLiveCountView>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProfileLiveCountView.FromPointer); // 0x40 AllGrateCountView           ( ModelClassType ProfileLiveCountView ProfileLiveCountView ProfileLiveCountView Pointer )
            value.AllPerfectCountView                       = GetObject<ProfileLiveCountView>(new IntPtr(p + 0x048), ReversePrism.DataModels.ProfileLiveCountView.FromPointer); // 0x48 AllPerfectCountView         ( ModelClassType ProfileLiveCountView ProfileLiveCountView ProfileLiveCountView Pointer )
            value.AllShinyCountView                         = GetObject<ProfileLiveCountView>(new IntPtr(p + 0x050), ReversePrism.DataModels.ProfileLiveCountView.FromPointer); // 0x50 AllShinyCountView           ( ModelClassType ProfileLiveCountView ProfileLiveCountView ProfileLiveCountView Pointer )
            value.FesUnitRankView                           = GetObject<ProfileFriendUserProgressFesUnitRankView>(new IntPtr(p + 0x058), ReversePrism.DataModels.ProfileFriendUserProgressFesUnitRankView.FromPointer); // 0x58 FesUnitRankView             ( ModelClassType ProfileFriendUserProgressFesUnitRankView ProfileFriendUserProgressFesUnitRankView ProfileFriendUserProgressFesUnitRankView Pointer )
            value.EpisordClearCountView                     = GetObject<ProfileFriendUserProgressEpisordClearCountView>(new IntPtr(p + 0x060), ReversePrism.DataModels.ProfileFriendUserProgressEpisordClearCountView.FromPointer); // 0x60 EpisordClearCountView       ( ModelClassType ProfileFriendUserProgressEpisordClearCountView ProfileFriendUserProgressEpisordClearCountView ProfileFriendUserProgressEpisordClearCountView Pointer )

            return value;
        }
    }
}
