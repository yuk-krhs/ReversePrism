using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TriangleCount                            ModelPrimitiveType int int int Int32
    // 018 triangles                                NativeArray`1<int3> IL2CPP_TYPE_GENERICINST
    // 028 vertexToVertexMap                        NativeParallelMultiHashMap`2<ushort, ushort> IL2CPP_TYPE_GENERICINST
    public partial class Reduction_InitVertexToVertexJob2 : DataModel
    {
        public int                                      TriangleCount                           { get; set; }

        public static Reduction_InitVertexToVertexJob2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Reduction_InitVertexToVertexJob2() { Pointer= p0 };

            value.TriangleCount                             = GetInt32(new IntPtr(p + 0x010)); // 0x10 TriangleCount               ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
