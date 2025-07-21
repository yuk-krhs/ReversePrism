using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StoreHistory                             ModelClassType IStoreItemPurchaseHistoryStatus IStoreItemPurchaseHistoryStatus IStoreItemPurchaseHistoryStatus Pointer
    // 018 ItemHistory                              ModelClassType IShopItemPurchaseHistoryStatus IShopItemPurchaseHistoryStatus IShopItemPurchaseHistoryStatus Pointer
    // 020 HistoryListItems                         ModelClassListType List`1<ShopPurchaseHistoryListItemViewModel> List`1<ShopPurchaseHistoryListItemViewModel> List<ShopPurchaseHistoryListItemViewModel> Pointer
    // 028 CurrentTabType                           ModelEnumType ShopItemType ShopItemType ShopItemType Int32
    public partial class ShopPurchaseHistoryViewModel : DataModel
    {
        public IStoreItemPurchaseHistoryStatus?         StoreHistory                            { get; set; }
        public IShopItemPurchaseHistoryStatus?          ItemHistory                             { get; set; }
        public List<ShopPurchaseHistoryListItemViewModel>? HistoryListItems                        { get; set; }
        public ShopItemType                             CurrentTabType                          { get; set; }

        public static ShopPurchaseHistoryViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopPurchaseHistoryViewModel() { Pointer= p0 };

            value.StoreHistory                              = GetObject<IStoreItemPurchaseHistoryStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStoreItemPurchaseHistoryStatus.FromPointer); // 0x10 StoreHistory                ( ModelClassType IStoreItemPurchaseHistoryStatus IStoreItemPurchaseHistoryStatus IStoreItemPurchaseHistoryStatus Pointer )
            value.ItemHistory                               = GetObject<IShopItemPurchaseHistoryStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IShopItemPurchaseHistoryStatus.FromPointer); // 0x18 ItemHistory                 ( ModelClassType IShopItemPurchaseHistoryStatus IShopItemPurchaseHistoryStatus IShopItemPurchaseHistoryStatus Pointer )
            value.HistoryListItems                          = GetObjectList<ShopPurchaseHistoryListItemViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.ShopPurchaseHistoryListItemViewModel.FromPointer); // 0x20 HistoryListItems            ( ModelClassListType List`1<ShopPurchaseHistoryListItemViewModel> List`1<ShopPurchaseHistoryListItemViewModel> List<ShopPurchaseHistoryListItemViewModel> Pointer )
            value.CurrentTabType                            = (ShopItemType)GetInt32(new IntPtr(p + 0x028)); // 0x28 CurrentTabType              ( ModelEnumType ShopItemType ShopItemType ShopItemType Int32 )

            return value;
        }
    }
}
