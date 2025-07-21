using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Tcnt                                     ModelPrimitiveType int int int Int32
    // 018 triangles                                NativeArray`1<int3> IL2CPP_TYPE_GENERICINST
    // 028 edgeToTriangles                          NativeParallelMultiHashMap`2<int2, ushort> IL2CPP_TYPE_GENERICINST
    public partial class Proxy_CalcEdgeToTriangleJob : DataModel
    {
        public int                                      Tcnt                                    { get; set; }

        public static Proxy_CalcEdgeToTriangleJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Proxy_CalcEdgeToTriangleJob() { Pointer= p0 };

            value.Tcnt                                      = GetInt32(new IntPtr(p + 0x010)); // 0x10 Tcnt                        ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
