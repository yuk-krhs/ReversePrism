using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MessageText                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 ItemIconImage                            000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 030 ItemNameText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 ProductDetailButton                      0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 PurchaseAmountPanel                      0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 PurchaseAmountText                       0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 MinimumButton                            0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 058 MinusButton                              0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 060 PlusButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 068 MaximumButton                            0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 070 NeedPaidJewelPanel                       0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 078 NeedPaidJewelAmountText                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 NeedFreeJewelPanel                       0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 088 NeedFreeJewelAmountText                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 090 PaidJewelFluctionTextPair                000186768A80 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer
    // 098 FreeJewelFluctionTextPair                000186768A80 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer
    // 0A0 CashPanel                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0A8 CashPriceText                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0B0 ItemFluctionTextPair                     000186768A80 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer
    // 0B8 PurchaseLimitPanel                       0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0C0 CurrentPurchaseLimitText                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0C8 AfterPurchaseLimitText                   0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0D0 SpecifiedCommercialTransactionActButton  0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 0D8 ActOnSettlementButton                    0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 0E0 CautionPanel                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0E8 CautionText                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0F0 OnClickProductDetailButton               Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0F8 OnClickMinimumButton                     Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 100 OnClickMinusButton                       Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 108 OnClickPlusButton                        Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 110 OnClickMaximumButton                     Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 118 OnClickSpecifiedCommercialTransactionActButton Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 120 OnClickActOnSettlementButton             Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class ShopPurchaseConfirmView
    {
        public UITextMeshProUGUI?                       MessageText                             { get; set; }
        public RawImage?                                ItemIconImage                           { get; set; }
        public UITextMeshProUGUI?                       ItemNameText                            { get; set; }
        public UIButton?                                ProductDetailButton                     { get; set; }
        public GameObject?                              PurchaseAmountPanel                     { get; set; }
        public UITextMeshProUGUI?                       PurchaseAmountText                      { get; set; }
        public UIButton?                                MinimumButton                           { get; set; }
        public UIButton?                                MinusButton                             { get; set; }
        public UIButton?                                PlusButton                              { get; set; }
        public UIButton?                                MaximumButton                           { get; set; }
        public GameObject?                              NeedPaidJewelPanel                      { get; set; }
        public UITextMeshProUGUI?                       NeedPaidJewelAmountText                 { get; set; }
        public GameObject?                              NeedFreeJewelPanel                      { get; set; }
        public UITextMeshProUGUI?                       NeedFreeJewelAmountText                 { get; set; }
        public ValueFluctionTextPair?                   PaidJewelFluctionTextPair               { get; set; }
        public ValueFluctionTextPair?                   FreeJewelFluctionTextPair               { get; set; }
        public GameObject?                              CashPanel                               { get; set; }
        public UITextMeshProUGUI?                       CashPriceText                           { get; set; }
        public ValueFluctionTextPair?                   ItemFluctionTextPair                    { get; set; }
        public GameObject?                              PurchaseLimitPanel                      { get; set; }
        public UITextMeshProUGUI?                       CurrentPurchaseLimitText                { get; set; }
        public UITextMeshProUGUI?                       AfterPurchaseLimitText                  { get; set; }
        public UIButton?                                SpecifiedCommercialTransactionActButton { get; set; }
        public UIButton?                                ActOnSettlementButton                   { get; set; }
        public GameObject?                              CautionPanel                            { get; set; }
        public UITextMeshProUGUI?                       CautionText                             { get; set; }

        public static ShopPurchaseConfirmView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopPurchaseConfirmView();

            value.MessageText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D553A070 0x20 MessageText                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ItemIconImage                             = GetObject<RawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.RawImage.FromPointer); // 0270D553A090 0x28 ItemIconImage               ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.ItemNameText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D553A0B0 0x30 ItemNameText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ProductDetailButton                       = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0270D553A0D0 0x38 ProductDetailButton         ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.PurchaseAmountPanel                       = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0270D553A0F0 0x40 PurchaseAmountPanel         ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.PurchaseAmountText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D553A110 0x48 PurchaseAmountText          ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MinimumButton                             = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0270D553A130 0x50 MinimumButton               ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.MinusButton                               = GetObject<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 0270D553A150 0x58 MinusButton                 ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.PlusButton                                = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 0270D553A170 0x60 PlusButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.MaximumButton                             = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 0270D553A190 0x68 MaximumButton               ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.NeedPaidJewelPanel                        = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0270D553A1B0 0x70 NeedPaidJewelPanel          ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.NeedPaidJewelAmountText                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D553A1D0 0x78 NeedPaidJewelAmountText     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NeedFreeJewelPanel                        = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 0270D553A1F0 0x80 NeedFreeJewelPanel          ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.NeedFreeJewelAmountText                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D553A210 0x88 NeedFreeJewelAmountText     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PaidJewelFluctionTextPair                 = GetObject<ValueFluctionTextPair>(new IntPtr(p + 0x090), ReversePrism.DataModels.ValueFluctionTextPair.FromPointer); // 0270D553A230 0x90 PaidJewelFluctionTextPair   ( 000186768A80 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer )
            value.FreeJewelFluctionTextPair                 = GetObject<ValueFluctionTextPair>(new IntPtr(p + 0x098), ReversePrism.DataModels.ValueFluctionTextPair.FromPointer); // 0270D553A250 0x98 FreeJewelFluctionTextPair   ( 000186768A80 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer )
            value.CashPanel                                 = GetObject<GameObject>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GameObject.FromPointer); // 0270D553A270 0xA0 CashPanel                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CashPriceText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D553A290 0xA8 CashPriceText               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ItemFluctionTextPair                      = GetObject<ValueFluctionTextPair>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.ValueFluctionTextPair.FromPointer); // 0270D553A2B0 0xB0 ItemFluctionTextPair        ( 000186768A80 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer )
            value.PurchaseLimitPanel                        = GetObject<GameObject>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.GameObject.FromPointer); // 0270D553A2D0 0xB8 PurchaseLimitPanel          ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CurrentPurchaseLimitText                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D553A2F0 0xC0 CurrentPurchaseLimitText    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AfterPurchaseLimitText                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D553A310 0xC8 AfterPurchaseLimitText      ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SpecifiedCommercialTransactionActButton   = GetObject<UIButton>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.UIButton.FromPointer); // 0270D553A330 0xD0 SpecifiedCommercialTransactionActButton ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ActOnSettlementButton                     = GetObject<UIButton>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.UIButton.FromPointer); // 0270D553A350 0xD8 ActOnSettlementButton       ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.CautionPanel                              = GetObject<GameObject>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.GameObject.FromPointer); // 0270D553A370 0xE0 CautionPanel                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CautionText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D553A390 0xE8 CautionText                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
