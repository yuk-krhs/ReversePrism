using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 InvRot                                   ModelEnumType quaternion quaternion quaternion Int32
    // 020 localNormals                             NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 030 localTangents                            NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 040 vertexToTransformRotations               NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 050 transformRotations                       NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    public partial class Proxy_CalcVertexToTransformJob : DataModel
    {
        public quaternion                               InvRot                                  { get; set; }

        public static Proxy_CalcVertexToTransformJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Proxy_CalcVertexToTransformJob() { Pointer= p0 };

            value.InvRot                                    = (quaternion)GetInt32(new IntPtr(p + 0x010)); // 0x10 InvRot                      ( ModelEnumType quaternion quaternion quaternion Int32 )

            return value;
        }
    }
}
