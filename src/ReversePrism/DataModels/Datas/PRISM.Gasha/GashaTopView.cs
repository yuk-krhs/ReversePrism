using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GashaBannerCarousel                      0001865EFA20 ModelClassType GashaBannerCarousel GashaBannerCarousel GashaBannerCarousel Pointer
    // 028 MoviePlayer                              000186658A40 ModelClassType MoviePlayer MoviePlayer MoviePlayer Pointer
    // 030 GashaNamePlate                           0001866089D0 ModelClassType GashaNamePlateEx GashaNamePlateEx GashaNamePlateEx Pointer
    // 038 TxtTokutei                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 BtnMoviesSwitch                          000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 048 GoGashaButton                            0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 BtnTokutei                               000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 058 ImgLogo                                  0001866CCDB0 ModelClassType Image Image Image Pointer
    // 060 TxtLimit                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 BtnDetails                               000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 070 BtnGashaRates                            000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 078 BtnMembers                               000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 080 BtnCostumes                              000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 088 BtnOmake                                 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 090 BtnHistory                               000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 098 TxtMsg                                   0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A0 ImgBackground                            0001866CCDB0 ModelClassType Image Image Image Pointer
    // 0A8 AspectRatioFitterBackground              0001866DD380 ModelClassType AspectRatioFitter AspectRatioFitter AspectRatioFitter Pointer
    // 0B0 TraBack                                  0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 0B8 TraFront                                 0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 0C0 ImgCarouselTouch                         0001866CCDB0 ModelClassType Image Image Image Pointer
    // 0C8 CanvasGroupMiddle                        000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0D0 GoPrismGauge                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0D8 TxtPrismGaugePoint                       0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0E0 GaugeItemIcon                            0001865BC1A0 ModelClassType CmnItem CmnItem CmnItem Pointer
    // 0E8 BtnPrismGauge                            000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 0F0 GoPrismGaugeDone                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0F8 GoExchangeRoot                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 100 BtnExchange                              000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 108 TxtExchange                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 110 GoExchangebadge                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 118 GashaTokenAreas                          000185B81E10 ModelClassListType GashaTokenArea[] GashaTokenArea[] List<GashaTokenArea> Pointer
    // 120 JewelArea                                0001865BBB90 ModelClassType CmnCurrentJewel CmnCurrentJewel CmnCurrentJewel Pointer
    // 128 GashaStepListView                        00018661E9F0 ModelClassType GashaStepListView GashaStepListView GashaStepListView Pointer
    // 130 GoBtns                                   000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    // 138 CurrentGasha                             0001865D9930 ModelClassType Gasha Gasha Gasha Pointer
    // 140 InitDisposables                          0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 148 SaleUpdateDisposables                    0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 150 BackBtnDisposable                        0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 158 ChangeGashaCts                           0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 160 ChangeBannerCts                          0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 168 CurrentBackgroundType                    00018672BEC0 ModelEnumType BackgroundType BackgroundType BackgroundType Int32
    // 170 Cts                                      0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 178 LastSelectIndex                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 17C IsBackgroundReserve                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 180 GashaNewDic                              000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 188 UpdateTime                               0001865F2AF0 ModelPrimitiveType int int int Int32
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
    public partial class GashaTopView
    {
        public GashaBannerCarousel?                     GashaBannerCarousel                     { get; set; }
        public MoviePlayer?                             MoviePlayer                             { get; set; }
        public GashaNamePlateEx?                        GashaNamePlate                          { get; set; }
        public UITextMeshProUGUI?                       TxtTokutei                              { get; set; }
        public ButtonBase?                              BtnMoviesSwitch                         { get; set; }
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
        public Transform?                               TraBack                                 { get; set; }
        public Transform?                               TraFront                                { get; set; }
        public Image?                                   ImgCarouselTouch                        { get; set; }
        public CanvasGroup?                             CanvasGroupMiddle                       { get; set; }
        public GameObject?                              GoPrismGauge                            { get; set; }
        public UITextMeshProUGUI?                       TxtPrismGaugePoint                      { get; set; }
        public CmnItem?                                 GaugeItemIcon                           { get; set; }
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
        public CompositeDisposable?                     InitDisposables                         { get; set; }
        public CompositeDisposable?                     SaleUpdateDisposables                   { get; set; }
        public IDisposable?                             BackBtnDisposable                       { get; set; }
        public CancellationTokenSource?                 ChangeGashaCts                          { get; set; }
        public CancellationTokenSource?                 ChangeBannerCts                         { get; set; }
        public BackgroundType                           CurrentBackgroundType                   { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public int                                      LastSelectIndex                         { get; set; }
        public bool                                     IsBackgroundReserve                     { get; set; }
        public List<string>?                            GashaNewDic                             { get; set; }
        public int                                      UpdateTime                              { get; set; }

        public static GashaTopView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaTopView();

            value.GashaBannerCarousel                       = GetObject<GashaBannerCarousel>(new IntPtr(p + 0x020), ReversePrism.DataModels.GashaBannerCarousel.FromPointer); // 0270D5383170 0x20 GashaBannerCarousel         ( 0001865EFA20 ModelClassType GashaBannerCarousel GashaBannerCarousel GashaBannerCarousel Pointer )
            value.MoviePlayer                               = GetObject<MoviePlayer>(new IntPtr(p + 0x028), ReversePrism.DataModels.MoviePlayer.FromPointer); // 0270D5383190 0x28 MoviePlayer                 ( 000186658A40 ModelClassType MoviePlayer MoviePlayer MoviePlayer Pointer )
            value.GashaNamePlate                            = GetObject<GashaNamePlateEx>(new IntPtr(p + 0x030), ReversePrism.DataModels.GashaNamePlateEx.FromPointer); // 0270D53831B0 0x30 GashaNamePlate              ( 0001866089D0 ModelClassType GashaNamePlateEx GashaNamePlateEx GashaNamePlateEx Pointer )
            value.TxtTokutei                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D53831D0 0x38 TxtTokutei                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnMoviesSwitch                           = GetObject<ButtonBase>(new IntPtr(p + 0x040), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D53831F0 0x40 BtnMoviesSwitch             ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.GoGashaButton                             = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5383210 0x48 GoGashaButton               ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.BtnTokutei                                = GetObject<ButtonBase>(new IntPtr(p + 0x050), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D5383230 0x50 BtnTokutei                  ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.ImgLogo                                   = GetObject<Image>(new IntPtr(p + 0x058), ReversePrism.DataModels.Image.FromPointer); // 0270D5383250 0x58 ImgLogo                     ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.TxtLimit                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5383270 0x60 TxtLimit                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnDetails                                = GetObject<ButtonBase>(new IntPtr(p + 0x068), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D5383290 0x68 BtnDetails                  ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.BtnGashaRates                             = GetObject<ButtonBase>(new IntPtr(p + 0x070), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D53832B0 0x70 BtnGashaRates               ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.BtnMembers                                = GetObject<ButtonBase>(new IntPtr(p + 0x078), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D53832D0 0x78 BtnMembers                  ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.BtnCostumes                               = GetObject<ButtonBase>(new IntPtr(p + 0x080), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D53832F0 0x80 BtnCostumes                 ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.BtnOmake                                  = GetObject<ButtonBase>(new IntPtr(p + 0x088), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D5383310 0x88 BtnOmake                    ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.BtnHistory                                = GetObject<ButtonBase>(new IntPtr(p + 0x090), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D5383330 0x90 BtnHistory                  ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.TxtMsg                                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x098), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5383350 0x98 TxtMsg                      ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ImgBackground                             = GetObject<Image>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Image.FromPointer); // 0270D5383370 0xA0 ImgBackground               ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.AspectRatioFitterBackground               = GetObject<AspectRatioFitter>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.AspectRatioFitter.FromPointer); // 0270D5383390 0xA8 AspectRatioFitterBackground ( 0001866DD380 ModelClassType AspectRatioFitter AspectRatioFitter AspectRatioFitter Pointer )
            value.TraBack                                   = GetObject<Transform>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Transform.FromPointer); // 0270D53833B0 0xB0 TraBack                     ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.TraFront                                  = GetObject<Transform>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.Transform.FromPointer); // 0270D53833D0 0xB8 TraFront                    ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.ImgCarouselTouch                          = GetObject<Image>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.Image.FromPointer); // 0270D53833F0 0xC0 ImgCarouselTouch            ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.CanvasGroupMiddle                         = GetObject<CanvasGroup>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270D5383410 0xC8 CanvasGroupMiddle           ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.GoPrismGauge                              = GetObject<GameObject>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5383430 0xD0 GoPrismGauge                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TxtPrismGaugePoint                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5383450 0xD8 TxtPrismGaugePoint          ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GaugeItemIcon                             = GetObject<CmnItem>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.CmnItem.FromPointer); // 0270D5383470 0xE0 GaugeItemIcon               ( 0001865BC1A0 ModelClassType CmnItem CmnItem CmnItem Pointer )
            value.BtnPrismGauge                             = GetObject<ButtonBase>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D5383490 0xE8 BtnPrismGauge               ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.GoPrismGaugeDone                          = GetObject<GameObject>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.GameObject.FromPointer); // 0270D53834B0 0xF0 GoPrismGaugeDone            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoExchangeRoot                            = GetObject<GameObject>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.GameObject.FromPointer); // 0270D53834D0 0xF8 GoExchangeRoot              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.BtnExchange                               = GetObject<ButtonBase>(new IntPtr(p + 0x100), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D53834F0 0x100 BtnExchange                 ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.TxtExchange                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x108), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5383510 0x108 TxtExchange                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoExchangebadge                           = GetObject<GameObject>(new IntPtr(p + 0x110), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5383530 0x110 GoExchangebadge             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GashaTokenAreas                           = GetObjectList<GashaTokenArea>(new IntPtr(p + 0x118), ReversePrism.DataModels.GashaTokenArea.FromPointer); // 0270D5383550 0x118 GashaTokenAreas             ( 000185B81E10 ModelClassListType GashaTokenArea[] GashaTokenArea[] List<GashaTokenArea> Pointer )
            value.JewelArea                                 = GetObject<CmnCurrentJewel>(new IntPtr(p + 0x120), ReversePrism.DataModels.CmnCurrentJewel.FromPointer); // 0270D5383570 0x120 JewelArea                   ( 0001865BBB90 ModelClassType CmnCurrentJewel CmnCurrentJewel CmnCurrentJewel Pointer )
            value.GashaStepListView                         = GetObject<GashaStepListView>(new IntPtr(p + 0x128), ReversePrism.DataModels.GashaStepListView.FromPointer); // 0270D5383590 0x128 GashaStepListView           ( 00018661E9F0 ModelClassType GashaStepListView GashaStepListView GashaStepListView Pointer )
            value.GoBtns                                    = GetObjectList<GameObject>(new IntPtr(p + 0x130), ReversePrism.DataModels.GameObject.FromPointer); // 0270D53835B0 0x130 GoBtns                      ( 000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )
            value.CurrentGasha                              = GetObject<Gasha>(new IntPtr(p + 0x138), ReversePrism.DataModels.Gasha.FromPointer); // 0270D53835D0 0x138 CurrentGasha                ( 0001865D9930 ModelClassType Gasha Gasha Gasha Pointer )
            value.InitDisposables                           = GetObject<CompositeDisposable>(new IntPtr(p + 0x140), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D53835F0 0x140 InitDisposables             ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.SaleUpdateDisposables                     = GetObject<CompositeDisposable>(new IntPtr(p + 0x148), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D5383610 0x148 SaleUpdateDisposables       ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.BackBtnDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x150), ReversePrism.DataModels.IDisposable.FromPointer); // 0270D5383630 0x150 BackBtnDisposable           ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.ChangeGashaCts                            = GetObject<CancellationTokenSource>(new IntPtr(p + 0x158), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D5383650 0x158 ChangeGashaCts              ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.ChangeBannerCts                           = GetObject<CancellationTokenSource>(new IntPtr(p + 0x160), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D5383670 0x160 ChangeBannerCts             ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.CurrentBackgroundType                     = (BackgroundType)GetInt32(new IntPtr(p + 0x168)); // 0270D5383690 0x168 CurrentBackgroundType       ( 00018672BEC0 ModelEnumType BackgroundType BackgroundType BackgroundType Int32 )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x170), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D53836B0 0x170 Cts                         ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.LastSelectIndex                           = GetInt32(new IntPtr(p + 0x178)); // 0270D53836D0 0x178 LastSelectIndex             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsBackgroundReserve                       = GetBool(new IntPtr(p + 0x17C)); // 0270D53836F0 0x17C IsBackgroundReserve         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.GashaNewDic                               = GetStringList(new IntPtr(p + 0x180)); // 0270D5383710 0x180 GashaNewDic                 ( 000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.UpdateTime                                = GetInt32(new IntPtr(p + 0x188)); // 0270D5383730 0x188 UpdateTime                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
