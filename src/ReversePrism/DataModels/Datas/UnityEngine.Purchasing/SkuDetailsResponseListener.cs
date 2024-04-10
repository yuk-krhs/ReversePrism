using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_AndroidSkuDetailsResponseListenerClassName string IL2CPP_TYPE_STRING
    // 020 m_OnSkuDetailsResponse                   Action`2<IGoogleBillingResult, List`1<AndroidJavaObject>> IL2CPP_TYPE_GENERICINST
    // 028 M_Util                                   0001866905E0 ModelClassType IUtil IUtil IUtil Pointer
    // 030 M_TelemetryDiagnostics                   00018666E030 ModelClassType ITelemetryDiagnostics ITelemetryDiagnostics ITelemetryDiagnostics Pointer
    public partial class SkuDetailsResponseListener : DataModel
    {
        public IUtil?                                   M_Util                                  { get; set; }
        public ITelemetryDiagnostics?                   M_TelemetryDiagnostics                  { get; set; }

        public static SkuDetailsResponseListener? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SkuDetailsResponseListener() { Pointer= p0 };

            value.M_Util                                    = GetObject<IUtil>(new IntPtr(p + 0x028), ReversePrism.DataModels.IUtil.FromPointer); // 0245A68C9320 0x28 M_Util                      ( 0001866905E0 ModelClassType IUtil IUtil IUtil Pointer )
            value.M_TelemetryDiagnostics                    = GetObject<ITelemetryDiagnostics>(new IntPtr(p + 0x030), ReversePrism.DataModels.ITelemetryDiagnostics.FromPointer); // 0245A68C9340 0x30 M_TelemetryDiagnostics      ( 00018666E030 ModelClassType ITelemetryDiagnostics ITelemetryDiagnostics ITelemetryDiagnostics Pointer )

            return value;
        }
    }
}
