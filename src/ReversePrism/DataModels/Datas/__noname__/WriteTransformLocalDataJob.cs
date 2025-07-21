using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 jobVertexIndexList                       NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 020 teamDataArray                            NativeArray`1<TeamData> IL2CPP_TYPE_GENERICINST
    // 030 teamIds                                  NativeArray`1<short> IL2CPP_TYPE_GENERICINST
    // 040 attributes                               NativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 050 vertexParentIndices                      NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 060 transformPositionArray                   NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 070 transformRotationArray                   NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 080 transformScaleArray                      NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 090 transformLocalPositionArray              NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0A0 transformLocalRotationArray              NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    public partial class WriteTransformLocalDataJob : DataModel
    {

        public static WriteTransformLocalDataJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WriteTransformLocalDataJob() { Pointer= p0 };


            return value;
        }
    }
}
