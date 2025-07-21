using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NewVertexCount                           ModelPrimitiveType int int int Int32
    // 018 newVertexToVertexMap                     NativeParallelMultiHashMap`2<ushort, ushort> IL2CPP_TYPE_GENERICINST
    // 028 edgeSet                                  NativeParallelHashSet`1<int2> IL2CPP_TYPE_GENERICINST
    public partial class Organize_CreateLineTriangleJob : DataModel
    {
        public int                                      NewVertexCount                          { get; set; }

        public static Organize_CreateLineTriangleJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Organize_CreateLineTriangleJob() { Pointer= p0 };

            value.NewVertexCount                            = GetInt32(new IntPtr(p + 0x010)); // 0x10 NewVertexCount              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
