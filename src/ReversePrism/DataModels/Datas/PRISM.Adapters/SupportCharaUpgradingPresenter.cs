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
    // 020 Argument                                 0001865E7500 ModelClassType SupportCharaUpgradingArgument SupportCharaUpgradingArgument SupportCharaUpgradingArgument Pointer
    // 028 TitleView                                0001865EA1D0 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 030 View                                     000186668A40 ModelClassType ISupportCharaUpgradingView ISupportCharaUpgradingView ISupportCharaUpgradingView Pointer
    // 038 StatusView                               0001866678F0 ModelClassType ISupportCharaStatusView ISupportCharaStatusView ISupportCharaStatusView Pointer
    // 040 TrainingView                             000186667DF0 ModelClassType ISupportCharaTrainingView ISupportCharaTrainingView ISupportCharaTrainingView Pointer
    // 048 MasterTrainingView                       000186667000 ModelClassType ISupportCharaMasterTrainingView ISupportCharaMasterTrainingView ISupportCharaMasterTrainingView Pointer
    // 050 SCharaDetailPopupViewFactory             000186622C10 ModelClassType ISCharaDetailPopupViewFactory ISCharaDetailPopupViewFactory ISCharaDetailPopupViewFactory Pointer
    // 058 selectFavoriteMarkPopupViewFactory       IPopupViewFactory`1<ISelectFavoriteMarkPopupView> IL2CPP_TYPE_GENERICINST
    // 060 scTrainingExecutionConfirmedPopupViewFactory IPopupViewFactory`1<ISCTrainingExecutionConfirmedPopupView> IL2CPP_TYPE_GENERICINST
    // 068 supportCharaLvUpCompletedPopupViewFactory IPopupViewFactory`1<ISupportCharaLvUpCompletedPopupView> IL2CPP_TYPE_GENERICINST
    // 070 masterTrainingExecutionConfirmedPopupViewFactory IPopupViewFactory`1<IMasterTrainingExecutionConfirmedPopupView> IL2CPP_TYPE_GENERICINST
    // 078 CommonSequencerContainer                 0001867347C0 ModelClassType ICommonSequencerContainer ICommonSequencerContainer ICommonSequencerContainer Pointer
    // 080 MasterData                               00018660B7A0 ModelClassType MasterData MasterData MasterData Pointer
    // 088 ProductService                           0001865A4890 ModelClassType ProductService ProductService ProductService Pointer
    // 090 TargetSC                                 000186669B50 ModelClassType ISupportCharacterStatus ISupportCharacterStatus ISupportCharacterStatus Pointer
    // 098 Calculator                               000186523A70 ModelClassType CalcLvExp CalcLvExp CalcLvExp Pointer
    // 0A0 StatusViewModel                          0001865E3AF0 ModelClassType SupportCharaStatusViewModel SupportCharaStatusViewModel SupportCharaStatusViewModel Pointer
    // 0A8 TrainingViewModel                        0001865E58C0 ModelClassType SupportCharaTrainingViewModel SupportCharaTrainingViewModel SupportCharaTrainingViewModel Pointer
    // 0B0 MasterTrainingViewModel                  0001865E10E0 ModelClassType SupportCharaMasterTrainingViewModel SupportCharaMasterTrainingViewModel SupportCharaMasterTrainingViewModel Pointer
    // 0B8 LvUpVoiceMotion                          0001866264F0 ModelClassType MstOutgameVoiceMotion MstOutgameVoiceMotion MstOutgameVoiceMotion Pointer
    // 0C0 DefaultTab                               0001865F2C70 ModelEnumType SupportIdolUpgradeTab SupportIdolUpgradeTab SupportIdolUpgradeTab Int32
    // 0C8 ProduceAdvStatusList                     000185D05518 ModelClassListType IReadOnlyList`1<IProduceAdvStatus> IReadOnlyList`1<IProduceAdvStatus> List<IProduceAdvStatus> Pointer
    public partial class SupportCharaUpgradingPresenter : DataModel
    {
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public SupportCharaUpgradingArgument?           Argument                                { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }
        public ISupportCharaUpgradingView?              View                                    { get; set; }
        public ISupportCharaStatusView?                 StatusView                              { get; set; }
        public ISupportCharaTrainingView?               TrainingView                            { get; set; }
        public ISupportCharaMasterTrainingView?         MasterTrainingView                      { get; set; }
        public ISCharaDetailPopupViewFactory?           SCharaDetailPopupViewFactory            { get; set; }
        public ICommonSequencerContainer?               CommonSequencerContainer                { get; set; }
        public MasterData?                              MasterData                              { get; set; }
        public ProductService?                          ProductService                          { get; set; }
        public ISupportCharacterStatus?                 TargetSC                                { get; set; }
        public CalcLvExp?                               Calculator                              { get; set; }
        public SupportCharaStatusViewModel?             StatusViewModel                         { get; set; }
        public SupportCharaTrainingViewModel?           TrainingViewModel                       { get; set; }
        public SupportCharaMasterTrainingViewModel?     MasterTrainingViewModel                 { get; set; }
        public MstOutgameVoiceMotion?                   LvUpVoiceMotion                         { get; set; }
        public SupportIdolUpgradeTab                    DefaultTab                              { get; set; }
        public List<IProduceAdvStatus>?                 ProduceAdvStatusList                    { get; set; }

        public static SupportCharaUpgradingPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharaUpgradingPresenter() { Pointer= p0 };

            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x010), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0246660CDDD0 0x10 Cts                         ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0246660CDDF0 0x18 Disposables                 ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Argument                                  = GetObject<SupportCharaUpgradingArgument>(new IntPtr(p + 0x020), ReversePrism.DataModels.SupportCharaUpgradingArgument.FromPointer); // 0246660CDE10 0x20 Argument                    ( 0001865E7500 ModelClassType SupportCharaUpgradingArgument SupportCharaUpgradingArgument SupportCharaUpgradingArgument Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x028), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0246660CDE30 0x28 TitleView                   ( 0001865EA1D0 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.View                                      = GetObject<ISupportCharaUpgradingView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ISupportCharaUpgradingView.FromPointer); // 0246660CDE50 0x30 View                        ( 000186668A40 ModelClassType ISupportCharaUpgradingView ISupportCharaUpgradingView ISupportCharaUpgradingView Pointer )
            value.StatusView                                = GetObject<ISupportCharaStatusView>(new IntPtr(p + 0x038), ReversePrism.DataModels.ISupportCharaStatusView.FromPointer); // 0246660CDE70 0x38 StatusView                  ( 0001866678F0 ModelClassType ISupportCharaStatusView ISupportCharaStatusView ISupportCharaStatusView Pointer )
            value.TrainingView                              = GetObject<ISupportCharaTrainingView>(new IntPtr(p + 0x040), ReversePrism.DataModels.ISupportCharaTrainingView.FromPointer); // 0246660CDE90 0x40 TrainingView                ( 000186667DF0 ModelClassType ISupportCharaTrainingView ISupportCharaTrainingView ISupportCharaTrainingView Pointer )
            value.MasterTrainingView                        = GetObject<ISupportCharaMasterTrainingView>(new IntPtr(p + 0x048), ReversePrism.DataModels.ISupportCharaMasterTrainingView.FromPointer); // 0246660CDEB0 0x48 MasterTrainingView          ( 000186667000 ModelClassType ISupportCharaMasterTrainingView ISupportCharaMasterTrainingView ISupportCharaMasterTrainingView Pointer )
            value.SCharaDetailPopupViewFactory              = GetObject<ISCharaDetailPopupViewFactory>(new IntPtr(p + 0x050), ReversePrism.DataModels.ISCharaDetailPopupViewFactory.FromPointer); // 0246660CDED0 0x50 SCharaDetailPopupViewFactory ( 000186622C10 ModelClassType ISCharaDetailPopupViewFactory ISCharaDetailPopupViewFactory ISCharaDetailPopupViewFactory Pointer )
            value.CommonSequencerContainer                  = GetObject<ICommonSequencerContainer>(new IntPtr(p + 0x078), ReversePrism.DataModels.ICommonSequencerContainer.FromPointer); // 0246660CDF70 0x78 CommonSequencerContainer    ( 0001867347C0 ModelClassType ICommonSequencerContainer ICommonSequencerContainer ICommonSequencerContainer Pointer )
            value.MasterData                                = GetObject<MasterData>(new IntPtr(p + 0x080), ReversePrism.DataModels.MasterData.FromPointer); // 0246660CDF90 0x80 MasterData                  ( 00018660B7A0 ModelClassType MasterData MasterData MasterData Pointer )
            value.ProductService                            = GetObject<ProductService>(new IntPtr(p + 0x088), ReversePrism.DataModels.ProductService.FromPointer); // 0246660CDFB0 0x88 ProductService              ( 0001865A4890 ModelClassType ProductService ProductService ProductService Pointer )
            value.TargetSC                                  = GetObject<ISupportCharacterStatus>(new IntPtr(p + 0x090), ReversePrism.DataModels.ISupportCharacterStatus.FromPointer); // 0246660CDFD0 0x90 TargetSC                    ( 000186669B50 ModelClassType ISupportCharacterStatus ISupportCharacterStatus ISupportCharacterStatus Pointer )
            value.Calculator                                = GetObject<CalcLvExp>(new IntPtr(p + 0x098), ReversePrism.DataModels.CalcLvExp.FromPointer); // 0246660CDFF0 0x98 Calculator                  ( 000186523A70 ModelClassType CalcLvExp CalcLvExp CalcLvExp Pointer )
            value.StatusViewModel                           = GetObject<SupportCharaStatusViewModel>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.SupportCharaStatusViewModel.FromPointer); // 0246660CE010 0xA0 StatusViewModel             ( 0001865E3AF0 ModelClassType SupportCharaStatusViewModel SupportCharaStatusViewModel SupportCharaStatusViewModel Pointer )
            value.TrainingViewModel                         = GetObject<SupportCharaTrainingViewModel>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.SupportCharaTrainingViewModel.FromPointer); // 0246660CE030 0xA8 TrainingViewModel           ( 0001865E58C0 ModelClassType SupportCharaTrainingViewModel SupportCharaTrainingViewModel SupportCharaTrainingViewModel Pointer )
            value.MasterTrainingViewModel                   = GetObject<SupportCharaMasterTrainingViewModel>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.SupportCharaMasterTrainingViewModel.FromPointer); // 0246660CE050 0xB0 MasterTrainingViewModel     ( 0001865E10E0 ModelClassType SupportCharaMasterTrainingViewModel SupportCharaMasterTrainingViewModel SupportCharaMasterTrainingViewModel Pointer )
            value.LvUpVoiceMotion                           = GetObject<MstOutgameVoiceMotion>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.MstOutgameVoiceMotion.FromPointer); // 0246660CE070 0xB8 LvUpVoiceMotion             ( 0001866264F0 ModelClassType MstOutgameVoiceMotion MstOutgameVoiceMotion MstOutgameVoiceMotion Pointer )
            value.DefaultTab                                = (SupportIdolUpgradeTab)GetInt32(new IntPtr(p + 0x0C0)); // 0246660CE090 0xC0 DefaultTab                  ( 0001865F2C70 ModelEnumType SupportIdolUpgradeTab SupportIdolUpgradeTab SupportIdolUpgradeTab Int32 )
            value.ProduceAdvStatusList                      = GetObjectList<IProduceAdvStatus>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.IProduceAdvStatus.FromPointer); // 0246660CE0B0 0xC8 ProduceAdvStatusList        ( 000185D05518 ModelClassListType IReadOnlyList`1<IProduceAdvStatus> IReadOnlyList`1<IProduceAdvStatus> List<IProduceAdvStatus> Pointer )

            return value;
        }
    }
}
