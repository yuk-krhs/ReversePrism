using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScheduleSelectionViewModel               ModelClassType ScheduleSelectionViewModel ScheduleSelectionViewModel ScheduleSelectionViewModel Pointer
    // 018 ScheduleDetailViewModel                  ModelClassType ScheduleSelectionScheduleDetailViewModel ScheduleSelectionScheduleDetailViewModel ScheduleSelectionScheduleDetailViewModel Pointer
    // 020 ScheduleSelectionView                    ModelClassType IScheduleSelectionView IScheduleSelectionView IScheduleSelectionView Pointer
    // 028 View                                     ModelClassType IScheduleSelectionScheduleDetailView IScheduleSelectionScheduleDetailView IScheduleSelectionScheduleDetailView Pointer
    // 030 ScheduleSelectionModel                   ModelClassType ScheduleSelectionModel ScheduleSelectionModel ScheduleSelectionModel Pointer
    // 038 DetailModel                              ModelClassType ScheduleSelectionDetailModel ScheduleSelectionDetailModel ScheduleSelectionDetailModel Pointer
    // 040 IsBlackCover                             ModelPrimitiveType bool bool bool Bool
    // 048 EndAction                                ModelClassType Action Action Action Pointer
    // 050 TouchFrontPanelButton                    ModelClassType UIButton UIButton UIButton Pointer
    // 058 MiniCharacterActionObject                ModelClassType GameObject GameObject GameObject Pointer
    // 060 ScheduleInfoContent                      ModelClassType ScheduleInfoContent ScheduleInfoContent ScheduleInfoContent Pointer
    // 068 ParameterVariationContent                ModelClassType ParameterVariationContent ParameterVariationContent ParameterVariationContent Pointer
    // 070 MiniCharacterActionContent               ModelClassType MiniCharacterActionContent MiniCharacterActionContent MiniCharacterActionContent Pointer
    // 078 UnitIdolView                             ModelClassType IScheduleSelectionUnitIdolView IScheduleSelectionUnitIdolView IScheduleSelectionUnitIdolView Pointer
    // 080 LeftBottomAreaView                       ModelClassType IScheduleSelectionLeftBottomAreaView IScheduleSelectionLeftBottomAreaView IScheduleSelectionLeftBottomAreaView Pointer
    // 088 LeftWeekView                             ModelClassType IScheduleSelectionLeftWeekView IScheduleSelectionLeftWeekView IScheduleSelectionLeftWeekView Pointer
    // 090 ScheduleCarouselView                     ModelClassType IScheduleSelectionScheduleCarouselView IScheduleSelectionScheduleCarouselView IScheduleSelectionScheduleCarouselView Pointer
    // 098 LeftParamObject                          ModelClassType GameObject GameObject GameObject Pointer
    // 0A0 FanAreaObject                            ModelClassType GameObject GameObject GameObject Pointer
    // 0A8 CommonTitleView                          ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 0B0 ExecuteScheduleVitalityGauge             ModelClassType IScheduleVitalityGauge IScheduleVitalityGauge IScheduleVitalityGauge Pointer
    // 0B8 LessonAuditionScene                      ModelPrimitiveType string string string String
    // 0C0 ScheduleLevelUpActionContent             ModelClassType ScheduleLevelUpContent ScheduleLevelUpContent ScheduleLevelUpContent Pointer
    // 0C8 ScheduleLevelUpActionObject              ModelClassType GameObject GameObject GameObject Pointer
    // 0D0 ScheduleDisplayInActionObject            ModelClassType GameObject GameObject GameObject Pointer
    // 0D8 BgArea                                   ModelClassType RectTransform RectTransform RectTransform Pointer
    // 0E0 LeftArea                                 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 0E8 LeftArea2                                ModelClassType RectTransform RectTransform RectTransform Pointer
    // 0F0 setBlackDisplay                          Action`1<bool> IL2CPP_TYPE_GENERICINST
    // 0F8 OnClickScheduleExecuteDisposable         ModelClassType IDisposable IDisposable IDisposable Pointer
    // 100 SupportEffectDemonstrateUIContent        ModelClassType SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent Pointer
    // 108 ProduceBaseInfo                          ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer
    // 110 CacheCueName                             ModelPrimitiveType string string string String
    // 118 CacheLabel                               ModelPrimitiveType int int int Int32
    // 11C CacheIsSubSeason                         ModelPrimitiveType bool bool bool Bool
    // 120 Model3dLoader                            ModelClassType IModel3dLoaderForScheduleDetail IModel3dLoaderForScheduleDetail IModel3dLoaderForScheduleDetail Pointer
    // 128 PlayScenarioController                   ModelClassType PlayScenarioController PlayScenarioController PlayScenarioController Pointer
    // 130 IsExecutedSchedule                       ModelPrimitiveType bool bool bool Bool
    // 138 ViewDestroyCancellationToken             ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 140 DeleteCardIds                            ModelPrimitiveListType IReadOnlyList`1<string> IReadOnlyList`1<string> List<string> Pointer
    // 148 RankUpCardIds                            ModelPrimitiveListType IReadOnlyList`1<string> IReadOnlyList`1<string> List<string> Pointer
    public partial class ScheduleSelectionScheduleDetailPresenter : DataModel
    {
        public ScheduleSelectionViewModel?              ScheduleSelectionViewModel              { get; set; }
        public ScheduleSelectionScheduleDetailViewModel? ScheduleDetailViewModel                 { get; set; }
        public IScheduleSelectionView?                  ScheduleSelectionView                   { get; set; }
        public IScheduleSelectionScheduleDetailView?    View                                    { get; set; }
        public ScheduleSelectionModel?                  ScheduleSelectionModel                  { get; set; }
        public ScheduleSelectionDetailModel?            DetailModel                             { get; set; }
        public bool                                     IsBlackCover                            { get; set; }
        public Action?                                  EndAction                               { get; set; }
        public UIButton?                                TouchFrontPanelButton                   { get; set; }
        public GameObject?                              MiniCharacterActionObject               { get; set; }
        public ScheduleInfoContent?                     ScheduleInfoContent                     { get; set; }
        public ParameterVariationContent?               ParameterVariationContent               { get; set; }
        public MiniCharacterActionContent?              MiniCharacterActionContent              { get; set; }
        public IScheduleSelectionUnitIdolView?          UnitIdolView                            { get; set; }
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
        public RectTransform?                           BgArea                                  { get; set; }
        public RectTransform?                           LeftArea                                { get; set; }
        public RectTransform?                           LeftArea2                               { get; set; }
        public IDisposable?                             OnClickScheduleExecuteDisposable        { get; set; }
        public SupportEffectDemonstrateUIContent?       SupportEffectDemonstrateUIContent       { get; set; }
        public IProduceBaseInfoStatus?                  ProduceBaseInfo                         { get; set; }
        public string                                   CacheCueName                            { get; set; }
        public int                                      CacheLabel                              { get; set; }
        public bool                                     CacheIsSubSeason                        { get; set; }
        public IModel3dLoaderForScheduleDetail?         Model3dLoader                           { get; set; }
        public PlayScenarioController?                  PlayScenarioController                  { get; set; }
        public bool                                     IsExecutedSchedule                      { get; set; }
        public CancellationToken                        ViewDestroyCancellationToken            { get; set; }
        public List<string>?                            DeleteCardIds                           { get; set; }
        public List<string>?                            RankUpCardIds                           { get; set; }

        public static ScheduleSelectionScheduleDetailPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleSelectionScheduleDetailPresenter() { Pointer= p0 };

            value.ScheduleSelectionViewModel                = GetObject<ScheduleSelectionViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ScheduleSelectionViewModel.FromPointer); // 0x10 ScheduleSelectionViewModel  ( ModelClassType ScheduleSelectionViewModel ScheduleSelectionViewModel ScheduleSelectionViewModel Pointer )
            value.ScheduleDetailViewModel                   = GetObject<ScheduleSelectionScheduleDetailViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ScheduleSelectionScheduleDetailViewModel.FromPointer); // 0x18 ScheduleDetailViewModel     ( ModelClassType ScheduleSelectionScheduleDetailViewModel ScheduleSelectionScheduleDetailViewModel ScheduleSelectionScheduleDetailViewModel Pointer )
            value.ScheduleSelectionView                     = GetObject<IScheduleSelectionView>(new IntPtr(p + 0x020), ReversePrism.DataModels.IScheduleSelectionView.FromPointer); // 0x20 ScheduleSelectionView       ( ModelClassType IScheduleSelectionView IScheduleSelectionView IScheduleSelectionView Pointer )
            value.View                                      = GetObject<IScheduleSelectionScheduleDetailView>(new IntPtr(p + 0x028), ReversePrism.DataModels.IScheduleSelectionScheduleDetailView.FromPointer); // 0x28 View                        ( ModelClassType IScheduleSelectionScheduleDetailView IScheduleSelectionScheduleDetailView IScheduleSelectionScheduleDetailView Pointer )
            value.ScheduleSelectionModel                    = GetObject<ScheduleSelectionModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.ScheduleSelectionModel.FromPointer); // 0x30 ScheduleSelectionModel      ( ModelClassType ScheduleSelectionModel ScheduleSelectionModel ScheduleSelectionModel Pointer )
            value.DetailModel                               = GetObject<ScheduleSelectionDetailModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.ScheduleSelectionDetailModel.FromPointer); // 0x38 DetailModel                 ( ModelClassType ScheduleSelectionDetailModel ScheduleSelectionDetailModel ScheduleSelectionDetailModel Pointer )
            value.IsBlackCover                              = GetBool(new IntPtr(p + 0x040)); // 0x40 IsBlackCover                ( ModelPrimitiveType bool bool bool Bool )
            value.EndAction                                 = GetObject<Action>(new IntPtr(p + 0x048), ReversePrism.DataModels.Action.FromPointer); // 0x48 EndAction                   ( ModelClassType Action Action Action Pointer )
            value.TouchFrontPanelButton                     = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0x50 TouchFrontPanelButton       ( ModelClassType UIButton UIButton UIButton Pointer )
            value.MiniCharacterActionObject                 = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 MiniCharacterActionObject   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ScheduleInfoContent                       = GetObject<ScheduleInfoContent>(new IntPtr(p + 0x060), ReversePrism.DataModels.ScheduleInfoContent.FromPointer); // 0x60 ScheduleInfoContent         ( ModelClassType ScheduleInfoContent ScheduleInfoContent ScheduleInfoContent Pointer )
            value.ParameterVariationContent                 = GetObject<ParameterVariationContent>(new IntPtr(p + 0x068), ReversePrism.DataModels.ParameterVariationContent.FromPointer); // 0x68 ParameterVariationContent   ( ModelClassType ParameterVariationContent ParameterVariationContent ParameterVariationContent Pointer )
            value.MiniCharacterActionContent                = GetObject<MiniCharacterActionContent>(new IntPtr(p + 0x070), ReversePrism.DataModels.MiniCharacterActionContent.FromPointer); // 0x70 MiniCharacterActionContent  ( ModelClassType MiniCharacterActionContent MiniCharacterActionContent MiniCharacterActionContent Pointer )
            value.UnitIdolView                              = GetObject<IScheduleSelectionUnitIdolView>(new IntPtr(p + 0x078), ReversePrism.DataModels.IScheduleSelectionUnitIdolView.FromPointer); // 0x78 UnitIdolView                ( ModelClassType IScheduleSelectionUnitIdolView IScheduleSelectionUnitIdolView IScheduleSelectionUnitIdolView Pointer )
            value.LeftBottomAreaView                        = GetObject<IScheduleSelectionLeftBottomAreaView>(new IntPtr(p + 0x080), ReversePrism.DataModels.IScheduleSelectionLeftBottomAreaView.FromPointer); // 0x80 LeftBottomAreaView          ( ModelClassType IScheduleSelectionLeftBottomAreaView IScheduleSelectionLeftBottomAreaView IScheduleSelectionLeftBottomAreaView Pointer )
            value.LeftWeekView                              = GetObject<IScheduleSelectionLeftWeekView>(new IntPtr(p + 0x088), ReversePrism.DataModels.IScheduleSelectionLeftWeekView.FromPointer); // 0x88 LeftWeekView                ( ModelClassType IScheduleSelectionLeftWeekView IScheduleSelectionLeftWeekView IScheduleSelectionLeftWeekView Pointer )
            value.ScheduleCarouselView                      = GetObject<IScheduleSelectionScheduleCarouselView>(new IntPtr(p + 0x090), ReversePrism.DataModels.IScheduleSelectionScheduleCarouselView.FromPointer); // 0x90 ScheduleCarouselView        ( ModelClassType IScheduleSelectionScheduleCarouselView IScheduleSelectionScheduleCarouselView IScheduleSelectionScheduleCarouselView Pointer )
            value.LeftParamObject                           = GetObject<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 0x98 LeftParamObject             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.FanAreaObject                             = GetObject<GameObject>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GameObject.FromPointer); // 0xA0 FanAreaObject               ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CommonTitleView                           = GetObject<CommonTitleView>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0xA8 CommonTitleView             ( ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.ExecuteScheduleVitalityGauge              = GetObject<IScheduleVitalityGauge>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.IScheduleVitalityGauge.FromPointer); // 0xB0 ExecuteScheduleVitalityGauge ( ModelClassType IScheduleVitalityGauge IScheduleVitalityGauge IScheduleVitalityGauge Pointer )
            value.LessonAuditionScene                       = GetString(new IntPtr(p + 0x0B8)); // 0xB8 LessonAuditionScene         ( ModelPrimitiveType string string string String )
            value.ScheduleLevelUpActionContent              = GetObject<ScheduleLevelUpContent>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.ScheduleLevelUpContent.FromPointer); // 0xC0 ScheduleLevelUpActionContent ( ModelClassType ScheduleLevelUpContent ScheduleLevelUpContent ScheduleLevelUpContent Pointer )
            value.ScheduleLevelUpActionObject               = GetObject<GameObject>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.GameObject.FromPointer); // 0xC8 ScheduleLevelUpActionObject ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ScheduleDisplayInActionObject             = GetObject<GameObject>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.GameObject.FromPointer); // 0xD0 ScheduleDisplayInActionObject ( ModelClassType GameObject GameObject GameObject Pointer )
            value.BgArea                                    = GetObject<RectTransform>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.RectTransform.FromPointer); // 0xD8 BgArea                      ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.LeftArea                                  = GetObject<RectTransform>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.RectTransform.FromPointer); // 0xE0 LeftArea                    ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.LeftArea2                                 = GetObject<RectTransform>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.RectTransform.FromPointer); // 0xE8 LeftArea2                   ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.OnClickScheduleExecuteDisposable          = GetObject<IDisposable>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.IDisposable.FromPointer); // 0xF8 OnClickScheduleExecuteDisposable ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.SupportEffectDemonstrateUIContent         = GetObject<SupportEffectDemonstrateUIContent>(new IntPtr(p + 0x100), ReversePrism.DataModels.SupportEffectDemonstrateUIContent.FromPointer); // 0x100 SupportEffectDemonstrateUIContent ( ModelClassType SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent Pointer )
            value.ProduceBaseInfo                           = GetObject<IProduceBaseInfoStatus>(new IntPtr(p + 0x108), ReversePrism.DataModels.IProduceBaseInfoStatus.FromPointer); // 0x108 ProduceBaseInfo             ( ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer )
            value.CacheCueName                              = GetString(new IntPtr(p + 0x110)); // 0x110 CacheCueName                ( ModelPrimitiveType string string string String )
            value.CacheLabel                                = GetInt32(new IntPtr(p + 0x118)); // 0x118 CacheLabel                  ( ModelPrimitiveType int int int Int32 )
            value.CacheIsSubSeason                          = GetBool(new IntPtr(p + 0x11C)); // 0x11C CacheIsSubSeason            ( ModelPrimitiveType bool bool bool Bool )
            value.Model3dLoader                             = GetObject<IModel3dLoaderForScheduleDetail>(new IntPtr(p + 0x120), ReversePrism.DataModels.IModel3dLoaderForScheduleDetail.FromPointer); // 0x120 Model3dLoader               ( ModelClassType IModel3dLoaderForScheduleDetail IModel3dLoaderForScheduleDetail IModel3dLoaderForScheduleDetail Pointer )
            value.PlayScenarioController                    = GetObject<PlayScenarioController>(new IntPtr(p + 0x128), ReversePrism.DataModels.PlayScenarioController.FromPointer); // 0x128 PlayScenarioController      ( ModelClassType PlayScenarioController PlayScenarioController PlayScenarioController Pointer )
            value.IsExecutedSchedule                        = GetBool(new IntPtr(p + 0x130)); // 0x130 IsExecutedSchedule          ( ModelPrimitiveType bool bool bool Bool )
            value.ViewDestroyCancellationToken              = (CancellationToken)GetInt32(new IntPtr(p + 0x138)); // 0x138 ViewDestroyCancellationToken ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.DeleteCardIds                             = GetStringList(new IntPtr(p + 0x140)); // 0x140 DeleteCardIds               ( ModelPrimitiveListType IReadOnlyList`1<string> IReadOnlyList`1<string> List<string> Pointer )
            value.RankUpCardIds                             = GetStringList(new IntPtr(p + 0x148)); // 0x148 RankUpCardIds               ( ModelPrimitiveListType IReadOnlyList`1<string> IReadOnlyList`1<string> List<string> Pointer )

            return value;
        }
    }
}
