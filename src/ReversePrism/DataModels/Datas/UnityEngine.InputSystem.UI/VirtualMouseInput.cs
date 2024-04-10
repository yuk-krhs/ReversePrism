using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_CursorMode                             0001866F7FC0 ModelEnumType CursorMode CursorMode CursorMode Int32
    // 028 M_CursorGraphic                          0001866920B0 ModelClassType Graphic Graphic Graphic Pointer
    // 030 M_CursorTransform                        000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 038 M_CursorSpeed                            0001866656B0 ModelPrimitiveType float float float Single
    // 03C M_ScrollSpeed                            0001866656B0 ModelPrimitiveType float float float Single
    // 040 M_StickAction                            0001865E90D0 ModelEnumType InputActionProperty InputActionProperty InputActionProperty Int32
    // 058 M_LeftButtonAction                       0001865E90D0 ModelEnumType InputActionProperty InputActionProperty InputActionProperty Int32
    // 070 M_MiddleButtonAction                     0001865E90D0 ModelEnumType InputActionProperty InputActionProperty InputActionProperty Int32
    // 088 M_RightButtonAction                      0001865E90D0 ModelEnumType InputActionProperty InputActionProperty InputActionProperty Int32
    // 0A0 M_ForwardButtonAction                    0001865E90D0 ModelEnumType InputActionProperty InputActionProperty InputActionProperty Int32
    // 0B8 M_BackButtonAction                       0001865E90D0 ModelEnumType InputActionProperty InputActionProperty InputActionProperty Int32
    // 0D0 M_ScrollWheelAction                      0001865E90D0 ModelEnumType InputActionProperty InputActionProperty InputActionProperty Int32
    // 0E8 M_Canvas                                 00018653FDA0 ModelClassType Canvas Canvas Canvas Pointer
    // 0F0 M_VirtualMouse                           0001866502A0 ModelClassType Mouse Mouse Mouse Pointer
    // 0F8 M_SystemMouse                            0001866502A0 ModelClassType Mouse Mouse Mouse Pointer
    // 100 M_AfterInputUpdateDelegate               0001866792B0 ModelClassType Action Action Action Pointer
    // 108 m_ButtonActionTriggeredDelegate          Action`1<CallbackContext> IL2CPP_TYPE_GENERICINST
    // 110 M_LastTime                               0001865C2950 ModelPrimitiveType double double double Double
    // 118 M_LastStickValue                         0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    public partial class VirtualMouseInput : DataModel
    {
        public CursorMode                               M_CursorMode                            { get; set; }
        public Graphic?                                 M_CursorGraphic                         { get; set; }
        public RectTransform?                           M_CursorTransform                       { get; set; }
        public float                                    M_CursorSpeed                           { get; set; }
        public float                                    M_ScrollSpeed                           { get; set; }
        public InputActionProperty                      M_StickAction                           { get; set; }
        public InputActionProperty                      M_LeftButtonAction                      { get; set; }
        public InputActionProperty                      M_MiddleButtonAction                    { get; set; }
        public InputActionProperty                      M_RightButtonAction                     { get; set; }
        public InputActionProperty                      M_ForwardButtonAction                   { get; set; }
        public InputActionProperty                      M_BackButtonAction                      { get; set; }
        public InputActionProperty                      M_ScrollWheelAction                     { get; set; }
        public Canvas?                                  M_Canvas                                { get; set; }
        public Mouse?                                   M_VirtualMouse                          { get; set; }
        public Mouse?                                   M_SystemMouse                           { get; set; }
        public Action?                                  M_AfterInputUpdateDelegate              { get; set; }
        public double                                   M_LastTime                              { get; set; }
        public Vector2                                  M_LastStickValue                        { get; set; }

        public static VirtualMouseInput? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VirtualMouseInput() { Pointer= p0 };

            value.M_CursorMode                              = (CursorMode)GetInt32(new IntPtr(p + 0x020)); // 024667812D78 0x20 M_CursorMode                ( 0001866F7FC0 ModelEnumType CursorMode CursorMode CursorMode Int32 )
            value.M_CursorGraphic                           = GetObject<Graphic>(new IntPtr(p + 0x028), ReversePrism.DataModels.Graphic.FromPointer); // 024667812D98 0x28 M_CursorGraphic             ( 0001866920B0 ModelClassType Graphic Graphic Graphic Pointer )
            value.M_CursorTransform                         = GetObject<RectTransform>(new IntPtr(p + 0x030), ReversePrism.DataModels.RectTransform.FromPointer); // 024667812DB8 0x30 M_CursorTransform           ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_CursorSpeed                             = GetSingle(new IntPtr(p + 0x038)); // 024667812DD8 0x38 M_CursorSpeed               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_ScrollSpeed                             = GetSingle(new IntPtr(p + 0x03C)); // 024667812DF8 0x3C M_ScrollSpeed               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_StickAction                             = (InputActionProperty)GetInt32(new IntPtr(p + 0x040)); // 024667812E18 0x40 M_StickAction               ( 0001865E90D0 ModelEnumType InputActionProperty InputActionProperty InputActionProperty Int32 )
            value.M_LeftButtonAction                        = (InputActionProperty)GetInt32(new IntPtr(p + 0x058)); // 024667812E38 0x58 M_LeftButtonAction          ( 0001865E90D0 ModelEnumType InputActionProperty InputActionProperty InputActionProperty Int32 )
            value.M_MiddleButtonAction                      = (InputActionProperty)GetInt32(new IntPtr(p + 0x070)); // 024667812E58 0x70 M_MiddleButtonAction        ( 0001865E90D0 ModelEnumType InputActionProperty InputActionProperty InputActionProperty Int32 )
            value.M_RightButtonAction                       = (InputActionProperty)GetInt32(new IntPtr(p + 0x088)); // 024667812E78 0x88 M_RightButtonAction         ( 0001865E90D0 ModelEnumType InputActionProperty InputActionProperty InputActionProperty Int32 )
            value.M_ForwardButtonAction                     = (InputActionProperty)GetInt32(new IntPtr(p + 0x0A0)); // 024667812E98 0xA0 M_ForwardButtonAction       ( 0001865E90D0 ModelEnumType InputActionProperty InputActionProperty InputActionProperty Int32 )
            value.M_BackButtonAction                        = (InputActionProperty)GetInt32(new IntPtr(p + 0x0B8)); // 024667812EB8 0xB8 M_BackButtonAction          ( 0001865E90D0 ModelEnumType InputActionProperty InputActionProperty InputActionProperty Int32 )
            value.M_ScrollWheelAction                       = (InputActionProperty)GetInt32(new IntPtr(p + 0x0D0)); // 024667812ED8 0xD0 M_ScrollWheelAction         ( 0001865E90D0 ModelEnumType InputActionProperty InputActionProperty InputActionProperty Int32 )
            value.M_Canvas                                  = GetObject<Canvas>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.Canvas.FromPointer); // 024667812EF8 0xE8 M_Canvas                    ( 00018653FDA0 ModelClassType Canvas Canvas Canvas Pointer )
            value.M_VirtualMouse                            = GetObject<Mouse>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.Mouse.FromPointer); // 024667812F18 0xF0 M_VirtualMouse              ( 0001866502A0 ModelClassType Mouse Mouse Mouse Pointer )
            value.M_SystemMouse                             = GetObject<Mouse>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.Mouse.FromPointer); // 024667812F38 0xF8 M_SystemMouse               ( 0001866502A0 ModelClassType Mouse Mouse Mouse Pointer )
            value.M_AfterInputUpdateDelegate                = GetObject<Action>(new IntPtr(p + 0x100), ReversePrism.DataModels.Action.FromPointer); // 024667812F58 0x100 M_AfterInputUpdateDelegate  ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.M_LastTime                                = GetDouble(new IntPtr(p + 0x110)); // 024667812F98 0x110 M_LastTime                  ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.M_LastStickValue                          = (Vector2)GetInt32(new IntPtr(p + 0x118)); // 024667812FB8 0x118 M_LastStickValue            ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
