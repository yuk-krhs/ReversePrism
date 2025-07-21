using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SeasonNumberText                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 PeriodText                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 TargetSongButton                         ModelClassType UIButton UIButton UIButton Pointer
    // 038 RewardDetailButton                       ModelClassType UIButton UIButton UIButton Pointer
    // 040 HelpButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 048 TabGroup                                 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 050 MyselfRankingCell                        ModelClassType MusicScoreRankingCell MusicScoreRankingCell MusicScoreRankingCell Pointer
    // 058 MusicScoreRankingView                    ModelClassType MusicScoreRankingView MusicScoreRankingView MusicScoreRankingView Pointer
    // 060 onSelectMusic                            Subject`1<ValueTuple`2<int, SongDifficultyLevel>> IL2CPP_TYPE_GENERICINST
    // 068 Canceller                                ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    // 070 ViewModel                                ModelClassType MusicRankingOverlayViewModel MusicRankingOverlayViewModel MusicRankingOverlayViewModel Pointer
    // 000 Path                                     string IL2CPP_TYPE_STRING
    // 078 IsInitialized                            ModelPrimitiveType bool bool bool Bool
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
        public AutoCancellationTokenSource              Canceller                               { get; set; }
        public MusicRankingOverlayViewModel?            ViewModel                               { get; set; }
        public bool                                     IsInitialized                           { get; set; }

        public static SeasonRankingTabView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SeasonRankingTabView() { Pointer= p0 };

            value.SeasonNumberText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 SeasonNumberText            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PeriodText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 PeriodText                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TargetSongButton                          = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0x30 TargetSongButton            ( ModelClassType UIButton UIButton UIButton Pointer )
            value.RewardDetailButton                        = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 RewardDetailButton          ( ModelClassType UIButton UIButton UIButton Pointer )
            value.HelpButton                                = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0x40 HelpButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.TabGroup                                  = GetObject<UITabGroup>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITabGroup.FromPointer); // 0x48 TabGroup                    ( ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.MyselfRankingCell                         = GetObject<MusicScoreRankingCell>(new IntPtr(p + 0x050), ReversePrism.DataModels.MusicScoreRankingCell.FromPointer); // 0x50 MyselfRankingCell           ( ModelClassType MusicScoreRankingCell MusicScoreRankingCell MusicScoreRankingCell Pointer )
            value.MusicScoreRankingView                     = GetObject<MusicScoreRankingView>(new IntPtr(p + 0x058), ReversePrism.DataModels.MusicScoreRankingView.FromPointer); // 0x58 MusicScoreRankingView       ( ModelClassType MusicScoreRankingView MusicScoreRankingView MusicScoreRankingView Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x068)); // 0x68 Canceller                   ( ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )
            value.ViewModel                                 = GetObject<MusicRankingOverlayViewModel>(new IntPtr(p + 0x070), ReversePrism.DataModels.MusicRankingOverlayViewModel.FromPointer); // 0x70 ViewModel                   ( ModelClassType MusicRankingOverlayViewModel MusicRankingOverlayViewModel MusicRankingOverlayViewModel Pointer )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x078)); // 0x78 IsInitialized               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
