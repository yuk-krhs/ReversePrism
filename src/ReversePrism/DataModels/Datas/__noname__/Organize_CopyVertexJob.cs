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
    // 030 oldAttributes                            NativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 040 oldLocalPositions                        NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 050 oldLocalNormals                          NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 060 oldLocalTangents                         NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 070 newAttributes                            NativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 080 newLocalPositions                        NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 090 newLocalNormals                          NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0A0 newLocalTangents                         NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    public partial class Organize_CopyVertexJob : DataModel
    {

        public static Organize_CopyVertexJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Organize_CopyVertexJob() { Pointer= p0 };


            return value;
        }
    }
}
