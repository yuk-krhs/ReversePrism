using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SkinBoneOffset                           ModelPrimitiveType int int int Int32
    // 018 srcSkinBoneTransformIndices              NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 028 srcTransformPositionArray                NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 038 srcTransformRotationArray                NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 048 srcTransformScaleArray                   NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 058 DstCenterLocalToWorldMatrix              ModelEnumType float4x4 float4x4 float4x4 Int32
    // 098 dstSkinBoneBindPoses                     NativeArray`1<float4x4> IL2CPP_TYPE_GENERICINST
    public partial class Add_CalcBindPoseJob : DataModel
    {
        public int                                      SkinBoneOffset                          { get; set; }
        public float4x4                                 DstCenterLocalToWorldMatrix             { get; set; }

        public static Add_CalcBindPoseJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Add_CalcBindPoseJob() { Pointer= p0 };

            value.SkinBoneOffset                            = GetInt32(new IntPtr(p + 0x010)); // 0x10 SkinBoneOffset              ( ModelPrimitiveType int int int Int32 )
            value.DstCenterLocalToWorldMatrix               = (float4x4)GetInt32(new IntPtr(p + 0x058)); // 0x58 DstCenterLocalToWorldMatrix ( ModelEnumType float4x4 float4x4 float4x4 Int32 )

            return value;
        }
    }
}
