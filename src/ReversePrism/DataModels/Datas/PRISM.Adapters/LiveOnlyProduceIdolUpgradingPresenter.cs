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
    // 020 Argument                                 ModelClassType LiveOnlyProduceIdolUpgradingArgument LiveOnlyProduceIdolUpgradingArgument LiveOnlyProduceIdolUpgradingArgument Pointer
    // 028 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 030 TitleView                                ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 038 UiCharacterView                          ModelClassType IProduceIdolUpgradingUICharacterView IProduceIdolUpgradingUICharacterView IProduceIdolUpgradingUICharacterView Pointer
    // 040 View                                     ModelClassType ILiveOnlyProduceIdolUpgradingView ILiveOnlyProduceIdolUpgradingView ILiveOnlyProduceIdolUpgradingView Pointer
    // 048 StatusView                               ModelClassType IProduceIdolStatusView IProduceIdolStatusView IProduceIdolStatusView Pointer
    // 050 TrainingView                             ModelClassType IProduceIdolTrainingView IProduceIdolTrainingView IProduceIdolTrainingView Pointer
    // 058 LiveSkillView                            ModelClassType IProduceIdolLiveSkillView IProduceIdolLiveSkillView IProduceIdolLiveSkillView Pointer
    // 060 TargetPI                                 ModelClassType IProduceIdolStatus IProduceIdolStatus IProduceIdolStatus Pointer
    // 068 ProduceIdolStatusModel                   ModelClassType ProduceIdolStatusViewModel ProduceIdolStatusViewModel ProduceIdolStatusViewModel Pointer
    // 070 ProduceIdolTrainingModel                 ModelClassType ProduceIdolTrainingViewModel ProduceIdolTrainingViewModel ProduceIdolTrainingViewModel Pointer
    // 078 LiveSkillViewModel                       ModelClassType ProduceIdolLiveSkillViewModel ProduceIdolLiveSkillViewModel ProduceIdolLiveSkillViewModel Pointer
    // 080 UnitIdol                                 ModelClassType UnitIdol UnitIdol UnitIdol Pointer
    public partial class LiveOnlyProduceIdolUpgradingPresenter : DataModel
    {
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public LiveOnlyProduceIdolUpgradingArgument?    Argument                                { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }
        public IProduceIdolUpgradingUICharacterView?    UiCharacterView                         { get; set; }
        public ILiveOnlyProduceIdolUpgradingView?       View                                    { get; set; }
        public IProduceIdolStatusView?                  StatusView                              { get; set; }
        public IProduceIdolTrainingView?                TrainingView                            { get; set; }
        public IProduceIdolLiveSkillView?               LiveSkillView                           { get; set; }
        public IProduceIdolStatus?                      TargetPI                                { get; set; }
        public ProduceIdolStatusViewModel?              ProduceIdolStatusModel                  { get; set; }
        public ProduceIdolTrainingViewModel?            ProduceIdolTrainingModel                { get; set; }
        public ProduceIdolLiveSkillViewModel?           LiveSkillViewModel                      { get; set; }
        public UnitIdol?                                UnitIdol                                { get; set; }

        public static LiveOnlyProduceIdolUpgradingPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveOnlyProduceIdolUpgradingPresenter() { Pointer= p0 };

            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x010), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x10 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x18 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Argument                                  = GetObject<LiveOnlyProduceIdolUpgradingArgument>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveOnlyProduceIdolUpgradingArgument.FromPointer); // 0x20 Argument                    ( ModelClassType LiveOnlyProduceIdolUpgradingArgument LiveOnlyProduceIdolUpgradingArgument LiveOnlyProduceIdolUpgradingArgument Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x028), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x28 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x030), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0x30 TitleView                   ( ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.UiCharacterView                           = GetObject<IProduceIdolUpgradingUICharacterView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IProduceIdolUpgradingUICharacterView.FromPointer); // 0x38 UiCharacterView             ( ModelClassType IProduceIdolUpgradingUICharacterView IProduceIdolUpgradingUICharacterView IProduceIdolUpgradingUICharacterView Pointer )
            value.View                                      = GetObject<ILiveOnlyProduceIdolUpgradingView>(new IntPtr(p + 0x040), ReversePrism.DataModels.ILiveOnlyProduceIdolUpgradingView.FromPointer); // 0x40 View                        ( ModelClassType ILiveOnlyProduceIdolUpgradingView ILiveOnlyProduceIdolUpgradingView ILiveOnlyProduceIdolUpgradingView Pointer )
            value.StatusView                                = GetObject<IProduceIdolStatusView>(new IntPtr(p + 0x048), ReversePrism.DataModels.IProduceIdolStatusView.FromPointer); // 0x48 StatusView                  ( ModelClassType IProduceIdolStatusView IProduceIdolStatusView IProduceIdolStatusView Pointer )
            value.TrainingView                              = GetObject<IProduceIdolTrainingView>(new IntPtr(p + 0x050), ReversePrism.DataModels.IProduceIdolTrainingView.FromPointer); // 0x50 TrainingView                ( ModelClassType IProduceIdolTrainingView IProduceIdolTrainingView IProduceIdolTrainingView Pointer )
            value.LiveSkillView                             = GetObject<IProduceIdolLiveSkillView>(new IntPtr(p + 0x058), ReversePrism.DataModels.IProduceIdolLiveSkillView.FromPointer); // 0x58 LiveSkillView               ( ModelClassType IProduceIdolLiveSkillView IProduceIdolLiveSkillView IProduceIdolLiveSkillView Pointer )
            value.TargetPI                                  = GetObject<IProduceIdolStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.IProduceIdolStatus.FromPointer); // 0x60 TargetPI                    ( ModelClassType IProduceIdolStatus IProduceIdolStatus IProduceIdolStatus Pointer )
            value.ProduceIdolStatusModel                    = GetObject<ProduceIdolStatusViewModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.ProduceIdolStatusViewModel.FromPointer); // 0x68 ProduceIdolStatusModel      ( ModelClassType ProduceIdolStatusViewModel ProduceIdolStatusViewModel ProduceIdolStatusViewModel Pointer )
            value.ProduceIdolTrainingModel                  = GetObject<ProduceIdolTrainingViewModel>(new IntPtr(p + 0x070), ReversePrism.DataModels.ProduceIdolTrainingViewModel.FromPointer); // 0x70 ProduceIdolTrainingModel    ( ModelClassType ProduceIdolTrainingViewModel ProduceIdolTrainingViewModel ProduceIdolTrainingViewModel Pointer )
            value.LiveSkillViewModel                        = GetObject<ProduceIdolLiveSkillViewModel>(new IntPtr(p + 0x078), ReversePrism.DataModels.ProduceIdolLiveSkillViewModel.FromPointer); // 0x78 LiveSkillViewModel          ( ModelClassType ProduceIdolLiveSkillViewModel ProduceIdolLiveSkillViewModel ProduceIdolLiveSkillViewModel Pointer )
            value.UnitIdol                                  = GetObject<UnitIdol>(new IntPtr(p + 0x080), ReversePrism.DataModels.UnitIdol.FromPointer); // 0x80 UnitIdol                    ( ModelClassType UnitIdol UnitIdol UnitIdol Pointer )

            return value;
        }
    }
}
