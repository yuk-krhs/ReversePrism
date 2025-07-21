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
    // 028 localPositions                           NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 038 edgeToTriangleList                       NativeParallelHashMap`2<int2, FixedList128Bytes`1<int>> IL2CPP_TYPE_GENERICINST
    // 048 newTriangles                             NativeList`1<int3> IL2CPP_TYPE_GENERICINST
    // 050 useQuadSet                               NativeParallelHashSet`1<int4> IL2CPP_TYPE_GENERICINST
    // 060 removeTriangleSet                        NativeParallelHashSet`1<int3> IL2CPP_TYPE_GENERICINST
    public partial class Optimize_EdgeToTrianlgeJob : DataModel
    {
        public int                                      Tcnt                                    { get; set; }

        public static Optimize_EdgeToTrianlgeJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Optimize_EdgeToTrianlgeJob() { Pointer= p0 };

            value.Tcnt                                      = GetInt32(new IntPtr(p + 0x010)); // 0x10 Tcnt                        ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
