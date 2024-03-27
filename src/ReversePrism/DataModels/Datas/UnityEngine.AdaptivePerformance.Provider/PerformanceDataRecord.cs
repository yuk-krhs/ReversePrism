using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ChangeFlags                              00018655DF10 ModelEnumType Feature Feature Feature Int32
    // 014 TemperatureLevel                         0001866656B0 ModelPrimitiveType float float float Single
    // 018 TemperatureTrend                         0001866656B0 ModelPrimitiveType float float float Single
    // 01C WarningLevel                             000186545580 ModelEnumType WarningLevel WarningLevel WarningLevel Int32
    // 020 CpuPerformanceLevel                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 GpuPerformanceLevel                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 PerformanceLevelControlAvailable         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02C CpuFrameTime                             0001866656B0 ModelPrimitiveType float float float Single
    // 030 GpuFrameTime                             0001866656B0 ModelPrimitiveType float float float Single
    // 034 OverallFrameTime                         0001866656B0 ModelPrimitiveType float float float Single
    // 038 CpuPerformanceBoost                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 039 GpuPerformanceBoost                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03C ClusterInfo                              0001865BB6C0 ModelEnumType ClusterInfo ClusterInfo ClusterInfo Int32
    // 048 PerformanceMode                          000186733960 ModelEnumType PerformanceMode PerformanceMode PerformanceMode Int32
    public partial class PerformanceDataRecord
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
            var value   = new PerformanceDataRecord();

            value.ChangeFlags                               = (Feature)GetInt32(new IntPtr(p + 0x010)); // 0270DB689C18 0x10 ChangeFlags                 ( 00018655DF10 ModelEnumType Feature Feature Feature Int32 )
            value.TemperatureLevel                          = GetSingle(new IntPtr(p + 0x014)); // 0270DB689C38 0x14 TemperatureLevel            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.TemperatureTrend                          = GetSingle(new IntPtr(p + 0x018)); // 0270DB689C58 0x18 TemperatureTrend            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.WarningLevel                              = (WarningLevel)GetInt32(new IntPtr(p + 0x01C)); // 0270DB689C78 0x1C WarningLevel                ( 000186545580 ModelEnumType WarningLevel WarningLevel WarningLevel Int32 )
            value.CpuPerformanceLevel                       = GetInt32(new IntPtr(p + 0x020)); // 0270DB689C98 0x20 CpuPerformanceLevel         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.GpuPerformanceLevel                       = GetInt32(new IntPtr(p + 0x024)); // 0270DB689CB8 0x24 GpuPerformanceLevel         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PerformanceLevelControlAvailable          = GetBool(new IntPtr(p + 0x028)); // 0270DB689CD8 0x28 PerformanceLevelControlAvailable ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CpuFrameTime                              = GetSingle(new IntPtr(p + 0x02C)); // 0270DB689CF8 0x2C CpuFrameTime                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.GpuFrameTime                              = GetSingle(new IntPtr(p + 0x030)); // 0270DB689D18 0x30 GpuFrameTime                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.OverallFrameTime                          = GetSingle(new IntPtr(p + 0x034)); // 0270DB689D38 0x34 OverallFrameTime            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CpuPerformanceBoost                       = GetBool(new IntPtr(p + 0x038)); // 0270DB689D58 0x38 CpuPerformanceBoost         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.GpuPerformanceBoost                       = GetBool(new IntPtr(p + 0x039)); // 0270DB689D78 0x39 GpuPerformanceBoost         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ClusterInfo                               = (ClusterInfo)GetInt32(new IntPtr(p + 0x03C)); // 0270DB689D98 0x3C ClusterInfo                 ( 0001865BB6C0 ModelEnumType ClusterInfo ClusterInfo ClusterInfo Int32 )
            value.PerformanceMode                           = (PerformanceMode)GetInt32(new IntPtr(p + 0x048)); // 0270DB689DB8 0x48 PerformanceMode             ( 000186733960 ModelEnumType PerformanceMode PerformanceMode PerformanceMode Int32 )

            return value;
        }
    }
}
