using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GashaMultilingualAddress                 string IL2CPP_TYPE_STRING
    // 078 GoTop                                    ModelClassType GameObject GameObject GameObject Pointer
    // 080 GoResult                                 ModelClassType GameObject GameObject GameObject Pointer
    // 088 GashaRatesPopupCaller                    ModelClassType GashaRatesPopupCaller GashaRatesPopupCaller GashaRatesPopupCaller Pointer
    // 090 GashaBonusPopupCaller                    ModelClassType GashaBonusPopupCaller GashaBonusPopupCaller GashaBonusPopupCaller Pointer
    // 098 GashaBonusAcquisitionPopupCaller         ModelClassType GashaBonusAcquisitionPopupCaller GashaBonusAcquisitionPopupCaller GashaBonusAcquisitionPopupCaller Pointer
    // 0A0 GashaPrismGaugePopupCaller               ModelClassType GashaPrismGaugePopupCaller GashaPrismGaugePopupCaller GashaPrismGaugePopupCaller Pointer
    // 0A8 GashaPrismGaugeProgressPopupCaller       ModelClassType GashaPrismGaugeProgressPopupCaller GashaPrismGaugeProgressPopupCaller GashaPrismGaugeProgressPopupCaller Pointer
    // 0B0 GashaPrismGaugeGetRewardPopupCaller      ModelClassType GashaPrismGaugeGetRewardPopupCaller GashaPrismGaugeGetRewardPopupCaller GashaPrismGaugeGetRewardPopupCaller Pointer
    // 0B8 GashaExchangeListPopupCaller             ModelClassType GashaExchangeListPopupCaller GashaExchangeListPopupCaller GashaExchangeListPopupCaller Pointer
    // 0C0 GashaExchangeConfirmationPopupCaller     ModelClassType GashaExchangeConfirmationPopupCaller GashaExchangeConfirmationPopupCaller GashaExchangeConfirmationPopupCaller Pointer
    // 0C8 GashaExchangeExpiryDateConversionPopupCaller ModelClassType GashaExchangeExpiryDateConversionPopupCaller GashaExchangeExpiryDateConversionPopupCaller GashaExchangeExpiryDateConversionPopupCaller Pointer
    // 0D0 StepUpGashaRatesPopupCaller              ModelClassType StepUpGashaRatesPopupCaller StepUpGashaRatesPopupCaller StepUpGashaRatesPopupCaller Pointer
    // 0D8 GashaSequence                            ModelClassType GashaSequenceDirection GashaSequenceDirection GashaSequenceDirection Pointer
    // 0E0 HelpPopupCaller                          ModelClassType HelpPopupCaller HelpPopupCaller HelpPopupCaller Pointer
    // 0E8 ExchangeCharacterEffectCaller            ModelClassType GashaExchangeCharacterEffectCaller GashaExchangeCharacterEffectCaller GashaExchangeCharacterEffectCaller Pointer
    // 0F0 ReviewPopupCaller                        ModelClassType AppReviewPopupCaller AppReviewPopupCaller AppReviewPopupCaller Pointer
    // 0F8 GashaDetailPopupCaller                   ModelClassType GashaDetailPopupCaller GashaDetailPopupCaller GashaDetailPopupCaller Pointer
    // 100 GashaCostumePopupCaller                  ModelClassType GashaCostumePopupCaller GashaCostumePopupCaller GashaCostumePopupCaller Pointer
    // 108 GashaHistoryPopupCaller                  ModelClassType GashaHistoryPopupCaller GashaHistoryPopupCaller GashaHistoryPopupCaller Pointer
    // 110 GashaHistoryDetailPopupCaller            ModelClassType GashaHistoryDetailPopupCaller GashaHistoryDetailPopupCaller GashaHistoryDetailPopupCaller Pointer
    // 118 GashaConfirmationPopupCaller             ModelClassType GashaConfirmationPopupCaller GashaConfirmationPopupCaller GashaConfirmationPopupCaller Pointer
    // 120 GashaTicketConfirmationPopupCaller       ModelClassType GashaTicketConfirmationPopupCaller GashaTicketConfirmationPopupCaller GashaTicketConfirmationPopupCaller Pointer
    // 128 ViewTop                                  ModelClassType GashaTopView GashaTopView GashaTopView Pointer
    // 130 ViewResult                               ModelClassType GashaResultView GashaResultView GashaResultView Pointer
    // 138 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 140 Model                                    ModelClassType GashaModel GashaModel GashaModel Pointer
    // 148 LimitedSaleViewModel                     ModelClassType ILimitedSaleViewModelForLegacy ILimitedSaleViewModelForLegacy ILimitedSaleViewModelForLegacy Pointer
    // 150 gashaRatesPopupViewModels                Dictionary`2<string, GashaRatesPopupViewModel> IL2CPP_TYPE_GENERICINST
    // 158 stepUpGashaRatesPopupViewModels          Dictionary`2<string, List`1<StepUpGashaRatesPopupViewModel>> IL2CPP_TYPE_GENERICINST
    // 160 IsFadeInEnd                              ModelPrimitiveType bool bool bool Bool
    // 168 SequenceSoundResources                   ModelClassType MvCutSceneSoundResources MvCutSceneSoundResources MvCutSceneSoundResources Pointer
    // 170 DownloadUiHide                           ModelClassType HideScope HideScope HideScope Pointer
    // 178 BackgroundSuppressDisposable             ModelClassType IDisposable IDisposable IDisposable Pointer
    // 180 BackKeyDisposable                        ModelClassType IDisposable IDisposable IDisposable Pointer
    // 188 SaleUpdateDisposables                    ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 190 IsShowReview                             ModelPrimitiveType bool bool bool Bool
    // 198 TargetResourceId                         ModelPrimitiveType string string string String
    // 1A0 InitCostumePopupOpenGashaId              ModelPrimitiveType string string string String
    // 1A8 LimitedSaleViewModelGenerator            ModelClassType ILimitedSaleViewModelGenerator ILimitedSaleViewModelGenerator ILimitedSaleViewModelGenerator Pointer
    public partial class GashaPresenter : DataModel
    {
        public GameObject?                              GoTop                                   { get; set; }
        public GameObject?                              GoResult                                { get; set; }
        public GashaRatesPopupCaller?                   GashaRatesPopupCaller                   { get; set; }
        public GashaBonusPopupCaller?                   GashaBonusPopupCaller                   { get; set; }
        public GashaBonusAcquisitionPopupCaller?        GashaBonusAcquisitionPopupCaller        { get; set; }
        public GashaPrismGaugePopupCaller?              GashaPrismGaugePopupCaller              { get; set; }
        public GashaPrismGaugeProgressPopupCaller?      GashaPrismGaugeProgressPopupCaller      { get; set; }
        public GashaPrismGaugeGetRewardPopupCaller?     GashaPrismGaugeGetRewardPopupCaller     { get; set; }
        public GashaExchangeListPopupCaller?            GashaExchangeListPopupCaller            { get; set; }
        public GashaExchangeConfirmationPopupCaller?    GashaExchangeConfirmationPopupCaller    { get; set; }
        public GashaExchangeExpiryDateConversionPopupCaller? GashaExchangeExpiryDateConversionPopupCaller { get; set; }
        public StepUpGashaRatesPopupCaller?             StepUpGashaRatesPopupCaller             { get; set; }
        public GashaSequenceDirection?                  GashaSequence                           { get; set; }
        public HelpPopupCaller?                         HelpPopupCaller                         { get; set; }
        public GashaExchangeCharacterEffectCaller?      ExchangeCharacterEffectCaller           { get; set; }
        public AppReviewPopupCaller?                    ReviewPopupCaller                       { get; set; }
        public GashaDetailPopupCaller?                  GashaDetailPopupCaller                  { get; set; }
        public GashaCostumePopupCaller?                 GashaCostumePopupCaller                 { get; set; }
        public GashaHistoryPopupCaller?                 GashaHistoryPopupCaller                 { get; set; }
        public GashaHistoryDetailPopupCaller?           GashaHistoryDetailPopupCaller           { get; set; }
        public GashaConfirmationPopupCaller?            GashaConfirmationPopupCaller            { get; set; }
        public GashaTicketConfirmationPopupCaller?      GashaTicketConfirmationPopupCaller      { get; set; }
        public GashaTopView?                            ViewTop                                 { get; set; }
        public GashaResultView?                         ViewResult                              { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public GashaModel?                              Model                                   { get; set; }
        public ILimitedSaleViewModelForLegacy?          LimitedSaleViewModel                    { get; set; }
        public bool                                     IsFadeInEnd                             { get; set; }
        public MvCutSceneSoundResources?                SequenceSoundResources                  { get; set; }
        public HideScope?                               DownloadUiHide                          { get; set; }
        public IDisposable?                             BackgroundSuppressDisposable            { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }
        public CompositeDisposable?                     SaleUpdateDisposables                   { get; set; }
        public bool                                     IsShowReview                            { get; set; }
        public string                                   TargetResourceId                        { get; set; }
        public string                                   InitCostumePopupOpenGashaId             { get; set; }
        public ILimitedSaleViewModelGenerator?          LimitedSaleViewModelGenerator           { get; set; }

        public static GashaPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaPresenter() { Pointer= p0 };

            value.GoTop                                     = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0x78 GoTop                       ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GoResult                                  = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 0x80 GoResult                    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GashaRatesPopupCaller                     = GetObject<GashaRatesPopupCaller>(new IntPtr(p + 0x088), ReversePrism.DataModels.GashaRatesPopupCaller.FromPointer); // 0x88 GashaRatesPopupCaller       ( ModelClassType GashaRatesPopupCaller GashaRatesPopupCaller GashaRatesPopupCaller Pointer )
            value.GashaBonusPopupCaller                     = GetObject<GashaBonusPopupCaller>(new IntPtr(p + 0x090), ReversePrism.DataModels.GashaBonusPopupCaller.FromPointer); // 0x90 GashaBonusPopupCaller       ( ModelClassType GashaBonusPopupCaller GashaBonusPopupCaller GashaBonusPopupCaller Pointer )
            value.GashaBonusAcquisitionPopupCaller          = GetObject<GashaBonusAcquisitionPopupCaller>(new IntPtr(p + 0x098), ReversePrism.DataModels.GashaBonusAcquisitionPopupCaller.FromPointer); // 0x98 GashaBonusAcquisitionPopupCaller ( ModelClassType GashaBonusAcquisitionPopupCaller GashaBonusAcquisitionPopupCaller GashaBonusAcquisitionPopupCaller Pointer )
            value.GashaPrismGaugePopupCaller                = GetObject<GashaPrismGaugePopupCaller>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GashaPrismGaugePopupCaller.FromPointer); // 0xA0 GashaPrismGaugePopupCaller  ( ModelClassType GashaPrismGaugePopupCaller GashaPrismGaugePopupCaller GashaPrismGaugePopupCaller Pointer )
            value.GashaPrismGaugeProgressPopupCaller        = GetObject<GashaPrismGaugeProgressPopupCaller>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.GashaPrismGaugeProgressPopupCaller.FromPointer); // 0xA8 GashaPrismGaugeProgressPopupCaller ( ModelClassType GashaPrismGaugeProgressPopupCaller GashaPrismGaugeProgressPopupCaller GashaPrismGaugeProgressPopupCaller Pointer )
            value.GashaPrismGaugeGetRewardPopupCaller       = GetObject<GashaPrismGaugeGetRewardPopupCaller>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.GashaPrismGaugeGetRewardPopupCaller.FromPointer); // 0xB0 GashaPrismGaugeGetRewardPopupCaller ( ModelClassType GashaPrismGaugeGetRewardPopupCaller GashaPrismGaugeGetRewardPopupCaller GashaPrismGaugeGetRewardPopupCaller Pointer )
            value.GashaExchangeListPopupCaller              = GetObject<GashaExchangeListPopupCaller>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.GashaExchangeListPopupCaller.FromPointer); // 0xB8 GashaExchangeListPopupCaller ( ModelClassType GashaExchangeListPopupCaller GashaExchangeListPopupCaller GashaExchangeListPopupCaller Pointer )
            value.GashaExchangeConfirmationPopupCaller      = GetObject<GashaExchangeConfirmationPopupCaller>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.GashaExchangeConfirmationPopupCaller.FromPointer); // 0xC0 GashaExchangeConfirmationPopupCaller ( ModelClassType GashaExchangeConfirmationPopupCaller GashaExchangeConfirmationPopupCaller GashaExchangeConfirmationPopupCaller Pointer )
            value.GashaExchangeExpiryDateConversionPopupCaller = GetObject<GashaExchangeExpiryDateConversionPopupCaller>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.GashaExchangeExpiryDateConversionPopupCaller.FromPointer); // 0xC8 GashaExchangeExpiryDateConversionPopupCaller ( ModelClassType GashaExchangeExpiryDateConversionPopupCaller GashaExchangeExpiryDateConversionPopupCaller GashaExchangeExpiryDateConversionPopupCaller Pointer )
            value.StepUpGashaRatesPopupCaller               = GetObject<StepUpGashaRatesPopupCaller>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.StepUpGashaRatesPopupCaller.FromPointer); // 0xD0 StepUpGashaRatesPopupCaller ( ModelClassType StepUpGashaRatesPopupCaller StepUpGashaRatesPopupCaller StepUpGashaRatesPopupCaller Pointer )
            value.GashaSequence                             = GetObject<GashaSequenceDirection>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.GashaSequenceDirection.FromPointer); // 0xD8 GashaSequence               ( ModelClassType GashaSequenceDirection GashaSequenceDirection GashaSequenceDirection Pointer )
            value.HelpPopupCaller                           = GetObject<HelpPopupCaller>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.HelpPopupCaller.FromPointer); // 0xE0 HelpPopupCaller             ( ModelClassType HelpPopupCaller HelpPopupCaller HelpPopupCaller Pointer )
            value.ExchangeCharacterEffectCaller             = GetObject<GashaExchangeCharacterEffectCaller>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.GashaExchangeCharacterEffectCaller.FromPointer); // 0xE8 ExchangeCharacterEffectCaller ( ModelClassType GashaExchangeCharacterEffectCaller GashaExchangeCharacterEffectCaller GashaExchangeCharacterEffectCaller Pointer )
            value.ReviewPopupCaller                         = GetObject<AppReviewPopupCaller>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.AppReviewPopupCaller.FromPointer); // 0xF0 ReviewPopupCaller           ( ModelClassType AppReviewPopupCaller AppReviewPopupCaller AppReviewPopupCaller Pointer )
            value.GashaDetailPopupCaller                    = GetObject<GashaDetailPopupCaller>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.GashaDetailPopupCaller.FromPointer); // 0xF8 GashaDetailPopupCaller      ( ModelClassType GashaDetailPopupCaller GashaDetailPopupCaller GashaDetailPopupCaller Pointer )
            value.GashaCostumePopupCaller                   = GetObject<GashaCostumePopupCaller>(new IntPtr(p + 0x100), ReversePrism.DataModels.GashaCostumePopupCaller.FromPointer); // 0x100 GashaCostumePopupCaller     ( ModelClassType GashaCostumePopupCaller GashaCostumePopupCaller GashaCostumePopupCaller Pointer )
            value.GashaHistoryPopupCaller                   = GetObject<GashaHistoryPopupCaller>(new IntPtr(p + 0x108), ReversePrism.DataModels.GashaHistoryPopupCaller.FromPointer); // 0x108 GashaHistoryPopupCaller     ( ModelClassType GashaHistoryPopupCaller GashaHistoryPopupCaller GashaHistoryPopupCaller Pointer )
            value.GashaHistoryDetailPopupCaller             = GetObject<GashaHistoryDetailPopupCaller>(new IntPtr(p + 0x110), ReversePrism.DataModels.GashaHistoryDetailPopupCaller.FromPointer); // 0x110 GashaHistoryDetailPopupCaller ( ModelClassType GashaHistoryDetailPopupCaller GashaHistoryDetailPopupCaller GashaHistoryDetailPopupCaller Pointer )
            value.GashaConfirmationPopupCaller              = GetObject<GashaConfirmationPopupCaller>(new IntPtr(p + 0x118), ReversePrism.DataModels.GashaConfirmationPopupCaller.FromPointer); // 0x118 GashaConfirmationPopupCaller ( ModelClassType GashaConfirmationPopupCaller GashaConfirmationPopupCaller GashaConfirmationPopupCaller Pointer )
            value.GashaTicketConfirmationPopupCaller        = GetObject<GashaTicketConfirmationPopupCaller>(new IntPtr(p + 0x120), ReversePrism.DataModels.GashaTicketConfirmationPopupCaller.FromPointer); // 0x120 GashaTicketConfirmationPopupCaller ( ModelClassType GashaTicketConfirmationPopupCaller GashaTicketConfirmationPopupCaller GashaTicketConfirmationPopupCaller Pointer )
            value.ViewTop                                   = GetObject<GashaTopView>(new IntPtr(p + 0x128), ReversePrism.DataModels.GashaTopView.FromPointer); // 0x128 ViewTop                     ( ModelClassType GashaTopView GashaTopView GashaTopView Pointer )
            value.ViewResult                                = GetObject<GashaResultView>(new IntPtr(p + 0x130), ReversePrism.DataModels.GashaResultView.FromPointer); // 0x130 ViewResult                  ( ModelClassType GashaResultView GashaResultView GashaResultView Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x138), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x138 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Model                                     = GetObject<GashaModel>(new IntPtr(p + 0x140), ReversePrism.DataModels.GashaModel.FromPointer); // 0x140 Model                       ( ModelClassType GashaModel GashaModel GashaModel Pointer )
            value.LimitedSaleViewModel                      = GetObject<ILimitedSaleViewModelForLegacy>(new IntPtr(p + 0x148), ReversePrism.DataModels.ILimitedSaleViewModelForLegacy.FromPointer); // 0x148 LimitedSaleViewModel        ( ModelClassType ILimitedSaleViewModelForLegacy ILimitedSaleViewModelForLegacy ILimitedSaleViewModelForLegacy Pointer )
            value.IsFadeInEnd                               = GetBool(new IntPtr(p + 0x160)); // 0x160 IsFadeInEnd                 ( ModelPrimitiveType bool bool bool Bool )
            value.SequenceSoundResources                    = GetObject<MvCutSceneSoundResources>(new IntPtr(p + 0x168), ReversePrism.DataModels.MvCutSceneSoundResources.FromPointer); // 0x168 SequenceSoundResources      ( ModelClassType MvCutSceneSoundResources MvCutSceneSoundResources MvCutSceneSoundResources Pointer )
            value.DownloadUiHide                            = GetObject<HideScope>(new IntPtr(p + 0x170), ReversePrism.DataModels.HideScope.FromPointer); // 0x170 DownloadUiHide              ( ModelClassType HideScope HideScope HideScope Pointer )
            value.BackgroundSuppressDisposable              = GetObject<IDisposable>(new IntPtr(p + 0x178), ReversePrism.DataModels.IDisposable.FromPointer); // 0x178 BackgroundSuppressDisposable ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x180), ReversePrism.DataModels.IDisposable.FromPointer); // 0x180 BackKeyDisposable           ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.SaleUpdateDisposables                     = GetObject<CompositeDisposable>(new IntPtr(p + 0x188), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x188 SaleUpdateDisposables       ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.IsShowReview                              = GetBool(new IntPtr(p + 0x190)); // 0x190 IsShowReview                ( ModelPrimitiveType bool bool bool Bool )
            value.TargetResourceId                          = GetString(new IntPtr(p + 0x198)); // 0x198 TargetResourceId            ( ModelPrimitiveType string string string String )
            value.InitCostumePopupOpenGashaId               = GetString(new IntPtr(p + 0x1A0)); // 0x1A0 InitCostumePopupOpenGashaId ( ModelPrimitiveType string string string String )
            value.LimitedSaleViewModelGenerator             = GetObject<ILimitedSaleViewModelGenerator>(new IntPtr(p + 0x1A8), ReversePrism.DataModels.ILimitedSaleViewModelGenerator.FromPointer); // 0x1A8 LimitedSaleViewModelGenerator ( ModelClassType ILimitedSaleViewModelGenerator ILimitedSaleViewModelGenerator ILimitedSaleViewModelGenerator Pointer )

            return value;
        }
    }
}
