using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kDynamicOriginClickable                  string IL2CPP_TYPE_STRING
    // 038 M_MovementRange                          0001866656B0 ModelPrimitiveType float float float Single
    // 03C M_DynamicOriginRange                     0001866656B0 ModelPrimitiveType float float float Single
    // 040 M_ControlPath                            000186671910 ModelPrimitiveType string string string String
    // 048 M_Behaviour                              000186531D40 ModelEnumType Behaviour Behaviour Behaviour Int32
    // 04C M_UseIsolatedInputActions                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 050 M_PointerDownAction                      0001865E7E40 ModelClassType InputAction InputAction InputAction Pointer
    // 058 M_PointerMoveAction                      0001865E7E40 ModelClassType InputAction InputAction InputAction Pointer
    // 060 M_StartPos                               0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 06C M_PointerDownPos                         0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 078 M_RaycastResults                         000185D00148 ModelEnumListType List`1<RaycastResult> List`1<RaycastResult> List<RaycastResult> Pointer
    // 080 M_PointerEventData                       0001866429D0 ModelClassType PointerEventData PointerEventData PointerEventData Pointer
    public partial class OnScreenStick : DataModel
    {
        public float                                    M_MovementRange                         { get; set; }
        public float                                    M_DynamicOriginRange                    { get; set; }
        public string                                   M_ControlPath                           { get; set; }
        public Behaviour                                M_Behaviour                             { get; set; }
        public bool                                     M_UseIsolatedInputActions               { get; set; }
        public InputAction?                             M_PointerDownAction                     { get; set; }
        public InputAction?                             M_PointerMoveAction                     { get; set; }
        public Vector3                                  M_StartPos                              { get; set; }
        public Vector2                                  M_PointerDownPos                        { get; set; }
        public List<RaycastResult>?                     M_RaycastResults                        { get; set; }
        public PointerEventData?                        M_PointerEventData                      { get; set; }

        public static OnScreenStick? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OnScreenStick() { Pointer= p0 };

            value.M_MovementRange                           = GetSingle(new IntPtr(p + 0x038)); // 0246678169E8 0x38 M_MovementRange             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_DynamicOriginRange                      = GetSingle(new IntPtr(p + 0x03C)); // 024667816A08 0x3C M_DynamicOriginRange        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_ControlPath                             = GetString(new IntPtr(p + 0x040)); // 024667816A28 0x40 M_ControlPath               ( 000186671910 ModelPrimitiveType string string string String )
            value.M_Behaviour                               = (Behaviour)GetInt32(new IntPtr(p + 0x048)); // 024667816A48 0x48 M_Behaviour                 ( 000186531D40 ModelEnumType Behaviour Behaviour Behaviour Int32 )
            value.M_UseIsolatedInputActions                 = GetBool(new IntPtr(p + 0x04C)); // 024667816A68 0x4C M_UseIsolatedInputActions   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_PointerDownAction                       = GetObject<InputAction>(new IntPtr(p + 0x050), ReversePrism.DataModels.InputAction.FromPointer); // 024667816A88 0x50 M_PointerDownAction         ( 0001865E7E40 ModelClassType InputAction InputAction InputAction Pointer )
            value.M_PointerMoveAction                       = GetObject<InputAction>(new IntPtr(p + 0x058), ReversePrism.DataModels.InputAction.FromPointer); // 024667816AA8 0x58 M_PointerMoveAction         ( 0001865E7E40 ModelClassType InputAction InputAction InputAction Pointer )
            value.M_StartPos                                = (Vector3)GetInt32(new IntPtr(p + 0x060)); // 024667816AC8 0x60 M_StartPos                  ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_PointerDownPos                          = (Vector2)GetInt32(new IntPtr(p + 0x06C)); // 024667816AE8 0x6C M_PointerDownPos            ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_RaycastResults                          = GetEnumList<RaycastResult>(new IntPtr(p + 0x078)); // 024667816B08 0x78 M_RaycastResults            ( 000185D00148 ModelEnumListType List`1<RaycastResult> List`1<RaycastResult> List<RaycastResult> Pointer )
            value.M_PointerEventData                        = GetObject<PointerEventData>(new IntPtr(p + 0x080), ReversePrism.DataModels.PointerEventData.FromPointer); // 024667816B28 0x80 M_PointerEventData          ( 0001866429D0 ModelClassType PointerEventData PointerEventData PointerEventData Pointer )

            return value;
        }
    }
}
