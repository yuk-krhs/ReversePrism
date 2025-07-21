using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 AdaptivePerformanceProfilerCategory      ProfilerCategory IL2CPP_TYPE_VALUETYPE
    // 002 CurrentCPUCounter                        ProfilerCounter`1<float> IL2CPP_TYPE_GENERICINST
    // 003 AvgCPUCounter                            ProfilerCounter`1<float> IL2CPP_TYPE_GENERICINST
    // 004 CurrentGPUCounter                        ProfilerCounter`1<float> IL2CPP_TYPE_GENERICINST
    // 005 AvgGPUCounter                            ProfilerCounter`1<float> IL2CPP_TYPE_GENERICINST
    // 006 CurrentCPULevelCounter                   ProfilerCounter`1<int> IL2CPP_TYPE_GENERICINST
    // 007 CurrentGPULevelCounter                   ProfilerCounter`1<int> IL2CPP_TYPE_GENERICINST
    // 008 CurrentFrametimeCounter                  ProfilerCounter`1<float> IL2CPP_TYPE_GENERICINST
    // 009 AvgFrametimeCounter                      ProfilerCounter`1<float> IL2CPP_TYPE_GENERICINST
    // 00A WarningLevelCounter                      ProfilerCounter`1<int> IL2CPP_TYPE_GENERICINST
    // 00B TemperatureLevelCounter                  ProfilerCounter`1<float> IL2CPP_TYPE_GENERICINST
    // 00C TemperatureTrendCounter                  ProfilerCounter`1<float> IL2CPP_TYPE_GENERICINST
    // 00D BottleneckCounter                        ProfilerCounter`1<int> IL2CPP_TYPE_GENERICINST
    // 00E PerformanceModeCounter                   ProfilerCounter`1<int> IL2CPP_TYPE_GENERICINST
    // 010 KAdaptivePerformanceProfilerModuleGuid   ModelEnumType Guid Guid Guid Int32
    // 020 KScalerDataTag                           ModelPrimitiveType int int int Int32
    // 028 scalerInfos                              Dictionary`2<string, ScalerInfo> IL2CPP_TYPE_GENERICINST
    public partial class AdaptivePerformanceProfilerStats : DataModel
    {
        public Guid                                     KAdaptivePerformanceProfilerModuleGuid  { get; set; }
        public int                                      KScalerDataTag                          { get; set; }

        public static AdaptivePerformanceProfilerStats? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdaptivePerformanceProfilerStats() { Pointer= p0 };

            value.KAdaptivePerformanceProfilerModuleGuid    = (Guid)GetInt32(new IntPtr(p + 0x010)); // 0x10 KAdaptivePerformanceProfilerModuleGuid ( ModelEnumType Guid Guid Guid Int32 )
            value.KScalerDataTag                            = GetInt32(new IntPtr(p + 0x020)); // 0x20 KScalerDataTag              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
