using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SimulationPower                          ModelEnumType float4 float4 float4 Int32
    // 020 stepParticleIndexArray                   NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 030 teamDataArray                            NativeArray`1<TeamData> IL2CPP_TYPE_GENERICINST
    // 040 parameterArray                           NativeArray`1<ClothParameters> IL2CPP_TYPE_GENERICINST
    // 050 attributes                               NativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 060 depthArray                               NativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 070 teamIdArray                              NativeArray`1<short> IL2CPP_TYPE_GENERICINST
    // 080 nextPosArray                             NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 090 basePosArray                             NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0A0 velocityPosArray                         NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0B0 frictionArray                            NativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 0C0 indexArray                               NativeArray`1<uint> IL2CPP_TYPE_GENERICINST
    // 0D0 dataArray                                NativeArray`1<ushort> IL2CPP_TYPE_GENERICINST
    // 0E0 distanceArray                            NativeArray`1<float> IL2CPP_TYPE_GENERICINST
    public partial class DistanceConstraintJob : DataModel
    {
        public float4                                   SimulationPower                         { get; set; }

        public static DistanceConstraintJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DistanceConstraintJob() { Pointer= p0 };

            value.SimulationPower                           = (float4)GetInt32(new IntPtr(p + 0x010)); // 0x10 SimulationPower             ( ModelEnumType float4 float4 float4 Int32 )

            return value;
        }
    }
}
