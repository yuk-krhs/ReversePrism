using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 M_refreshInterval                        ModelPrimitiveType float float float Single
    // 034 M_objectNamesRefreshInterval             ModelPrimitiveType float float float Single
    // 038 M_searchRefreshInterval                  ModelPrimitiveType float float float Single
    // 03C NextHierarchyRefreshTime                 ModelPrimitiveType float float float Single
    // 040 NextObjectNamesRefreshTime               ModelPrimitiveType float float float Single
    // 044 NextSearchRefreshTime                    ModelPrimitiveType float float float Single
    // 048 M_allowMultiSelection                    ModelPrimitiveType bool bool bool Bool
    // 049 M_multiSelectionToggleSelectionMode      ModelPrimitiveType bool bool bool Bool
    // 04A JustActivatedMultiSelectionToggleSelectionMode ModelPrimitiveType bool bool bool Bool
    // 04B M_exposeUnityScenes                      ModelPrimitiveType bool bool bool Bool
    // 050 ExposedUnityScenesSubset                 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 058 M_exposeDontDestroyOnLoadScene           ModelPrimitiveType bool bool bool Bool
    // 060 PseudoScenesOrder                        ModelPrimitiveListType string[] string[] List<string> Pointer
    // 068 M_pointerLongPressAction                 ModelEnumType LongPressAction LongPressAction LongPressAction Int32
    // 06C M_pointerLongPressDuration               ModelPrimitiveType float float float Single
    // 070 M_doubleClickThreshold                   ModelPrimitiveType float float float Single
    // 074 M_canReorganizeItems                     ModelPrimitiveType bool bool bool Bool
    // 075 M_canDropDraggedParentOnChild            ModelPrimitiveType bool bool bool Bool
    // 076 M_canDropDraggedObjectsToPseudoScenes    ModelPrimitiveType bool bool bool Bool
    // 077 M_showTooltips                           ModelPrimitiveType bool bool bool Bool
    // 078 M_tooltipDelay                           ModelPrimitiveType float float float Single
    // 080 TooltipListener                          ModelClassType TooltipListener TooltipListener TooltipListener Pointer
    // 088 M_showHorizontalScrollbar                ModelPrimitiveType bool bool bool Bool
    // 089 M_isInSearchMode                         ModelPrimitiveType bool bool bool Bool
    // 090 M_connectedInspector                     ModelClassType RuntimeInspector RuntimeInspector RuntimeInspector Pointer
    // 098 M_isLocked                               ModelPrimitiveType bool bool bool Bool
    // 0A0 ScrollView                               ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 0A8 DrawArea                                 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 0B0 ListView                                 ModelClassType RecycledListView RecycledListView RecycledListView Pointer
    // 0B8 Background                               ModelClassType Image Image Image Pointer
    // 0C0 VerticalScrollbar                        ModelClassType Image Image Image Pointer
    // 0C8 HorizontalScrollbar                      ModelClassType Image Image Image Pointer
    // 0D0 SearchInputField                         ModelClassType InputField InputField InputField Pointer
    // 0D8 SearchIcon                               ModelClassType Image Image Image Pointer
    // 0E0 SearchInputFieldBackground               ModelClassType Image Image Image Pointer
    // 0E8 SearchBarLayoutElement                   ModelClassType LayoutElement LayoutElement LayoutElement Pointer
    // 0F0 DeselectAllButton                        ModelClassType Button Button Button Pointer
    // 0F8 DeselectAllLayoutElement                 ModelClassType LayoutElement LayoutElement LayoutElement Pointer
    // 100 DeselectAllLabel                         ModelClassType Text Text Text Pointer
    // 108 SelectedPathBackground                   ModelClassType Image Image Image Pointer
    // 110 SelectedPathText                         ModelClassType Text Text Text Pointer
    // 118 DragDropListener                         ModelClassType HierarchyDragDropListener HierarchyDragDropListener HierarchyDragDropListener Pointer
    // 120 DrawerPrefab                             ModelClassType HierarchyField HierarchyField HierarchyField Pointer
    // 128 M_sceneDrawerBackground                  ModelClassType Sprite Sprite Sprite Pointer
    // 130 M_transformDrawerBackground              ModelClassType Sprite Sprite Sprite Pointer
    // 000 aliveHierarchies                         int IL2CPP_TYPE_I4
    // 138 Initialized                              ModelPrimitiveType bool bool bool Bool
    // 140 Drawers                                  ModelClassListType List`1<HierarchyField> List`1<HierarchyField> List<HierarchyField> Pointer
    // 148 SceneData                                ModelClassListType List`1<HierarchyDataRoot> List`1<HierarchyDataRoot> List<HierarchyDataRoot> Pointer
    // 150 SearchSceneData                          ModelClassListType List`1<HierarchyDataRoot> List`1<HierarchyDataRoot> List<HierarchyDataRoot> Pointer
    // 158 pseudoSceneDataLookup                    Dictionary`2<string, HierarchyDataRootPseudoScene> IL2CPP_TYPE_GENERICINST
    // 160 M_currentSelection                       ModelClassListType List`1<Transform> List`1<Transform> List<Transform> Pointer
    // 168 currentSelectionSet                      HashSet`1<int> IL2CPP_TYPE_GENERICINST
    // 170 newSelectionSet                          HashSet`1<int> IL2CPP_TYPE_GENERICINST
    // 178 MultiSelectionPivotTransform             ModelClassType Transform Transform Transform Pointer
    // 180 MultiSelectionPivotSceneData             ModelClassType HierarchyDataRoot HierarchyDataRoot HierarchyDataRoot Pointer
    // 188 MultiSelectionPivotSiblingIndexTraversalList ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 190 SingleTransformSelection                 ModelClassListType Transform[] Transform[] List<Transform> Pointer
    // 198 TotalItemCount                           ModelPrimitiveType int int int Int32
    // 19C SelectLock                               ModelPrimitiveType bool bool bool Bool
    // 19D IsListViewDirty                          ModelPrimitiveType bool bool bool Bool
    // 19E ShouldRecalculateContentWidth            ModelPrimitiveType bool bool bool Bool
    // 1A0 LastClickTime                            ModelPrimitiveType float float float Single
    // 1A8 LastClickedDrawer                        ModelClassType HierarchyField HierarchyField HierarchyField Pointer
    // 1B0 CurrentlyPressedDrawer                   ModelClassType HierarchyField HierarchyField HierarchyField Pointer
    // 1B8 PressedDrawerDraggedReferenceCreateTime  ModelPrimitiveType float float float Single
    // 1C0 PressedDrawerActivePointer               ModelClassType PointerEventData PointerEventData PointerEventData Pointer
    // 1C8 M_canvas                                 ModelClassType Canvas Canvas Canvas Pointer
    // 1D0 M_autoScrollSpeed                        ModelPrimitiveType float float float Single
    // 1D8 NullPointerEventData                     ModelClassType PointerEventData PointerEventData PointerEventData Pointer
    // 1E0 OnSelectionChanged                       ModelClassType SelectionChangedDelegate SelectionChangedDelegate SelectionChangedDelegate Pointer
    // 1E8 OnItemDoubleClicked                      ModelClassType DoubleClickDelegate DoubleClickDelegate DoubleClickDelegate Pointer
    // 1F0 M_gameObjectDelegate                     ModelClassType GameObjectFilterDelegate GameObjectFilterDelegate GameObjectFilterDelegate Pointer
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

            value.M_refreshInterval                         = GetSingle(new IntPtr(p + 0x030)); // 0x30 M_refreshInterval           ( ModelPrimitiveType float float float Single )
            value.M_objectNamesRefreshInterval              = GetSingle(new IntPtr(p + 0x034)); // 0x34 M_objectNamesRefreshInterval ( ModelPrimitiveType float float float Single )
            value.M_searchRefreshInterval                   = GetSingle(new IntPtr(p + 0x038)); // 0x38 M_searchRefreshInterval     ( ModelPrimitiveType float float float Single )
            value.NextHierarchyRefreshTime                  = GetSingle(new IntPtr(p + 0x03C)); // 0x3C NextHierarchyRefreshTime    ( ModelPrimitiveType float float float Single )
            value.NextObjectNamesRefreshTime                = GetSingle(new IntPtr(p + 0x040)); // 0x40 NextObjectNamesRefreshTime  ( ModelPrimitiveType float float float Single )
            value.NextSearchRefreshTime                     = GetSingle(new IntPtr(p + 0x044)); // 0x44 NextSearchRefreshTime       ( ModelPrimitiveType float float float Single )
            value.M_allowMultiSelection                     = GetBool(new IntPtr(p + 0x048)); // 0x48 M_allowMultiSelection       ( ModelPrimitiveType bool bool bool Bool )
            value.M_multiSelectionToggleSelectionMode       = GetBool(new IntPtr(p + 0x049)); // 0x49 M_multiSelectionToggleSelectionMode ( ModelPrimitiveType bool bool bool Bool )
            value.JustActivatedMultiSelectionToggleSelectionMode = GetBool(new IntPtr(p + 0x04A)); // 0x4A JustActivatedMultiSelectionToggleSelectionMode ( ModelPrimitiveType bool bool bool Bool )
            value.M_exposeUnityScenes                       = GetBool(new IntPtr(p + 0x04B)); // 0x4B M_exposeUnityScenes         ( ModelPrimitiveType bool bool bool Bool )
            value.ExposedUnityScenesSubset                  = GetStringList(new IntPtr(p + 0x050)); // 0x50 ExposedUnityScenesSubset    ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.M_exposeDontDestroyOnLoadScene            = GetBool(new IntPtr(p + 0x058)); // 0x58 M_exposeDontDestroyOnLoadScene ( ModelPrimitiveType bool bool bool Bool )
            value.PseudoScenesOrder                         = GetStringList(new IntPtr(p + 0x060)); // 0x60 PseudoScenesOrder           ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.M_pointerLongPressAction                  = (LongPressAction)GetInt32(new IntPtr(p + 0x068)); // 0x68 M_pointerLongPressAction    ( ModelEnumType LongPressAction LongPressAction LongPressAction Int32 )
            value.M_pointerLongPressDuration                = GetSingle(new IntPtr(p + 0x06C)); // 0x6C M_pointerLongPressDuration  ( ModelPrimitiveType float float float Single )
            value.M_doubleClickThreshold                    = GetSingle(new IntPtr(p + 0x070)); // 0x70 M_doubleClickThreshold      ( ModelPrimitiveType float float float Single )
            value.M_canReorganizeItems                      = GetBool(new IntPtr(p + 0x074)); // 0x74 M_canReorganizeItems        ( ModelPrimitiveType bool bool bool Bool )
            value.M_canDropDraggedParentOnChild             = GetBool(new IntPtr(p + 0x075)); // 0x75 M_canDropDraggedParentOnChild ( ModelPrimitiveType bool bool bool Bool )
            value.M_canDropDraggedObjectsToPseudoScenes     = GetBool(new IntPtr(p + 0x076)); // 0x76 M_canDropDraggedObjectsToPseudoScenes ( ModelPrimitiveType bool bool bool Bool )
            value.M_showTooltips                            = GetBool(new IntPtr(p + 0x077)); // 0x77 M_showTooltips              ( ModelPrimitiveType bool bool bool Bool )
            value.M_tooltipDelay                            = GetSingle(new IntPtr(p + 0x078)); // 0x78 M_tooltipDelay              ( ModelPrimitiveType float float float Single )
            value.TooltipListener                           = GetObject<TooltipListener>(new IntPtr(p + 0x080), ReversePrism.DataModels.TooltipListener.FromPointer); // 0x80 TooltipListener             ( ModelClassType TooltipListener TooltipListener TooltipListener Pointer )
            value.M_showHorizontalScrollbar                 = GetBool(new IntPtr(p + 0x088)); // 0x88 M_showHorizontalScrollbar   ( ModelPrimitiveType bool bool bool Bool )
            value.M_isInSearchMode                          = GetBool(new IntPtr(p + 0x089)); // 0x89 M_isInSearchMode            ( ModelPrimitiveType bool bool bool Bool )
            value.M_connectedInspector                      = GetObject<RuntimeInspector>(new IntPtr(p + 0x090), ReversePrism.DataModels.RuntimeInspector.FromPointer); // 0x90 M_connectedInspector        ( ModelClassType RuntimeInspector RuntimeInspector RuntimeInspector Pointer )
            value.M_isLocked                                = GetBool(new IntPtr(p + 0x098)); // 0x98 M_isLocked                  ( ModelPrimitiveType bool bool bool Bool )
            value.ScrollView                                = GetObject<ScrollRect>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ScrollRect.FromPointer); // 0xA0 ScrollView                  ( ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.DrawArea                                  = GetObject<RectTransform>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.RectTransform.FromPointer); // 0xA8 DrawArea                    ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.ListView                                  = GetObject<RecycledListView>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.RecycledListView.FromPointer); // 0xB0 ListView                    ( ModelClassType RecycledListView RecycledListView RecycledListView Pointer )
            value.Background                                = GetObject<Image>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.Image.FromPointer); // 0xB8 Background                  ( ModelClassType Image Image Image Pointer )
            value.VerticalScrollbar                         = GetObject<Image>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.Image.FromPointer); // 0xC0 VerticalScrollbar           ( ModelClassType Image Image Image Pointer )
            value.HorizontalScrollbar                       = GetObject<Image>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.Image.FromPointer); // 0xC8 HorizontalScrollbar         ( ModelClassType Image Image Image Pointer )
            value.SearchInputField                          = GetObject<InputField>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.InputField.FromPointer); // 0xD0 SearchInputField            ( ModelClassType InputField InputField InputField Pointer )
            value.SearchIcon                                = GetObject<Image>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.Image.FromPointer); // 0xD8 SearchIcon                  ( ModelClassType Image Image Image Pointer )
            value.SearchInputFieldBackground                = GetObject<Image>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.Image.FromPointer); // 0xE0 SearchInputFieldBackground  ( ModelClassType Image Image Image Pointer )
            value.SearchBarLayoutElement                    = GetObject<LayoutElement>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.LayoutElement.FromPointer); // 0xE8 SearchBarLayoutElement      ( ModelClassType LayoutElement LayoutElement LayoutElement Pointer )
            value.DeselectAllButton                         = GetObject<Button>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.Button.FromPointer); // 0xF0 DeselectAllButton           ( ModelClassType Button Button Button Pointer )
            value.DeselectAllLayoutElement                  = GetObject<LayoutElement>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.LayoutElement.FromPointer); // 0xF8 DeselectAllLayoutElement    ( ModelClassType LayoutElement LayoutElement LayoutElement Pointer )
            value.DeselectAllLabel                          = GetObject<Text>(new IntPtr(p + 0x100), ReversePrism.DataModels.Text.FromPointer); // 0x100 DeselectAllLabel            ( ModelClassType Text Text Text Pointer )
            value.SelectedPathBackground                    = GetObject<Image>(new IntPtr(p + 0x108), ReversePrism.DataModels.Image.FromPointer); // 0x108 SelectedPathBackground      ( ModelClassType Image Image Image Pointer )
            value.SelectedPathText                          = GetObject<Text>(new IntPtr(p + 0x110), ReversePrism.DataModels.Text.FromPointer); // 0x110 SelectedPathText            ( ModelClassType Text Text Text Pointer )
            value.DragDropListener                          = GetObject<HierarchyDragDropListener>(new IntPtr(p + 0x118), ReversePrism.DataModels.HierarchyDragDropListener.FromPointer); // 0x118 DragDropListener            ( ModelClassType HierarchyDragDropListener HierarchyDragDropListener HierarchyDragDropListener Pointer )
            value.DrawerPrefab                              = GetObject<HierarchyField>(new IntPtr(p + 0x120), ReversePrism.DataModels.HierarchyField.FromPointer); // 0x120 DrawerPrefab                ( ModelClassType HierarchyField HierarchyField HierarchyField Pointer )
            value.M_sceneDrawerBackground                   = GetObject<Sprite>(new IntPtr(p + 0x128), ReversePrism.DataModels.Sprite.FromPointer); // 0x128 M_sceneDrawerBackground     ( ModelClassType Sprite Sprite Sprite Pointer )
            value.M_transformDrawerBackground               = GetObject<Sprite>(new IntPtr(p + 0x130), ReversePrism.DataModels.Sprite.FromPointer); // 0x130 M_transformDrawerBackground ( ModelClassType Sprite Sprite Sprite Pointer )
            value.Initialized                               = GetBool(new IntPtr(p + 0x138)); // 0x138 Initialized                 ( ModelPrimitiveType bool bool bool Bool )
            value.Drawers                                   = GetObjectList<HierarchyField>(new IntPtr(p + 0x140), ReversePrism.DataModels.HierarchyField.FromPointer); // 0x140 Drawers                     ( ModelClassListType List`1<HierarchyField> List`1<HierarchyField> List<HierarchyField> Pointer )
            value.SceneData                                 = GetObjectList<HierarchyDataRoot>(new IntPtr(p + 0x148), ReversePrism.DataModels.HierarchyDataRoot.FromPointer); // 0x148 SceneData                   ( ModelClassListType List`1<HierarchyDataRoot> List`1<HierarchyDataRoot> List<HierarchyDataRoot> Pointer )
            value.SearchSceneData                           = GetObjectList<HierarchyDataRoot>(new IntPtr(p + 0x150), ReversePrism.DataModels.HierarchyDataRoot.FromPointer); // 0x150 SearchSceneData             ( ModelClassListType List`1<HierarchyDataRoot> List`1<HierarchyDataRoot> List<HierarchyDataRoot> Pointer )
            value.M_currentSelection                        = GetObjectList<Transform>(new IntPtr(p + 0x160), ReversePrism.DataModels.Transform.FromPointer); // 0x160 M_currentSelection          ( ModelClassListType List`1<Transform> List`1<Transform> List<Transform> Pointer )
            value.MultiSelectionPivotTransform              = GetObject<Transform>(new IntPtr(p + 0x178), ReversePrism.DataModels.Transform.FromPointer); // 0x178 MultiSelectionPivotTransform ( ModelClassType Transform Transform Transform Pointer )
            value.MultiSelectionPivotSceneData              = GetObject<HierarchyDataRoot>(new IntPtr(p + 0x180), ReversePrism.DataModels.HierarchyDataRoot.FromPointer); // 0x180 MultiSelectionPivotSceneData ( ModelClassType HierarchyDataRoot HierarchyDataRoot HierarchyDataRoot Pointer )
            value.MultiSelectionPivotSiblingIndexTraversalList = GetInt32List(new IntPtr(p + 0x188)); // 0x188 MultiSelectionPivotSiblingIndexTraversalList ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.SingleTransformSelection                  = GetObjectList<Transform>(new IntPtr(p + 0x190), ReversePrism.DataModels.Transform.FromPointer); // 0x190 SingleTransformSelection    ( ModelClassListType Transform[] Transform[] List<Transform> Pointer )
            value.TotalItemCount                            = GetInt32(new IntPtr(p + 0x198)); // 0x198 TotalItemCount              ( ModelPrimitiveType int int int Int32 )
            value.SelectLock                                = GetBool(new IntPtr(p + 0x19C)); // 0x19C SelectLock                  ( ModelPrimitiveType bool bool bool Bool )
            value.IsListViewDirty                           = GetBool(new IntPtr(p + 0x19D)); // 0x19D IsListViewDirty             ( ModelPrimitiveType bool bool bool Bool )
            value.ShouldRecalculateContentWidth             = GetBool(new IntPtr(p + 0x19E)); // 0x19E ShouldRecalculateContentWidth ( ModelPrimitiveType bool bool bool Bool )
            value.LastClickTime                             = GetSingle(new IntPtr(p + 0x1A0)); // 0x1A0 LastClickTime               ( ModelPrimitiveType float float float Single )
            value.LastClickedDrawer                         = GetObject<HierarchyField>(new IntPtr(p + 0x1A8), ReversePrism.DataModels.HierarchyField.FromPointer); // 0x1A8 LastClickedDrawer           ( ModelClassType HierarchyField HierarchyField HierarchyField Pointer )
            value.CurrentlyPressedDrawer                    = GetObject<HierarchyField>(new IntPtr(p + 0x1B0), ReversePrism.DataModels.HierarchyField.FromPointer); // 0x1B0 CurrentlyPressedDrawer      ( ModelClassType HierarchyField HierarchyField HierarchyField Pointer )
            value.PressedDrawerDraggedReferenceCreateTime   = GetSingle(new IntPtr(p + 0x1B8)); // 0x1B8 PressedDrawerDraggedReferenceCreateTime ( ModelPrimitiveType float float float Single )
            value.PressedDrawerActivePointer                = GetObject<PointerEventData>(new IntPtr(p + 0x1C0), ReversePrism.DataModels.PointerEventData.FromPointer); // 0x1C0 PressedDrawerActivePointer  ( ModelClassType PointerEventData PointerEventData PointerEventData Pointer )
            value.M_canvas                                  = GetObject<Canvas>(new IntPtr(p + 0x1C8), ReversePrism.DataModels.Canvas.FromPointer); // 0x1C8 M_canvas                    ( ModelClassType Canvas Canvas Canvas Pointer )
            value.M_autoScrollSpeed                         = GetSingle(new IntPtr(p + 0x1D0)); // 0x1D0 M_autoScrollSpeed           ( ModelPrimitiveType float float float Single )
            value.NullPointerEventData                      = GetObject<PointerEventData>(new IntPtr(p + 0x1D8), ReversePrism.DataModels.PointerEventData.FromPointer); // 0x1D8 NullPointerEventData        ( ModelClassType PointerEventData PointerEventData PointerEventData Pointer )
            value.OnSelectionChanged                        = GetObject<SelectionChangedDelegate>(new IntPtr(p + 0x1E0), ReversePrism.DataModels.SelectionChangedDelegate.FromPointer); // 0x1E0 OnSelectionChanged          ( ModelClassType SelectionChangedDelegate SelectionChangedDelegate SelectionChangedDelegate Pointer )
            value.OnItemDoubleClicked                       = GetObject<DoubleClickDelegate>(new IntPtr(p + 0x1E8), ReversePrism.DataModels.DoubleClickDelegate.FromPointer); // 0x1E8 OnItemDoubleClicked         ( ModelClassType DoubleClickDelegate DoubleClickDelegate DoubleClickDelegate Pointer )
            value.M_gameObjectDelegate                      = GetObject<GameObjectFilterDelegate>(new IntPtr(p + 0x1F0), ReversePrism.DataModels.GameObjectFilterDelegate.FromPointer); // 0x1F0 M_gameObjectDelegate        ( ModelClassType GameObjectFilterDelegate GameObjectFilterDelegate GameObjectFilterDelegate Pointer )

            return value;
        }
    }
}
