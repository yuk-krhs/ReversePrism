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
    // 040 vertexBindPosePositions                  NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 050 vertexBindPoseRotations                  NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    public partial class Proxy_CalcVertexBindPoseJob2 : DataModel
    {

        public static Proxy_CalcVertexBindPoseJob2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Proxy_CalcVertexBindPoseJob2() { Pointer= p0 };


            return value;
        }
    }
}
