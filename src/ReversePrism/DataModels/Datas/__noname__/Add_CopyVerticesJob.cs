using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 VertexOffset                             ModelPrimitiveType int int int Int32
    // 014 SkinBoneOffset                           ModelPrimitiveType int int int Int32
    // 018 ToM                                      ModelEnumType float4x4 float4x4 float4x4 Int32
    // 058 srcAttributes                            NativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 068 srclocalPositions                        NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 078 srclocalNormals                          NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 088 srclocalTangents                         NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 098 srcUV                                    NativeArray`1<float2> IL2CPP_TYPE_GENERICINST
    // 0A8 srcBoneWeights                           NativeArray`1<VirtualMeshBoneWeight> IL2CPP_TYPE_GENERICINST
    // 0B8 dstAttributes                            NativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 0C8 dstlocalPositions                        NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0D8 dstlocalNormals                          NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0E8 dstlocalTangents                         NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0F8 dstUV                                    NativeArray`1<float2> IL2CPP_TYPE_GENERICINST
    // 108 dstBoneWeights                           NativeArray`1<VirtualMeshBoneWeight> IL2CPP_TYPE_GENERICINST
    // 118 dstSkinBoneIndices                       NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    public partial class Add_CopyVerticesJob : DataModel
    {
        public int                                      VertexOffset                            { get; set; }
        public int                                      SkinBoneOffset                          { get; set; }
        public float4x4                                 ToM                                     { get; set; }

        public static Add_CopyVerticesJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Add_CopyVerticesJob() { Pointer= p0 };

            value.VertexOffset                              = GetInt32(new IntPtr(p + 0x010)); // 0x10 VertexOffset                ( ModelPrimitiveType int int int Int32 )
            value.SkinBoneOffset                            = GetInt32(new IntPtr(p + 0x014)); // 0x14 SkinBoneOffset              ( ModelPrimitiveType int int int Int32 )
            value.ToM                                       = (float4x4)GetInt32(new IntPtr(p + 0x018)); // 0x18 ToM                         ( ModelEnumType float4x4 float4x4 float4x4 Int32 )

            return value;
        }
    }
}
