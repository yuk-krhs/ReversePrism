using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 3C8 M_FirstLayoutPass                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 3CC M_HorizontalScrollerVisibility           0001866FCDA0 ModelEnumType ScrollerVisibility ScrollerVisibility ScrollerVisibility Int32
    // 3D0 M_VerticalScrollerVisibility             0001866FCDA0 ModelEnumType ScrollerVisibility ScrollerVisibility ScrollerVisibility Int32
    // 3D8 M_AttachedRootVisualContainer            0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 3E0 M_SingleLineHeight                       0001866656B0 ModelPrimitiveType float float float Single
    // 3E4 M_MouseWheelScrollSizeIsInline           000186595210 ModelPrimitiveType bool bool bool Bool
    // 3E8 M_HorizontalPageSize                     0001866656B0 ModelPrimitiveType float float float Single
    // 3EC M_VerticalPageSize                       0001866656B0 ModelPrimitiveType float float float Single
    // 3F0 M_MouseWheelScrollSize                   0001866656B0 ModelPrimitiveType float float float Single
    // 000 k_DefaultScrollDecelerationRate          float IL2CPP_TYPE_R4
    // 3F4 M_ScrollDecelerationRate                 0001866656B0 ModelPrimitiveType float float float Single
    // 004 k_DefaultElasticity                      float IL2CPP_TYPE_R4
    // 3F8 M_Elasticity                             0001866656B0 ModelPrimitiveType float float float Single
    // 3FC M_TouchScrollBehavior                    00018673B170 ModelEnumType TouchScrollBehavior TouchScrollBehavior TouchScrollBehavior Int32
    // 400 M_NestedInteractionKind                  00018673AA00 ModelEnumType NestedInteractionKind NestedInteractionKind NestedInteractionKind Int32
    // 008 k_DefaultElasticAnimationInterval        long IL2CPP_TYPE_I8
    // 408 M_ElasticAnimationIntervalMs             0001865F7700 ModelPrimitiveType long long long Int64
    // 410 ContentViewport                          0001866B34A0 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 418 HorizontalScroller                       0001866FB5C0 ModelClassType Scroller Scroller Scroller Pointer
    // 420 VerticalScroller                         0001866FB5C0 ModelClassType Scroller Scroller Scroller Pointer
    // 428 M_ContentContainer                       0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 430 M_ContentAndVerticalScrollContainer      0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 010 UssClassName                             000186674040 ModelPrimitiveType string string string String
    // 018 ViewportUssClassName                     000186674040 ModelPrimitiveType string string string String
    // 020 HorizontalVariantViewportUssClassName    000186674040 ModelPrimitiveType string string string String
    // 028 VerticalVariantViewportUssClassName      000186674040 ModelPrimitiveType string string string String
    // 030 VerticalHorizontalVariantViewportUssClassName 000186674040 ModelPrimitiveType string string string String
    // 038 ContentAndVerticalScrollUssClassName     000186674040 ModelPrimitiveType string string string String
    // 040 ContentUssClassName                      000186674040 ModelPrimitiveType string string string String
    // 048 HorizontalVariantContentUssClassName     000186674040 ModelPrimitiveType string string string String
    // 050 VerticalVariantContentUssClassName       000186674040 ModelPrimitiveType string string string String
    // 058 VerticalHorizontalVariantContentUssClassName 000186674040 ModelPrimitiveType string string string String
    // 060 HScrollerUssClassName                    000186674040 ModelPrimitiveType string string string String
    // 068 VScrollerUssClassName                    000186674040 ModelPrimitiveType string string string String
    // 070 HorizontalVariantUssClassName            000186674040 ModelPrimitiveType string string string String
    // 078 VerticalVariantUssClassName              000186674040 ModelPrimitiveType string string string String
    // 080 VerticalHorizontalVariantUssClassName    000186674040 ModelPrimitiveType string string string String
    // 088 ScrollVariantUssClassName                000186674040 ModelPrimitiveType string string string String
    // 438 M_Mode                                   0001866F9AA0 ModelEnumType ScrollViewMode ScrollViewMode ScrollViewMode Int32
    // 440 M_ScheduledLayoutPassResetItem           000186697790 ModelClassType IVisualElementScheduledItem IVisualElementScheduledItem IVisualElementScheduledItem Pointer
    // 448 M_ScrollingPointerId                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 44C M_StartPosition                          0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 454 M_PointerStartPosition                   0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 45C M_Velocity                               0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 464 M_SpringBackVelocity                     0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 46C M_LowBounds                              0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 474 M_HighBounds                             0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 47C M_LastVelocityLerpTime                   0001866656B0 ModelPrimitiveType float float float Single
    // 480 M_StartedMoving                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 481 M_TouchStoppedVelocity                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 488 M_CapturedTarget                         0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 490 m_CapturedTargetPointerMoveCallback      EventCallback`1<PointerMoveEvent> IL2CPP_TYPE_GENERICINST
    // 498 m_CapturedTargetPointerUpCallback        EventCallback`1<PointerUpEvent> IL2CPP_TYPE_GENERICINST
    // 4A0 M_PostPointerUpAnimation                 0001866979A0 ModelClassType IVisualElementScheduledItem IVisualElementScheduledItem IVisualElementScheduledItem Pointer
    public partial class ScrollView
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
            var value   = new ScrollView();

            value.M_FirstLayoutPass                         = GetInt32(new IntPtr(p + 0x3C8)); // 027006737970 0x3C8 M_FirstLayoutPass           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_HorizontalScrollerVisibility            = (ScrollerVisibility)GetInt32(new IntPtr(p + 0x3CC)); // 027006737990 0x3CC M_HorizontalScrollerVisibility ( 0001866FCDA0 ModelEnumType ScrollerVisibility ScrollerVisibility ScrollerVisibility Int32 )
            value.M_VerticalScrollerVisibility              = (ScrollerVisibility)GetInt32(new IntPtr(p + 0x3D0)); // 0270067379B0 0x3D0 M_VerticalScrollerVisibility ( 0001866FCDA0 ModelEnumType ScrollerVisibility ScrollerVisibility ScrollerVisibility Int32 )
            value.M_AttachedRootVisualContainer             = GetObject<VisualElement>(new IntPtr(p + 0x3D8), ReversePrism.DataModels.VisualElement.FromPointer); // 0270067379D0 0x3D8 M_AttachedRootVisualContainer ( 0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_SingleLineHeight                        = GetSingle(new IntPtr(p + 0x3E0)); // 0270067379F0 0x3E0 M_SingleLineHeight          ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_MouseWheelScrollSizeIsInline            = GetBool(new IntPtr(p + 0x3E4)); // 027006737A10 0x3E4 M_MouseWheelScrollSizeIsInline ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.M_HorizontalPageSize                      = GetSingle(new IntPtr(p + 0x3E8)); // 027006737A30 0x3E8 M_HorizontalPageSize        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_VerticalPageSize                        = GetSingle(new IntPtr(p + 0x3EC)); // 027006737A50 0x3EC M_VerticalPageSize          ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_MouseWheelScrollSize                    = GetSingle(new IntPtr(p + 0x3F0)); // 027006737A70 0x3F0 M_MouseWheelScrollSize      ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_ScrollDecelerationRate                  = GetSingle(new IntPtr(p + 0x3F4)); // 027006737AB0 0x3F4 M_ScrollDecelerationRate    ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_Elasticity                              = GetSingle(new IntPtr(p + 0x3F8)); // 027006737AF0 0x3F8 M_Elasticity                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_TouchScrollBehavior                     = (TouchScrollBehavior)GetInt32(new IntPtr(p + 0x3FC)); // 027006737B10 0x3FC M_TouchScrollBehavior       ( 00018673B170 ModelEnumType TouchScrollBehavior TouchScrollBehavior TouchScrollBehavior Int32 )
            value.M_NestedInteractionKind                   = (NestedInteractionKind)GetInt32(new IntPtr(p + 0x400)); // 027006737B30 0x400 M_NestedInteractionKind     ( 00018673AA00 ModelEnumType NestedInteractionKind NestedInteractionKind NestedInteractionKind Int32 )
            value.M_ElasticAnimationIntervalMs              = GetInt64(new IntPtr(p + 0x408)); // 027006737B70 0x408 M_ElasticAnimationIntervalMs ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.ContentViewport                           = GetObject<VisualElement>(new IntPtr(p + 0x410), ReversePrism.DataModels.VisualElement.FromPointer); // 027006737B90 0x410 ContentViewport             ( 0001866B34A0 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.HorizontalScroller                        = GetObject<Scroller>(new IntPtr(p + 0x418), ReversePrism.DataModels.Scroller.FromPointer); // 027006737BB0 0x418 HorizontalScroller          ( 0001866FB5C0 ModelClassType Scroller Scroller Scroller Pointer )
            value.VerticalScroller                          = GetObject<Scroller>(new IntPtr(p + 0x420), ReversePrism.DataModels.Scroller.FromPointer); // 027006737BD0 0x420 VerticalScroller            ( 0001866FB5C0 ModelClassType Scroller Scroller Scroller Pointer )
            value.M_ContentContainer                        = GetObject<VisualElement>(new IntPtr(p + 0x428), ReversePrism.DataModels.VisualElement.FromPointer); // 027006737BF0 0x428 M_ContentContainer          ( 0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_ContentAndVerticalScrollContainer       = GetObject<VisualElement>(new IntPtr(p + 0x430), ReversePrism.DataModels.VisualElement.FromPointer); // 027006737C10 0x430 M_ContentAndVerticalScrollContainer ( 0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.UssClassName                              = GetString(new IntPtr(p + 0x010)); // 027006737C30 0x10 UssClassName                ( 000186674040 ModelPrimitiveType string string string String )
            value.ViewportUssClassName                      = GetString(new IntPtr(p + 0x018)); // 027006737C50 0x18 ViewportUssClassName        ( 000186674040 ModelPrimitiveType string string string String )
            value.HorizontalVariantViewportUssClassName     = GetString(new IntPtr(p + 0x020)); // 027006737C70 0x20 HorizontalVariantViewportUssClassName ( 000186674040 ModelPrimitiveType string string string String )
            value.VerticalVariantViewportUssClassName       = GetString(new IntPtr(p + 0x028)); // 027006737C90 0x28 VerticalVariantViewportUssClassName ( 000186674040 ModelPrimitiveType string string string String )
            value.VerticalHorizontalVariantViewportUssClassName = GetString(new IntPtr(p + 0x030)); // 027006737CB0 0x30 VerticalHorizontalVariantViewportUssClassName ( 000186674040 ModelPrimitiveType string string string String )
            value.ContentAndVerticalScrollUssClassName      = GetString(new IntPtr(p + 0x038)); // 027006737CD0 0x38 ContentAndVerticalScrollUssClassName ( 000186674040 ModelPrimitiveType string string string String )
            value.ContentUssClassName                       = GetString(new IntPtr(p + 0x040)); // 027006737CF0 0x40 ContentUssClassName         ( 000186674040 ModelPrimitiveType string string string String )
            value.HorizontalVariantContentUssClassName      = GetString(new IntPtr(p + 0x048)); // 027006737D10 0x48 HorizontalVariantContentUssClassName ( 000186674040 ModelPrimitiveType string string string String )
            value.VerticalVariantContentUssClassName        = GetString(new IntPtr(p + 0x050)); // 027006737D30 0x50 VerticalVariantContentUssClassName ( 000186674040 ModelPrimitiveType string string string String )
            value.VerticalHorizontalVariantContentUssClassName = GetString(new IntPtr(p + 0x058)); // 027006737D50 0x58 VerticalHorizontalVariantContentUssClassName ( 000186674040 ModelPrimitiveType string string string String )
            value.HScrollerUssClassName                     = GetString(new IntPtr(p + 0x060)); // 027006737D70 0x60 HScrollerUssClassName       ( 000186674040 ModelPrimitiveType string string string String )
            value.VScrollerUssClassName                     = GetString(new IntPtr(p + 0x068)); // 027006737D90 0x68 VScrollerUssClassName       ( 000186674040 ModelPrimitiveType string string string String )
            value.HorizontalVariantUssClassName             = GetString(new IntPtr(p + 0x070)); // 027006737DB0 0x70 HorizontalVariantUssClassName ( 000186674040 ModelPrimitiveType string string string String )
            value.VerticalVariantUssClassName               = GetString(new IntPtr(p + 0x078)); // 027006737DD0 0x78 VerticalVariantUssClassName ( 000186674040 ModelPrimitiveType string string string String )
            value.VerticalHorizontalVariantUssClassName     = GetString(new IntPtr(p + 0x080)); // 027006737DF0 0x80 VerticalHorizontalVariantUssClassName ( 000186674040 ModelPrimitiveType string string string String )
            value.ScrollVariantUssClassName                 = GetString(new IntPtr(p + 0x088)); // 027006737E10 0x88 ScrollVariantUssClassName   ( 000186674040 ModelPrimitiveType string string string String )
            value.M_Mode                                    = (ScrollViewMode)GetInt32(new IntPtr(p + 0x438)); // 027006737E30 0x438 M_Mode                      ( 0001866F9AA0 ModelEnumType ScrollViewMode ScrollViewMode ScrollViewMode Int32 )
            value.M_ScheduledLayoutPassResetItem            = GetObject<IVisualElementScheduledItem>(new IntPtr(p + 0x440), ReversePrism.DataModels.IVisualElementScheduledItem.FromPointer); // 027006737E50 0x440 M_ScheduledLayoutPassResetItem ( 000186697790 ModelClassType IVisualElementScheduledItem IVisualElementScheduledItem IVisualElementScheduledItem Pointer )
            value.M_ScrollingPointerId                      = GetInt32(new IntPtr(p + 0x448)); // 027006737E70 0x448 M_ScrollingPointerId        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_StartPosition                           = (Vector2)GetInt32(new IntPtr(p + 0x44C)); // 027006737E90 0x44C M_StartPosition             ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_PointerStartPosition                    = (Vector2)GetInt32(new IntPtr(p + 0x454)); // 027006737EB0 0x454 M_PointerStartPosition      ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_Velocity                                = (Vector2)GetInt32(new IntPtr(p + 0x45C)); // 027006737ED0 0x45C M_Velocity                  ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_SpringBackVelocity                      = (Vector2)GetInt32(new IntPtr(p + 0x464)); // 027006737EF0 0x464 M_SpringBackVelocity        ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_LowBounds                               = (Vector2)GetInt32(new IntPtr(p + 0x46C)); // 027006737F10 0x46C M_LowBounds                 ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_HighBounds                              = (Vector2)GetInt32(new IntPtr(p + 0x474)); // 027006737F30 0x474 M_HighBounds                ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_LastVelocityLerpTime                    = GetSingle(new IntPtr(p + 0x47C)); // 027006737F50 0x47C M_LastVelocityLerpTime      ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_StartedMoving                           = GetBool(new IntPtr(p + 0x480)); // 027006737F70 0x480 M_StartedMoving             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_TouchStoppedVelocity                    = GetBool(new IntPtr(p + 0x481)); // 027006737F90 0x481 M_TouchStoppedVelocity      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_CapturedTarget                          = GetObject<VisualElement>(new IntPtr(p + 0x488), ReversePrism.DataModels.VisualElement.FromPointer); // 027006737FB0 0x488 M_CapturedTarget            ( 0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_PostPointerUpAnimation                  = GetObject<IVisualElementScheduledItem>(new IntPtr(p + 0x4A0), ReversePrism.DataModels.IVisualElementScheduledItem.FromPointer); // 027006738010 0x4A0 M_PostPointerUpAnimation    ( 0001866979A0 ModelClassType IVisualElementScheduledItem IVisualElementScheduledItem IVisualElementScheduledItem Pointer )

            return value;
        }
    }
}
