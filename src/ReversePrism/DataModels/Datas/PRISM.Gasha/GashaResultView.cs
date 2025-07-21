using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BtnOK                                    ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 028 BtnOmake                                 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 030 BtnUiHide                                ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 038 BtnRetryGasha                            ModelClassType GashaButton GashaButton GashaButton Pointer
    // 040 BtnEndlessRetryGasha                     ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 048 GashaCurrentJewel                        ModelClassType CmnCurrentJewel CmnCurrentJewel CmnCurrentJewel Pointer
    // 050 GoTemplateIco                            ModelClassType GameObject GameObject GameObject Pointer
    // 058 TraItemRoot                              ModelClassType Transform Transform Transform Pointer
    // 060 GoTopArea                                ModelClassType GameObject GameObject GameObject Pointer
    // 068 GoMiddleArea                             ModelClassType GameObject GameObject GameObject Pointer
    // 070 CanvasGroupMiddleArea                    ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 078 GoBottomArea                             ModelClassType GameObject GameObject GameObject Pointer
    // 080 CommonTitleView                          ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 088 ImgBackground                            ModelClassType RawImage RawImage RawImage Pointer
    // 090 ImgDisable                               ModelClassType Image Image Image Pointer
    // 098 TxtBottomMsg                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A0 GoExChangePointRoot                      ModelClassType GameObject GameObject GameObject Pointer
    // 0A8 BtnExChangePoint                         ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 0B0 TxtExChangePointBefor                    ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0B8 TxtExChangePointAfter                    ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0C0 GoPrismGaugePointRoot                    ModelClassType GameObject GameObject GameObject Pointer
    // 0C8 BtnPrismGaugePointPoint                  ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 0D0 TxtPrismGaugePointBefor                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0D8 TxtPrismGaugePointAfter                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0E0 GashaTokenArea                           ModelClassType GashaTokenArea GashaTokenArea GashaTokenArea Pointer
    // 0E8 TxtOKBtn                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0F0 BtnInterruption                          ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 0F8 BtnShare                                 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 100 GashaResultShare                         ModelClassType GashaResultShare GashaResultShare GashaResultShare Pointer
    // 108 BackgroundMove                           ModelPrimitiveType float float float Single
    // 110 GoIcons                                  ModelClassListType List`1<GashaResultItem> List`1<GashaResultItem> List<GashaResultItem> Pointer
    // 118 Ct                                       ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 120 UiHideDisposable                         ModelClassType IDisposable IDisposable IDisposable Pointer
    // 128 ReturnTopDisposable                      ModelClassType IDisposable IDisposable IDisposable Pointer
    // 130 onBonusAcquisitionOnClick                Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 138 <OnRetry>k__BackingField                 Action`2<string, string> IL2CPP_TYPE_GENERICINST
    // 140 <OnNeedJewel>k__BackingField             Func`1<UniTask`1<Jewel>> IL2CPP_TYPE_GENERICINST
    // 148 <OnOK>k__BackingField                    Action`2<string, string> IL2CPP_TYPE_GENERICINST
    // 150 OnBackKey                                ModelClassType Action Action Action Pointer
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

            value.BtnOK                                     = GetObject<ButtonBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x20 BtnOK                       ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.BtnOmake                                  = GetObject<ButtonBase>(new IntPtr(p + 0x028), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x28 BtnOmake                    ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.BtnUiHide                                 = GetObject<ButtonBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x30 BtnUiHide                   ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.BtnRetryGasha                             = GetObject<GashaButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.GashaButton.FromPointer); // 0x38 BtnRetryGasha               ( ModelClassType GashaButton GashaButton GashaButton Pointer )
            value.BtnEndlessRetryGasha                      = GetObject<ButtonBase>(new IntPtr(p + 0x040), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x40 BtnEndlessRetryGasha        ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.GashaCurrentJewel                         = GetObject<CmnCurrentJewel>(new IntPtr(p + 0x048), ReversePrism.DataModels.CmnCurrentJewel.FromPointer); // 0x48 GashaCurrentJewel           ( ModelClassType CmnCurrentJewel CmnCurrentJewel CmnCurrentJewel Pointer )
            value.GoTemplateIco                             = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 GoTemplateIco               ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TraItemRoot                               = GetObject<Transform>(new IntPtr(p + 0x058), ReversePrism.DataModels.Transform.FromPointer); // 0x58 TraItemRoot                 ( ModelClassType Transform Transform Transform Pointer )
            value.GoTopArea                                 = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0x60 GoTopArea                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GoMiddleArea                              = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 GoMiddleArea                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CanvasGroupMiddleArea                     = GetObject<CanvasGroup>(new IntPtr(p + 0x070), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x70 CanvasGroupMiddleArea       ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.GoBottomArea                              = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0x78 GoBottomArea                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CommonTitleView                           = GetObject<CommonTitleView>(new IntPtr(p + 0x080), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0x80 CommonTitleView             ( ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.ImgBackground                             = GetObject<RawImage>(new IntPtr(p + 0x088), ReversePrism.DataModels.RawImage.FromPointer); // 0x88 ImgBackground               ( ModelClassType RawImage RawImage RawImage Pointer )
            value.ImgDisable                                = GetObject<Image>(new IntPtr(p + 0x090), ReversePrism.DataModels.Image.FromPointer); // 0x90 ImgDisable                  ( ModelClassType Image Image Image Pointer )
            value.TxtBottomMsg                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x098), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x98 TxtBottomMsg                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoExChangePointRoot                       = GetObject<GameObject>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GameObject.FromPointer); // 0xA0 GoExChangePointRoot         ( ModelClassType GameObject GameObject GameObject Pointer )
            value.BtnExChangePoint                          = GetObject<ButtonBase>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.ButtonBase.FromPointer); // 0xA8 BtnExChangePoint            ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.TxtExChangePointBefor                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xB0 TxtExChangePointBefor       ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtExChangePointAfter                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xB8 TxtExChangePointAfter       ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoPrismGaugePointRoot                     = GetObject<GameObject>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.GameObject.FromPointer); // 0xC0 GoPrismGaugePointRoot       ( ModelClassType GameObject GameObject GameObject Pointer )
            value.BtnPrismGaugePointPoint                   = GetObject<ButtonBase>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.ButtonBase.FromPointer); // 0xC8 BtnPrismGaugePointPoint     ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.TxtPrismGaugePointBefor                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xD0 TxtPrismGaugePointBefor     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtPrismGaugePointAfter                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xD8 TxtPrismGaugePointAfter     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GashaTokenArea                            = GetObject<GashaTokenArea>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.GashaTokenArea.FromPointer); // 0xE0 GashaTokenArea              ( ModelClassType GashaTokenArea GashaTokenArea GashaTokenArea Pointer )
            value.TxtOKBtn                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xE8 TxtOKBtn                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnInterruption                           = GetObject<ButtonBase>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.ButtonBase.FromPointer); // 0xF0 BtnInterruption             ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.BtnShare                                  = GetObject<ButtonBase>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.ButtonBase.FromPointer); // 0xF8 BtnShare                    ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.GashaResultShare                          = GetObject<GashaResultShare>(new IntPtr(p + 0x100), ReversePrism.DataModels.GashaResultShare.FromPointer); // 0x100 GashaResultShare            ( ModelClassType GashaResultShare GashaResultShare GashaResultShare Pointer )
            value.BackgroundMove                            = GetSingle(new IntPtr(p + 0x108)); // 0x108 BackgroundMove              ( ModelPrimitiveType float float float Single )
            value.GoIcons                                   = GetObjectList<GashaResultItem>(new IntPtr(p + 0x110), ReversePrism.DataModels.GashaResultItem.FromPointer); // 0x110 GoIcons                     ( ModelClassListType List`1<GashaResultItem> List`1<GashaResultItem> List<GashaResultItem> Pointer )
            value.Ct                                        = GetObject<CancellationTokenSource>(new IntPtr(p + 0x118), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x118 Ct                          ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.UiHideDisposable                          = GetObject<IDisposable>(new IntPtr(p + 0x120), ReversePrism.DataModels.IDisposable.FromPointer); // 0x120 UiHideDisposable            ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.ReturnTopDisposable                       = GetObject<IDisposable>(new IntPtr(p + 0x128), ReversePrism.DataModels.IDisposable.FromPointer); // 0x128 ReturnTopDisposable         ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.OnBackKey                                 = GetObject<Action>(new IntPtr(p + 0x150), ReversePrism.DataModels.Action.FromPointer); // 0x150 OnBackKey                   ( ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
