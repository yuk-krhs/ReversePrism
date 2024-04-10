using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScheduleSelectionViewModel               0001866E2A30 ModelClassType ScheduleSelectionViewModel ScheduleSelectionViewModel ScheduleSelectionViewModel Pointer
    // 018 ScheduleSelectionView                    000186627780 ModelClassType IScheduleSelectionView IScheduleSelectionView IScheduleSelectionView Pointer
    // 020 View                                     000186626DD0 ModelClassType IScheduleSelectionScheduleDetailView IScheduleSelectionScheduleDetailView IScheduleSelectionScheduleDetailView Pointer
    // 028 Model                                    0001866DC3D0 ModelClassType ScheduleSelectionModel ScheduleSelectionModel ScheduleSelectionModel Pointer
    // 030 DetailModel                              0001866D9130 ModelClassType ScheduleSelectionDetailModel ScheduleSelectionDetailModel ScheduleSelectionDetailModel Pointer
    // 038 MonoBehaviour                            00018663D7E0 ModelClassType MonoBehaviour MonoBehaviour MonoBehaviour Pointer
    // 040 IsBlackCover                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 048 EndAction                                0001866792B0 ModelClassType Action Action Action Pointer
    // 050 TouchFrontPanelButton                    0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 058 MiniCharacterActionObject                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 060 ScheduleInfoContent                      0001866D4B10 ModelClassType ScheduleInfoContent ScheduleInfoContent ScheduleInfoContent Pointer
    // 068 ParameterVariationContent                00018671D4D0 ModelClassType ParameterVariationContent ParameterVariationContent ParameterVariationContent Pointer
    // 070 MiniCharacterActionContent               00018661B490 ModelClassType MiniCharacterActionContent MiniCharacterActionContent MiniCharacterActionContent Pointer
    // 078 VitalityGauge                            00018652E260 ModelClassType VitalityGauge VitalityGauge VitalityGauge Pointer
    // 080 UnitidolView                             000186627280 ModelClassType IScheduleSelectionUnitIdolView IScheduleSelectionUnitIdolView IScheduleSelectionUnitIdolView Pointer
    // 088 LeftBottomAreaView                       000186626010 ModelClassType IScheduleSelectionLeftBottomAreaView IScheduleSelectionLeftBottomAreaView IScheduleSelectionLeftBottomAreaView Pointer
    // 090 LeftWeekView                             000186626510 ModelClassType IScheduleSelectionLeftWeekView IScheduleSelectionLeftWeekView IScheduleSelectionLeftWeekView Pointer
    // 098 ScheduleCarouselView                     0001866269D0 ModelClassType IScheduleSelectionScheduleCarouselView IScheduleSelectionScheduleCarouselView IScheduleSelectionScheduleCarouselView Pointer
    // 0A0 LeftParamObject                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0A8 FanAreaObject                            0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0B0 CommonTitleView                          0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 0B8 ExecuteScheduleVitalityGauge             000186628D00 ModelClassType IScheduleVitalityGauge IScheduleVitalityGauge IScheduleVitalityGauge Pointer
    // 0C0 LessonAuditionScene                      000186671910 ModelPrimitiveType string string string String
    // 0C8 ScheduleLevelUpActionContent             0001866D5270 ModelClassType ScheduleLevelUpContent ScheduleLevelUpContent ScheduleLevelUpContent Pointer
    // 0D0 ScheduleLevelUpActionObject              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0D8 ScheduleDisplayInActionObject            0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0E0 SafeArea                                 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 0E8 BgArea                                   000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 0F0 LeftArea                                 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 0F8 LeftArea2                                000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 100 RightCentralArea                         000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 108 RightTopUIArea                           000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 110 setBlackDisplay                          Action`1<bool> IL2CPP_TYPE_GENERICINST
    // 118 OnClickScheduleExecuteDisposable         0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 120 SupportEffectDemonstrateUIContent        0001865F0A00 ModelClassType SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent Pointer
    // 128 ProduceBaseInfo                          0001865E2F10 ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer
    // 130 Model3DManager                           000186639A50 ModelClassType Model3DManager Model3DManager Model3DManager Pointer
    // 138 CacheCueName                             000186671910 ModelPrimitiveType string string string String
    // 140 CacheLabel                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 144 CacheIsSubSeason                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 145 IsExecutedSchedule                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 148 Cts                                      0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class ScheduleSelectionScheduleDetailPresenter : DataModel
    {
        public ScheduleSelectionViewModel?              ScheduleSelectionViewModel              { get; set; }
        public IScheduleSelectionView?                  ScheduleSelectionView                   { get; set; }
        public IScheduleSelectionScheduleDetailView?    View                                    { get; set; }
        public ScheduleSelectionModel?                  Model                                   { get; set; }
        public ScheduleSelectionDetailModel?            DetailModel                             { get; set; }
        public MonoBehaviour?                           MonoBehaviour                           { get; set; }
        public bool                                     IsBlackCover                            { get; set; }
        public Action?                                  EndAction                               { get; set; }
        public UIButton?                                TouchFrontPanelButton                   { get; set; }
        public GameObject?                              MiniCharacterActionObject               { get; set; }
        public ScheduleInfoContent?                     ScheduleInfoContent                     { get; set; }
        public ParameterVariationContent?               ParameterVariationContent               { get; set; }
        public MiniCharacterActionContent?              MiniCharacterActionContent              { get; set; }
        public VitalityGauge?                           VitalityGauge                           { get; set; }
        public IScheduleSelectionUnitIdolView?          UnitidolView                            { get; set; }
        public IScheduleSelectionLeftBottomAreaView?    LeftBottomAreaView                      { get; set; }
        public IScheduleSelectionLeftWeekView?          LeftWeekView                            { get; set; }
        public IScheduleSelectionScheduleCarouselView?  ScheduleCarouselView                    { get; set; }
        public GameObject?                              LeftParamObject                         { get; set; }
        public GameObject?                              FanAreaObject                           { get; set; }
        public CommonTitleView?                         CommonTitleView                         { get; set; }
        public IScheduleVitalityGauge?                  ExecuteScheduleVitalityGauge            { get; set; }
        public string                                   LessonAuditionScene                     { get; set; }
        public ScheduleLevelUpContent?                  ScheduleLevelUpActionContent            { get; set; }
        public GameObject?                              ScheduleLevelUpActionObject             { get; set; }
        public GameObject?                              ScheduleDisplayInActionObject           { get; set; }
        public RectTransform?                           SafeArea                                { get; set; }
        public RectTransform?                           BgArea                                  { get; set; }
        public RectTransform?                           LeftArea                                { get; set; }
        public RectTransform?                           LeftArea2                               { get; set; }
        public RectTransform?                           RightCentralArea                        { get; set; }
        public RectTransform?                           RightTopUIArea                          { get; set; }
        public IDisposable?                             OnClickScheduleExecuteDisposable        { get; set; }
        public SupportEffectDemonstrateUIContent?       SupportEffectDemonstrateUIContent       { get; set; }
        public IProduceBaseInfoStatus?                  ProduceBaseInfo                         { get; set; }
        public Model3DManager?                          Model3DManager                          { get; set; }
        public string                                   CacheCueName                            { get; set; }
        public int                                      CacheLabel                              { get; set; }
        public bool                                     CacheIsSubSeason                        { get; set; }
        public bool                                     IsExecutedSchedule                      { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }

        public static ScheduleSelectionScheduleDetailPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleSelectionScheduleDetailPresenter() { Pointer= p0 };

            value.ScheduleSelectionViewModel                = GetObject<ScheduleSelectionViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ScheduleSelectionViewModel.FromPointer); // 0246666B1738 0x10 ScheduleSelectionViewModel  ( 0001866E2A30 ModelClassType ScheduleSelectionViewModel ScheduleSelectionViewModel ScheduleSelectionViewModel Pointer )
            value.ScheduleSelectionView                     = GetObject<IScheduleSelectionView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IScheduleSelectionView.FromPointer); // 0246666B1758 0x18 ScheduleSelectionView       ( 000186627780 ModelClassType IScheduleSelectionView IScheduleSelectionView IScheduleSelectionView Pointer )
            value.View                                      = GetObject<IScheduleSelectionScheduleDetailView>(new IntPtr(p + 0x020), ReversePrism.DataModels.IScheduleSelectionScheduleDetailView.FromPointer); // 0246666B1778 0x20 View                        ( 000186626DD0 ModelClassType IScheduleSelectionScheduleDetailView IScheduleSelectionScheduleDetailView IScheduleSelectionScheduleDetailView Pointer )
            value.Model                                     = GetObject<ScheduleSelectionModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.ScheduleSelectionModel.FromPointer); // 0246666B1798 0x28 Model                       ( 0001866DC3D0 ModelClassType ScheduleSelectionModel ScheduleSelectionModel ScheduleSelectionModel Pointer )
            value.DetailModel                               = GetObject<ScheduleSelectionDetailModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.ScheduleSelectionDetailModel.FromPointer); // 0246666B17B8 0x30 DetailModel                 ( 0001866D9130 ModelClassType ScheduleSelectionDetailModel ScheduleSelectionDetailModel ScheduleSelectionDetailModel Pointer )
            value.MonoBehaviour                             = GetObject<MonoBehaviour>(new IntPtr(p + 0x038), ReversePrism.DataModels.MonoBehaviour.FromPointer); // 0246666B17D8 0x38 MonoBehaviour               ( 00018663D7E0 ModelClassType MonoBehaviour MonoBehaviour MonoBehaviour Pointer )
            value.IsBlackCover                              = GetBool(new IntPtr(p + 0x040)); // 0246666B17F8 0x40 IsBlackCover                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.EndAction                                 = GetObject<Action>(new IntPtr(p + 0x048), ReversePrism.DataModels.Action.FromPointer); // 0246666B1818 0x48 EndAction                   ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.TouchFrontPanelButton                     = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0246666B1838 0x50 TouchFrontPanelButton       ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.MiniCharacterActionObject                 = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0246666B1858 0x58 MiniCharacterActionObject   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ScheduleInfoContent                       = GetObject<ScheduleInfoContent>(new IntPtr(p + 0x060), ReversePrism.DataModels.ScheduleInfoContent.FromPointer); // 0246666B1878 0x60 ScheduleInfoContent         ( 0001866D4B10 ModelClassType ScheduleInfoContent ScheduleInfoContent ScheduleInfoContent Pointer )
            value.ParameterVariationContent                 = GetObject<ParameterVariationContent>(new IntPtr(p + 0x068), ReversePrism.DataModels.ParameterVariationContent.FromPointer); // 0246666B1898 0x68 ParameterVariationContent   ( 00018671D4D0 ModelClassType ParameterVariationContent ParameterVariationContent ParameterVariationContent Pointer )
            value.MiniCharacterActionContent                = GetObject<MiniCharacterActionContent>(new IntPtr(p + 0x070), ReversePrism.DataModels.MiniCharacterActionContent.FromPointer); // 0246666B18B8 0x70 MiniCharacterActionContent  ( 00018661B490 ModelClassType MiniCharacterActionContent MiniCharacterActionContent MiniCharacterActionContent Pointer )
            value.VitalityGauge                             = GetObject<VitalityGauge>(new IntPtr(p + 0x078), ReversePrism.DataModels.VitalityGauge.FromPointer); // 0246666B18D8 0x78 VitalityGauge               ( 00018652E260 ModelClassType VitalityGauge VitalityGauge VitalityGauge Pointer )
            value.UnitidolView                              = GetObject<IScheduleSelectionUnitIdolView>(new IntPtr(p + 0x080), ReversePrism.DataModels.IScheduleSelectionUnitIdolView.FromPointer); // 0246666B18F8 0x80 UnitidolView                ( 000186627280 ModelClassType IScheduleSelectionUnitIdolView IScheduleSelectionUnitIdolView IScheduleSelectionUnitIdolView Pointer )
            value.LeftBottomAreaView                        = GetObject<IScheduleSelectionLeftBottomAreaView>(new IntPtr(p + 0x088), ReversePrism.DataModels.IScheduleSelectionLeftBottomAreaView.FromPointer); // 0246666B1918 0x88 LeftBottomAreaView          ( 000186626010 ModelClassType IScheduleSelectionLeftBottomAreaView IScheduleSelectionLeftBottomAreaView IScheduleSelectionLeftBottomAreaView Pointer )
            value.LeftWeekView                              = GetObject<IScheduleSelectionLeftWeekView>(new IntPtr(p + 0x090), ReversePrism.DataModels.IScheduleSelectionLeftWeekView.FromPointer); // 0246666B1938 0x90 LeftWeekView                ( 000186626510 ModelClassType IScheduleSelectionLeftWeekView IScheduleSelectionLeftWeekView IScheduleSelectionLeftWeekView Pointer )
            value.ScheduleCarouselView                      = GetObject<IScheduleSelectionScheduleCarouselView>(new IntPtr(p + 0x098), ReversePrism.DataModels.IScheduleSelectionScheduleCarouselView.FromPointer); // 0246666B1958 0x98 ScheduleCarouselView        ( 0001866269D0 ModelClassType IScheduleSelectionScheduleCarouselView IScheduleSelectionScheduleCarouselView IScheduleSelectionScheduleCarouselView Pointer )
            value.LeftParamObject                           = GetObject<GameObject>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GameObject.FromPointer); // 0246666B1978 0xA0 LeftParamObject             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.FanAreaObject                             = GetObject<GameObject>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.GameObject.FromPointer); // 0246666B1998 0xA8 FanAreaObject               ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CommonTitleView                           = GetObject<CommonTitleView>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0246666B19B8 0xB0 CommonTitleView             ( 0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.ExecuteScheduleVitalityGauge              = GetObject<IScheduleVitalityGauge>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.IScheduleVitalityGauge.FromPointer); // 0246666B19D8 0xB8 ExecuteScheduleVitalityGauge ( 000186628D00 ModelClassType IScheduleVitalityGauge IScheduleVitalityGauge IScheduleVitalityGauge Pointer )
            value.LessonAuditionScene                       = GetString(new IntPtr(p + 0x0C0)); // 0246666B19F8 0xC0 LessonAuditionScene         ( 000186671910 ModelPrimitiveType string string string String )
            value.ScheduleLevelUpActionContent              = GetObject<ScheduleLevelUpContent>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.ScheduleLevelUpContent.FromPointer); // 0246666B1A18 0xC8 ScheduleLevelUpActionContent ( 0001866D5270 ModelClassType ScheduleLevelUpContent ScheduleLevelUpContent ScheduleLevelUpContent Pointer )
            value.ScheduleLevelUpActionObject               = GetObject<GameObject>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.GameObject.FromPointer); // 0246666B1A38 0xD0 ScheduleLevelUpActionObject ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ScheduleDisplayInActionObject             = GetObject<GameObject>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.GameObject.FromPointer); // 0246666B1A58 0xD8 ScheduleDisplayInActionObject ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SafeArea                                  = GetObject<RectTransform>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.RectTransform.FromPointer); // 0246666B1A78 0xE0 SafeArea                    ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.BgArea                                    = GetObject<RectTransform>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.RectTransform.FromPointer); // 0246666B1A98 0xE8 BgArea                      ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.LeftArea                                  = GetObject<RectTransform>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.RectTransform.FromPointer); // 0246666B1AB8 0xF0 LeftArea                    ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.LeftArea2                                 = GetObject<RectTransform>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.RectTransform.FromPointer); // 0246666B1AD8 0xF8 LeftArea2                   ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.RightCentralArea                          = GetObject<RectTransform>(new IntPtr(p + 0x100), ReversePrism.DataModels.RectTransform.FromPointer); // 0246666B1AF8 0x100 RightCentralArea            ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.RightTopUIArea                            = GetObject<RectTransform>(new IntPtr(p + 0x108), ReversePrism.DataModels.RectTransform.FromPointer); // 0246666B1B18 0x108 RightTopUIArea              ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.OnClickScheduleExecuteDisposable          = GetObject<IDisposable>(new IntPtr(p + 0x118), ReversePrism.DataModels.IDisposable.FromPointer); // 0246666B1B58 0x118 OnClickScheduleExecuteDisposable ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.SupportEffectDemonstrateUIContent         = GetObject<SupportEffectDemonstrateUIContent>(new IntPtr(p + 0x120), ReversePrism.DataModels.SupportEffectDemonstrateUIContent.FromPointer); // 0246666B1B78 0x120 SupportEffectDemonstrateUIContent ( 0001865F0A00 ModelClassType SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent Pointer )
            value.ProduceBaseInfo                           = GetObject<IProduceBaseInfoStatus>(new IntPtr(p + 0x128), ReversePrism.DataModels.IProduceBaseInfoStatus.FromPointer); // 0246666B1B98 0x128 ProduceBaseInfo             ( 0001865E2F10 ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer )
            value.Model3DManager                            = GetObject<Model3DManager>(new IntPtr(p + 0x130), ReversePrism.DataModels.Model3DManager.FromPointer); // 0246666B1BB8 0x130 Model3DManager              ( 000186639A50 ModelClassType Model3DManager Model3DManager Model3DManager Pointer )
            value.CacheCueName                              = GetString(new IntPtr(p + 0x138)); // 0246666B1BD8 0x138 CacheCueName                ( 000186671910 ModelPrimitiveType string string string String )
            value.CacheLabel                                = GetInt32(new IntPtr(p + 0x140)); // 0246666B1BF8 0x140 CacheLabel                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CacheIsSubSeason                          = GetBool(new IntPtr(p + 0x144)); // 0246666B1C18 0x144 CacheIsSubSeason            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsExecutedSchedule                        = GetBool(new IntPtr(p + 0x145)); // 0246666B1C38 0x145 IsExecutedSchedule          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x148), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0246666B1C58 0x148 Cts                         ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
