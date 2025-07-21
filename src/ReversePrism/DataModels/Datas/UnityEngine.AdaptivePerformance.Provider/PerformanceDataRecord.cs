using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ChangeFlags                              ModelEnumType Feature Feature Feature Int32
    // 014 TemperatureLevel                         ModelPrimitiveType float float float Single
    // 018 TemperatureTrend                         ModelPrimitiveType float float float Single
    // 01C WarningLevel                             ModelEnumType WarningLevel WarningLevel WarningLevel Int32
    // 020 CpuPerformanceLevel                      ModelPrimitiveType int int int Int32
    // 024 GpuPerformanceLevel                      ModelPrimitiveType int int int Int32
    // 028 PerformanceLevelControlAvailable         ModelPrimitiveType bool bool bool Bool
    // 02C CpuFrameTime                             ModelPrimitiveType float float float Single
    // 030 GpuFrameTime                             ModelPrimitiveType float float float Single
    // 034 OverallFrameTime                         ModelPrimitiveType float float float Single
    // 038 CpuPerformanceBoost                      ModelPrimitiveType bool bool bool Bool
    // 039 GpuPerformanceBoost                      ModelPrimitiveType bool bool bool Bool
    // 03C ClusterInfo                              ModelEnumType ClusterInfo ClusterInfo ClusterInfo Int32
    // 048 PerformanceMode                          ModelEnumType PerformanceMode PerformanceMode PerformanceMode Int32
    public partial class PerformanceDataRecord : DataModel
    {
        public Feature                                  ChangeFlags                             { get; set; }
        public float                                    TemperatureLevel                        { get; set; }
        public float                                    TemperatureTrend                        { get; set; }
        public WarningLevel                             WarningLevel                            { get; set; }
        public int                                      CpuPerformanceLevel                     { get; set; }
        public int                                      GpuPerformanceLevel                     { get; set; }
        public bool                                     PerformanceLevelControlAvailable        { get; set; }
        public float                                    CpuFrameTime                            { get; set; }
        public float                                    GpuFrameTime                            { get; set; }
        public float                                    OverallFrameTime                        { get; set; }
        public bool                                     CpuPerformanceBoost                     { get; set; }
        public bool                                     GpuPerformanceBoost                     { get; set; }
        public ClusterInfo                              ClusterInfo                             { get; set; }
        public PerformanceMode                          PerformanceMode                         { get; set; }

        public static PerformanceDataRecord? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PerformanceDataRecord() { Pointer= p0 };

            value.ChangeFlags                               = (Feature)GetInt32(new IntPtr(p + 0x010)); // 0x10 ChangeFlags                 ( ModelEnumType Feature Feature Feature Int32 )
            value.TemperatureLevel                          = GetSingle(new IntPtr(p + 0x014)); // 0x14 TemperatureLevel            ( ModelPrimitiveType float float float Single )
            value.TemperatureTrend                          = GetSingle(new IntPtr(p + 0x018)); // 0x18 TemperatureTrend            ( ModelPrimitiveType float float float Single )
            value.WarningLevel                              = (WarningLevel)GetInt32(new IntPtr(p + 0x01C)); // 0x1C WarningLevel                ( ModelEnumType WarningLevel WarningLevel WarningLevel Int32 )
            value.CpuPerformanceLevel                       = GetInt32(new IntPtr(p + 0x020)); // 0x20 CpuPerformanceLevel         ( ModelPrimitiveType int int int Int32 )
            value.GpuPerformanceLevel                       = GetInt32(new IntPtr(p + 0x024)); // 0x24 GpuPerformanceLevel         ( ModelPrimitiveType int int int Int32 )
            value.PerformanceLevelControlAvailable          = GetBool(new IntPtr(p + 0x028)); // 0x28 PerformanceLevelControlAvailable ( ModelPrimitiveType bool bool bool Bool )
            value.CpuFrameTime                              = GetSingle(new IntPtr(p + 0x02C)); // 0x2C CpuFrameTime                ( ModelPrimitiveType float float float Single )
            value.GpuFrameTime                              = GetSingle(new IntPtr(p + 0x030)); // 0x30 GpuFrameTime                ( ModelPrimitiveType float float float Single )
            value.OverallFrameTime                          = GetSingle(new IntPtr(p + 0x034)); // 0x34 OverallFrameTime            ( ModelPrimitiveType float float float Single )
            value.CpuPerformanceBoost                       = GetBool(new IntPtr(p + 0x038)); // 0x38 CpuPerformanceBoost         ( ModelPrimitiveType bool bool bool Bool )
            value.GpuPerformanceBoost                       = GetBool(new IntPtr(p + 0x039)); // 0x39 GpuPerformanceBoost         ( ModelPrimitiveType bool bool bool Bool )
            value.ClusterInfo                               = (ClusterInfo)GetInt32(new IntPtr(p + 0x03C)); // 0x3C ClusterInfo                 ( ModelEnumType ClusterInfo ClusterInfo ClusterInfo Int32 )
            value.PerformanceMode                           = (PerformanceMode)GetInt32(new IntPtr(p + 0x048)); // 0x48 PerformanceMode             ( ModelEnumType PerformanceMode PerformanceMode PerformanceMode Int32 )

            return value;
        }
    }
}
