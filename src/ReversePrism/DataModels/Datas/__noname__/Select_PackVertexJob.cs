using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 VertexCount                              ModelPrimitiveType int int int Int32
    // 018 newVertexRemapIndices                    NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 028 attributes                               NativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 038 localPositions                           NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 048 localNormals                             NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 058 localTangents                            NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 068 uv                                       NativeArray`1<float2> IL2CPP_TYPE_GENERICINST
    // 078 boneWeights                              NativeArray`1<VirtualMeshBoneWeight> IL2CPP_TYPE_GENERICINST
    // 088 newReferenceIndices                      NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 098 newAttributes                            NativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 0A8 newLocalPositions                        NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0B8 newLocalNormals                          NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0C8 newLocalTangents                         NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0D8 newUv                                    NativeArray`1<float2> IL2CPP_TYPE_GENERICINST
    // 0E8 newBoneWeights                           NativeArray`1<VirtualMeshBoneWeight> IL2CPP_TYPE_GENERICINST
    public partial class Select_PackVertexJob : DataModel
    {
        public int                                      VertexCount                             { get; set; }

        public static Select_PackVertexJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Select_PackVertexJob() { Pointer= p0 };

            value.VertexCount                               = GetInt32(new IntPtr(p + 0x010)); // 0x10 VertexCount                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
