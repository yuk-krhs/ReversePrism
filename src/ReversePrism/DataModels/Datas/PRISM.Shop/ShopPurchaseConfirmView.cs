using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MessageText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 ItemIconImage                            ModelClassType RawImage RawImage RawImage Pointer
    // 030 ItemNameText                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 ProductDetailButton                      ModelClassType UIButton UIButton UIButton Pointer
    // 040 PurchaseAmountPanel                      ModelClassType GameObject GameObject GameObject Pointer
    // 048 PurchaseAmountText                       ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 MinimumButton                            ModelClassType UIButton UIButton UIButton Pointer
    // 058 MinusButton                              ModelClassType UIButton UIButton UIButton Pointer
    // 060 PlusButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 068 MaximumButton                            ModelClassType UIButton UIButton UIButton Pointer
    // 070 NeedPaidJewelPanel                       ModelClassType GameObject GameObject GameObject Pointer
    // 078 NeedPaidJewelAmountText                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 NeedFreeJewelPanel                       ModelClassType GameObject GameObject GameObject Pointer
    // 088 NeedFreeJewelAmountText                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 090 PaidJewelFluctionTextPair                ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer
    // 098 FreeJewelFluctionTextPair                ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer
    // 0A0 CashPanel                                ModelClassType GameObject GameObject GameObject Pointer
    // 0A8 CashPriceText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0B0 ItemFluctionTextPair                     ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer
    // 0B8 PurchaseLimitPanel                       ModelClassType GameObject GameObject GameObject Pointer
    // 0C0 CurrentPurchaseLimitText                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0C8 AfterPurchaseLimitText                   ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0D0 SpecifiedCommercialTransactionActButton  ModelClassType UIButton UIButton UIButton Pointer
    // 0D8 ActOnSettlementButton                    ModelClassType UIButton UIButton UIButton Pointer
    // 0E0 CautionPanel                             ModelClassType GameObject GameObject GameObject Pointer
    // 0E8 CautionText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0F0 OnClickProductDetailButton               Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0F8 OnClickMinimumButton                     Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 100 OnClickMinusButton                       Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 108 OnClickPlusButton                        Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 110 OnClickMaximumButton                     Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 118 OnClickSpecifiedCommercialTransactionActButton Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 120 OnClickActOnSettlementButton             Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class ShopPurchaseConfirmView : DataModel
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
            var value   = new ShopPurchaseConfirmView() { Pointer= p0 };

            value.MessageText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 MessageText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ItemIconImage                             = GetObject<RawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.RawImage.FromPointer); // 0x28 ItemIconImage               ( ModelClassType RawImage RawImage RawImage Pointer )
            value.ItemNameText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 ItemNameText                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ProductDetailButton                       = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 ProductDetailButton         ( ModelClassType UIButton UIButton UIButton Pointer )
            value.PurchaseAmountPanel                       = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 PurchaseAmountPanel         ( ModelClassType GameObject GameObject GameObject Pointer )
            value.PurchaseAmountText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 PurchaseAmountText          ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MinimumButton                             = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0x50 MinimumButton               ( ModelClassType UIButton UIButton UIButton Pointer )
            value.MinusButton                               = GetObject<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 0x58 MinusButton                 ( ModelClassType UIButton UIButton UIButton Pointer )
            value.PlusButton                                = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 0x60 PlusButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.MaximumButton                             = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 0x68 MaximumButton               ( ModelClassType UIButton UIButton UIButton Pointer )
            value.NeedPaidJewelPanel                        = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 NeedPaidJewelPanel          ( ModelClassType GameObject GameObject GameObject Pointer )
            value.NeedPaidJewelAmountText                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x78 NeedPaidJewelAmountText     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NeedFreeJewelPanel                        = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 0x80 NeedFreeJewelPanel          ( ModelClassType GameObject GameObject GameObject Pointer )
            value.NeedFreeJewelAmountText                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x88 NeedFreeJewelAmountText     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PaidJewelFluctionTextPair                 = GetObject<ValueFluctionTextPair>(new IntPtr(p + 0x090), ReversePrism.DataModels.ValueFluctionTextPair.FromPointer); // 0x90 PaidJewelFluctionTextPair   ( ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer )
            value.FreeJewelFluctionTextPair                 = GetObject<ValueFluctionTextPair>(new IntPtr(p + 0x098), ReversePrism.DataModels.ValueFluctionTextPair.FromPointer); // 0x98 FreeJewelFluctionTextPair   ( ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer )
            value.CashPanel                                 = GetObject<GameObject>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GameObject.FromPointer); // 0xA0 CashPanel                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CashPriceText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xA8 CashPriceText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ItemFluctionTextPair                      = GetObject<ValueFluctionTextPair>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.ValueFluctionTextPair.FromPointer); // 0xB0 ItemFluctionTextPair        ( ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer )
            value.PurchaseLimitPanel                        = GetObject<GameObject>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.GameObject.FromPointer); // 0xB8 PurchaseLimitPanel          ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CurrentPurchaseLimitText                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xC0 CurrentPurchaseLimitText    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AfterPurchaseLimitText                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xC8 AfterPurchaseLimitText      ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SpecifiedCommercialTransactionActButton   = GetObject<UIButton>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.UIButton.FromPointer); // 0xD0 SpecifiedCommercialTransactionActButton ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ActOnSettlementButton                     = GetObject<UIButton>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.UIButton.FromPointer); // 0xD8 ActOnSettlementButton       ( ModelClassType UIButton UIButton UIButton Pointer )
            value.CautionPanel                              = GetObject<GameObject>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.GameObject.FromPointer); // 0xE0 CautionPanel                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CautionText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xE8 CautionText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
