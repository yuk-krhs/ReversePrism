using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_Content                                000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 028 M_Horizontal                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 029 M_Vertical                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02C M_MovementType                           000186739470 ModelEnumType MovementType MovementType MovementType Int32
    // 030 M_Elasticity                             0001866656B0 ModelPrimitiveType float float float Single
    // 034 M_Inertia                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 M_DecelerationRate                       0001866656B0 ModelPrimitiveType float float float Single
    // 03C M_ScrollSensitivity                      0001866656B0 ModelPrimitiveType float float float Single
    // 040 M_Viewport                               000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 048 M_HorizontalScrollbar                    0001866FA460 ModelClassType Scrollbar Scrollbar Scrollbar Pointer
    // 050 M_VerticalScrollbar                      0001866FA460 ModelClassType Scrollbar Scrollbar Scrollbar Pointer
    // 058 M_HorizontalScrollbarVisibility          00018673A050 ModelEnumType ScrollbarVisibility ScrollbarVisibility ScrollbarVisibility Int32
    // 05C M_VerticalScrollbarVisibility            00018673A050 ModelEnumType ScrollbarVisibility ScrollbarVisibility ScrollbarVisibility Int32
    // 060 M_HorizontalScrollbarSpacing             0001866656B0 ModelPrimitiveType float float float Single
    // 064 M_VerticalScrollbarSpacing               0001866656B0 ModelPrimitiveType float float float Single
    // 068 M_OnValueChanged                         000186739B70 ModelClassType ScrollRectEvent ScrollRectEvent ScrollRectEvent Pointer
    // 070 M_PointerStartLocalCursor                0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 078 M_ContentStartPosition                   0001866A8470 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 080 M_ViewRect                               000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 088 M_ContentBounds                          000186599880 ModelEnumType Bounds Bounds Bounds Int32
    // 0A0 M_ViewBounds                             0001865993A0 ModelEnumType Bounds Bounds Bounds Int32
    // 0B8 M_Velocity                               0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 0C0 M_Dragging                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0C1 M_Scrolling                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0C4 M_PrevPosition                           0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 0CC M_PrevContentBounds                      0001865993A0 ModelEnumType Bounds Bounds Bounds Int32
    // 0E4 M_PrevViewBounds                         0001865993A0 ModelEnumType Bounds Bounds Bounds Int32
    // 0FC M_HasRebuiltLayout                       0001865974C0 ModelPrimitiveType bool bool bool Bool
    // 0FD M_HSliderExpand                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0FE M_VSliderExpand                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 100 M_HSliderHeight                          0001866656B0 ModelPrimitiveType float float float Single
    // 104 M_VSliderWidth                           0001866656B0 ModelPrimitiveType float float float Single
    // 108 M_Rect                                   000186630DC0 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 110 M_HorizontalScrollbarRect                000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 118 M_VerticalScrollbarRect                  000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 120 M_Tracker                                000186705B80 ModelEnumType DrivenRectTransformTracker DrivenRectTransformTracker DrivenRectTransformTracker Int32
    // 128 M_Corners                                000185CB10A8 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    public partial class ScrollRect : DataModel
    {
        public RectTransform?                           M_Content                               { get; set; }
        public bool                                     M_Horizontal                            { get; set; }
        public bool                                     M_Vertical                              { get; set; }
        public MovementType                             M_MovementType                          { get; set; }
        public float                                    M_Elasticity                            { get; set; }
        public bool                                     M_Inertia                               { get; set; }
        public float                                    M_DecelerationRate                      { get; set; }
        public float                                    M_ScrollSensitivity                     { get; set; }
        public RectTransform?                           M_Viewport                              { get; set; }
        public Scrollbar?                               M_HorizontalScrollbar                   { get; set; }
        public Scrollbar?                               M_VerticalScrollbar                     { get; set; }
        public ScrollbarVisibility                      M_HorizontalScrollbarVisibility         { get; set; }
        public ScrollbarVisibility                      M_VerticalScrollbarVisibility           { get; set; }
        public float                                    M_HorizontalScrollbarSpacing            { get; set; }
        public float                                    M_VerticalScrollbarSpacing              { get; set; }
        public ScrollRectEvent?                         M_OnValueChanged                        { get; set; }
        public Vector2                                  M_PointerStartLocalCursor               { get; set; }
        public Vector2                                  M_ContentStartPosition                  { get; set; }
        public RectTransform?                           M_ViewRect                              { get; set; }
        public Bounds                                   M_ContentBounds                         { get; set; }
        public Bounds                                   M_ViewBounds                            { get; set; }
        public Vector2                                  M_Velocity                              { get; set; }
        public bool                                     M_Dragging                              { get; set; }
        public bool                                     M_Scrolling                             { get; set; }
        public Vector2                                  M_PrevPosition                          { get; set; }
        public Bounds                                   M_PrevContentBounds                     { get; set; }
        public Bounds                                   M_PrevViewBounds                        { get; set; }
        public bool                                     M_HasRebuiltLayout                      { get; set; }
        public bool                                     M_HSliderExpand                         { get; set; }
        public bool                                     M_VSliderExpand                         { get; set; }
        public float                                    M_HSliderHeight                         { get; set; }
        public float                                    M_VSliderWidth                          { get; set; }
        public RectTransform?                           M_Rect                                  { get; set; }
        public RectTransform?                           M_HorizontalScrollbarRect               { get; set; }
        public RectTransform?                           M_VerticalScrollbarRect                 { get; set; }
        public DrivenRectTransformTracker               M_Tracker                               { get; set; }
        public List<Vector3>?                           M_Corners                               { get; set; }

        public static ScrollRect? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScrollRect() { Pointer= p0 };

            value.M_Content                                 = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 024660BD9A30 0x20 M_Content                   ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_Horizontal                              = GetBool(new IntPtr(p + 0x028)); // 024660BD9A50 0x28 M_Horizontal                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_Vertical                                = GetBool(new IntPtr(p + 0x029)); // 024660BD9A70 0x29 M_Vertical                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_MovementType                            = (MovementType)GetInt32(new IntPtr(p + 0x02C)); // 024660BD9A90 0x2C M_MovementType              ( 000186739470 ModelEnumType MovementType MovementType MovementType Int32 )
            value.M_Elasticity                              = GetSingle(new IntPtr(p + 0x030)); // 024660BD9AB0 0x30 M_Elasticity                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_Inertia                                 = GetBool(new IntPtr(p + 0x034)); // 024660BD9AD0 0x34 M_Inertia                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_DecelerationRate                        = GetSingle(new IntPtr(p + 0x038)); // 024660BD9AF0 0x38 M_DecelerationRate          ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_ScrollSensitivity                       = GetSingle(new IntPtr(p + 0x03C)); // 024660BD9B10 0x3C M_ScrollSensitivity         ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_Viewport                                = GetObject<RectTransform>(new IntPtr(p + 0x040), ReversePrism.DataModels.RectTransform.FromPointer); // 024660BD9B30 0x40 M_Viewport                  ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_HorizontalScrollbar                     = GetObject<Scrollbar>(new IntPtr(p + 0x048), ReversePrism.DataModels.Scrollbar.FromPointer); // 024660BD9B50 0x48 M_HorizontalScrollbar       ( 0001866FA460 ModelClassType Scrollbar Scrollbar Scrollbar Pointer )
            value.M_VerticalScrollbar                       = GetObject<Scrollbar>(new IntPtr(p + 0x050), ReversePrism.DataModels.Scrollbar.FromPointer); // 024660BD9B70 0x50 M_VerticalScrollbar         ( 0001866FA460 ModelClassType Scrollbar Scrollbar Scrollbar Pointer )
            value.M_HorizontalScrollbarVisibility           = (ScrollbarVisibility)GetInt32(new IntPtr(p + 0x058)); // 024660BD9B90 0x58 M_HorizontalScrollbarVisibility ( 00018673A050 ModelEnumType ScrollbarVisibility ScrollbarVisibility ScrollbarVisibility Int32 )
            value.M_VerticalScrollbarVisibility             = (ScrollbarVisibility)GetInt32(new IntPtr(p + 0x05C)); // 024660BD9BB0 0x5C M_VerticalScrollbarVisibility ( 00018673A050 ModelEnumType ScrollbarVisibility ScrollbarVisibility ScrollbarVisibility Int32 )
            value.M_HorizontalScrollbarSpacing              = GetSingle(new IntPtr(p + 0x060)); // 024660BD9BD0 0x60 M_HorizontalScrollbarSpacing ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_VerticalScrollbarSpacing                = GetSingle(new IntPtr(p + 0x064)); // 024660BD9BF0 0x64 M_VerticalScrollbarSpacing  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_OnValueChanged                          = GetObject<ScrollRectEvent>(new IntPtr(p + 0x068), ReversePrism.DataModels.ScrollRectEvent.FromPointer); // 024660BD9C10 0x68 M_OnValueChanged            ( 000186739B70 ModelClassType ScrollRectEvent ScrollRectEvent ScrollRectEvent Pointer )
            value.M_PointerStartLocalCursor                 = (Vector2)GetInt32(new IntPtr(p + 0x070)); // 024660BD9C30 0x70 M_PointerStartLocalCursor   ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_ContentStartPosition                    = (Vector2)GetInt32(new IntPtr(p + 0x078)); // 024660BD9C50 0x78 M_ContentStartPosition      ( 0001866A8470 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_ViewRect                                = GetObject<RectTransform>(new IntPtr(p + 0x080), ReversePrism.DataModels.RectTransform.FromPointer); // 024660BD9C70 0x80 M_ViewRect                  ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_ContentBounds                           = (Bounds)GetInt32(new IntPtr(p + 0x088)); // 024660BD9C90 0x88 M_ContentBounds             ( 000186599880 ModelEnumType Bounds Bounds Bounds Int32 )
            value.M_ViewBounds                              = (Bounds)GetInt32(new IntPtr(p + 0x0A0)); // 024660BD9CB0 0xA0 M_ViewBounds                ( 0001865993A0 ModelEnumType Bounds Bounds Bounds Int32 )
            value.M_Velocity                                = (Vector2)GetInt32(new IntPtr(p + 0x0B8)); // 024660BD9CD0 0xB8 M_Velocity                  ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_Dragging                                = GetBool(new IntPtr(p + 0x0C0)); // 024660BD9CF0 0xC0 M_Dragging                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_Scrolling                               = GetBool(new IntPtr(p + 0x0C1)); // 024660BD9D10 0xC1 M_Scrolling                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_PrevPosition                            = (Vector2)GetInt32(new IntPtr(p + 0x0C4)); // 024660BD9D30 0xC4 M_PrevPosition              ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_PrevContentBounds                       = (Bounds)GetInt32(new IntPtr(p + 0x0CC)); // 024660BD9D50 0xCC M_PrevContentBounds         ( 0001865993A0 ModelEnumType Bounds Bounds Bounds Int32 )
            value.M_PrevViewBounds                          = (Bounds)GetInt32(new IntPtr(p + 0x0E4)); // 024660BD9D70 0xE4 M_PrevViewBounds            ( 0001865993A0 ModelEnumType Bounds Bounds Bounds Int32 )
            value.M_HasRebuiltLayout                        = GetBool(new IntPtr(p + 0x0FC)); // 024660BD9D90 0xFC M_HasRebuiltLayout          ( 0001865974C0 ModelPrimitiveType bool bool bool Bool )
            value.M_HSliderExpand                           = GetBool(new IntPtr(p + 0x0FD)); // 024660BD9DB0 0xFD M_HSliderExpand             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_VSliderExpand                           = GetBool(new IntPtr(p + 0x0FE)); // 024660BD9DD0 0xFE M_VSliderExpand             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_HSliderHeight                           = GetSingle(new IntPtr(p + 0x100)); // 024660BD9DF0 0x100 M_HSliderHeight             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_VSliderWidth                            = GetSingle(new IntPtr(p + 0x104)); // 024660BD9E10 0x104 M_VSliderWidth              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_Rect                                    = GetObject<RectTransform>(new IntPtr(p + 0x108), ReversePrism.DataModels.RectTransform.FromPointer); // 024660BD9E30 0x108 M_Rect                      ( 000186630DC0 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_HorizontalScrollbarRect                 = GetObject<RectTransform>(new IntPtr(p + 0x110), ReversePrism.DataModels.RectTransform.FromPointer); // 024660BD9E50 0x110 M_HorizontalScrollbarRect   ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_VerticalScrollbarRect                   = GetObject<RectTransform>(new IntPtr(p + 0x118), ReversePrism.DataModels.RectTransform.FromPointer); // 024660BD9E70 0x118 M_VerticalScrollbarRect     ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_Tracker                                 = (DrivenRectTransformTracker)GetInt32(new IntPtr(p + 0x120)); // 024660BD9E90 0x120 M_Tracker                   ( 000186705B80 ModelEnumType DrivenRectTransformTracker DrivenRectTransformTracker DrivenRectTransformTracker Int32 )
            value.M_Corners                                 = GetEnumList<Vector3>(new IntPtr(p + 0x128)); // 024660BD9EB0 0x128 M_Corners                   ( 000185CB10A8 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )

            return value;
        }
    }
}
