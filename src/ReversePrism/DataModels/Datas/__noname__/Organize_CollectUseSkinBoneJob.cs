using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OldVertexCount                           ModelPrimitiveType int int int Int32
    // 018 joinIndices                              NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 028 oldBoneWeights                           NativeArray`1<VirtualMeshBoneWeight> IL2CPP_TYPE_GENERICINST
    // 038 oldBindPoses                             NativeArray`1<float4x4> IL2CPP_TYPE_GENERICINST
    // 048 useSkinBoneMap                           NativeParallelHashMap`2<int, int> IL2CPP_TYPE_GENERICINST
    // 058 newSkinBoneTransformIndices              NativeList`1<int> IL2CPP_TYPE_GENERICINST
    // 060 newSkinBoneBindPoses                     NativeList`1<float4x4> IL2CPP_TYPE_GENERICINST
    // 068 newSkinBoneCount                         NativeReference`1<int> IL2CPP_TYPE_GENERICINST
    // 078 useSkinBoneMapKeyList                    NativeList`1<int> IL2CPP_TYPE_GENERICINST
    public partial class Organize_CollectUseSkinBoneJob : DataModel
    {
        public int                                      OldVertexCount                          { get; set; }

        public static Organize_CollectUseSkinBoneJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Organize_CollectUseSkinBoneJob() { Pointer= p0 };

            value.OldVertexCount                            = GetInt32(new IntPtr(p + 0x010)); // 0x10 OldVertexCount              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
