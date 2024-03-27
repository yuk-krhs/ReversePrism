using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 MiniStageDisplay                         000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 068 MusicInfoView                            0001866630C0 ModelClassType MusicBasicInfoView MusicBasicInfoView MusicBasicInfoView Pointer
    // 070 ClearAnimation                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 078 ScoreRankAnimator                        0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 080 LBMoneyView                              000186576340 ModelClassType LiveRewardLBMoneyView LiveRewardLBMoneyView LiveRewardLBMoneyView Pointer
    // 088 RewardScrollRect                         0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 090 LiveBonusRewardContainer                 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 098 ClearRewardContainer                     000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 0A0 ScoreRankRewardContainer                 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 0A8 OtherRewardContainer                     000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 0B0 RewardItemPrefab                         000186573C40 ModelClassType LiveResultRewardItem LiveResultRewardItem LiveResultRewardItem Pointer
    // 0B8 IdolViewContainer                        000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 0C0 IdolViewPrefab                           0001865706D0 ModelClassType LiveResultIdolView LiveResultIdolView LiveResultIdolView Pointer
    // 0C8 EventLogoImage                           0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 0D0 EventScoreDetailPanel                    0001865543E0 ModelClassType LiveEventScoreDetailPanel LiveEventScoreDetailPanel LiveEventScoreDetailPanel Pointer
    // 0D8 SkipAnimationButton                      0001865140C0 ModelClassType Button Button Button Pointer
    // 0E0 CloseButton                              0001867605D0 ModelClassType PopupButton PopupButton PopupButton Pointer
    // 0E8 rewardItemDic                            Dictionary`2<RectTransform, List`1<LiveResultRewardItem>> IL2CPP_TYPE_GENERICINST
    // 0F0 Unit                                     000186588310 ModelClassType LiveUnit LiveUnit LiveUnit Pointer
    // 0F8 MiniStageCamera                          000186536460 ModelClassType CameraController CameraController CameraController Pointer
    // 100 Reply                                    000186647990 ModelClassType ISkipLiveReply ISkipLiveReply ISkipLiveReply Pointer
    // 108 IdolViews                                000185B912F0 ModelClassListType LiveResultIdolView[] LiveResultIdolView[] List<LiveResultIdolView> Pointer
    // 000 ResourceTag                              string IL2CPP_TYPE_STRING
    // 110 AnimationCanceller                       0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class SkipLiveResultPopupContent
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
        public Button?                                  SkipAnimationButton                     { get; set; }
        public PopupButton?                             CloseButton                             { get; set; }
        public LiveUnit?                                Unit                                    { get; set; }
        public CameraController?                        MiniStageCamera                         { get; set; }
        public ISkipLiveReply?                          Reply                                   { get; set; }
        public List<LiveResultIdolView>?                IdolViews                               { get; set; }
        public CancellationTokenSource?                 AnimationCanceller                      { get; set; }

        public static SkipLiveResultPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SkipLiveResultPopupContent();

            value.MiniStageDisplay                          = GetObject<RawImage>(new IntPtr(p + 0x060), ReversePrism.DataModels.RawImage.FromPointer); // 0270D522ADB0 0x60 MiniStageDisplay            ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.MusicInfoView                             = GetObject<MusicBasicInfoView>(new IntPtr(p + 0x068), ReversePrism.DataModels.MusicBasicInfoView.FromPointer); // 0270D522ADD0 0x68 MusicInfoView               ( 0001866630C0 ModelClassType MusicBasicInfoView MusicBasicInfoView MusicBasicInfoView Pointer )
            value.ClearAnimation                            = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0270D522ADF0 0x70 ClearAnimation              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ScoreRankAnimator                         = GetObject<Animator>(new IntPtr(p + 0x078), ReversePrism.DataModels.Animator.FromPointer); // 0270D522AE10 0x78 ScoreRankAnimator           ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.LBMoneyView                               = GetObject<LiveRewardLBMoneyView>(new IntPtr(p + 0x080), ReversePrism.DataModels.LiveRewardLBMoneyView.FromPointer); // 0270D522AE30 0x80 LBMoneyView                 ( 000186576340 ModelClassType LiveRewardLBMoneyView LiveRewardLBMoneyView LiveRewardLBMoneyView Pointer )
            value.RewardScrollRect                          = GetObject<ScrollRect>(new IntPtr(p + 0x088), ReversePrism.DataModels.ScrollRect.FromPointer); // 0270D522AE50 0x88 RewardScrollRect            ( 0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.LiveBonusRewardContainer                  = GetObject<RectTransform>(new IntPtr(p + 0x090), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D522AE70 0x90 LiveBonusRewardContainer    ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.ClearRewardContainer                      = GetObject<RectTransform>(new IntPtr(p + 0x098), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D522AE90 0x98 ClearRewardContainer        ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.ScoreRankRewardContainer                  = GetObject<RectTransform>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D522AEB0 0xA0 ScoreRankRewardContainer    ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.OtherRewardContainer                      = GetObject<RectTransform>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D522AED0 0xA8 OtherRewardContainer        ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.RewardItemPrefab                          = GetObject<LiveResultRewardItem>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.LiveResultRewardItem.FromPointer); // 0270D522AEF0 0xB0 RewardItemPrefab            ( 000186573C40 ModelClassType LiveResultRewardItem LiveResultRewardItem LiveResultRewardItem Pointer )
            value.IdolViewContainer                         = GetObject<RectTransform>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D522AF10 0xB8 IdolViewContainer           ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.IdolViewPrefab                            = GetObject<LiveResultIdolView>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.LiveResultIdolView.FromPointer); // 0270D522AF30 0xC0 IdolViewPrefab              ( 0001865706D0 ModelClassType LiveResultIdolView LiveResultIdolView LiveResultIdolView Pointer )
            value.EventLogoImage                            = GetObject<UIImage>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.UIImage.FromPointer); // 0270D522AF50 0xC8 EventLogoImage              ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.EventScoreDetailPanel                     = GetObject<LiveEventScoreDetailPanel>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.LiveEventScoreDetailPanel.FromPointer); // 0270D522AF70 0xD0 EventScoreDetailPanel       ( 0001865543E0 ModelClassType LiveEventScoreDetailPanel LiveEventScoreDetailPanel LiveEventScoreDetailPanel Pointer )
            value.SkipAnimationButton                       = GetObject<Button>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.Button.FromPointer); // 0270D522AF90 0xD8 SkipAnimationButton         ( 0001865140C0 ModelClassType Button Button Button Pointer )
            value.CloseButton                               = GetObject<PopupButton>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.PopupButton.FromPointer); // 0270D522AFB0 0xE0 CloseButton                 ( 0001867605D0 ModelClassType PopupButton PopupButton PopupButton Pointer )
            value.Unit                                      = GetObject<LiveUnit>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.LiveUnit.FromPointer); // 0270D522AFF0 0xF0 Unit                        ( 000186588310 ModelClassType LiveUnit LiveUnit LiveUnit Pointer )
            value.MiniStageCamera                           = GetObject<CameraController>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.CameraController.FromPointer); // 0270D522B010 0xF8 MiniStageCamera             ( 000186536460 ModelClassType CameraController CameraController CameraController Pointer )
            value.Reply                                     = GetObject<ISkipLiveReply>(new IntPtr(p + 0x100), ReversePrism.DataModels.ISkipLiveReply.FromPointer); // 0270D522B030 0x100 Reply                       ( 000186647990 ModelClassType ISkipLiveReply ISkipLiveReply ISkipLiveReply Pointer )
            value.IdolViews                                 = GetObjectList<LiveResultIdolView>(new IntPtr(p + 0x108), ReversePrism.DataModels.LiveResultIdolView.FromPointer); // 0270D522B050 0x108 IdolViews                   ( 000185B912F0 ModelClassListType LiveResultIdolView[] LiveResultIdolView[] List<LiveResultIdolView> Pointer )
            value.AnimationCanceller                        = GetObject<CancellationTokenSource>(new IntPtr(p + 0x110), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D522B090 0x110 AnimationCanceller          ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
