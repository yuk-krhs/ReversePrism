using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 078 View                                     ModelClassType ViewProducePreparationEpisodeSelectView ViewProducePreparationEpisodeSelectView ViewProducePreparationEpisodeSelectView Pointer
    // 080 DifficultyReleasedConfigRef              ModelPrimitiveType string string string String
    // 088 DefaultBannerGroupViewReference          ModelClassType EpisodeSelectViewBannerGroupReferenceForLegacy EpisodeSelectViewBannerGroupReferenceForLegacy EpisodeSelectViewBannerGroupReferenceForLegacy Pointer
    // 090 ProducePromotionBannerViewReference      ModelClassType EpisodeSelectViewBannerGroupReferenceForLegacy EpisodeSelectViewBannerGroupReferenceForLegacy EpisodeSelectViewBannerGroupReferenceForLegacy Pointer
    // 098 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 0A0 Ct                                       ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 0A8 Model                                    ModelClassType ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel Pointer
    // 0B0 IsInitilizing                            ModelPrimitiveType bool bool bool Bool
    // 0B8 TutorialInfoSequence                     ModelClassType ITutorialSequence ITutorialSequence ITutorialSequence Pointer
    // 0C0 EndTutorialCaller                        ModelClassType EndTutorialConfirmPopupViewCaller EndTutorialConfirmPopupViewCaller EndTutorialConfirmPopupViewCaller Pointer
    // 0C8 PromotionPopupCaller                     ModelClassType ProducePromotionPopupCaller ProducePromotionPopupCaller ProducePromotionPopupCaller Pointer
    // 0D0 MissionOverlayCaller                     ModelClassType MissionOverlayCaller MissionOverlayCaller MissionOverlayCaller Pointer
    // 0D8 JumpToChallengeTourConfingRef            ModelPrimitiveType string string string String
    public partial class ViewProducePreparationEpisodeSelectPresenter : DataModel
    {
        public ViewProducePreparationEpisodeSelectView? View                                    { get; set; }
        public string                                   DifficultyReleasedConfigRef             { get; set; }
        public EpisodeSelectViewBannerGroupReferenceForLegacy? DefaultBannerGroupViewReference         { get; set; }
        public EpisodeSelectViewBannerGroupReferenceForLegacy? ProducePromotionBannerViewReference     { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public CancellationToken                        Ct                                      { get; set; }
        public ViewProducePreparationEpisodeSelectModel? Model                                   { get; set; }
        public bool                                     IsInitilizing                           { get; set; }
        public ITutorialSequence?                       TutorialInfoSequence                    { get; set; }
        public EndTutorialConfirmPopupViewCaller?       EndTutorialCaller                       { get; set; }
        public ProducePromotionPopupCaller?             PromotionPopupCaller                    { get; set; }
        public MissionOverlayCaller?                    MissionOverlayCaller                    { get; set; }
        public string                                   JumpToChallengeTourConfingRef           { get; set; }

        public static ViewProducePreparationEpisodeSelectPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ViewProducePreparationEpisodeSelectPresenter() { Pointer= p0 };

            value.View                                      = GetObject<ViewProducePreparationEpisodeSelectView>(new IntPtr(p + 0x078), ReversePrism.DataModels.ViewProducePreparationEpisodeSelectView.FromPointer); // 0x78 View                        ( ModelClassType ViewProducePreparationEpisodeSelectView ViewProducePreparationEpisodeSelectView ViewProducePreparationEpisodeSelectView Pointer )
            value.DifficultyReleasedConfigRef               = GetString(new IntPtr(p + 0x080)); // 0x80 DifficultyReleasedConfigRef ( ModelPrimitiveType string string string String )
            value.DefaultBannerGroupViewReference           = GetObject<EpisodeSelectViewBannerGroupReferenceForLegacy>(new IntPtr(p + 0x088), ReversePrism.DataModels.EpisodeSelectViewBannerGroupReferenceForLegacy.FromPointer); // 0x88 DefaultBannerGroupViewReference ( ModelClassType EpisodeSelectViewBannerGroupReferenceForLegacy EpisodeSelectViewBannerGroupReferenceForLegacy EpisodeSelectViewBannerGroupReferenceForLegacy Pointer )
            value.ProducePromotionBannerViewReference       = GetObject<EpisodeSelectViewBannerGroupReferenceForLegacy>(new IntPtr(p + 0x090), ReversePrism.DataModels.EpisodeSelectViewBannerGroupReferenceForLegacy.FromPointer); // 0x90 ProducePromotionBannerViewReference ( ModelClassType EpisodeSelectViewBannerGroupReferenceForLegacy EpisodeSelectViewBannerGroupReferenceForLegacy EpisodeSelectViewBannerGroupReferenceForLegacy Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x098), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x98 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Ct                                        = (CancellationToken)GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 Ct                          ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.Model                                     = GetObject<ViewProducePreparationEpisodeSelectModel>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.ViewProducePreparationEpisodeSelectModel.FromPointer); // 0xA8 Model                       ( ModelClassType ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel Pointer )
            value.IsInitilizing                             = GetBool(new IntPtr(p + 0x0B0)); // 0xB0 IsInitilizing               ( ModelPrimitiveType bool bool bool Bool )
            value.TutorialInfoSequence                      = GetObject<ITutorialSequence>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.ITutorialSequence.FromPointer); // 0xB8 TutorialInfoSequence        ( ModelClassType ITutorialSequence ITutorialSequence ITutorialSequence Pointer )
            value.EndTutorialCaller                         = GetObject<EndTutorialConfirmPopupViewCaller>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.EndTutorialConfirmPopupViewCaller.FromPointer); // 0xC0 EndTutorialCaller           ( ModelClassType EndTutorialConfirmPopupViewCaller EndTutorialConfirmPopupViewCaller EndTutorialConfirmPopupViewCaller Pointer )
            value.PromotionPopupCaller                      = GetObject<ProducePromotionPopupCaller>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.ProducePromotionPopupCaller.FromPointer); // 0xC8 PromotionPopupCaller        ( ModelClassType ProducePromotionPopupCaller ProducePromotionPopupCaller ProducePromotionPopupCaller Pointer )
            value.MissionOverlayCaller                      = GetObject<MissionOverlayCaller>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.MissionOverlayCaller.FromPointer); // 0xD0 MissionOverlayCaller        ( ModelClassType MissionOverlayCaller MissionOverlayCaller MissionOverlayCaller Pointer )
            value.JumpToChallengeTourConfingRef             = GetString(new IntPtr(p + 0x0D8)); // 0xD8 JumpToChallengeTourConfingRef ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
