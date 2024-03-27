using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ScrollDirection                          0001865DD1E0 ModelEnumType ScrollDirectionEnum ScrollDirectionEnum ScrollDirectionEnum Int32
    // 024 Spacing                                  000186666050 ModelPrimitiveType float float float Single
    // 028 Padding                                  000186651AE0 ModelClassType RectOffset RectOffset RectOffset Pointer
    // 030 Loop                                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 031 LoopWhileDragging                        000186595960 ModelPrimitiveType bool bool bool Bool
    // 034 MaxVelocity                              000186666050 ModelPrimitiveType float float float Single
    // 038 ScrollbarVisibility                      0001865DD8C0 ModelEnumType ScrollbarVisibilityEnum ScrollbarVisibilityEnum ScrollbarVisibilityEnum Int32
    // 03C Snapping                                 000186595960 ModelPrimitiveType bool bool bool Bool
    // 040 SnapVelocityThreshold                    000186666050 ModelPrimitiveType float float float Single
    // 044 SnapWatchOffset                          000186666050 ModelPrimitiveType float float float Single
    // 048 SnapJumpToOffset                         000186666050 ModelPrimitiveType float float float Single
    // 04C SnapCellCenterOffset                     000186666050 ModelPrimitiveType float float float Single
    // 050 SnapUseCellSpacing                       000186595960 ModelPrimitiveType bool bool bool Bool
    // 054 SnapTweenType                            0001865DDFC0 ModelEnumType TweenType TweenType TweenType Int32
    // 058 SnapTweenTime                            000186666050 ModelPrimitiveType float float float Single
    // 05C SnapWhileDragging                        000186595960 ModelPrimitiveType bool bool bool Bool
    // 060 LookAheadBefore                          0001866656B0 ModelPrimitiveType float float float Single
    // 064 LookAheadAfter                           0001866656B0 ModelPrimitiveType float float float Single
    // 068 CellViewVisibilityChanged                000186552C90 ModelClassType CellViewVisibilityChangedDelegate CellViewVisibilityChangedDelegate CellViewVisibilityChangedDelegate Pointer
    // 070 CellViewWillRecycle                      000186553170 ModelClassType CellViewWillRecycleDelegate CellViewWillRecycleDelegate CellViewWillRecycleDelegate Pointer
    // 078 ScrollerScrolled                         0001866FBA80 ModelClassType ScrollerScrolledDelegate ScrollerScrolledDelegate ScrollerScrolledDelegate Pointer
    // 080 ScrollerSnapped                          0001866FC420 ModelClassType ScrollerSnappedDelegate ScrollerSnappedDelegate ScrollerSnappedDelegate Pointer
    // 088 ScrollerScrollingChanged                 0001866FBF20 ModelClassType ScrollerScrollingChangedDelegate ScrollerScrollingChangedDelegate ScrollerScrollingChangedDelegate Pointer
    // 090 ScrollerTweeningChanged                  0001866FC900 ModelClassType ScrollerTweeningChangedDelegate ScrollerTweeningChangedDelegate ScrollerTweeningChangedDelegate Pointer
    // 098 CellViewInstantiated                     0001865522A0 ModelClassType CellViewInstantiated CellViewInstantiated CellViewInstantiated Pointer
    // 0A0 CellViewReused                           000186552780 ModelClassType CellViewReused CellViewReused CellViewReused Pointer
    // 0A8 IsScrolling                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0A9 IsTweening                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0AA Initialized                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0AB UpdateSpacing                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0B0 ScrollRect                               0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 0B8 ScrollRectTransform                      000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 0C0 Scrollbar                                0001866FA460 ModelClassType Scrollbar Scrollbar Scrollbar Pointer
    // 0C8 Container                                000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 0D0 LayoutGroup                              0001866D6100 ModelClassType HorizontalOrVerticalLayoutGroup HorizontalOrVerticalLayoutGroup HorizontalOrVerticalLayoutGroup Pointer
    // 0D8 Delegate                                 00018675E900 ModelClassType IEnhancedScrollerDelegate IEnhancedScrollerDelegate IEnhancedScrollerDelegate Pointer
    // 0E0 ReloadData                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0E1 RefreshActive                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0E8 _recycledCellViews                       SmallList`1<EnhancedScrollerCellView> IL2CPP_TYPE_GENERICINST
    // 0F0 FirstPadder                              00018650C2A0 ModelClassType LayoutElement LayoutElement LayoutElement Pointer
    // 0F8 LastPadder                               00018650C2A0 ModelClassType LayoutElement LayoutElement LayoutElement Pointer
    // 100 RecycledCellViewContainer                000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 108 _cellViewSizeArray                       SmallList`1<float> IL2CPP_TYPE_GENERICINST
    // 110 _cellViewOffsetArray                     SmallList`1<float> IL2CPP_TYPE_GENERICINST
    // 118 ScrollPosition                           000186666050 ModelPrimitiveType float float float Single
    // 120 _activeCellViews                         SmallList`1<EnhancedScrollerCellView> IL2CPP_TYPE_GENERICINST
    // 128 ActiveCellViewsStartIndex                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 12C ActiveCellViewsEndIndex                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 130 LoopFirstCellIndex                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 134 LoopLastCellIndex                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 138 LoopFirstScrollPosition                  0001866656B0 ModelPrimitiveType float float float Single
    // 13C LoopLastScrollPosition                   0001866656B0 ModelPrimitiveType float float float Single
    // 140 LoopFirstJumpTrigger                     0001866656B0 ModelPrimitiveType float float float Single
    // 144 LoopLastJumpTrigger                      0001866656B0 ModelPrimitiveType float float float Single
    // 148 LastScrollRectSize                       0001866656B0 ModelPrimitiveType float float float Single
    // 14C LastLoop                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 150 SnapCellViewIndex                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 154 SnapDataIndex                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 158 SnapJumping                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 159 SnapInertia                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 15C LastScrollbarVisibility                  0001865DD8C0 ModelEnumType ScrollbarVisibilityEnum ScrollbarVisibilityEnum ScrollbarVisibilityEnum Int32
    // 160 SingleLoopGroupSize                      0001866656B0 ModelPrimitiveType float float float Single
    // 164 SnapBeforeDrag                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 165 LoopBeforeDrag                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 166 IgnoreLoopJump                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 168 DragFingerCount                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 16C TweenTimeLeft                            0001866656B0 ModelPrimitiveType float float float Single
    public partial class EnhancedScroller
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
            var value   = new EnhancedScroller();

            value.ScrollDirection                           = (ScrollDirectionEnum)GetInt32(new IntPtr(p + 0x020)); // 027004F5E180 0x20 ScrollDirection             ( 0001865DD1E0 ModelEnumType ScrollDirectionEnum ScrollDirectionEnum ScrollDirectionEnum Int32 )
            value.Spacing                                   = GetSingle(new IntPtr(p + 0x024)); // 027004F5E1A0 0x24 Spacing                     ( 000186666050 ModelPrimitiveType float float float Single )
            value.Padding                                   = GetObject<RectOffset>(new IntPtr(p + 0x028), ReversePrism.DataModels.RectOffset.FromPointer); // 027004F5E1C0 0x28 Padding                     ( 000186651AE0 ModelClassType RectOffset RectOffset RectOffset Pointer )
            value.Loop                                      = GetBool(new IntPtr(p + 0x030)); // 027004F5E1E0 0x30 Loop                        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.LoopWhileDragging                         = GetBool(new IntPtr(p + 0x031)); // 027004F5E200 0x31 LoopWhileDragging           ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.MaxVelocity                               = GetSingle(new IntPtr(p + 0x034)); // 027004F5E220 0x34 MaxVelocity                 ( 000186666050 ModelPrimitiveType float float float Single )
            value.ScrollbarVisibility                       = (ScrollbarVisibilityEnum)GetInt32(new IntPtr(p + 0x038)); // 027004F5E240 0x38 ScrollbarVisibility         ( 0001865DD8C0 ModelEnumType ScrollbarVisibilityEnum ScrollbarVisibilityEnum ScrollbarVisibilityEnum Int32 )
            value.Snapping                                  = GetBool(new IntPtr(p + 0x03C)); // 027004F5E260 0x3C Snapping                    ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.SnapVelocityThreshold                     = GetSingle(new IntPtr(p + 0x040)); // 027004F5E280 0x40 SnapVelocityThreshold       ( 000186666050 ModelPrimitiveType float float float Single )
            value.SnapWatchOffset                           = GetSingle(new IntPtr(p + 0x044)); // 027004F5E2A0 0x44 SnapWatchOffset             ( 000186666050 ModelPrimitiveType float float float Single )
            value.SnapJumpToOffset                          = GetSingle(new IntPtr(p + 0x048)); // 027004F5E2C0 0x48 SnapJumpToOffset            ( 000186666050 ModelPrimitiveType float float float Single )
            value.SnapCellCenterOffset                      = GetSingle(new IntPtr(p + 0x04C)); // 027004F5E2E0 0x4C SnapCellCenterOffset        ( 000186666050 ModelPrimitiveType float float float Single )
            value.SnapUseCellSpacing                        = GetBool(new IntPtr(p + 0x050)); // 027004F5E300 0x50 SnapUseCellSpacing          ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.SnapTweenType                             = (TweenType)GetInt32(new IntPtr(p + 0x054)); // 027004F5E320 0x54 SnapTweenType               ( 0001865DDFC0 ModelEnumType TweenType TweenType TweenType Int32 )
            value.SnapTweenTime                             = GetSingle(new IntPtr(p + 0x058)); // 027004F5E340 0x58 SnapTweenTime               ( 000186666050 ModelPrimitiveType float float float Single )
            value.SnapWhileDragging                         = GetBool(new IntPtr(p + 0x05C)); // 027004F5E360 0x5C SnapWhileDragging           ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.LookAheadBefore                           = GetSingle(new IntPtr(p + 0x060)); // 027004F5E380 0x60 LookAheadBefore             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.LookAheadAfter                            = GetSingle(new IntPtr(p + 0x064)); // 027004F5E3A0 0x64 LookAheadAfter              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CellViewVisibilityChanged                 = GetObject<CellViewVisibilityChangedDelegate>(new IntPtr(p + 0x068), ReversePrism.DataModels.CellViewVisibilityChangedDelegate.FromPointer); // 027004F5E3C0 0x68 CellViewVisibilityChanged   ( 000186552C90 ModelClassType CellViewVisibilityChangedDelegate CellViewVisibilityChangedDelegate CellViewVisibilityChangedDelegate Pointer )
            value.CellViewWillRecycle                       = GetObject<CellViewWillRecycleDelegate>(new IntPtr(p + 0x070), ReversePrism.DataModels.CellViewWillRecycleDelegate.FromPointer); // 027004F5E3E0 0x70 CellViewWillRecycle         ( 000186553170 ModelClassType CellViewWillRecycleDelegate CellViewWillRecycleDelegate CellViewWillRecycleDelegate Pointer )
            value.ScrollerScrolled                          = GetObject<ScrollerScrolledDelegate>(new IntPtr(p + 0x078), ReversePrism.DataModels.ScrollerScrolledDelegate.FromPointer); // 027004F5E400 0x78 ScrollerScrolled            ( 0001866FBA80 ModelClassType ScrollerScrolledDelegate ScrollerScrolledDelegate ScrollerScrolledDelegate Pointer )
            value.ScrollerSnapped                           = GetObject<ScrollerSnappedDelegate>(new IntPtr(p + 0x080), ReversePrism.DataModels.ScrollerSnappedDelegate.FromPointer); // 027004F5E420 0x80 ScrollerSnapped             ( 0001866FC420 ModelClassType ScrollerSnappedDelegate ScrollerSnappedDelegate ScrollerSnappedDelegate Pointer )
            value.ScrollerScrollingChanged                  = GetObject<ScrollerScrollingChangedDelegate>(new IntPtr(p + 0x088), ReversePrism.DataModels.ScrollerScrollingChangedDelegate.FromPointer); // 027004F5E440 0x88 ScrollerScrollingChanged    ( 0001866FBF20 ModelClassType ScrollerScrollingChangedDelegate ScrollerScrollingChangedDelegate ScrollerScrollingChangedDelegate Pointer )
            value.ScrollerTweeningChanged                   = GetObject<ScrollerTweeningChangedDelegate>(new IntPtr(p + 0x090), ReversePrism.DataModels.ScrollerTweeningChangedDelegate.FromPointer); // 027004F5E460 0x90 ScrollerTweeningChanged     ( 0001866FC900 ModelClassType ScrollerTweeningChangedDelegate ScrollerTweeningChangedDelegate ScrollerTweeningChangedDelegate Pointer )
            value.CellViewInstantiated                      = GetObject<CellViewInstantiated>(new IntPtr(p + 0x098), ReversePrism.DataModels.CellViewInstantiated.FromPointer); // 027004F5E480 0x98 CellViewInstantiated        ( 0001865522A0 ModelClassType CellViewInstantiated CellViewInstantiated CellViewInstantiated Pointer )
            value.CellViewReused                            = GetObject<CellViewReused>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.CellViewReused.FromPointer); // 027004F5E4A0 0xA0 CellViewReused              ( 000186552780 ModelClassType CellViewReused CellViewReused CellViewReused Pointer )
            value.IsScrolling                               = GetBool(new IntPtr(p + 0x0A8)); // 027004F5E4C0 0xA8 IsScrolling                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsTweening                                = GetBool(new IntPtr(p + 0x0A9)); // 027004F5E4E0 0xA9 IsTweening                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Initialized                               = GetBool(new IntPtr(p + 0x0AA)); // 027004F5E500 0xAA Initialized                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UpdateSpacing                             = GetBool(new IntPtr(p + 0x0AB)); // 027004F5E520 0xAB UpdateSpacing               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ScrollRect                                = GetObject<ScrollRect>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.ScrollRect.FromPointer); // 027004F5E540 0xB0 ScrollRect                  ( 0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.ScrollRectTransform                       = GetObject<RectTransform>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.RectTransform.FromPointer); // 027004F5E560 0xB8 ScrollRectTransform         ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.Scrollbar                                 = GetObject<Scrollbar>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.Scrollbar.FromPointer); // 027004F5E580 0xC0 Scrollbar                   ( 0001866FA460 ModelClassType Scrollbar Scrollbar Scrollbar Pointer )
            value.Container                                 = GetObject<RectTransform>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.RectTransform.FromPointer); // 027004F5E5A0 0xC8 Container                   ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.LayoutGroup                               = GetObject<HorizontalOrVerticalLayoutGroup>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.HorizontalOrVerticalLayoutGroup.FromPointer); // 027004F5E5C0 0xD0 LayoutGroup                 ( 0001866D6100 ModelClassType HorizontalOrVerticalLayoutGroup HorizontalOrVerticalLayoutGroup HorizontalOrVerticalLayoutGroup Pointer )
            value.Delegate                                  = GetObject<IEnhancedScrollerDelegate>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.IEnhancedScrollerDelegate.FromPointer); // 027004F5E5E0 0xD8 Delegate                    ( 00018675E900 ModelClassType IEnhancedScrollerDelegate IEnhancedScrollerDelegate IEnhancedScrollerDelegate Pointer )
            value.ReloadData                                = GetBool(new IntPtr(p + 0x0E0)); // 027004F5E600 0xE0 ReloadData                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.RefreshActive                             = GetBool(new IntPtr(p + 0x0E1)); // 027004F5E620 0xE1 RefreshActive               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.FirstPadder                               = GetObject<LayoutElement>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.LayoutElement.FromPointer); // 027004F5E660 0xF0 FirstPadder                 ( 00018650C2A0 ModelClassType LayoutElement LayoutElement LayoutElement Pointer )
            value.LastPadder                                = GetObject<LayoutElement>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.LayoutElement.FromPointer); // 027004F5E680 0xF8 LastPadder                  ( 00018650C2A0 ModelClassType LayoutElement LayoutElement LayoutElement Pointer )
            value.RecycledCellViewContainer                 = GetObject<RectTransform>(new IntPtr(p + 0x100), ReversePrism.DataModels.RectTransform.FromPointer); // 027004F5E6A0 0x100 RecycledCellViewContainer   ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.ScrollPosition                            = GetSingle(new IntPtr(p + 0x118)); // 027004F5E700 0x118 ScrollPosition              ( 000186666050 ModelPrimitiveType float float float Single )
            value.ActiveCellViewsStartIndex                 = GetInt32(new IntPtr(p + 0x128)); // 027004F5E740 0x128 ActiveCellViewsStartIndex   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ActiveCellViewsEndIndex                   = GetInt32(new IntPtr(p + 0x12C)); // 027004F5E760 0x12C ActiveCellViewsEndIndex     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LoopFirstCellIndex                        = GetInt32(new IntPtr(p + 0x130)); // 027004F5E780 0x130 LoopFirstCellIndex          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LoopLastCellIndex                         = GetInt32(new IntPtr(p + 0x134)); // 027004F5E7A0 0x134 LoopLastCellIndex           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LoopFirstScrollPosition                   = GetSingle(new IntPtr(p + 0x138)); // 027004F5E7C0 0x138 LoopFirstScrollPosition     ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.LoopLastScrollPosition                    = GetSingle(new IntPtr(p + 0x13C)); // 027004F5E7E0 0x13C LoopLastScrollPosition      ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.LoopFirstJumpTrigger                      = GetSingle(new IntPtr(p + 0x140)); // 027004F5E800 0x140 LoopFirstJumpTrigger        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.LoopLastJumpTrigger                       = GetSingle(new IntPtr(p + 0x144)); // 027004F5E820 0x144 LoopLastJumpTrigger         ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.LastScrollRectSize                        = GetSingle(new IntPtr(p + 0x148)); // 027004F5E840 0x148 LastScrollRectSize          ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.LastLoop                                  = GetBool(new IntPtr(p + 0x14C)); // 027004F5E860 0x14C LastLoop                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SnapCellViewIndex                         = GetInt32(new IntPtr(p + 0x150)); // 027004F5E880 0x150 SnapCellViewIndex           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SnapDataIndex                             = GetInt32(new IntPtr(p + 0x154)); // 027004F5E8A0 0x154 SnapDataIndex               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SnapJumping                               = GetBool(new IntPtr(p + 0x158)); // 027004F5E8C0 0x158 SnapJumping                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SnapInertia                               = GetBool(new IntPtr(p + 0x159)); // 027004F5E8E0 0x159 SnapInertia                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.LastScrollbarVisibility                   = (ScrollbarVisibilityEnum)GetInt32(new IntPtr(p + 0x15C)); // 027004F5E900 0x15C LastScrollbarVisibility     ( 0001865DD8C0 ModelEnumType ScrollbarVisibilityEnum ScrollbarVisibilityEnum ScrollbarVisibilityEnum Int32 )
            value.SingleLoopGroupSize                       = GetSingle(new IntPtr(p + 0x160)); // 027004F5E920 0x160 SingleLoopGroupSize         ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.SnapBeforeDrag                            = GetBool(new IntPtr(p + 0x164)); // 027004F5E940 0x164 SnapBeforeDrag              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.LoopBeforeDrag                            = GetBool(new IntPtr(p + 0x165)); // 027004F5E960 0x165 LoopBeforeDrag              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IgnoreLoopJump                            = GetBool(new IntPtr(p + 0x166)); // 027004F5E980 0x166 IgnoreLoopJump              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DragFingerCount                           = GetInt32(new IntPtr(p + 0x168)); // 027004F5E9A0 0x168 DragFingerCount             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TweenTimeLeft                             = GetSingle(new IntPtr(p + 0x16C)); // 027004F5E9C0 0x16C TweenTimeLeft               ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
