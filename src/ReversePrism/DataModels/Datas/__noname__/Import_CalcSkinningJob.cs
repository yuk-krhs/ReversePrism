using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 localPositions                           NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 020 localNormals                             NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 030 localTangents                            NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 040 boneWeights                              NativeArray`1<VirtualMeshBoneWeight> IL2CPP_TYPE_GENERICINST
    // 050 skinBoneTransformIndices                 NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 060 bindPoses                                NativeArray`1<float4x4> IL2CPP_TYPE_GENERICINST
    // 070 transformPositionArray                   NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 080 transformRotationArray                   NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 090 transformScaleArray                      NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0A0 ToM                                      ModelEnumType float4x4 float4x4 float4x4 Int32
    public partial class Import_CalcSkinningJob : DataModel
    {
        public float4x4                                 ToM                                     { get; set; }

        public static Import_CalcSkinningJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Import_CalcSkinningJob() { Pointer= p0 };

            value.ToM                                       = (float4x4)GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 ToM                         ( ModelEnumType float4x4 float4x4 float4x4 Int32 )

            return value;
        }
    }
}
