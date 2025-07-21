using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TitleView                                ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 028 UnitidolView                             ModelClassType ScheduleSelectionUnitIdolView ScheduleSelectionUnitIdolView ScheduleSelectionUnitIdolView Pointer
    // 030 LeftBottomAreaView                       ModelClassType ScheduleSelectionLeftBottomAreaView ScheduleSelectionLeftBottomAreaView ScheduleSelectionLeftBottomAreaView Pointer
    // 038 LeftWeekView                             ModelClassType ScheduleSelectionLeftWeekView ScheduleSelectionLeftWeekView ScheduleSelectionLeftWeekView Pointer
    // 040 ScheduleCarouselView                     ModelClassType ScheduleSelectionScheduleCarouselView ScheduleSelectionScheduleCarouselView ScheduleSelectionScheduleCarouselView Pointer
    // 048 ScheduleDetailView                       ModelClassType ScheduleSelectionScheduleDetailView ScheduleSelectionScheduleDetailView ScheduleSelectionScheduleDetailView Pointer
    // 050 SubSeasonButton                          ModelClassType UIButton UIButton UIButton Pointer
    // 058 SubSeasonCheckOn                         ModelClassType GameObject GameObject GameObject Pointer
    // 060 SubSeasonCheckOff                        ModelClassType GameObject GameObject GameObject Pointer
    // 068 IngameTutorialButton                     ModelClassType UIButton UIButton UIButton Pointer
    // 070 HamburgerButton                          ModelClassType UIButton UIButton UIButton Pointer
    // 078 IngameTutorialButtonObject               ModelClassType GameObject GameObject GameObject Pointer
    // 080 HamburgerButtonObject                    ModelClassType GameObject GameObject GameObject Pointer
    // 088 BlackBackObject                          ModelClassType GameObject GameObject GameObject Pointer
    // 090 SafeAreaRoot                             ModelClassType RectTransform RectTransform RectTransform Pointer
    // 098 BgArea                                   ModelClassType RectTransform RectTransform RectTransform Pointer
    // 0A0 LeftArea                                 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 0A8 LeftArea2                                ModelClassType RectTransform RectTransform RectTransform Pointer
    // 0B0 RightCentralArea                         ModelClassType RectTransform RectTransform RectTransform Pointer
    // 0B8 RightTopUIArea                           ModelClassType RectTransform RectTransform RectTransform Pointer
    // 0C0 NormalBgObject                           ModelClassType GameObject GameObject GameObject Pointer
    // 0C8 NormalBgBaseImage                        ModelClassType UIImage UIImage UIImage Pointer
    // 0D0 NormalBgUnitLogoImage                    ModelClassType UIImage UIImage UIImage Pointer
    // 0D8 SubSeasonBgRawImage                      ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 0E0 TouchFrontPanelButton                    ModelClassType UIButton UIButton UIButton Pointer
    // 0E8 TouchFrontPanelImage                     ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 0F0 MiniCharacterActionObject                ModelClassType GameObject GameObject GameObject Pointer
    // 0F8 ScheduleInfoContent                      ModelClassType ScheduleInfoContent ScheduleInfoContent ScheduleInfoContent Pointer
    // 100 ParameterVariationContent                ModelClassType ParameterVariationContent ParameterVariationContent ParameterVariationContent Pointer
    // 108 MiniCharacterActionContent               ModelClassType MiniCharacterActionContent MiniCharacterActionContent MiniCharacterActionContent Pointer
    // 110 ScheduleLevelUpActionContent             ModelClassType ScheduleLevelUpContent ScheduleLevelUpContent ScheduleLevelUpContent Pointer
    // 118 ScheduleLevelUpActionObject              ModelClassType GameObject GameObject GameObject Pointer
    // 120 ExpansionParameterContentObject          ModelClassType GameObject GameObject GameObject Pointer
    // 128 ScheduleDisplayInActionObject            ModelClassType GameObject GameObject GameObject Pointer
    // 130 FanAreaObject                            ModelClassType GameObject GameObject GameObject Pointer
    // 138 LeftParamObject                          ModelClassType GameObject GameObject GameObject Pointer
    // 140 CommonTitleView                          ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 148 ExecuteScheduleVitalityGauge             ModelClassType ScheduleVitalityGauge ScheduleVitalityGauge ScheduleVitalityGauge Pointer
    // 150 LessonAuditionScene                      ModelPrimitiveType string string string String
    // 158 BlockArea                                ModelClassType RectTransform RectTransform RectTransform Pointer
    // 160 TutorialDataObject                       ModelClassType TutorialData TutorialData TutorialData Pointer
    // 168 ConfigRefKeys                            ModelPrimitiveListType string[] string[] List<string> Pointer
    // 170 SupportEffectDemonstrateUIContent        ModelClassType SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent Pointer
    // 178 ScheduleSelectTutorialSequences          ModelClassListType ITutorialSequence[] ITutorialSequence[] List<ITutorialSequence> Pointer
    // 180 HowToPlayManualKey                       ModelPrimitiveType string string string String
    // 188 AppearanceUIAnimator                     ModelClassType Animator Animator Animator Pointer
    // 190 AppearanceText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 198 HowToPlayProduceManualData               ModelClassType HowToPlayProduceManualData HowToPlayProduceManualData HowToPlayProduceManualData Pointer
    // 1A0 onClickHamburgerButton                   Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 1A8 onClickIngameTutorialButton              Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 1B0 onClickSubseasonButton                   Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 1B8 onRingVoiceActivate                      Action`1<bool> IL2CPP_TYPE_GENERICINST
    // 1C0 BackKeyDisposable                        ModelClassType IDisposable IDisposable IDisposable Pointer
    // 1C8 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    public partial class ScheduleSelectionView : DataModel
    {
        public CommonTitleView?                         TitleView                               { get; set; }
        public ScheduleSelectionUnitIdolView?           UnitidolView                            { get; set; }
        public ScheduleSelectionLeftBottomAreaView?     LeftBottomAreaView                      { get; set; }
        public ScheduleSelectionLeftWeekView?           LeftWeekView                            { get; set; }
        public ScheduleSelectionScheduleCarouselView?   ScheduleCarouselView                    { get; set; }
        public ScheduleSelectionScheduleDetailView?     ScheduleDetailView                      { get; set; }
        public UIButton?                                SubSeasonButton                         { get; set; }
        public GameObject?                              SubSeasonCheckOn                        { get; set; }
        public GameObject?                              SubSeasonCheckOff                       { get; set; }
        public UIButton?                                IngameTutorialButton                    { get; set; }
        public UIButton?                                HamburgerButton                         { get; set; }
        public GameObject?                              IngameTutorialButtonObject              { get; set; }
        public GameObject?                              HamburgerButtonObject                   { get; set; }
        public GameObject?                              BlackBackObject                         { get; set; }
        public RectTransform?                           SafeAreaRoot                            { get; set; }
        public RectTransform?                           BgArea                                  { get; set; }
        public RectTransform?                           LeftArea                                { get; set; }
        public RectTransform?                           LeftArea2                               { get; set; }
        public RectTransform?                           RightCentralArea                        { get; set; }
        public RectTransform?                           RightTopUIArea                          { get; set; }
        public GameObject?                              NormalBgObject                          { get; set; }
        public UIImage?                                 NormalBgBaseImage                       { get; set; }
        public UIImage?                                 NormalBgUnitLogoImage                   { get; set; }
        public UIRawImage?                              SubSeasonBgRawImage                     { get; set; }
        public UIButton?                                TouchFrontPanelButton                   { get; set; }
        public UIRawImage?                              TouchFrontPanelImage                    { get; set; }
        public GameObject?                              MiniCharacterActionObject               { get; set; }
        public ScheduleInfoContent?                     ScheduleInfoContent                     { get; set; }
        public ParameterVariationContent?               ParameterVariationContent               { get; set; }
        public MiniCharacterActionContent?              MiniCharacterActionContent              { get; set; }
        public ScheduleLevelUpContent?                  ScheduleLevelUpActionContent            { get; set; }
        public GameObject?                              ScheduleLevelUpActionObject             { get; set; }
        public GameObject?                              ExpansionParameterContentObject         { get; set; }
        public GameObject?                              ScheduleDisplayInActionObject           { get; set; }
        public GameObject?                              FanAreaObject                           { get; set; }
        public GameObject?                              LeftParamObject                         { get; set; }
        public CommonTitleView?                         CommonTitleView                         { get; set; }
        public ScheduleVitalityGauge?                   ExecuteScheduleVitalityGauge            { get; set; }
        public string                                   LessonAuditionScene                     { get; set; }
        public RectTransform?                           BlockArea                               { get; set; }
        public TutorialData?                            TutorialDataObject                      { get; set; }
        public List<string>?                            ConfigRefKeys                           { get; set; }
        public SupportEffectDemonstrateUIContent?       SupportEffectDemonstrateUIContent       { get; set; }
        public List<ITutorialSequence>?                 ScheduleSelectTutorialSequences         { get; set; }
        public string                                   HowToPlayManualKey                      { get; set; }
        public Animator?                                AppearanceUIAnimator                    { get; set; }
        public UITextMeshProUGUI?                       AppearanceText                          { get; set; }
        public HowToPlayProduceManualData?              HowToPlayProduceManualData              { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static ScheduleSelectionView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleSelectionView() { Pointer= p0 };

            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x020), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0x20 TitleView                   ( ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.UnitidolView                              = GetObject<ScheduleSelectionUnitIdolView>(new IntPtr(p + 0x028), ReversePrism.DataModels.ScheduleSelectionUnitIdolView.FromPointer); // 0x28 UnitidolView                ( ModelClassType ScheduleSelectionUnitIdolView ScheduleSelectionUnitIdolView ScheduleSelectionUnitIdolView Pointer )
            value.LeftBottomAreaView                        = GetObject<ScheduleSelectionLeftBottomAreaView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ScheduleSelectionLeftBottomAreaView.FromPointer); // 0x30 LeftBottomAreaView          ( ModelClassType ScheduleSelectionLeftBottomAreaView ScheduleSelectionLeftBottomAreaView ScheduleSelectionLeftBottomAreaView Pointer )
            value.LeftWeekView                              = GetObject<ScheduleSelectionLeftWeekView>(new IntPtr(p + 0x038), ReversePrism.DataModels.ScheduleSelectionLeftWeekView.FromPointer); // 0x38 LeftWeekView                ( ModelClassType ScheduleSelectionLeftWeekView ScheduleSelectionLeftWeekView ScheduleSelectionLeftWeekView Pointer )
            value.ScheduleCarouselView                      = GetObject<ScheduleSelectionScheduleCarouselView>(new IntPtr(p + 0x040), ReversePrism.DataModels.ScheduleSelectionScheduleCarouselView.FromPointer); // 0x40 ScheduleCarouselView        ( ModelClassType ScheduleSelectionScheduleCarouselView ScheduleSelectionScheduleCarouselView ScheduleSelectionScheduleCarouselView Pointer )
            value.ScheduleDetailView                        = GetObject<ScheduleSelectionScheduleDetailView>(new IntPtr(p + 0x048), ReversePrism.DataModels.ScheduleSelectionScheduleDetailView.FromPointer); // 0x48 ScheduleDetailView          ( ModelClassType ScheduleSelectionScheduleDetailView ScheduleSelectionScheduleDetailView ScheduleSelectionScheduleDetailView Pointer )
            value.SubSeasonButton                           = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0x50 SubSeasonButton             ( ModelClassType UIButton UIButton UIButton Pointer )
            value.SubSeasonCheckOn                          = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 SubSeasonCheckOn            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SubSeasonCheckOff                         = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0x60 SubSeasonCheckOff           ( ModelClassType GameObject GameObject GameObject Pointer )
            value.IngameTutorialButton                      = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 0x68 IngameTutorialButton        ( ModelClassType UIButton UIButton UIButton Pointer )
            value.HamburgerButton                           = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 0x70 HamburgerButton             ( ModelClassType UIButton UIButton UIButton Pointer )
            value.IngameTutorialButtonObject                = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0x78 IngameTutorialButtonObject  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.HamburgerButtonObject                     = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 0x80 HamburgerButtonObject       ( ModelClassType GameObject GameObject GameObject Pointer )
            value.BlackBackObject                           = GetObject<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 0x88 BlackBackObject             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SafeAreaRoot                              = GetObject<RectTransform>(new IntPtr(p + 0x090), ReversePrism.DataModels.RectTransform.FromPointer); // 0x90 SafeAreaRoot                ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.BgArea                                    = GetObject<RectTransform>(new IntPtr(p + 0x098), ReversePrism.DataModels.RectTransform.FromPointer); // 0x98 BgArea                      ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.LeftArea                                  = GetObject<RectTransform>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.RectTransform.FromPointer); // 0xA0 LeftArea                    ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.LeftArea2                                 = GetObject<RectTransform>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.RectTransform.FromPointer); // 0xA8 LeftArea2                   ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.RightCentralArea                          = GetObject<RectTransform>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.RectTransform.FromPointer); // 0xB0 RightCentralArea            ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.RightTopUIArea                            = GetObject<RectTransform>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.RectTransform.FromPointer); // 0xB8 RightTopUIArea              ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.NormalBgObject                            = GetObject<GameObject>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.GameObject.FromPointer); // 0xC0 NormalBgObject              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.NormalBgBaseImage                         = GetObject<UIImage>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.UIImage.FromPointer); // 0xC8 NormalBgBaseImage           ( ModelClassType UIImage UIImage UIImage Pointer )
            value.NormalBgUnitLogoImage                     = GetObject<UIImage>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.UIImage.FromPointer); // 0xD0 NormalBgUnitLogoImage       ( ModelClassType UIImage UIImage UIImage Pointer )
            value.SubSeasonBgRawImage                       = GetObject<UIRawImage>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.UIRawImage.FromPointer); // 0xD8 SubSeasonBgRawImage         ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.TouchFrontPanelButton                     = GetObject<UIButton>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.UIButton.FromPointer); // 0xE0 TouchFrontPanelButton       ( ModelClassType UIButton UIButton UIButton Pointer )
            value.TouchFrontPanelImage                      = GetObject<UIRawImage>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.UIRawImage.FromPointer); // 0xE8 TouchFrontPanelImage        ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.MiniCharacterActionObject                 = GetObject<GameObject>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.GameObject.FromPointer); // 0xF0 MiniCharacterActionObject   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ScheduleInfoContent                       = GetObject<ScheduleInfoContent>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.ScheduleInfoContent.FromPointer); // 0xF8 ScheduleInfoContent         ( ModelClassType ScheduleInfoContent ScheduleInfoContent ScheduleInfoContent Pointer )
            value.ParameterVariationContent                 = GetObject<ParameterVariationContent>(new IntPtr(p + 0x100), ReversePrism.DataModels.ParameterVariationContent.FromPointer); // 0x100 ParameterVariationContent   ( ModelClassType ParameterVariationContent ParameterVariationContent ParameterVariationContent Pointer )
            value.MiniCharacterActionContent                = GetObject<MiniCharacterActionContent>(new IntPtr(p + 0x108), ReversePrism.DataModels.MiniCharacterActionContent.FromPointer); // 0x108 MiniCharacterActionContent  ( ModelClassType MiniCharacterActionContent MiniCharacterActionContent MiniCharacterActionContent Pointer )
            value.ScheduleLevelUpActionContent              = GetObject<ScheduleLevelUpContent>(new IntPtr(p + 0x110), ReversePrism.DataModels.ScheduleLevelUpContent.FromPointer); // 0x110 ScheduleLevelUpActionContent ( ModelClassType ScheduleLevelUpContent ScheduleLevelUpContent ScheduleLevelUpContent Pointer )
            value.ScheduleLevelUpActionObject               = GetObject<GameObject>(new IntPtr(p + 0x118), ReversePrism.DataModels.GameObject.FromPointer); // 0x118 ScheduleLevelUpActionObject ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ExpansionParameterContentObject           = GetObject<GameObject>(new IntPtr(p + 0x120), ReversePrism.DataModels.GameObject.FromPointer); // 0x120 ExpansionParameterContentObject ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ScheduleDisplayInActionObject             = GetObject<GameObject>(new IntPtr(p + 0x128), ReversePrism.DataModels.GameObject.FromPointer); // 0x128 ScheduleDisplayInActionObject ( ModelClassType GameObject GameObject GameObject Pointer )
            value.FanAreaObject                             = GetObject<GameObject>(new IntPtr(p + 0x130), ReversePrism.DataModels.GameObject.FromPointer); // 0x130 FanAreaObject               ( ModelClassType GameObject GameObject GameObject Pointer )
            value.LeftParamObject                           = GetObject<GameObject>(new IntPtr(p + 0x138), ReversePrism.DataModels.GameObject.FromPointer); // 0x138 LeftParamObject             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CommonTitleView                           = GetObject<CommonTitleView>(new IntPtr(p + 0x140), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0x140 CommonTitleView             ( ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.ExecuteScheduleVitalityGauge              = GetObject<ScheduleVitalityGauge>(new IntPtr(p + 0x148), ReversePrism.DataModels.ScheduleVitalityGauge.FromPointer); // 0x148 ExecuteScheduleVitalityGauge ( ModelClassType ScheduleVitalityGauge ScheduleVitalityGauge ScheduleVitalityGauge Pointer )
            value.LessonAuditionScene                       = GetString(new IntPtr(p + 0x150)); // 0x150 LessonAuditionScene         ( ModelPrimitiveType string string string String )
            value.BlockArea                                 = GetObject<RectTransform>(new IntPtr(p + 0x158), ReversePrism.DataModels.RectTransform.FromPointer); // 0x158 BlockArea                   ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.TutorialDataObject                        = GetObject<TutorialData>(new IntPtr(p + 0x160), ReversePrism.DataModels.TutorialData.FromPointer); // 0x160 TutorialDataObject          ( ModelClassType TutorialData TutorialData TutorialData Pointer )
            value.ConfigRefKeys                             = GetStringList(new IntPtr(p + 0x168)); // 0x168 ConfigRefKeys               ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.SupportEffectDemonstrateUIContent         = GetObject<SupportEffectDemonstrateUIContent>(new IntPtr(p + 0x170), ReversePrism.DataModels.SupportEffectDemonstrateUIContent.FromPointer); // 0x170 SupportEffectDemonstrateUIContent ( ModelClassType SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent Pointer )
            value.ScheduleSelectTutorialSequences           = GetObjectList<ITutorialSequence>(new IntPtr(p + 0x178), ReversePrism.DataModels.ITutorialSequence.FromPointer); // 0x178 ScheduleSelectTutorialSequences ( ModelClassListType ITutorialSequence[] ITutorialSequence[] List<ITutorialSequence> Pointer )
            value.HowToPlayManualKey                        = GetString(new IntPtr(p + 0x180)); // 0x180 HowToPlayManualKey          ( ModelPrimitiveType string string string String )
            value.AppearanceUIAnimator                      = GetObject<Animator>(new IntPtr(p + 0x188), ReversePrism.DataModels.Animator.FromPointer); // 0x188 AppearanceUIAnimator        ( ModelClassType Animator Animator Animator Pointer )
            value.AppearanceText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x190), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x190 AppearanceText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.HowToPlayProduceManualData                = GetObject<HowToPlayProduceManualData>(new IntPtr(p + 0x198), ReversePrism.DataModels.HowToPlayProduceManualData.FromPointer); // 0x198 HowToPlayProduceManualData  ( ModelClassType HowToPlayProduceManualData HowToPlayProduceManualData HowToPlayProduceManualData Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x1C0), ReversePrism.DataModels.IDisposable.FromPointer); // 0x1C0 BackKeyDisposable           ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x1C8), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x1C8 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
