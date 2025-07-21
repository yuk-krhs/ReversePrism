using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PointerId                                ModelPrimitiveType int int int Int32
    // 018 PointerType                              ModelPrimitiveType string string string String
    // 020 IsPrimary                                ModelPrimitiveType bool bool bool Bool
    // 024 Button                                   ModelPrimitiveType int int int Int32
    // 028 PressedButtons                           ModelPrimitiveType int int int Int32
    // 02C Position                                 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 038 LocalPosition                            ModelEnumType Vector3 Vector3 Vector3 Int32
    // 044 DeltaPosition                            ModelEnumType Vector3 Vector3 Vector3 Int32
    // 050 DeltaTime                                ModelPrimitiveType float float float Single
    // 054 ClickCount                               ModelPrimitiveType int int int Int32
    // 058 Pressure                                 ModelPrimitiveType float float float Single
    // 05C TangentialPressure                       ModelPrimitiveType float float float Single
    // 060 AltitudeAngle                            ModelPrimitiveType float float float Single
    // 064 AzimuthAngle                             ModelPrimitiveType float float float Single
    // 068 Twist                                    ModelPrimitiveType float float float Single
    // 06C Tilt                                     ModelEnumType Vector2 Vector2 Vector2 Int32
    // 074 PenStatus                                ModelEnumType PenStatus PenStatus PenStatus Int32
    // 078 Radius                                   ModelEnumType Vector2 Vector2 Vector2 Int32
    // 080 RadiusVariance                           ModelEnumType Vector2 Vector2 Vector2 Int32
    // 088 Modifiers                                ModelEnumType EventModifiers EventModifiers EventModifiers Int32
    public partial class PointerEvent : DataModel
    {
        public int                                      PointerId                               { get; set; }
        public string                                   PointerType                             { get; set; }
        public bool                                     IsPrimary                               { get; set; }
        public int                                      Button                                  { get; set; }
        public int                                      PressedButtons                          { get; set; }
        public Vector3                                  Position                                { get; set; }
        public Vector3                                  LocalPosition                           { get; set; }
        public Vector3                                  DeltaPosition                           { get; set; }
        public float                                    DeltaTime                               { get; set; }
        public int                                      ClickCount                              { get; set; }
        public float                                    Pressure                                { get; set; }
        public float                                    TangentialPressure                      { get; set; }
        public float                                    AltitudeAngle                           { get; set; }
        public float                                    AzimuthAngle                            { get; set; }
        public float                                    Twist                                   { get; set; }
        public Vector2                                  Tilt                                    { get; set; }
        public PenStatus                                PenStatus                               { get; set; }
        public Vector2                                  Radius                                  { get; set; }
        public Vector2                                  RadiusVariance                          { get; set; }
        public EventModifiers                           Modifiers                               { get; set; }

        public static PointerEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PointerEvent() { Pointer= p0 };

            value.PointerId                                 = GetInt32(new IntPtr(p + 0x010)); // 0x10 PointerId                   ( ModelPrimitiveType int int int Int32 )
            value.PointerType                               = GetString(new IntPtr(p + 0x018)); // 0x18 PointerType                 ( ModelPrimitiveType string string string String )
            value.IsPrimary                                 = GetBool(new IntPtr(p + 0x020)); // 0x20 IsPrimary                   ( ModelPrimitiveType bool bool bool Bool )
            value.Button                                    = GetInt32(new IntPtr(p + 0x024)); // 0x24 Button                      ( ModelPrimitiveType int int int Int32 )
            value.PressedButtons                            = GetInt32(new IntPtr(p + 0x028)); // 0x28 PressedButtons              ( ModelPrimitiveType int int int Int32 )
            value.Position                                  = (Vector3)GetInt32(new IntPtr(p + 0x02C)); // 0x2C Position                    ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.LocalPosition                             = (Vector3)GetInt32(new IntPtr(p + 0x038)); // 0x38 LocalPosition               ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.DeltaPosition                             = (Vector3)GetInt32(new IntPtr(p + 0x044)); // 0x44 DeltaPosition               ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.DeltaTime                                 = GetSingle(new IntPtr(p + 0x050)); // 0x50 DeltaTime                   ( ModelPrimitiveType float float float Single )
            value.ClickCount                                = GetInt32(new IntPtr(p + 0x054)); // 0x54 ClickCount                  ( ModelPrimitiveType int int int Int32 )
            value.Pressure                                  = GetSingle(new IntPtr(p + 0x058)); // 0x58 Pressure                    ( ModelPrimitiveType float float float Single )
            value.TangentialPressure                        = GetSingle(new IntPtr(p + 0x05C)); // 0x5C TangentialPressure          ( ModelPrimitiveType float float float Single )
            value.AltitudeAngle                             = GetSingle(new IntPtr(p + 0x060)); // 0x60 AltitudeAngle               ( ModelPrimitiveType float float float Single )
            value.AzimuthAngle                              = GetSingle(new IntPtr(p + 0x064)); // 0x64 AzimuthAngle                ( ModelPrimitiveType float float float Single )
            value.Twist                                     = GetSingle(new IntPtr(p + 0x068)); // 0x68 Twist                       ( ModelPrimitiveType float float float Single )
            value.Tilt                                      = (Vector2)GetInt32(new IntPtr(p + 0x06C)); // 0x6C Tilt                        ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.PenStatus                                 = (PenStatus)GetInt32(new IntPtr(p + 0x074)); // 0x74 PenStatus                   ( ModelEnumType PenStatus PenStatus PenStatus Int32 )
            value.Radius                                    = (Vector2)GetInt32(new IntPtr(p + 0x078)); // 0x78 Radius                      ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.RadiusVariance                            = (Vector2)GetInt32(new IntPtr(p + 0x080)); // 0x80 RadiusVariance              ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Modifiers                                 = (EventModifiers)GetInt32(new IntPtr(p + 0x088)); // 0x88 Modifiers                   ( ModelEnumType EventModifiers EventModifiers EventModifiers Int32 )

            return value;
        }
    }
}
