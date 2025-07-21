using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SimulationPower                          ModelEnumType float4 float4 float4 Int32
    // 020 SimulationDeltaTime                      ModelPrimitiveType float float float Single
    // 028 stepParticleIndexArray                   NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 038 attributes                               NativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 048 depthArray                               NativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 058 positions                                NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 068 rotations                                NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 078 vertexRootIndices                        NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 088 teamDataArray                            NativeArray`1<TeamData> IL2CPP_TYPE_GENERICINST
    // 098 parameterArray                           NativeArray`1<ClothParameters> IL2CPP_TYPE_GENERICINST
    // 0A8 centerDataArray                          NativeArray`1<CenterData> IL2CPP_TYPE_GENERICINST
    // 0B8 teamWindArray                            NativeArray`1<TeamWindData> IL2CPP_TYPE_GENERICINST
    // 0C8 windDataArray                            NativeArray`1<WindData> IL2CPP_TYPE_GENERICINST
    // 0D8 teamIdArray                              NativeArray`1<short> IL2CPP_TYPE_GENERICINST
    // 0E8 oldPosArray                              NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0F8 velocityArray                            NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 108 nextPosArray                             NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 118 basePosArray                             NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 128 baseRotArray                             NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 138 oldPositionArray                         NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 148 oldRotationArray                         NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 158 velocityPosArray                         NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 168 frictionArray                            NativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 178 stepBasicPositionArray                   NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 188 stepBasicRotationArray                   NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    public partial class StartSimulationStepJob : DataModel
    {
        public float4                                   SimulationPower                         { get; set; }
        public float                                    SimulationDeltaTime                     { get; set; }

        public static StartSimulationStepJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StartSimulationStepJob() { Pointer= p0 };

            value.SimulationPower                           = (float4)GetInt32(new IntPtr(p + 0x010)); // 0x10 SimulationPower             ( ModelEnumType float4 float4 float4 Int32 )
            value.SimulationDeltaTime                       = GetSingle(new IntPtr(p + 0x020)); // 0x20 SimulationDeltaTime         ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
