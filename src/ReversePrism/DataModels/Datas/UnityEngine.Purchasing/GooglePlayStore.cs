using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_RetrieveProductsService                00018655F0D0 ModelClassType IGooglePlayStoreRetrieveProductsService IGooglePlayStoreRetrieveProductsService IGooglePlayStoreRetrieveProductsService Pointer
    // 018 M_StorePurchaseService                   00018655EBC0 ModelClassType IGooglePlayStorePurchaseService IGooglePlayStorePurchaseService IGooglePlayStorePurchaseService Pointer
    // 020 M_FetchPurchases                         00018655BEB0 ModelClassType IGoogleFetchPurchases IGoogleFetchPurchases IGoogleFetchPurchases Pointer
    // 028 M_FinishTransactionService               00018655E680 ModelClassType IGooglePlayStoreFinishTransactionService IGooglePlayStoreFinishTransactionService IGooglePlayStoreFinishTransactionService Pointer
    // 030 M_GooglePurchaseCallback                 000186560F00 ModelClassType IGooglePurchaseCallback IGooglePurchaseCallback IGooglePurchaseCallback Pointer
    // 038 M_GooglePlayStoreExtensions              00018655E1C0 ModelClassType IGooglePlayStoreExtensionsInternal IGooglePlayStoreExtensionsInternal IGooglePlayStoreExtensionsInternal Pointer
    // 040 M_GooglePlayConfigurationInternal        00018655D510 ModelClassType IGooglePlayConfigurationInternal IGooglePlayConfigurationInternal IGooglePlayConfigurationInternal Pointer
    // 048 M_Util                                   0001866905E0 ModelClassType IUtil IUtil IUtil Pointer
    public partial class GooglePlayStore : DataModel
    {
        public IGooglePlayStoreRetrieveProductsService? M_RetrieveProductsService               { get; set; }
        public IGooglePlayStorePurchaseService?         M_StorePurchaseService                  { get; set; }
        public IGoogleFetchPurchases?                   M_FetchPurchases                        { get; set; }
        public IGooglePlayStoreFinishTransactionService? M_FinishTransactionService              { get; set; }
        public IGooglePurchaseCallback?                 M_GooglePurchaseCallback                { get; set; }
        public IGooglePlayStoreExtensionsInternal?      M_GooglePlayStoreExtensions             { get; set; }
        public IGooglePlayConfigurationInternal?        M_GooglePlayConfigurationInternal       { get; set; }
        public IUtil?                                   M_Util                                  { get; set; }

        public static GooglePlayStore? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GooglePlayStore() { Pointer= p0 };

            value.M_RetrieveProductsService                 = GetObject<IGooglePlayStoreRetrieveProductsService>(new IntPtr(p + 0x010), ReversePrism.DataModels.IGooglePlayStoreRetrieveProductsService.FromPointer); // 0245A68CCED8 0x10 M_RetrieveProductsService   ( 00018655F0D0 ModelClassType IGooglePlayStoreRetrieveProductsService IGooglePlayStoreRetrieveProductsService IGooglePlayStoreRetrieveProductsService Pointer )
            value.M_StorePurchaseService                    = GetObject<IGooglePlayStorePurchaseService>(new IntPtr(p + 0x018), ReversePrism.DataModels.IGooglePlayStorePurchaseService.FromPointer); // 0245A68CCEF8 0x18 M_StorePurchaseService      ( 00018655EBC0 ModelClassType IGooglePlayStorePurchaseService IGooglePlayStorePurchaseService IGooglePlayStorePurchaseService Pointer )
            value.M_FetchPurchases                          = GetObject<IGoogleFetchPurchases>(new IntPtr(p + 0x020), ReversePrism.DataModels.IGoogleFetchPurchases.FromPointer); // 0245A68CCF18 0x20 M_FetchPurchases            ( 00018655BEB0 ModelClassType IGoogleFetchPurchases IGoogleFetchPurchases IGoogleFetchPurchases Pointer )
            value.M_FinishTransactionService                = GetObject<IGooglePlayStoreFinishTransactionService>(new IntPtr(p + 0x028), ReversePrism.DataModels.IGooglePlayStoreFinishTransactionService.FromPointer); // 0245A68CCF38 0x28 M_FinishTransactionService  ( 00018655E680 ModelClassType IGooglePlayStoreFinishTransactionService IGooglePlayStoreFinishTransactionService IGooglePlayStoreFinishTransactionService Pointer )
            value.M_GooglePurchaseCallback                  = GetObject<IGooglePurchaseCallback>(new IntPtr(p + 0x030), ReversePrism.DataModels.IGooglePurchaseCallback.FromPointer); // 0245A68CCF58 0x30 M_GooglePurchaseCallback    ( 000186560F00 ModelClassType IGooglePurchaseCallback IGooglePurchaseCallback IGooglePurchaseCallback Pointer )
            value.M_GooglePlayStoreExtensions               = GetObject<IGooglePlayStoreExtensionsInternal>(new IntPtr(p + 0x038), ReversePrism.DataModels.IGooglePlayStoreExtensionsInternal.FromPointer); // 0245A68CCF78 0x38 M_GooglePlayStoreExtensions ( 00018655E1C0 ModelClassType IGooglePlayStoreExtensionsInternal IGooglePlayStoreExtensionsInternal IGooglePlayStoreExtensionsInternal Pointer )
            value.M_GooglePlayConfigurationInternal         = GetObject<IGooglePlayConfigurationInternal>(new IntPtr(p + 0x040), ReversePrism.DataModels.IGooglePlayConfigurationInternal.FromPointer); // 0245A68CCF98 0x40 M_GooglePlayConfigurationInternal ( 00018655D510 ModelClassType IGooglePlayConfigurationInternal IGooglePlayConfigurationInternal IGooglePlayConfigurationInternal Pointer )
            value.M_Util                                    = GetObject<IUtil>(new IntPtr(p + 0x048), ReversePrism.DataModels.IUtil.FromPointer); // 0245A68CCFB8 0x48 M_Util                      ( 0001866905E0 ModelClassType IUtil IUtil IUtil Pointer )

            return value;
        }
    }
}
