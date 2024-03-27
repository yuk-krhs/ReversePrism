using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 FunctionTabGroup                         0001866F5B90 ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer
    // 028 RewardCategoryView                       00018654FB60 ModelClassType LiveEventRankingCategoryView LiveEventRankingCategoryView LiveEventRankingCategoryView Pointer
    // 030 RewardCategoryViews                      000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 038 RankingCategoryView                      00018654FB60 ModelClassType LiveEventRankingCategoryView LiveEventRankingCategoryView LiveEventRankingCategoryView Pointer
    // 040 RankingCategoryViews                     000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 048 MedalGashaRewardTabView                  0001865EDB30 ModelClassType MedalGashaRewardTabView MedalGashaRewardTabView MedalGashaRewardTabView Pointer
    // 050 EventRankingRewardTabView                000186761780 ModelClassType EventRankingRewardTabView EventRankingRewardTabView EventRankingRewardTabView Pointer
    // 058 EventRankingView                         000186551E50 ModelClassType LiveEventRankingTabView LiveEventRankingTabView LiveEventRankingTabView Pointer
    // 060 HighScoreRankingView                     000186551E50 ModelClassType LiveEventRankingTabView LiveEventRankingTabView LiveEventRankingTabView Pointer
    // 068 TitleView                                0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 070 BackButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 078 HowToPlayPopupOpener                     0001866D8C30 ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer
    // 080 ResourceLoader                           00018661A8D0 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 088 BackKeyDisposable                        0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 090 Model                                    0001865525E0 ModelClassType LiveEventRankingViewModel LiveEventRankingViewModel LiveEventRankingViewModel Pointer
    // 098 onClose                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class LiveEventRankingOverlayView
    {
        public UITabGroupEx?                            FunctionTabGroup                        { get; set; }
        public LiveEventRankingCategoryView?            RewardCategoryView                      { get; set; }
        public List<GameObject>?                        RewardCategoryViews                     { get; set; }
        public LiveEventRankingCategoryView?            RankingCategoryView                     { get; set; }
        public List<GameObject>?                        RankingCategoryViews                    { get; set; }
        public MedalGashaRewardTabView?                 MedalGashaRewardTabView                 { get; set; }
        public EventRankingRewardTabView?               EventRankingRewardTabView               { get; set; }
        public LiveEventRankingTabView?                 EventRankingView                        { get; set; }
        public LiveEventRankingTabView?                 HighScoreRankingView                    { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }
        public UIButton?                                BackButton                              { get; set; }
        public HowToPlayPopupOpener?                    HowToPlayPopupOpener                    { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }
        public LiveEventRankingViewModel?               Model                                   { get; set; }

        public static LiveEventRankingOverlayView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventRankingOverlayView();

            value.FunctionTabGroup                          = GetObject<UITabGroupEx>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabGroupEx.FromPointer); // 0270DB90DAA8 0x20 FunctionTabGroup            ( 0001866F5B90 ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer )
            value.RewardCategoryView                        = GetObject<LiveEventRankingCategoryView>(new IntPtr(p + 0x028), ReversePrism.DataModels.LiveEventRankingCategoryView.FromPointer); // 0270DB90DAC8 0x28 RewardCategoryView          ( 00018654FB60 ModelClassType LiveEventRankingCategoryView LiveEventRankingCategoryView LiveEventRankingCategoryView Pointer )
            value.RewardCategoryViews                       = GetObjectList<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB90DAE8 0x30 RewardCategoryViews         ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.RankingCategoryView                       = GetObject<LiveEventRankingCategoryView>(new IntPtr(p + 0x038), ReversePrism.DataModels.LiveEventRankingCategoryView.FromPointer); // 0270DB90DB08 0x38 RankingCategoryView         ( 00018654FB60 ModelClassType LiveEventRankingCategoryView LiveEventRankingCategoryView LiveEventRankingCategoryView Pointer )
            value.RankingCategoryViews                      = GetObjectList<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB90DB28 0x40 RankingCategoryViews        ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.MedalGashaRewardTabView                   = GetObject<MedalGashaRewardTabView>(new IntPtr(p + 0x048), ReversePrism.DataModels.MedalGashaRewardTabView.FromPointer); // 0270DB90DB48 0x48 MedalGashaRewardTabView     ( 0001865EDB30 ModelClassType MedalGashaRewardTabView MedalGashaRewardTabView MedalGashaRewardTabView Pointer )
            value.EventRankingRewardTabView                 = GetObject<EventRankingRewardTabView>(new IntPtr(p + 0x050), ReversePrism.DataModels.EventRankingRewardTabView.FromPointer); // 0270DB90DB68 0x50 EventRankingRewardTabView   ( 000186761780 ModelClassType EventRankingRewardTabView EventRankingRewardTabView EventRankingRewardTabView Pointer )
            value.EventRankingView                          = GetObject<LiveEventRankingTabView>(new IntPtr(p + 0x058), ReversePrism.DataModels.LiveEventRankingTabView.FromPointer); // 0270DB90DB88 0x58 EventRankingView            ( 000186551E50 ModelClassType LiveEventRankingTabView LiveEventRankingTabView LiveEventRankingTabView Pointer )
            value.HighScoreRankingView                      = GetObject<LiveEventRankingTabView>(new IntPtr(p + 0x060), ReversePrism.DataModels.LiveEventRankingTabView.FromPointer); // 0270DB90DBA8 0x60 HighScoreRankingView        ( 000186551E50 ModelClassType LiveEventRankingTabView LiveEventRankingTabView LiveEventRankingTabView Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x068), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0270DB90DBC8 0x68 TitleView                   ( 0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.BackButton                                = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB90DBE8 0x70 BackButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.HowToPlayPopupOpener                      = GetObject<HowToPlayPopupOpener>(new IntPtr(p + 0x078), ReversePrism.DataModels.HowToPlayPopupOpener.FromPointer); // 0270DB90DC08 0x78 HowToPlayPopupOpener        ( 0001866D8C30 ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x080), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0270DB90DC28 0x80 ResourceLoader              ( 00018661A8D0 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x088), ReversePrism.DataModels.IDisposable.FromPointer); // 0270DB90DC48 0x88 BackKeyDisposable           ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.Model                                     = GetObject<LiveEventRankingViewModel>(new IntPtr(p + 0x090), ReversePrism.DataModels.LiveEventRankingViewModel.FromPointer); // 0270DB90DC68 0x90 Model                       ( 0001865525E0 ModelClassType LiveEventRankingViewModel LiveEventRankingViewModel LiveEventRankingViewModel Pointer )

            return value;
        }
    }
}
