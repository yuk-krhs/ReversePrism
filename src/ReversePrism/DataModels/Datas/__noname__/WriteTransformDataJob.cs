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
    // 030 transformPositionArray                   NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 040 transformRotationArray                   NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 050 teamIds                                  NativeArray`1<short> IL2CPP_TYPE_GENERICINST
    // 060 positions                                NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 070 rotations                                NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 080 vertexToTransformRotations               NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    public partial class WriteTransformDataJob : DataModel
    {

        public static WriteTransformDataJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WriteTransformDataJob() { Pointer= p0 };


            return value;
        }
    }
}
