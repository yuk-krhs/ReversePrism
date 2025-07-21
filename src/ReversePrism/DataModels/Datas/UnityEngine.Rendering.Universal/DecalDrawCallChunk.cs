using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 decalToWorlds                            NativeArray`1<float4x4> IL2CPP_TYPE_GENERICINST
    // 038 normalToDecals                           NativeArray`1<float4x4> IL2CPP_TYPE_GENERICINST
    // 048 renderingLayerMasks                      NativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 058 subCalls                                 NativeArray`1<DecalSubDrawCall> IL2CPP_TYPE_GENERICINST
    // 068 subCallCounts                            NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    public partial class DecalDrawCallChunk : DataModel
    {

        public static DecalDrawCallChunk? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DecalDrawCallChunk() { Pointer= p0 };


            return value;
        }
    }
}
