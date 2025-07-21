using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_X                                      ModelPrimitiveType int int int Int32
    // 014 M_Y                                      ModelPrimitiveType int int int Int32
    // 000 s_Zero                                   Vector2Int IL2CPP_TYPE_VALUETYPE
    // 008 s_One                                    Vector2Int IL2CPP_TYPE_VALUETYPE
    // 010 S_Up                                     ModelEnumType Vector2Int Vector2Int Vector2Int Int32
    // 018 S_Down                                   ModelEnumType Vector2Int Vector2Int Vector2Int Int32
    // 020 S_Left                                   ModelEnumType Vector2Int Vector2Int Vector2Int Int32
    // 028 S_Right                                  ModelEnumType Vector2Int Vector2Int Vector2Int Int32
    public partial class Vector2Int : DataModel
    {
        public int                                      M_X                                     { get; set; }
        public int                                      M_Y                                     { get; set; }
        public Vector2Int                               S_Up                                    { get; set; }
        public Vector2Int                               S_Down                                  { get; set; }
        public Vector2Int                               S_Left                                  { get; set; }
        public Vector2Int                               S_Right                                 { get; set; }

        public static Vector2Int? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Vector2Int() { Pointer= p0 };

            value.M_X                                       = GetInt32(new IntPtr(p + 0x010)); // 0x10 M_X                         ( ModelPrimitiveType int int int Int32 )
            value.M_Y                                       = GetInt32(new IntPtr(p + 0x014)); // 0x14 M_Y                         ( ModelPrimitiveType int int int Int32 )
            value.S_Up                                      = (Vector2Int)GetInt32(new IntPtr(p + 0x010)); // 0x10 S_Up                        ( ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.S_Down                                    = (Vector2Int)GetInt32(new IntPtr(p + 0x018)); // 0x18 S_Down                      ( ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.S_Left                                    = (Vector2Int)GetInt32(new IntPtr(p + 0x020)); // 0x20 S_Left                      ( ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.S_Right                                   = (Vector2Int)GetInt32(new IntPtr(p + 0x028)); // 0x28 S_Right                     ( ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )

            return value;
        }
    }
}
