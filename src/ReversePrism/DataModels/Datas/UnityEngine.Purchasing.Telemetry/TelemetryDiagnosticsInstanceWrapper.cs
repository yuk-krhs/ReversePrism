using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Instance                               00018674F3D0 ModelClassType IDiagnostics IDiagnostics IDiagnostics Pointer
    // 018 M_Logger                                 0001865A1000 ModelClassType ILogger ILogger ILogger Pointer
    // 020 M_Util                                   0001866900E0 ModelClassType IUtil IUtil IUtil Pointer
    // 028 m_Queue                                  TelemetryQueue`1<TelemetryDiagnosticParams> IL2CPP_TYPE_GENERICINST
    public partial class TelemetryDiagnosticsInstanceWrapper : DataModel
    {
        public IDiagnostics?                            M_Instance                              { get; set; }
        public ILogger?                                 M_Logger                                { get; set; }
        public IUtil?                                   M_Util                                  { get; set; }

        public static TelemetryDiagnosticsInstanceWrapper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TelemetryDiagnosticsInstanceWrapper() { Pointer= p0 };

            value.M_Instance                                = GetObject<IDiagnostics>(new IntPtr(p + 0x010), ReversePrism.DataModels.IDiagnostics.FromPointer); // 0245A68F3688 0x10 M_Instance                  ( 00018674F3D0 ModelClassType IDiagnostics IDiagnostics IDiagnostics Pointer )
            value.M_Logger                                  = GetObject<ILogger>(new IntPtr(p + 0x018), ReversePrism.DataModels.ILogger.FromPointer); // 0245A68F36A8 0x18 M_Logger                    ( 0001865A1000 ModelClassType ILogger ILogger ILogger Pointer )
            value.M_Util                                    = GetObject<IUtil>(new IntPtr(p + 0x020), ReversePrism.DataModels.IUtil.FromPointer); // 0245A68F36C8 0x20 M_Util                      ( 0001866900E0 ModelClassType IUtil IUtil IUtil Pointer )

            return value;
        }
    }
}
