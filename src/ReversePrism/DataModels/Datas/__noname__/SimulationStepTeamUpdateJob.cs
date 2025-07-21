using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UpdateIndex                              ModelPrimitiveType int int int Int32
    // 014 SimulationDeltaTime                      ModelPrimitiveType float float float Single
    // 018 teamDataArray                            NativeArray`1<TeamData> IL2CPP_TYPE_GENERICINST
    // 028 parameterArray                           NativeArray`1<ClothParameters> IL2CPP_TYPE_GENERICINST
    // 038 centerDataArray                          NativeArray`1<CenterData> IL2CPP_TYPE_GENERICINST
    // 048 teamWindArray                            NativeArray`1<TeamWindData> IL2CPP_TYPE_GENERICINST
    public partial class SimulationStepTeamUpdateJob : DataModel
    {
        public int                                      UpdateIndex                             { get; set; }
        public float                                    SimulationDeltaTime                     { get; set; }

        public static SimulationStepTeamUpdateJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SimulationStepTeamUpdateJob() { Pointer= p0 };

            value.UpdateIndex                               = GetInt32(new IntPtr(p + 0x010)); // 0x10 UpdateIndex                 ( ModelPrimitiveType int int int Int32 )
            value.SimulationDeltaTime                       = GetSingle(new IntPtr(p + 0x014)); // 0x14 SimulationDeltaTime         ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
