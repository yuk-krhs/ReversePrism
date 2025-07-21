using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SimulationPower                          ModelEnumType float4 float4 float4 Int32
    // 020 stepTriangleBendIndexArray               NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 030 teamDataArray                            NativeArray`1<TeamData> IL2CPP_TYPE_GENERICINST
    // 040 parameterArray                           NativeArray`1<ClothParameters> IL2CPP_TYPE_GENERICINST
    // 050 attributes                               NativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 060 depthArray                               NativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 070 nextPosArray                             NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 080 frictionArray                            NativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 090 trianglePairArray                        NativeArray`1<ulong> IL2CPP_TYPE_GENERICINST
    // 0A0 restAngleOrVolumeArray                   NativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 0B0 signOrVolumeArray                        NativeArray`1<sbyte> IL2CPP_TYPE_GENERICINST
    // 0C0 writeDataArray                           NativeArray`1<uint> IL2CPP_TYPE_GENERICINST
    // 0D0 writeIndexArray                          NativeArray`1<uint> IL2CPP_TYPE_GENERICINST
    // 0E0 writeBuffer                              NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    public partial class TriangleBendingJob : DataModel
    {
        public float4                                   SimulationPower                         { get; set; }

        public static TriangleBendingJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TriangleBendingJob() { Pointer= p0 };

            value.SimulationPower                           = (float4)GetInt32(new IntPtr(p + 0x010)); // 0x10 SimulationPower             ( ModelEnumType float4 float4 float4 Int32 )

            return value;
        }
    }
}
