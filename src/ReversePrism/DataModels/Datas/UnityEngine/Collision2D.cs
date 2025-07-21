using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Collider                               ModelPrimitiveType int int int Int32
    // 014 M_OtherCollider                          ModelPrimitiveType int int int Int32
    // 018 M_Rigidbody                              ModelPrimitiveType int int int Int32
    // 01C M_OtherRigidbody                         ModelPrimitiveType int int int Int32
    // 020 M_RelativeVelocity                       ModelEnumType Vector2 Vector2 Vector2 Int32
    // 028 M_Enabled                                ModelPrimitiveType int int int Int32
    // 02C M_ContactCount                           ModelPrimitiveType int int int Int32
    // 030 M_ReusedContacts                         ModelEnumListType ContactPoint2D[] ContactPoint2D[] List<ContactPoint2D> Pointer
    // 038 M_LegacyContacts                         ModelEnumListType ContactPoint2D[] ContactPoint2D[] List<ContactPoint2D> Pointer
    public partial class Collision2D : DataModel
    {
        public int                                      M_Collider                              { get; set; }
        public int                                      M_OtherCollider                         { get; set; }
        public int                                      M_Rigidbody                             { get; set; }
        public int                                      M_OtherRigidbody                        { get; set; }
        public Vector2                                  M_RelativeVelocity                      { get; set; }
        public int                                      M_Enabled                               { get; set; }
        public int                                      M_ContactCount                          { get; set; }
        public List<ContactPoint2D>?                    M_ReusedContacts                        { get; set; }
        public List<ContactPoint2D>?                    M_LegacyContacts                        { get; set; }

        public static Collision2D? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Collision2D() { Pointer= p0 };

            value.M_Collider                                = GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Collider                  ( ModelPrimitiveType int int int Int32 )
            value.M_OtherCollider                           = GetInt32(new IntPtr(p + 0x014)); // 0x14 M_OtherCollider             ( ModelPrimitiveType int int int Int32 )
            value.M_Rigidbody                               = GetInt32(new IntPtr(p + 0x018)); // 0x18 M_Rigidbody                 ( ModelPrimitiveType int int int Int32 )
            value.M_OtherRigidbody                          = GetInt32(new IntPtr(p + 0x01C)); // 0x1C M_OtherRigidbody            ( ModelPrimitiveType int int int Int32 )
            value.M_RelativeVelocity                        = (Vector2)GetInt32(new IntPtr(p + 0x020)); // 0x20 M_RelativeVelocity          ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_Enabled                                 = GetInt32(new IntPtr(p + 0x028)); // 0x28 M_Enabled                   ( ModelPrimitiveType int int int Int32 )
            value.M_ContactCount                            = GetInt32(new IntPtr(p + 0x02C)); // 0x2C M_ContactCount              ( ModelPrimitiveType int int int Int32 )
            value.M_ReusedContacts                          = GetEnumList<ContactPoint2D>(new IntPtr(p + 0x030)); // 0x30 M_ReusedContacts            ( ModelEnumListType ContactPoint2D[] ContactPoint2D[] List<ContactPoint2D> Pointer )
            value.M_LegacyContacts                          = GetEnumList<ContactPoint2D>(new IntPtr(p + 0x038)); // 0x38 M_LegacyContacts            ( ModelEnumListType ContactPoint2D[] ContactPoint2D[] List<ContactPoint2D> Pointer )

            return value;
        }
    }
}
