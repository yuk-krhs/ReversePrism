using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TitleView                                0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 028 UnitidolView                             0001866E1440 ModelClassType ScheduleSelectionUnitIdolView ScheduleSelectionUnitIdolView ScheduleSelectionUnitIdolView Pointer
    // 030 LeftBottomAreaView                       0001866D9DA0 ModelClassType ScheduleSelectionLeftBottomAreaView ScheduleSelectionLeftBottomAreaView ScheduleSelectionLeftBottomAreaView Pointer
    // 038 LeftWeekView                             0001866DB0C0 ModelClassType ScheduleSelectionLeftWeekView ScheduleSelectionLeftWeekView ScheduleSelectionLeftWeekView Pointer
    // 040 ScheduleCarouselView                     0001866DE380 ModelClassType ScheduleSelectionScheduleCarouselView ScheduleSelectionScheduleCarouselView ScheduleSelectionScheduleCarouselView Pointer
    // 048 ScheduleDetailView                       0001866DF220 ModelClassType ScheduleSelectionScheduleDetailView ScheduleSelectionScheduleDetailView ScheduleSelectionScheduleDetailView Pointer
    // 050 SubSeasonButton                          0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 058 SubSeasonCheckOn                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 060 SubSeasonCheckOff                        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 068 IngameTutorialButton                     0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 070 HamburgerButton                          0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 078 IngameTutorialButtonObject               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 080 HamburgerButtonObject                    0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 088 BlackBackObject                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 090 SafeAreaRoot                             000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 098 BgArea                                   000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 0A0 LeftArea                                 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 0A8 LeftArea2                                000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 0B0 RightCentralArea                         000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 0B8 RightTopUIArea                           000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 0C0 NormalBgObject                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0C8 NormalBgBaseImage                        0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 0D0 NormalBgUnitLogoImage                    0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 0D8 SubSeasonBgRawImage                      0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 0E0 VitalityGauge                            00018652E260 ModelClassType VitalityGauge VitalityGauge VitalityGauge Pointer
    // 0E8 TouchFrontPanelButton                    0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 0F0 TouchFrontPanelImage                     0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 0F8 MiniCharacterActionObject                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 100 ScheduleInfoContent                      0001866D4B10 ModelClassType ScheduleInfoContent ScheduleInfoContent ScheduleInfoContent Pointer
    // 108 ParameterVariationContent                00018671D4D0 ModelClassType ParameterVariationContent ParameterVariationContent ParameterVariationContent Pointer
    // 110 MiniCharacterActionContent               00018661B490 ModelClassType MiniCharacterActionContent MiniCharacterActionContent MiniCharacterActionContent Pointer
    // 118 ScheduleLevelUpActionContent             0001866D5270 ModelClassType ScheduleLevelUpContent ScheduleLevelUpContent ScheduleLevelUpContent Pointer
    // 120 ScheduleLevelUpActionObject              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 128 ExpansionParameterContentObject          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 130 ScheduleDisplayInActionObject            0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 138 FanAreaObject                            0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 140 LeftParamObject                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 148 CommonTitleView                          0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 150 ExecuteScheduleVitalityGauge             0001866E5120 ModelClassType ScheduleVitalityGauge ScheduleVitalityGauge ScheduleVitalityGauge Pointer
    // 158 LessonAuditionScene                      000186671910 ModelPrimitiveType string string string String
    // 160 BlockArea                                000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 168 TutorialDataObject                       0001866B91B0 ModelClassType TutorialData TutorialData TutorialData Pointer
    // 170 ConfigRefKeys                            000185B817C0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 178 SupportEffectDemonstrateUIContent        0001865F0A00 ModelClassType SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent Pointer
    // 180 ProduceTopMenuPopupViewFactory           00018658BBF0 ModelClassType ProduceTopMenuPopupViewFactory ProduceTopMenuPopupViewFactory ProduceTopMenuPopupViewFactory Pointer
    // 188 ScheduleSelectTutorialSequences          000185B8A160 ModelClassListType ITutorialSequence[] ITutorialSequence[] List<ITutorialSequence> Pointer
    // 190 HowToPlayManualKey                       000186671910 ModelPrimitiveType string string string String
    // 198 HowToPlayProduceManualData               0001866DA470 ModelClassType HowToPlayProduceManualData HowToPlayProduceManualData HowToPlayProduceManualData Pointer
    // 1A0 onClickHamburgerButton                   Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 1A8 onClickIngameTutorialButton              Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 1B0 onClickSubseasonButton                   Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 1B8 onRingVoiceActivate                      Action`1<bool> IL2CPP_TYPE_GENERICINST
    // 1C0 BackKeyDisposable                        0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class ScheduleSelectionView
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
        public VitalityGauge?                           VitalityGauge                           { get; set; }
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
        public ProduceTopMenuPopupViewFactory?          ProduceTopMenuPopupViewFactory          { get; set; }
        public List<ITutorialSequence>?                 ScheduleSelectTutorialSequences         { get; set; }
        public string                                   HowToPlayManualKey                      { get; set; }
        public HowToPlayProduceManualData?              HowToPlayProduceManualData              { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }

        public static ScheduleSelectionView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleSelectionView();

            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x020), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0270DA17CB98 0x20 TitleView                   ( 0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.UnitidolView                              = GetObject<ScheduleSelectionUnitIdolView>(new IntPtr(p + 0x028), ReversePrism.DataModels.ScheduleSelectionUnitIdolView.FromPointer); // 0270DA17CBB8 0x28 UnitidolView                ( 0001866E1440 ModelClassType ScheduleSelectionUnitIdolView ScheduleSelectionUnitIdolView ScheduleSelectionUnitIdolView Pointer )
            value.LeftBottomAreaView                        = GetObject<ScheduleSelectionLeftBottomAreaView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ScheduleSelectionLeftBottomAreaView.FromPointer); // 0270DA17CBD8 0x30 LeftBottomAreaView          ( 0001866D9DA0 ModelClassType ScheduleSelectionLeftBottomAreaView ScheduleSelectionLeftBottomAreaView ScheduleSelectionLeftBottomAreaView Pointer )
            value.LeftWeekView                              = GetObject<ScheduleSelectionLeftWeekView>(new IntPtr(p + 0x038), ReversePrism.DataModels.ScheduleSelectionLeftWeekView.FromPointer); // 0270DA17CBF8 0x38 LeftWeekView                ( 0001866DB0C0 ModelClassType ScheduleSelectionLeftWeekView ScheduleSelectionLeftWeekView ScheduleSelectionLeftWeekView Pointer )
            value.ScheduleCarouselView                      = GetObject<ScheduleSelectionScheduleCarouselView>(new IntPtr(p + 0x040), ReversePrism.DataModels.ScheduleSelectionScheduleCarouselView.FromPointer); // 0270DA17CC18 0x40 ScheduleCarouselView        ( 0001866DE380 ModelClassType ScheduleSelectionScheduleCarouselView ScheduleSelectionScheduleCarouselView ScheduleSelectionScheduleCarouselView Pointer )
            value.ScheduleDetailView                        = GetObject<ScheduleSelectionScheduleDetailView>(new IntPtr(p + 0x048), ReversePrism.DataModels.ScheduleSelectionScheduleDetailView.FromPointer); // 0270DA17CC38 0x48 ScheduleDetailView          ( 0001866DF220 ModelClassType ScheduleSelectionScheduleDetailView ScheduleSelectionScheduleDetailView ScheduleSelectionScheduleDetailView Pointer )
            value.SubSeasonButton                           = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA17CC58 0x50 SubSeasonButton             ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.SubSeasonCheckOn                          = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA17CC78 0x58 SubSeasonCheckOn            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SubSeasonCheckOff                         = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA17CC98 0x60 SubSeasonCheckOff           ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.IngameTutorialButton                      = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA17CCB8 0x68 IngameTutorialButton        ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.HamburgerButton                           = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA17CCD8 0x70 HamburgerButton             ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.IngameTutorialButtonObject                = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA17CCF8 0x78 IngameTutorialButtonObject  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.HamburgerButtonObject                     = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA17CD18 0x80 HamburgerButtonObject       ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.BlackBackObject                           = GetObject<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA17CD38 0x88 BlackBackObject             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SafeAreaRoot                              = GetObject<RectTransform>(new IntPtr(p + 0x090), ReversePrism.DataModels.RectTransform.FromPointer); // 0270DA17CD58 0x90 SafeAreaRoot                ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.BgArea                                    = GetObject<RectTransform>(new IntPtr(p + 0x098), ReversePrism.DataModels.RectTransform.FromPointer); // 0270DA17CD78 0x98 BgArea                      ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.LeftArea                                  = GetObject<RectTransform>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.RectTransform.FromPointer); // 0270DA17CD98 0xA0 LeftArea                    ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.LeftArea2                                 = GetObject<RectTransform>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.RectTransform.FromPointer); // 0270DA17CDB8 0xA8 LeftArea2                   ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.RightCentralArea                          = GetObject<RectTransform>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.RectTransform.FromPointer); // 0270DA17CDD8 0xB0 RightCentralArea            ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.RightTopUIArea                            = GetObject<RectTransform>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.RectTransform.FromPointer); // 0270DA17CDF8 0xB8 RightTopUIArea              ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.NormalBgObject                            = GetObject<GameObject>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA17CE18 0xC0 NormalBgObject              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.NormalBgBaseImage                         = GetObject<UIImage>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.UIImage.FromPointer); // 0270DA17CE38 0xC8 NormalBgBaseImage           ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.NormalBgUnitLogoImage                     = GetObject<UIImage>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.UIImage.FromPointer); // 0270DA17CE58 0xD0 NormalBgUnitLogoImage       ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.SubSeasonBgRawImage                       = GetObject<UIRawImage>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.UIRawImage.FromPointer); // 0270DA17CE78 0xD8 SubSeasonBgRawImage         ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.VitalityGauge                             = GetObject<VitalityGauge>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.VitalityGauge.FromPointer); // 0270DA17CE98 0xE0 VitalityGauge               ( 00018652E260 ModelClassType VitalityGauge VitalityGauge VitalityGauge Pointer )
            value.TouchFrontPanelButton                     = GetObject<UIButton>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA17CEB8 0xE8 TouchFrontPanelButton       ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.TouchFrontPanelImage                      = GetObject<UIRawImage>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.UIRawImage.FromPointer); // 0270DA17CED8 0xF0 TouchFrontPanelImage        ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.MiniCharacterActionObject                 = GetObject<GameObject>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA17CEF8 0xF8 MiniCharacterActionObject   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ScheduleInfoContent                       = GetObject<ScheduleInfoContent>(new IntPtr(p + 0x100), ReversePrism.DataModels.ScheduleInfoContent.FromPointer); // 0270DA17CF18 0x100 ScheduleInfoContent         ( 0001866D4B10 ModelClassType ScheduleInfoContent ScheduleInfoContent ScheduleInfoContent Pointer )
            value.ParameterVariationContent                 = GetObject<ParameterVariationContent>(new IntPtr(p + 0x108), ReversePrism.DataModels.ParameterVariationContent.FromPointer); // 0270DA17CF38 0x108 ParameterVariationContent   ( 00018671D4D0 ModelClassType ParameterVariationContent ParameterVariationContent ParameterVariationContent Pointer )
            value.MiniCharacterActionContent                = GetObject<MiniCharacterActionContent>(new IntPtr(p + 0x110), ReversePrism.DataModels.MiniCharacterActionContent.FromPointer); // 0270DA17CF58 0x110 MiniCharacterActionContent  ( 00018661B490 ModelClassType MiniCharacterActionContent MiniCharacterActionContent MiniCharacterActionContent Pointer )
            value.ScheduleLevelUpActionContent              = GetObject<ScheduleLevelUpContent>(new IntPtr(p + 0x118), ReversePrism.DataModels.ScheduleLevelUpContent.FromPointer); // 0270DA17CF78 0x118 ScheduleLevelUpActionContent ( 0001866D5270 ModelClassType ScheduleLevelUpContent ScheduleLevelUpContent ScheduleLevelUpContent Pointer )
            value.ScheduleLevelUpActionObject               = GetObject<GameObject>(new IntPtr(p + 0x120), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA17CF98 0x120 ScheduleLevelUpActionObject ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ExpansionParameterContentObject           = GetObject<GameObject>(new IntPtr(p + 0x128), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA17CFB8 0x128 ExpansionParameterContentObject ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ScheduleDisplayInActionObject             = GetObject<GameObject>(new IntPtr(p + 0x130), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA17CFD8 0x130 ScheduleDisplayInActionObject ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.FanAreaObject                             = GetObject<GameObject>(new IntPtr(p + 0x138), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA17CFF8 0x138 FanAreaObject               ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.LeftParamObject                           = GetObject<GameObject>(new IntPtr(p + 0x140), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA17D018 0x140 LeftParamObject             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CommonTitleView                           = GetObject<CommonTitleView>(new IntPtr(p + 0x148), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0270DA17D038 0x148 CommonTitleView             ( 0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.ExecuteScheduleVitalityGauge              = GetObject<ScheduleVitalityGauge>(new IntPtr(p + 0x150), ReversePrism.DataModels.ScheduleVitalityGauge.FromPointer); // 0270DA17D058 0x150 ExecuteScheduleVitalityGauge ( 0001866E5120 ModelClassType ScheduleVitalityGauge ScheduleVitalityGauge ScheduleVitalityGauge Pointer )
            value.LessonAuditionScene                       = GetString(new IntPtr(p + 0x158)); // 0270DA17D078 0x158 LessonAuditionScene         ( 000186671910 ModelPrimitiveType string string string String )
            value.BlockArea                                 = GetObject<RectTransform>(new IntPtr(p + 0x160), ReversePrism.DataModels.RectTransform.FromPointer); // 0270DA17D098 0x160 BlockArea                   ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.TutorialDataObject                        = GetObject<TutorialData>(new IntPtr(p + 0x168), ReversePrism.DataModels.TutorialData.FromPointer); // 0270DA17D0B8 0x168 TutorialDataObject          ( 0001866B91B0 ModelClassType TutorialData TutorialData TutorialData Pointer )
            value.ConfigRefKeys                             = GetStringList(new IntPtr(p + 0x170)); // 0270DA17D0D8 0x170 ConfigRefKeys               ( 000185B817C0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.SupportEffectDemonstrateUIContent         = GetObject<SupportEffectDemonstrateUIContent>(new IntPtr(p + 0x178), ReversePrism.DataModels.SupportEffectDemonstrateUIContent.FromPointer); // 0270DA17D0F8 0x178 SupportEffectDemonstrateUIContent ( 0001865F0A00 ModelClassType SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent Pointer )
            value.ProduceTopMenuPopupViewFactory            = GetObject<ProduceTopMenuPopupViewFactory>(new IntPtr(p + 0x180), ReversePrism.DataModels.ProduceTopMenuPopupViewFactory.FromPointer); // 0270DA17D118 0x180 ProduceTopMenuPopupViewFactory ( 00018658BBF0 ModelClassType ProduceTopMenuPopupViewFactory ProduceTopMenuPopupViewFactory ProduceTopMenuPopupViewFactory Pointer )
            value.ScheduleSelectTutorialSequences           = GetObjectList<ITutorialSequence>(new IntPtr(p + 0x188), ReversePrism.DataModels.ITutorialSequence.FromPointer); // 0270DA17D138 0x188 ScheduleSelectTutorialSequences ( 000185B8A160 ModelClassListType ITutorialSequence[] ITutorialSequence[] List<ITutorialSequence> Pointer )
            value.HowToPlayManualKey                        = GetString(new IntPtr(p + 0x190)); // 0270DA17D158 0x190 HowToPlayManualKey          ( 000186671910 ModelPrimitiveType string string string String )
            value.HowToPlayProduceManualData                = GetObject<HowToPlayProduceManualData>(new IntPtr(p + 0x198), ReversePrism.DataModels.HowToPlayProduceManualData.FromPointer); // 0270DA17D178 0x198 HowToPlayProduceManualData  ( 0001866DA470 ModelClassType HowToPlayProduceManualData HowToPlayProduceManualData HowToPlayProduceManualData Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x1C0), ReversePrism.DataModels.IDisposable.FromPointer); // 0270DA17D218 0x1C0 BackKeyDisposable           ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
