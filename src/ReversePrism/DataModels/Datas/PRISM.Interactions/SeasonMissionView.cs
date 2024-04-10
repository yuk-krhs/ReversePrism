using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CloseButton                              000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 028 UiTabGroup                               0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 030 AllReceiveButton                         000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 038 AllReceivePositiveObject                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 AllReceiveLockObject                     0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 PremiumUnlockButton                      000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 050 TermText                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 TermTitleText                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 RankView                                 000186705670 ModelClassType SeasonMissionRankView SeasonMissionRankView SeasonMissionRankView Pointer
    // 068 RewardListView                           000186706920 ModelClassType SeasonMissionRewardListView SeasonMissionRewardListView SeasonMissionRewardListView Pointer
    // 070 MissionListView                          000186702CC0 ModelClassType SeasonMissionMissionListView SeasonMissionMissionListView SeasonMissionMissionListView Pointer
    // 078 SeasonEndAnimator                        0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 080 RankUpStagingView                        000186705190 ModelClassType SeasonMissionRankUpStagingView SeasonMissionRankUpStagingView SeasonMissionRankUpStagingView Pointer
    // 088 RewardTab                                000186708BC0 ModelClassType SeasonMissionTab SeasonMissionTab SeasonMissionTab Pointer
    // 090 MissionTab                               000186708BC0 ModelClassType SeasonMissionTab SeasonMissionTab SeasonMissionTab Pointer
    // 098 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0A0 MissionFilterView                        000186580020 ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer
    // 0A8 missionFilterPopupFactory                PopupViewFactory`1<ISeasonMissionFilterPopupView> IL2CPP_TYPE_GENERICINST
    // 0B0 shopOverlayFactory                       OverlayViewFactory`1<IShopView> IL2CPP_TYPE_GENERICINST
    // 0B8 ViewModel                                00018670A4A0 ModelClassType SeasonMissionViewModel SeasonMissionViewModel SeasonMissionViewModel Pointer
    // 0C0 BackKeyDisposable                        0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 0C8 Disposable                               0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 0D0 ResourceLoader                           00018661A8D0 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    public partial class SeasonMissionView : DataModel
    {
        public ButtonBase?                              CloseButton                             { get; set; }
        public UITabGroup?                              UiTabGroup                              { get; set; }
        public ButtonBase?                              AllReceiveButton                        { get; set; }
        public GameObject?                              AllReceivePositiveObject                { get; set; }
        public GameObject?                              AllReceiveLockObject                    { get; set; }
        public ButtonBase?                              PremiumUnlockButton                     { get; set; }
        public UITextMeshProUGUI?                       TermText                                { get; set; }
        public UITextMeshProUGUI?                       TermTitleText                           { get; set; }
        public SeasonMissionRankView?                   RankView                                { get; set; }
        public SeasonMissionRewardListView?             RewardListView                          { get; set; }
        public SeasonMissionMissionListView?            MissionListView                         { get; set; }
        public Animator?                                SeasonEndAnimator                       { get; set; }
        public SeasonMissionRankUpStagingView?          RankUpStagingView                       { get; set; }
        public SeasonMissionTab?                        RewardTab                               { get; set; }
        public SeasonMissionTab?                        MissionTab                              { get; set; }
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public FilterAndSortView?                       MissionFilterView                       { get; set; }
        public SeasonMissionViewModel?                  ViewModel                               { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static SeasonMissionView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SeasonMissionView() { Pointer= p0 };

            value.CloseButton                               = GetObject<ButtonBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.ButtonBase.FromPointer); // 02466BDAAEE0 0x20 CloseButton                 ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.UiTabGroup                                = GetObject<UITabGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITabGroup.FromPointer); // 02466BDAAF00 0x28 UiTabGroup                  ( 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.AllReceiveButton                          = GetObject<ButtonBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.ButtonBase.FromPointer); // 02466BDAAF20 0x30 AllReceiveButton            ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.AllReceivePositiveObject                  = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 02466BDAAF40 0x38 AllReceivePositiveObject    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.AllReceiveLockObject                      = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 02466BDAAF60 0x40 AllReceiveLockObject        ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.PremiumUnlockButton                       = GetObject<ButtonBase>(new IntPtr(p + 0x048), ReversePrism.DataModels.ButtonBase.FromPointer); // 02466BDAAF80 0x48 PremiumUnlockButton         ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.TermText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BDAAFA0 0x50 TermText                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TermTitleText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BDAAFC0 0x58 TermTitleText               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RankView                                  = GetObject<SeasonMissionRankView>(new IntPtr(p + 0x060), ReversePrism.DataModels.SeasonMissionRankView.FromPointer); // 02466BDAAFE0 0x60 RankView                    ( 000186705670 ModelClassType SeasonMissionRankView SeasonMissionRankView SeasonMissionRankView Pointer )
            value.RewardListView                            = GetObject<SeasonMissionRewardListView>(new IntPtr(p + 0x068), ReversePrism.DataModels.SeasonMissionRewardListView.FromPointer); // 02466BDAB000 0x68 RewardListView              ( 000186706920 ModelClassType SeasonMissionRewardListView SeasonMissionRewardListView SeasonMissionRewardListView Pointer )
            value.MissionListView                           = GetObject<SeasonMissionMissionListView>(new IntPtr(p + 0x070), ReversePrism.DataModels.SeasonMissionMissionListView.FromPointer); // 02466BDAB020 0x70 MissionListView             ( 000186702CC0 ModelClassType SeasonMissionMissionListView SeasonMissionMissionListView SeasonMissionMissionListView Pointer )
            value.SeasonEndAnimator                         = GetObject<Animator>(new IntPtr(p + 0x078), ReversePrism.DataModels.Animator.FromPointer); // 02466BDAB040 0x78 SeasonEndAnimator           ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.RankUpStagingView                         = GetObject<SeasonMissionRankUpStagingView>(new IntPtr(p + 0x080), ReversePrism.DataModels.SeasonMissionRankUpStagingView.FromPointer); // 02466BDAB060 0x80 RankUpStagingView           ( 000186705190 ModelClassType SeasonMissionRankUpStagingView SeasonMissionRankUpStagingView SeasonMissionRankUpStagingView Pointer )
            value.RewardTab                                 = GetObject<SeasonMissionTab>(new IntPtr(p + 0x088), ReversePrism.DataModels.SeasonMissionTab.FromPointer); // 02466BDAB080 0x88 RewardTab                   ( 000186708BC0 ModelClassType SeasonMissionTab SeasonMissionTab SeasonMissionTab Pointer )
            value.MissionTab                                = GetObject<SeasonMissionTab>(new IntPtr(p + 0x090), ReversePrism.DataModels.SeasonMissionTab.FromPointer); // 02466BDAB0A0 0x90 MissionTab                  ( 000186708BC0 ModelClassType SeasonMissionTab SeasonMissionTab SeasonMissionTab Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x098), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466BDAB0C0 0x98 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.MissionFilterView                         = GetObject<FilterAndSortView>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.FilterAndSortView.FromPointer); // 02466BDAB0E0 0xA0 MissionFilterView           ( 000186580020 ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer )
            value.ViewModel                                 = GetObject<SeasonMissionViewModel>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.SeasonMissionViewModel.FromPointer); // 02466BDAB140 0xB8 ViewModel                   ( 00018670A4A0 ModelClassType SeasonMissionViewModel SeasonMissionViewModel SeasonMissionViewModel Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.IDisposable.FromPointer); // 02466BDAB160 0xC0 BackKeyDisposable           ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 02466BDAB180 0xC8 Disposable                  ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.IResourceLoader.FromPointer); // 02466BDAB1A0 0xD0 ResourceLoader              ( 00018661A8D0 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
