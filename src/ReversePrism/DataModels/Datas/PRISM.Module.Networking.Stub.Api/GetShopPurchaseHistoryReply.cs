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
    // 018 StoreItemPurchaseHistory                 ModelClassType StoreItemPurchaseHistoryStatus StoreItemPurchaseHistoryStatus StoreItemPurchaseHistoryStatus Pointer
    // 000 ShopItemPurchaseHistoryFieldNumber       int IL2CPP_TYPE_I4
    // 020 ShopItemPurchaseHistory                  ModelClassType ShopItemPurchaseHistoryStatus ShopItemPurchaseHistoryStatus ShopItemPurchaseHistoryStatus Pointer
    public partial class GetShopPurchaseHistoryReply : DataModel
    {
        public StoreItemPurchaseHistoryStatus?          StoreItemPurchaseHistory                { get; set; }
        public ShopItemPurchaseHistoryStatus?           ShopItemPurchaseHistory                 { get; set; }

        public static GetShopPurchaseHistoryReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetShopPurchaseHistoryReply() { Pointer= p0 };

            value.StoreItemPurchaseHistory                  = GetObject<StoreItemPurchaseHistoryStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.StoreItemPurchaseHistoryStatus.FromPointer); // 0x18 StoreItemPurchaseHistory    ( ModelClassType StoreItemPurchaseHistoryStatus StoreItemPurchaseHistoryStatus StoreItemPurchaseHistoryStatus Pointer )
            value.ShopItemPurchaseHistory                   = GetObject<ShopItemPurchaseHistoryStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ShopItemPurchaseHistoryStatus.FromPointer); // 0x20 ShopItemPurchaseHistory     ( ModelClassType ShopItemPurchaseHistoryStatus ShopItemPurchaseHistoryStatus ShopItemPurchaseHistoryStatus Pointer )

            return value;
        }
    }
}
