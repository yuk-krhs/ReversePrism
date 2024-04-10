using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NumThrottlingEventSinceStartup           0001865F7E40 ModelPrimitiveType long long long Int64
    // 018 NumThrottlingImminentEventSinceStartup   0001865F7E40 ModelPrimitiveType long long long Int64
    // 020 NumNoWarningEventSinceStartup            0001865F7E40 ModelPrimitiveType long long long Int64
    // 028 CurrentTempTrend                         000186666050 ModelPrimitiveType float float float Single
    // 02C CurrentTempLevel                         000186666050 ModelPrimitiveType float float float Single
    public partial class AdaptivePerformanceThermalAnalyticsEvent : DataModel
    {
        public long                                     NumThrottlingEventSinceStartup          { get; set; }
        public long                                     NumThrottlingImminentEventSinceStartup  { get; set; }
        public long                                     NumNoWarningEventSinceStartup           { get; set; }
        public float                                    CurrentTempTrend                        { get; set; }
        public float                                    CurrentTempLevel                        { get; set; }

        public static AdaptivePerformanceThermalAnalyticsEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdaptivePerformanceThermalAnalyticsEvent() { Pointer= p0 };

            value.NumThrottlingEventSinceStartup            = GetInt64(new IntPtr(p + 0x010)); // 02466090D740 0x10 NumThrottlingEventSinceStartup ( 0001865F7E40 ModelPrimitiveType long long long Int64 )
            value.NumThrottlingImminentEventSinceStartup    = GetInt64(new IntPtr(p + 0x018)); // 02466090D760 0x18 NumThrottlingImminentEventSinceStartup ( 0001865F7E40 ModelPrimitiveType long long long Int64 )
            value.NumNoWarningEventSinceStartup             = GetInt64(new IntPtr(p + 0x020)); // 02466090D780 0x20 NumNoWarningEventSinceStartup ( 0001865F7E40 ModelPrimitiveType long long long Int64 )
            value.CurrentTempTrend                          = GetSingle(new IntPtr(p + 0x028)); // 02466090D7A0 0x28 CurrentTempTrend            ( 000186666050 ModelPrimitiveType float float float Single )
            value.CurrentTempLevel                          = GetSingle(new IntPtr(p + 0x02C)); // 02466090D7C0 0x2C CurrentTempLevel            ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
