using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 joinIndices                              NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 020 vertexRemapIndices                       NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 030 useSkinBoneMap                           NativeParallelHashMap`2<int, int> IL2CPP_TYPE_GENERICINST
    // 040 oldSkinBoneIndices                       NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 050 oldBoneWeights                           NativeArray`1<VirtualMeshBoneWeight> IL2CPP_TYPE_GENERICINST
    // 060 newBoneWeights                           NativeArray`1<VirtualMeshBoneWeight> IL2CPP_TYPE_GENERICINST
    public partial class Organize_RemapBoneWeightJob : DataModel
    {

        public static Organize_RemapBoneWeightJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Organize_RemapBoneWeightJob() { Pointer= p0 };


            return value;
        }
    }
}
