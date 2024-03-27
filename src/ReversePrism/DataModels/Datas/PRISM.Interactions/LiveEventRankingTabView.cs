using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TabGroup                                 0001866F5B90 ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer
    // 028 UserRankingView                          000186750F20 ModelClassType UserRankingView UserRankingView UserRankingView Pointer
    // 030 LiveEventRankingListView                 000186550A60 ModelClassType LiveEventRankingListView LiveEventRankingListView LiveEventRankingListView Pointer
    // 038 DifficultyIcon                           000186665790 ModelClassType MusicDifficultyIcon MusicDifficultyIcon MusicDifficultyIcon Pointer
    // 040 MusicInfoView                            0001866630C0 ModelClassType MusicBasicInfoView MusicBasicInfoView MusicBasicInfoView Pointer
    // 048 PointIcon                                000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 050 AchievementDetailCaller                  000186674050 ModelClassType AchievementDetailPopupCaller AchievementDetailPopupCaller AchievementDetailPopupCaller Pointer
    // 058 AggregationPanel                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 060 AggregationDateText                      0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 CommentInput                             0001865E5200 ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer
    // 070 ProfileCaller                            0001865BD220 ModelClassType ProfilePopupCaller ProfilePopupCaller ProfilePopupCaller Pointer
    // 078 ViewModel                                0001866A3670 ModelClassType LiveEventRankingTabViewModel LiveEventRankingTabViewModel LiveEventRankingTabViewModel Pointer
    // 080 IsInitialized                            000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class LiveEventRankingTabView
    {
        public UITabGroupEx?                            TabGroup                                { get; set; }
        public UserRankingView?                         UserRankingView                         { get; set; }
        public LiveEventRankingListView?                LiveEventRankingListView                { get; set; }
        public MusicDifficultyIcon?                     DifficultyIcon                          { get; set; }
        public MusicBasicInfoView?                      MusicInfoView                           { get; set; }
        public RawImage?                                PointIcon                               { get; set; }
        public AchievementDetailPopupCaller?            AchievementDetailCaller                 { get; set; }
        public GameObject?                              AggregationPanel                        { get; set; }
        public UITextMeshProUGUI?                       AggregationDateText                     { get; set; }
        public CommonInputFieldTMP?                     CommentInput                            { get; set; }
        public ProfilePopupCaller?                      ProfileCaller                           { get; set; }
        public LiveEventRankingTabViewModel?            ViewModel                               { get; set; }
        public bool                                     IsInitialized                           { get; set; }

        public static LiveEventRankingTabView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventRankingTabView();

            value.TabGroup                                  = GetObject<UITabGroupEx>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabGroupEx.FromPointer); // 0270DB910000 0x20 TabGroup                    ( 0001866F5B90 ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer )
            value.UserRankingView                           = GetObject<UserRankingView>(new IntPtr(p + 0x028), ReversePrism.DataModels.UserRankingView.FromPointer); // 0270DB910020 0x28 UserRankingView             ( 000186750F20 ModelClassType UserRankingView UserRankingView UserRankingView Pointer )
            value.LiveEventRankingListView                  = GetObject<LiveEventRankingListView>(new IntPtr(p + 0x030), ReversePrism.DataModels.LiveEventRankingListView.FromPointer); // 0270DB910040 0x30 LiveEventRankingListView    ( 000186550A60 ModelClassType LiveEventRankingListView LiveEventRankingListView LiveEventRankingListView Pointer )
            value.DifficultyIcon                            = GetObject<MusicDifficultyIcon>(new IntPtr(p + 0x038), ReversePrism.DataModels.MusicDifficultyIcon.FromPointer); // 0270DB910060 0x38 DifficultyIcon              ( 000186665790 ModelClassType MusicDifficultyIcon MusicDifficultyIcon MusicDifficultyIcon Pointer )
            value.MusicInfoView                             = GetObject<MusicBasicInfoView>(new IntPtr(p + 0x040), ReversePrism.DataModels.MusicBasicInfoView.FromPointer); // 0270DB910080 0x40 MusicInfoView               ( 0001866630C0 ModelClassType MusicBasicInfoView MusicBasicInfoView MusicBasicInfoView Pointer )
            value.PointIcon                                 = GetObject<RawImage>(new IntPtr(p + 0x048), ReversePrism.DataModels.RawImage.FromPointer); // 0270DB9100A0 0x48 PointIcon                   ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.AchievementDetailCaller                   = GetObject<AchievementDetailPopupCaller>(new IntPtr(p + 0x050), ReversePrism.DataModels.AchievementDetailPopupCaller.FromPointer); // 0270DB9100C0 0x50 AchievementDetailCaller     ( 000186674050 ModelClassType AchievementDetailPopupCaller AchievementDetailPopupCaller AchievementDetailPopupCaller Pointer )
            value.AggregationPanel                          = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB9100E0 0x58 AggregationPanel            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.AggregationDateText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB910100 0x60 AggregationDateText         ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CommentInput                              = GetObject<CommonInputFieldTMP>(new IntPtr(p + 0x068), ReversePrism.DataModels.CommonInputFieldTMP.FromPointer); // 0270DB910120 0x68 CommentInput                ( 0001865E5200 ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer )
            value.ProfileCaller                             = GetObject<ProfilePopupCaller>(new IntPtr(p + 0x070), ReversePrism.DataModels.ProfilePopupCaller.FromPointer); // 0270DB910140 0x70 ProfileCaller               ( 0001865BD220 ModelClassType ProfilePopupCaller ProfilePopupCaller ProfilePopupCaller Pointer )
            value.ViewModel                                 = GetObject<LiveEventRankingTabViewModel>(new IntPtr(p + 0x078), ReversePrism.DataModels.LiveEventRankingTabViewModel.FromPointer); // 0270DB910160 0x78 ViewModel                   ( 0001866A3670 ModelClassType LiveEventRankingTabViewModel LiveEventRankingTabViewModel LiveEventRankingTabViewModel Pointer )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x080)); // 0270DB910180 0x80 IsInitialized               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
