using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Controller                             00018659D1A0 ModelClassType CharacterController CharacterController CharacterController Pointer
    // 018 M_Collider                               0001865C9370 ModelClassType Collider Collider Collider Pointer
    // 020 M_Point                                  0001866ABA80 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 02C M_Normal                                 0001866ABA80 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 038 M_MoveDirection                          0001866ABA80 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 044 M_MoveLength                             000186665900 ModelPrimitiveType float float float Single
    // 048 M_Push                                   0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class ControllerColliderHit : DataModel
    {
        public CharacterController?                     M_Controller                            { get; set; }
        public Collider?                                M_Collider                              { get; set; }
        public Vector3                                  M_Point                                 { get; set; }
        public Vector3                                  M_Normal                                { get; set; }
        public Vector3                                  M_MoveDirection                         { get; set; }
        public float                                    M_MoveLength                            { get; set; }
        public int                                      M_Push                                  { get; set; }

        public static ControllerColliderHit? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ControllerColliderHit() { Pointer= p0 };

            value.M_Controller                              = GetObject<CharacterController>(new IntPtr(p + 0x010), ReversePrism.DataModels.CharacterController.FromPointer); // 0245A2146498 0x10 M_Controller                ( 00018659D1A0 ModelClassType CharacterController CharacterController CharacterController Pointer )
            value.M_Collider                                = GetObject<Collider>(new IntPtr(p + 0x018), ReversePrism.DataModels.Collider.FromPointer); // 0245A21464B8 0x18 M_Collider                  ( 0001865C9370 ModelClassType Collider Collider Collider Pointer )
            value.M_Point                                   = (Vector3)GetInt32(new IntPtr(p + 0x020)); // 0245A21464D8 0x20 M_Point                     ( 0001866ABA80 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_Normal                                  = (Vector3)GetInt32(new IntPtr(p + 0x02C)); // 0245A21464F8 0x2C M_Normal                    ( 0001866ABA80 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_MoveDirection                           = (Vector3)GetInt32(new IntPtr(p + 0x038)); // 0245A2146518 0x38 M_MoveDirection             ( 0001866ABA80 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_MoveLength                              = GetSingle(new IntPtr(p + 0x044)); // 0245A2146538 0x44 M_MoveLength                ( 000186665900 ModelPrimitiveType float float float Single )
            value.M_Push                                    = GetInt32(new IntPtr(p + 0x048)); // 0245A2146558 0x48 M_Push                      ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
