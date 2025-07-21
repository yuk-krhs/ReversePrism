using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GashaBannerCarousel                      ModelClassType GashaBannerCarousel GashaBannerCarousel GashaBannerCarousel Pointer
    // 028 MoviePlayer                              ModelClassType MoviePlayer MoviePlayer MoviePlayer Pointer
    // 030 BackgroundSwipeButton                    ModelClassType SwipeButton SwipeButton SwipeButton Pointer
    // 038 GashaNamePlate                           ModelClassType GashaNamePlateP GashaNamePlateP GashaNamePlateP Pointer
    // 040 TxtTokutei                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 GoGashaButton                            ModelClassType GameObject GameObject GameObject Pointer
    // 050 BtnTokutei                               ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 058 ImgLogo                                  ModelClassType Image Image Image Pointer
    // 060 TxtLimit                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 BtnDetails                               ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 070 BtnGashaRates                            ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 078 BtnMembers                               ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 080 BtnCostumes                              ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 088 BtnOmake                                 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 090 BtnHistory                               ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 098 TxtMsg                                   ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A0 ImgBackground                            ModelClassType Image Image Image Pointer
    // 0A8 AspectRatioFitterBackground              ModelClassType AspectRatioFitter AspectRatioFitter AspectRatioFitter Pointer
    // 0B0 ImgBackgroundNext                        ModelClassType Image Image Image Pointer
    // 0B8 AspectRatioFitterBackgroundNext          ModelClassType AspectRatioFitter AspectRatioFitter AspectRatioFitter Pointer
    // 0C0 ImgCarouselTouch                         ModelClassType Image Image Image Pointer
    // 0C8 CanvasGroupMiddle                        ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0D0 GoPrismGauge                             ModelClassType GameObject GameObject GameObject Pointer
    // 0D8 TxtPrismGaugePoint                       ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0E0 GaugeItemIcon                            ModelClassType RewardItem RewardItem RewardItem Pointer
    // 0E8 BtnPrismGauge                            ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 0F0 GoPrismGaugeDone                         ModelClassType GameObject GameObject GameObject Pointer
    // 0F8 GoExchangeRoot                           ModelClassType GameObject GameObject GameObject Pointer
    // 100 BtnExchange                              ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 108 TxtExchange                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 110 GoExchangebadge                          ModelClassType GameObject GameObject GameObject Pointer
    // 118 GashaTokenAreas                          ModelClassListType GashaTokenArea[] GashaTokenArea[] List<GashaTokenArea> Pointer
    // 120 JewelArea                                ModelClassType CmnCurrentJewel CmnCurrentJewel CmnCurrentJewel Pointer
    // 128 GashaStepListView                        ModelClassType GashaStepListView GashaStepListView GashaStepListView Pointer
    // 130 GoBtns                                   ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    // 138 CurrentGasha                             ModelClassType Gasha Gasha Gasha Pointer
    // 140 BackBtnDisposable                        ModelClassType IDisposable IDisposable IDisposable Pointer
    // 148 ChangeGashaCts                           ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 150 ChangeBannerCts                          ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 158 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 160 LastSelectIndex                          ModelPrimitiveType int int int Int32
    // 164 IsBackgroundReserve                      ModelPrimitiveType bool bool bool Bool
    // 168 GashaNewDic                              ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 170 BackgroundMovies                         ModelPrimitiveListType string[] string[] List<string> Pointer
    // 178 BackgroundMovieValues                    ModelPrimitiveListType string[] string[] List<string> Pointer
    // 180 BackgroundImages                         ModelPrimitiveListType string[] string[] List<string> Pointer
    // 188 PlayBackgroundIndex                      ModelPrimitiveType int int int Int32
    // 18C UpdateTime                               ModelPrimitiveType int int int Int32
    // 190 <OnClickGasha>k__BackingField            Action`2<string, string> IL2CPP_TYPE_GENERICINST
    // 198 <OnChangeBanner>k__BackingField          Action`2<string, string> IL2CPP_TYPE_GENERICINST
    // 1A0 <OnNeedMemberData>k__BackingField        Func`2<string, UniTask`1<IGetGashaMemberReply>> IL2CPP_TYPE_GENERICINST
    // 1A8 <OnNeedGashaDetail>k__BackingField       Func`3<string, IReadOnlyList`1<string>, UniTask`1<IGetGashaDetailReply>> IL2CPP_TYPE_GENERICINST
    // 1B0 <OnNeedGashaNotes>k__BackingField        Func`3<string, IReadOnlyList`1<string>, UniTask`1<IGetGashaNotesReply>> IL2CPP_TYPE_GENERICINST
    // 1B8 <OnNeedHistory>k__BackingField           Func`1<UniTask`1<IGetGashaHistoryListReply>> IL2CPP_TYPE_GENERICINST
    // 1C0 <OnRefreshNewData>k__BackingField        Func`1<List`1<string>> IL2CPP_TYPE_GENERICINST
    // 1C8 <OnSaveNewData>k__BackingField           Action`1<string> IL2CPP_TYPE_GENERICINST
    // 1D0 <OnNeedProductDetail>k__BackingField     Func`3<ProductType, int, UniTask`1<IGetProductDetailReply>> IL2CPP_TYPE_GENERICINST
    // 1D8 <OnNeedJewel>k__BackingField             Func`1<UniTask`1<Jewel>> IL2CPP_TYPE_GENERICINST
    public partial class GashaTopView : DataModel
    {
        public GashaBannerCarousel?                     GashaBannerCarousel                     { get; set; }
        public MoviePlayer?                             MoviePlayer                             { get; set; }
        public SwipeButton?                             BackgroundSwipeButton                   { get; set; }
        public GashaNamePlateP?                         GashaNamePlate                          { get; set; }
        public UITextMeshProUGUI?                       TxtTokutei                              { get; set; }
        public GameObject?                              GoGashaButton                           { get; set; }
        public ButtonBase?                              BtnTokutei                              { get; set; }
        public Image?                                   ImgLogo                                 { get; set; }
        public UITextMeshProUGUI?                       TxtLimit                                { get; set; }
        public ButtonBase?                              BtnDetails                              { get; set; }
        public ButtonBase?                              BtnGashaRates                           { get; set; }
        public ButtonBase?                              BtnMembers                              { get; set; }
        public ButtonBase?                              BtnCostumes                             { get; set; }
        public ButtonBase?                              BtnOmake                                { get; set; }
        public ButtonBase?                              BtnHistory                              { get; set; }
        public UITextMeshProUGUI?                       TxtMsg                                  { get; set; }
        public Image?                                   ImgBackground                           { get; set; }
        public AspectRatioFitter?                       AspectRatioFitterBackground             { get; set; }
        public Image?                                   ImgBackgroundNext                       { get; set; }
        public AspectRatioFitter?                       AspectRatioFitterBackgroundNext         { get; set; }
        public Image?                                   ImgCarouselTouch                        { get; set; }
        public CanvasGroup?                             CanvasGroupMiddle                       { get; set; }
        public GameObject?                              GoPrismGauge                            { get; set; }
        public UITextMeshProUGUI?                       TxtPrismGaugePoint                      { get; set; }
        public RewardItem?                              GaugeItemIcon                           { get; set; }
        public ButtonBase?                              BtnPrismGauge                           { get; set; }
        public GameObject?                              GoPrismGaugeDone                        { get; set; }
        public GameObject?                              GoExchangeRoot                          { get; set; }
        public ButtonBase?                              BtnExchange                             { get; set; }
        public UITextMeshProUGUI?                       TxtExchange                             { get; set; }
        public GameObject?                              GoExchangebadge                         { get; set; }
        public List<GashaTokenArea>?                    GashaTokenAreas                         { get; set; }
        public CmnCurrentJewel?                         JewelArea                               { get; set; }
        public GashaStepListView?                       GashaStepListView                       { get; set; }
        public List<GameObject>?                        GoBtns                                  { get; set; }
        public Gasha?                                   CurrentGasha                            { get; set; }
        public IDisposable?                             BackBtnDisposable                       { get; set; }
        public CancellationTokenSource?                 ChangeGashaCts                          { get; set; }
        public CancellationTokenSource?                 ChangeBannerCts                         { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public int                                      LastSelectIndex                         { get; set; }
        public bool                                     IsBackgroundReserve                     { get; set; }
        public List<string>?                            GashaNewDic                             { get; set; }
        public List<string>?                            BackgroundMovies                        { get; set; }
        public List<string>?                            BackgroundMovieValues                   { get; set; }
        public List<string>?                            BackgroundImages                        { get; set; }
        public int                                      PlayBackgroundIndex                     { get; set; }
        public int                                      UpdateTime                              { get; set; }

        public static GashaTopView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaTopView() { Pointer= p0 };

            value.GashaBannerCarousel                       = GetObject<GashaBannerCarousel>(new IntPtr(p + 0x020), ReversePrism.DataModels.GashaBannerCarousel.FromPointer); // 0x20 GashaBannerCarousel         ( ModelClassType GashaBannerCarousel GashaBannerCarousel GashaBannerCarousel Pointer )
            value.MoviePlayer                               = GetObject<MoviePlayer>(new IntPtr(p + 0x028), ReversePrism.DataModels.MoviePlayer.FromPointer); // 0x28 MoviePlayer                 ( ModelClassType MoviePlayer MoviePlayer MoviePlayer Pointer )
            value.BackgroundSwipeButton                     = GetObject<SwipeButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.SwipeButton.FromPointer); // 0x30 BackgroundSwipeButton       ( ModelClassType SwipeButton SwipeButton SwipeButton Pointer )
            value.GashaNamePlate                            = GetObject<GashaNamePlateP>(new IntPtr(p + 0x038), ReversePrism.DataModels.GashaNamePlateP.FromPointer); // 0x38 GashaNamePlate              ( ModelClassType GashaNamePlateP GashaNamePlateP GashaNamePlateP Pointer )
            value.TxtTokutei                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 TxtTokutei                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoGashaButton                             = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 GoGashaButton               ( ModelClassType GameObject GameObject GameObject Pointer )
            value.BtnTokutei                                = GetObject<ButtonBase>(new IntPtr(p + 0x050), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x50 BtnTokutei                  ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.ImgLogo                                   = GetObject<Image>(new IntPtr(p + 0x058), ReversePrism.DataModels.Image.FromPointer); // 0x58 ImgLogo                     ( ModelClassType Image Image Image Pointer )
            value.TxtLimit                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 TxtLimit                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnDetails                                = GetObject<ButtonBase>(new IntPtr(p + 0x068), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x68 BtnDetails                  ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.BtnGashaRates                             = GetObject<ButtonBase>(new IntPtr(p + 0x070), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x70 BtnGashaRates               ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.BtnMembers                                = GetObject<ButtonBase>(new IntPtr(p + 0x078), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x78 BtnMembers                  ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.BtnCostumes                               = GetObject<ButtonBase>(new IntPtr(p + 0x080), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x80 BtnCostumes                 ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.BtnOmake                                  = GetObject<ButtonBase>(new IntPtr(p + 0x088), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x88 BtnOmake                    ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.BtnHistory                                = GetObject<ButtonBase>(new IntPtr(p + 0x090), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x90 BtnHistory                  ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.TxtMsg                                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x098), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x98 TxtMsg                      ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ImgBackground                             = GetObject<Image>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Image.FromPointer); // 0xA0 ImgBackground               ( ModelClassType Image Image Image Pointer )
            value.AspectRatioFitterBackground               = GetObject<AspectRatioFitter>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.AspectRatioFitter.FromPointer); // 0xA8 AspectRatioFitterBackground ( ModelClassType AspectRatioFitter AspectRatioFitter AspectRatioFitter Pointer )
            value.ImgBackgroundNext                         = GetObject<Image>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Image.FromPointer); // 0xB0 ImgBackgroundNext           ( ModelClassType Image Image Image Pointer )
            value.AspectRatioFitterBackgroundNext           = GetObject<AspectRatioFitter>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.AspectRatioFitter.FromPointer); // 0xB8 AspectRatioFitterBackgroundNext ( ModelClassType AspectRatioFitter AspectRatioFitter AspectRatioFitter Pointer )
            value.ImgCarouselTouch                          = GetObject<Image>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.Image.FromPointer); // 0xC0 ImgCarouselTouch            ( ModelClassType Image Image Image Pointer )
            value.CanvasGroupMiddle                         = GetObject<CanvasGroup>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0xC8 CanvasGroupMiddle           ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.GoPrismGauge                              = GetObject<GameObject>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.GameObject.FromPointer); // 0xD0 GoPrismGauge                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TxtPrismGaugePoint                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xD8 TxtPrismGaugePoint          ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GaugeItemIcon                             = GetObject<RewardItem>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.RewardItem.FromPointer); // 0xE0 GaugeItemIcon               ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.BtnPrismGauge                             = GetObject<ButtonBase>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.ButtonBase.FromPointer); // 0xE8 BtnPrismGauge               ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.GoPrismGaugeDone                          = GetObject<GameObject>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.GameObject.FromPointer); // 0xF0 GoPrismGaugeDone            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GoExchangeRoot                            = GetObject<GameObject>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.GameObject.FromPointer); // 0xF8 GoExchangeRoot              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.BtnExchange                               = GetObject<ButtonBase>(new IntPtr(p + 0x100), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x100 BtnExchange                 ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.TxtExchange                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x108), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x108 TxtExchange                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoExchangebadge                           = GetObject<GameObject>(new IntPtr(p + 0x110), ReversePrism.DataModels.GameObject.FromPointer); // 0x110 GoExchangebadge             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GashaTokenAreas                           = GetObjectList<GashaTokenArea>(new IntPtr(p + 0x118), ReversePrism.DataModels.GashaTokenArea.FromPointer); // 0x118 GashaTokenAreas             ( ModelClassListType GashaTokenArea[] GashaTokenArea[] List<GashaTokenArea> Pointer )
            value.JewelArea                                 = GetObject<CmnCurrentJewel>(new IntPtr(p + 0x120), ReversePrism.DataModels.CmnCurrentJewel.FromPointer); // 0x120 JewelArea                   ( ModelClassType CmnCurrentJewel CmnCurrentJewel CmnCurrentJewel Pointer )
            value.GashaStepListView                         = GetObject<GashaStepListView>(new IntPtr(p + 0x128), ReversePrism.DataModels.GashaStepListView.FromPointer); // 0x128 GashaStepListView           ( ModelClassType GashaStepListView GashaStepListView GashaStepListView Pointer )
            value.GoBtns                                    = GetObjectList<GameObject>(new IntPtr(p + 0x130), ReversePrism.DataModels.GameObject.FromPointer); // 0x130 GoBtns                      ( ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )
            value.CurrentGasha                              = GetObject<Gasha>(new IntPtr(p + 0x138), ReversePrism.DataModels.Gasha.FromPointer); // 0x138 CurrentGasha                ( ModelClassType Gasha Gasha Gasha Pointer )
            value.BackBtnDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x140), ReversePrism.DataModels.IDisposable.FromPointer); // 0x140 BackBtnDisposable           ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.ChangeGashaCts                            = GetObject<CancellationTokenSource>(new IntPtr(p + 0x148), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x148 ChangeGashaCts              ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.ChangeBannerCts                           = GetObject<CancellationTokenSource>(new IntPtr(p + 0x150), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x150 ChangeBannerCts             ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x158), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x158 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.LastSelectIndex                           = GetInt32(new IntPtr(p + 0x160)); // 0x160 LastSelectIndex             ( ModelPrimitiveType int int int Int32 )
            value.IsBackgroundReserve                       = GetBool(new IntPtr(p + 0x164)); // 0x164 IsBackgroundReserve         ( ModelPrimitiveType bool bool bool Bool )
            value.GashaNewDic                               = GetStringList(new IntPtr(p + 0x168)); // 0x168 GashaNewDic                 ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.BackgroundMovies                          = GetStringList(new IntPtr(p + 0x170)); // 0x170 BackgroundMovies            ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.BackgroundMovieValues                     = GetStringList(new IntPtr(p + 0x178)); // 0x178 BackgroundMovieValues       ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.BackgroundImages                          = GetStringList(new IntPtr(p + 0x180)); // 0x180 BackgroundImages            ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.PlayBackgroundIndex                       = GetInt32(new IntPtr(p + 0x188)); // 0x188 PlayBackgroundIndex         ( ModelPrimitiveType int int int Int32 )
            value.UpdateTime                                = GetInt32(new IntPtr(p + 0x18C)); // 0x18C UpdateTime                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
