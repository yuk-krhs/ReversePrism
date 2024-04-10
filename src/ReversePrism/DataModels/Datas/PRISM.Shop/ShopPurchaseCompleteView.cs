using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ItemIconImage                            000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 028 ItemNameText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 ProductDetailButton                      0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 038 InfoPanel                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 PurchaseAmountText                       0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 PaidjewelFluctionPair                    000186768A80 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer
    // 050 FreejewelFluctionPair                    000186768A80 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer
    // 058 ItemFluctionPair                         000186768A80 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer
    // 060 PurchaseLimitPanel                       00018675DFE0 ModelClassType ShopItemAmount ShopItemAmount ShopItemAmount Pointer
    // 068 OnClickProductDetailButton               Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class ShopPurchaseCompleteView : DataModel
    {
        public RawImage?                                ItemIconImage                           { get; set; }
        public UITextMeshProUGUI?                       ItemNameText                            { get; set; }
        public UIButton?                                ProductDetailButton                     { get; set; }
        public GameObject?                              InfoPanel                               { get; set; }
        public UITextMeshProUGUI?                       PurchaseAmountText                      { get; set; }
        public ValueFluctionTextPair?                   PaidjewelFluctionPair                   { get; set; }
        public ValueFluctionTextPair?                   FreejewelFluctionPair                   { get; set; }
        public ValueFluctionTextPair?                   ItemFluctionPair                        { get; set; }
        public ShopItemAmount?                          PurchaseLimitPanel                      { get; set; }

        public static ShopPurchaseCompleteView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopPurchaseCompleteView() { Pointer= p0 };

            value.ItemIconImage                             = GetObject<RawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.RawImage.FromPointer); // 0246655AA978 0x20 ItemIconImage               ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.ItemNameText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246655AA998 0x28 ItemNameText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ProductDetailButton                       = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0246655AA9B8 0x30 ProductDetailButton         ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.InfoPanel                                 = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0246655AA9D8 0x38 InfoPanel                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.PurchaseAmountText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246655AA9F8 0x40 PurchaseAmountText          ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PaidjewelFluctionPair                     = GetObject<ValueFluctionTextPair>(new IntPtr(p + 0x048), ReversePrism.DataModels.ValueFluctionTextPair.FromPointer); // 0246655AAA18 0x48 PaidjewelFluctionPair       ( 000186768A80 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer )
            value.FreejewelFluctionPair                     = GetObject<ValueFluctionTextPair>(new IntPtr(p + 0x050), ReversePrism.DataModels.ValueFluctionTextPair.FromPointer); // 0246655AAA38 0x50 FreejewelFluctionPair       ( 000186768A80 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer )
            value.ItemFluctionPair                          = GetObject<ValueFluctionTextPair>(new IntPtr(p + 0x058), ReversePrism.DataModels.ValueFluctionTextPair.FromPointer); // 0246655AAA58 0x58 ItemFluctionPair            ( 000186768A80 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer )
            value.PurchaseLimitPanel                        = GetObject<ShopItemAmount>(new IntPtr(p + 0x060), ReversePrism.DataModels.ShopItemAmount.FromPointer); // 0246655AAA78 0x60 PurchaseLimitPanel          ( 00018675DFE0 ModelClassType ShopItemAmount ShopItemAmount ShopItemAmount Pointer )

            return value;
        }
    }
}
