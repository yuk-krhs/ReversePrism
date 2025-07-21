using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RefreshMode                              ModelEnumType RefreshMode RefreshMode RefreshMode Int32
    // 024 SimulationFrequency                      ModelPrimitiveType int int int Int32
    // 028 MaxSimulationCountPerFrame               ModelPrimitiveType int int int Int32
    // 02C InitializationLocation                   ModelEnumType InitializationLocation InitializationLocation InitializationLocation Int32
    // 030 UpdateLocation                           ModelEnumType UpdateLocation UpdateLocation UpdateLocation Int32
    public partial class MagicaSettings : DataModel
    {
        public RefreshMode                              RefreshMode                             { get; set; }
        public int                                      SimulationFrequency                     { get; set; }
        public int                                      MaxSimulationCountPerFrame              { get; set; }
        public InitializationLocation                   InitializationLocation                  { get; set; }
        public UpdateLocation                           UpdateLocation                          { get; set; }

        public static MagicaSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MagicaSettings() { Pointer= p0 };

            value.RefreshMode                               = (RefreshMode)GetInt32(new IntPtr(p + 0x020)); // 0x20 RefreshMode                 ( ModelEnumType RefreshMode RefreshMode RefreshMode Int32 )
            value.SimulationFrequency                       = GetInt32(new IntPtr(p + 0x024)); // 0x24 SimulationFrequency         ( ModelPrimitiveType int int int Int32 )
            value.MaxSimulationCountPerFrame                = GetInt32(new IntPtr(p + 0x028)); // 0x28 MaxSimulationCountPerFrame  ( ModelPrimitiveType int int int Int32 )
            value.InitializationLocation                    = (InitializationLocation)GetInt32(new IntPtr(p + 0x02C)); // 0x2C InitializationLocation      ( ModelEnumType InitializationLocation InitializationLocation InitializationLocation Int32 )
            value.UpdateLocation                            = (UpdateLocation)GetInt32(new IntPtr(p + 0x030)); // 0x30 UpdateLocation              ( ModelEnumType UpdateLocation UpdateLocation UpdateLocation Int32 )

            return value;
        }
    }
}
