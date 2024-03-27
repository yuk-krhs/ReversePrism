using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<PurchaseShopItemReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 BeforeShopItemFieldNumber                int IL2CPP_TYPE_I4
    // 018 BeforeShopItem                           000186761440 ModelClassType ShopItemStatus ShopItemStatus ShopItemStatus Pointer
    // 000 AfterShopItemFieldNumber                 int IL2CPP_TYPE_I4
    // 020 AfterShopItem                            000186761440 ModelClassType ShopItemStatus ShopItemStatus ShopItemStatus Pointer
    // 000 AmountFieldNumber                        int IL2CPP_TYPE_I4
    // 028 Amount                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 UpdatedHavingProductGroupFieldNumber     int IL2CPP_TYPE_I4
    // 030 UpdatedHavingProductGroup                0001866ACFE0 ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer
    public partial class PurchaseShopItemReply
    {
        public ShopItemStatus?                          BeforeShopItem                          { get; set; }
        public ShopItemStatus?                          AfterShopItem                           { get; set; }
        public int                                      Amount                                  { get; set; }
        public HavingProductGroupStatus?                UpdatedHavingProductGroup               { get; set; }

        public static PurchaseShopItemReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PurchaseShopItemReply();

            value.BeforeShopItem                            = GetObject<ShopItemStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ShopItemStatus.FromPointer); // 0270D27F2180 0x18 BeforeShopItem              ( 000186761440 ModelClassType ShopItemStatus ShopItemStatus ShopItemStatus Pointer )
            value.AfterShopItem                             = GetObject<ShopItemStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ShopItemStatus.FromPointer); // 0270D27F21C0 0x20 AfterShopItem               ( 000186761440 ModelClassType ShopItemStatus ShopItemStatus ShopItemStatus Pointer )
            value.Amount                                    = GetInt32(new IntPtr(p + 0x028)); // 0270D27F2200 0x28 Amount                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UpdatedHavingProductGroup                 = GetObject<HavingProductGroupStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.HavingProductGroupStatus.FromPointer); // 0270D27F2240 0x30 UpdatedHavingProductGroup   ( 0001866ACFE0 ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer )

            return value;
        }
    }
}
