using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_AndroidSkuDetailsParamClassName        string IL2CPP_TYPE_STRING
    // 000 k_AndroidBillingFlowParamClassName       string IL2CPP_TYPE_STRING
    // 000 k_AndroidSubscriptionUpdateParamClassName string IL2CPP_TYPE_STRING
    // 000 k_AndroidPriceChangeFlowParamClassName   string IL2CPP_TYPE_STRING
    // 000 k_AndroidConsumeParamsClassName          string IL2CPP_TYPE_STRING
    // 000 k_AndroidAcknowledgePurchaseParamsClassName string IL2CPP_TYPE_STRING
    // 000 k_AndroidBillingClientClassName          string IL2CPP_TYPE_STRING
    // 010 M_BillingClient                          0001866AD7E0 ModelClassType AndroidJavaObject AndroidJavaObject AndroidJavaObject Pointer
    // 018 M_ObfuscatedAccountId                    000186671910 ModelPrimitiveType string string string String
    // 020 M_ObfuscatedProfileId                    000186671910 ModelPrimitiveType string string string String
    // 028 M_Util                                   0001866905E0 ModelClassType IUtil IUtil IUtil Pointer
    // 030 M_TelemetryDiagnostics                   00018666E030 ModelClassType ITelemetryDiagnostics ITelemetryDiagnostics ITelemetryDiagnostics Pointer
    public partial class GoogleBillingClient
    {
        public AndroidJavaObject?                       M_BillingClient                         { get; set; }
        public string                                   M_ObfuscatedAccountId                   { get; set; }
        public string                                   M_ObfuscatedProfileId                   { get; set; }
        public IUtil?                                   M_Util                                  { get; set; }
        public ITelemetryDiagnostics?                   M_TelemetryDiagnostics                  { get; set; }

        public static GoogleBillingClient? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GoogleBillingClient();

            value.M_BillingClient                           = GetObject<AndroidJavaObject>(new IntPtr(p + 0x010), ReversePrism.DataModels.AndroidJavaObject.FromPointer); // 027006924928 0x10 M_BillingClient             ( 0001866AD7E0 ModelClassType AndroidJavaObject AndroidJavaObject AndroidJavaObject Pointer )
            value.M_ObfuscatedAccountId                     = GetString(new IntPtr(p + 0x018)); // 027006924948 0x18 M_ObfuscatedAccountId       ( 000186671910 ModelPrimitiveType string string string String )
            value.M_ObfuscatedProfileId                     = GetString(new IntPtr(p + 0x020)); // 027006924968 0x20 M_ObfuscatedProfileId       ( 000186671910 ModelPrimitiveType string string string String )
            value.M_Util                                    = GetObject<IUtil>(new IntPtr(p + 0x028), ReversePrism.DataModels.IUtil.FromPointer); // 027006924988 0x28 M_Util                      ( 0001866905E0 ModelClassType IUtil IUtil IUtil Pointer )
            value.M_TelemetryDiagnostics                    = GetObject<ITelemetryDiagnostics>(new IntPtr(p + 0x030), ReversePrism.DataModels.ITelemetryDiagnostics.FromPointer); // 0270069249A8 0x30 M_TelemetryDiagnostics      ( 00018666E030 ModelClassType ITelemetryDiagnostics ITelemetryDiagnostics ITelemetryDiagnostics Pointer )

            return value;
        }
    }
}
