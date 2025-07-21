using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SimulationDeltaTime                      ModelPrimitiveType float float float Single
    // 018 stepParticleIndexArray                   NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 028 teamDataArray                            NativeArray`1<TeamData> IL2CPP_TYPE_GENERICINST
    // 038 parameterArray                           NativeArray`1<ClothParameters> IL2CPP_TYPE_GENERICINST
    // 048 centerDataArray                          NativeArray`1<CenterData> IL2CPP_TYPE_GENERICINST
    // 058 attributes                               NativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 068 vertexDepths                             NativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 078 teamIdArray                              NativeArray`1<short> IL2CPP_TYPE_GENERICINST
    // 088 nextPosArray                             NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 098 oldPosArray                              NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0A8 velocityArray                            NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0B8 realVelocityArray                        NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0C8 velocityPosArray                         NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0D8 frictionArray                            NativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 0E8 staticFrictionArray                      NativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 0F8 collisionNormalArray                     NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    public partial class EndSimulationStepJob : DataModel
    {
        public float                                    SimulationDeltaTime                     { get; set; }

        public static EndSimulationStepJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EndSimulationStepJob() { Pointer= p0 };

            value.SimulationDeltaTime                       = GetSingle(new IntPtr(p + 0x010)); // 0x10 SimulationDeltaTime         ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
