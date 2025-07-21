using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Vmesh                                    ModelClassType VirtualMesh VirtualMesh VirtualMesh Pointer
    // 018 vertexJoinIndices                        NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 028 vertexToVertexMap                        NativeParallelMultiHashMap`2<ushort, ushort> IL2CPP_TYPE_GENERICINST
    // 038 vertexRemapIndices                       NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 048 useSkinBoneMap                           NativeParallelHashMap`2<int, int> IL2CPP_TYPE_GENERICINST
    // 058 newVertexToVertexMap                     NativeParallelMultiHashMap`2<ushort, ushort> IL2CPP_TYPE_GENERICINST
    // 068 edgeSet                                  NativeParallelHashSet`1<int2> IL2CPP_TYPE_GENERICINST
    // 078 triangleSet                              NativeParallelHashSet`1<int3> IL2CPP_TYPE_GENERICINST
    // 088 OldVertexCount                           ModelPrimitiveType int int int Int32
    // 08C NewVertexCount                           ModelPrimitiveType int int int Int32
    // 090 RemoveVertexCount                        ModelPrimitiveType int int int Int32
    // 098 newAttributes                            ExSimpleNativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 0A0 newLocalPositions                        ExSimpleNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0A8 newLocalNormals                          ExSimpleNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0B0 newLocalTangents                         ExSimpleNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0B8 newUv                                    ExSimpleNativeArray`1<float2> IL2CPP_TYPE_GENERICINST
    // 0C0 newBoneWeights                           ExSimpleNativeArray`1<VirtualMeshBoneWeight> IL2CPP_TYPE_GENERICINST
    // 0C8 newSkinBoneCount                         NativeReference`1<int> IL2CPP_TYPE_GENERICINST
    // 0D8 newSkinBoneTransformIndices              NativeList`1<int> IL2CPP_TYPE_GENERICINST
    // 0E0 newSkinBoneBindPoseList                  NativeList`1<float4x4> IL2CPP_TYPE_GENERICINST
    // 0E8 newLineList                              NativeList`1<int2> IL2CPP_TYPE_GENERICINST
    // 0F0 newTriangleList                          NativeList`1<int3> IL2CPP_TYPE_GENERICINST
    public partial class ReductionWorkData : DataModel
    {
        public VirtualMesh?                             Vmesh                                   { get; set; }
        public int                                      OldVertexCount                          { get; set; }
        public int                                      NewVertexCount                          { get; set; }
        public int                                      RemoveVertexCount                       { get; set; }

        public static ReductionWorkData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReductionWorkData() { Pointer= p0 };

            value.Vmesh                                     = GetObject<VirtualMesh>(new IntPtr(p + 0x010), ReversePrism.DataModels.VirtualMesh.FromPointer); // 0x10 Vmesh                       ( ModelClassType VirtualMesh VirtualMesh VirtualMesh Pointer )
            value.OldVertexCount                            = GetInt32(new IntPtr(p + 0x088)); // 0x88 OldVertexCount              ( ModelPrimitiveType int int int Int32 )
            value.NewVertexCount                            = GetInt32(new IntPtr(p + 0x08C)); // 0x8C NewVertexCount              ( ModelPrimitiveType int int int Int32 )
            value.RemoveVertexCount                         = GetInt32(new IntPtr(p + 0x090)); // 0x90 RemoveVertexCount           ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
