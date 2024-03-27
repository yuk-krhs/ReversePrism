using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 TxtMsgTop                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 TxtCaution                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 TxtPaidBefore                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 TxtPaidAfter                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 TxtFreeBefore                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 TxtFreeAfter                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 090 TxtTokenBefore                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 098 TxtTokenAfter                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A0 TxtExChangePointBefore                   0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A8 TxtExChangePointAfter                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0B0 GoPaid                                   0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0B8 GoFree                                   0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0C0 GoExChangePoint                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0C8 GoToken                                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0D0 ImgToken                                 000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 0D8 ShopOverlayCaller                        0001867652C0 ModelClassType ShopOverlayCaller ShopOverlayCaller ShopOverlayCaller Pointer
    // 0E0 TxtTokutei                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0E8 BtnTokutei                               000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 0F0 GashaName                                000186671910 ModelPrimitiveType string string string String
    // 0F8 Ps                                       0001865A4890 ModelClassType ProductService ProductService ProductService Pointer
    // 100 Popup                                    0001865E8C10 ModelClassType CommonPopupWindow CommonPopupWindow CommonPopupWindow Pointer
    // 108 closeTask                                UniTaskCompletionSource`1<CloseType> IL2CPP_TYPE_GENERICINST
    // 110 IsRetry                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 118 onCloseShopProcessingEvent               Func`1<UniTask> IL2CPP_TYPE_GENERICINST
    public partial class GashaConfirmationContent
    {
        public UITextMeshProUGUI?                       TxtMsgTop                               { get; set; }
        public UITextMeshProUGUI?                       TxtCaution                              { get; set; }
        public UITextMeshProUGUI?                       TxtPaidBefore                           { get; set; }
        public UITextMeshProUGUI?                       TxtPaidAfter                            { get; set; }
        public UITextMeshProUGUI?                       TxtFreeBefore                           { get; set; }
        public UITextMeshProUGUI?                       TxtFreeAfter                            { get; set; }
        public UITextMeshProUGUI?                       TxtTokenBefore                          { get; set; }
        public UITextMeshProUGUI?                       TxtTokenAfter                           { get; set; }
        public UITextMeshProUGUI?                       TxtExChangePointBefore                  { get; set; }
        public UITextMeshProUGUI?                       TxtExChangePointAfter                   { get; set; }
        public GameObject?                              GoPaid                                  { get; set; }
        public GameObject?                              GoFree                                  { get; set; }
        public GameObject?                              GoExChangePoint                         { get; set; }
        public GameObject?                              GoToken                                 { get; set; }
        public RawImage?                                ImgToken                                { get; set; }
        public ShopOverlayCaller?                       ShopOverlayCaller                       { get; set; }
        public UITextMeshProUGUI?                       TxtTokutei                              { get; set; }
        public ButtonBase?                              BtnTokutei                              { get; set; }
        public string                                   GashaName                               { get; set; }
        public ProductService?                          Ps                                      { get; set; }
        public CommonPopupWindow?                       Popup                                   { get; set; }
        public bool                                     IsRetry                                 { get; set; }

        public static GashaConfirmationContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaConfirmationContent();

            value.TxtMsgTop                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D52F2210 0x60 TxtMsgTop                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtCaution                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D52F2230 0x68 TxtCaution                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtPaidBefore                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D52F2250 0x70 TxtPaidBefore               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtPaidAfter                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D52F2270 0x78 TxtPaidAfter                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtFreeBefore                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D52F2290 0x80 TxtFreeBefore               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtFreeAfter                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D52F22B0 0x88 TxtFreeAfter                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtTokenBefore                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x090), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D52F22D0 0x90 TxtTokenBefore              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtTokenAfter                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x098), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D52F22F0 0x98 TxtTokenAfter               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtExChangePointBefore                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D52F2310 0xA0 TxtExChangePointBefore      ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtExChangePointAfter                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D52F2330 0xA8 TxtExChangePointAfter       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoPaid                                    = GetObject<GameObject>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.GameObject.FromPointer); // 0270D52F2350 0xB0 GoPaid                      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoFree                                    = GetObject<GameObject>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.GameObject.FromPointer); // 0270D52F2370 0xB8 GoFree                      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoExChangePoint                           = GetObject<GameObject>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.GameObject.FromPointer); // 0270D52F2390 0xC0 GoExChangePoint             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoToken                                   = GetObject<GameObject>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.GameObject.FromPointer); // 0270D52F23B0 0xC8 GoToken                     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ImgToken                                  = GetObject<RawImage>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.RawImage.FromPointer); // 0270D52F23D0 0xD0 ImgToken                    ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.ShopOverlayCaller                         = GetObject<ShopOverlayCaller>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.ShopOverlayCaller.FromPointer); // 0270D52F23F0 0xD8 ShopOverlayCaller           ( 0001867652C0 ModelClassType ShopOverlayCaller ShopOverlayCaller ShopOverlayCaller Pointer )
            value.TxtTokutei                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D52F2410 0xE0 TxtTokutei                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnTokutei                                = GetObject<ButtonBase>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D52F2430 0xE8 BtnTokutei                  ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.GashaName                                 = GetString(new IntPtr(p + 0x0F0)); // 0270D52F2450 0xF0 GashaName                   ( 000186671910 ModelPrimitiveType string string string String )
            value.Ps                                        = GetObject<ProductService>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.ProductService.FromPointer); // 0270D52F2470 0xF8 Ps                          ( 0001865A4890 ModelClassType ProductService ProductService ProductService Pointer )
            value.Popup                                     = GetObject<CommonPopupWindow>(new IntPtr(p + 0x100), ReversePrism.DataModels.CommonPopupWindow.FromPointer); // 0270D52F2490 0x100 Popup                       ( 0001865E8C10 ModelClassType CommonPopupWindow CommonPopupWindow CommonPopupWindow Pointer )
            value.IsRetry                                   = GetBool(new IntPtr(p + 0x110)); // 0270D52F24D0 0x110 IsRetry                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
