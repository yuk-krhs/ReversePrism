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

            value.TxtMsgTop                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246653659B8 0x60 TxtMsgTop                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtCaution                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246653659D8 0x68 TxtCaution                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtPaidBefore                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246653659F8 0x70 TxtPaidBefore               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtPaidAfter                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665365A18 0x78 TxtPaidAfter                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtFreeBefore                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665365A38 0x80 TxtFreeBefore               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtFreeAfter                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665365A58 0x88 TxtFreeAfter                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtTokenBefore                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x090), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665365A78 0x90 TxtTokenBefore              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtTokenAfter                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x098), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665365A98 0x98 TxtTokenAfter               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtExChangePointBefore                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665365AB8 0xA0 TxtExChangePointBefore      ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtExChangePointAfter                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665365AD8 0xA8 TxtExChangePointAfter       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoPaid                                    = GetObject<GameObject>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.GameObject.FromPointer); // 024665365AF8 0xB0 GoPaid                      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoFree                                    = GetObject<GameObject>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.GameObject.FromPointer); // 024665365B18 0xB8 GoFree                      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoExChangePoint                           = GetObject<GameObject>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.GameObject.FromPointer); // 024665365B38 0xC0 GoExChangePoint             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoToken                                   = GetObject<GameObject>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.GameObject.FromPointer); // 024665365B58 0xC8 GoToken                     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ImgToken                                  = GetObject<RawImage>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.RawImage.FromPointer); // 024665365B78 0xD0 ImgToken                    ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.ShopOverlayCaller                         = GetObject<ShopOverlayCaller>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.ShopOverlayCaller.FromPointer); // 024665365B98 0xD8 ShopOverlayCaller           ( 0001867652C0 ModelClassType ShopOverlayCaller ShopOverlayCaller ShopOverlayCaller Pointer )
            value.TxtTokutei                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665365BB8 0xE0 TxtTokutei                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnTokutei                                = GetObject<ButtonBase>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.ButtonBase.FromPointer); // 024665365BD8 0xE8 BtnTokutei                  ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.GashaName                                 = GetString(new IntPtr(p + 0x0F0)); // 024665365BF8 0xF0 GashaName                   ( 000186671910 ModelPrimitiveType string string string String )
            value.Ps                                        = GetObject<ProductService>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.ProductService.FromPointer); // 024665365C18 0xF8 Ps                          ( 0001865A4890 ModelClassType ProductService ProductService ProductService Pointer )
            value.Popup                                     = GetObject<CommonPopupWindow>(new IntPtr(p + 0x100), ReversePrism.DataModels.CommonPopupWindow.FromPointer); // 024665365C38 0x100 Popup                       ( 0001865E8C10 ModelClassType CommonPopupWindow CommonPopupWindow CommonPopupWindow Pointer )
            value.IsRetry                                   = GetBool(new IntPtr(p + 0x110)); // 024665365C78 0x110 IsRetry                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
