using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SimulationDeltaTime                      ModelPrimitiveType float float float Single
    // 018 teamDataArray                            NativeArray`1<TeamData> IL2CPP_TYPE_GENERICINST
    // 028 teamIdArray                              NativeArray`1<short> IL2CPP_TYPE_GENERICINST
    // 038 oldPosArray                              NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 048 realVelocityArray                        NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 058 oldPositionArray                         NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 068 oldRotationArray                         NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 078 dispPosArray                             NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 088 attributes                               NativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 098 positions                                NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0A8 rotations                                NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    public partial class CalcDisplayPositionJob : DataModel
    {
        public float                                    SimulationDeltaTime                     { get; set; }

        public static CalcDisplayPositionJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CalcDisplayPositionJob() { Pointer= p0 };

            value.SimulationDeltaTime                       = GetSingle(new IntPtr(p + 0x010)); // 0x10 SimulationDeltaTime         ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
