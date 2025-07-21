using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 triangles                                NativeArray`1<int3> IL2CPP_TYPE_GENERICINST
    // 020 localPositins                            NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 030 triangleNormals                          NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    public partial class Proxy_CalcTriangleNormalJob : DataModel
    {

        public static Proxy_CalcTriangleNormalJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Proxy_CalcTriangleNormalJob() { Pointer= p0 };


            return value;
        }
    }
}
