using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Viewport                                 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 028 ScrollDirection                          0001866F7950 ModelEnumType ScrollDirection ScrollDirection ScrollDirection Int32
    // 02C MovementType                             000186656490 ModelEnumType MovementType MovementType MovementType Int32
    // 030 Elasticity                               0001866656B0 ModelPrimitiveType float float float Single
    // 034 ScrollSensitivity                        0001866656B0 ModelPrimitiveType float float float Single
    // 038 WheelScrollSensitivityMultiplier         0001866656B0 ModelPrimitiveType float float float Single
    // 03C Inertia                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 040 DecelerationRate                         0001866656B0 ModelPrimitiveType float float float Single
    // 048 Snap                                     00018673DA20 ModelClassType Snap Snap Snap Pointer
    // 050 Draggable                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 058 Scrollbar                                0001866FA460 ModelClassType Scrollbar Scrollbar Scrollbar Pointer
    // 060 AutoScrollState                          00018673D540 ModelClassType AutoScrollState AutoScrollState AutoScrollState Pointer
    // 068 onValueChanged                           Action`1<float> IL2CPP_TYPE_GENERICINST
    // 070 onSelectionChanged                       Action`1<int> IL2CPP_TYPE_GENERICINST
    // 078 BeginDragPointerPosition                 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 080 ScrollStartPosition                      0001866656B0 ModelPrimitiveType float float float Single
    // 084 PrevPosition                             0001866656B0 ModelPrimitiveType float float float Single
    // 088 CurrentPosition                          0001866656B0 ModelPrimitiveType float float float Single
    // 08C TotalCount                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 090 Hold                                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 091 Scrolling                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 092 Dragging                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 094 Velocity                                 0001866656B0 ModelPrimitiveType float float float Single
    // 000 DefaultEasingFunction                    EasingFunction IL2CPP_TYPE_CLASS
    public partial class Scroller
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
            var value   = new Scroller();

            value.Viewport                                  = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D4C4C478 0x20 Viewport                    ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.ScrollDirection                           = (ScrollDirection)GetInt32(new IntPtr(p + 0x028)); // 0270D4C4C498 0x28 ScrollDirection             ( 0001866F7950 ModelEnumType ScrollDirection ScrollDirection ScrollDirection Int32 )
            value.MovementType                              = (MovementType)GetInt32(new IntPtr(p + 0x02C)); // 0270D4C4C4B8 0x2C MovementType                ( 000186656490 ModelEnumType MovementType MovementType MovementType Int32 )
            value.Elasticity                                = GetSingle(new IntPtr(p + 0x030)); // 0270D4C4C4D8 0x30 Elasticity                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ScrollSensitivity                         = GetSingle(new IntPtr(p + 0x034)); // 0270D4C4C4F8 0x34 ScrollSensitivity           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.WheelScrollSensitivityMultiplier          = GetSingle(new IntPtr(p + 0x038)); // 0270D4C4C518 0x38 WheelScrollSensitivityMultiplier ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Inertia                                   = GetBool(new IntPtr(p + 0x03C)); // 0270D4C4C538 0x3C Inertia                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DecelerationRate                          = GetSingle(new IntPtr(p + 0x040)); // 0270D4C4C558 0x40 DecelerationRate            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Snap                                      = GetObject<Snap>(new IntPtr(p + 0x048), ReversePrism.DataModels.Snap.FromPointer); // 0270D4C4C578 0x48 Snap                        ( 00018673DA20 ModelClassType Snap Snap Snap Pointer )
            value.Draggable                                 = GetBool(new IntPtr(p + 0x050)); // 0270D4C4C598 0x50 Draggable                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Scrollbar                                 = GetObject<Scrollbar>(new IntPtr(p + 0x058), ReversePrism.DataModels.Scrollbar.FromPointer); // 0270D4C4C5B8 0x58 Scrollbar                   ( 0001866FA460 ModelClassType Scrollbar Scrollbar Scrollbar Pointer )
            value.AutoScrollState                           = GetObject<AutoScrollState>(new IntPtr(p + 0x060), ReversePrism.DataModels.AutoScrollState.FromPointer); // 0270D4C4C5D8 0x60 AutoScrollState             ( 00018673D540 ModelClassType AutoScrollState AutoScrollState AutoScrollState Pointer )
            value.BeginDragPointerPosition                  = (Vector2)GetInt32(new IntPtr(p + 0x078)); // 0270D4C4C638 0x78 BeginDragPointerPosition    ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.ScrollStartPosition                       = GetSingle(new IntPtr(p + 0x080)); // 0270D4C4C658 0x80 ScrollStartPosition         ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.PrevPosition                              = GetSingle(new IntPtr(p + 0x084)); // 0270D4C4C678 0x84 PrevPosition                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CurrentPosition                           = GetSingle(new IntPtr(p + 0x088)); // 0270D4C4C698 0x88 CurrentPosition             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.TotalCount                                = GetInt32(new IntPtr(p + 0x08C)); // 0270D4C4C6B8 0x8C TotalCount                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Hold                                      = GetBool(new IntPtr(p + 0x090)); // 0270D4C4C6D8 0x90 Hold                        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Scrolling                                 = GetBool(new IntPtr(p + 0x091)); // 0270D4C4C6F8 0x91 Scrolling                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Dragging                                  = GetBool(new IntPtr(p + 0x092)); // 0270D4C4C718 0x92 Dragging                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Velocity                                  = GetSingle(new IntPtr(p + 0x094)); // 0270D4C4C738 0x94 Velocity                    ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
