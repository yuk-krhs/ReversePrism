using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 triangleNormals                          NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 020 triangleTangents                         NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 030 vertexToTriangles                        NativeArray`1<FixedList32Bytes`1<uint>> IL2CPP_TYPE_GENERICINST
    // 040 localNormals                             NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 050 localTangents                            NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    public partial class Proxy_CalcVertexNormalTangentFromTriangleJob : DataModel
    {

        public static Proxy_CalcVertexNormalTangentFromTriangleJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Proxy_CalcVertexNormalTangentFromTriangleJob() { Pointer= p0 };


            return value;
        }
    }
}
