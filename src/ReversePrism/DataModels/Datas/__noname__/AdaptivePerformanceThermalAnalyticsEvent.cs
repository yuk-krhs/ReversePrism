using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NumThrottlingEventSinceStartup           ModelPrimitiveType long long long Int64
    // 018 NumThrottlingImminentEventSinceStartup   ModelPrimitiveType long long long Int64
    // 020 NumNoWarningEventSinceStartup            ModelPrimitiveType long long long Int64
    // 028 CurrentTempTrend                         ModelPrimitiveType float float float Single
    // 02C CurrentTempLevel                         ModelPrimitiveType float float float Single
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

            value.NumThrottlingEventSinceStartup            = GetInt64(new IntPtr(p + 0x010)); // 0x10 NumThrottlingEventSinceStartup ( ModelPrimitiveType long long long Int64 )
            value.NumThrottlingImminentEventSinceStartup    = GetInt64(new IntPtr(p + 0x018)); // 0x18 NumThrottlingImminentEventSinceStartup ( ModelPrimitiveType long long long Int64 )
            value.NumNoWarningEventSinceStartup             = GetInt64(new IntPtr(p + 0x020)); // 0x20 NumNoWarningEventSinceStartup ( ModelPrimitiveType long long long Int64 )
            value.CurrentTempTrend                          = GetSingle(new IntPtr(p + 0x028)); // 0x28 CurrentTempTrend            ( ModelPrimitiveType float float float Single )
            value.CurrentTempLevel                          = GetSingle(new IntPtr(p + 0x02C)); // 0x2C CurrentTempLevel            ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
