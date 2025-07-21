using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 newVertexToVertexMap                     NativeParallelMultiHashMap`2<ushort, ushort> IL2CPP_TYPE_GENERICINST
    // 020 newLineList                              NativeList`1<int2> IL2CPP_TYPE_GENERICINST
    // 028 edgeSet                                  NativeParallelHashSet`1<int2> IL2CPP_TYPE_GENERICINST
    // 038 triangleSet                              NativeParallelHashSet`1<int3> IL2CPP_TYPE_GENERICINST
    public partial class Organize_CreateLineTriangleJob2 : DataModel
    {

        public static Organize_CreateLineTriangleJob2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Organize_CreateLineTriangleJob2() { Pointer= p0 };


            return value;
        }
    }
}
