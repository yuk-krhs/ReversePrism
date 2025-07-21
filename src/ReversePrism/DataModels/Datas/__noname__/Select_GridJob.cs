using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 GridSize                                 ModelPrimitiveType float float float Single
    // 018 gridMap                                  NativeParallelMultiHashMap`2<int3, int> IL2CPP_TYPE_GENERICINST
    // 028 SelectionCount                           ModelPrimitiveType int int int Int32
    // 030 selectionPositions                       NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 040 selectionAttributes                      NativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 050 VertexCount                              ModelPrimitiveType int int int Int32
    // 054 TriangleCount                            ModelPrimitiveType int int int Int32
    // 058 SearchRadius                             ModelPrimitiveType float float float Single
    // 060 meshPositions                            NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 070 meshTriangles                            NativeArray`1<int3> IL2CPP_TYPE_GENERICINST
    // 080 newTriangles                             NativeList`1<int3> IL2CPP_TYPE_GENERICINST
    // 088 newVertexRemapIndices                    NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 098 newVertexCount                           NativeReference`1<int> IL2CPP_TYPE_GENERICINST
    public partial class Select_GridJob : DataModel
    {
        public float                                    GridSize                                { get; set; }
        public int                                      SelectionCount                          { get; set; }
        public int                                      VertexCount                             { get; set; }
        public int                                      TriangleCount                           { get; set; }
        public float                                    SearchRadius                            { get; set; }

        public static Select_GridJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Select_GridJob() { Pointer= p0 };

            value.GridSize                                  = GetSingle(new IntPtr(p + 0x010)); // 0x10 GridSize                    ( ModelPrimitiveType float float float Single )
            value.SelectionCount                            = GetInt32(new IntPtr(p + 0x028)); // 0x28 SelectionCount              ( ModelPrimitiveType int int int Int32 )
            value.VertexCount                               = GetInt32(new IntPtr(p + 0x050)); // 0x50 VertexCount                 ( ModelPrimitiveType int int int Int32 )
            value.TriangleCount                             = GetInt32(new IntPtr(p + 0x054)); // 0x54 TriangleCount               ( ModelPrimitiveType int int int Int32 )
            value.SearchRadius                              = GetSingle(new IntPtr(p + 0x058)); // 0x58 SearchRadius                ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
