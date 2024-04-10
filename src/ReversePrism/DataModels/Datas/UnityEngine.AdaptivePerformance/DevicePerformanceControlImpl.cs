using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_PerformanceLevelControl                00018674EEF0 ModelClassType IDevicePerformanceLevelControl IDevicePerformanceLevelControl IDevicePerformanceLevelControl Pointer
    // 018 PerformanceControlMode                   000186731ED0 ModelEnumType PerformanceControlMode PerformanceControlMode PerformanceControlMode Int32
    // 01C CpuLevel                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 GpuLevel                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 CurrentCpuLevel                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 CurrentGpuLevel                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C CpuPerformanceBoost                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02D GpuPerformanceBoost                      000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class DevicePerformanceControlImpl : DataModel
    {
        public IDevicePerformanceLevelControl?          M_PerformanceLevelControl               { get; set; }
        public PerformanceControlMode                   PerformanceControlMode                  { get; set; }
        public int                                      CpuLevel                                { get; set; }
        public int                                      GpuLevel                                { get; set; }
        public int                                      CurrentCpuLevel                         { get; set; }
        public int                                      CurrentGpuLevel                         { get; set; }
        public bool                                     CpuPerformanceBoost                     { get; set; }
        public bool                                     GpuPerformanceBoost                     { get; set; }

        public static DevicePerformanceControlImpl? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DevicePerformanceControlImpl() { Pointer= p0 };

            value.M_PerformanceLevelControl                 = GetObject<IDevicePerformanceLevelControl>(new IntPtr(p + 0x010), ReversePrism.DataModels.IDevicePerformanceLevelControl.FromPointer); // 02466B6EE9B0 0x10 M_PerformanceLevelControl   ( 00018674EEF0 ModelClassType IDevicePerformanceLevelControl IDevicePerformanceLevelControl IDevicePerformanceLevelControl Pointer )
            value.PerformanceControlMode                    = (PerformanceControlMode)GetInt32(new IntPtr(p + 0x018)); // 02466B6EE9D0 0x18 PerformanceControlMode      ( 000186731ED0 ModelEnumType PerformanceControlMode PerformanceControlMode PerformanceControlMode Int32 )
            value.CpuLevel                                  = GetInt32(new IntPtr(p + 0x01C)); // 02466B6EE9F0 0x1C CpuLevel                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.GpuLevel                                  = GetInt32(new IntPtr(p + 0x020)); // 02466B6EEA10 0x20 GpuLevel                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentCpuLevel                           = GetInt32(new IntPtr(p + 0x024)); // 02466B6EEA30 0x24 CurrentCpuLevel             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentGpuLevel                           = GetInt32(new IntPtr(p + 0x028)); // 02466B6EEA50 0x28 CurrentGpuLevel             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CpuPerformanceBoost                       = GetBool(new IntPtr(p + 0x02C)); // 02466B6EEA70 0x2C CpuPerformanceBoost         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.GpuPerformanceBoost                       = GetBool(new IntPtr(p + 0x02D)); // 02466B6EEA90 0x2D GpuPerformanceBoost         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
