using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Point                                  0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 018 M_Normal                                 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 020 M_RelativeVelocity                       0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 028 M_Separation                             0001866656B0 ModelPrimitiveType float float float Single
    // 02C M_NormalImpulse                          0001866656B0 ModelPrimitiveType float float float Single
    // 030 M_TangentImpulse                         0001866656B0 ModelPrimitiveType float float float Single
    // 034 M_Collider                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 M_OtherCollider                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 03C M_Rigidbody                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 040 M_OtherRigidbody                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 044 M_Enabled                                0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ContactPoint2D : DataModel
    {
        public Vector2                                  M_Point                                 { get; set; }
        public Vector2                                  M_Normal                                { get; set; }
        public Vector2                                  M_RelativeVelocity                      { get; set; }
        public float                                    M_Separation                            { get; set; }
        public float                                    M_NormalImpulse                         { get; set; }
        public float                                    M_TangentImpulse                        { get; set; }
        public int                                      M_Collider                              { get; set; }
        public int                                      M_OtherCollider                         { get; set; }
        public int                                      M_Rigidbody                             { get; set; }
        public int                                      M_OtherRigidbody                        { get; set; }
        public int                                      M_Enabled                               { get; set; }

        public static ContactPoint2D? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ContactPoint2D() { Pointer= p0 };

            value.M_Point                                   = (Vector2)GetInt32(new IntPtr(p + 0x010)); // 0245A22939A8 0x10 M_Point                     ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_Normal                                  = (Vector2)GetInt32(new IntPtr(p + 0x018)); // 0245A22939C8 0x18 M_Normal                    ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_RelativeVelocity                        = (Vector2)GetInt32(new IntPtr(p + 0x020)); // 0245A22939E8 0x20 M_RelativeVelocity          ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_Separation                              = GetSingle(new IntPtr(p + 0x028)); // 0245A2293A08 0x28 M_Separation                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_NormalImpulse                           = GetSingle(new IntPtr(p + 0x02C)); // 0245A2293A28 0x2C M_NormalImpulse             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_TangentImpulse                          = GetSingle(new IntPtr(p + 0x030)); // 0245A2293A48 0x30 M_TangentImpulse            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_Collider                                = GetInt32(new IntPtr(p + 0x034)); // 0245A2293A68 0x34 M_Collider                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_OtherCollider                           = GetInt32(new IntPtr(p + 0x038)); // 0245A2293A88 0x38 M_OtherCollider             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_Rigidbody                               = GetInt32(new IntPtr(p + 0x03C)); // 0245A2293AA8 0x3C M_Rigidbody                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_OtherRigidbody                          = GetInt32(new IntPtr(p + 0x040)); // 0245A2293AC8 0x40 M_OtherRigidbody            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_Enabled                                 = GetInt32(new IntPtr(p + 0x044)); // 0245A2293AE8 0x44 M_Enabled                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
