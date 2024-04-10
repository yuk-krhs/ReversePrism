using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SeasonNumberText                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 PeriodText                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 TargetSongButton                         0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 038 RewardDetailButton                       0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 HelpButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 048 TabGroup                                 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 050 MyselfRankingCell                        000186673AB0 ModelClassType MusicScoreRankingCell MusicScoreRankingCell MusicScoreRankingCell Pointer
    // 058 MusicScoreRankingView                    000186674BB0 ModelClassType MusicScoreRankingView MusicScoreRankingView MusicScoreRankingView Pointer
    // 060 TargetSongPopupCaller                    00018660FEA0 ModelClassType RankingTargetSongPopupCaller RankingTargetSongPopupCaller RankingTargetSongPopupCaller Pointer
    // 068 RankingRewardPopupCaller                 00018660F090 ModelClassType RankingRewardPopupCaller RankingRewardPopupCaller RankingRewardPopupCaller Pointer
    // 070 AchievementDetailCaller                  000186674050 ModelClassType AchievementDetailPopupCaller AchievementDetailPopupCaller AchievementDetailPopupCaller Pointer
    // 078 onSelectMusic                            Subject`1<ValueTuple`2<int, SongDifficultyLevel>> IL2CPP_TYPE_GENERICINST
    // 080 Canceller                                000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    // 088 ViewModel                                00018666BB50 ModelClassType MusicRankingOverlayViewModel MusicRankingOverlayViewModel MusicRankingOverlayViewModel Pointer
    // 000 Path                                     string IL2CPP_TYPE_STRING
    // 090 IsInitialized                            000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class SeasonRankingTabView : DataModel
    {
        public UITextMeshProUGUI?                       SeasonNumberText                        { get; set; }
        public UITextMeshProUGUI?                       PeriodText                              { get; set; }
        public UIButton?                                TargetSongButton                        { get; set; }
        public UIButton?                                RewardDetailButton                      { get; set; }
        public UIButton?                                HelpButton                              { get; set; }
        public UITabGroup?                              TabGroup                                { get; set; }
        public MusicScoreRankingCell?                   MyselfRankingCell                       { get; set; }
        public MusicScoreRankingView?                   MusicScoreRankingView                   { get; set; }
        public RankingTargetSongPopupCaller?            TargetSongPopupCaller                   { get; set; }
        public RankingRewardPopupCaller?                RankingRewardPopupCaller                { get; set; }
        public AchievementDetailPopupCaller?            AchievementDetailCaller                 { get; set; }
        public AutoCancellationTokenSource              Canceller                               { get; set; }
        public MusicRankingOverlayViewModel?            ViewModel                               { get; set; }
        public bool                                     IsInitialized                           { get; set; }

        public static SeasonRankingTabView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SeasonRankingTabView() { Pointer= p0 };

            value.SeasonNumberText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B464B28 0x20 SeasonNumberText            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PeriodText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B464B48 0x28 PeriodText                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TargetSongButton                          = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 02466B464B68 0x30 TargetSongButton            ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.RewardDetailButton                        = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 02466B464B88 0x38 RewardDetailButton          ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.HelpButton                                = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 02466B464BA8 0x40 HelpButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.TabGroup                                  = GetObject<UITabGroup>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITabGroup.FromPointer); // 02466B464BC8 0x48 TabGroup                    ( 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.MyselfRankingCell                         = GetObject<MusicScoreRankingCell>(new IntPtr(p + 0x050), ReversePrism.DataModels.MusicScoreRankingCell.FromPointer); // 02466B464BE8 0x50 MyselfRankingCell           ( 000186673AB0 ModelClassType MusicScoreRankingCell MusicScoreRankingCell MusicScoreRankingCell Pointer )
            value.MusicScoreRankingView                     = GetObject<MusicScoreRankingView>(new IntPtr(p + 0x058), ReversePrism.DataModels.MusicScoreRankingView.FromPointer); // 02466B464C08 0x58 MusicScoreRankingView       ( 000186674BB0 ModelClassType MusicScoreRankingView MusicScoreRankingView MusicScoreRankingView Pointer )
            value.TargetSongPopupCaller                     = GetObject<RankingTargetSongPopupCaller>(new IntPtr(p + 0x060), ReversePrism.DataModels.RankingTargetSongPopupCaller.FromPointer); // 02466B464C28 0x60 TargetSongPopupCaller       ( 00018660FEA0 ModelClassType RankingTargetSongPopupCaller RankingTargetSongPopupCaller RankingTargetSongPopupCaller Pointer )
            value.RankingRewardPopupCaller                  = GetObject<RankingRewardPopupCaller>(new IntPtr(p + 0x068), ReversePrism.DataModels.RankingRewardPopupCaller.FromPointer); // 02466B464C48 0x68 RankingRewardPopupCaller    ( 00018660F090 ModelClassType RankingRewardPopupCaller RankingRewardPopupCaller RankingRewardPopupCaller Pointer )
            value.AchievementDetailCaller                   = GetObject<AchievementDetailPopupCaller>(new IntPtr(p + 0x070), ReversePrism.DataModels.AchievementDetailPopupCaller.FromPointer); // 02466B464C68 0x70 AchievementDetailCaller     ( 000186674050 ModelClassType AchievementDetailPopupCaller AchievementDetailPopupCaller AchievementDetailPopupCaller Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x080)); // 02466B464CA8 0x80 Canceller                   ( 000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )
            value.ViewModel                                 = GetObject<MusicRankingOverlayViewModel>(new IntPtr(p + 0x088), ReversePrism.DataModels.MusicRankingOverlayViewModel.FromPointer); // 02466B464CC8 0x88 ViewModel                   ( 00018666BB50 ModelClassType MusicRankingOverlayViewModel MusicRankingOverlayViewModel MusicRankingOverlayViewModel Pointer )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x090)); // 02466B464D08 0x90 IsInitialized               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
