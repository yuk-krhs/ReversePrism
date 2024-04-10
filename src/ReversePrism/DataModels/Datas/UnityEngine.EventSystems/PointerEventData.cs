using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PointerEnter                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 M_PointerPress                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 LastPress                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 RawPointerPress                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 PointerDrag                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 PointerClick                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 PointerCurrentRaycast                    000186613FB0 ModelEnumType RaycastResult RaycastResult RaycastResult Int32
    // 0A0 PointerPressRaycast                      000186613FB0 ModelEnumType RaycastResult RaycastResult RaycastResult Int32
    // 0F0 Hovered                                  000185CDD4D8 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    // 0F8 EligibleForClick                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0FC DisplayIndex                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 100 PointerId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 104 Position                                 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 10C Delta                                    0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 114 PressPosition                            0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 11C WorldPosition                            0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 128 WorldNormal                              0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 134 ClickTime                                0001866656B0 ModelPrimitiveType float float float Single
    // 138 ClickCount                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 13C ScrollDelta                              0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 144 UseDragThreshold                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 145 Dragging                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 148 Button                                   000186584A20 ModelEnumType InputButton InputButton InputButton Int32
    // 14C Pressure                                 0001866656B0 ModelPrimitiveType float float float Single
    // 150 TangentialPressure                       0001866656B0 ModelPrimitiveType float float float Single
    // 154 AltitudeAngle                            0001866656B0 ModelPrimitiveType float float float Single
    // 158 AzimuthAngle                             0001866656B0 ModelPrimitiveType float float float Single
    // 15C Twist                                    0001866656B0 ModelPrimitiveType float float float Single
    // 160 Tilt                                     0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 168 PenStatus                                00018672DE00 ModelEnumType PenStatus PenStatus PenStatus Int32
    // 16C Radius                                   0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 174 RadiusVariance                           0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 17C FullyExited                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 17D Reentered                                000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class PointerEventData : DataModel
    {
        public GameObject?                              PointerEnter                            { get; set; }
        public GameObject?                              M_PointerPress                          { get; set; }
        public GameObject?                              LastPress                               { get; set; }
        public GameObject?                              RawPointerPress                         { get; set; }
        public GameObject?                              PointerDrag                             { get; set; }
        public GameObject?                              PointerClick                            { get; set; }
        public RaycastResult                            PointerCurrentRaycast                   { get; set; }
        public RaycastResult                            PointerPressRaycast                     { get; set; }
        public List<GameObject>?                        Hovered                                 { get; set; }
        public bool                                     EligibleForClick                        { get; set; }
        public int                                      DisplayIndex                            { get; set; }
        public int                                      PointerId                               { get; set; }
        public Vector2                                  Position                                { get; set; }
        public Vector2                                  Delta                                   { get; set; }
        public Vector2                                  PressPosition                           { get; set; }
        public Vector3                                  WorldPosition                           { get; set; }
        public Vector3                                  WorldNormal                             { get; set; }
        public float                                    ClickTime                               { get; set; }
        public int                                      ClickCount                              { get; set; }
        public Vector2                                  ScrollDelta                             { get; set; }
        public bool                                     UseDragThreshold                        { get; set; }
        public bool                                     Dragging                                { get; set; }
        public InputButton                              Button                                  { get; set; }
        public float                                    Pressure                                { get; set; }
        public float                                    TangentialPressure                      { get; set; }
        public float                                    AltitudeAngle                           { get; set; }
        public float                                    AzimuthAngle                            { get; set; }
        public float                                    Twist                                   { get; set; }
        public Vector2                                  Tilt                                    { get; set; }
        public PenStatus                                PenStatus                               { get; set; }
        public Vector2                                  Radius                                  { get; set; }
        public Vector2                                  RadiusVariance                          { get; set; }
        public bool                                     FullyExited                             { get; set; }
        public bool                                     Reentered                               { get; set; }

        public static PointerEventData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PointerEventData() { Pointer= p0 };

            value.PointerEnter                              = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0245A3EBC958 0x20 PointerEnter                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.M_PointerPress                            = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0245A3EBC978 0x28 M_PointerPress              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.LastPress                                 = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0245A3EBC998 0x30 LastPress                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.RawPointerPress                           = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0245A3EBC9B8 0x38 RawPointerPress             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.PointerDrag                               = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0245A3EBC9D8 0x40 PointerDrag                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.PointerClick                              = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0245A3EBC9F8 0x48 PointerClick                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.PointerCurrentRaycast                     = (RaycastResult)GetInt32(new IntPtr(p + 0x050)); // 0245A3EBCA18 0x50 PointerCurrentRaycast       ( 000186613FB0 ModelEnumType RaycastResult RaycastResult RaycastResult Int32 )
            value.PointerPressRaycast                       = (RaycastResult)GetInt32(new IntPtr(p + 0x0A0)); // 0245A3EBCA38 0xA0 PointerPressRaycast         ( 000186613FB0 ModelEnumType RaycastResult RaycastResult RaycastResult Int32 )
            value.Hovered                                   = GetObjectList<GameObject>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.GameObject.FromPointer); // 0245A3EBCA58 0xF0 Hovered                     ( 000185CDD4D8 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )
            value.EligibleForClick                          = GetBool(new IntPtr(p + 0x0F8)); // 0245A3EBCA78 0xF8 EligibleForClick            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DisplayIndex                              = GetInt32(new IntPtr(p + 0x0FC)); // 0245A3EBCA98 0xFC DisplayIndex                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PointerId                                 = GetInt32(new IntPtr(p + 0x100)); // 0245A3EBCAB8 0x100 PointerId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Position                                  = (Vector2)GetInt32(new IntPtr(p + 0x104)); // 0245A3EBCAD8 0x104 Position                    ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Delta                                     = (Vector2)GetInt32(new IntPtr(p + 0x10C)); // 0245A3EBCAF8 0x10C Delta                       ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.PressPosition                             = (Vector2)GetInt32(new IntPtr(p + 0x114)); // 0245A3EBCB18 0x114 PressPosition               ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.WorldPosition                             = (Vector3)GetInt32(new IntPtr(p + 0x11C)); // 0245A3EBCB38 0x11C WorldPosition               ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.WorldNormal                               = (Vector3)GetInt32(new IntPtr(p + 0x128)); // 0245A3EBCB58 0x128 WorldNormal                 ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.ClickTime                                 = GetSingle(new IntPtr(p + 0x134)); // 0245A3EBCB78 0x134 ClickTime                   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ClickCount                                = GetInt32(new IntPtr(p + 0x138)); // 0245A3EBCB98 0x138 ClickCount                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ScrollDelta                               = (Vector2)GetInt32(new IntPtr(p + 0x13C)); // 0245A3EBCBB8 0x13C ScrollDelta                 ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.UseDragThreshold                          = GetBool(new IntPtr(p + 0x144)); // 0245A3EBCBD8 0x144 UseDragThreshold            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Dragging                                  = GetBool(new IntPtr(p + 0x145)); // 0245A3EBCBF8 0x145 Dragging                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Button                                    = (InputButton)GetInt32(new IntPtr(p + 0x148)); // 0245A3EBCC18 0x148 Button                      ( 000186584A20 ModelEnumType InputButton InputButton InputButton Int32 )
            value.Pressure                                  = GetSingle(new IntPtr(p + 0x14C)); // 0245A3EBCC38 0x14C Pressure                    ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.TangentialPressure                        = GetSingle(new IntPtr(p + 0x150)); // 0245A3EBCC58 0x150 TangentialPressure          ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.AltitudeAngle                             = GetSingle(new IntPtr(p + 0x154)); // 0245A3EBCC78 0x154 AltitudeAngle               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.AzimuthAngle                              = GetSingle(new IntPtr(p + 0x158)); // 0245A3EBCC98 0x158 AzimuthAngle                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Twist                                     = GetSingle(new IntPtr(p + 0x15C)); // 0245A3EBCCB8 0x15C Twist                       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Tilt                                      = (Vector2)GetInt32(new IntPtr(p + 0x160)); // 0245A3EBCCD8 0x160 Tilt                        ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.PenStatus                                 = (PenStatus)GetInt32(new IntPtr(p + 0x168)); // 0245A3EBCCF8 0x168 PenStatus                   ( 00018672DE00 ModelEnumType PenStatus PenStatus PenStatus Int32 )
            value.Radius                                    = (Vector2)GetInt32(new IntPtr(p + 0x16C)); // 0245A3EBCD18 0x16C Radius                      ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.RadiusVariance                            = (Vector2)GetInt32(new IntPtr(p + 0x174)); // 0245A3EBCD38 0x174 RadiusVariance              ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.FullyExited                               = GetBool(new IntPtr(p + 0x17C)); // 0245A3EBCD58 0x17C FullyExited                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Reentered                                 = GetBool(new IntPtr(p + 0x17D)); // 0245A3EBCD78 0x17D Reentered                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
