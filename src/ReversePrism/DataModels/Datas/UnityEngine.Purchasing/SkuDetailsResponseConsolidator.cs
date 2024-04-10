using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_RequiredNumberOfCallbacks              int IL2CPP_TYPE_I4
    // 010 M_NumberReceivedCallbacks                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 m_OnSkuDetailsResponseConsolidated       Action`1<ISkuDetailsQueryResponse> IL2CPP_TYPE_GENERICINST
    // 020 M_Responses                              000186648330 ModelClassType ISkuDetailsQueryResponse ISkuDetailsQueryResponse ISkuDetailsQueryResponse Pointer
    // 028 M_Util                                   0001866905E0 ModelClassType IUtil IUtil IUtil Pointer
    // 030 M_TelemetryDiagnostics                   00018666E030 ModelClassType ITelemetryDiagnostics ITelemetryDiagnostics ITelemetryDiagnostics Pointer
    public partial class SkuDetailsResponseConsolidator : DataModel
    {
        public int                                      M_NumberReceivedCallbacks               { get; set; }
        public ISkuDetailsQueryResponse?                M_Responses                             { get; set; }
        public IUtil?                                   M_Util                                  { get; set; }
        public ITelemetryDiagnostics?                   M_TelemetryDiagnostics                  { get; set; }

        public static SkuDetailsResponseConsolidator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SkuDetailsResponseConsolidator() { Pointer= p0 };

            value.M_NumberReceivedCallbacks                 = GetInt32(new IntPtr(p + 0x010)); // 0245A68CB1B0 0x10 M_NumberReceivedCallbacks   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_Responses                               = GetObject<ISkuDetailsQueryResponse>(new IntPtr(p + 0x020), ReversePrism.DataModels.ISkuDetailsQueryResponse.FromPointer); // 0245A68CB1F0 0x20 M_Responses                 ( 000186648330 ModelClassType ISkuDetailsQueryResponse ISkuDetailsQueryResponse ISkuDetailsQueryResponse Pointer )
            value.M_Util                                    = GetObject<IUtil>(new IntPtr(p + 0x028), ReversePrism.DataModels.IUtil.FromPointer); // 0245A68CB210 0x28 M_Util                      ( 0001866905E0 ModelClassType IUtil IUtil IUtil Pointer )
            value.M_TelemetryDiagnostics                    = GetObject<ITelemetryDiagnostics>(new IntPtr(p + 0x030), ReversePrism.DataModels.ITelemetryDiagnostics.FromPointer); // 0245A68CB230 0x30 M_TelemetryDiagnostics      ( 00018666E030 ModelClassType ITelemetryDiagnostics ITelemetryDiagnostics ITelemetryDiagnostics Pointer )

            return value;
        }
    }
}
