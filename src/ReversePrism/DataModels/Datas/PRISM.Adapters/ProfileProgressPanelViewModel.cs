using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 HasReplyData                             ModelPrimitiveType bool bool bool Bool
    // 018 TotalHighScoreRateViewModel              ModelClassType MusicRateViewModel MusicRateViewModel MusicRateViewModel Pointer
    // 020 TotalTechnicalRateViewModel              ModelClassType MusicRateViewModel MusicRateViewModel MusicRateViewModel Pointer
    // 028 LiveClearCountViewModels                 ModelClassListType IReadOnlyList`1<IUserProfileLiveStatus> IReadOnlyList`1<IUserProfileLiveStatus> List<IUserProfileLiveStatus> Pointer
    // 030 FullComboCountViewModels                 ModelClassListType IReadOnlyList`1<IUserProfileLiveStatus> IReadOnlyList`1<IUserProfileLiveStatus> List<IUserProfileLiveStatus> Pointer
    // 038 AllGrateCountViewModels                  ModelClassListType IReadOnlyList`1<IUserProfileLiveStatus> IReadOnlyList`1<IUserProfileLiveStatus> List<IUserProfileLiveStatus> Pointer
    // 040 AllPerfectCountViewModels                ModelClassListType IReadOnlyList`1<IUserProfileLiveStatus> IReadOnlyList`1<IUserProfileLiveStatus> List<IUserProfileLiveStatus> Pointer
    // 048 AllShinyCountViewModels                  ModelClassListType IReadOnlyList`1<IUserProfileLiveStatus> IReadOnlyList`1<IUserProfileLiveStatus> List<IUserProfileLiveStatus> Pointer
    // 050 Rank                                     ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32
    // 054 RankScore                                ModelPrimitiveType int int int Int32
    // 058 EpisordClearCount                        ModelPrimitiveListType int[] int[] List<int> Pointer
    // 060 FesUnitDetailViewModels                  ModelClassListType ProfileProgressFesUnitRankDetailViewModel[] ProfileProgressFesUnitRankDetailViewModel[] List<ProfileProgressFesUnitRankDetailViewModel> Pointer
    public partial class ProfileProgressPanelViewModel : DataModel
    {
        public bool                                     HasReplyData                            { get; set; }
        public MusicRateViewModel?                      TotalHighScoreRateViewModel             { get; set; }
        public MusicRateViewModel?                      TotalTechnicalRateViewModel             { get; set; }
        public List<IUserProfileLiveStatus>?            LiveClearCountViewModels                { get; set; }
        public List<IUserProfileLiveStatus>?            FullComboCountViewModels                { get; set; }
        public List<IUserProfileLiveStatus>?            AllGrateCountViewModels                 { get; set; }
        public List<IUserProfileLiveStatus>?            AllPerfectCountViewModels               { get; set; }
        public List<IUserProfileLiveStatus>?            AllShinyCountViewModels                 { get; set; }
        public ProduceParameterRank                     Rank                                    { get; set; }
        public int                                      RankScore                               { get; set; }
        public List<int>?                               EpisordClearCount                       { get; set; }
        public List<ProfileProgressFesUnitRankDetailViewModel>? FesUnitDetailViewModels                 { get; set; }

        public static ProfileProgressPanelViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileProgressPanelViewModel() { Pointer= p0 };

            value.HasReplyData                              = GetBool(new IntPtr(p + 0x010)); // 0x10 HasReplyData                ( ModelPrimitiveType bool bool bool Bool )
            value.TotalHighScoreRateViewModel               = GetObject<MusicRateViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.MusicRateViewModel.FromPointer); // 0x18 TotalHighScoreRateViewModel ( ModelClassType MusicRateViewModel MusicRateViewModel MusicRateViewModel Pointer )
            value.TotalTechnicalRateViewModel               = GetObject<MusicRateViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.MusicRateViewModel.FromPointer); // 0x20 TotalTechnicalRateViewModel ( ModelClassType MusicRateViewModel MusicRateViewModel MusicRateViewModel Pointer )
            value.LiveClearCountViewModels                  = GetObjectList<IUserProfileLiveStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IUserProfileLiveStatus.FromPointer); // 0x28 LiveClearCountViewModels    ( ModelClassListType IReadOnlyList`1<IUserProfileLiveStatus> IReadOnlyList`1<IUserProfileLiveStatus> List<IUserProfileLiveStatus> Pointer )
            value.FullComboCountViewModels                  = GetObjectList<IUserProfileLiveStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IUserProfileLiveStatus.FromPointer); // 0x30 FullComboCountViewModels    ( ModelClassListType IReadOnlyList`1<IUserProfileLiveStatus> IReadOnlyList`1<IUserProfileLiveStatus> List<IUserProfileLiveStatus> Pointer )
            value.AllGrateCountViewModels                   = GetObjectList<IUserProfileLiveStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IUserProfileLiveStatus.FromPointer); // 0x38 AllGrateCountViewModels     ( ModelClassListType IReadOnlyList`1<IUserProfileLiveStatus> IReadOnlyList`1<IUserProfileLiveStatus> List<IUserProfileLiveStatus> Pointer )
            value.AllPerfectCountViewModels                 = GetObjectList<IUserProfileLiveStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IUserProfileLiveStatus.FromPointer); // 0x40 AllPerfectCountViewModels   ( ModelClassListType IReadOnlyList`1<IUserProfileLiveStatus> IReadOnlyList`1<IUserProfileLiveStatus> List<IUserProfileLiveStatus> Pointer )
            value.AllShinyCountViewModels                   = GetObjectList<IUserProfileLiveStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.IUserProfileLiveStatus.FromPointer); // 0x48 AllShinyCountViewModels     ( ModelClassListType IReadOnlyList`1<IUserProfileLiveStatus> IReadOnlyList`1<IUserProfileLiveStatus> List<IUserProfileLiveStatus> Pointer )
            value.Rank                                      = (ProduceParameterRank)GetInt32(new IntPtr(p + 0x050)); // 0x50 Rank                        ( ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32 )
            value.RankScore                                 = GetInt32(new IntPtr(p + 0x054)); // 0x54 RankScore                   ( ModelPrimitiveType int int int Int32 )
            value.EpisordClearCount                         = GetInt32List(new IntPtr(p + 0x058)); // 0x58 EpisordClearCount           ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.FesUnitDetailViewModels                   = GetObjectList<ProfileProgressFesUnitRankDetailViewModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.ProfileProgressFesUnitRankDetailViewModel.FromPointer); // 0x60 FesUnitDetailViewModels     ( ModelClassListType ProfileProgressFesUnitRankDetailViewModel[] ProfileProgressFesUnitRankDetailViewModel[] List<ProfileProgressFesUnitRankDetailViewModel> Pointer )

            return value;
        }
    }
}
