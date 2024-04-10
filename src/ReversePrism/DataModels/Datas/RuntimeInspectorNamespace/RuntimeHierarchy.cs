using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 M_refreshInterval                        0001866656B0 ModelPrimitiveType float float float Single
    // 034 M_objectNamesRefreshInterval             0001866656B0 ModelPrimitiveType float float float Single
    // 038 M_searchRefreshInterval                  0001866656B0 ModelPrimitiveType float float float Single
    // 03C NextHierarchyRefreshTime                 0001866656B0 ModelPrimitiveType float float float Single
    // 040 NextObjectNamesRefreshTime               0001866656B0 ModelPrimitiveType float float float Single
    // 044 NextSearchRefreshTime                    0001866656B0 ModelPrimitiveType float float float Single
    // 048 M_allowMultiSelection                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 049 M_multiSelectionToggleSelectionMode      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 04A JustActivatedMultiSelectionToggleSelectionMode 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 04B M_exposeUnityScenes                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 050 ExposedUnityScenesSubset                 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 058 M_exposeDontDestroyOnLoadScene           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 060 PseudoScenesOrder                        000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 068 M_pointerLongPressAction                 0001866EB940 ModelEnumType LongPressAction LongPressAction LongPressAction Int32
    // 06C M_pointerLongPressDuration               0001866656B0 ModelPrimitiveType float float float Single
    // 070 M_doubleClickThreshold                   0001866656B0 ModelPrimitiveType float float float Single
    // 074 M_canReorganizeItems                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 075 M_canDropDraggedParentOnChild            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 076 M_canDropDraggedObjectsToPseudoScenes    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 077 M_showTooltips                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 078 M_tooltipDelay                           0001866656B0 ModelPrimitiveType float float float Single
    // 080 TooltipListener                          00018668C630 ModelClassType TooltipListener TooltipListener TooltipListener Pointer
    // 088 M_showHorizontalScrollbar                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 089 M_isInSearchMode                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 090 M_connectedInspector                     00018669ADC0 ModelClassType RuntimeInspector RuntimeInspector RuntimeInspector Pointer
    // 098 M_isLocked                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0A0 ScrollView                               0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 0A8 DrawArea                                 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 0B0 ListView                                 000186632170 ModelClassType RecycledListView RecycledListView RecycledListView Pointer
    // 0B8 Background                               0001866CCDB0 ModelClassType Image Image Image Pointer
    // 0C0 VerticalScrollbar                        0001866CCDB0 ModelClassType Image Image Image Pointer
    // 0C8 HorizontalScrollbar                      0001866CCDB0 ModelClassType Image Image Image Pointer
    // 0D0 SearchInputField                         0001866FF160 ModelClassType InputField InputField InputField Pointer
    // 0D8 SearchIcon                               0001866CCDB0 ModelClassType Image Image Image Pointer
    // 0E0 SearchInputFieldBackground               0001866CCDB0 ModelClassType Image Image Image Pointer
    // 0E8 SearchBarLayoutElement                   00018650C2A0 ModelClassType LayoutElement LayoutElement LayoutElement Pointer
    // 0F0 DeselectAllButton                        0001865140C0 ModelClassType Button Button Button Pointer
    // 0F8 DeselectAllLayoutElement                 00018650C2A0 ModelClassType LayoutElement LayoutElement LayoutElement Pointer
    // 100 DeselectAllLabel                         000186631C00 ModelClassType Text Text Text Pointer
    // 108 SelectedPathBackground                   0001866CCDB0 ModelClassType Image Image Image Pointer
    // 110 SelectedPathText                         000186631C00 ModelClassType Text Text Text Pointer
    // 118 DragDropListener                         0001866B5470 ModelClassType HierarchyDragDropListener HierarchyDragDropListener HierarchyDragDropListener Pointer
    // 120 DrawerPrefab                             0001866B5E30 ModelClassType HierarchyField HierarchyField HierarchyField Pointer
    // 128 M_sceneDrawerBackground                  00018666B610 ModelClassType Sprite Sprite Sprite Pointer
    // 130 M_transformDrawerBackground              00018666B610 ModelClassType Sprite Sprite Sprite Pointer
    // 000 aliveHierarchies                         int IL2CPP_TYPE_I4
    // 138 Initialized                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 140 Drawers                                  000185CDFEA8 ModelClassListType List`1<HierarchyField> List`1<HierarchyField> List<HierarchyField> Pointer
    // 148 SceneData                                000185CDF988 ModelClassListType List`1<HierarchyDataRoot> List`1<HierarchyDataRoot> List<HierarchyDataRoot> Pointer
    // 150 SearchSceneData                          000185CDF988 ModelClassListType List`1<HierarchyDataRoot> List`1<HierarchyDataRoot> List<HierarchyDataRoot> Pointer
    // 158 pseudoSceneDataLookup                    Dictionary`2<string, HierarchyDataRootPseudoScene> IL2CPP_TYPE_GENERICINST
    // 160 M_currentSelection                       000185D16118 ModelClassListType List`1<Transform> List`1<Transform> List<Transform> Pointer
    // 168 currentSelectionSet                      HashSet`1<int> IL2CPP_TYPE_GENERICINST
    // 170 newSelectionSet                          HashSet`1<int> IL2CPP_TYPE_GENERICINST
    // 178 MultiSelectionPivotTransform             0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 180 MultiSelectionPivotSceneData             0001866B43A0 ModelClassType HierarchyDataRoot HierarchyDataRoot HierarchyDataRoot Pointer
    // 188 MultiSelectionPivotSiblingIndexTraversalList 000185CED1B8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 190 SingleTransformSelection                 000185CACFF8 ModelClassListType Transform[] Transform[] List<Transform> Pointer
    // 198 TotalItemCount                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 19C SelectLock                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 19D IsListViewDirty                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 19E ShouldRecalculateContentWidth            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 1A0 LastClickTime                            0001866656B0 ModelPrimitiveType float float float Single
    // 1A8 LastClickedDrawer                        0001866B5E30 ModelClassType HierarchyField HierarchyField HierarchyField Pointer
    // 1B0 CurrentlyPressedDrawer                   0001866B5E30 ModelClassType HierarchyField HierarchyField HierarchyField Pointer
    // 1B8 PressedDrawerDraggedReferenceCreateTime  0001866656B0 ModelPrimitiveType float float float Single
    // 1C0 PressedDrawerActivePointer               000186642240 ModelClassType PointerEventData PointerEventData PointerEventData Pointer
    // 1C8 M_canvas                                 00018653FDA0 ModelClassType Canvas Canvas Canvas Pointer
    // 1D0 M_autoScrollSpeed                        0001866656B0 ModelPrimitiveType float float float Single
    // 1D8 NullPointerEventData                     000186642240 ModelClassType PointerEventData PointerEventData PointerEventData Pointer
    // 1E0 OnSelectionChanged                       0001866EC880 ModelClassType SelectionChangedDelegate SelectionChangedDelegate SelectionChangedDelegate Pointer
    // 1E8 OnItemDoubleClicked                      0001866EAFC0 ModelClassType DoubleClickDelegate DoubleClickDelegate DoubleClickDelegate Pointer
    // 1F0 M_gameObjectDelegate                     0001866EB480 ModelClassType GameObjectFilterDelegate GameObjectFilterDelegate GameObjectFilterDelegate Pointer
    public partial class RuntimeHierarchy : DataModel
    {
        public float                                    M_refreshInterval                       { get; set; }
        public float                                    M_objectNamesRefreshInterval            { get; set; }
        public float                                    M_searchRefreshInterval                 { get; set; }
        public float                                    NextHierarchyRefreshTime                { get; set; }
        public float                                    NextObjectNamesRefreshTime              { get; set; }
        public float                                    NextSearchRefreshTime                   { get; set; }
        public bool                                     M_allowMultiSelection                   { get; set; }
        public bool                                     M_multiSelectionToggleSelectionMode     { get; set; }
        public bool                                     JustActivatedMultiSelectionToggleSelectionMode { get; set; }
        public bool                                     M_exposeUnityScenes                     { get; set; }
        public List<string>?                            ExposedUnityScenesSubset                { get; set; }
        public bool                                     M_exposeDontDestroyOnLoadScene          { get; set; }
        public List<string>?                            PseudoScenesOrder                       { get; set; }
        public LongPressAction                          M_pointerLongPressAction                { get; set; }
        public float                                    M_pointerLongPressDuration              { get; set; }
        public float                                    M_doubleClickThreshold                  { get; set; }
        public bool                                     M_canReorganizeItems                    { get; set; }
        public bool                                     M_canDropDraggedParentOnChild           { get; set; }
        public bool                                     M_canDropDraggedObjectsToPseudoScenes   { get; set; }
        public bool                                     M_showTooltips                          { get; set; }
        public float                                    M_tooltipDelay                          { get; set; }
        public TooltipListener?                         TooltipListener                         { get; set; }
        public bool                                     M_showHorizontalScrollbar               { get; set; }
        public bool                                     M_isInSearchMode                        { get; set; }
        public RuntimeInspector?                        M_connectedInspector                    { get; set; }
        public bool                                     M_isLocked                              { get; set; }
        public ScrollRect?                              ScrollView                              { get; set; }
        public RectTransform?                           DrawArea                                { get; set; }
        public RecycledListView?                        ListView                                { get; set; }
        public Image?                                   Background                              { get; set; }
        public Image?                                   VerticalScrollbar                       { get; set; }
        public Image?                                   HorizontalScrollbar                     { get; set; }
        public InputField?                              SearchInputField                        { get; set; }
        public Image?                                   SearchIcon                              { get; set; }
        public Image?                                   SearchInputFieldBackground              { get; set; }
        public LayoutElement?                           SearchBarLayoutElement                  { get; set; }
        public Button?                                  DeselectAllButton                       { get; set; }
        public LayoutElement?                           DeselectAllLayoutElement                { get; set; }
        public Text?                                    DeselectAllLabel                        { get; set; }
        public Image?                                   SelectedPathBackground                  { get; set; }
        public Text?                                    SelectedPathText                        { get; set; }
        public HierarchyDragDropListener?               DragDropListener                        { get; set; }
        public HierarchyField?                          DrawerPrefab                            { get; set; }
        public Sprite?                                  M_sceneDrawerBackground                 { get; set; }
        public Sprite?                                  M_transformDrawerBackground             { get; set; }
        public bool                                     Initialized                             { get; set; }
        public List<HierarchyField>?                    Drawers                                 { get; set; }
        public List<HierarchyDataRoot>?                 SceneData                               { get; set; }
        public List<HierarchyDataRoot>?                 SearchSceneData                         { get; set; }
        public List<Transform>?                         M_currentSelection                      { get; set; }
        public Transform?                               MultiSelectionPivotTransform            { get; set; }
        public HierarchyDataRoot?                       MultiSelectionPivotSceneData            { get; set; }
        public List<int>?                               MultiSelectionPivotSiblingIndexTraversalList { get; set; }
        public List<Transform>?                         SingleTransformSelection                { get; set; }
        public int                                      TotalItemCount                          { get; set; }
        public bool                                     SelectLock                              { get; set; }
        public bool                                     IsListViewDirty                         { get; set; }
        public bool                                     ShouldRecalculateContentWidth           { get; set; }
        public float                                    LastClickTime                           { get; set; }
        public HierarchyField?                          LastClickedDrawer                       { get; set; }
        public HierarchyField?                          CurrentlyPressedDrawer                  { get; set; }
        public float                                    PressedDrawerDraggedReferenceCreateTime { get; set; }
        public PointerEventData?                        PressedDrawerActivePointer              { get; set; }
        public Canvas?                                  M_canvas                                { get; set; }
        public float                                    M_autoScrollSpeed                       { get; set; }
        public PointerEventData?                        NullPointerEventData                    { get; set; }
        public SelectionChangedDelegate?                OnSelectionChanged                      { get; set; }
        public DoubleClickDelegate?                     OnItemDoubleClicked                     { get; set; }
        public GameObjectFilterDelegate?                M_gameObjectDelegate                    { get; set; }

        public static RuntimeHierarchy? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RuntimeHierarchy() { Pointer= p0 };

            value.M_refreshInterval                         = GetSingle(new IntPtr(p + 0x030)); // 02466B1E05C8 0x30 M_refreshInterval           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_objectNamesRefreshInterval              = GetSingle(new IntPtr(p + 0x034)); // 02466B1E05E8 0x34 M_objectNamesRefreshInterval ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_searchRefreshInterval                   = GetSingle(new IntPtr(p + 0x038)); // 02466B1E0608 0x38 M_searchRefreshInterval     ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.NextHierarchyRefreshTime                  = GetSingle(new IntPtr(p + 0x03C)); // 02466B1E0628 0x3C NextHierarchyRefreshTime    ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.NextObjectNamesRefreshTime                = GetSingle(new IntPtr(p + 0x040)); // 02466B1E0648 0x40 NextObjectNamesRefreshTime  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.NextSearchRefreshTime                     = GetSingle(new IntPtr(p + 0x044)); // 02466B1E0668 0x44 NextSearchRefreshTime       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_allowMultiSelection                     = GetBool(new IntPtr(p + 0x048)); // 02466B1E0688 0x48 M_allowMultiSelection       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_multiSelectionToggleSelectionMode       = GetBool(new IntPtr(p + 0x049)); // 02466B1E06A8 0x49 M_multiSelectionToggleSelectionMode ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.JustActivatedMultiSelectionToggleSelectionMode = GetBool(new IntPtr(p + 0x04A)); // 02466B1E06C8 0x4A JustActivatedMultiSelectionToggleSelectionMode ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_exposeUnityScenes                       = GetBool(new IntPtr(p + 0x04B)); // 02466B1E06E8 0x4B M_exposeUnityScenes         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ExposedUnityScenesSubset                  = GetStringList(new IntPtr(p + 0x050)); // 02466B1E0708 0x50 ExposedUnityScenesSubset    ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.M_exposeDontDestroyOnLoadScene            = GetBool(new IntPtr(p + 0x058)); // 02466B1E0728 0x58 M_exposeDontDestroyOnLoadScene ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PseudoScenesOrder                         = GetStringList(new IntPtr(p + 0x060)); // 02466B1E0748 0x60 PseudoScenesOrder           ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.M_pointerLongPressAction                  = (LongPressAction)GetInt32(new IntPtr(p + 0x068)); // 02466B1E0768 0x68 M_pointerLongPressAction    ( 0001866EB940 ModelEnumType LongPressAction LongPressAction LongPressAction Int32 )
            value.M_pointerLongPressDuration                = GetSingle(new IntPtr(p + 0x06C)); // 02466B1E0788 0x6C M_pointerLongPressDuration  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_doubleClickThreshold                    = GetSingle(new IntPtr(p + 0x070)); // 02466B1E07A8 0x70 M_doubleClickThreshold      ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_canReorganizeItems                      = GetBool(new IntPtr(p + 0x074)); // 02466B1E07C8 0x74 M_canReorganizeItems        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_canDropDraggedParentOnChild             = GetBool(new IntPtr(p + 0x075)); // 02466B1E07E8 0x75 M_canDropDraggedParentOnChild ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_canDropDraggedObjectsToPseudoScenes     = GetBool(new IntPtr(p + 0x076)); // 02466B1E0808 0x76 M_canDropDraggedObjectsToPseudoScenes ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_showTooltips                            = GetBool(new IntPtr(p + 0x077)); // 02466B1E0828 0x77 M_showTooltips              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_tooltipDelay                            = GetSingle(new IntPtr(p + 0x078)); // 02466B1E0848 0x78 M_tooltipDelay              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.TooltipListener                           = GetObject<TooltipListener>(new IntPtr(p + 0x080), ReversePrism.DataModels.TooltipListener.FromPointer); // 02466B1E0868 0x80 TooltipListener             ( 00018668C630 ModelClassType TooltipListener TooltipListener TooltipListener Pointer )
            value.M_showHorizontalScrollbar                 = GetBool(new IntPtr(p + 0x088)); // 02466B1E0888 0x88 M_showHorizontalScrollbar   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_isInSearchMode                          = GetBool(new IntPtr(p + 0x089)); // 02466B1E08A8 0x89 M_isInSearchMode            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_connectedInspector                      = GetObject<RuntimeInspector>(new IntPtr(p + 0x090), ReversePrism.DataModels.RuntimeInspector.FromPointer); // 02466B1E08C8 0x90 M_connectedInspector        ( 00018669ADC0 ModelClassType RuntimeInspector RuntimeInspector RuntimeInspector Pointer )
            value.M_isLocked                                = GetBool(new IntPtr(p + 0x098)); // 02466B1E08E8 0x98 M_isLocked                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ScrollView                                = GetObject<ScrollRect>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ScrollRect.FromPointer); // 02466B1E0908 0xA0 ScrollView                  ( 0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.DrawArea                                  = GetObject<RectTransform>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.RectTransform.FromPointer); // 02466B1E0928 0xA8 DrawArea                    ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.ListView                                  = GetObject<RecycledListView>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.RecycledListView.FromPointer); // 02466B1E0948 0xB0 ListView                    ( 000186632170 ModelClassType RecycledListView RecycledListView RecycledListView Pointer )
            value.Background                                = GetObject<Image>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.Image.FromPointer); // 02466B1E0968 0xB8 Background                  ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.VerticalScrollbar                         = GetObject<Image>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.Image.FromPointer); // 02466B1E0988 0xC0 VerticalScrollbar           ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.HorizontalScrollbar                       = GetObject<Image>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.Image.FromPointer); // 02466B1E09A8 0xC8 HorizontalScrollbar         ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.SearchInputField                          = GetObject<InputField>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.InputField.FromPointer); // 02466B1E09C8 0xD0 SearchInputField            ( 0001866FF160 ModelClassType InputField InputField InputField Pointer )
            value.SearchIcon                                = GetObject<Image>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.Image.FromPointer); // 02466B1E09E8 0xD8 SearchIcon                  ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.SearchInputFieldBackground                = GetObject<Image>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.Image.FromPointer); // 02466B1E0A08 0xE0 SearchInputFieldBackground  ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.SearchBarLayoutElement                    = GetObject<LayoutElement>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.LayoutElement.FromPointer); // 02466B1E0A28 0xE8 SearchBarLayoutElement      ( 00018650C2A0 ModelClassType LayoutElement LayoutElement LayoutElement Pointer )
            value.DeselectAllButton                         = GetObject<Button>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.Button.FromPointer); // 02466B1E0A48 0xF0 DeselectAllButton           ( 0001865140C0 ModelClassType Button Button Button Pointer )
            value.DeselectAllLayoutElement                  = GetObject<LayoutElement>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.LayoutElement.FromPointer); // 02466B1E0A68 0xF8 DeselectAllLayoutElement    ( 00018650C2A0 ModelClassType LayoutElement LayoutElement LayoutElement Pointer )
            value.DeselectAllLabel                          = GetObject<Text>(new IntPtr(p + 0x100), ReversePrism.DataModels.Text.FromPointer); // 02466B1E0A88 0x100 DeselectAllLabel            ( 000186631C00 ModelClassType Text Text Text Pointer )
            value.SelectedPathBackground                    = GetObject<Image>(new IntPtr(p + 0x108), ReversePrism.DataModels.Image.FromPointer); // 02466B1E0AA8 0x108 SelectedPathBackground      ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.SelectedPathText                          = GetObject<Text>(new IntPtr(p + 0x110), ReversePrism.DataModels.Text.FromPointer); // 02466B1E0AC8 0x110 SelectedPathText            ( 000186631C00 ModelClassType Text Text Text Pointer )
            value.DragDropListener                          = GetObject<HierarchyDragDropListener>(new IntPtr(p + 0x118), ReversePrism.DataModels.HierarchyDragDropListener.FromPointer); // 02466B1E0AE8 0x118 DragDropListener            ( 0001866B5470 ModelClassType HierarchyDragDropListener HierarchyDragDropListener HierarchyDragDropListener Pointer )
            value.DrawerPrefab                              = GetObject<HierarchyField>(new IntPtr(p + 0x120), ReversePrism.DataModels.HierarchyField.FromPointer); // 02466B1E0B08 0x120 DrawerPrefab                ( 0001866B5E30 ModelClassType HierarchyField HierarchyField HierarchyField Pointer )
            value.M_sceneDrawerBackground                   = GetObject<Sprite>(new IntPtr(p + 0x128), ReversePrism.DataModels.Sprite.FromPointer); // 02466B1E0B28 0x128 M_sceneDrawerBackground     ( 00018666B610 ModelClassType Sprite Sprite Sprite Pointer )
            value.M_transformDrawerBackground               = GetObject<Sprite>(new IntPtr(p + 0x130), ReversePrism.DataModels.Sprite.FromPointer); // 02466B1E0B48 0x130 M_transformDrawerBackground ( 00018666B610 ModelClassType Sprite Sprite Sprite Pointer )
            value.Initialized                               = GetBool(new IntPtr(p + 0x138)); // 02466B1E0B88 0x138 Initialized                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Drawers                                   = GetObjectList<HierarchyField>(new IntPtr(p + 0x140), ReversePrism.DataModels.HierarchyField.FromPointer); // 02466B1E0BA8 0x140 Drawers                     ( 000185CDFEA8 ModelClassListType List`1<HierarchyField> List`1<HierarchyField> List<HierarchyField> Pointer )
            value.SceneData                                 = GetObjectList<HierarchyDataRoot>(new IntPtr(p + 0x148), ReversePrism.DataModels.HierarchyDataRoot.FromPointer); // 02466B1E0BC8 0x148 SceneData                   ( 000185CDF988 ModelClassListType List`1<HierarchyDataRoot> List`1<HierarchyDataRoot> List<HierarchyDataRoot> Pointer )
            value.SearchSceneData                           = GetObjectList<HierarchyDataRoot>(new IntPtr(p + 0x150), ReversePrism.DataModels.HierarchyDataRoot.FromPointer); // 02466B1E0BE8 0x150 SearchSceneData             ( 000185CDF988 ModelClassListType List`1<HierarchyDataRoot> List`1<HierarchyDataRoot> List<HierarchyDataRoot> Pointer )
            value.M_currentSelection                        = GetObjectList<Transform>(new IntPtr(p + 0x160), ReversePrism.DataModels.Transform.FromPointer); // 02466B1E0C28 0x160 M_currentSelection          ( 000185D16118 ModelClassListType List`1<Transform> List`1<Transform> List<Transform> Pointer )
            value.MultiSelectionPivotTransform              = GetObject<Transform>(new IntPtr(p + 0x178), ReversePrism.DataModels.Transform.FromPointer); // 02466B1E0C88 0x178 MultiSelectionPivotTransform ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.MultiSelectionPivotSceneData              = GetObject<HierarchyDataRoot>(new IntPtr(p + 0x180), ReversePrism.DataModels.HierarchyDataRoot.FromPointer); // 02466B1E0CA8 0x180 MultiSelectionPivotSceneData ( 0001866B43A0 ModelClassType HierarchyDataRoot HierarchyDataRoot HierarchyDataRoot Pointer )
            value.MultiSelectionPivotSiblingIndexTraversalList = GetInt32List(new IntPtr(p + 0x188)); // 02466B1E0CC8 0x188 MultiSelectionPivotSiblingIndexTraversalList ( 000185CED1B8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.SingleTransformSelection                  = GetObjectList<Transform>(new IntPtr(p + 0x190), ReversePrism.DataModels.Transform.FromPointer); // 02466B1E0CE8 0x190 SingleTransformSelection    ( 000185CACFF8 ModelClassListType Transform[] Transform[] List<Transform> Pointer )
            value.TotalItemCount                            = GetInt32(new IntPtr(p + 0x198)); // 02466B1E0D08 0x198 TotalItemCount              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SelectLock                                = GetBool(new IntPtr(p + 0x19C)); // 02466B1E0D28 0x19C SelectLock                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsListViewDirty                           = GetBool(new IntPtr(p + 0x19D)); // 02466B1E0D48 0x19D IsListViewDirty             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ShouldRecalculateContentWidth             = GetBool(new IntPtr(p + 0x19E)); // 02466B1E0D68 0x19E ShouldRecalculateContentWidth ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.LastClickTime                             = GetSingle(new IntPtr(p + 0x1A0)); // 02466B1E0D88 0x1A0 LastClickTime               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.LastClickedDrawer                         = GetObject<HierarchyField>(new IntPtr(p + 0x1A8), ReversePrism.DataModels.HierarchyField.FromPointer); // 02466B1E0DA8 0x1A8 LastClickedDrawer           ( 0001866B5E30 ModelClassType HierarchyField HierarchyField HierarchyField Pointer )
            value.CurrentlyPressedDrawer                    = GetObject<HierarchyField>(new IntPtr(p + 0x1B0), ReversePrism.DataModels.HierarchyField.FromPointer); // 02466B1E0DC8 0x1B0 CurrentlyPressedDrawer      ( 0001866B5E30 ModelClassType HierarchyField HierarchyField HierarchyField Pointer )
            value.PressedDrawerDraggedReferenceCreateTime   = GetSingle(new IntPtr(p + 0x1B8)); // 02466B1E0DE8 0x1B8 PressedDrawerDraggedReferenceCreateTime ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.PressedDrawerActivePointer                = GetObject<PointerEventData>(new IntPtr(p + 0x1C0), ReversePrism.DataModels.PointerEventData.FromPointer); // 02466B1E0E08 0x1C0 PressedDrawerActivePointer  ( 000186642240 ModelClassType PointerEventData PointerEventData PointerEventData Pointer )
            value.M_canvas                                  = GetObject<Canvas>(new IntPtr(p + 0x1C8), ReversePrism.DataModels.Canvas.FromPointer); // 02466B1E0E28 0x1C8 M_canvas                    ( 00018653FDA0 ModelClassType Canvas Canvas Canvas Pointer )
            value.M_autoScrollSpeed                         = GetSingle(new IntPtr(p + 0x1D0)); // 02466B1E0E48 0x1D0 M_autoScrollSpeed           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.NullPointerEventData                      = GetObject<PointerEventData>(new IntPtr(p + 0x1D8), ReversePrism.DataModels.PointerEventData.FromPointer); // 02466B1E0E68 0x1D8 NullPointerEventData        ( 000186642240 ModelClassType PointerEventData PointerEventData PointerEventData Pointer )
            value.OnSelectionChanged                        = GetObject<SelectionChangedDelegate>(new IntPtr(p + 0x1E0), ReversePrism.DataModels.SelectionChangedDelegate.FromPointer); // 02466B1E0E88 0x1E0 OnSelectionChanged          ( 0001866EC880 ModelClassType SelectionChangedDelegate SelectionChangedDelegate SelectionChangedDelegate Pointer )
            value.OnItemDoubleClicked                       = GetObject<DoubleClickDelegate>(new IntPtr(p + 0x1E8), ReversePrism.DataModels.DoubleClickDelegate.FromPointer); // 02466B1E0EA8 0x1E8 OnItemDoubleClicked         ( 0001866EAFC0 ModelClassType DoubleClickDelegate DoubleClickDelegate DoubleClickDelegate Pointer )
            value.M_gameObjectDelegate                      = GetObject<GameObjectFilterDelegate>(new IntPtr(p + 0x1F0), ReversePrism.DataModels.GameObjectFilterDelegate.FromPointer); // 02466B1E0EC8 0x1F0 M_gameObjectDelegate        ( 0001866EB480 ModelClassType GameObjectFilterDelegate GameObjectFilterDelegate GameObjectFilterDelegate Pointer )

            return value;
        }
    }
}
