using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Viewport                                 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 028 ScrollDirection                          ModelEnumType ScrollDirection ScrollDirection ScrollDirection Int32
    // 02C MovementType                             ModelEnumType MovementType MovementType MovementType Int32
    // 030 Elasticity                               ModelPrimitiveType float float float Single
    // 034 ScrollSensitivity                        ModelPrimitiveType float float float Single
    // 038 WheelScrollSensitivityMultiplier         ModelPrimitiveType float float float Single
    // 03C Inertia                                  ModelPrimitiveType bool bool bool Bool
    // 040 DecelerationRate                         ModelPrimitiveType float float float Single
    // 048 Snap                                     ModelClassType Snap Snap Snap Pointer
    // 050 Draggable                                ModelPrimitiveType bool bool bool Bool
    // 058 Scrollbar                                ModelClassType Scrollbar Scrollbar Scrollbar Pointer
    // 060 AutoScrollState                          ModelClassType AutoScrollState AutoScrollState AutoScrollState Pointer
    // 068 onValueChanged                           Action`1<float> IL2CPP_TYPE_GENERICINST
    // 070 onSelectionChanged                       Action`1<int> IL2CPP_TYPE_GENERICINST
    // 078 BeginDragPointerPosition                 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 080 ScrollStartPosition                      ModelPrimitiveType float float float Single
    // 084 PrevPosition                             ModelPrimitiveType float float float Single
    // 088 CurrentPosition                          ModelPrimitiveType float float float Single
    // 08C TotalCount                               ModelPrimitiveType int int int Int32
    // 090 Hold                                     ModelPrimitiveType bool bool bool Bool
    // 091 Scrolling                                ModelPrimitiveType bool bool bool Bool
    // 092 Dragging                                 ModelPrimitiveType bool bool bool Bool
    // 094 Velocity                                 ModelPrimitiveType float float float Single
    // 000 DefaultEasingFunction                    EasingFunction IL2CPP_TYPE_CLASS
    public partial class Scroller : DataModel
    {
        public RectTransform?                           Viewport                                { get; set; }
        public ScrollDirection                          ScrollDirection                         { get; set; }
        public MovementType                             MovementType                            { get; set; }
        public float                                    Elasticity                              { get; set; }
        public float                                    ScrollSensitivity                       { get; set; }
        public float                                    WheelScrollSensitivityMultiplier        { get; set; }
        public bool                                     Inertia                                 { get; set; }
        public float                                    DecelerationRate                        { get; set; }
        public Snap?                                    Snap                                    { get; set; }
        public bool                                     Draggable                               { get; set; }
        public Scrollbar?                               Scrollbar                               { get; set; }
        public AutoScrollState?                         AutoScrollState                         { get; set; }
        public Vector2                                  BeginDragPointerPosition                { get; set; }
        public float                                    ScrollStartPosition                     { get; set; }
        public float                                    PrevPosition                            { get; set; }
        public float                                    CurrentPosition                         { get; set; }
        public int                                      TotalCount                              { get; set; }
        public bool                                     Hold                                    { get; set; }
        public bool                                     Scrolling                               { get; set; }
        public bool                                     Dragging                                { get; set; }
        public float                                    Velocity                                { get; set; }

        public static Scroller? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Scroller() { Pointer= p0 };

            value.Viewport                                  = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 0x20 Viewport                    ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.ScrollDirection                           = (ScrollDirection)GetInt32(new IntPtr(p + 0x028)); // 0x28 ScrollDirection             ( ModelEnumType ScrollDirection ScrollDirection ScrollDirection Int32 )
            value.MovementType                              = (MovementType)GetInt32(new IntPtr(p + 0x02C)); // 0x2C MovementType                ( ModelEnumType MovementType MovementType MovementType Int32 )
            value.Elasticity                                = GetSingle(new IntPtr(p + 0x030)); // 0x30 Elasticity                  ( ModelPrimitiveType float float float Single )
            value.ScrollSensitivity                         = GetSingle(new IntPtr(p + 0x034)); // 0x34 ScrollSensitivity           ( ModelPrimitiveType float float float Single )
            value.WheelScrollSensitivityMultiplier          = GetSingle(new IntPtr(p + 0x038)); // 0x38 WheelScrollSensitivityMultiplier ( ModelPrimitiveType float float float Single )
            value.Inertia                                   = GetBool(new IntPtr(p + 0x03C)); // 0x3C Inertia                     ( ModelPrimitiveType bool bool bool Bool )
            value.DecelerationRate                          = GetSingle(new IntPtr(p + 0x040)); // 0x40 DecelerationRate            ( ModelPrimitiveType float float float Single )
            value.Snap                                      = GetObject<Snap>(new IntPtr(p + 0x048), ReversePrism.DataModels.Snap.FromPointer); // 0x48 Snap                        ( ModelClassType Snap Snap Snap Pointer )
            value.Draggable                                 = GetBool(new IntPtr(p + 0x050)); // 0x50 Draggable                   ( ModelPrimitiveType bool bool bool Bool )
            value.Scrollbar                                 = GetObject<Scrollbar>(new IntPtr(p + 0x058), ReversePrism.DataModels.Scrollbar.FromPointer); // 0x58 Scrollbar                   ( ModelClassType Scrollbar Scrollbar Scrollbar Pointer )
            value.AutoScrollState                           = GetObject<AutoScrollState>(new IntPtr(p + 0x060), ReversePrism.DataModels.AutoScrollState.FromPointer); // 0x60 AutoScrollState             ( ModelClassType AutoScrollState AutoScrollState AutoScrollState Pointer )
            value.BeginDragPointerPosition                  = (Vector2)GetInt32(new IntPtr(p + 0x078)); // 0x78 BeginDragPointerPosition    ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.ScrollStartPosition                       = GetSingle(new IntPtr(p + 0x080)); // 0x80 ScrollStartPosition         ( ModelPrimitiveType float float float Single )
            value.PrevPosition                              = GetSingle(new IntPtr(p + 0x084)); // 0x84 PrevPosition                ( ModelPrimitiveType float float float Single )
            value.CurrentPosition                           = GetSingle(new IntPtr(p + 0x088)); // 0x88 CurrentPosition             ( ModelPrimitiveType float float float Single )
            value.TotalCount                                = GetInt32(new IntPtr(p + 0x08C)); // 0x8C TotalCount                  ( ModelPrimitiveType int int int Int32 )
            value.Hold                                      = GetBool(new IntPtr(p + 0x090)); // 0x90 Hold                        ( ModelPrimitiveType bool bool bool Bool )
            value.Scrolling                                 = GetBool(new IntPtr(p + 0x091)); // 0x91 Scrolling                   ( ModelPrimitiveType bool bool bool Bool )
            value.Dragging                                  = GetBool(new IntPtr(p + 0x092)); // 0x92 Dragging                    ( ModelPrimitiveType bool bool bool Bool )
            value.Velocity                                  = GetSingle(new IntPtr(p + 0x094)); // 0x94 Velocity                    ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
