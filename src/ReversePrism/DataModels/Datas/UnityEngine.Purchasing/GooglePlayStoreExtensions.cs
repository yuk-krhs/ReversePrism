using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_GooglePlayStoreService                 00018655F5C0 ModelClassType IGooglePlayStoreService IGooglePlayStoreService IGooglePlayStoreService Pointer
    // 018 M_GooglePlayStoreFinishTransactionService 00018655E680 ModelClassType IGooglePlayStoreFinishTransactionService IGooglePlayStoreFinishTransactionService IGooglePlayStoreFinishTransactionService Pointer
    // 020 M_TelemetryDiagnostics                   00018666E030 ModelClassType ITelemetryDiagnostics ITelemetryDiagnostics ITelemetryDiagnostics Pointer
    // 028 M_Logger                                 0001865A19E0 ModelClassType ILogger ILogger ILogger Pointer
    // 030 M_StoreCallback                          000186658CA0 ModelClassType IStoreCallback IStoreCallback IStoreCallback Pointer
    // 038 m_DeferredPurchaseAction                 Action`1<Product> IL2CPP_TYPE_GENERICINST
    // 040 m_DeferredProrationUpgradeDowngradeSubscriptionAction Action`1<Product> IL2CPP_TYPE_GENERICINST
    public partial class GooglePlayStoreExtensions
    {
        public IGooglePlayStoreService?                 M_GooglePlayStoreService                { get; set; }
        public IGooglePlayStoreFinishTransactionService? M_GooglePlayStoreFinishTransactionService { get; set; }
        public ITelemetryDiagnostics?                   M_TelemetryDiagnostics                  { get; set; }
        public ILogger?                                 M_Logger                                { get; set; }
        public IStoreCallback?                          M_StoreCallback                         { get; set; }

        public static GooglePlayStoreExtensions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GooglePlayStoreExtensions();

            value.M_GooglePlayStoreService                  = GetObject<IGooglePlayStoreService>(new IntPtr(p + 0x010), ReversePrism.DataModels.IGooglePlayStoreService.FromPointer); // 02700690A950 0x10 M_GooglePlayStoreService    ( 00018655F5C0 ModelClassType IGooglePlayStoreService IGooglePlayStoreService IGooglePlayStoreService Pointer )
            value.M_GooglePlayStoreFinishTransactionService = GetObject<IGooglePlayStoreFinishTransactionService>(new IntPtr(p + 0x018), ReversePrism.DataModels.IGooglePlayStoreFinishTransactionService.FromPointer); // 02700690A970 0x18 M_GooglePlayStoreFinishTransactionService ( 00018655E680 ModelClassType IGooglePlayStoreFinishTransactionService IGooglePlayStoreFinishTransactionService IGooglePlayStoreFinishTransactionService Pointer )
            value.M_TelemetryDiagnostics                    = GetObject<ITelemetryDiagnostics>(new IntPtr(p + 0x020), ReversePrism.DataModels.ITelemetryDiagnostics.FromPointer); // 02700690A990 0x20 M_TelemetryDiagnostics      ( 00018666E030 ModelClassType ITelemetryDiagnostics ITelemetryDiagnostics ITelemetryDiagnostics Pointer )
            value.M_Logger                                  = GetObject<ILogger>(new IntPtr(p + 0x028), ReversePrism.DataModels.ILogger.FromPointer); // 02700690A9B0 0x28 M_Logger                    ( 0001865A19E0 ModelClassType ILogger ILogger ILogger Pointer )
            value.M_StoreCallback                           = GetObject<IStoreCallback>(new IntPtr(p + 0x030), ReversePrism.DataModels.IStoreCallback.FromPointer); // 02700690A9D0 0x30 M_StoreCallback             ( 000186658CA0 ModelClassType IStoreCallback IStoreCallback IStoreCallback Pointer )

            return value;
        }
    }
}
