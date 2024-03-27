using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum Feature
    {
        None,
        WarningLevel,
        TemperatureLevel,
        TemperatureTrend,
        CpuPerformanceLevel,
        GpuPerformanceLevel,
        PerformanceLevelControl,
        GpuFrameTime,
        CpuFrameTime,
        OverallFrameTime,
        CpuPerformanceBoost,
        GpuPerformanceBoost,
        ClusterInfo,
        PerformanceMode,
    }
}
