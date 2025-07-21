using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 vertexToTriangles                        NativeArray`1<FixedList32Bytes`1<uint>> IL2CPP_TYPE_GENERICINST
    // 020 triangleNormals                          NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 030 triangleTangents                         NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 040 attributes                               NativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    public partial class Proxy_OrganizeVertexToTrianglsJob : DataModel
    {

        public static Proxy_OrganizeVertexToTrianglsJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Proxy_OrganizeVertexToTrianglsJob() { Pointer= p0 };


            return value;
        }
    }
}
