using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 3C8 M_FirstLayoutPass                        ModelPrimitiveType int int int Int32
    // 3CC M_HorizontalScrollerVisibility           ModelEnumType ScrollerVisibility ScrollerVisibility ScrollerVisibility Int32
    // 3D0 M_VerticalScrollerVisibility             ModelEnumType ScrollerVisibility ScrollerVisibility ScrollerVisibility Int32
    // 3D8 M_AttachedRootVisualContainer            ModelClassType VisualElement VisualElement VisualElement Pointer
    // 3E0 M_SingleLineHeight                       ModelPrimitiveType float float float Single
    // 3E4 M_MouseWheelScrollSizeIsInline           ModelPrimitiveType bool bool bool Bool
    // 3E8 M_HorizontalPageSize                     ModelPrimitiveType float float float Single
    // 3EC M_VerticalPageSize                       ModelPrimitiveType float float float Single
    // 3F0 M_MouseWheelScrollSize                   ModelPrimitiveType float float float Single
    // 000 k_DefaultScrollDecelerationRate          float IL2CPP_TYPE_R4
    // 3F4 M_ScrollDecelerationRate                 ModelPrimitiveType float float float Single
    // 004 k_DefaultElasticity                      float IL2CPP_TYPE_R4
    // 3F8 M_Elasticity                             ModelPrimitiveType float float float Single
    // 3FC M_TouchScrollBehavior                    ModelEnumType TouchScrollBehavior TouchScrollBehavior TouchScrollBehavior Int32
    // 400 M_NestedInteractionKind                  ModelEnumType NestedInteractionKind NestedInteractionKind NestedInteractionKind Int32
    // 008 k_DefaultElasticAnimationInterval        long IL2CPP_TYPE_I8
    // 408 M_ElasticAnimationIntervalMs             ModelPrimitiveType long long long Int64
    // 410 ContentViewport                          ModelClassType VisualElement VisualElement VisualElement Pointer
    // 418 HorizontalScroller                       ModelClassType Scroller Scroller Scroller Pointer
    // 420 VerticalScroller                         ModelClassType Scroller Scroller Scroller Pointer
    // 428 M_ContentContainer                       ModelClassType VisualElement VisualElement VisualElement Pointer
    // 430 M_ContentAndVerticalScrollContainer      ModelClassType VisualElement VisualElement VisualElement Pointer
    // 010 UssClassName                             ModelPrimitiveType string string string String
    // 018 ViewportUssClassName                     ModelPrimitiveType string string string String
    // 020 HorizontalVariantViewportUssClassName    ModelPrimitiveType string string string String
    // 028 VerticalVariantViewportUssClassName      ModelPrimitiveType string string string String
    // 030 VerticalHorizontalVariantViewportUssClassName ModelPrimitiveType string string string String
    // 038 ContentAndVerticalScrollUssClassName     ModelPrimitiveType string string string String
    // 040 ContentUssClassName                      ModelPrimitiveType string string string String
    // 048 HorizontalVariantContentUssClassName     ModelPrimitiveType string string string String
    // 050 VerticalVariantContentUssClassName       ModelPrimitiveType string string string String
    // 058 VerticalHorizontalVariantContentUssClassName ModelPrimitiveType string string string String
    // 060 HScrollerUssClassName                    ModelPrimitiveType string string string String
    // 068 VScrollerUssClassName                    ModelPrimitiveType string string string String
    // 070 HorizontalVariantUssClassName            ModelPrimitiveType string string string String
    // 078 VerticalVariantUssClassName              ModelPrimitiveType string string string String
    // 080 VerticalHorizontalVariantUssClassName    ModelPrimitiveType string string string String
    // 088 ScrollVariantUssClassName                ModelPrimitiveType string string string String
    // 438 M_Mode                                   ModelEnumType ScrollViewMode ScrollViewMode ScrollViewMode Int32
    // 440 M_ScheduledLayoutPassResetItem           ModelClassType IVisualElementScheduledItem IVisualElementScheduledItem IVisualElementScheduledItem Pointer
    // 448 M_ScrollingPointerId                     ModelPrimitiveType int int int Int32
    // 44C M_StartPosition                          ModelEnumType Vector2 Vector2 Vector2 Int32
    // 454 M_PointerStartPosition                   ModelEnumType Vector2 Vector2 Vector2 Int32
    // 45C M_Velocity                               ModelEnumType Vector2 Vector2 Vector2 Int32
    // 464 M_SpringBackVelocity                     ModelEnumType Vector2 Vector2 Vector2 Int32
    // 46C M_LowBounds                              ModelEnumType Vector2 Vector2 Vector2 Int32
    // 474 M_HighBounds                             ModelEnumType Vector2 Vector2 Vector2 Int32
    // 47C M_LastVelocityLerpTime                   ModelPrimitiveType float float float Single
    // 480 M_StartedMoving                          ModelPrimitiveType bool bool bool Bool
    // 481 M_TouchStoppedVelocity                   ModelPrimitiveType bool bool bool Bool
    // 488 M_CapturedTarget                         ModelClassType VisualElement VisualElement VisualElement Pointer
    // 490 m_CapturedTargetPointerMoveCallback      EventCallback`1<PointerMoveEvent> IL2CPP_TYPE_GENERICINST
    // 498 m_CapturedTargetPointerUpCallback        EventCallback`1<PointerUpEvent> IL2CPP_TYPE_GENERICINST
    // 4A0 M_PostPointerUpAnimation                 ModelClassType IVisualElementScheduledItem IVisualElementScheduledItem IVisualElementScheduledItem Pointer
    public partial class ScrollView : DataModel
    {
        public int                                      M_FirstLayoutPass                       { get; set; }
        public ScrollerVisibility                       M_HorizontalScrollerVisibility          { get; set; }
        public ScrollerVisibility                       M_VerticalScrollerVisibility            { get; set; }
        public VisualElement?                           M_AttachedRootVisualContainer           { get; set; }
        public float                                    M_SingleLineHeight                      { get; set; }
        public bool                                     M_MouseWheelScrollSizeIsInline          { get; set; }
        public float                                    M_HorizontalPageSize                    { get; set; }
        public float                                    M_VerticalPageSize                      { get; set; }
        public float                                    M_MouseWheelScrollSize                  { get; set; }
        public float                                    M_ScrollDecelerationRate                { get; set; }
        public float                                    M_Elasticity                            { get; set; }
        public TouchScrollBehavior                      M_TouchScrollBehavior                   { get; set; }
        public NestedInteractionKind                    M_NestedInteractionKind                 { get; set; }
        public long                                     M_ElasticAnimationIntervalMs            { get; set; }
        public VisualElement?                           ContentViewport                         { get; set; }
        public Scroller?                                HorizontalScroller                      { get; set; }
        public Scroller?                                VerticalScroller                        { get; set; }
        public VisualElement?                           M_ContentContainer                      { get; set; }
        public VisualElement?                           M_ContentAndVerticalScrollContainer     { get; set; }
        public string                                   UssClassName                            { get; set; }
        public string                                   ViewportUssClassName                    { get; set; }
        public string                                   HorizontalVariantViewportUssClassName   { get; set; }
        public string                                   VerticalVariantViewportUssClassName     { get; set; }
        public string                                   VerticalHorizontalVariantViewportUssClassName { get; set; }
        public string                                   ContentAndVerticalScrollUssClassName    { get; set; }
        public string                                   ContentUssClassName                     { get; set; }
        public string                                   HorizontalVariantContentUssClassName    { get; set; }
        public string                                   VerticalVariantContentUssClassName      { get; set; }
        public string                                   VerticalHorizontalVariantContentUssClassName { get; set; }
        public string                                   HScrollerUssClassName                   { get; set; }
        public string                                   VScrollerUssClassName                   { get; set; }
        public string                                   HorizontalVariantUssClassName           { get; set; }
        public string                                   VerticalVariantUssClassName             { get; set; }
        public string                                   VerticalHorizontalVariantUssClassName   { get; set; }
        public string                                   ScrollVariantUssClassName               { get; set; }
        public ScrollViewMode                           M_Mode                                  { get; set; }
        public IVisualElementScheduledItem?             M_ScheduledLayoutPassResetItem          { get; set; }
        public int                                      M_ScrollingPointerId                    { get; set; }
        public Vector2                                  M_StartPosition                         { get; set; }
        public Vector2                                  M_PointerStartPosition                  { get; set; }
        public Vector2                                  M_Velocity                              { get; set; }
        public Vector2                                  M_SpringBackVelocity                    { get; set; }
        public Vector2                                  M_LowBounds                             { get; set; }
        public Vector2                                  M_HighBounds                            { get; set; }
        public float                                    M_LastVelocityLerpTime                  { get; set; }
        public bool                                     M_StartedMoving                         { get; set; }
        public bool                                     M_TouchStoppedVelocity                  { get; set; }
        public VisualElement?                           M_CapturedTarget                        { get; set; }
        public IVisualElementScheduledItem?             M_PostPointerUpAnimation                { get; set; }

        public static ScrollView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScrollView() { Pointer= p0 };

            value.M_FirstLayoutPass                         = GetInt32(new IntPtr(p + 0x3C8)); // 0x3C8 M_FirstLayoutPass           ( ModelPrimitiveType int int int Int32 )
            value.M_HorizontalScrollerVisibility            = (ScrollerVisibility)GetInt32(new IntPtr(p + 0x3CC)); // 0x3CC M_HorizontalScrollerVisibility ( ModelEnumType ScrollerVisibility ScrollerVisibility ScrollerVisibility Int32 )
            value.M_VerticalScrollerVisibility              = (ScrollerVisibility)GetInt32(new IntPtr(p + 0x3D0)); // 0x3D0 M_VerticalScrollerVisibility ( ModelEnumType ScrollerVisibility ScrollerVisibility ScrollerVisibility Int32 )
            value.M_AttachedRootVisualContainer             = GetObject<VisualElement>(new IntPtr(p + 0x3D8), ReversePrism.DataModels.VisualElement.FromPointer); // 0x3D8 M_AttachedRootVisualContainer ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_SingleLineHeight                        = GetSingle(new IntPtr(p + 0x3E0)); // 0x3E0 M_SingleLineHeight          ( ModelPrimitiveType float float float Single )
            value.M_MouseWheelScrollSizeIsInline            = GetBool(new IntPtr(p + 0x3E4)); // 0x3E4 M_MouseWheelScrollSizeIsInline ( ModelPrimitiveType bool bool bool Bool )
            value.M_HorizontalPageSize                      = GetSingle(new IntPtr(p + 0x3E8)); // 0x3E8 M_HorizontalPageSize        ( ModelPrimitiveType float float float Single )
            value.M_VerticalPageSize                        = GetSingle(new IntPtr(p + 0x3EC)); // 0x3EC M_VerticalPageSize          ( ModelPrimitiveType float float float Single )
            value.M_MouseWheelScrollSize                    = GetSingle(new IntPtr(p + 0x3F0)); // 0x3F0 M_MouseWheelScrollSize      ( ModelPrimitiveType float float float Single )
            value.M_ScrollDecelerationRate                  = GetSingle(new IntPtr(p + 0x3F4)); // 0x3F4 M_ScrollDecelerationRate    ( ModelPrimitiveType float float float Single )
            value.M_Elasticity                              = GetSingle(new IntPtr(p + 0x3F8)); // 0x3F8 M_Elasticity                ( ModelPrimitiveType float float float Single )
            value.M_TouchScrollBehavior                     = (TouchScrollBehavior)GetInt32(new IntPtr(p + 0x3FC)); // 0x3FC M_TouchScrollBehavior       ( ModelEnumType TouchScrollBehavior TouchScrollBehavior TouchScrollBehavior Int32 )
            value.M_NestedInteractionKind                   = (NestedInteractionKind)GetInt32(new IntPtr(p + 0x400)); // 0x400 M_NestedInteractionKind     ( ModelEnumType NestedInteractionKind NestedInteractionKind NestedInteractionKind Int32 )
            value.M_ElasticAnimationIntervalMs              = GetInt64(new IntPtr(p + 0x408)); // 0x408 M_ElasticAnimationIntervalMs ( ModelPrimitiveType long long long Int64 )
            value.ContentViewport                           = GetObject<VisualElement>(new IntPtr(p + 0x410), ReversePrism.DataModels.VisualElement.FromPointer); // 0x410 ContentViewport             ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.HorizontalScroller                        = GetObject<Scroller>(new IntPtr(p + 0x418), ReversePrism.DataModels.Scroller.FromPointer); // 0x418 HorizontalScroller          ( ModelClassType Scroller Scroller Scroller Pointer )
            value.VerticalScroller                          = GetObject<Scroller>(new IntPtr(p + 0x420), ReversePrism.DataModels.Scroller.FromPointer); // 0x420 VerticalScroller            ( ModelClassType Scroller Scroller Scroller Pointer )
            value.M_ContentContainer                        = GetObject<VisualElement>(new IntPtr(p + 0x428), ReversePrism.DataModels.VisualElement.FromPointer); // 0x428 M_ContentContainer          ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_ContentAndVerticalScrollContainer       = GetObject<VisualElement>(new IntPtr(p + 0x430), ReversePrism.DataModels.VisualElement.FromPointer); // 0x430 M_ContentAndVerticalScrollContainer ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.UssClassName                              = GetString(new IntPtr(p + 0x010)); // 0x10 UssClassName                ( ModelPrimitiveType string string string String )
            value.ViewportUssClassName                      = GetString(new IntPtr(p + 0x018)); // 0x18 ViewportUssClassName        ( ModelPrimitiveType string string string String )
            value.HorizontalVariantViewportUssClassName     = GetString(new IntPtr(p + 0x020)); // 0x20 HorizontalVariantViewportUssClassName ( ModelPrimitiveType string string string String )
            value.VerticalVariantViewportUssClassName       = GetString(new IntPtr(p + 0x028)); // 0x28 VerticalVariantViewportUssClassName ( ModelPrimitiveType string string string String )
            value.VerticalHorizontalVariantViewportUssClassName = GetString(new IntPtr(p + 0x030)); // 0x30 VerticalHorizontalVariantViewportUssClassName ( ModelPrimitiveType string string string String )
            value.ContentAndVerticalScrollUssClassName      = GetString(new IntPtr(p + 0x038)); // 0x38 ContentAndVerticalScrollUssClassName ( ModelPrimitiveType string string string String )
            value.ContentUssClassName                       = GetString(new IntPtr(p + 0x040)); // 0x40 ContentUssClassName         ( ModelPrimitiveType string string string String )
            value.HorizontalVariantContentUssClassName      = GetString(new IntPtr(p + 0x048)); // 0x48 HorizontalVariantContentUssClassName ( ModelPrimitiveType string string string String )
            value.VerticalVariantContentUssClassName        = GetString(new IntPtr(p + 0x050)); // 0x50 VerticalVariantContentUssClassName ( ModelPrimitiveType string string string String )
            value.VerticalHorizontalVariantContentUssClassName = GetString(new IntPtr(p + 0x058)); // 0x58 VerticalHorizontalVariantContentUssClassName ( ModelPrimitiveType string string string String )
            value.HScrollerUssClassName                     = GetString(new IntPtr(p + 0x060)); // 0x60 HScrollerUssClassName       ( ModelPrimitiveType string string string String )
            value.VScrollerUssClassName                     = GetString(new IntPtr(p + 0x068)); // 0x68 VScrollerUssClassName       ( ModelPrimitiveType string string string String )
            value.HorizontalVariantUssClassName             = GetString(new IntPtr(p + 0x070)); // 0x70 HorizontalVariantUssClassName ( ModelPrimitiveType string string string String )
            value.VerticalVariantUssClassName               = GetString(new IntPtr(p + 0x078)); // 0x78 VerticalVariantUssClassName ( ModelPrimitiveType string string string String )
            value.VerticalHorizontalVariantUssClassName     = GetString(new IntPtr(p + 0x080)); // 0x80 VerticalHorizontalVariantUssClassName ( ModelPrimitiveType string string string String )
            value.ScrollVariantUssClassName                 = GetString(new IntPtr(p + 0x088)); // 0x88 ScrollVariantUssClassName   ( ModelPrimitiveType string string string String )
            value.M_Mode                                    = (ScrollViewMode)GetInt32(new IntPtr(p + 0x438)); // 0x438 M_Mode                      ( ModelEnumType ScrollViewMode ScrollViewMode ScrollViewMode Int32 )
            value.M_ScheduledLayoutPassResetItem            = GetObject<IVisualElementScheduledItem>(new IntPtr(p + 0x440), ReversePrism.DataModels.IVisualElementScheduledItem.FromPointer); // 0x440 M_ScheduledLayoutPassResetItem ( ModelClassType IVisualElementScheduledItem IVisualElementScheduledItem IVisualElementScheduledItem Pointer )
            value.M_ScrollingPointerId                      = GetInt32(new IntPtr(p + 0x448)); // 0x448 M_ScrollingPointerId        ( ModelPrimitiveType int int int Int32 )
            value.M_StartPosition                           = (Vector2)GetInt32(new IntPtr(p + 0x44C)); // 0x44C M_StartPosition             ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_PointerStartPosition                    = (Vector2)GetInt32(new IntPtr(p + 0x454)); // 0x454 M_PointerStartPosition      ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_Velocity                                = (Vector2)GetInt32(new IntPtr(p + 0x45C)); // 0x45C M_Velocity                  ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_SpringBackVelocity                      = (Vector2)GetInt32(new IntPtr(p + 0x464)); // 0x464 M_SpringBackVelocity        ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_LowBounds                               = (Vector2)GetInt32(new IntPtr(p + 0x46C)); // 0x46C M_LowBounds                 ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_HighBounds                              = (Vector2)GetInt32(new IntPtr(p + 0x474)); // 0x474 M_HighBounds                ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_LastVelocityLerpTime                    = GetSingle(new IntPtr(p + 0x47C)); // 0x47C M_LastVelocityLerpTime      ( ModelPrimitiveType float float float Single )
            value.M_StartedMoving                           = GetBool(new IntPtr(p + 0x480)); // 0x480 M_StartedMoving             ( ModelPrimitiveType bool bool bool Bool )
            value.M_TouchStoppedVelocity                    = GetBool(new IntPtr(p + 0x481)); // 0x481 M_TouchStoppedVelocity      ( ModelPrimitiveType bool bool bool Bool )
            value.M_CapturedTarget                          = GetObject<VisualElement>(new IntPtr(p + 0x488), ReversePrism.DataModels.VisualElement.FromPointer); // 0x488 M_CapturedTarget            ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_PostPointerUpAnimation                  = GetObject<IVisualElementScheduledItem>(new IntPtr(p + 0x4A0), ReversePrism.DataModels.IVisualElementScheduledItem.FromPointer); // 0x4A0 M_PostPointerUpAnimation    ( ModelClassType IVisualElementScheduledItem IVisualElementScheduledItem IVisualElementScheduledItem Pointer )

            return value;
        }
    }
}
