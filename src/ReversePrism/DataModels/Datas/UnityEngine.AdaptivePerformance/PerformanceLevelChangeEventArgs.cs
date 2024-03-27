using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CpuLevel                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 CpuLevelDelta                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 GpuLevel                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C GpuLevelDelta                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 PerformanceControlMode                   000186731ED0 ModelEnumType PerformanceControlMode PerformanceControlMode PerformanceControlMode Int32
    // 024 ManualOverride                           000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class PerformanceLevelChangeEventArgs
    {
        public int                                      CpuLevel                                { get; set; }
        public int                                      CpuLevelDelta                           { get; set; }
        public int                                      GpuLevel                                { get; set; }
        public int                                      GpuLevelDelta                           { get; set; }
        public PerformanceControlMode                   PerformanceControlMode                  { get; set; }
        public bool                                     ManualOverride                          { get; set; }

        public static PerformanceLevelChangeEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PerformanceLevelChangeEventArgs();

            value.CpuLevel                                  = GetInt32(new IntPtr(p + 0x010)); // 0270DB65DAB0 0x10 CpuLevel                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CpuLevelDelta                             = GetInt32(new IntPtr(p + 0x014)); // 0270DB65DAD0 0x14 CpuLevelDelta               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.GpuLevel                                  = GetInt32(new IntPtr(p + 0x018)); // 0270DB65DAF0 0x18 GpuLevel                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.GpuLevelDelta                             = GetInt32(new IntPtr(p + 0x01C)); // 0270DB65DB10 0x1C GpuLevelDelta               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PerformanceControlMode                    = (PerformanceControlMode)GetInt32(new IntPtr(p + 0x020)); // 0270DB65DB30 0x20 PerformanceControlMode      ( 000186731ED0 ModelEnumType PerformanceControlMode PerformanceControlMode PerformanceControlMode Int32 )
            value.ManualOverride                            = GetBool(new IntPtr(p + 0x024)); // 0270DB65DB50 0x24 ManualOverride              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
