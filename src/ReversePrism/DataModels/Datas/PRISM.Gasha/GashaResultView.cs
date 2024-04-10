using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BtnOK                                    000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 028 BtnOmake                                 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 030 BtnUiHide                                000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 038 BtnRetryGasha                            0001865F2FB0 ModelClassType GashaButton GashaButton GashaButton Pointer
    // 040 BtnEndlessRetryGasha                     000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 048 GashaCurrentJewel                        0001865BBB90 ModelClassType CmnCurrentJewel CmnCurrentJewel CmnCurrentJewel Pointer
    // 050 GoTemplateIco                            0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 058 TraItemRoot                              0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 060 GoTopArea                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 068 GoMiddleArea                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 070 CanvasGroupMiddleArea                    000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 078 GoBottomArea                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 080 CommonTitleView                          0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 088 ImgBackground                            000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 090 ImgDisable                               0001866CCDB0 ModelClassType Image Image Image Pointer
    // 098 TxtBottomMsg                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A0 GoExChangePointRoot                      0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0A8 BtnExChangePoint                         000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 0B0 TxtExChangePointBefor                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0B8 TxtExChangePointAfter                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0C0 GoPrismGaugePointRoot                    0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0C8 BtnPrismGaugePointPoint                  000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 0D0 TxtPrismGaugePointBefor                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0D8 TxtPrismGaugePointAfter                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0E0 GashaTokenArea                           0001866208B0 ModelClassType GashaTokenArea GashaTokenArea GashaTokenArea Pointer
    // 0E8 TxtOKBtn                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0F0 BtnInterruption                          000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 0F8 BtnShare                                 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 100 GashaResultShare                         000186616440 ModelClassType GashaResultShare GashaResultShare GashaResultShare Pointer
    // 108 BackgroundMove                           0001866656B0 ModelPrimitiveType float float float Single
    // 110 GoIcons                                  000185CDE358 ModelClassListType List`1<GashaResultItem> List`1<GashaResultItem> List<GashaResultItem> Pointer
    // 118 Ct                                       0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 120 UiHideDisposable                         0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 128 ReturnTopDisposable                      0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 130 onBonusAcquisitionOnClick                Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 138 <OnRetry>k__BackingField                 Action`2<string, string> IL2CPP_TYPE_GENERICINST
    // 140 <OnNeedJewel>k__BackingField             Func`1<UniTask`1<Jewel>> IL2CPP_TYPE_GENERICINST
    // 148 <OnOK>k__BackingField                    Action`2<string, string> IL2CPP_TYPE_GENERICINST
    // 150 OnBackKey                                0001866792B0 ModelClassType Action Action Action Pointer
    // 158 <ItemDisplayDirection>k__BackingField    UniTaskCompletionSource`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class GashaResultView : DataModel
    {
        public ButtonBase?                              BtnOK                                   { get; set; }
        public ButtonBase?                              BtnOmake                                { get; set; }
        public ButtonBase?                              BtnUiHide                               { get; set; }
        public GashaButton?                             BtnRetryGasha                           { get; set; }
        public ButtonBase?                              BtnEndlessRetryGasha                    { get; set; }
        public CmnCurrentJewel?                         GashaCurrentJewel                       { get; set; }
        public GameObject?                              GoTemplateIco                           { get; set; }
        public Transform?                               TraItemRoot                             { get; set; }
        public GameObject?                              GoTopArea                               { get; set; }
        public GameObject?                              GoMiddleArea                            { get; set; }
        public CanvasGroup?                             CanvasGroupMiddleArea                   { get; set; }
        public GameObject?                              GoBottomArea                            { get; set; }
        public CommonTitleView?                         CommonTitleView                         { get; set; }
        public RawImage?                                ImgBackground                           { get; set; }
        public Image?                                   ImgDisable                              { get; set; }
        public UITextMeshProUGUI?                       TxtBottomMsg                            { get; set; }
        public GameObject?                              GoExChangePointRoot                     { get; set; }
        public ButtonBase?                              BtnExChangePoint                        { get; set; }
        public UITextMeshProUGUI?                       TxtExChangePointBefor                   { get; set; }
        public UITextMeshProUGUI?                       TxtExChangePointAfter                   { get; set; }
        public GameObject?                              GoPrismGaugePointRoot                   { get; set; }
        public ButtonBase?                              BtnPrismGaugePointPoint                 { get; set; }
        public UITextMeshProUGUI?                       TxtPrismGaugePointBefor                 { get; set; }
        public UITextMeshProUGUI?                       TxtPrismGaugePointAfter                 { get; set; }
        public GashaTokenArea?                          GashaTokenArea                          { get; set; }
        public UITextMeshProUGUI?                       TxtOKBtn                                { get; set; }
        public ButtonBase?                              BtnInterruption                         { get; set; }
        public ButtonBase?                              BtnShare                                { get; set; }
        public GashaResultShare?                        GashaResultShare                        { get; set; }
        public float                                    BackgroundMove                          { get; set; }
        public List<GashaResultItem>?                   GoIcons                                 { get; set; }
        public CancellationTokenSource?                 Ct                                      { get; set; }
        public IDisposable?                             UiHideDisposable                        { get; set; }
        public IDisposable?                             ReturnTopDisposable                     { get; set; }
        public Action?                                  OnBackKey                               { get; set; }

        public static GashaResultView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaResultView() { Pointer= p0 };

            value.BtnOK                                     = GetObject<ButtonBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.ButtonBase.FromPointer); // 0246653E7280 0x20 BtnOK                       ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.BtnOmake                                  = GetObject<ButtonBase>(new IntPtr(p + 0x028), ReversePrism.DataModels.ButtonBase.FromPointer); // 0246653E72A0 0x28 BtnOmake                    ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.BtnUiHide                                 = GetObject<ButtonBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.ButtonBase.FromPointer); // 0246653E72C0 0x30 BtnUiHide                   ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.BtnRetryGasha                             = GetObject<GashaButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.GashaButton.FromPointer); // 0246653E72E0 0x38 BtnRetryGasha               ( 0001865F2FB0 ModelClassType GashaButton GashaButton GashaButton Pointer )
            value.BtnEndlessRetryGasha                      = GetObject<ButtonBase>(new IntPtr(p + 0x040), ReversePrism.DataModels.ButtonBase.FromPointer); // 0246653E7300 0x40 BtnEndlessRetryGasha        ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.GashaCurrentJewel                         = GetObject<CmnCurrentJewel>(new IntPtr(p + 0x048), ReversePrism.DataModels.CmnCurrentJewel.FromPointer); // 0246653E7320 0x48 GashaCurrentJewel           ( 0001865BBB90 ModelClassType CmnCurrentJewel CmnCurrentJewel CmnCurrentJewel Pointer )
            value.GoTemplateIco                             = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0246653E7340 0x50 GoTemplateIco               ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TraItemRoot                               = GetObject<Transform>(new IntPtr(p + 0x058), ReversePrism.DataModels.Transform.FromPointer); // 0246653E7360 0x58 TraItemRoot                 ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.GoTopArea                                 = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0246653E7380 0x60 GoTopArea                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoMiddleArea                              = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0246653E73A0 0x68 GoMiddleArea                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CanvasGroupMiddleArea                     = GetObject<CanvasGroup>(new IntPtr(p + 0x070), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0246653E73C0 0x70 CanvasGroupMiddleArea       ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.GoBottomArea                              = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0246653E73E0 0x78 GoBottomArea                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CommonTitleView                           = GetObject<CommonTitleView>(new IntPtr(p + 0x080), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0246653E7400 0x80 CommonTitleView             ( 0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.ImgBackground                             = GetObject<RawImage>(new IntPtr(p + 0x088), ReversePrism.DataModels.RawImage.FromPointer); // 0246653E7420 0x88 ImgBackground               ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.ImgDisable                                = GetObject<Image>(new IntPtr(p + 0x090), ReversePrism.DataModels.Image.FromPointer); // 0246653E7440 0x90 ImgDisable                  ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.TxtBottomMsg                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x098), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246653E7460 0x98 TxtBottomMsg                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoExChangePointRoot                       = GetObject<GameObject>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GameObject.FromPointer); // 0246653E7480 0xA0 GoExChangePointRoot         ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.BtnExChangePoint                          = GetObject<ButtonBase>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.ButtonBase.FromPointer); // 0246653E74A0 0xA8 BtnExChangePoint            ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.TxtExChangePointBefor                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246653E74C0 0xB0 TxtExChangePointBefor       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtExChangePointAfter                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246653E74E0 0xB8 TxtExChangePointAfter       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoPrismGaugePointRoot                     = GetObject<GameObject>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.GameObject.FromPointer); // 0246653E7500 0xC0 GoPrismGaugePointRoot       ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.BtnPrismGaugePointPoint                   = GetObject<ButtonBase>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.ButtonBase.FromPointer); // 0246653E7520 0xC8 BtnPrismGaugePointPoint     ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.TxtPrismGaugePointBefor                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246653E7540 0xD0 TxtPrismGaugePointBefor     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtPrismGaugePointAfter                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246653E7560 0xD8 TxtPrismGaugePointAfter     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GashaTokenArea                            = GetObject<GashaTokenArea>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.GashaTokenArea.FromPointer); // 0246653E7580 0xE0 GashaTokenArea              ( 0001866208B0 ModelClassType GashaTokenArea GashaTokenArea GashaTokenArea Pointer )
            value.TxtOKBtn                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246653E75A0 0xE8 TxtOKBtn                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnInterruption                           = GetObject<ButtonBase>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.ButtonBase.FromPointer); // 0246653E75C0 0xF0 BtnInterruption             ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.BtnShare                                  = GetObject<ButtonBase>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.ButtonBase.FromPointer); // 0246653E75E0 0xF8 BtnShare                    ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.GashaResultShare                          = GetObject<GashaResultShare>(new IntPtr(p + 0x100), ReversePrism.DataModels.GashaResultShare.FromPointer); // 0246653E7600 0x100 GashaResultShare            ( 000186616440 ModelClassType GashaResultShare GashaResultShare GashaResultShare Pointer )
            value.BackgroundMove                            = GetSingle(new IntPtr(p + 0x108)); // 0246653E7620 0x108 BackgroundMove              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.GoIcons                                   = GetObjectList<GashaResultItem>(new IntPtr(p + 0x110), ReversePrism.DataModels.GashaResultItem.FromPointer); // 0246653E7640 0x110 GoIcons                     ( 000185CDE358 ModelClassListType List`1<GashaResultItem> List`1<GashaResultItem> List<GashaResultItem> Pointer )
            value.Ct                                        = GetObject<CancellationTokenSource>(new IntPtr(p + 0x118), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0246653E7660 0x118 Ct                          ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.UiHideDisposable                          = GetObject<IDisposable>(new IntPtr(p + 0x120), ReversePrism.DataModels.IDisposable.FromPointer); // 0246653E7680 0x120 UiHideDisposable            ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.ReturnTopDisposable                       = GetObject<IDisposable>(new IntPtr(p + 0x128), ReversePrism.DataModels.IDisposable.FromPointer); // 0246653E76A0 0x128 ReturnTopDisposable         ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.OnBackKey                                 = GetObject<Action>(new IntPtr(p + 0x150), ReversePrism.DataModels.Action.FromPointer); // 0246653E7740 0x150 OnBackKey                   ( 0001866792B0 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
