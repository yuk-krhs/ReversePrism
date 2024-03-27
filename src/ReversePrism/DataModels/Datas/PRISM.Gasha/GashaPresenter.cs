using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GashaMultilingualAddress                 string IL2CPP_TYPE_STRING
    // 080 GoTop                                    0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 088 GoResult                                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 090 GashaRatesPopupCaller                    000186614080 ModelClassType GashaRatesPopupCaller GashaRatesPopupCaller GashaRatesPopupCaller Pointer
    // 098 GashaBonusPopupCaller                    0001865F1170 ModelClassType GashaBonusPopupCaller GashaBonusPopupCaller GashaBonusPopupCaller Pointer
    // 0A0 GashaBonusAcquisitionPopupCaller         0001865F05F0 ModelClassType GashaBonusAcquisitionPopupCaller GashaBonusAcquisitionPopupCaller GashaBonusAcquisitionPopupCaller Pointer
    // 0A8 GashaPrismGaugePopupCaller               00018660DF20 ModelClassType GashaPrismGaugePopupCaller GashaPrismGaugePopupCaller GashaPrismGaugePopupCaller Pointer
    // 0B0 GashaPrismGaugeProgressPopupCaller       00018660EF40 ModelClassType GashaPrismGaugeProgressPopupCaller GashaPrismGaugeProgressPopupCaller GashaPrismGaugeProgressPopupCaller Pointer
    // 0B8 GashaPrismGaugeGetRewardPopupCaller      00018660D300 ModelClassType GashaPrismGaugeGetRewardPopupCaller GashaPrismGaugeGetRewardPopupCaller GashaPrismGaugeGetRewardPopupCaller Pointer
    // 0C0 GashaExchangeListPopupCaller             0001866013F0 ModelClassType GashaExchangeListPopupCaller GashaExchangeListPopupCaller GashaExchangeListPopupCaller Pointer
    // 0C8 GashaExchangeConfirmationPopupCaller     0001865FD970 ModelClassType GashaExchangeConfirmationPopupCaller GashaExchangeConfirmationPopupCaller GashaExchangeConfirmationPopupCaller Pointer
    // 0D0 GashaExchangeExpiryDateConversionPopupCaller 0001865FEA00 ModelClassType GashaExchangeExpiryDateConversionPopupCaller GashaExchangeExpiryDateConversionPopupCaller GashaExchangeExpiryDateConversionPopupCaller Pointer
    // 0D8 StepUpGashaRatesPopupCaller              000186589E20 ModelClassType StepUpGashaRatesPopupCaller StepUpGashaRatesPopupCaller StepUpGashaRatesPopupCaller Pointer
    // 0E0 GashaSequence                            000186619D00 ModelClassType GashaSequenceDirection GashaSequenceDirection GashaSequenceDirection Pointer
    // 0E8 HelpPopupCaller                          0001866B1260 ModelClassType HelpPopupCaller HelpPopupCaller HelpPopupCaller Pointer
    // 0F0 ExchangeCharacterEffectCaller            0001865FCEF0 ModelClassType GashaExchangeCharacterEffectOverlayCaller GashaExchangeCharacterEffectOverlayCaller GashaExchangeCharacterEffectOverlayCaller Pointer
    // 0F8 ReviewPopupCaller                        0001866C9D60 ModelClassType AppReviewPopupCaller AppReviewPopupCaller AppReviewPopupCaller Pointer
    // 100 GashaDetailPopupCaller                   0001865F7F40 ModelClassType GashaDetailPopupCaller GashaDetailPopupCaller GashaDetailPopupCaller Pointer
    // 108 GashaCostumePopupCaller                  0001865F5790 ModelClassType GashaCostumePopupCaller GashaCostumePopupCaller GashaCostumePopupCaller Pointer
    // 110 PIdolDetailPopupCaller                   000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer
    // 118 CostumeDetailPopupCaller                 00018662B0A0 ModelClassType CostumeDetailPopupCaller CostumeDetailPopupCaller CostumeDetailPopupCaller Pointer
    // 120 ViewTop                                  000186620D60 ModelClassType GashaTopView GashaTopView GashaTopView Pointer
    // 128 ViewResult                               000186616B40 ModelClassType GashaResultView GashaResultView GashaResultView Pointer
    // 130 Cts                                      0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 138 Model                                    0001866080D0 ModelClassType GashaModel GashaModel GashaModel Pointer
    // 140 LimitedSaleViewModel                     000186590880 ModelClassType ILimitedSaleViewModelForLegacy ILimitedSaleViewModelForLegacy ILimitedSaleViewModelForLegacy Pointer
    // 148 stepUpGashaRatesPopupViewModels          Dictionary`2<string, List`1<StepUpGashaRatesPopupViewModel>> IL2CPP_TYPE_GENERICINST
    // 150 IsFadeInEnd                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 158 SequenceSoundResources                   000186677C40 ModelClassType MvCutSceneSoundResources MvCutSceneSoundResources MvCutSceneSoundResources Pointer
    // 160 DownloadUiHide                           0001866BF4C0 ModelClassType HideScope HideScope HideScope Pointer
    // 168 BackgroundSuppressDisposable             0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 170 BackKeyDisposable                        0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 178 SaleUpdateDisposables                    0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 180 IsShowReview                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 188 TargetResourceId                         000186671910 ModelPrimitiveType string string string String
    // 190 InitCostumePopupOpenGashaId              000186671910 ModelPrimitiveType string string string String
    // 198 LimitedSaleViewModelGenerator            000186590FB0 ModelClassType ILimitedSaleViewModelGenerator ILimitedSaleViewModelGenerator ILimitedSaleViewModelGenerator Pointer
    public partial class GashaPresenter
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
        public GashaExchangeCharacterEffectOverlayCaller? ExchangeCharacterEffectCaller           { get; set; }
        public AppReviewPopupCaller?                    ReviewPopupCaller                       { get; set; }
        public GashaDetailPopupCaller?                  GashaDetailPopupCaller                  { get; set; }
        public GashaCostumePopupCaller?                 GashaCostumePopupCaller                 { get; set; }
        public PIdolDetailPopupCaller?                  PIdolDetailPopupCaller                  { get; set; }
        public CostumeDetailPopupCaller?                CostumeDetailPopupCaller                { get; set; }
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
            var value   = new GashaPresenter();

            value.GoTop                                     = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 0270D536B730 0x80 GoTop                       ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoResult                                  = GetObject<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 0270D536B750 0x88 GoResult                    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GashaRatesPopupCaller                     = GetObject<GashaRatesPopupCaller>(new IntPtr(p + 0x090), ReversePrism.DataModels.GashaRatesPopupCaller.FromPointer); // 0270D536B770 0x90 GashaRatesPopupCaller       ( 000186614080 ModelClassType GashaRatesPopupCaller GashaRatesPopupCaller GashaRatesPopupCaller Pointer )
            value.GashaBonusPopupCaller                     = GetObject<GashaBonusPopupCaller>(new IntPtr(p + 0x098), ReversePrism.DataModels.GashaBonusPopupCaller.FromPointer); // 0270D536B790 0x98 GashaBonusPopupCaller       ( 0001865F1170 ModelClassType GashaBonusPopupCaller GashaBonusPopupCaller GashaBonusPopupCaller Pointer )
            value.GashaBonusAcquisitionPopupCaller          = GetObject<GashaBonusAcquisitionPopupCaller>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GashaBonusAcquisitionPopupCaller.FromPointer); // 0270D536B7B0 0xA0 GashaBonusAcquisitionPopupCaller ( 0001865F05F0 ModelClassType GashaBonusAcquisitionPopupCaller GashaBonusAcquisitionPopupCaller GashaBonusAcquisitionPopupCaller Pointer )
            value.GashaPrismGaugePopupCaller                = GetObject<GashaPrismGaugePopupCaller>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.GashaPrismGaugePopupCaller.FromPointer); // 0270D536B7D0 0xA8 GashaPrismGaugePopupCaller  ( 00018660DF20 ModelClassType GashaPrismGaugePopupCaller GashaPrismGaugePopupCaller GashaPrismGaugePopupCaller Pointer )
            value.GashaPrismGaugeProgressPopupCaller        = GetObject<GashaPrismGaugeProgressPopupCaller>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.GashaPrismGaugeProgressPopupCaller.FromPointer); // 0270D536B7F0 0xB0 GashaPrismGaugeProgressPopupCaller ( 00018660EF40 ModelClassType GashaPrismGaugeProgressPopupCaller GashaPrismGaugeProgressPopupCaller GashaPrismGaugeProgressPopupCaller Pointer )
            value.GashaPrismGaugeGetRewardPopupCaller       = GetObject<GashaPrismGaugeGetRewardPopupCaller>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.GashaPrismGaugeGetRewardPopupCaller.FromPointer); // 0270D536B810 0xB8 GashaPrismGaugeGetRewardPopupCaller ( 00018660D300 ModelClassType GashaPrismGaugeGetRewardPopupCaller GashaPrismGaugeGetRewardPopupCaller GashaPrismGaugeGetRewardPopupCaller Pointer )
            value.GashaExchangeListPopupCaller              = GetObject<GashaExchangeListPopupCaller>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.GashaExchangeListPopupCaller.FromPointer); // 0270D536B830 0xC0 GashaExchangeListPopupCaller ( 0001866013F0 ModelClassType GashaExchangeListPopupCaller GashaExchangeListPopupCaller GashaExchangeListPopupCaller Pointer )
            value.GashaExchangeConfirmationPopupCaller      = GetObject<GashaExchangeConfirmationPopupCaller>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.GashaExchangeConfirmationPopupCaller.FromPointer); // 0270D536B850 0xC8 GashaExchangeConfirmationPopupCaller ( 0001865FD970 ModelClassType GashaExchangeConfirmationPopupCaller GashaExchangeConfirmationPopupCaller GashaExchangeConfirmationPopupCaller Pointer )
            value.GashaExchangeExpiryDateConversionPopupCaller = GetObject<GashaExchangeExpiryDateConversionPopupCaller>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.GashaExchangeExpiryDateConversionPopupCaller.FromPointer); // 0270D536B870 0xD0 GashaExchangeExpiryDateConversionPopupCaller ( 0001865FEA00 ModelClassType GashaExchangeExpiryDateConversionPopupCaller GashaExchangeExpiryDateConversionPopupCaller GashaExchangeExpiryDateConversionPopupCaller Pointer )
            value.StepUpGashaRatesPopupCaller               = GetObject<StepUpGashaRatesPopupCaller>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.StepUpGashaRatesPopupCaller.FromPointer); // 0270D536B890 0xD8 StepUpGashaRatesPopupCaller ( 000186589E20 ModelClassType StepUpGashaRatesPopupCaller StepUpGashaRatesPopupCaller StepUpGashaRatesPopupCaller Pointer )
            value.GashaSequence                             = GetObject<GashaSequenceDirection>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.GashaSequenceDirection.FromPointer); // 0270D536B8B0 0xE0 GashaSequence               ( 000186619D00 ModelClassType GashaSequenceDirection GashaSequenceDirection GashaSequenceDirection Pointer )
            value.HelpPopupCaller                           = GetObject<HelpPopupCaller>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.HelpPopupCaller.FromPointer); // 0270D536B8D0 0xE8 HelpPopupCaller             ( 0001866B1260 ModelClassType HelpPopupCaller HelpPopupCaller HelpPopupCaller Pointer )
            value.ExchangeCharacterEffectCaller             = GetObject<GashaExchangeCharacterEffectOverlayCaller>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.GashaExchangeCharacterEffectOverlayCaller.FromPointer); // 0270D536B8F0 0xF0 ExchangeCharacterEffectCaller ( 0001865FCEF0 ModelClassType GashaExchangeCharacterEffectOverlayCaller GashaExchangeCharacterEffectOverlayCaller GashaExchangeCharacterEffectOverlayCaller Pointer )
            value.ReviewPopupCaller                         = GetObject<AppReviewPopupCaller>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.AppReviewPopupCaller.FromPointer); // 0270D536B910 0xF8 ReviewPopupCaller           ( 0001866C9D60 ModelClassType AppReviewPopupCaller AppReviewPopupCaller AppReviewPopupCaller Pointer )
            value.GashaDetailPopupCaller                    = GetObject<GashaDetailPopupCaller>(new IntPtr(p + 0x100), ReversePrism.DataModels.GashaDetailPopupCaller.FromPointer); // 0270D536B930 0x100 GashaDetailPopupCaller      ( 0001865F7F40 ModelClassType GashaDetailPopupCaller GashaDetailPopupCaller GashaDetailPopupCaller Pointer )
            value.GashaCostumePopupCaller                   = GetObject<GashaCostumePopupCaller>(new IntPtr(p + 0x108), ReversePrism.DataModels.GashaCostumePopupCaller.FromPointer); // 0270D536B950 0x108 GashaCostumePopupCaller     ( 0001865F5790 ModelClassType GashaCostumePopupCaller GashaCostumePopupCaller GashaCostumePopupCaller Pointer )
            value.PIdolDetailPopupCaller                    = GetObject<PIdolDetailPopupCaller>(new IntPtr(p + 0x110), ReversePrism.DataModels.PIdolDetailPopupCaller.FromPointer); // 0270D536B970 0x110 PIdolDetailPopupCaller      ( 000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer )
            value.CostumeDetailPopupCaller                  = GetObject<CostumeDetailPopupCaller>(new IntPtr(p + 0x118), ReversePrism.DataModels.CostumeDetailPopupCaller.FromPointer); // 0270D536B990 0x118 CostumeDetailPopupCaller    ( 00018662B0A0 ModelClassType CostumeDetailPopupCaller CostumeDetailPopupCaller CostumeDetailPopupCaller Pointer )
            value.ViewTop                                   = GetObject<GashaTopView>(new IntPtr(p + 0x120), ReversePrism.DataModels.GashaTopView.FromPointer); // 0270D536B9B0 0x120 ViewTop                     ( 000186620D60 ModelClassType GashaTopView GashaTopView GashaTopView Pointer )
            value.ViewResult                                = GetObject<GashaResultView>(new IntPtr(p + 0x128), ReversePrism.DataModels.GashaResultView.FromPointer); // 0270D536B9D0 0x128 ViewResult                  ( 000186616B40 ModelClassType GashaResultView GashaResultView GashaResultView Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x130), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D536B9F0 0x130 Cts                         ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Model                                     = GetObject<GashaModel>(new IntPtr(p + 0x138), ReversePrism.DataModels.GashaModel.FromPointer); // 0270D536BA10 0x138 Model                       ( 0001866080D0 ModelClassType GashaModel GashaModel GashaModel Pointer )
            value.LimitedSaleViewModel                      = GetObject<ILimitedSaleViewModelForLegacy>(new IntPtr(p + 0x140), ReversePrism.DataModels.ILimitedSaleViewModelForLegacy.FromPointer); // 0270D536BA30 0x140 LimitedSaleViewModel        ( 000186590880 ModelClassType ILimitedSaleViewModelForLegacy ILimitedSaleViewModelForLegacy ILimitedSaleViewModelForLegacy Pointer )
            value.IsFadeInEnd                               = GetBool(new IntPtr(p + 0x150)); // 0270D536BA70 0x150 IsFadeInEnd                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SequenceSoundResources                    = GetObject<MvCutSceneSoundResources>(new IntPtr(p + 0x158), ReversePrism.DataModels.MvCutSceneSoundResources.FromPointer); // 0270D536BA90 0x158 SequenceSoundResources      ( 000186677C40 ModelClassType MvCutSceneSoundResources MvCutSceneSoundResources MvCutSceneSoundResources Pointer )
            value.DownloadUiHide                            = GetObject<HideScope>(new IntPtr(p + 0x160), ReversePrism.DataModels.HideScope.FromPointer); // 0270D536BAB0 0x160 DownloadUiHide              ( 0001866BF4C0 ModelClassType HideScope HideScope HideScope Pointer )
            value.BackgroundSuppressDisposable              = GetObject<IDisposable>(new IntPtr(p + 0x168), ReversePrism.DataModels.IDisposable.FromPointer); // 0270D536BAD0 0x168 BackgroundSuppressDisposable ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x170), ReversePrism.DataModels.IDisposable.FromPointer); // 0270D536BAF0 0x170 BackKeyDisposable           ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.SaleUpdateDisposables                     = GetObject<CompositeDisposable>(new IntPtr(p + 0x178), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D536BB10 0x178 SaleUpdateDisposables       ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.IsShowReview                              = GetBool(new IntPtr(p + 0x180)); // 0270D536BB30 0x180 IsShowReview                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.TargetResourceId                          = GetString(new IntPtr(p + 0x188)); // 0270D536BB50 0x188 TargetResourceId            ( 000186671910 ModelPrimitiveType string string string String )
            value.InitCostumePopupOpenGashaId               = GetString(new IntPtr(p + 0x190)); // 0270D536BB70 0x190 InitCostumePopupOpenGashaId ( 000186671910 ModelPrimitiveType string string string String )
            value.LimitedSaleViewModelGenerator             = GetObject<ILimitedSaleViewModelGenerator>(new IntPtr(p + 0x198), ReversePrism.DataModels.ILimitedSaleViewModelGenerator.FromPointer); // 0270D536BB90 0x198 LimitedSaleViewModelGenerator ( 000186590FB0 ModelClassType ILimitedSaleViewModelGenerator ILimitedSaleViewModelGenerator ILimitedSaleViewModelGenerator Pointer )

            return value;
        }
    }
}
