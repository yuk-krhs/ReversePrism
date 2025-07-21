using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_Edges                                  NativeArray`1<int2> IL2CPP_TYPE_GENERICINST
    // 020 m_Stars                                  NativeArray`1<UStar> IL2CPP_TYPE_GENERICINST
    // 030 m_Cells                                  NativeArray`1<int3> IL2CPP_TYPE_GENERICINST
    // 040 M_CellCount                              ModelPrimitiveType int int int Int32
    // 048 m_ILArray                                NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 058 m_IUArray                                NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 068 m_SPArray                                NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 078 M_NumEdges                               ModelPrimitiveType int int int Int32
    // 07C M_NumHulls                               ModelPrimitiveType int int int Int32
    // 080 M_NumPoints                              ModelPrimitiveType int int int Int32
    // 084 M_StarCount                              ModelPrimitiveType int int int Int32
    // 088 m_Flags                                  NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 098 m_Neighbors                              NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 0A8 m_Constraints                            NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 0B8 M_Allocator                              ModelEnumType Allocator Allocator Allocator Int32
    public partial class Tessellator : DataModel
    {
        public int                                      M_CellCount                             { get; set; }
        public int                                      M_NumEdges                              { get; set; }
        public int                                      M_NumHulls                              { get; set; }
        public int                                      M_NumPoints                             { get; set; }
        public int                                      M_StarCount                             { get; set; }
        public Allocator                                M_Allocator                             { get; set; }

        public static Tessellator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Tessellator() { Pointer= p0 };

            value.M_CellCount                               = GetInt32(new IntPtr(p + 0x040)); // 0x40 M_CellCount                 ( ModelPrimitiveType int int int Int32 )
            value.M_NumEdges                                = GetInt32(new IntPtr(p + 0x078)); // 0x78 M_NumEdges                  ( ModelPrimitiveType int int int Int32 )
            value.M_NumHulls                                = GetInt32(new IntPtr(p + 0x07C)); // 0x7C M_NumHulls                  ( ModelPrimitiveType int int int Int32 )
            value.M_NumPoints                               = GetInt32(new IntPtr(p + 0x080)); // 0x80 M_NumPoints                 ( ModelPrimitiveType int int int Int32 )
            value.M_StarCount                               = GetInt32(new IntPtr(p + 0x084)); // 0x84 M_StarCount                 ( ModelPrimitiveType int int int Int32 )
            value.M_Allocator                               = (Allocator)GetInt32(new IntPtr(p + 0x0B8)); // 0xB8 M_Allocator                 ( ModelEnumType Allocator Allocator Allocator Int32 )

            return value;
        }
    }
}
