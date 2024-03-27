using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CurrentCpuLevel                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 CurrentGpuLevel                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 PerformanceBottleneck                    000186730BA0 ModelEnumType PerformanceBottleneck PerformanceBottleneck PerformanceBottleneck Int32
    // 01C CpuPerformanceBoost                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 01D GpuPerformanceBoost                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 020 ClusterInfo                              0001865BB6C0 ModelEnumType ClusterInfo ClusterInfo ClusterInfo Int32
    public partial class PerformanceMetrics
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
            var value   = new PerformanceMetrics();

            value.CurrentCpuLevel                           = GetInt32(new IntPtr(p + 0x010)); // 0270D090A368 0x10 CurrentCpuLevel             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentGpuLevel                           = GetInt32(new IntPtr(p + 0x014)); // 0270D090A388 0x14 CurrentGpuLevel             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PerformanceBottleneck                     = (PerformanceBottleneck)GetInt32(new IntPtr(p + 0x018)); // 0270D090A3A8 0x18 PerformanceBottleneck       ( 000186730BA0 ModelEnumType PerformanceBottleneck PerformanceBottleneck PerformanceBottleneck Int32 )
            value.CpuPerformanceBoost                       = GetBool(new IntPtr(p + 0x01C)); // 0270D090A3C8 0x1C CpuPerformanceBoost         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.GpuPerformanceBoost                       = GetBool(new IntPtr(p + 0x01D)); // 0270D090A3E8 0x1D GpuPerformanceBoost         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ClusterInfo                               = (ClusterInfo)GetInt32(new IntPtr(p + 0x020)); // 0270D090A408 0x20 ClusterInfo                 ( 0001865BB6C0 ModelEnumType ClusterInfo ClusterInfo ClusterInfo Int32 )

            return value;
        }
    }
}
