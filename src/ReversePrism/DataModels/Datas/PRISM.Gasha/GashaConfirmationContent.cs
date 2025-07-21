using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 TxtMsgTop                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 TxtCaution                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 TxtPaidBefore                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 TxtPaidAfter                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 TxtFreeBefore                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 TxtFreeAfter                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 090 TxtTokenBefore                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 098 TxtTokenAfter                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A0 TxtExChangePointBefore                   ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A8 TxtExChangePointAfter                    ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0B0 GoPaid                                   ModelClassType GameObject GameObject GameObject Pointer
    // 0B8 GoFree                                   ModelClassType GameObject GameObject GameObject Pointer
    // 0C0 GoExChangePoint                          ModelClassType GameObject GameObject GameObject Pointer
    // 0C8 GoToken                                  ModelClassType GameObject GameObject GameObject Pointer
    // 0D0 ImgToken                                 ModelClassType RawImage RawImage RawImage Pointer
    // 0D8 ShopOverlayCaller                        ModelClassType ShopOverlayCaller ShopOverlayCaller ShopOverlayCaller Pointer
    // 0E0 TxtTokutei                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0E8 BtnTokutei                               ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 0F0 GashaName                                ModelPrimitiveType string string string String
    // 0F8 Ps                                       ModelClassType ProductService ProductService ProductService Pointer
    // 100 Popup                                    ModelClassType CommonPopupWindow CommonPopupWindow CommonPopupWindow Pointer
    // 108 closeTask                                UniTaskCompletionSource`1<CloseType> IL2CPP_TYPE_GENERICINST
    // 110 IsRetry                                  ModelPrimitiveType bool bool bool Bool
    // 118 onCloseShopProcessingEvent               Func`1<UniTask> IL2CPP_TYPE_GENERICINST
    public partial class GashaConfirmationContent : DataModel
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
            var value   = new GashaConfirmationContent() { Pointer= p0 };

            value.TxtMsgTop                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 TxtMsgTop                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtCaution                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x68 TxtCaution                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtPaidBefore                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x70 TxtPaidBefore               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtPaidAfter                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x78 TxtPaidAfter                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtFreeBefore                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x80 TxtFreeBefore               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtFreeAfter                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x88 TxtFreeAfter                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtTokenBefore                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x090), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x90 TxtTokenBefore              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtTokenAfter                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x098), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x98 TxtTokenAfter               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtExChangePointBefore                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xA0 TxtExChangePointBefore      ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtExChangePointAfter                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xA8 TxtExChangePointAfter       ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoPaid                                    = GetObject<GameObject>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.GameObject.FromPointer); // 0xB0 GoPaid                      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GoFree                                    = GetObject<GameObject>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.GameObject.FromPointer); // 0xB8 GoFree                      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GoExChangePoint                           = GetObject<GameObject>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.GameObject.FromPointer); // 0xC0 GoExChangePoint             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GoToken                                   = GetObject<GameObject>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.GameObject.FromPointer); // 0xC8 GoToken                     ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ImgToken                                  = GetObject<RawImage>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.RawImage.FromPointer); // 0xD0 ImgToken                    ( ModelClassType RawImage RawImage RawImage Pointer )
            value.ShopOverlayCaller                         = GetObject<ShopOverlayCaller>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.ShopOverlayCaller.FromPointer); // 0xD8 ShopOverlayCaller           ( ModelClassType ShopOverlayCaller ShopOverlayCaller ShopOverlayCaller Pointer )
            value.TxtTokutei                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xE0 TxtTokutei                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnTokutei                                = GetObject<ButtonBase>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.ButtonBase.FromPointer); // 0xE8 BtnTokutei                  ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.GashaName                                 = GetString(new IntPtr(p + 0x0F0)); // 0xF0 GashaName                   ( ModelPrimitiveType string string string String )
            value.Ps                                        = GetObject<ProductService>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.ProductService.FromPointer); // 0xF8 Ps                          ( ModelClassType ProductService ProductService ProductService Pointer )
            value.Popup                                     = GetObject<CommonPopupWindow>(new IntPtr(p + 0x100), ReversePrism.DataModels.CommonPopupWindow.FromPointer); // 0x100 Popup                       ( ModelClassType CommonPopupWindow CommonPopupWindow CommonPopupWindow Pointer )
            value.IsRetry                                   = GetBool(new IntPtr(p + 0x110)); // 0x110 IsRetry                     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
