using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_GetDocumentArgs         Marshaller`1<GetDocumentArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_GetDocumentReply        Marshaller`1<GetDocumentReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_GetShopItemGroupListArgs Marshaller`1<GetShopItemGroupListArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_GetShopItemGroupListReply Marshaller`1<GetShopItemGroupListReply> IL2CPP_TYPE_GENERICINST
    // 028 __Marshaller_api_PurchaseShopItemArgs    Marshaller`1<PurchaseShopItemArgs> IL2CPP_TYPE_GENERICINST
    // 030 __Marshaller_api_PurchaseShopItemReply   Marshaller`1<PurchaseShopItemReply> IL2CPP_TYPE_GENERICINST
    // 038 __Marshaller_api_ReceivePurchaseCountBenefitArgs Marshaller`1<ReceivePurchaseCountBenefitArgs> IL2CPP_TYPE_GENERICINST
    // 040 __Marshaller_api_ReceivePurchaseCountBenefitReply Marshaller`1<ReceivePurchaseCountBenefitReply> IL2CPP_TYPE_GENERICINST
    // 048 __Marshaller_api_GetShopPurchaseHistoryArgs Marshaller`1<GetShopPurchaseHistoryArgs> IL2CPP_TYPE_GENERICINST
    // 050 __Marshaller_api_GetShopPurchaseHistoryReply Marshaller`1<GetShopPurchaseHistoryReply> IL2CPP_TYPE_GENERICINST
    // 058 __Marshaller_api_GetShopItemJewelGroupArgs Marshaller`1<GetShopItemJewelGroupArgs> IL2CPP_TYPE_GENERICINST
    // 060 __Marshaller_api_GetShopItemJewelGroupReply Marshaller`1<GetShopItemJewelGroupReply> IL2CPP_TYPE_GENERICINST
    // 068 __Marshaller_api_GetShopItemItemGroupArgs Marshaller`1<GetShopItemItemGroupArgs> IL2CPP_TYPE_GENERICINST
    // 070 __Marshaller_api_GetShopItemItemGroupReply Marshaller`1<GetShopItemItemGroupReply> IL2CPP_TYPE_GENERICINST
    // 078 __Marshaller_api_GetShopItemSeasonPassGroupArgs Marshaller`1<GetShopItemSeasonPassGroupArgs> IL2CPP_TYPE_GENERICINST
    // 080 __Marshaller_api_GetShopItemSeasonPassGroupReply Marshaller`1<GetShopItemSeasonPassGroupReply> IL2CPP_TYPE_GENERICINST
    // 088 __Marshaller_api_GetShopItemLoginBonusPassGroupArgs Marshaller`1<GetShopItemLoginBonusPassGroupArgs> IL2CPP_TYPE_GENERICINST
    // 090 __Marshaller_api_GetShopItemLoginBonusPassGroupReply Marshaller`1<GetShopItemLoginBonusPassGroupReply> IL2CPP_TYPE_GENERICINST
    // 098 __Marshaller_api_GetShopItemCostumeGroupArgs Marshaller`1<GetShopItemCostumeGroupArgs> IL2CPP_TYPE_GENERICINST
    // 0A0 __Marshaller_api_GetShopItemCostumeGroupReply Marshaller`1<GetShopItemCostumeGroupReply> IL2CPP_TYPE_GENERICINST
    // 0A8 __Method_GetDocument                     Method`2<GetDocumentArgs, GetDocumentReply> IL2CPP_TYPE_GENERICINST
    // 0B0 __Method_GetShopItemGroupList            Method`2<GetShopItemGroupListArgs, GetShopItemGroupListReply> IL2CPP_TYPE_GENERICINST
    // 0B8 __Method_PurchaseShopItem                Method`2<PurchaseShopItemArgs, PurchaseShopItemReply> IL2CPP_TYPE_GENERICINST
    // 0C0 __Method_ReceivePurchaseCountBenefit     Method`2<ReceivePurchaseCountBenefitArgs, ReceivePurchaseCountBenefitReply> IL2CPP_TYPE_GENERICINST
    // 0C8 __Method_GetShopPurchaseHistory          Method`2<GetShopPurchaseHistoryArgs, GetShopPurchaseHistoryReply> IL2CPP_TYPE_GENERICINST
    // 0D0 __Method_GetShopItemJewelGroup           Method`2<GetShopItemJewelGroupArgs, GetShopItemJewelGroupReply> IL2CPP_TYPE_GENERICINST
    // 0D8 __Method_GetShopItemItemGroup            Method`2<GetShopItemItemGroupArgs, GetShopItemItemGroupReply> IL2CPP_TYPE_GENERICINST
    // 0E0 __Method_GetShopItemSeasonPassGroup      Method`2<GetShopItemSeasonPassGroupArgs, GetShopItemSeasonPassGroupReply> IL2CPP_TYPE_GENERICINST
    // 0E8 __Method_GetShopItemLoginBonusPassGroup  Method`2<GetShopItemLoginBonusPassGroupArgs, GetShopItemLoginBonusPassGroupReply> IL2CPP_TYPE_GENERICINST
    // 0F0 __Method_GetShopItemCostumeGroup         Method`2<GetShopItemCostumeGroupArgs, GetShopItemCostumeGroupReply> IL2CPP_TYPE_GENERICINST
    public partial class ShopService
    {

        public static ShopService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopService();


            return value;
        }
    }
}
