using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Cts                                      0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 018 Disposables                              0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 020 Argument                                 000186553C70 ModelClassType ProduceIdolUpgradingArgument ProduceIdolUpgradingArgument ProduceIdolUpgradingArgument Pointer
    // 028 MasterData                               00018660B7A0 ModelClassType MasterData MasterData MasterData Pointer
    // 030 TitleView                                0001865EA1D0 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 038 UiCharacterView                          0001865ECA50 ModelClassType IProduceIdolUpgradingUICharacterView IProduceIdolUpgradingUICharacterView IProduceIdolUpgradingUICharacterView Pointer
    // 040 View                                     0001865ECF00 ModelClassType IProduceIdolUpgradingView IProduceIdolUpgradingView IProduceIdolUpgradingView Pointer
    // 048 StatusView                               0001865EBA60 ModelClassType IProduceIdolStatusView IProduceIdolStatusView IProduceIdolStatusView Pointer
    // 050 AwakeningView                            0001865E8F20 ModelClassType IProduceIdolAwakeningView IProduceIdolAwakeningView IProduceIdolAwakeningView Pointer
    // 058 TrainingView                             0001865EBF10 ModelClassType IProduceIdolTrainingView IProduceIdolTrainingView IProduceIdolTrainingView Pointer
    // 060 SkillView                                0001865EAD10 ModelClassType IProduceIdolSkillView IProduceIdolSkillView IProduceIdolSkillView Pointer
    // 068 selectFavoriteMarkPopupViewFactory       IPopupViewFactory`1<ISelectFavoriteMarkPopupView> IL2CPP_TYPE_GENERICINST
    // 070 PIdolDetailPopupViewFactory              0001865D0010 ModelClassType IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory Pointer
    // 078 howToGetItemsPopupViewFactory            IPopupViewFactory`1<IHowToGetItemsPopupView> IL2CPP_TYPE_GENERICINST
    // 080 awakeningExecutionConfirmedPopupViewFactory IPopupViewFactory`1<IAwakeningExecutionConfirmedPopupView> IL2CPP_TYPE_GENERICINST
    // 088 piTrainingExecutionConfirmedPopupViewFactory IPopupViewFactory`1<IPITrainingExecutionConfirmedPopupView> IL2CPP_TYPE_GENERICINST
    // 090 costumeAcquisitionPopupViewFactory       IPopupViewFactory`1<ICostumeAcquisitionPopupView> IL2CPP_TYPE_GENERICINST
    // 098 costumeDetailPopupViewFactory            IPopupViewFactory`1<ICostumeDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 0A0 idolSkillLvUpExecutionConfirmedPopupViewFactory IPopupViewFactory`1<IIdolSkillLvUpExecutionConfirmedPopupView> IL2CPP_TYPE_GENERICINST
    // 0A8 idolSkillLvUpCompletedPopupViewFactory   IPopupViewFactory`1<IIdolSkillLvUpCompletedPopupView> IL2CPP_TYPE_GENERICINST
    // 0B0 efficacyDetailListPopupViewFactory       IPopupViewFactory`1<IEfficacyDetailListPopupView> IL2CPP_TYPE_GENERICINST
    // 0B8 ProductService                           0001865A4890 ModelClassType ProductService ProductService ProductService Pointer
    // 0C0 TargetPI                                 0001865EB0E0 ModelClassType IProduceIdolStatus IProduceIdolStatus IProduceIdolStatus Pointer
    // 0C8 DefaultTab                               000186552FD0 ModelEnumType ProduceIdolUpgradeTab ProduceIdolUpgradeTab ProduceIdolUpgradeTab Int32
    // 0D0 ProduceIdolStatusModel                   000186550CE0 ModelClassType ProduceIdolStatusViewModel ProduceIdolStatusViewModel ProduceIdolStatusViewModel Pointer
    // 0D8 ProduceIdolAwakeningModel                000186547710 ModelClassType ProduceIdolAwakeningViewModel ProduceIdolAwakeningViewModel ProduceIdolAwakeningViewModel Pointer
    // 0E0 ProduceIdolTrainingModel                 000186551E60 ModelClassType ProduceIdolTrainingViewModel ProduceIdolTrainingViewModel ProduceIdolTrainingViewModel Pointer
    // 0E8 IdolSkillLvUpModel                       0001866C1440 ModelClassType IdolSkillLvUpModel IdolSkillLvUpModel IdolSkillLvUpModel Pointer
    // 0F0 SkillLvUpVoiceMotion                     0001866264F0 ModelClassType MstOutgameVoiceMotion MstOutgameVoiceMotion MstOutgameVoiceMotion Pointer
    // 0F8 UnitIdol                                 00018670C980 ModelClassType UnitIdol UnitIdol UnitIdol Pointer
    // 100 Display3DSceneLoader                     0001866CC6B0 ModelClassType SceneLoaderAddressable SceneLoaderAddressable SceneLoaderAddressable Pointer
    // 108 ProduceAdvStatusList                     000185D05518 ModelClassListType IReadOnlyList`1<IProduceAdvStatus> IReadOnlyList`1<IProduceAdvStatus> List<IProduceAdvStatus> Pointer
    public partial class ProduceIdolUpgradingPresenter
    {
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public ProduceIdolUpgradingArgument?            Argument                                { get; set; }
        public MasterData?                              MasterData                              { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }
        public IProduceIdolUpgradingUICharacterView?    UiCharacterView                         { get; set; }
        public IProduceIdolUpgradingView?               View                                    { get; set; }
        public IProduceIdolStatusView?                  StatusView                              { get; set; }
        public IProduceIdolAwakeningView?               AwakeningView                           { get; set; }
        public IProduceIdolTrainingView?                TrainingView                            { get; set; }
        public IProduceIdolSkillView?                   SkillView                               { get; set; }
        public IPIdolDetailPopupViewFactory?            PIdolDetailPopupViewFactory             { get; set; }
        public ProductService?                          ProductService                          { get; set; }
        public IProduceIdolStatus?                      TargetPI                                { get; set; }
        public ProduceIdolUpgradeTab                    DefaultTab                              { get; set; }
        public ProduceIdolStatusViewModel?              ProduceIdolStatusModel                  { get; set; }
        public ProduceIdolAwakeningViewModel?           ProduceIdolAwakeningModel               { get; set; }
        public ProduceIdolTrainingViewModel?            ProduceIdolTrainingModel                { get; set; }
        public IdolSkillLvUpModel?                      IdolSkillLvUpModel                      { get; set; }
        public MstOutgameVoiceMotion?                   SkillLvUpVoiceMotion                    { get; set; }
        public UnitIdol?                                UnitIdol                                { get; set; }
        public SceneLoaderAddressable?                  Display3DSceneLoader                    { get; set; }
        public List<IProduceAdvStatus>?                 ProduceAdvStatusList                    { get; set; }

        public static ProduceIdolUpgradingPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceIdolUpgradingPresenter();

            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x010), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D5FCAF20 0x10 Cts                         ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D5FCAF40 0x18 Disposables                 ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Argument                                  = GetObject<ProduceIdolUpgradingArgument>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceIdolUpgradingArgument.FromPointer); // 0270D5FCAF60 0x20 Argument                    ( 000186553C70 ModelClassType ProduceIdolUpgradingArgument ProduceIdolUpgradingArgument ProduceIdolUpgradingArgument Pointer )
            value.MasterData                                = GetObject<MasterData>(new IntPtr(p + 0x028), ReversePrism.DataModels.MasterData.FromPointer); // 0270D5FCAF80 0x28 MasterData                  ( 00018660B7A0 ModelClassType MasterData MasterData MasterData Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x030), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0270D5FCAFA0 0x30 TitleView                   ( 0001865EA1D0 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.UiCharacterView                           = GetObject<IProduceIdolUpgradingUICharacterView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IProduceIdolUpgradingUICharacterView.FromPointer); // 0270D5FCAFC0 0x38 UiCharacterView             ( 0001865ECA50 ModelClassType IProduceIdolUpgradingUICharacterView IProduceIdolUpgradingUICharacterView IProduceIdolUpgradingUICharacterView Pointer )
            value.View                                      = GetObject<IProduceIdolUpgradingView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IProduceIdolUpgradingView.FromPointer); // 0270D5FCAFE0 0x40 View                        ( 0001865ECF00 ModelClassType IProduceIdolUpgradingView IProduceIdolUpgradingView IProduceIdolUpgradingView Pointer )
            value.StatusView                                = GetObject<IProduceIdolStatusView>(new IntPtr(p + 0x048), ReversePrism.DataModels.IProduceIdolStatusView.FromPointer); // 0270D5FCB000 0x48 StatusView                  ( 0001865EBA60 ModelClassType IProduceIdolStatusView IProduceIdolStatusView IProduceIdolStatusView Pointer )
            value.AwakeningView                             = GetObject<IProduceIdolAwakeningView>(new IntPtr(p + 0x050), ReversePrism.DataModels.IProduceIdolAwakeningView.FromPointer); // 0270D5FCB020 0x50 AwakeningView               ( 0001865E8F20 ModelClassType IProduceIdolAwakeningView IProduceIdolAwakeningView IProduceIdolAwakeningView Pointer )
            value.TrainingView                              = GetObject<IProduceIdolTrainingView>(new IntPtr(p + 0x058), ReversePrism.DataModels.IProduceIdolTrainingView.FromPointer); // 0270D5FCB040 0x58 TrainingView                ( 0001865EBF10 ModelClassType IProduceIdolTrainingView IProduceIdolTrainingView IProduceIdolTrainingView Pointer )
            value.SkillView                                 = GetObject<IProduceIdolSkillView>(new IntPtr(p + 0x060), ReversePrism.DataModels.IProduceIdolSkillView.FromPointer); // 0270D5FCB060 0x60 SkillView                   ( 0001865EAD10 ModelClassType IProduceIdolSkillView IProduceIdolSkillView IProduceIdolSkillView Pointer )
            value.PIdolDetailPopupViewFactory               = GetObject<IPIdolDetailPopupViewFactory>(new IntPtr(p + 0x070), ReversePrism.DataModels.IPIdolDetailPopupViewFactory.FromPointer); // 0270D5FCB0A0 0x70 PIdolDetailPopupViewFactory ( 0001865D0010 ModelClassType IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory Pointer )
            value.ProductService                            = GetObject<ProductService>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.ProductService.FromPointer); // 0270D5FCB1C0 0xB8 ProductService              ( 0001865A4890 ModelClassType ProductService ProductService ProductService Pointer )
            value.TargetPI                                  = GetObject<IProduceIdolStatus>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.IProduceIdolStatus.FromPointer); // 0270D5FCB1E0 0xC0 TargetPI                    ( 0001865EB0E0 ModelClassType IProduceIdolStatus IProduceIdolStatus IProduceIdolStatus Pointer )
            value.DefaultTab                                = (ProduceIdolUpgradeTab)GetInt32(new IntPtr(p + 0x0C8)); // 0270D5FCB200 0xC8 DefaultTab                  ( 000186552FD0 ModelEnumType ProduceIdolUpgradeTab ProduceIdolUpgradeTab ProduceIdolUpgradeTab Int32 )
            value.ProduceIdolStatusModel                    = GetObject<ProduceIdolStatusViewModel>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.ProduceIdolStatusViewModel.FromPointer); // 0270D5FCB220 0xD0 ProduceIdolStatusModel      ( 000186550CE0 ModelClassType ProduceIdolStatusViewModel ProduceIdolStatusViewModel ProduceIdolStatusViewModel Pointer )
            value.ProduceIdolAwakeningModel                 = GetObject<ProduceIdolAwakeningViewModel>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.ProduceIdolAwakeningViewModel.FromPointer); // 0270D5FCB240 0xD8 ProduceIdolAwakeningModel   ( 000186547710 ModelClassType ProduceIdolAwakeningViewModel ProduceIdolAwakeningViewModel ProduceIdolAwakeningViewModel Pointer )
            value.ProduceIdolTrainingModel                  = GetObject<ProduceIdolTrainingViewModel>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.ProduceIdolTrainingViewModel.FromPointer); // 0270D5FCB260 0xE0 ProduceIdolTrainingModel    ( 000186551E60 ModelClassType ProduceIdolTrainingViewModel ProduceIdolTrainingViewModel ProduceIdolTrainingViewModel Pointer )
            value.IdolSkillLvUpModel                        = GetObject<IdolSkillLvUpModel>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.IdolSkillLvUpModel.FromPointer); // 0270D5FCB280 0xE8 IdolSkillLvUpModel          ( 0001866C1440 ModelClassType IdolSkillLvUpModel IdolSkillLvUpModel IdolSkillLvUpModel Pointer )
            value.SkillLvUpVoiceMotion                      = GetObject<MstOutgameVoiceMotion>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.MstOutgameVoiceMotion.FromPointer); // 0270D5FCB2A0 0xF0 SkillLvUpVoiceMotion        ( 0001866264F0 ModelClassType MstOutgameVoiceMotion MstOutgameVoiceMotion MstOutgameVoiceMotion Pointer )
            value.UnitIdol                                  = GetObject<UnitIdol>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.UnitIdol.FromPointer); // 0270D5FCB2C0 0xF8 UnitIdol                    ( 00018670C980 ModelClassType UnitIdol UnitIdol UnitIdol Pointer )
            value.Display3DSceneLoader                      = GetObject<SceneLoaderAddressable>(new IntPtr(p + 0x100), ReversePrism.DataModels.SceneLoaderAddressable.FromPointer); // 0270D5FCB2E0 0x100 Display3DSceneLoader        ( 0001866CC6B0 ModelClassType SceneLoaderAddressable SceneLoaderAddressable SceneLoaderAddressable Pointer )
            value.ProduceAdvStatusList                      = GetObjectList<IProduceAdvStatus>(new IntPtr(p + 0x108), ReversePrism.DataModels.IProduceAdvStatus.FromPointer); // 0270D5FCB300 0x108 ProduceAdvStatusList        ( 000185D05518 ModelClassListType IReadOnlyList`1<IProduceAdvStatus> IReadOnlyList`1<IProduceAdvStatus> List<IProduceAdvStatus> Pointer )

            return value;
        }
    }
}
