using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GetDocument                              Method`2<IGetDocumentArgs, IGetDocumentReply> IL2CPP_TYPE_GENERICINST
    // 018 GetShopItemGroupList                     Method`2<IGetShopItemGroupListArgs, IGetShopItemGroupListReply> IL2CPP_TYPE_GENERICINST
    // 030 PurchaseShopItem                         Method`2<IPurchaseShopItemArgs, IPurchaseShopItemReply> IL2CPP_TYPE_GENERICINST
    // 048 ReceivePurchaseCountBenefit              Method`2<IReceivePurchaseCountBenefitArgs, IReceivePurchaseCountBenefitReply> IL2CPP_TYPE_GENERICINST
    // 060 GetShopPurchaseHistory                   Method`2<IGetShopPurchaseHistoryArgs, IGetShopPurchaseHistoryReply> IL2CPP_TYPE_GENERICINST
    // 078 GetShopItemJewelGroup                    Method`2<IGetShopItemJewelGroupArgs, IGetShopItemJewelGroupReply> IL2CPP_TYPE_GENERICINST
    // 090 GetShopItemItemGroup                     Method`2<IGetShopItemItemGroupArgs, IGetShopItemItemGroupReply> IL2CPP_TYPE_GENERICINST
    // 0A8 GetShopItemSeasonPassGroup               Method`2<IGetShopItemSeasonPassGroupArgs, IGetShopItemSeasonPassGroupReply> IL2CPP_TYPE_GENERICINST
    // 0C0 GetShopItemLoginBonusPassGroup           Method`2<IGetShopItemLoginBonusPassGroupArgs, IGetShopItemLoginBonusPassGroupReply> IL2CPP_TYPE_GENERICINST
    // 0D8 GetShopItemCostumeGroup                  Method`2<IGetShopItemCostumeGroupArgs, IGetShopItemCostumeGroupReply> IL2CPP_TYPE_GENERICINST
    public partial class ShopServiceMethods
    {

        public static ShopServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopServiceMethods();


            return value;
        }
    }
}
