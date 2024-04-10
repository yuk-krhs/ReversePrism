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
    // 018 Timer                                    00018658EAD0 ModelClassType Stopwatch Stopwatch Stopwatch Pointer
    // 020 Head                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 Tail                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 ElapsedMs                                0001865F7700 ModelPrimitiveType long long long Int64
    // 030 ElapsedBytes                             0001865F7700 ModelPrimitiveType long long long Int64
    // 038 State                                    000186601060 ModelEnumType StabilityProfile StabilityProfile StabilityProfile Int32
    // 040 Throughput                               0001865C2950 ModelPrimitiveType double double double Double
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

            value.Timer                                     = GetObject<Stopwatch>(new IntPtr(p + 0x018), ReversePrism.DataModels.Stopwatch.FromPointer); // 02466B59C5E0 0x18 Timer                       ( 00018658EAD0 ModelClassType Stopwatch Stopwatch Stopwatch Pointer )
            value.Head                                      = GetInt32(new IntPtr(p + 0x020)); // 02466B59C600 0x20 Head                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Tail                                      = GetInt32(new IntPtr(p + 0x024)); // 02466B59C620 0x24 Tail                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ElapsedMs                                 = GetInt64(new IntPtr(p + 0x028)); // 02466B59C640 0x28 ElapsedMs                   ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.ElapsedBytes                              = GetInt64(new IntPtr(p + 0x030)); // 02466B59C660 0x30 ElapsedBytes                ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.State                                     = (StabilityProfile)GetInt32(new IntPtr(p + 0x038)); // 02466B59C680 0x38 State                       ( 000186601060 ModelEnumType StabilityProfile StabilityProfile StabilityProfile Int32 )
            value.Throughput                                = GetDouble(new IntPtr(p + 0x040)); // 02466B59C6A0 0x40 Throughput                  ( 0001865C2950 ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
