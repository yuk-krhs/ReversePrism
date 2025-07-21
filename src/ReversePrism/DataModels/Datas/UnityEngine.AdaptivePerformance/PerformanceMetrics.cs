using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CurrentCpuLevel                          ModelPrimitiveType int int int Int32
    // 014 CurrentGpuLevel                          ModelPrimitiveType int int int Int32
    // 018 PerformanceBottleneck                    ModelEnumType PerformanceBottleneck PerformanceBottleneck PerformanceBottleneck Int32
    // 01C CpuPerformanceBoost                      ModelPrimitiveType bool bool bool Bool
    // 01D GpuPerformanceBoost                      ModelPrimitiveType bool bool bool Bool
    // 020 ClusterInfo                              ModelEnumType ClusterInfo ClusterInfo ClusterInfo Int32
    public partial class PerformanceMetrics : DataModel
    {
        public int                                      CurrentCpuLevel                         { get; set; }
        public int                                      CurrentGpuLevel                         { get; set; }
        public PerformanceBottleneck                    PerformanceBottleneck                   { get; set; }
        public bool                                     CpuPerformanceBoost                     { get; set; }
        public bool                                     GpuPerformanceBoost                     { get; set; }
        public ClusterInfo                              ClusterInfo                             { get; set; }

        public static PerformanceMetrics? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PerformanceMetrics() { Pointer= p0 };

            value.CurrentCpuLevel                           = GetInt32(new IntPtr(p + 0x010)); // 0x10 CurrentCpuLevel             ( ModelPrimitiveType int int int Int32 )
            value.CurrentGpuLevel                           = GetInt32(new IntPtr(p + 0x014)); // 0x14 CurrentGpuLevel             ( ModelPrimitiveType int int int Int32 )
            value.PerformanceBottleneck                     = (PerformanceBottleneck)GetInt32(new IntPtr(p + 0x018)); // 0x18 PerformanceBottleneck       ( ModelEnumType PerformanceBottleneck PerformanceBottleneck PerformanceBottleneck Int32 )
            value.CpuPerformanceBoost                       = GetBool(new IntPtr(p + 0x01C)); // 0x1C CpuPerformanceBoost         ( ModelPrimitiveType bool bool bool Bool )
            value.GpuPerformanceBoost                       = GetBool(new IntPtr(p + 0x01D)); // 0x1D GpuPerformanceBoost         ( ModelPrimitiveType bool bool bool Bool )
            value.ClusterInfo                               = (ClusterInfo)GetInt32(new IntPtr(p + 0x020)); // 0x20 ClusterInfo                 ( ModelEnumType ClusterInfo ClusterInfo ClusterInfo Int32 )

            return value;
        }
    }
}
