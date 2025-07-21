using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PointerEnter                             ModelClassType GameObject GameObject GameObject Pointer
    // 028 M_PointerPress                           ModelClassType GameObject GameObject GameObject Pointer
    // 030 LastPress                                ModelClassType GameObject GameObject GameObject Pointer
    // 038 RawPointerPress                          ModelClassType GameObject GameObject GameObject Pointer
    // 040 PointerDrag                              ModelClassType GameObject GameObject GameObject Pointer
    // 048 PointerClick                             ModelClassType GameObject GameObject GameObject Pointer
    // 050 PointerCurrentRaycast                    ModelEnumType RaycastResult RaycastResult RaycastResult Int32
    // 0A0 PointerPressRaycast                      ModelEnumType RaycastResult RaycastResult RaycastResult Int32
    // 0F0 Hovered                                  ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    // 0F8 EligibleForClick                         ModelPrimitiveType bool bool bool Bool
    // 0FC DisplayIndex                             ModelPrimitiveType int int int Int32
    // 100 PointerId                                ModelPrimitiveType int int int Int32
    // 104 Position                                 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 10C Delta                                    ModelEnumType Vector2 Vector2 Vector2 Int32
    // 114 PressPosition                            ModelEnumType Vector2 Vector2 Vector2 Int32
    // 11C WorldPosition                            ModelEnumType Vector3 Vector3 Vector3 Int32
    // 128 WorldNormal                              ModelEnumType Vector3 Vector3 Vector3 Int32
    // 134 ClickTime                                ModelPrimitiveType float float float Single
    // 138 ClickCount                               ModelPrimitiveType int int int Int32
    // 13C ScrollDelta                              ModelEnumType Vector2 Vector2 Vector2 Int32
    // 144 UseDragThreshold                         ModelPrimitiveType bool bool bool Bool
    // 145 Dragging                                 ModelPrimitiveType bool bool bool Bool
    // 148 Button                                   ModelEnumType InputButton InputButton InputButton Int32
    // 14C Pressure                                 ModelPrimitiveType float float float Single
    // 150 TangentialPressure                       ModelPrimitiveType float float float Single
    // 154 AltitudeAngle                            ModelPrimitiveType float float float Single
    // 158 AzimuthAngle                             ModelPrimitiveType float float float Single
    // 15C Twist                                    ModelPrimitiveType float float float Single
    // 160 Tilt                                     ModelEnumType Vector2 Vector2 Vector2 Int32
    // 168 PenStatus                                ModelEnumType PenStatus PenStatus PenStatus Int32
    // 16C Radius                                   ModelEnumType Vector2 Vector2 Vector2 Int32
    // 174 RadiusVariance                           ModelEnumType Vector2 Vector2 Vector2 Int32
    // 17C FullyExited                              ModelPrimitiveType bool bool bool Bool
    // 17D Reentered                                ModelPrimitiveType bool bool bool Bool
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

            value.PointerEnter                              = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 PointerEnter                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.M_PointerPress                            = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 M_PointerPress              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.LastPress                                 = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 LastPress                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.RawPointerPress                           = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 RawPointerPress             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.PointerDrag                               = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 PointerDrag                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.PointerClick                              = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 PointerClick                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.PointerCurrentRaycast                     = (RaycastResult)GetInt32(new IntPtr(p + 0x050)); // 0x50 PointerCurrentRaycast       ( ModelEnumType RaycastResult RaycastResult RaycastResult Int32 )
            value.PointerPressRaycast                       = (RaycastResult)GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 PointerPressRaycast         ( ModelEnumType RaycastResult RaycastResult RaycastResult Int32 )
            value.Hovered                                   = GetObjectList<GameObject>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.GameObject.FromPointer); // 0xF0 Hovered                     ( ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )
            value.EligibleForClick                          = GetBool(new IntPtr(p + 0x0F8)); // 0xF8 EligibleForClick            ( ModelPrimitiveType bool bool bool Bool )
            value.DisplayIndex                              = GetInt32(new IntPtr(p + 0x0FC)); // 0xFC DisplayIndex                ( ModelPrimitiveType int int int Int32 )
            value.PointerId                                 = GetInt32(new IntPtr(p + 0x100)); // 0x100 PointerId                   ( ModelPrimitiveType int int int Int32 )
            value.Position                                  = (Vector2)GetInt32(new IntPtr(p + 0x104)); // 0x104 Position                    ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Delta                                     = (Vector2)GetInt32(new IntPtr(p + 0x10C)); // 0x10C Delta                       ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.PressPosition                             = (Vector2)GetInt32(new IntPtr(p + 0x114)); // 0x114 PressPosition               ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.WorldPosition                             = (Vector3)GetInt32(new IntPtr(p + 0x11C)); // 0x11C WorldPosition               ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.WorldNormal                               = (Vector3)GetInt32(new IntPtr(p + 0x128)); // 0x128 WorldNormal                 ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.ClickTime                                 = GetSingle(new IntPtr(p + 0x134)); // 0x134 ClickTime                   ( ModelPrimitiveType float float float Single )
            value.ClickCount                                = GetInt32(new IntPtr(p + 0x138)); // 0x138 ClickCount                  ( ModelPrimitiveType int int int Int32 )
            value.ScrollDelta                               = (Vector2)GetInt32(new IntPtr(p + 0x13C)); // 0x13C ScrollDelta                 ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.UseDragThreshold                          = GetBool(new IntPtr(p + 0x144)); // 0x144 UseDragThreshold            ( ModelPrimitiveType bool bool bool Bool )
            value.Dragging                                  = GetBool(new IntPtr(p + 0x145)); // 0x145 Dragging                    ( ModelPrimitiveType bool bool bool Bool )
            value.Button                                    = (InputButton)GetInt32(new IntPtr(p + 0x148)); // 0x148 Button                      ( ModelEnumType InputButton InputButton InputButton Int32 )
            value.Pressure                                  = GetSingle(new IntPtr(p + 0x14C)); // 0x14C Pressure                    ( ModelPrimitiveType float float float Single )
            value.TangentialPressure                        = GetSingle(new IntPtr(p + 0x150)); // 0x150 TangentialPressure          ( ModelPrimitiveType float float float Single )
            value.AltitudeAngle                             = GetSingle(new IntPtr(p + 0x154)); // 0x154 AltitudeAngle               ( ModelPrimitiveType float float float Single )
            value.AzimuthAngle                              = GetSingle(new IntPtr(p + 0x158)); // 0x158 AzimuthAngle                ( ModelPrimitiveType float float float Single )
            value.Twist                                     = GetSingle(new IntPtr(p + 0x15C)); // 0x15C Twist                       ( ModelPrimitiveType float float float Single )
            value.Tilt                                      = (Vector2)GetInt32(new IntPtr(p + 0x160)); // 0x160 Tilt                        ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.PenStatus                                 = (PenStatus)GetInt32(new IntPtr(p + 0x168)); // 0x168 PenStatus                   ( ModelEnumType PenStatus PenStatus PenStatus Int32 )
            value.Radius                                    = (Vector2)GetInt32(new IntPtr(p + 0x16C)); // 0x16C Radius                      ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.RadiusVariance                            = (Vector2)GetInt32(new IntPtr(p + 0x174)); // 0x174 RadiusVariance              ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.FullyExited                               = GetBool(new IntPtr(p + 0x17C)); // 0x17C FullyExited                 ( ModelPrimitiveType bool bool bool Bool )
            value.Reentered                                 = GetBool(new IntPtr(p + 0x17D)); // 0x17D Reentered                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
