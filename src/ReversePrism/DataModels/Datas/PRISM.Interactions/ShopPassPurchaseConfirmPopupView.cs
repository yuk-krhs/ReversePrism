using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ConfirmText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 ItemIconImage                            ModelClassType RawImage RawImage RawImage Pointer
    // 030 ItemNameText                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 ProductDetailButton                      ModelClassType UIButton UIButton UIButton Pointer
    // 040 ValidityLabelText                        ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 ValidDayText                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 ValidityText                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 PriceText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 ActOnSettlementButton                    ModelClassType UIButton UIButton UIButton Pointer
    // 068 SpecifiedCommercialTransactionButton     ModelClassType UIButton UIButton UIButton Pointer
    // 070 ViewModel                                ModelClassType ShopViewModel ShopViewModel ShopViewModel Pointer
    // 078 onClickProductDetailSubject              Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 080 onClickSpecifiedCommercialTransactionSubject Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 088 onClosed                                 Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 090 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ShopPassPurchaseConfirmPopupView : DataModel
    {
        public UITextMeshProUGUI?                       ConfirmText                             { get; set; }
        public RawImage?                                ItemIconImage                           { get; set; }
        public UITextMeshProUGUI?                       ItemNameText                            { get; set; }
        public UIButton?                                ProductDetailButton                     { get; set; }
        public UITextMeshProUGUI?                       ValidityLabelText                       { get; set; }
        public UITextMeshProUGUI?                       ValidDayText                            { get; set; }
        public UITextMeshProUGUI?                       ValidityText                            { get; set; }
        public UITextMeshProUGUI?                       PriceText                               { get; set; }
        public UIButton?                                ActOnSettlementButton                   { get; set; }
        public UIButton?                                SpecifiedCommercialTransactionButton    { get; set; }
        public ShopViewModel?                           ViewModel                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ShopPassPurchaseConfirmPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopPassPurchaseConfirmPopupView() { Pointer= p0 };

            value.ConfirmText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 ConfirmText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ItemIconImage                             = GetObject<RawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.RawImage.FromPointer); // 0x28 ItemIconImage               ( ModelClassType RawImage RawImage RawImage Pointer )
            value.ItemNameText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 ItemNameText                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ProductDetailButton                       = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 ProductDetailButton         ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ValidityLabelText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 ValidityLabelText           ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ValidDayText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 ValidDayText                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ValidityText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 ValidityText                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PriceText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 PriceText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ActOnSettlementButton                     = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 0x60 ActOnSettlementButton       ( ModelClassType UIButton UIButton UIButton Pointer )
            value.SpecifiedCommercialTransactionButton      = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 0x68 SpecifiedCommercialTransactionButton ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ViewModel                                 = GetObject<ShopViewModel>(new IntPtr(p + 0x070), ReversePrism.DataModels.ShopViewModel.FromPointer); // 0x70 ViewModel                   ( ModelClassType ShopViewModel ShopViewModel ShopViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x090), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x90 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
