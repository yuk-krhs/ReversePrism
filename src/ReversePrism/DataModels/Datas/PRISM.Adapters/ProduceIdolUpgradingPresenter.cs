using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 018 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 020 Argument                                 ModelClassType ProduceIdolUpgradingArgument ProduceIdolUpgradingArgument ProduceIdolUpgradingArgument Pointer
    // 028 MasterData                               ModelClassType MasterData MasterData MasterData Pointer
    // 030 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 038 TitleView                                ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 040 UiCharacterView                          ModelClassType IProduceIdolUpgradingUICharacterView IProduceIdolUpgradingUICharacterView IProduceIdolUpgradingUICharacterView Pointer
    // 048 View                                     ModelClassType IProduceIdolUpgradingView IProduceIdolUpgradingView IProduceIdolUpgradingView Pointer
    // 050 StatusView                               ModelClassType IProduceIdolStatusView IProduceIdolStatusView IProduceIdolStatusView Pointer
    // 058 AwakeningView                            ModelClassType IProduceIdolAwakeningView IProduceIdolAwakeningView IProduceIdolAwakeningView Pointer
    // 060 TrainingView                             ModelClassType IProduceIdolTrainingView IProduceIdolTrainingView IProduceIdolTrainingView Pointer
    // 068 SkillView                                ModelClassType IProduceIdolSkillView IProduceIdolSkillView IProduceIdolSkillView Pointer
    // 070 LiveSkillView                            ModelClassType IProduceIdolLiveSkillView IProduceIdolLiveSkillView IProduceIdolLiveSkillView Pointer
    // 078 TargetPI                                 ModelClassType IProduceIdolStatus IProduceIdolStatus IProduceIdolStatus Pointer
    // 080 DefaultTab                               ModelEnumType ProduceIdolUpgradeTab ProduceIdolUpgradeTab ProduceIdolUpgradeTab Int32
    // 088 ProduceIdolStatusModel                   ModelClassType ProduceIdolStatusViewModel ProduceIdolStatusViewModel ProduceIdolStatusViewModel Pointer
    // 090 ProduceIdolAwakeningModel                ModelClassType ProduceIdolAwakeningViewModel ProduceIdolAwakeningViewModel ProduceIdolAwakeningViewModel Pointer
    // 098 ProduceIdolTrainingModel                 ModelClassType ProduceIdolTrainingViewModel ProduceIdolTrainingViewModel ProduceIdolTrainingViewModel Pointer
    // 0A0 IdolSkillLvUpModel                       ModelClassType IdolSkillLvUpModel IdolSkillLvUpModel IdolSkillLvUpModel Pointer
    // 0A8 LiveSkillViewModel                       ModelClassType ProduceIdolLiveSkillViewModel ProduceIdolLiveSkillViewModel ProduceIdolLiveSkillViewModel Pointer
    // 0B0 SkillLvUpVoiceMotion                     ModelClassType MstOutgameVoiceMotion MstOutgameVoiceMotion MstOutgameVoiceMotion Pointer
    // 0B8 UnitIdol                                 ModelClassType UnitIdol UnitIdol UnitIdol Pointer
    public partial class ProduceIdolUpgradingPresenter : DataModel
    {
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public ProduceIdolUpgradingArgument?            Argument                                { get; set; }
        public MasterData?                              MasterData                              { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }
        public IProduceIdolUpgradingUICharacterView?    UiCharacterView                         { get; set; }
        public IProduceIdolUpgradingView?               View                                    { get; set; }
        public IProduceIdolStatusView?                  StatusView                              { get; set; }
        public IProduceIdolAwakeningView?               AwakeningView                           { get; set; }
        public IProduceIdolTrainingView?                TrainingView                            { get; set; }
        public IProduceIdolSkillView?                   SkillView                               { get; set; }
        public IProduceIdolLiveSkillView?               LiveSkillView                           { get; set; }
        public IProduceIdolStatus?                      TargetPI                                { get; set; }
        public ProduceIdolUpgradeTab                    DefaultTab                              { get; set; }
        public ProduceIdolStatusViewModel?              ProduceIdolStatusModel                  { get; set; }
        public ProduceIdolAwakeningViewModel?           ProduceIdolAwakeningModel               { get; set; }
        public ProduceIdolTrainingViewModel?            ProduceIdolTrainingModel                { get; set; }
        public IdolSkillLvUpModel?                      IdolSkillLvUpModel                      { get; set; }
        public ProduceIdolLiveSkillViewModel?           LiveSkillViewModel                      { get; set; }
        public MstOutgameVoiceMotion?                   SkillLvUpVoiceMotion                    { get; set; }
        public UnitIdol?                                UnitIdol                                { get; set; }

        public static ProduceIdolUpgradingPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceIdolUpgradingPresenter() { Pointer= p0 };

            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x010), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x10 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x18 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Argument                                  = GetObject<ProduceIdolUpgradingArgument>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceIdolUpgradingArgument.FromPointer); // 0x20 Argument                    ( ModelClassType ProduceIdolUpgradingArgument ProduceIdolUpgradingArgument ProduceIdolUpgradingArgument Pointer )
            value.MasterData                                = GetObject<MasterData>(new IntPtr(p + 0x028), ReversePrism.DataModels.MasterData.FromPointer); // 0x28 MasterData                  ( ModelClassType MasterData MasterData MasterData Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x030), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x30 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x038), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0x38 TitleView                   ( ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.UiCharacterView                           = GetObject<IProduceIdolUpgradingUICharacterView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IProduceIdolUpgradingUICharacterView.FromPointer); // 0x40 UiCharacterView             ( ModelClassType IProduceIdolUpgradingUICharacterView IProduceIdolUpgradingUICharacterView IProduceIdolUpgradingUICharacterView Pointer )
            value.View                                      = GetObject<IProduceIdolUpgradingView>(new IntPtr(p + 0x048), ReversePrism.DataModels.IProduceIdolUpgradingView.FromPointer); // 0x48 View                        ( ModelClassType IProduceIdolUpgradingView IProduceIdolUpgradingView IProduceIdolUpgradingView Pointer )
            value.StatusView                                = GetObject<IProduceIdolStatusView>(new IntPtr(p + 0x050), ReversePrism.DataModels.IProduceIdolStatusView.FromPointer); // 0x50 StatusView                  ( ModelClassType IProduceIdolStatusView IProduceIdolStatusView IProduceIdolStatusView Pointer )
            value.AwakeningView                             = GetObject<IProduceIdolAwakeningView>(new IntPtr(p + 0x058), ReversePrism.DataModels.IProduceIdolAwakeningView.FromPointer); // 0x58 AwakeningView               ( ModelClassType IProduceIdolAwakeningView IProduceIdolAwakeningView IProduceIdolAwakeningView Pointer )
            value.TrainingView                              = GetObject<IProduceIdolTrainingView>(new IntPtr(p + 0x060), ReversePrism.DataModels.IProduceIdolTrainingView.FromPointer); // 0x60 TrainingView                ( ModelClassType IProduceIdolTrainingView IProduceIdolTrainingView IProduceIdolTrainingView Pointer )
            value.SkillView                                 = GetObject<IProduceIdolSkillView>(new IntPtr(p + 0x068), ReversePrism.DataModels.IProduceIdolSkillView.FromPointer); // 0x68 SkillView                   ( ModelClassType IProduceIdolSkillView IProduceIdolSkillView IProduceIdolSkillView Pointer )
            value.LiveSkillView                             = GetObject<IProduceIdolLiveSkillView>(new IntPtr(p + 0x070), ReversePrism.DataModels.IProduceIdolLiveSkillView.FromPointer); // 0x70 LiveSkillView               ( ModelClassType IProduceIdolLiveSkillView IProduceIdolLiveSkillView IProduceIdolLiveSkillView Pointer )
            value.TargetPI                                  = GetObject<IProduceIdolStatus>(new IntPtr(p + 0x078), ReversePrism.DataModels.IProduceIdolStatus.FromPointer); // 0x78 TargetPI                    ( ModelClassType IProduceIdolStatus IProduceIdolStatus IProduceIdolStatus Pointer )
            value.DefaultTab                                = (ProduceIdolUpgradeTab)GetInt32(new IntPtr(p + 0x080)); // 0x80 DefaultTab                  ( ModelEnumType ProduceIdolUpgradeTab ProduceIdolUpgradeTab ProduceIdolUpgradeTab Int32 )
            value.ProduceIdolStatusModel                    = GetObject<ProduceIdolStatusViewModel>(new IntPtr(p + 0x088), ReversePrism.DataModels.ProduceIdolStatusViewModel.FromPointer); // 0x88 ProduceIdolStatusModel      ( ModelClassType ProduceIdolStatusViewModel ProduceIdolStatusViewModel ProduceIdolStatusViewModel Pointer )
            value.ProduceIdolAwakeningModel                 = GetObject<ProduceIdolAwakeningViewModel>(new IntPtr(p + 0x090), ReversePrism.DataModels.ProduceIdolAwakeningViewModel.FromPointer); // 0x90 ProduceIdolAwakeningModel   ( ModelClassType ProduceIdolAwakeningViewModel ProduceIdolAwakeningViewModel ProduceIdolAwakeningViewModel Pointer )
            value.ProduceIdolTrainingModel                  = GetObject<ProduceIdolTrainingViewModel>(new IntPtr(p + 0x098), ReversePrism.DataModels.ProduceIdolTrainingViewModel.FromPointer); // 0x98 ProduceIdolTrainingModel    ( ModelClassType ProduceIdolTrainingViewModel ProduceIdolTrainingViewModel ProduceIdolTrainingViewModel Pointer )
            value.IdolSkillLvUpModel                        = GetObject<IdolSkillLvUpModel>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.IdolSkillLvUpModel.FromPointer); // 0xA0 IdolSkillLvUpModel          ( ModelClassType IdolSkillLvUpModel IdolSkillLvUpModel IdolSkillLvUpModel Pointer )
            value.LiveSkillViewModel                        = GetObject<ProduceIdolLiveSkillViewModel>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.ProduceIdolLiveSkillViewModel.FromPointer); // 0xA8 LiveSkillViewModel          ( ModelClassType ProduceIdolLiveSkillViewModel ProduceIdolLiveSkillViewModel ProduceIdolLiveSkillViewModel Pointer )
            value.SkillLvUpVoiceMotion                      = GetObject<MstOutgameVoiceMotion>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.MstOutgameVoiceMotion.FromPointer); // 0xB0 SkillLvUpVoiceMotion        ( ModelClassType MstOutgameVoiceMotion MstOutgameVoiceMotion MstOutgameVoiceMotion Pointer )
            value.UnitIdol                                  = GetObject<UnitIdol>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.UnitIdol.FromPointer); // 0xB8 UnitIdol                    ( ModelClassType UnitIdol UnitIdol UnitIdol Pointer )

            return value;
        }
    }
}
