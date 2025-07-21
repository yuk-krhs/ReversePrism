using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Analytics                              ModelClassType IAnalyticsService IAnalyticsService IAnalyticsService Pointer
    // 018 M_Logger                                 ModelClassType ILogger ILogger ILogger Pointer
    // 020 M_CoreAnalytics                          ModelClassType IAnalyticsStandardEventComponent IAnalyticsStandardEventComponent IAnalyticsStandardEventComponent Pointer
    // 000 k_TransactionEventName                   string IL2CPP_TYPE_STRING
    // 000 k_TransactionFailedEventName             string IL2CPP_TYPE_STRING
    // 000 k_PurchasingPackageName                  string IL2CPP_TYPE_STRING
    // 000 k_TransactionEventVersion                int IL2CPP_TYPE_I4
    // 000 k_TransactionFailedEventVersion          int IL2CPP_TYPE_I4
    public partial class CoreAnalyticsAdapter : DataModel
    {
        public IAnalyticsService?                       M_Analytics                             { get; set; }
        public ILogger?                                 M_Logger                                { get; set; }
        public IAnalyticsStandardEventComponent?        M_CoreAnalytics                         { get; set; }

        public static CoreAnalyticsAdapter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CoreAnalyticsAdapter() { Pointer= p0 };

            value.M_Analytics                               = GetObject<IAnalyticsService>(new IntPtr(p + 0x010), ReversePrism.DataModels.IAnalyticsService.FromPointer); // 0x10 M_Analytics                 ( ModelClassType IAnalyticsService IAnalyticsService IAnalyticsService Pointer )
            value.M_Logger                                  = GetObject<ILogger>(new IntPtr(p + 0x018), ReversePrism.DataModels.ILogger.FromPointer); // 0x18 M_Logger                    ( ModelClassType ILogger ILogger ILogger Pointer )
            value.M_CoreAnalytics                           = GetObject<IAnalyticsStandardEventComponent>(new IntPtr(p + 0x020), ReversePrism.DataModels.IAnalyticsStandardEventComponent.FromPointer); // 0x20 M_CoreAnalytics             ( ModelClassType IAnalyticsStandardEventComponent IAnalyticsStandardEventComponent IAnalyticsStandardEventComponent Pointer )

            return value;
        }
    }
}
