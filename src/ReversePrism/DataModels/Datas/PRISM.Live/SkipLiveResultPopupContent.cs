using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 MiniStageDisplay                         ModelClassType RawImage RawImage RawImage Pointer
    // 068 MusicInfoView                            ModelClassType MusicBasicInfoView MusicBasicInfoView MusicBasicInfoView Pointer
    // 070 ClearAnimation                           ModelClassType GameObject GameObject GameObject Pointer
    // 078 ScoreRankAnimator                        ModelClassType Animator Animator Animator Pointer
    // 080 LBMoneyView                              ModelClassType LiveRewardLBMoneyView LiveRewardLBMoneyView LiveRewardLBMoneyView Pointer
    // 088 RewardScrollRect                         ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 090 LiveBonusRewardContainer                 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 098 ClearRewardContainer                     ModelClassType RectTransform RectTransform RectTransform Pointer
    // 0A0 ScoreRankRewardContainer                 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 0A8 OtherRewardContainer                     ModelClassType RectTransform RectTransform RectTransform Pointer
    // 0B0 RewardItemPrefab                         ModelClassType LiveResultRewardItem LiveResultRewardItem LiveResultRewardItem Pointer
    // 0B8 IdolViewContainer                        ModelClassType RectTransform RectTransform RectTransform Pointer
    // 0C0 IdolViewPrefab                           ModelClassType LiveResultIdolView LiveResultIdolView LiveResultIdolView Pointer
    // 0C8 EventLogoImage                           ModelClassType UIImage UIImage UIImage Pointer
    // 0D0 EventScoreDetailPanel                    ModelClassType LiveEventScoreDetailPanel LiveEventScoreDetailPanel LiveEventScoreDetailPanel Pointer
    // 0D8 AllSongEventIdolViewContainer            ModelClassType RectTransform RectTransform RectTransform Pointer
    // 0E0 AllSongEventIdolViewPrefab               ModelClassType LiveResultAllSongEventIdolView LiveResultAllSongEventIdolView LiveResultAllSongEventIdolView Pointer
    // 0E8 SkipAnimationButton                      ModelClassType Button Button Button Pointer
    // 0F0 CloseButton                              ModelClassType PopupButton PopupButton PopupButton Pointer
    // 0F8 rewardItemDic                            Dictionary`2<RectTransform, List`1<LiveResultRewardItem>> IL2CPP_TYPE_GENERICINST
    // 100 Model3dLoader                            ModelClassType SimpleModel3dLoader SimpleModel3dLoader SimpleModel3dLoader Pointer
    // 108 Unit                                     ModelClassType LiveUnit LiveUnit LiveUnit Pointer
    // 110 MiniStageCamera                          ModelClassType CameraController CameraController CameraController Pointer
    // 118 Reply                                    ModelClassType ISkipLiveReply ISkipLiveReply ISkipLiveReply Pointer
    // 120 IdolViews                                ModelClassListType LiveResultIdolView[] LiveResultIdolView[] List<LiveResultIdolView> Pointer
    // 128 AllSongEventIdolViews                    ModelClassListType LiveResultAllSongEventIdolView[] LiveResultAllSongEventIdolView[] List<LiveResultAllSongEventIdolView> Pointer
    // 130 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 138 AnimationCanceller                       ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class SkipLiveResultPopupContent : DataModel
    {
        public RawImage?                                MiniStageDisplay                        { get; set; }
        public MusicBasicInfoView?                      MusicInfoView                           { get; set; }
        public GameObject?                              ClearAnimation                          { get; set; }
        public Animator?                                ScoreRankAnimator                       { get; set; }
        public LiveRewardLBMoneyView?                   LBMoneyView                             { get; set; }
        public ScrollRect?                              RewardScrollRect                        { get; set; }
        public RectTransform?                           LiveBonusRewardContainer                { get; set; }
        public RectTransform?                           ClearRewardContainer                    { get; set; }
        public RectTransform?                           ScoreRankRewardContainer                { get; set; }
        public RectTransform?                           OtherRewardContainer                    { get; set; }
        public LiveResultRewardItem?                    RewardItemPrefab                        { get; set; }
        public RectTransform?                           IdolViewContainer                       { get; set; }
        public LiveResultIdolView?                      IdolViewPrefab                          { get; set; }
        public UIImage?                                 EventLogoImage                          { get; set; }
        public LiveEventScoreDetailPanel?               EventScoreDetailPanel                   { get; set; }
        public RectTransform?                           AllSongEventIdolViewContainer           { get; set; }
        public LiveResultAllSongEventIdolView?          AllSongEventIdolViewPrefab              { get; set; }
        public Button?                                  SkipAnimationButton                     { get; set; }
        public PopupButton?                             CloseButton                             { get; set; }
        public SimpleModel3dLoader?                     Model3dLoader                           { get; set; }
        public LiveUnit?                                Unit                                    { get; set; }
        public CameraController?                        MiniStageCamera                         { get; set; }
        public ISkipLiveReply?                          Reply                                   { get; set; }
        public List<LiveResultIdolView>?                IdolViews                               { get; set; }
        public List<LiveResultAllSongEventIdolView>?    AllSongEventIdolViews                   { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }
        public CancellationTokenSource?                 AnimationCanceller                      { get; set; }

        public static SkipLiveResultPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SkipLiveResultPopupContent() { Pointer= p0 };

            value.MiniStageDisplay                          = GetObject<RawImage>(new IntPtr(p + 0x060), ReversePrism.DataModels.RawImage.FromPointer); // 0x60 MiniStageDisplay            ( ModelClassType RawImage RawImage RawImage Pointer )
            value.MusicInfoView                             = GetObject<MusicBasicInfoView>(new IntPtr(p + 0x068), ReversePrism.DataModels.MusicBasicInfoView.FromPointer); // 0x68 MusicInfoView               ( ModelClassType MusicBasicInfoView MusicBasicInfoView MusicBasicInfoView Pointer )
            value.ClearAnimation                            = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 ClearAnimation              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ScoreRankAnimator                         = GetObject<Animator>(new IntPtr(p + 0x078), ReversePrism.DataModels.Animator.FromPointer); // 0x78 ScoreRankAnimator           ( ModelClassType Animator Animator Animator Pointer )
            value.LBMoneyView                               = GetObject<LiveRewardLBMoneyView>(new IntPtr(p + 0x080), ReversePrism.DataModels.LiveRewardLBMoneyView.FromPointer); // 0x80 LBMoneyView                 ( ModelClassType LiveRewardLBMoneyView LiveRewardLBMoneyView LiveRewardLBMoneyView Pointer )
            value.RewardScrollRect                          = GetObject<ScrollRect>(new IntPtr(p + 0x088), ReversePrism.DataModels.ScrollRect.FromPointer); // 0x88 RewardScrollRect            ( ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.LiveBonusRewardContainer                  = GetObject<RectTransform>(new IntPtr(p + 0x090), ReversePrism.DataModels.RectTransform.FromPointer); // 0x90 LiveBonusRewardContainer    ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.ClearRewardContainer                      = GetObject<RectTransform>(new IntPtr(p + 0x098), ReversePrism.DataModels.RectTransform.FromPointer); // 0x98 ClearRewardContainer        ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.ScoreRankRewardContainer                  = GetObject<RectTransform>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.RectTransform.FromPointer); // 0xA0 ScoreRankRewardContainer    ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.OtherRewardContainer                      = GetObject<RectTransform>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.RectTransform.FromPointer); // 0xA8 OtherRewardContainer        ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.RewardItemPrefab                          = GetObject<LiveResultRewardItem>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.LiveResultRewardItem.FromPointer); // 0xB0 RewardItemPrefab            ( ModelClassType LiveResultRewardItem LiveResultRewardItem LiveResultRewardItem Pointer )
            value.IdolViewContainer                         = GetObject<RectTransform>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.RectTransform.FromPointer); // 0xB8 IdolViewContainer           ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.IdolViewPrefab                            = GetObject<LiveResultIdolView>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.LiveResultIdolView.FromPointer); // 0xC0 IdolViewPrefab              ( ModelClassType LiveResultIdolView LiveResultIdolView LiveResultIdolView Pointer )
            value.EventLogoImage                            = GetObject<UIImage>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.UIImage.FromPointer); // 0xC8 EventLogoImage              ( ModelClassType UIImage UIImage UIImage Pointer )
            value.EventScoreDetailPanel                     = GetObject<LiveEventScoreDetailPanel>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.LiveEventScoreDetailPanel.FromPointer); // 0xD0 EventScoreDetailPanel       ( ModelClassType LiveEventScoreDetailPanel LiveEventScoreDetailPanel LiveEventScoreDetailPanel Pointer )
            value.AllSongEventIdolViewContainer             = GetObject<RectTransform>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.RectTransform.FromPointer); // 0xD8 AllSongEventIdolViewContainer ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.AllSongEventIdolViewPrefab                = GetObject<LiveResultAllSongEventIdolView>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.LiveResultAllSongEventIdolView.FromPointer); // 0xE0 AllSongEventIdolViewPrefab  ( ModelClassType LiveResultAllSongEventIdolView LiveResultAllSongEventIdolView LiveResultAllSongEventIdolView Pointer )
            value.SkipAnimationButton                       = GetObject<Button>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.Button.FromPointer); // 0xE8 SkipAnimationButton         ( ModelClassType Button Button Button Pointer )
            value.CloseButton                               = GetObject<PopupButton>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.PopupButton.FromPointer); // 0xF0 CloseButton                 ( ModelClassType PopupButton PopupButton PopupButton Pointer )
            value.Model3dLoader                             = GetObject<SimpleModel3dLoader>(new IntPtr(p + 0x100), ReversePrism.DataModels.SimpleModel3dLoader.FromPointer); // 0x100 Model3dLoader               ( ModelClassType SimpleModel3dLoader SimpleModel3dLoader SimpleModel3dLoader Pointer )
            value.Unit                                      = GetObject<LiveUnit>(new IntPtr(p + 0x108), ReversePrism.DataModels.LiveUnit.FromPointer); // 0x108 Unit                        ( ModelClassType LiveUnit LiveUnit LiveUnit Pointer )
            value.MiniStageCamera                           = GetObject<CameraController>(new IntPtr(p + 0x110), ReversePrism.DataModels.CameraController.FromPointer); // 0x110 MiniStageCamera             ( ModelClassType CameraController CameraController CameraController Pointer )
            value.Reply                                     = GetObject<ISkipLiveReply>(new IntPtr(p + 0x118), ReversePrism.DataModels.ISkipLiveReply.FromPointer); // 0x118 Reply                       ( ModelClassType ISkipLiveReply ISkipLiveReply ISkipLiveReply Pointer )
            value.IdolViews                                 = GetObjectList<LiveResultIdolView>(new IntPtr(p + 0x120), ReversePrism.DataModels.LiveResultIdolView.FromPointer); // 0x120 IdolViews                   ( ModelClassListType LiveResultIdolView[] LiveResultIdolView[] List<LiveResultIdolView> Pointer )
            value.AllSongEventIdolViews                     = GetObjectList<LiveResultAllSongEventIdolView>(new IntPtr(p + 0x128), ReversePrism.DataModels.LiveResultAllSongEventIdolView.FromPointer); // 0x128 AllSongEventIdolViews       ( ModelClassListType LiveResultAllSongEventIdolView[] LiveResultAllSongEventIdolView[] List<LiveResultAllSongEventIdolView> Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x130), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x130 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.AnimationCanceller                        = GetObject<CancellationTokenSource>(new IntPtr(p + 0x138), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x138 AnimationCanceller          ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
