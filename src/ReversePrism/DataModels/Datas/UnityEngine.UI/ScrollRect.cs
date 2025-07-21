using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_Content                                ModelClassType RectTransform RectTransform RectTransform Pointer
    // 028 M_Horizontal                             ModelPrimitiveType bool bool bool Bool
    // 029 M_Vertical                               ModelPrimitiveType bool bool bool Bool
    // 02C M_MovementType                           ModelEnumType MovementType MovementType MovementType Int32
    // 030 M_Elasticity                             ModelPrimitiveType float float float Single
    // 034 M_Inertia                                ModelPrimitiveType bool bool bool Bool
    // 038 M_DecelerationRate                       ModelPrimitiveType float float float Single
    // 03C M_ScrollSensitivity                      ModelPrimitiveType float float float Single
    // 040 M_Viewport                               ModelClassType RectTransform RectTransform RectTransform Pointer
    // 048 M_HorizontalScrollbar                    ModelClassType Scrollbar Scrollbar Scrollbar Pointer
    // 050 M_VerticalScrollbar                      ModelClassType Scrollbar Scrollbar Scrollbar Pointer
    // 058 M_HorizontalScrollbarVisibility          ModelEnumType ScrollbarVisibility ScrollbarVisibility ScrollbarVisibility Int32
    // 05C M_VerticalScrollbarVisibility            ModelEnumType ScrollbarVisibility ScrollbarVisibility ScrollbarVisibility Int32
    // 060 M_HorizontalScrollbarSpacing             ModelPrimitiveType float float float Single
    // 064 M_VerticalScrollbarSpacing               ModelPrimitiveType float float float Single
    // 068 M_OnValueChanged                         ModelClassType ScrollRectEvent ScrollRectEvent ScrollRectEvent Pointer
    // 070 M_PointerStartLocalCursor                ModelEnumType Vector2 Vector2 Vector2 Int32
    // 078 M_ContentStartPosition                   ModelEnumType Vector2 Vector2 Vector2 Int32
    // 080 M_ViewRect                               ModelClassType RectTransform RectTransform RectTransform Pointer
    // 088 M_ContentBounds                          ModelEnumType Bounds Bounds Bounds Int32
    // 0A0 M_ViewBounds                             ModelEnumType Bounds Bounds Bounds Int32
    // 0B8 M_Velocity                               ModelEnumType Vector2 Vector2 Vector2 Int32
    // 0C0 M_Dragging                               ModelPrimitiveType bool bool bool Bool
    // 0C1 M_Scrolling                              ModelPrimitiveType bool bool bool Bool
    // 0C4 M_PrevPosition                           ModelEnumType Vector2 Vector2 Vector2 Int32
    // 0CC M_PrevContentBounds                      ModelEnumType Bounds Bounds Bounds Int32
    // 0E4 M_PrevViewBounds                         ModelEnumType Bounds Bounds Bounds Int32
    // 0FC M_HasRebuiltLayout                       ModelPrimitiveType bool bool bool Bool
    // 0FD M_HSliderExpand                          ModelPrimitiveType bool bool bool Bool
    // 0FE M_VSliderExpand                          ModelPrimitiveType bool bool bool Bool
    // 100 M_HSliderHeight                          ModelPrimitiveType float float float Single
    // 104 M_VSliderWidth                           ModelPrimitiveType float float float Single
    // 108 M_Rect                                   ModelClassType RectTransform RectTransform RectTransform Pointer
    // 110 M_HorizontalScrollbarRect                ModelClassType RectTransform RectTransform RectTransform Pointer
    // 118 M_VerticalScrollbarRect                  ModelClassType RectTransform RectTransform RectTransform Pointer
    // 120 M_Tracker                                ModelEnumType DrivenRectTransformTracker DrivenRectTransformTracker DrivenRectTransformTracker Int32
    // 128 M_Corners                                ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
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

            value.M_Content                                 = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 0x20 M_Content                   ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_Horizontal                              = GetBool(new IntPtr(p + 0x028)); // 0x28 M_Horizontal                ( ModelPrimitiveType bool bool bool Bool )
            value.M_Vertical                                = GetBool(new IntPtr(p + 0x029)); // 0x29 M_Vertical                  ( ModelPrimitiveType bool bool bool Bool )
            value.M_MovementType                            = (MovementType)GetInt32(new IntPtr(p + 0x02C)); // 0x2C M_MovementType              ( ModelEnumType MovementType MovementType MovementType Int32 )
            value.M_Elasticity                              = GetSingle(new IntPtr(p + 0x030)); // 0x30 M_Elasticity                ( ModelPrimitiveType float float float Single )
            value.M_Inertia                                 = GetBool(new IntPtr(p + 0x034)); // 0x34 M_Inertia                   ( ModelPrimitiveType bool bool bool Bool )
            value.M_DecelerationRate                        = GetSingle(new IntPtr(p + 0x038)); // 0x38 M_DecelerationRate          ( ModelPrimitiveType float float float Single )
            value.M_ScrollSensitivity                       = GetSingle(new IntPtr(p + 0x03C)); // 0x3C M_ScrollSensitivity         ( ModelPrimitiveType float float float Single )
            value.M_Viewport                                = GetObject<RectTransform>(new IntPtr(p + 0x040), ReversePrism.DataModels.RectTransform.FromPointer); // 0x40 M_Viewport                  ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_HorizontalScrollbar                     = GetObject<Scrollbar>(new IntPtr(p + 0x048), ReversePrism.DataModels.Scrollbar.FromPointer); // 0x48 M_HorizontalScrollbar       ( ModelClassType Scrollbar Scrollbar Scrollbar Pointer )
            value.M_VerticalScrollbar                       = GetObject<Scrollbar>(new IntPtr(p + 0x050), ReversePrism.DataModels.Scrollbar.FromPointer); // 0x50 M_VerticalScrollbar         ( ModelClassType Scrollbar Scrollbar Scrollbar Pointer )
            value.M_HorizontalScrollbarVisibility           = (ScrollbarVisibility)GetInt32(new IntPtr(p + 0x058)); // 0x58 M_HorizontalScrollbarVisibility ( ModelEnumType ScrollbarVisibility ScrollbarVisibility ScrollbarVisibility Int32 )
            value.M_VerticalScrollbarVisibility             = (ScrollbarVisibility)GetInt32(new IntPtr(p + 0x05C)); // 0x5C M_VerticalScrollbarVisibility ( ModelEnumType ScrollbarVisibility ScrollbarVisibility ScrollbarVisibility Int32 )
            value.M_HorizontalScrollbarSpacing              = GetSingle(new IntPtr(p + 0x060)); // 0x60 M_HorizontalScrollbarSpacing ( ModelPrimitiveType float float float Single )
            value.M_VerticalScrollbarSpacing                = GetSingle(new IntPtr(p + 0x064)); // 0x64 M_VerticalScrollbarSpacing  ( ModelPrimitiveType float float float Single )
            value.M_OnValueChanged                          = GetObject<ScrollRectEvent>(new IntPtr(p + 0x068), ReversePrism.DataModels.ScrollRectEvent.FromPointer); // 0x68 M_OnValueChanged            ( ModelClassType ScrollRectEvent ScrollRectEvent ScrollRectEvent Pointer )
            value.M_PointerStartLocalCursor                 = (Vector2)GetInt32(new IntPtr(p + 0x070)); // 0x70 M_PointerStartLocalCursor   ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_ContentStartPosition                    = (Vector2)GetInt32(new IntPtr(p + 0x078)); // 0x78 M_ContentStartPosition      ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_ViewRect                                = GetObject<RectTransform>(new IntPtr(p + 0x080), ReversePrism.DataModels.RectTransform.FromPointer); // 0x80 M_ViewRect                  ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_ContentBounds                           = (Bounds)GetInt32(new IntPtr(p + 0x088)); // 0x88 M_ContentBounds             ( ModelEnumType Bounds Bounds Bounds Int32 )
            value.M_ViewBounds                              = (Bounds)GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 M_ViewBounds                ( ModelEnumType Bounds Bounds Bounds Int32 )
            value.M_Velocity                                = (Vector2)GetInt32(new IntPtr(p + 0x0B8)); // 0xB8 M_Velocity                  ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_Dragging                                = GetBool(new IntPtr(p + 0x0C0)); // 0xC0 M_Dragging                  ( ModelPrimitiveType bool bool bool Bool )
            value.M_Scrolling                               = GetBool(new IntPtr(p + 0x0C1)); // 0xC1 M_Scrolling                 ( ModelPrimitiveType bool bool bool Bool )
            value.M_PrevPosition                            = (Vector2)GetInt32(new IntPtr(p + 0x0C4)); // 0xC4 M_PrevPosition              ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_PrevContentBounds                       = (Bounds)GetInt32(new IntPtr(p + 0x0CC)); // 0xCC M_PrevContentBounds         ( ModelEnumType Bounds Bounds Bounds Int32 )
            value.M_PrevViewBounds                          = (Bounds)GetInt32(new IntPtr(p + 0x0E4)); // 0xE4 M_PrevViewBounds            ( ModelEnumType Bounds Bounds Bounds Int32 )
            value.M_HasRebuiltLayout                        = GetBool(new IntPtr(p + 0x0FC)); // 0xFC M_HasRebuiltLayout          ( ModelPrimitiveType bool bool bool Bool )
            value.M_HSliderExpand                           = GetBool(new IntPtr(p + 0x0FD)); // 0xFD M_HSliderExpand             ( ModelPrimitiveType bool bool bool Bool )
            value.M_VSliderExpand                           = GetBool(new IntPtr(p + 0x0FE)); // 0xFE M_VSliderExpand             ( ModelPrimitiveType bool bool bool Bool )
            value.M_HSliderHeight                           = GetSingle(new IntPtr(p + 0x100)); // 0x100 M_HSliderHeight             ( ModelPrimitiveType float float float Single )
            value.M_VSliderWidth                            = GetSingle(new IntPtr(p + 0x104)); // 0x104 M_VSliderWidth              ( ModelPrimitiveType float float float Single )
            value.M_Rect                                    = GetObject<RectTransform>(new IntPtr(p + 0x108), ReversePrism.DataModels.RectTransform.FromPointer); // 0x108 M_Rect                      ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_HorizontalScrollbarRect                 = GetObject<RectTransform>(new IntPtr(p + 0x110), ReversePrism.DataModels.RectTransform.FromPointer); // 0x110 M_HorizontalScrollbarRect   ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_VerticalScrollbarRect                   = GetObject<RectTransform>(new IntPtr(p + 0x118), ReversePrism.DataModels.RectTransform.FromPointer); // 0x118 M_VerticalScrollbarRect     ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_Tracker                                 = (DrivenRectTransformTracker)GetInt32(new IntPtr(p + 0x120)); // 0x120 M_Tracker                   ( ModelEnumType DrivenRectTransformTracker DrivenRectTransformTracker DrivenRectTransformTracker Int32 )
            value.M_Corners                                 = GetEnumList<Vector3>(new IntPtr(p + 0x128)); // 0x128 M_Corners                   ( ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )

            return value;
        }
    }
}
