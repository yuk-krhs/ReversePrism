using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 StableReportThresholdMs                  int IL2CPP_TYPE_I4
    // 000 EarlyReportThresholdMs                   int IL2CPP_TYPE_I4
    // 000 WorkBufSize                              int IL2CPP_TYPE_I4
    // 010 buf                                      ValueTuple`2<long, long>[] IL2CPP_TYPE_SZARRAY
    // 018 Timer                                    ModelClassType Stopwatch Stopwatch Stopwatch Pointer
    // 020 Head                                     ModelPrimitiveType int int int Int32
    // 024 Tail                                     ModelPrimitiveType int int int Int32
    // 028 ElapsedMs                                ModelPrimitiveType long long long Int64
    // 030 ElapsedBytes                             ModelPrimitiveType long long long Int64
    // 038 State                                    ModelEnumType StabilityProfile StabilityProfile StabilityProfile Int32
    // 040 Throughput                               ModelPrimitiveType double double double Double
    public partial class ThroughputMonitor : DataModel
    {
        public Stopwatch?                               Timer                                   { get; set; }
        public int                                      Head                                    { get; set; }
        public int                                      Tail                                    { get; set; }
        public long                                     ElapsedMs                               { get; set; }
        public long                                     ElapsedBytes                            { get; set; }
        public StabilityProfile                         State                                   { get; set; }
        public double                                   Throughput                              { get; set; }

        public static ThroughputMonitor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ThroughputMonitor() { Pointer= p0 };

            value.Timer                                     = GetObject<Stopwatch>(new IntPtr(p + 0x018), ReversePrism.DataModels.Stopwatch.FromPointer); // 0x18 Timer                       ( ModelClassType Stopwatch Stopwatch Stopwatch Pointer )
            value.Head                                      = GetInt32(new IntPtr(p + 0x020)); // 0x20 Head                        ( ModelPrimitiveType int int int Int32 )
            value.Tail                                      = GetInt32(new IntPtr(p + 0x024)); // 0x24 Tail                        ( ModelPrimitiveType int int int Int32 )
            value.ElapsedMs                                 = GetInt64(new IntPtr(p + 0x028)); // 0x28 ElapsedMs                   ( ModelPrimitiveType long long long Int64 )
            value.ElapsedBytes                              = GetInt64(new IntPtr(p + 0x030)); // 0x30 ElapsedBytes                ( ModelPrimitiveType long long long Int64 )
            value.State                                     = (StabilityProfile)GetInt32(new IntPtr(p + 0x038)); // 0x38 State                       ( ModelEnumType StabilityProfile StabilityProfile StabilityProfile Int32 )
            value.Throughput                                = GetDouble(new IntPtr(p + 0x040)); // 0x40 Throughput                  ( ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
