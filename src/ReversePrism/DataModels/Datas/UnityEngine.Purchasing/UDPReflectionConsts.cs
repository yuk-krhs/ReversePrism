using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_UdpEngineNamespace                     string IL2CPP_TYPE_STRING
    // 000 k_AppStoreSettingsType                   string IL2CPP_TYPE_STRING
    // 000 k_BuildConfigType                        string IL2CPP_TYPE_STRING
    // 000 k_InventoryType                          string IL2CPP_TYPE_STRING
    // 000 k_ProductInfoType                        string IL2CPP_TYPE_STRING
    // 000 k_StoreServiceType                       string IL2CPP_TYPE_STRING
    // 000 k_UdpIapBridgeType                       string IL2CPP_TYPE_STRING
    // 000 k_UserInfoType                           string IL2CPP_TYPE_STRING
    // 000 k_AppStoreSettingsClientIDField          string IL2CPP_TYPE_STRING
    // 000 k_AppStoreSettingsAppSlugField           string IL2CPP_TYPE_STRING
    // 000 k_AppStoreSettingsAssetPathField         string IL2CPP_TYPE_STRING
    // 000 k_BuildConfigApiEndpointField            string IL2CPP_TYPE_STRING
    // 000 k_BuildConfigIdEndpointField             string IL2CPP_TYPE_STRING
    // 000 k_BuildConfigUdpEndpointField            string IL2CPP_TYPE_STRING
    // 000 k_BuildConfigVersionField                string IL2CPP_TYPE_STRING
    // 000 k_InventoryGetProductListMethod          string IL2CPP_TYPE_STRING
    // 000 k_InventoryGetPurchaseInfoMethod         string IL2CPP_TYPE_STRING
    // 000 k_InventoryHasPurchaseMethod             string IL2CPP_TYPE_STRING
    // 000 k_ProductInfoCurrencyProp                string IL2CPP_TYPE_STRING
    // 000 k_ProductInfoDescProp                    string IL2CPP_TYPE_STRING
    // 000 k_ProductInfoPriceProp                   string IL2CPP_TYPE_STRING
    // 000 k_ProductnfoPriceAmountMicrosProp        string IL2CPP_TYPE_STRING
    // 000 k_ProductInfoIdProp                      string IL2CPP_TYPE_STRING
    // 000 k_ProductInfoTitleProp                   string IL2CPP_TYPE_STRING
    // 000 k_StoreServiceNameProp                   string IL2CPP_TYPE_STRING
    // 000 k_StoreServiceEnableDebugLoggingMethod   string IL2CPP_TYPE_STRING
    // 000 k_UdpIapBridgeInitMethod                 string IL2CPP_TYPE_STRING
    // 000 k_UdpIapBridgePurchaseMethod             string IL2CPP_TYPE_STRING
    // 000 k_UdpIapBridgeRetrieveProductsMethod     string IL2CPP_TYPE_STRING
    // 000 k_UdpIapBridgeFinishTransactionMethod    string IL2CPP_TYPE_STRING
    // 000 k_UserInfoChannelProp                    string IL2CPP_TYPE_STRING
    // 000 k_UserInfoIdProp                         string IL2CPP_TYPE_STRING
    // 000 k_UserInfoLoginTokenProp                 string IL2CPP_TYPE_STRING
    public partial class UDPReflectionConsts
    {

        public static UDPReflectionConsts? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UDPReflectionConsts();


            return value;
        }
    }
}
