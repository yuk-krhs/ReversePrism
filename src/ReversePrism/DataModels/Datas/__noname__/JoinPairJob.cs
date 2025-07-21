using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 JoinPositionAdjustment                   ModelPrimitiveType float float float Single
    // 018 removePairList                           NativeList`1<int2> IL2CPP_TYPE_GENERICINST
    // 020 localPositions                           NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 030 localNormals                             NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 040 vertexToVertexMap                        NativeParallelMultiHashMap`2<ushort, ushort> IL2CPP_TYPE_GENERICINST
    // 050 boneWeights                              NativeArray`1<VirtualMeshBoneWeight> IL2CPP_TYPE_GENERICINST
    // 060 attributes                               NativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 070 joinIndices                              NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    public partial class JoinPairJob : DataModel
    {
        public float                                    JoinPositionAdjustment                  { get; set; }

        public static JoinPairJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JoinPairJob() { Pointer= p0 };

            value.JoinPositionAdjustment                    = GetSingle(new IntPtr(p + 0x010)); // 0x10 JoinPositionAdjustment      ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
