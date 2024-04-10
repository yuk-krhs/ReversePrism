using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_MaxConnectionAttempts                  int IL2CPP_TYPE_I4
    // 010 M_CurrentConnectionAttempts              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 M_BillingClient                          00018655AFC0 ModelClassType IGoogleBillingClient IGoogleBillingClient IGoogleBillingClient Pointer
    // 020 M_BillingClientStateListener             00018670F8E0 ModelClassType IBillingClientStateListener IBillingClientStateListener IBillingClientStateListener Pointer
    // 028 M_QuerySkuDetailsService                 00018660C000 ModelClassType IQuerySkuDetailsService IQuerySkuDetailsService IQuerySkuDetailsService Pointer
    // 030 m_ProductsToQuery                        ConcurrentQueue`1<ProductDescriptionQuery> IL2CPP_TYPE_GENERICINST
    // 038 m_OnPurchaseSucceededQueue               ConcurrentQueue`1<Action`1<List`1<IGooglePurchase>>> IL2CPP_TYPE_GENERICINST
    // 040 M_GooglePurchaseService                  000186561400 ModelClassType IGooglePurchaseService IGooglePurchaseService IGooglePurchaseService Pointer
    // 048 M_GoogleFinishTransactionService         00018655C370 ModelClassType IGoogleFinishTransactionService IGoogleFinishTransactionService IGoogleFinishTransactionService Pointer
    // 050 M_GoogleQueryPurchasesService            0001865622D0 ModelClassType IGoogleQueryPurchasesService IGoogleQueryPurchasesService IGoogleQueryPurchasesService Pointer
    // 058 M_GooglePriceChangeService               00018655FAB0 ModelClassType IGooglePriceChangeService IGooglePriceChangeService IGooglePriceChangeService Pointer
    // 060 M_GoogleLastKnownProductService          00018655C890 ModelClassType IGoogleLastKnownProductService IGoogleLastKnownProductService IGoogleLastKnownProductService Pointer
    // 068 M_TelemetryDiagnostics                   00018666E030 ModelClassType ITelemetryDiagnostics ITelemetryDiagnostics ITelemetryDiagnostics Pointer
    // 070 M_Logger                                 0001865A19E0 ModelClassType ILogger ILogger ILogger Pointer
    public partial class GooglePlayStoreService : DataModel
    {
        public int                                      M_CurrentConnectionAttempts             { get; set; }
        public IGoogleBillingClient?                    M_BillingClient                         { get; set; }
        public IBillingClientStateListener?             M_BillingClientStateListener            { get; set; }
        public IQuerySkuDetailsService?                 M_QuerySkuDetailsService                { get; set; }
        public IGooglePurchaseService?                  M_GooglePurchaseService                 { get; set; }
        public IGoogleFinishTransactionService?         M_GoogleFinishTransactionService        { get; set; }
        public IGoogleQueryPurchasesService?            M_GoogleQueryPurchasesService           { get; set; }
        public IGooglePriceChangeService?               M_GooglePriceChangeService              { get; set; }
        public IGoogleLastKnownProductService?          M_GoogleLastKnownProductService         { get; set; }
        public ITelemetryDiagnostics?                   M_TelemetryDiagnostics                  { get; set; }
        public ILogger?                                 M_Logger                                { get; set; }

        public static GooglePlayStoreService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GooglePlayStoreService() { Pointer= p0 };

            value.M_CurrentConnectionAttempts               = GetInt32(new IntPtr(p + 0x010)); // 0245A68C4FA0 0x10 M_CurrentConnectionAttempts ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_BillingClient                           = GetObject<IGoogleBillingClient>(new IntPtr(p + 0x018), ReversePrism.DataModels.IGoogleBillingClient.FromPointer); // 0245A68C4FC0 0x18 M_BillingClient             ( 00018655AFC0 ModelClassType IGoogleBillingClient IGoogleBillingClient IGoogleBillingClient Pointer )
            value.M_BillingClientStateListener              = GetObject<IBillingClientStateListener>(new IntPtr(p + 0x020), ReversePrism.DataModels.IBillingClientStateListener.FromPointer); // 0245A68C4FE0 0x20 M_BillingClientStateListener ( 00018670F8E0 ModelClassType IBillingClientStateListener IBillingClientStateListener IBillingClientStateListener Pointer )
            value.M_QuerySkuDetailsService                  = GetObject<IQuerySkuDetailsService>(new IntPtr(p + 0x028), ReversePrism.DataModels.IQuerySkuDetailsService.FromPointer); // 0245A68C5000 0x28 M_QuerySkuDetailsService    ( 00018660C000 ModelClassType IQuerySkuDetailsService IQuerySkuDetailsService IQuerySkuDetailsService Pointer )
            value.M_GooglePurchaseService                   = GetObject<IGooglePurchaseService>(new IntPtr(p + 0x040), ReversePrism.DataModels.IGooglePurchaseService.FromPointer); // 0245A68C5060 0x40 M_GooglePurchaseService     ( 000186561400 ModelClassType IGooglePurchaseService IGooglePurchaseService IGooglePurchaseService Pointer )
            value.M_GoogleFinishTransactionService          = GetObject<IGoogleFinishTransactionService>(new IntPtr(p + 0x048), ReversePrism.DataModels.IGoogleFinishTransactionService.FromPointer); // 0245A68C5080 0x48 M_GoogleFinishTransactionService ( 00018655C370 ModelClassType IGoogleFinishTransactionService IGoogleFinishTransactionService IGoogleFinishTransactionService Pointer )
            value.M_GoogleQueryPurchasesService             = GetObject<IGoogleQueryPurchasesService>(new IntPtr(p + 0x050), ReversePrism.DataModels.IGoogleQueryPurchasesService.FromPointer); // 0245A68C50A0 0x50 M_GoogleQueryPurchasesService ( 0001865622D0 ModelClassType IGoogleQueryPurchasesService IGoogleQueryPurchasesService IGoogleQueryPurchasesService Pointer )
            value.M_GooglePriceChangeService                = GetObject<IGooglePriceChangeService>(new IntPtr(p + 0x058), ReversePrism.DataModels.IGooglePriceChangeService.FromPointer); // 0245A68C50C0 0x58 M_GooglePriceChangeService  ( 00018655FAB0 ModelClassType IGooglePriceChangeService IGooglePriceChangeService IGooglePriceChangeService Pointer )
            value.M_GoogleLastKnownProductService           = GetObject<IGoogleLastKnownProductService>(new IntPtr(p + 0x060), ReversePrism.DataModels.IGoogleLastKnownProductService.FromPointer); // 0245A68C50E0 0x60 M_GoogleLastKnownProductService ( 00018655C890 ModelClassType IGoogleLastKnownProductService IGoogleLastKnownProductService IGoogleLastKnownProductService Pointer )
            value.M_TelemetryDiagnostics                    = GetObject<ITelemetryDiagnostics>(new IntPtr(p + 0x068), ReversePrism.DataModels.ITelemetryDiagnostics.FromPointer); // 0245A68C5100 0x68 M_TelemetryDiagnostics      ( 00018666E030 ModelClassType ITelemetryDiagnostics ITelemetryDiagnostics ITelemetryDiagnostics Pointer )
            value.M_Logger                                  = GetObject<ILogger>(new IntPtr(p + 0x070), ReversePrism.DataModels.ILogger.FromPointer); // 0245A68C5120 0x70 M_Logger                    ( 0001865A19E0 ModelClassType ILogger ILogger ILogger Pointer )

            return value;
        }
    }
}
