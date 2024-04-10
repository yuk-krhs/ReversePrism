using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 HasReplyData                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 TotalHighScoreRateViewModel              000186671BD0 ModelClassType MusicRateViewModel MusicRateViewModel MusicRateViewModel Pointer
    // 020 TotalTechnicalRateViewModel              000186671BD0 ModelClassType MusicRateViewModel MusicRateViewModel MusicRateViewModel Pointer
    // 028 LiveClearCountViewModels                 000185B9EBA0 ModelClassListType ProfileProgressCountViewModel[] ProfileProgressCountViewModel[] List<ProfileProgressCountViewModel> Pointer
    // 030 FullComboCountViewModels                 000185B9EBA0 ModelClassListType ProfileProgressCountViewModel[] ProfileProgressCountViewModel[] List<ProfileProgressCountViewModel> Pointer
    // 038 AllGrateCountViewModels                  000185B9EBA0 ModelClassListType ProfileProgressCountViewModel[] ProfileProgressCountViewModel[] List<ProfileProgressCountViewModel> Pointer
    // 040 AllPerfectCountViewModels                000185B9EBA0 ModelClassListType ProfileProgressCountViewModel[] ProfileProgressCountViewModel[] List<ProfileProgressCountViewModel> Pointer
    // 048 Rank                                     00018660D900 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32
    // 04C RankScore                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 050 EpisordClearCount                        000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 058 FesUnitDetailViewModels                  000185B9ED80 ModelClassListType ProfileProgressFesUnitRankDetailViewModel[] ProfileProgressFesUnitRankDetailViewModel[] List<ProfileProgressFesUnitRankDetailViewModel> Pointer
    public partial class ProfileProgressPanelViewModel : DataModel
    {
        public bool                                     HasReplyData                            { get; set; }
        public MusicRateViewModel?                      TotalHighScoreRateViewModel             { get; set; }
        public MusicRateViewModel?                      TotalTechnicalRateViewModel             { get; set; }
        public List<ProfileProgressCountViewModel>?     LiveClearCountViewModels                { get; set; }
        public List<ProfileProgressCountViewModel>?     FullComboCountViewModels                { get; set; }
        public List<ProfileProgressCountViewModel>?     AllGrateCountViewModels                 { get; set; }
        public List<ProfileProgressCountViewModel>?     AllPerfectCountViewModels               { get; set; }
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

            value.HasReplyData                              = GetBool(new IntPtr(p + 0x010)); // 0246666F88E0 0x10 HasReplyData                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.TotalHighScoreRateViewModel               = GetObject<MusicRateViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.MusicRateViewModel.FromPointer); // 0246666F8900 0x18 TotalHighScoreRateViewModel ( 000186671BD0 ModelClassType MusicRateViewModel MusicRateViewModel MusicRateViewModel Pointer )
            value.TotalTechnicalRateViewModel               = GetObject<MusicRateViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.MusicRateViewModel.FromPointer); // 0246666F8920 0x20 TotalTechnicalRateViewModel ( 000186671BD0 ModelClassType MusicRateViewModel MusicRateViewModel MusicRateViewModel Pointer )
            value.LiveClearCountViewModels                  = GetObjectList<ProfileProgressCountViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProfileProgressCountViewModel.FromPointer); // 0246666F8940 0x28 LiveClearCountViewModels    ( 000185B9EBA0 ModelClassListType ProfileProgressCountViewModel[] ProfileProgressCountViewModel[] List<ProfileProgressCountViewModel> Pointer )
            value.FullComboCountViewModels                  = GetObjectList<ProfileProgressCountViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProfileProgressCountViewModel.FromPointer); // 0246666F8960 0x30 FullComboCountViewModels    ( 000185B9EBA0 ModelClassListType ProfileProgressCountViewModel[] ProfileProgressCountViewModel[] List<ProfileProgressCountViewModel> Pointer )
            value.AllGrateCountViewModels                   = GetObjectList<ProfileProgressCountViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProfileProgressCountViewModel.FromPointer); // 0246666F8980 0x38 AllGrateCountViewModels     ( 000185B9EBA0 ModelClassListType ProfileProgressCountViewModel[] ProfileProgressCountViewModel[] List<ProfileProgressCountViewModel> Pointer )
            value.AllPerfectCountViewModels                 = GetObjectList<ProfileProgressCountViewModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProfileProgressCountViewModel.FromPointer); // 0246666F89A0 0x40 AllPerfectCountViewModels   ( 000185B9EBA0 ModelClassListType ProfileProgressCountViewModel[] ProfileProgressCountViewModel[] List<ProfileProgressCountViewModel> Pointer )
            value.Rank                                      = (ProduceParameterRank)GetInt32(new IntPtr(p + 0x048)); // 0246666F89C0 0x48 Rank                        ( 00018660D900 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32 )
            value.RankScore                                 = GetInt32(new IntPtr(p + 0x04C)); // 0246666F89E0 0x4C RankScore                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.EpisordClearCount                         = GetInt32List(new IntPtr(p + 0x050)); // 0246666F8A00 0x50 EpisordClearCount           ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.FesUnitDetailViewModels                   = GetObjectList<ProfileProgressFesUnitRankDetailViewModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.ProfileProgressFesUnitRankDetailViewModel.FromPointer); // 0246666F8A20 0x58 FesUnitDetailViewModels     ( 000185B9ED80 ModelClassListType ProfileProgressFesUnitRankDetailViewModel[] ProfileProgressFesUnitRankDetailViewModel[] List<ProfileProgressFesUnitRankDetailViewModel> Pointer )

            return value;
        }
    }
}
