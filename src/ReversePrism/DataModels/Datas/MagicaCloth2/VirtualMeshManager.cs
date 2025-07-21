using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 teamIds                                  ExNativeArray`1<short> IL2CPP_TYPE_GENERICINST
    // 018 attributes                               ExNativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 020 vertexToTriangles                        ExNativeArray`1<FixedList32Bytes`1<uint>> IL2CPP_TYPE_GENERICINST
    // 028 vertexBindPosePositions                  ExNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 030 vertexBindPoseRotations                  ExNativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 038 vertexDepths                             ExNativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 040 vertexRootIndices                        ExNativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 048 vertexLocalPositions                     ExNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 050 vertexLocalRotations                     ExNativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 058 vertexParentIndices                      ExNativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 060 vertexChildIndexArray                    ExNativeArray`1<uint> IL2CPP_TYPE_GENERICINST
    // 068 vertexChildDataArray                     ExNativeArray`1<ushort> IL2CPP_TYPE_GENERICINST
    // 070 normalAdjustmentRotations                ExNativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 078 uv                                       ExNativeArray`1<float2> IL2CPP_TYPE_GENERICINST
    // 080 triangleTeamIdArray                      ExNativeArray`1<short> IL2CPP_TYPE_GENERICINST
    // 088 triangles                                ExNativeArray`1<int3> IL2CPP_TYPE_GENERICINST
    // 090 triangleNormals                          ExNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 098 triangleTangents                         ExNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0A0 edgeTeamIdArray                          ExNativeArray`1<short> IL2CPP_TYPE_GENERICINST
    // 0A8 edges                                    ExNativeArray`1<int2> IL2CPP_TYPE_GENERICINST
    // 0B0 edgeFlags                                ExNativeArray`1<ExBitFlag8> IL2CPP_TYPE_GENERICINST
    // 0B8 baseLineFlags                            ExNativeArray`1<ExBitFlag8> IL2CPP_TYPE_GENERICINST
    // 0C0 baseLineTeamIds                          ExNativeArray`1<short> IL2CPP_TYPE_GENERICINST
    // 0C8 baseLineStartDataIndices                 ExNativeArray`1<ushort> IL2CPP_TYPE_GENERICINST
    // 0D0 baseLineDataCounts                       ExNativeArray`1<ushort> IL2CPP_TYPE_GENERICINST
    // 0D8 baseLineData                             ExNativeArray`1<ushort> IL2CPP_TYPE_GENERICINST
    // 0E0 localPositions                           ExNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0E8 localNormals                             ExNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0F0 localTangents                            ExNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0F8 boneWeights                              ExNativeArray`1<VirtualMeshBoneWeight> IL2CPP_TYPE_GENERICINST
    // 100 skinBoneTransformIndices                 ExNativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 108 skinBoneBindPoses                        ExNativeArray`1<float4x4> IL2CPP_TYPE_GENERICINST
    // 110 vertexToTransformRotations               ExNativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 118 positions                                ExNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 120 rotations                                ExNativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 128 mappingIdArray                           ExNativeArray`1<short> IL2CPP_TYPE_GENERICINST
    // 130 mappingReferenceIndices                  ExNativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 138 mappingAttributes                        ExNativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 140 mappingLocalPositins                     ExNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 148 mappingLocalNormals                      ExNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 150 mappingBoneWeights                       ExNativeArray`1<VirtualMeshBoneWeight> IL2CPP_TYPE_GENERICINST
    // 158 mappingPositions                         ExNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 160 mappingNormals                           ExNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 168 IsValid                                  ModelPrimitiveType bool bool bool Bool
    public partial class VirtualMeshManager : DataModel
    {
        public bool                                     IsValid                                 { get; set; }

        public static VirtualMeshManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VirtualMeshManager() { Pointer= p0 };

            value.IsValid                                   = GetBool(new IntPtr(p + 0x168)); // 0x168 IsValid                     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
