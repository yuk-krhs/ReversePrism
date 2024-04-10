using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ConfirmText                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 ItemIconImage                            000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 030 ItemNameText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 ProductDetailButton                      0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 ValidityLabelText                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 ValidDayText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 ValidityText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 PriceText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 ActOnSettlementButton                    0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 068 SpecifiedCommercialTransactionButton     0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 070 ViewModel                                000186774A10 ModelClassType ShopViewModel ShopViewModel ShopViewModel Pointer
    // 078 onClickProductDetailSubject              Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 080 onClickSpecifiedCommercialTransactionSubject Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 088 onClosed                                 Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 090 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ShopPassPurchaseConfirmContentViewPopupView : DataModel
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

        public static ShopPassPurchaseConfirmContentViewPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopPassPurchaseConfirmContentViewPopupView() { Pointer= p0 };

            value.ConfirmText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B878640 0x20 ConfirmText                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ItemIconImage                             = GetObject<RawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.RawImage.FromPointer); // 02466B878660 0x28 ItemIconImage               ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.ItemNameText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B878680 0x30 ItemNameText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ProductDetailButton                       = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 02466B8786A0 0x38 ProductDetailButton         ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ValidityLabelText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B8786C0 0x40 ValidityLabelText           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ValidDayText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B8786E0 0x48 ValidDayText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ValidityText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B878700 0x50 ValidityText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PriceText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B878720 0x58 PriceText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ActOnSettlementButton                     = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 02466B878740 0x60 ActOnSettlementButton       ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.SpecifiedCommercialTransactionButton      = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 02466B878760 0x68 SpecifiedCommercialTransactionButton ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ViewModel                                 = GetObject<ShopViewModel>(new IntPtr(p + 0x070), ReversePrism.DataModels.ShopViewModel.FromPointer); // 02466B878780 0x70 ViewModel                   ( 000186774A10 ModelClassType ShopViewModel ShopViewModel ShopViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x090), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466B878800 0x90 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
