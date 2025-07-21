using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SimulationFrequency                      ModelPrimitiveType int int int Int32
    // 014 MaxSimulationCountPerFrame               ModelPrimitiveType int int int Int32
    // 018 UpdateLocation                           ModelEnumType UpdateLocation UpdateLocation UpdateLocation Int32
    // 01C IsValid                                  ModelPrimitiveType bool bool bool Bool
    // 020 FixedUpdateCount                         ModelPrimitiveType int int int Int32
    // 024 GlobalTimeScale                          ModelPrimitiveType float float float Single
    // 028 SimulationDeltaTime                      ModelPrimitiveType float float float Single
    // 02C MaxDeltaTime                             ModelPrimitiveType float float float Single
    // 030 SimulationPower                          ModelEnumType float4 float4 float4 Int32
    public partial class TimeManager : DataModel
    {
        public int                                      SimulationFrequency                     { get; set; }
        public int                                      MaxSimulationCountPerFrame              { get; set; }
        public UpdateLocation                           UpdateLocation                          { get; set; }
        public bool                                     IsValid                                 { get; set; }
        public int                                      FixedUpdateCount                        { get; set; }
        public float                                    GlobalTimeScale                         { get; set; }
        public float                                    SimulationDeltaTime                     { get; set; }
        public float                                    MaxDeltaTime                            { get; set; }
        public float4                                   SimulationPower                         { get; set; }

        public static TimeManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimeManager() { Pointer= p0 };

            value.SimulationFrequency                       = GetInt32(new IntPtr(p + 0x010)); // 0x10 SimulationFrequency         ( ModelPrimitiveType int int int Int32 )
            value.MaxSimulationCountPerFrame                = GetInt32(new IntPtr(p + 0x014)); // 0x14 MaxSimulationCountPerFrame  ( ModelPrimitiveType int int int Int32 )
            value.UpdateLocation                            = (UpdateLocation)GetInt32(new IntPtr(p + 0x018)); // 0x18 UpdateLocation              ( ModelEnumType UpdateLocation UpdateLocation UpdateLocation Int32 )
            value.IsValid                                   = GetBool(new IntPtr(p + 0x01C)); // 0x1C IsValid                     ( ModelPrimitiveType bool bool bool Bool )
            value.FixedUpdateCount                          = GetInt32(new IntPtr(p + 0x020)); // 0x20 FixedUpdateCount            ( ModelPrimitiveType int int int Int32 )
            value.GlobalTimeScale                           = GetSingle(new IntPtr(p + 0x024)); // 0x24 GlobalTimeScale             ( ModelPrimitiveType float float float Single )
            value.SimulationDeltaTime                       = GetSingle(new IntPtr(p + 0x028)); // 0x28 SimulationDeltaTime         ( ModelPrimitiveType float float float Single )
            value.MaxDeltaTime                              = GetSingle(new IntPtr(p + 0x02C)); // 0x2C MaxDeltaTime                ( ModelPrimitiveType float float float Single )
            value.SimulationPower                           = (float4)GetInt32(new IntPtr(p + 0x030)); // 0x30 SimulationPower             ( ModelEnumType float4 float4 float4 Int32 )

            return value;
        }
    }
}
