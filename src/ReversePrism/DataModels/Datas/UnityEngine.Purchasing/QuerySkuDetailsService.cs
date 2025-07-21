using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_BillingClient                          ModelClassType IGoogleBillingClient IGoogleBillingClient IGoogleBillingClient Pointer
    // 018 M_GoogleCachedQuerySkuDetailsService     ModelClassType IGoogleCachedQuerySkuDetailsService IGoogleCachedQuerySkuDetailsService IGoogleCachedQuerySkuDetailsService Pointer
    // 020 M_SkuDetailsConverter                    ModelClassType ISkuDetailsConverter ISkuDetailsConverter ISkuDetailsConverter Pointer
    // 028 M_RetryPolicy                            ModelClassType IRetryPolicy IRetryPolicy IRetryPolicy Pointer
    // 030 M_GoogleProductCallback                  ModelClassType IGoogleProductCallback IGoogleProductCallback IGoogleProductCallback Pointer
    // 038 M_Util                                   ModelClassType IUtil IUtil IUtil Pointer
    // 040 M_TelemetryDiagnostics                   ModelClassType ITelemetryDiagnostics ITelemetryDiagnostics ITelemetryDiagnostics Pointer
    public partial class QuerySkuDetailsService : DataModel
    {
        public IGoogleBillingClient?                    M_BillingClient                         { get; set; }
        public IGoogleCachedQuerySkuDetailsService?     M_GoogleCachedQuerySkuDetailsService    { get; set; }
        public ISkuDetailsConverter?                    M_SkuDetailsConverter                   { get; set; }
        public IRetryPolicy?                            M_RetryPolicy                           { get; set; }
        public IGoogleProductCallback?                  M_GoogleProductCallback                 { get; set; }
        public IUtil?                                   M_Util                                  { get; set; }
        public ITelemetryDiagnostics?                   M_TelemetryDiagnostics                  { get; set; }

        public static QuerySkuDetailsService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new QuerySkuDetailsService() { Pointer= p0 };

            value.M_BillingClient                           = GetObject<IGoogleBillingClient>(new IntPtr(p + 0x010), ReversePrism.DataModels.IGoogleBillingClient.FromPointer); // 0x10 M_BillingClient             ( ModelClassType IGoogleBillingClient IGoogleBillingClient IGoogleBillingClient Pointer )
            value.M_GoogleCachedQuerySkuDetailsService      = GetObject<IGoogleCachedQuerySkuDetailsService>(new IntPtr(p + 0x018), ReversePrism.DataModels.IGoogleCachedQuerySkuDetailsService.FromPointer); // 0x18 M_GoogleCachedQuerySkuDetailsService ( ModelClassType IGoogleCachedQuerySkuDetailsService IGoogleCachedQuerySkuDetailsService IGoogleCachedQuerySkuDetailsService Pointer )
            value.M_SkuDetailsConverter                     = GetObject<ISkuDetailsConverter>(new IntPtr(p + 0x020), ReversePrism.DataModels.ISkuDetailsConverter.FromPointer); // 0x20 M_SkuDetailsConverter       ( ModelClassType ISkuDetailsConverter ISkuDetailsConverter ISkuDetailsConverter Pointer )
            value.M_RetryPolicy                             = GetObject<IRetryPolicy>(new IntPtr(p + 0x028), ReversePrism.DataModels.IRetryPolicy.FromPointer); // 0x28 M_RetryPolicy               ( ModelClassType IRetryPolicy IRetryPolicy IRetryPolicy Pointer )
            value.M_GoogleProductCallback                   = GetObject<IGoogleProductCallback>(new IntPtr(p + 0x030), ReversePrism.DataModels.IGoogleProductCallback.FromPointer); // 0x30 M_GoogleProductCallback     ( ModelClassType IGoogleProductCallback IGoogleProductCallback IGoogleProductCallback Pointer )
            value.M_Util                                    = GetObject<IUtil>(new IntPtr(p + 0x038), ReversePrism.DataModels.IUtil.FromPointer); // 0x38 M_Util                      ( ModelClassType IUtil IUtil IUtil Pointer )
            value.M_TelemetryDiagnostics                    = GetObject<ITelemetryDiagnostics>(new IntPtr(p + 0x040), ReversePrism.DataModels.ITelemetryDiagnostics.FromPointer); // 0x40 M_TelemetryDiagnostics      ( ModelClassType ITelemetryDiagnostics ITelemetryDiagnostics ITelemetryDiagnostics Pointer )

            return value;
        }
    }
}
