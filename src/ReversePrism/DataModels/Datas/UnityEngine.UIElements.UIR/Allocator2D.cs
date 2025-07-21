using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_MinSize                                ModelEnumType Vector2Int Vector2Int Vector2Int Int32
    // 018 M_MaxSize                                ModelEnumType Vector2Int Vector2Int Vector2Int Int32
    // 020 M_MaxAllocSize                           ModelEnumType Vector2Int Vector2Int Vector2Int Int32
    // 028 M_RowHeightBias                          ModelPrimitiveType int int int Int32
    // 030 M_Rows                                   ModelClassListType Row[] Row[] List<Row> Pointer
    // 038 M_Areas                                  ModelClassListType List`1<Area> List`1<Area> List<Area> Pointer
    public partial class Allocator2D : DataModel
    {
        public Vector2Int                               M_MinSize                               { get; set; }
        public Vector2Int                               M_MaxSize                               { get; set; }
        public Vector2Int                               M_MaxAllocSize                          { get; set; }
        public int                                      M_RowHeightBias                         { get; set; }
        public List<Row>?                               M_Rows                                  { get; set; }
        public List<Area>?                              M_Areas                                 { get; set; }

        public static Allocator2D? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Allocator2D() { Pointer= p0 };

            value.M_MinSize                                 = (Vector2Int)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_MinSize                   ( ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.M_MaxSize                                 = (Vector2Int)GetInt32(new IntPtr(p + 0x018)); // 0x18 M_MaxSize                   ( ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.M_MaxAllocSize                            = (Vector2Int)GetInt32(new IntPtr(p + 0x020)); // 0x20 M_MaxAllocSize              ( ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.M_RowHeightBias                           = GetInt32(new IntPtr(p + 0x028)); // 0x28 M_RowHeightBias             ( ModelPrimitiveType int int int Int32 )
            value.M_Rows                                    = GetObjectList<Row>(new IntPtr(p + 0x030), ReversePrism.DataModels.Row.FromPointer); // 0x30 M_Rows                      ( ModelClassListType Row[] Row[] List<Row> Pointer )
            value.M_Areas                                   = GetObjectList<Area>(new IntPtr(p + 0x038), ReversePrism.DataModels.Area.FromPointer); // 0x38 M_Areas                     ( ModelClassListType List`1<Area> List`1<Area> List<Area> Pointer )

            return value;
        }
    }
}
