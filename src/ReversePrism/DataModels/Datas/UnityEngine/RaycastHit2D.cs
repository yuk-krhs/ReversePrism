using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Centroid                               0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 018 M_Point                                  0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 020 M_Normal                                 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 028 M_Distance                               0001866656B0 ModelPrimitiveType float float float Single
    // 02C M_Fraction                               0001866656B0 ModelPrimitiveType float float float Single
    // 030 M_Collider                               0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class RaycastHit2D
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
            var value   = new RaycastHit2D();

            value.M_Centroid                                = (Vector2)GetInt32(new IntPtr(p + 0x010)); // 0270022977F8 0x10 M_Centroid                  ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_Point                                   = (Vector2)GetInt32(new IntPtr(p + 0x018)); // 027002297818 0x18 M_Point                     ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_Normal                                  = (Vector2)GetInt32(new IntPtr(p + 0x020)); // 027002297838 0x20 M_Normal                    ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_Distance                                = GetSingle(new IntPtr(p + 0x028)); // 027002297858 0x28 M_Distance                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_Fraction                                = GetSingle(new IntPtr(p + 0x02C)); // 027002297878 0x2C M_Fraction                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_Collider                                = GetInt32(new IntPtr(p + 0x030)); // 027002297898 0x30 M_Collider                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
