using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Centroid                               ModelEnumType Vector2 Vector2 Vector2 Int32
    // 018 M_Point                                  ModelEnumType Vector2 Vector2 Vector2 Int32
    // 020 M_Normal                                 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 028 M_Distance                               ModelPrimitiveType float float float Single
    // 02C M_Fraction                               ModelPrimitiveType float float float Single
    // 030 M_Collider                               ModelPrimitiveType int int int Int32
    public partial class RaycastHit2D : DataModel
    {
        public Vector2                                  M_Centroid                              { get; set; }
        public Vector2                                  M_Point                                 { get; set; }
        public Vector2                                  M_Normal                                { get; set; }
        public float                                    M_Distance                              { get; set; }
        public float                                    M_Fraction                              { get; set; }
        public int                                      M_Collider                              { get; set; }

        public static RaycastHit2D? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RaycastHit2D() { Pointer= p0 };

            value.M_Centroid                                = (Vector2)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Centroid                  ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_Point                                   = (Vector2)GetInt32(new IntPtr(p + 0x018)); // 0x18 M_Point                     ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_Normal                                  = (Vector2)GetInt32(new IntPtr(p + 0x020)); // 0x20 M_Normal                    ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_Distance                                = GetSingle(new IntPtr(p + 0x028)); // 0x28 M_Distance                  ( ModelPrimitiveType float float float Single )
            value.M_Fraction                                = GetSingle(new IntPtr(p + 0x02C)); // 0x2C M_Fraction                  ( ModelPrimitiveType float float float Single )
            value.M_Collider                                = GetInt32(new IntPtr(p + 0x030)); // 0x30 M_Collider                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
