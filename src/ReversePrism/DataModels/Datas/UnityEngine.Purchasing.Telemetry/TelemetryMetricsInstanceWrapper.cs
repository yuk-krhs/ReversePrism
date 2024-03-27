using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Instance                               0001865B2F70 ModelClassType IMetrics IMetrics IMetrics Pointer
    // 018 M_Logger                                 0001865A1000 ModelClassType ILogger ILogger ILogger Pointer
    // 020 M_Util                                   0001866900E0 ModelClassType IUtil IUtil IUtil Pointer
    // 028 m_Queue                                  TelemetryQueue`1<TelemetryMetricParams> IL2CPP_TYPE_GENERICINST
    public partial class TelemetryMetricsInstanceWrapper
    {
        public IMetrics?                                M_Instance                              { get; set; }
        public ILogger?                                 M_Logger                                { get; set; }
        public IUtil?                                   M_Util                                  { get; set; }

        public static TelemetryMetricsInstanceWrapper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TelemetryMetricsInstanceWrapper();

            value.M_Instance                                = GetObject<IMetrics>(new IntPtr(p + 0x010), ReversePrism.DataModels.IMetrics.FromPointer); // 027006930A30 0x10 M_Instance                  ( 0001865B2F70 ModelClassType IMetrics IMetrics IMetrics Pointer )
            value.M_Logger                                  = GetObject<ILogger>(new IntPtr(p + 0x018), ReversePrism.DataModels.ILogger.FromPointer); // 027006930A50 0x18 M_Logger                    ( 0001865A1000 ModelClassType ILogger ILogger ILogger Pointer )
            value.M_Util                                    = GetObject<IUtil>(new IntPtr(p + 0x020), ReversePrism.DataModels.IUtil.FromPointer); // 027006930A70 0x20 M_Util                      ( 0001866900E0 ModelClassType IUtil IUtil IUtil Pointer )

            return value;
        }
    }
}
