using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CloseButton                              ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 028 UiTabGroup                               ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 030 AllReceiveButton                         ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 038 AllReceivePositiveObject                 ModelClassType GameObject GameObject GameObject Pointer
    // 040 AllReceiveLockObject                     ModelClassType GameObject GameObject GameObject Pointer
    // 048 PremiumUnlockButton                      ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 050 TermText                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 TermTitleText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 RankView                                 ModelClassType SeasonMissionRankView SeasonMissionRankView SeasonMissionRankView Pointer
    // 068 RewardListView                           ModelClassType SeasonMissionRewardListView SeasonMissionRewardListView SeasonMissionRewardListView Pointer
    // 070 MissionListView                          ModelClassType SeasonMissionMissionListView SeasonMissionMissionListView SeasonMissionMissionListView Pointer
    // 078 SeasonEndAnimator                        ModelClassType Animator Animator Animator Pointer
    // 080 RankUpStagingView                        ModelClassType SeasonMissionRankUpStagingView SeasonMissionRankUpStagingView SeasonMissionRankUpStagingView Pointer
    // 088 RewardTab                                ModelClassType SeasonMissionTab SeasonMissionTab SeasonMissionTab Pointer
    // 090 MissionTab                               ModelClassType SeasonMissionTab SeasonMissionTab SeasonMissionTab Pointer
    // 098 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0A0 MissionFilterView                        ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer
    // 0A8 ViewModel                                ModelClassType SeasonMissionViewModel SeasonMissionViewModel SeasonMissionViewModel Pointer
    // 0B0 BackKeyDisposable                        ModelClassType IDisposable IDisposable IDisposable Pointer
    // 0B8 Disposable                               ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 0C0 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
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

            value.CloseButton                               = GetObject<ButtonBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x20 CloseButton                 ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.UiTabGroup                                = GetObject<UITabGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITabGroup.FromPointer); // 0x28 UiTabGroup                  ( ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.AllReceiveButton                          = GetObject<ButtonBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x30 AllReceiveButton            ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.AllReceivePositiveObject                  = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 AllReceivePositiveObject    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.AllReceiveLockObject                      = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 AllReceiveLockObject        ( ModelClassType GameObject GameObject GameObject Pointer )
            value.PremiumUnlockButton                       = GetObject<ButtonBase>(new IntPtr(p + 0x048), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x48 PremiumUnlockButton         ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.TermText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 TermText                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TermTitleText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 TermTitleText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RankView                                  = GetObject<SeasonMissionRankView>(new IntPtr(p + 0x060), ReversePrism.DataModels.SeasonMissionRankView.FromPointer); // 0x60 RankView                    ( ModelClassType SeasonMissionRankView SeasonMissionRankView SeasonMissionRankView Pointer )
            value.RewardListView                            = GetObject<SeasonMissionRewardListView>(new IntPtr(p + 0x068), ReversePrism.DataModels.SeasonMissionRewardListView.FromPointer); // 0x68 RewardListView              ( ModelClassType SeasonMissionRewardListView SeasonMissionRewardListView SeasonMissionRewardListView Pointer )
            value.MissionListView                           = GetObject<SeasonMissionMissionListView>(new IntPtr(p + 0x070), ReversePrism.DataModels.SeasonMissionMissionListView.FromPointer); // 0x70 MissionListView             ( ModelClassType SeasonMissionMissionListView SeasonMissionMissionListView SeasonMissionMissionListView Pointer )
            value.SeasonEndAnimator                         = GetObject<Animator>(new IntPtr(p + 0x078), ReversePrism.DataModels.Animator.FromPointer); // 0x78 SeasonEndAnimator           ( ModelClassType Animator Animator Animator Pointer )
            value.RankUpStagingView                         = GetObject<SeasonMissionRankUpStagingView>(new IntPtr(p + 0x080), ReversePrism.DataModels.SeasonMissionRankUpStagingView.FromPointer); // 0x80 RankUpStagingView           ( ModelClassType SeasonMissionRankUpStagingView SeasonMissionRankUpStagingView SeasonMissionRankUpStagingView Pointer )
            value.RewardTab                                 = GetObject<SeasonMissionTab>(new IntPtr(p + 0x088), ReversePrism.DataModels.SeasonMissionTab.FromPointer); // 0x88 RewardTab                   ( ModelClassType SeasonMissionTab SeasonMissionTab SeasonMissionTab Pointer )
            value.MissionTab                                = GetObject<SeasonMissionTab>(new IntPtr(p + 0x090), ReversePrism.DataModels.SeasonMissionTab.FromPointer); // 0x90 MissionTab                  ( ModelClassType SeasonMissionTab SeasonMissionTab SeasonMissionTab Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x098), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x98 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.MissionFilterView                         = GetObject<FilterAndSortView>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.FilterAndSortView.FromPointer); // 0xA0 MissionFilterView           ( ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer )
            value.ViewModel                                 = GetObject<SeasonMissionViewModel>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.SeasonMissionViewModel.FromPointer); // 0xA8 ViewModel                   ( ModelClassType SeasonMissionViewModel SeasonMissionViewModel SeasonMissionViewModel Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.IDisposable.FromPointer); // 0xB0 BackKeyDisposable           ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0xB8 Disposable                  ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0xC0 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
