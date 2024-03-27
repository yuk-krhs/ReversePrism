using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Point                                  0001866ABA80 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 01C M_Normal                                 0001866ABA80 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 028 M_Impulse                                0001866ABA80 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 034 M_ThisColliderInstanceID                 0001865F2F90 ModelPrimitiveType int int int Int32
    // 038 M_OtherColliderInstanceID                0001865F2F90 ModelPrimitiveType int int int Int32
    // 03C M_Separation                             000186665900 ModelPrimitiveType float float float Single
    public partial class ContactPoint
    {
        public Vector3                                  M_Point                                 { get; set; }
        public Vector3                                  M_Normal                                { get; set; }
        public Vector3                                  M_Impulse                               { get; set; }
        public int                                      M_ThisColliderInstanceID                { get; set; }
        public int                                      M_OtherColliderInstanceID               { get; set; }
        public float                                    M_Separation                            { get; set; }

        public static ContactPoint? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ContactPoint();

            value.M_Point                                   = (Vector3)GetInt32(new IntPtr(p + 0x010)); // 027002144CD8 0x10 M_Point                     ( 0001866ABA80 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_Normal                                  = (Vector3)GetInt32(new IntPtr(p + 0x01C)); // 027002144CF8 0x1C M_Normal                    ( 0001866ABA80 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_Impulse                                 = (Vector3)GetInt32(new IntPtr(p + 0x028)); // 027002144D18 0x28 M_Impulse                   ( 0001866ABA80 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_ThisColliderInstanceID                  = GetInt32(new IntPtr(p + 0x034)); // 027002144D38 0x34 M_ThisColliderInstanceID    ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_OtherColliderInstanceID                 = GetInt32(new IntPtr(p + 0x038)); // 027002144D58 0x38 M_OtherColliderInstanceID   ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_Separation                              = GetSingle(new IntPtr(p + 0x03C)); // 027002144D78 0x3C M_Separation                ( 000186665900 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
