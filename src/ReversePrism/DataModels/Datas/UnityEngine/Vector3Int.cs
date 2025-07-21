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
    // 018 M_Z                                      ModelPrimitiveType int int int Int32
    // 000 s_Zero                                   Vector3Int IL2CPP_TYPE_VALUETYPE
    // 00C s_One                                    Vector3Int IL2CPP_TYPE_VALUETYPE
    // 018 S_Up                                     ModelEnumType Vector3Int Vector3Int Vector3Int Int32
    // 024 S_Down                                   ModelEnumType Vector3Int Vector3Int Vector3Int Int32
    // 030 S_Left                                   ModelEnumType Vector3Int Vector3Int Vector3Int Int32
    // 03C S_Right                                  ModelEnumType Vector3Int Vector3Int Vector3Int Int32
    // 048 S_Forward                                ModelEnumType Vector3Int Vector3Int Vector3Int Int32
    // 054 S_Back                                   ModelEnumType Vector3Int Vector3Int Vector3Int Int32
    public partial class Vector3Int : DataModel
    {
        public int                                      M_X                                     { get; set; }
        public int                                      M_Y                                     { get; set; }
        public int                                      M_Z                                     { get; set; }
        public Vector3Int                               S_Up                                    { get; set; }
        public Vector3Int                               S_Down                                  { get; set; }
        public Vector3Int                               S_Left                                  { get; set; }
        public Vector3Int                               S_Right                                 { get; set; }
        public Vector3Int                               S_Forward                               { get; set; }
        public Vector3Int                               S_Back                                  { get; set; }

        public static Vector3Int? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Vector3Int() { Pointer= p0 };

            value.M_X                                       = GetInt32(new IntPtr(p + 0x010)); // 0x10 M_X                         ( ModelPrimitiveType int int int Int32 )
            value.M_Y                                       = GetInt32(new IntPtr(p + 0x014)); // 0x14 M_Y                         ( ModelPrimitiveType int int int Int32 )
            value.M_Z                                       = GetInt32(new IntPtr(p + 0x018)); // 0x18 M_Z                         ( ModelPrimitiveType int int int Int32 )
            value.S_Up                                      = (Vector3Int)GetInt32(new IntPtr(p + 0x018)); // 0x18 S_Up                        ( ModelEnumType Vector3Int Vector3Int Vector3Int Int32 )
            value.S_Down                                    = (Vector3Int)GetInt32(new IntPtr(p + 0x024)); // 0x24 S_Down                      ( ModelEnumType Vector3Int Vector3Int Vector3Int Int32 )
            value.S_Left                                    = (Vector3Int)GetInt32(new IntPtr(p + 0x030)); // 0x30 S_Left                      ( ModelEnumType Vector3Int Vector3Int Vector3Int Int32 )
            value.S_Right                                   = (Vector3Int)GetInt32(new IntPtr(p + 0x03C)); // 0x3C S_Right                     ( ModelEnumType Vector3Int Vector3Int Vector3Int Int32 )
            value.S_Forward                                 = (Vector3Int)GetInt32(new IntPtr(p + 0x048)); // 0x48 S_Forward                   ( ModelEnumType Vector3Int Vector3Int Vector3Int Int32 )
            value.S_Back                                    = (Vector3Int)GetInt32(new IntPtr(p + 0x054)); // 0x54 S_Back                      ( ModelEnumType Vector3Int Vector3Int Vector3Int Int32 )

            return value;
        }
    }
}
