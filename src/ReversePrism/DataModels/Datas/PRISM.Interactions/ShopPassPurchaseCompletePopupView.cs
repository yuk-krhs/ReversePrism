using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 purchasedMessageTextId                   int IL2CPP_TYPE_I4
    // 020 MessageText                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 ItemIconImage                            000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 030 ItemNameText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 ProductDetailButton                      0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 passDetailPopupViewFactory               PopupViewFactory`1<IShopPassDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 048 ViewModel                                000186767550 ModelClassType ShopPassPurchaseCompletePopupViewModel ShopPassPurchaseCompletePopupViewModel ShopPassPurchaseCompletePopupViewModel Pointer
    // 050 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 058 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ShopPassPurchaseCompletePopupView
    {
        public UITextMeshProUGUI?                       MessageText                             { get; set; }
        public RawImage?                                ItemIconImage                           { get; set; }
        public UITextMeshProUGUI?                       ItemNameText                            { get; set; }
        public UIButton?                                ProductDetailButton                     { get; set; }
        public ShopPassPurchaseCompletePopupViewModel?  ViewModel                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ShopPassPurchaseCompletePopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopPassPurchaseCompletePopupView();

            value.MessageText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB7E79A8 0x20 MessageText                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ItemIconImage                             = GetObject<RawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.RawImage.FromPointer); // 0270DB7E79C8 0x28 ItemIconImage               ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.ItemNameText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB7E79E8 0x30 ItemNameText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ProductDetailButton                       = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB7E7A08 0x38 ProductDetailButton         ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ViewModel                                 = GetObject<ShopPassPurchaseCompletePopupViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.ShopPassPurchaseCompletePopupViewModel.FromPointer); // 0270DB7E7A48 0x48 ViewModel                   ( 000186767550 ModelClassType ShopPassPurchaseCompletePopupViewModel ShopPassPurchaseCompletePopupViewModel ShopPassPurchaseCompletePopupViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x058), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DB7E7A88 0x58 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
