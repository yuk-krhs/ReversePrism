using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 FunctionTabGroup                         ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer
    // 028 RewardCategoryView                       ModelClassType LiveEventRankingCategoryView LiveEventRankingCategoryView LiveEventRankingCategoryView Pointer
    // 030 RewardCategoryViews                      ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 038 RankingCategoryView                      ModelClassType LiveEventRankingCategoryView LiveEventRankingCategoryView LiveEventRankingCategoryView Pointer
    // 040 RankingCategoryViews                     ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 048 MedalGashaRewardTabView                  ModelClassType MedalGashaRewardTabView MedalGashaRewardTabView MedalGashaRewardTabView Pointer
    // 050 MedalExchangeRewardTabView               ModelClassType LiveEventMedalExchangeRewardTabView LiveEventMedalExchangeRewardTabView LiveEventMedalExchangeRewardTabView Pointer
    // 058 EventRankingRewardTabView                ModelClassType EventRankingRewardTabView EventRankingRewardTabView EventRankingRewardTabView Pointer
    // 060 AllSongRewardTabView                     ModelClassType LiveEventAllSongRewardTabView LiveEventAllSongRewardTabView LiveEventAllSongRewardTabView Pointer
    // 068 AllSongIdolRewardTabView                 ModelClassType LiveEventAllSongIdolRewardTabView LiveEventAllSongIdolRewardTabView LiveEventAllSongIdolRewardTabView Pointer
    // 070 EventRankingView                         ModelClassType LiveEventRankingTabView LiveEventRankingTabView LiveEventRankingTabView Pointer
    // 078 HighScoreRankingView                     ModelClassType LiveEventRankingTabView LiveEventRankingTabView LiveEventRankingTabView Pointer
    // 080 AllSongIdolRankingTabView                ModelClassType LiveEventAllSongIdolRankingTabView LiveEventAllSongIdolRankingTabView LiveEventAllSongIdolRankingTabView Pointer
    // 088 AllSongPointRankingTabView               ModelClassType LiveEventAllSongRankingTabView LiveEventAllSongRankingTabView LiveEventAllSongRankingTabView Pointer
    // 090 AllSongHighScoreRankingTabView           ModelClassType LiveEventAllSongRankingTabView LiveEventAllSongRankingTabView LiveEventAllSongRankingTabView Pointer
    // 098 TitleView                                ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 0A0 BackButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 0A8 HowToPlayEventPopupOpener                ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer
    // 0B0 HowToPlayAllSongPopupOpener              ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer
    // 0B8 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 0C0 BackKeyDisposable                        ModelClassType IDisposable IDisposable IDisposable Pointer
    // 0C8 HowToPlayPopupOpener                     ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer
    // 0D0 Model                                    ModelClassType LiveEventRankingViewModel LiveEventRankingViewModel LiveEventRankingViewModel Pointer
    // 0D8 onClose                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class LiveEventRankingOverlayView : DataModel
    {
        public UITabGroupEx?                            FunctionTabGroup                        { get; set; }
        public LiveEventRankingCategoryView?            RewardCategoryView                      { get; set; }
        public List<GameObject>?                        RewardCategoryViews                     { get; set; }
        public LiveEventRankingCategoryView?            RankingCategoryView                     { get; set; }
        public List<GameObject>?                        RankingCategoryViews                    { get; set; }
        public MedalGashaRewardTabView?                 MedalGashaRewardTabView                 { get; set; }
        public LiveEventMedalExchangeRewardTabView?     MedalExchangeRewardTabView              { get; set; }
        public EventRankingRewardTabView?               EventRankingRewardTabView               { get; set; }
        public LiveEventAllSongRewardTabView?           AllSongRewardTabView                    { get; set; }
        public LiveEventAllSongIdolRewardTabView?       AllSongIdolRewardTabView                { get; set; }
        public LiveEventRankingTabView?                 EventRankingView                        { get; set; }
        public LiveEventRankingTabView?                 HighScoreRankingView                    { get; set; }
        public LiveEventAllSongIdolRankingTabView?      AllSongIdolRankingTabView               { get; set; }
        public LiveEventAllSongRankingTabView?          AllSongPointRankingTabView              { get; set; }
        public LiveEventAllSongRankingTabView?          AllSongHighScoreRankingTabView          { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }
        public UIButton?                                BackButton                              { get; set; }
        public HowToPlayPopupOpener?                    HowToPlayEventPopupOpener               { get; set; }
        public HowToPlayPopupOpener?                    HowToPlayAllSongPopupOpener             { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }
        public HowToPlayPopupOpener?                    HowToPlayPopupOpener                    { get; set; }
        public LiveEventRankingViewModel?               Model                                   { get; set; }

        public static LiveEventRankingOverlayView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventRankingOverlayView() { Pointer= p0 };

            value.FunctionTabGroup                          = GetObject<UITabGroupEx>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabGroupEx.FromPointer); // 0x20 FunctionTabGroup            ( ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer )
            value.RewardCategoryView                        = GetObject<LiveEventRankingCategoryView>(new IntPtr(p + 0x028), ReversePrism.DataModels.LiveEventRankingCategoryView.FromPointer); // 0x28 RewardCategoryView          ( ModelClassType LiveEventRankingCategoryView LiveEventRankingCategoryView LiveEventRankingCategoryView Pointer )
            value.RewardCategoryViews                       = GetObjectList<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 RewardCategoryViews         ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.RankingCategoryView                       = GetObject<LiveEventRankingCategoryView>(new IntPtr(p + 0x038), ReversePrism.DataModels.LiveEventRankingCategoryView.FromPointer); // 0x38 RankingCategoryView         ( ModelClassType LiveEventRankingCategoryView LiveEventRankingCategoryView LiveEventRankingCategoryView Pointer )
            value.RankingCategoryViews                      = GetObjectList<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 RankingCategoryViews        ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.MedalGashaRewardTabView                   = GetObject<MedalGashaRewardTabView>(new IntPtr(p + 0x048), ReversePrism.DataModels.MedalGashaRewardTabView.FromPointer); // 0x48 MedalGashaRewardTabView     ( ModelClassType MedalGashaRewardTabView MedalGashaRewardTabView MedalGashaRewardTabView Pointer )
            value.MedalExchangeRewardTabView                = GetObject<LiveEventMedalExchangeRewardTabView>(new IntPtr(p + 0x050), ReversePrism.DataModels.LiveEventMedalExchangeRewardTabView.FromPointer); // 0x50 MedalExchangeRewardTabView  ( ModelClassType LiveEventMedalExchangeRewardTabView LiveEventMedalExchangeRewardTabView LiveEventMedalExchangeRewardTabView Pointer )
            value.EventRankingRewardTabView                 = GetObject<EventRankingRewardTabView>(new IntPtr(p + 0x058), ReversePrism.DataModels.EventRankingRewardTabView.FromPointer); // 0x58 EventRankingRewardTabView   ( ModelClassType EventRankingRewardTabView EventRankingRewardTabView EventRankingRewardTabView Pointer )
            value.AllSongRewardTabView                      = GetObject<LiveEventAllSongRewardTabView>(new IntPtr(p + 0x060), ReversePrism.DataModels.LiveEventAllSongRewardTabView.FromPointer); // 0x60 AllSongRewardTabView        ( ModelClassType LiveEventAllSongRewardTabView LiveEventAllSongRewardTabView LiveEventAllSongRewardTabView Pointer )
            value.AllSongIdolRewardTabView                  = GetObject<LiveEventAllSongIdolRewardTabView>(new IntPtr(p + 0x068), ReversePrism.DataModels.LiveEventAllSongIdolRewardTabView.FromPointer); // 0x68 AllSongIdolRewardTabView    ( ModelClassType LiveEventAllSongIdolRewardTabView LiveEventAllSongIdolRewardTabView LiveEventAllSongIdolRewardTabView Pointer )
            value.EventRankingView                          = GetObject<LiveEventRankingTabView>(new IntPtr(p + 0x070), ReversePrism.DataModels.LiveEventRankingTabView.FromPointer); // 0x70 EventRankingView            ( ModelClassType LiveEventRankingTabView LiveEventRankingTabView LiveEventRankingTabView Pointer )
            value.HighScoreRankingView                      = GetObject<LiveEventRankingTabView>(new IntPtr(p + 0x078), ReversePrism.DataModels.LiveEventRankingTabView.FromPointer); // 0x78 HighScoreRankingView        ( ModelClassType LiveEventRankingTabView LiveEventRankingTabView LiveEventRankingTabView Pointer )
            value.AllSongIdolRankingTabView                 = GetObject<LiveEventAllSongIdolRankingTabView>(new IntPtr(p + 0x080), ReversePrism.DataModels.LiveEventAllSongIdolRankingTabView.FromPointer); // 0x80 AllSongIdolRankingTabView   ( ModelClassType LiveEventAllSongIdolRankingTabView LiveEventAllSongIdolRankingTabView LiveEventAllSongIdolRankingTabView Pointer )
            value.AllSongPointRankingTabView                = GetObject<LiveEventAllSongRankingTabView>(new IntPtr(p + 0x088), ReversePrism.DataModels.LiveEventAllSongRankingTabView.FromPointer); // 0x88 AllSongPointRankingTabView  ( ModelClassType LiveEventAllSongRankingTabView LiveEventAllSongRankingTabView LiveEventAllSongRankingTabView Pointer )
            value.AllSongHighScoreRankingTabView            = GetObject<LiveEventAllSongRankingTabView>(new IntPtr(p + 0x090), ReversePrism.DataModels.LiveEventAllSongRankingTabView.FromPointer); // 0x90 AllSongHighScoreRankingTabView ( ModelClassType LiveEventAllSongRankingTabView LiveEventAllSongRankingTabView LiveEventAllSongRankingTabView Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x098), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0x98 TitleView                   ( ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.BackButton                                = GetObject<UIButton>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.UIButton.FromPointer); // 0xA0 BackButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.HowToPlayEventPopupOpener                 = GetObject<HowToPlayPopupOpener>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.HowToPlayPopupOpener.FromPointer); // 0xA8 HowToPlayEventPopupOpener   ( ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer )
            value.HowToPlayAllSongPopupOpener               = GetObject<HowToPlayPopupOpener>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.HowToPlayPopupOpener.FromPointer); // 0xB0 HowToPlayAllSongPopupOpener ( ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0xB8 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.IDisposable.FromPointer); // 0xC0 BackKeyDisposable           ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.HowToPlayPopupOpener                      = GetObject<HowToPlayPopupOpener>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.HowToPlayPopupOpener.FromPointer); // 0xC8 HowToPlayPopupOpener        ( ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer )
            value.Model                                     = GetObject<LiveEventRankingViewModel>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.LiveEventRankingViewModel.FromPointer); // 0xD0 Model                       ( ModelClassType LiveEventRankingViewModel LiveEventRankingViewModel LiveEventRankingViewModel Pointer )

            return value;
        }
    }
}
