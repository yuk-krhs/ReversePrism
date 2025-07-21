using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 WtoL                                     ModelEnumType float4x4 float4x4 float4x4 Int32
    // 050 LtoW                                     ModelEnumType float4x4 float4x4 float4x4 Int32
    // 090 transformPositions                       NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0A0 transformRotations                       NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 0B0 transformScales                          NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0C0 localPositions                           NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0D0 localNormals                             NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0E0 localTangents                            NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0F0 boneWeights                              NativeArray`1<VirtualMeshBoneWeight> IL2CPP_TYPE_GENERICINST
    // 100 skinBoneBindPoses                        NativeArray`1<float4x4> IL2CPP_TYPE_GENERICINST
    public partial class Import_BoneVertexJob : DataModel
    {
        public float4x4                                 WtoL                                    { get; set; }
        public float4x4                                 LtoW                                    { get; set; }

        public static Import_BoneVertexJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Import_BoneVertexJob() { Pointer= p0 };

            value.WtoL                                      = (float4x4)GetInt32(new IntPtr(p + 0x010)); // 0x10 WtoL                        ( ModelEnumType float4x4 float4x4 float4x4 Int32 )
            value.LtoW                                      = (float4x4)GetInt32(new IntPtr(p + 0x050)); // 0x50 LtoW                        ( ModelEnumType float4x4 float4x4 float4x4 Int32 )

            return value;
        }
    }
}
