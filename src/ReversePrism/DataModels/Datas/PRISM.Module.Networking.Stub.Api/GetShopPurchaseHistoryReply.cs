using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetShopPurchaseHistoryReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 StoreItemPurchaseHistoryFieldNumber      int IL2CPP_TYPE_I4
    // 018 StoreItemPurchaseHistory                 0001865916F0 ModelClassType StoreItemPurchaseHistoryStatus StoreItemPurchaseHistoryStatus StoreItemPurchaseHistoryStatus Pointer
    // 000 ShopItemPurchaseHistoryFieldNumber       int IL2CPP_TYPE_I4
    // 020 ShopItemPurchaseHistory                  0001867605E0 ModelClassType ShopItemPurchaseHistoryStatus ShopItemPurchaseHistoryStatus ShopItemPurchaseHistoryStatus Pointer
    public partial class GetShopPurchaseHistoryReply
    {
        public StoreItemPurchaseHistoryStatus?          StoreItemPurchaseHistory                { get; set; }
        public ShopItemPurchaseHistoryStatus?           ShopItemPurchaseHistory                 { get; set; }

        public static GetShopPurchaseHistoryReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetShopPurchaseHistoryReply();

            value.StoreItemPurchaseHistory                  = GetObject<StoreItemPurchaseHistoryStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.StoreItemPurchaseHistoryStatus.FromPointer); // 0270D27F0188 0x18 StoreItemPurchaseHistory    ( 0001865916F0 ModelClassType StoreItemPurchaseHistoryStatus StoreItemPurchaseHistoryStatus StoreItemPurchaseHistoryStatus Pointer )
            value.ShopItemPurchaseHistory                   = GetObject<ShopItemPurchaseHistoryStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ShopItemPurchaseHistoryStatus.FromPointer); // 0270D27F01C8 0x20 ShopItemPurchaseHistory     ( 0001867605E0 ModelClassType ShopItemPurchaseHistoryStatus ShopItemPurchaseHistoryStatus ShopItemPurchaseHistoryStatus Pointer )

            return value;
        }
    }
}
