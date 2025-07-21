using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_PerfControl                            ModelClassType IDevicePerformanceControl IDevicePerformanceControl IDevicePerformanceControl Pointer
    // 018 M_PerfStats                              ModelClassType IPerformanceStatus IPerformanceStatus IPerformanceStatus Pointer
    // 020 M_ThermalStats                           ModelClassType IThermalStatus IThermalStatus IThermalStatus Pointer
    // 028 M_LastChangeTimeStamp                    ModelPrimitiveType float float float Single
    // 02C M_LastGpuLevelRaiseTimeStamp             ModelPrimitiveType float float float Single
    // 030 M_LastCpuLevelRaiseTimeStamp             ModelPrimitiveType float float float Single
    // 034 M_TargetFrameRateHitTimestamp            ModelPrimitiveType float float float Single
    // 038 M_BottleneckUnknownTimestamp             ModelPrimitiveType float float float Single
    // 03C M_TriedToResolveUnknownBottleneck        ModelPrimitiveType bool bool bool Bool
    // 03D M_Enabled                                ModelPrimitiveType bool bool bool Bool
    // 040 M_FeatureName                            ModelPrimitiveType string string string String
    // 048 TargetFrameTime                          ModelPrimitiveType float float float Single
    // 04C AllowedCpuActiveTimeRatio                ModelPrimitiveType float float float Single
    // 050 AllowedGpuActiveTimeRatio                ModelPrimitiveType float float float Single
    // 054 GpuLevelBounceAvoidanceThreshold         ModelPrimitiveType float float float Single
    // 058 CpuLevelBounceAvoidanceThreshold         ModelPrimitiveType float float float Single
    // 05C UpdateInterval                           ModelPrimitiveType float float float Single
    // 060 MinTargetFrameRateHitTime                ModelPrimitiveType float float float Single
    // 064 MaxTemperatureLevel                      ModelPrimitiveType float float float Single
    public partial class AutoPerformanceLevelController : DataModel
    {
        public IDevicePerformanceControl?               M_PerfControl                           { get; set; }
        public IPerformanceStatus?                      M_PerfStats                             { get; set; }
        public IThermalStatus?                          M_ThermalStats                          { get; set; }
        public float                                    M_LastChangeTimeStamp                   { get; set; }
        public float                                    M_LastGpuLevelRaiseTimeStamp            { get; set; }
        public float                                    M_LastCpuLevelRaiseTimeStamp            { get; set; }
        public float                                    M_TargetFrameRateHitTimestamp           { get; set; }
        public float                                    M_BottleneckUnknownTimestamp            { get; set; }
        public bool                                     M_TriedToResolveUnknownBottleneck       { get; set; }
        public bool                                     M_Enabled                               { get; set; }
        public string                                   M_FeatureName                           { get; set; }
        public float                                    TargetFrameTime                         { get; set; }
        public float                                    AllowedCpuActiveTimeRatio               { get; set; }
        public float                                    AllowedGpuActiveTimeRatio               { get; set; }
        public float                                    GpuLevelBounceAvoidanceThreshold        { get; set; }
        public float                                    CpuLevelBounceAvoidanceThreshold        { get; set; }
        public float                                    UpdateInterval                          { get; set; }
        public float                                    MinTargetFrameRateHitTime               { get; set; }
        public float                                    MaxTemperatureLevel                     { get; set; }

        public static AutoPerformanceLevelController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AutoPerformanceLevelController() { Pointer= p0 };

            value.M_PerfControl                             = GetObject<IDevicePerformanceControl>(new IntPtr(p + 0x010), ReversePrism.DataModels.IDevicePerformanceControl.FromPointer); // 0x10 M_PerfControl               ( ModelClassType IDevicePerformanceControl IDevicePerformanceControl IDevicePerformanceControl Pointer )
            value.M_PerfStats                               = GetObject<IPerformanceStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IPerformanceStatus.FromPointer); // 0x18 M_PerfStats                 ( ModelClassType IPerformanceStatus IPerformanceStatus IPerformanceStatus Pointer )
            value.M_ThermalStats                            = GetObject<IThermalStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IThermalStatus.FromPointer); // 0x20 M_ThermalStats              ( ModelClassType IThermalStatus IThermalStatus IThermalStatus Pointer )
            value.M_LastChangeTimeStamp                     = GetSingle(new IntPtr(p + 0x028)); // 0x28 M_LastChangeTimeStamp       ( ModelPrimitiveType float float float Single )
            value.M_LastGpuLevelRaiseTimeStamp              = GetSingle(new IntPtr(p + 0x02C)); // 0x2C M_LastGpuLevelRaiseTimeStamp ( ModelPrimitiveType float float float Single )
            value.M_LastCpuLevelRaiseTimeStamp              = GetSingle(new IntPtr(p + 0x030)); // 0x30 M_LastCpuLevelRaiseTimeStamp ( ModelPrimitiveType float float float Single )
            value.M_TargetFrameRateHitTimestamp             = GetSingle(new IntPtr(p + 0x034)); // 0x34 M_TargetFrameRateHitTimestamp ( ModelPrimitiveType float float float Single )
            value.M_BottleneckUnknownTimestamp              = GetSingle(new IntPtr(p + 0x038)); // 0x38 M_BottleneckUnknownTimestamp ( ModelPrimitiveType float float float Single )
            value.M_TriedToResolveUnknownBottleneck         = GetBool(new IntPtr(p + 0x03C)); // 0x3C M_TriedToResolveUnknownBottleneck ( ModelPrimitiveType bool bool bool Bool )
            value.M_Enabled                                 = GetBool(new IntPtr(p + 0x03D)); // 0x3D M_Enabled                   ( ModelPrimitiveType bool bool bool Bool )
            value.M_FeatureName                             = GetString(new IntPtr(p + 0x040)); // 0x40 M_FeatureName               ( ModelPrimitiveType string string string String )
            value.TargetFrameTime                           = GetSingle(new IntPtr(p + 0x048)); // 0x48 TargetFrameTime             ( ModelPrimitiveType float float float Single )
            value.AllowedCpuActiveTimeRatio                 = GetSingle(new IntPtr(p + 0x04C)); // 0x4C AllowedCpuActiveTimeRatio   ( ModelPrimitiveType float float float Single )
            value.AllowedGpuActiveTimeRatio                 = GetSingle(new IntPtr(p + 0x050)); // 0x50 AllowedGpuActiveTimeRatio   ( ModelPrimitiveType float float float Single )
            value.GpuLevelBounceAvoidanceThreshold          = GetSingle(new IntPtr(p + 0x054)); // 0x54 GpuLevelBounceAvoidanceThreshold ( ModelPrimitiveType float float float Single )
            value.CpuLevelBounceAvoidanceThreshold          = GetSingle(new IntPtr(p + 0x058)); // 0x58 CpuLevelBounceAvoidanceThreshold ( ModelPrimitiveType float float float Single )
            value.UpdateInterval                            = GetSingle(new IntPtr(p + 0x05C)); // 0x5C UpdateInterval              ( ModelPrimitiveType float float float Single )
            value.MinTargetFrameRateHitTime                 = GetSingle(new IntPtr(p + 0x060)); // 0x60 MinTargetFrameRateHitTime   ( ModelPrimitiveType float float float Single )
            value.MaxTemperatureLevel                       = GetSingle(new IntPtr(p + 0x064)); // 0x64 MaxTemperatureLevel         ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
