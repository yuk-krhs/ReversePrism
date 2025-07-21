using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 purchasedMessageTextId                   int IL2CPP_TYPE_I4
    // 020 MessageText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 ItemIconImage                            ModelClassType RawImage RawImage RawImage Pointer
    // 030 ItemNameText                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 ProductDetailButton                      ModelClassType UIButton UIButton UIButton Pointer
    // 040 ViewModel                                ModelClassType ShopPassPurchaseCompletePopupViewModel ShopPassPurchaseCompletePopupViewModel ShopPassPurchaseCompletePopupViewModel Pointer
    // 048 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 050 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ShopPassPurchaseCompletePopupView : DataModel
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
            var value   = new ShopPassPurchaseCompletePopupView() { Pointer= p0 };

            value.MessageText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 MessageText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ItemIconImage                             = GetObject<RawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.RawImage.FromPointer); // 0x28 ItemIconImage               ( ModelClassType RawImage RawImage RawImage Pointer )
            value.ItemNameText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 ItemNameText                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ProductDetailButton                       = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 ProductDetailButton         ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ViewModel                                 = GetObject<ShopPassPurchaseCompletePopupViewModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.ShopPassPurchaseCompletePopupViewModel.FromPointer); // 0x40 ViewModel                   ( ModelClassType ShopPassPurchaseCompletePopupViewModel ShopPassPurchaseCompletePopupViewModel ShopPassPurchaseCompletePopupViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x050), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x50 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
