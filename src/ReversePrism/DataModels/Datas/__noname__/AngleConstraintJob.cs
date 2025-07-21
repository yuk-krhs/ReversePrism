using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SimulationPower                          ModelEnumType float4 float4 float4 Int32
    // 020 stepBaseLineIndexArray                   NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 030 teamDataArray                            NativeArray`1<TeamData> IL2CPP_TYPE_GENERICINST
    // 040 parameterArray                           NativeArray`1<ClothParameters> IL2CPP_TYPE_GENERICINST
    // 050 attributes                               NativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 060 vertexDepths                             NativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 070 vertexParentIndices                      NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 080 baseLineStartDataIndices                 NativeArray`1<ushort> IL2CPP_TYPE_GENERICINST
    // 090 baseLineDataCounts                       NativeArray`1<ushort> IL2CPP_TYPE_GENERICINST
    // 0A0 baseLineData                             NativeArray`1<ushort> IL2CPP_TYPE_GENERICINST
    // 0B0 nextPosArray                             NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0C0 velocityPosArray                         NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0D0 frictionArray                            NativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 0E0 stepBasicPositionBuffer                  NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0F0 stepBasicRotationBuffer                  NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 100 lengthBufferArray                        NativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 110 localPosBufferArray                      NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 120 localRotBufferArray                      NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 130 rotationBufferArray                      NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 140 restorationVectorBufferArray             NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    public partial class AngleConstraintJob : DataModel
    {
        public float4                                   SimulationPower                         { get; set; }

        public static AngleConstraintJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AngleConstraintJob() { Pointer= p0 };

            value.SimulationPower                           = (float4)GetInt32(new IntPtr(p + 0x010)); // 0x10 SimulationPower             ( ModelEnumType float4 float4 float4 Int32 )

            return value;
        }
    }
}
