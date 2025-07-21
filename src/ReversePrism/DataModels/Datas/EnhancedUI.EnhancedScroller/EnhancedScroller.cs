using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ScrollDirection                          ModelEnumType ScrollDirectionEnum ScrollDirectionEnum ScrollDirectionEnum Int32
    // 024 Spacing                                  ModelPrimitiveType float float float Single
    // 028 Padding                                  ModelClassType RectOffset RectOffset RectOffset Pointer
    // 030 Loop                                     ModelPrimitiveType bool bool bool Bool
    // 031 LoopWhileDragging                        ModelPrimitiveType bool bool bool Bool
    // 034 MaxVelocity                              ModelPrimitiveType float float float Single
    // 038 ScrollbarVisibility                      ModelEnumType ScrollbarVisibilityEnum ScrollbarVisibilityEnum ScrollbarVisibilityEnum Int32
    // 03C Snapping                                 ModelPrimitiveType bool bool bool Bool
    // 040 SnapVelocityThreshold                    ModelPrimitiveType float float float Single
    // 044 SnapWatchOffset                          ModelPrimitiveType float float float Single
    // 048 SnapJumpToOffset                         ModelPrimitiveType float float float Single
    // 04C SnapCellCenterOffset                     ModelPrimitiveType float float float Single
    // 050 SnapUseCellSpacing                       ModelPrimitiveType bool bool bool Bool
    // 054 SnapTweenType                            ModelEnumType TweenType TweenType TweenType Int32
    // 058 SnapTweenTime                            ModelPrimitiveType float float float Single
    // 05C SnapWhileDragging                        ModelPrimitiveType bool bool bool Bool
    // 060 LookAheadBefore                          ModelPrimitiveType float float float Single
    // 064 LookAheadAfter                           ModelPrimitiveType float float float Single
    // 068 CellViewVisibilityChanged                ModelClassType CellViewVisibilityChangedDelegate CellViewVisibilityChangedDelegate CellViewVisibilityChangedDelegate Pointer
    // 070 CellViewWillRecycle                      ModelClassType CellViewWillRecycleDelegate CellViewWillRecycleDelegate CellViewWillRecycleDelegate Pointer
    // 078 ScrollerScrolled                         ModelClassType ScrollerScrolledDelegate ScrollerScrolledDelegate ScrollerScrolledDelegate Pointer
    // 080 ScrollerSnapped                          ModelClassType ScrollerSnappedDelegate ScrollerSnappedDelegate ScrollerSnappedDelegate Pointer
    // 088 ScrollerScrollingChanged                 ModelClassType ScrollerScrollingChangedDelegate ScrollerScrollingChangedDelegate ScrollerScrollingChangedDelegate Pointer
    // 090 ScrollerTweeningChanged                  ModelClassType ScrollerTweeningChangedDelegate ScrollerTweeningChangedDelegate ScrollerTweeningChangedDelegate Pointer
    // 098 CellViewInstantiated                     ModelClassType CellViewInstantiated CellViewInstantiated CellViewInstantiated Pointer
    // 0A0 CellViewReused                           ModelClassType CellViewReused CellViewReused CellViewReused Pointer
    // 0A8 IsScrolling                              ModelPrimitiveType bool bool bool Bool
    // 0A9 IsTweening                               ModelPrimitiveType bool bool bool Bool
    // 0AA Initialized                              ModelPrimitiveType bool bool bool Bool
    // 0AB UpdateSpacing                            ModelPrimitiveType bool bool bool Bool
    // 0B0 ScrollRect                               ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 0B8 ScrollRectTransform                      ModelClassType RectTransform RectTransform RectTransform Pointer
    // 0C0 Scrollbar                                ModelClassType Scrollbar Scrollbar Scrollbar Pointer
    // 0C8 Container                                ModelClassType RectTransform RectTransform RectTransform Pointer
    // 0D0 LayoutGroup                              ModelClassType HorizontalOrVerticalLayoutGroup HorizontalOrVerticalLayoutGroup HorizontalOrVerticalLayoutGroup Pointer
    // 0D8 Delegate                                 ModelClassType IEnhancedScrollerDelegate IEnhancedScrollerDelegate IEnhancedScrollerDelegate Pointer
    // 0E0 ReloadData                               ModelPrimitiveType bool bool bool Bool
    // 0E1 RefreshActive                            ModelPrimitiveType bool bool bool Bool
    // 0E8 _recycledCellViews                       SmallList`1<EnhancedScrollerCellView> IL2CPP_TYPE_GENERICINST
    // 0F0 FirstPadder                              ModelClassType LayoutElement LayoutElement LayoutElement Pointer
    // 0F8 LastPadder                               ModelClassType LayoutElement LayoutElement LayoutElement Pointer
    // 100 RecycledCellViewContainer                ModelClassType RectTransform RectTransform RectTransform Pointer
    // 108 _cellViewSizeArray                       SmallList`1<float> IL2CPP_TYPE_GENERICINST
    // 110 _cellViewOffsetArray                     SmallList`1<float> IL2CPP_TYPE_GENERICINST
    // 118 ScrollPosition                           ModelPrimitiveType float float float Single
    // 120 _activeCellViews                         SmallList`1<EnhancedScrollerCellView> IL2CPP_TYPE_GENERICINST
    // 128 ActiveCellViewsStartIndex                ModelPrimitiveType int int int Int32
    // 12C ActiveCellViewsEndIndex                  ModelPrimitiveType int int int Int32
    // 130 LoopFirstCellIndex                       ModelPrimitiveType int int int Int32
    // 134 LoopLastCellIndex                        ModelPrimitiveType int int int Int32
    // 138 LoopFirstScrollPosition                  ModelPrimitiveType float float float Single
    // 13C LoopLastScrollPosition                   ModelPrimitiveType float float float Single
    // 140 LoopFirstJumpTrigger                     ModelPrimitiveType float float float Single
    // 144 LoopLastJumpTrigger                      ModelPrimitiveType float float float Single
    // 148 LastScrollRectSize                       ModelPrimitiveType float float float Single
    // 14C LastLoop                                 ModelPrimitiveType bool bool bool Bool
    // 150 SnapCellViewIndex                        ModelPrimitiveType int int int Int32
    // 154 SnapDataIndex                            ModelPrimitiveType int int int Int32
    // 158 SnapJumping                              ModelPrimitiveType bool bool bool Bool
    // 159 SnapInertia                              ModelPrimitiveType bool bool bool Bool
    // 15C LastScrollbarVisibility                  ModelEnumType ScrollbarVisibilityEnum ScrollbarVisibilityEnum ScrollbarVisibilityEnum Int32
    // 160 SingleLoopGroupSize                      ModelPrimitiveType float float float Single
    // 164 SnapBeforeDrag                           ModelPrimitiveType bool bool bool Bool
    // 165 LoopBeforeDrag                           ModelPrimitiveType bool bool bool Bool
    // 166 IgnoreLoopJump                           ModelPrimitiveType bool bool bool Bool
    // 168 DragFingerCount                          ModelPrimitiveType int int int Int32
    // 16C TweenTimeLeft                            ModelPrimitiveType float float float Single
    public partial class EnhancedScroller : DataModel
    {
        public ScrollDirectionEnum                      ScrollDirection                         { get; set; }
        public float                                    Spacing                                 { get; set; }
        public RectOffset?                              Padding                                 { get; set; }
        public bool                                     Loop                                    { get; set; }
        public bool                                     LoopWhileDragging                       { get; set; }
        public float                                    MaxVelocity                             { get; set; }
        public ScrollbarVisibilityEnum                  ScrollbarVisibility                     { get; set; }
        public bool                                     Snapping                                { get; set; }
        public float                                    SnapVelocityThreshold                   { get; set; }
        public float                                    SnapWatchOffset                         { get; set; }
        public float                                    SnapJumpToOffset                        { get; set; }
        public float                                    SnapCellCenterOffset                    { get; set; }
        public bool                                     SnapUseCellSpacing                      { get; set; }
        public TweenType                                SnapTweenType                           { get; set; }
        public float                                    SnapTweenTime                           { get; set; }
        public bool                                     SnapWhileDragging                       { get; set; }
        public float                                    LookAheadBefore                         { get; set; }
        public float                                    LookAheadAfter                          { get; set; }
        public CellViewVisibilityChangedDelegate?       CellViewVisibilityChanged               { get; set; }
        public CellViewWillRecycleDelegate?             CellViewWillRecycle                     { get; set; }
        public ScrollerScrolledDelegate?                ScrollerScrolled                        { get; set; }
        public ScrollerSnappedDelegate?                 ScrollerSnapped                         { get; set; }
        public ScrollerScrollingChangedDelegate?        ScrollerScrollingChanged                { get; set; }
        public ScrollerTweeningChangedDelegate?         ScrollerTweeningChanged                 { get; set; }
        public CellViewInstantiated?                    CellViewInstantiated                    { get; set; }
        public CellViewReused?                          CellViewReused                          { get; set; }
        public bool                                     IsScrolling                             { get; set; }
        public bool                                     IsTweening                              { get; set; }
        public bool                                     Initialized                             { get; set; }
        public bool                                     UpdateSpacing                           { get; set; }
        public ScrollRect?                              ScrollRect                              { get; set; }
        public RectTransform?                           ScrollRectTransform                     { get; set; }
        public Scrollbar?                               Scrollbar                               { get; set; }
        public RectTransform?                           Container                               { get; set; }
        public HorizontalOrVerticalLayoutGroup?         LayoutGroup                             { get; set; }
        public IEnhancedScrollerDelegate?               Delegate                                { get; set; }
        public bool                                     ReloadData                              { get; set; }
        public bool                                     RefreshActive                           { get; set; }
        public LayoutElement?                           FirstPadder                             { get; set; }
        public LayoutElement?                           LastPadder                              { get; set; }
        public RectTransform?                           RecycledCellViewContainer               { get; set; }
        public float                                    ScrollPosition                          { get; set; }
        public int                                      ActiveCellViewsStartIndex               { get; set; }
        public int                                      ActiveCellViewsEndIndex                 { get; set; }
        public int                                      LoopFirstCellIndex                      { get; set; }
        public int                                      LoopLastCellIndex                       { get; set; }
        public float                                    LoopFirstScrollPosition                 { get; set; }
        public float                                    LoopLastScrollPosition                  { get; set; }
        public float                                    LoopFirstJumpTrigger                    { get; set; }
        public float                                    LoopLastJumpTrigger                     { get; set; }
        public float                                    LastScrollRectSize                      { get; set; }
        public bool                                     LastLoop                                { get; set; }
        public int                                      SnapCellViewIndex                       { get; set; }
        public int                                      SnapDataIndex                           { get; set; }
        public bool                                     SnapJumping                             { get; set; }
        public bool                                     SnapInertia                             { get; set; }
        public ScrollbarVisibilityEnum                  LastScrollbarVisibility                 { get; set; }
        public float                                    SingleLoopGroupSize                     { get; set; }
        public bool                                     SnapBeforeDrag                          { get; set; }
        public bool                                     LoopBeforeDrag                          { get; set; }
        public bool                                     IgnoreLoopJump                          { get; set; }
        public int                                      DragFingerCount                         { get; set; }
        public float                                    TweenTimeLeft                           { get; set; }

        public static EnhancedScroller? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnhancedScroller() { Pointer= p0 };

            value.ScrollDirection                           = (ScrollDirectionEnum)GetInt32(new IntPtr(p + 0x020)); // 0x20 ScrollDirection             ( ModelEnumType ScrollDirectionEnum ScrollDirectionEnum ScrollDirectionEnum Int32 )
            value.Spacing                                   = GetSingle(new IntPtr(p + 0x024)); // 0x24 Spacing                     ( ModelPrimitiveType float float float Single )
            value.Padding                                   = GetObject<RectOffset>(new IntPtr(p + 0x028), ReversePrism.DataModels.RectOffset.FromPointer); // 0x28 Padding                     ( ModelClassType RectOffset RectOffset RectOffset Pointer )
            value.Loop                                      = GetBool(new IntPtr(p + 0x030)); // 0x30 Loop                        ( ModelPrimitiveType bool bool bool Bool )
            value.LoopWhileDragging                         = GetBool(new IntPtr(p + 0x031)); // 0x31 LoopWhileDragging           ( ModelPrimitiveType bool bool bool Bool )
            value.MaxVelocity                               = GetSingle(new IntPtr(p + 0x034)); // 0x34 MaxVelocity                 ( ModelPrimitiveType float float float Single )
            value.ScrollbarVisibility                       = (ScrollbarVisibilityEnum)GetInt32(new IntPtr(p + 0x038)); // 0x38 ScrollbarVisibility         ( ModelEnumType ScrollbarVisibilityEnum ScrollbarVisibilityEnum ScrollbarVisibilityEnum Int32 )
            value.Snapping                                  = GetBool(new IntPtr(p + 0x03C)); // 0x3C Snapping                    ( ModelPrimitiveType bool bool bool Bool )
            value.SnapVelocityThreshold                     = GetSingle(new IntPtr(p + 0x040)); // 0x40 SnapVelocityThreshold       ( ModelPrimitiveType float float float Single )
            value.SnapWatchOffset                           = GetSingle(new IntPtr(p + 0x044)); // 0x44 SnapWatchOffset             ( ModelPrimitiveType float float float Single )
            value.SnapJumpToOffset                          = GetSingle(new IntPtr(p + 0x048)); // 0x48 SnapJumpToOffset            ( ModelPrimitiveType float float float Single )
            value.SnapCellCenterOffset                      = GetSingle(new IntPtr(p + 0x04C)); // 0x4C SnapCellCenterOffset        ( ModelPrimitiveType float float float Single )
            value.SnapUseCellSpacing                        = GetBool(new IntPtr(p + 0x050)); // 0x50 SnapUseCellSpacing          ( ModelPrimitiveType bool bool bool Bool )
            value.SnapTweenType                             = (TweenType)GetInt32(new IntPtr(p + 0x054)); // 0x54 SnapTweenType               ( ModelEnumType TweenType TweenType TweenType Int32 )
            value.SnapTweenTime                             = GetSingle(new IntPtr(p + 0x058)); // 0x58 SnapTweenTime               ( ModelPrimitiveType float float float Single )
            value.SnapWhileDragging                         = GetBool(new IntPtr(p + 0x05C)); // 0x5C SnapWhileDragging           ( ModelPrimitiveType bool bool bool Bool )
            value.LookAheadBefore                           = GetSingle(new IntPtr(p + 0x060)); // 0x60 LookAheadBefore             ( ModelPrimitiveType float float float Single )
            value.LookAheadAfter                            = GetSingle(new IntPtr(p + 0x064)); // 0x64 LookAheadAfter              ( ModelPrimitiveType float float float Single )
            value.CellViewVisibilityChanged                 = GetObject<CellViewVisibilityChangedDelegate>(new IntPtr(p + 0x068), ReversePrism.DataModels.CellViewVisibilityChangedDelegate.FromPointer); // 0x68 CellViewVisibilityChanged   ( ModelClassType CellViewVisibilityChangedDelegate CellViewVisibilityChangedDelegate CellViewVisibilityChangedDelegate Pointer )
            value.CellViewWillRecycle                       = GetObject<CellViewWillRecycleDelegate>(new IntPtr(p + 0x070), ReversePrism.DataModels.CellViewWillRecycleDelegate.FromPointer); // 0x70 CellViewWillRecycle         ( ModelClassType CellViewWillRecycleDelegate CellViewWillRecycleDelegate CellViewWillRecycleDelegate Pointer )
            value.ScrollerScrolled                          = GetObject<ScrollerScrolledDelegate>(new IntPtr(p + 0x078), ReversePrism.DataModels.ScrollerScrolledDelegate.FromPointer); // 0x78 ScrollerScrolled            ( ModelClassType ScrollerScrolledDelegate ScrollerScrolledDelegate ScrollerScrolledDelegate Pointer )
            value.ScrollerSnapped                           = GetObject<ScrollerSnappedDelegate>(new IntPtr(p + 0x080), ReversePrism.DataModels.ScrollerSnappedDelegate.FromPointer); // 0x80 ScrollerSnapped             ( ModelClassType ScrollerSnappedDelegate ScrollerSnappedDelegate ScrollerSnappedDelegate Pointer )
            value.ScrollerScrollingChanged                  = GetObject<ScrollerScrollingChangedDelegate>(new IntPtr(p + 0x088), ReversePrism.DataModels.ScrollerScrollingChangedDelegate.FromPointer); // 0x88 ScrollerScrollingChanged    ( ModelClassType ScrollerScrollingChangedDelegate ScrollerScrollingChangedDelegate ScrollerScrollingChangedDelegate Pointer )
            value.ScrollerTweeningChanged                   = GetObject<ScrollerTweeningChangedDelegate>(new IntPtr(p + 0x090), ReversePrism.DataModels.ScrollerTweeningChangedDelegate.FromPointer); // 0x90 ScrollerTweeningChanged     ( ModelClassType ScrollerTweeningChangedDelegate ScrollerTweeningChangedDelegate ScrollerTweeningChangedDelegate Pointer )
            value.CellViewInstantiated                      = GetObject<CellViewInstantiated>(new IntPtr(p + 0x098), ReversePrism.DataModels.CellViewInstantiated.FromPointer); // 0x98 CellViewInstantiated        ( ModelClassType CellViewInstantiated CellViewInstantiated CellViewInstantiated Pointer )
            value.CellViewReused                            = GetObject<CellViewReused>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.CellViewReused.FromPointer); // 0xA0 CellViewReused              ( ModelClassType CellViewReused CellViewReused CellViewReused Pointer )
            value.IsScrolling                               = GetBool(new IntPtr(p + 0x0A8)); // 0xA8 IsScrolling                 ( ModelPrimitiveType bool bool bool Bool )
            value.IsTweening                                = GetBool(new IntPtr(p + 0x0A9)); // 0xA9 IsTweening                  ( ModelPrimitiveType bool bool bool Bool )
            value.Initialized                               = GetBool(new IntPtr(p + 0x0AA)); // 0xAA Initialized                 ( ModelPrimitiveType bool bool bool Bool )
            value.UpdateSpacing                             = GetBool(new IntPtr(p + 0x0AB)); // 0xAB UpdateSpacing               ( ModelPrimitiveType bool bool bool Bool )
            value.ScrollRect                                = GetObject<ScrollRect>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.ScrollRect.FromPointer); // 0xB0 ScrollRect                  ( ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.ScrollRectTransform                       = GetObject<RectTransform>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.RectTransform.FromPointer); // 0xB8 ScrollRectTransform         ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.Scrollbar                                 = GetObject<Scrollbar>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.Scrollbar.FromPointer); // 0xC0 Scrollbar                   ( ModelClassType Scrollbar Scrollbar Scrollbar Pointer )
            value.Container                                 = GetObject<RectTransform>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.RectTransform.FromPointer); // 0xC8 Container                   ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.LayoutGroup                               = GetObject<HorizontalOrVerticalLayoutGroup>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.HorizontalOrVerticalLayoutGroup.FromPointer); // 0xD0 LayoutGroup                 ( ModelClassType HorizontalOrVerticalLayoutGroup HorizontalOrVerticalLayoutGroup HorizontalOrVerticalLayoutGroup Pointer )
            value.Delegate                                  = GetObject<IEnhancedScrollerDelegate>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.IEnhancedScrollerDelegate.FromPointer); // 0xD8 Delegate                    ( ModelClassType IEnhancedScrollerDelegate IEnhancedScrollerDelegate IEnhancedScrollerDelegate Pointer )
            value.ReloadData                                = GetBool(new IntPtr(p + 0x0E0)); // 0xE0 ReloadData                  ( ModelPrimitiveType bool bool bool Bool )
            value.RefreshActive                             = GetBool(new IntPtr(p + 0x0E1)); // 0xE1 RefreshActive               ( ModelPrimitiveType bool bool bool Bool )
            value.FirstPadder                               = GetObject<LayoutElement>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.LayoutElement.FromPointer); // 0xF0 FirstPadder                 ( ModelClassType LayoutElement LayoutElement LayoutElement Pointer )
            value.LastPadder                                = GetObject<LayoutElement>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.LayoutElement.FromPointer); // 0xF8 LastPadder                  ( ModelClassType LayoutElement LayoutElement LayoutElement Pointer )
            value.RecycledCellViewContainer                 = GetObject<RectTransform>(new IntPtr(p + 0x100), ReversePrism.DataModels.RectTransform.FromPointer); // 0x100 RecycledCellViewContainer   ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.ScrollPosition                            = GetSingle(new IntPtr(p + 0x118)); // 0x118 ScrollPosition              ( ModelPrimitiveType float float float Single )
            value.ActiveCellViewsStartIndex                 = GetInt32(new IntPtr(p + 0x128)); // 0x128 ActiveCellViewsStartIndex   ( ModelPrimitiveType int int int Int32 )
            value.ActiveCellViewsEndIndex                   = GetInt32(new IntPtr(p + 0x12C)); // 0x12C ActiveCellViewsEndIndex     ( ModelPrimitiveType int int int Int32 )
            value.LoopFirstCellIndex                        = GetInt32(new IntPtr(p + 0x130)); // 0x130 LoopFirstCellIndex          ( ModelPrimitiveType int int int Int32 )
            value.LoopLastCellIndex                         = GetInt32(new IntPtr(p + 0x134)); // 0x134 LoopLastCellIndex           ( ModelPrimitiveType int int int Int32 )
            value.LoopFirstScrollPosition                   = GetSingle(new IntPtr(p + 0x138)); // 0x138 LoopFirstScrollPosition     ( ModelPrimitiveType float float float Single )
            value.LoopLastScrollPosition                    = GetSingle(new IntPtr(p + 0x13C)); // 0x13C LoopLastScrollPosition      ( ModelPrimitiveType float float float Single )
            value.LoopFirstJumpTrigger                      = GetSingle(new IntPtr(p + 0x140)); // 0x140 LoopFirstJumpTrigger        ( ModelPrimitiveType float float float Single )
            value.LoopLastJumpTrigger                       = GetSingle(new IntPtr(p + 0x144)); // 0x144 LoopLastJumpTrigger         ( ModelPrimitiveType float float float Single )
            value.LastScrollRectSize                        = GetSingle(new IntPtr(p + 0x148)); // 0x148 LastScrollRectSize          ( ModelPrimitiveType float float float Single )
            value.LastLoop                                  = GetBool(new IntPtr(p + 0x14C)); // 0x14C LastLoop                    ( ModelPrimitiveType bool bool bool Bool )
            value.SnapCellViewIndex                         = GetInt32(new IntPtr(p + 0x150)); // 0x150 SnapCellViewIndex           ( ModelPrimitiveType int int int Int32 )
            value.SnapDataIndex                             = GetInt32(new IntPtr(p + 0x154)); // 0x154 SnapDataIndex               ( ModelPrimitiveType int int int Int32 )
            value.SnapJumping                               = GetBool(new IntPtr(p + 0x158)); // 0x158 SnapJumping                 ( ModelPrimitiveType bool bool bool Bool )
            value.SnapInertia                               = GetBool(new IntPtr(p + 0x159)); // 0x159 SnapInertia                 ( ModelPrimitiveType bool bool bool Bool )
            value.LastScrollbarVisibility                   = (ScrollbarVisibilityEnum)GetInt32(new IntPtr(p + 0x15C)); // 0x15C LastScrollbarVisibility     ( ModelEnumType ScrollbarVisibilityEnum ScrollbarVisibilityEnum ScrollbarVisibilityEnum Int32 )
            value.SingleLoopGroupSize                       = GetSingle(new IntPtr(p + 0x160)); // 0x160 SingleLoopGroupSize         ( ModelPrimitiveType float float float Single )
            value.SnapBeforeDrag                            = GetBool(new IntPtr(p + 0x164)); // 0x164 SnapBeforeDrag              ( ModelPrimitiveType bool bool bool Bool )
            value.LoopBeforeDrag                            = GetBool(new IntPtr(p + 0x165)); // 0x165 LoopBeforeDrag              ( ModelPrimitiveType bool bool bool Bool )
            value.IgnoreLoopJump                            = GetBool(new IntPtr(p + 0x166)); // 0x166 IgnoreLoopJump              ( ModelPrimitiveType bool bool bool Bool )
            value.DragFingerCount                           = GetInt32(new IntPtr(p + 0x168)); // 0x168 DragFingerCount             ( ModelPrimitiveType int int int Int32 )
            value.TweenTimeLeft                             = GetSingle(new IntPtr(p + 0x16C)); // 0x16C TweenTimeLeft               ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
