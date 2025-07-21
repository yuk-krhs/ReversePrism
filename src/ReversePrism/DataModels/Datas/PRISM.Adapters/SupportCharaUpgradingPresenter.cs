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
    // 020 Argument                                 ModelClassType SupportCharaUpgradingArgument SupportCharaUpgradingArgument SupportCharaUpgradingArgument Pointer
    // 028 TitleView                                ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 030 View                                     ModelClassType ISupportCharaUpgradingView ISupportCharaUpgradingView ISupportCharaUpgradingView Pointer
    // 038 StatusView                               ModelClassType ISupportCharaStatusView ISupportCharaStatusView ISupportCharaStatusView Pointer
    // 040 TrainingView                             ModelClassType ISupportCharaTrainingView ISupportCharaTrainingView ISupportCharaTrainingView Pointer
    // 048 MasterTrainingView                       ModelClassType ISupportCharaMasterTrainingView ISupportCharaMasterTrainingView ISupportCharaMasterTrainingView Pointer
    // 050 MasterData                               ModelClassType MasterData MasterData MasterData Pointer
    // 058 TargetSC                                 ModelClassType ISupportCharacterStatus ISupportCharacterStatus ISupportCharacterStatus Pointer
    // 060 Calculator                               ModelClassType CalcLvExp CalcLvExp CalcLvExp Pointer
    // 068 StatusViewModel                          ModelClassType SupportCharaStatusViewModel SupportCharaStatusViewModel SupportCharaStatusViewModel Pointer
    // 070 TrainingViewModel                        ModelClassType SupportCharaTrainingViewModel SupportCharaTrainingViewModel SupportCharaTrainingViewModel Pointer
    // 078 MasterTrainingViewModel                  ModelClassType SupportCharaMasterTrainingViewModel SupportCharaMasterTrainingViewModel SupportCharaMasterTrainingViewModel Pointer
    // 080 LvUpVoiceMotion                          ModelClassType MstOutgameVoiceMotion MstOutgameVoiceMotion MstOutgameVoiceMotion Pointer
    // 088 DefaultTab                               ModelEnumType SupportIdolUpgradeTab SupportIdolUpgradeTab SupportIdolUpgradeTab Int32
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
        public MasterData?                              MasterData                              { get; set; }
        public ISupportCharacterStatus?                 TargetSC                                { get; set; }
        public CalcLvExp?                               Calculator                              { get; set; }
        public SupportCharaStatusViewModel?             StatusViewModel                         { get; set; }
        public SupportCharaTrainingViewModel?           TrainingViewModel                       { get; set; }
        public SupportCharaMasterTrainingViewModel?     MasterTrainingViewModel                 { get; set; }
        public MstOutgameVoiceMotion?                   LvUpVoiceMotion                         { get; set; }
        public SupportIdolUpgradeTab                    DefaultTab                              { get; set; }

        public static SupportCharaUpgradingPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharaUpgradingPresenter() { Pointer= p0 };

            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x010), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x10 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x18 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Argument                                  = GetObject<SupportCharaUpgradingArgument>(new IntPtr(p + 0x020), ReversePrism.DataModels.SupportCharaUpgradingArgument.FromPointer); // 0x20 Argument                    ( ModelClassType SupportCharaUpgradingArgument SupportCharaUpgradingArgument SupportCharaUpgradingArgument Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x028), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0x28 TitleView                   ( ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.View                                      = GetObject<ISupportCharaUpgradingView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ISupportCharaUpgradingView.FromPointer); // 0x30 View                        ( ModelClassType ISupportCharaUpgradingView ISupportCharaUpgradingView ISupportCharaUpgradingView Pointer )
            value.StatusView                                = GetObject<ISupportCharaStatusView>(new IntPtr(p + 0x038), ReversePrism.DataModels.ISupportCharaStatusView.FromPointer); // 0x38 StatusView                  ( ModelClassType ISupportCharaStatusView ISupportCharaStatusView ISupportCharaStatusView Pointer )
            value.TrainingView                              = GetObject<ISupportCharaTrainingView>(new IntPtr(p + 0x040), ReversePrism.DataModels.ISupportCharaTrainingView.FromPointer); // 0x40 TrainingView                ( ModelClassType ISupportCharaTrainingView ISupportCharaTrainingView ISupportCharaTrainingView Pointer )
            value.MasterTrainingView                        = GetObject<ISupportCharaMasterTrainingView>(new IntPtr(p + 0x048), ReversePrism.DataModels.ISupportCharaMasterTrainingView.FromPointer); // 0x48 MasterTrainingView          ( ModelClassType ISupportCharaMasterTrainingView ISupportCharaMasterTrainingView ISupportCharaMasterTrainingView Pointer )
            value.MasterData                                = GetObject<MasterData>(new IntPtr(p + 0x050), ReversePrism.DataModels.MasterData.FromPointer); // 0x50 MasterData                  ( ModelClassType MasterData MasterData MasterData Pointer )
            value.TargetSC                                  = GetObject<ISupportCharacterStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.ISupportCharacterStatus.FromPointer); // 0x58 TargetSC                    ( ModelClassType ISupportCharacterStatus ISupportCharacterStatus ISupportCharacterStatus Pointer )
            value.Calculator                                = GetObject<CalcLvExp>(new IntPtr(p + 0x060), ReversePrism.DataModels.CalcLvExp.FromPointer); // 0x60 Calculator                  ( ModelClassType CalcLvExp CalcLvExp CalcLvExp Pointer )
            value.StatusViewModel                           = GetObject<SupportCharaStatusViewModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.SupportCharaStatusViewModel.FromPointer); // 0x68 StatusViewModel             ( ModelClassType SupportCharaStatusViewModel SupportCharaStatusViewModel SupportCharaStatusViewModel Pointer )
            value.TrainingViewModel                         = GetObject<SupportCharaTrainingViewModel>(new IntPtr(p + 0x070), ReversePrism.DataModels.SupportCharaTrainingViewModel.FromPointer); // 0x70 TrainingViewModel           ( ModelClassType SupportCharaTrainingViewModel SupportCharaTrainingViewModel SupportCharaTrainingViewModel Pointer )
            value.MasterTrainingViewModel                   = GetObject<SupportCharaMasterTrainingViewModel>(new IntPtr(p + 0x078), ReversePrism.DataModels.SupportCharaMasterTrainingViewModel.FromPointer); // 0x78 MasterTrainingViewModel     ( ModelClassType SupportCharaMasterTrainingViewModel SupportCharaMasterTrainingViewModel SupportCharaMasterTrainingViewModel Pointer )
            value.LvUpVoiceMotion                           = GetObject<MstOutgameVoiceMotion>(new IntPtr(p + 0x080), ReversePrism.DataModels.MstOutgameVoiceMotion.FromPointer); // 0x80 LvUpVoiceMotion             ( ModelClassType MstOutgameVoiceMotion MstOutgameVoiceMotion MstOutgameVoiceMotion Pointer )
            value.DefaultTab                                = (SupportIdolUpgradeTab)GetInt32(new IntPtr(p + 0x088)); // 0x88 DefaultTab                  ( ModelEnumType SupportIdolUpgradeTab SupportIdolUpgradeTab SupportIdolUpgradeTab Int32 )

            return value;
        }
    }
}
