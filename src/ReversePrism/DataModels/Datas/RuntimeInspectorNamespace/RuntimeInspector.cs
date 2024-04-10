using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 POOL_OBJECT_NAME                         string IL2CPP_TYPE_STRING
    // 030 M_refreshInterval                        0001866656B0 ModelPrimitiveType float float float Single
    // 034 NextRefreshTime                          0001866656B0 ModelPrimitiveType float float float Single
    // 038 M_exposeFields                           0001866EDE50 ModelEnumType VariableVisibility VariableVisibility VariableVisibility Int32
    // 03C M_exposeProperties                       0001866EDE50 ModelEnumType VariableVisibility VariableVisibility VariableVisibility Int32
    // 040 M_arrayIndicesStartAtOne                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 041 M_useTitleCaseNaming                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 042 M_showAddComponentButton                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 043 M_showRemoveComponentButton              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 044 M_showTooltips                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 048 M_tooltipDelay                           0001866656B0 ModelPrimitiveType float float float Single
    // 050 TooltipListener                          00018668C630 ModelClassType TooltipListener TooltipListener TooltipListener Pointer
    // 058 M_nestLimit                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 05C M_inspectedObjectHeaderVisibility        0001866ED1E0 ModelEnumType HeaderVisibility HeaderVisibility HeaderVisibility Int32
    // 060 PoolCapacity                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 068 PoolParent                               0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 070 M_connectedHierarchy                     000186699A60 ModelClassType RuntimeHierarchy RuntimeHierarchy RuntimeHierarchy Pointer
    // 078 Settings                                 000185CA1C48 ModelClassListType RuntimeInspectorSettings[] RuntimeInspectorSettings[] List<RuntimeInspectorSettings> Pointer
    // 080 M_isLocked                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 088 ScrollView                               0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 090 DrawArea                                 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 098 Background                               0001866CCDB0 ModelClassType Image Image Image Pointer
    // 0A0 Scrollbar                                0001866CCDB0 ModelClassType Image Image Image Pointer
    // 000 aliveInspectors                          int IL2CPP_TYPE_I4
    // 0A8 Initialized                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0B0 typeToDrawers                            Dictionary`2<Type, InspectorField[]> IL2CPP_TYPE_GENERICINST
    // 0B8 typeToReferenceDrawers                   Dictionary`2<Type, InspectorField[]> IL2CPP_TYPE_GENERICINST
    // 0C0 EligibleDrawers                          000185CECA88 ModelClassListType List`1<InspectorField> List`1<InspectorField> List<InspectorField> Pointer
    // 008 drawersPool                              Dictionary`2<Type, List`1<InspectorField>> IL2CPP_TYPE_GENERICINST
    // 0C8 HiddenVariables                          000185D1A9D8 ModelClassListType List`1<VariableSet> List`1<VariableSet> List<VariableSet> Pointer
    // 0D0 ExposedVariables                         000185D1A9D8 ModelClassListType List`1<VariableSet> List`1<VariableSet> List<VariableSet> Pointer
    // 0D8 CurrentDrawer                            00018670A940 ModelClassType InspectorField InspectorField InspectorField Pointer
    // 0E0 InspectLock                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0E1 IsDirty                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0E8 m_inspectedObject                        <object> IL2CPP_TYPE_OBJECT
    // 0F0 M_canvas                                 00018653FDA0 ModelClassType Canvas Canvas Canvas Pointer
    // 0F8 NullPointerEventData                     000186642240 ModelClassType PointerEventData PointerEventData PointerEventData Pointer
    // 100 OnInspectedObjectChanging                0001866ED990 ModelClassType InspectedObjectChangingDelegate InspectedObjectChangingDelegate InspectedObjectChangingDelegate Pointer
    // 108 M_componentFilter                        0001866ECD20 ModelClassType ComponentFilterDelegate ComponentFilterDelegate ComponentFilterDelegate Pointer
    public partial class RuntimeInspector : DataModel
    {
        public float                                    M_refreshInterval                       { get; set; }
        public float                                    NextRefreshTime                         { get; set; }
        public VariableVisibility                       M_exposeFields                          { get; set; }
        public VariableVisibility                       M_exposeProperties                      { get; set; }
        public bool                                     M_arrayIndicesStartAtOne                { get; set; }
        public bool                                     M_useTitleCaseNaming                    { get; set; }
        public bool                                     M_showAddComponentButton                { get; set; }
        public bool                                     M_showRemoveComponentButton             { get; set; }
        public bool                                     M_showTooltips                          { get; set; }
        public float                                    M_tooltipDelay                          { get; set; }
        public TooltipListener?                         TooltipListener                         { get; set; }
        public int                                      M_nestLimit                             { get; set; }
        public HeaderVisibility                         M_inspectedObjectHeaderVisibility       { get; set; }
        public int                                      PoolCapacity                            { get; set; }
        public Transform?                               PoolParent                              { get; set; }
        public RuntimeHierarchy?                        M_connectedHierarchy                    { get; set; }
        public List<RuntimeInspectorSettings>?          Settings                                { get; set; }
        public bool                                     M_isLocked                              { get; set; }
        public ScrollRect?                              ScrollView                              { get; set; }
        public RectTransform?                           DrawArea                                { get; set; }
        public Image?                                   Background                              { get; set; }
        public Image?                                   Scrollbar                               { get; set; }
        public bool                                     Initialized                             { get; set; }
        public List<InspectorField>?                    EligibleDrawers                         { get; set; }
        public List<VariableSet>?                       HiddenVariables                         { get; set; }
        public List<VariableSet>?                       ExposedVariables                        { get; set; }
        public InspectorField?                          CurrentDrawer                           { get; set; }
        public bool                                     InspectLock                             { get; set; }
        public bool                                     IsDirty                                 { get; set; }
        public Canvas?                                  M_canvas                                { get; set; }
        public PointerEventData?                        NullPointerEventData                    { get; set; }
        public InspectedObjectChangingDelegate?         OnInspectedObjectChanging               { get; set; }
        public ComponentFilterDelegate?                 M_componentFilter                       { get; set; }

        public static RuntimeInspector? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RuntimeInspector() { Pointer= p0 };

            value.M_refreshInterval                         = GetSingle(new IntPtr(p + 0x030)); // 02466B1E3840 0x30 M_refreshInterval           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.NextRefreshTime                           = GetSingle(new IntPtr(p + 0x034)); // 02466B1E3860 0x34 NextRefreshTime             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_exposeFields                            = (VariableVisibility)GetInt32(new IntPtr(p + 0x038)); // 02466B1E3880 0x38 M_exposeFields              ( 0001866EDE50 ModelEnumType VariableVisibility VariableVisibility VariableVisibility Int32 )
            value.M_exposeProperties                        = (VariableVisibility)GetInt32(new IntPtr(p + 0x03C)); // 02466B1E38A0 0x3C M_exposeProperties          ( 0001866EDE50 ModelEnumType VariableVisibility VariableVisibility VariableVisibility Int32 )
            value.M_arrayIndicesStartAtOne                  = GetBool(new IntPtr(p + 0x040)); // 02466B1E38C0 0x40 M_arrayIndicesStartAtOne    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_useTitleCaseNaming                      = GetBool(new IntPtr(p + 0x041)); // 02466B1E38E0 0x41 M_useTitleCaseNaming        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_showAddComponentButton                  = GetBool(new IntPtr(p + 0x042)); // 02466B1E3900 0x42 M_showAddComponentButton    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_showRemoveComponentButton               = GetBool(new IntPtr(p + 0x043)); // 02466B1E3920 0x43 M_showRemoveComponentButton ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_showTooltips                            = GetBool(new IntPtr(p + 0x044)); // 02466B1E3940 0x44 M_showTooltips              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_tooltipDelay                            = GetSingle(new IntPtr(p + 0x048)); // 02466B1E3960 0x48 M_tooltipDelay              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.TooltipListener                           = GetObject<TooltipListener>(new IntPtr(p + 0x050), ReversePrism.DataModels.TooltipListener.FromPointer); // 02466B1E3980 0x50 TooltipListener             ( 00018668C630 ModelClassType TooltipListener TooltipListener TooltipListener Pointer )
            value.M_nestLimit                               = GetInt32(new IntPtr(p + 0x058)); // 02466B1E39A0 0x58 M_nestLimit                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_inspectedObjectHeaderVisibility         = (HeaderVisibility)GetInt32(new IntPtr(p + 0x05C)); // 02466B1E39C0 0x5C M_inspectedObjectHeaderVisibility ( 0001866ED1E0 ModelEnumType HeaderVisibility HeaderVisibility HeaderVisibility Int32 )
            value.PoolCapacity                              = GetInt32(new IntPtr(p + 0x060)); // 02466B1E39E0 0x60 PoolCapacity                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PoolParent                                = GetObject<Transform>(new IntPtr(p + 0x068), ReversePrism.DataModels.Transform.FromPointer); // 02466B1E3A00 0x68 PoolParent                  ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.M_connectedHierarchy                      = GetObject<RuntimeHierarchy>(new IntPtr(p + 0x070), ReversePrism.DataModels.RuntimeHierarchy.FromPointer); // 02466B1E3A20 0x70 M_connectedHierarchy        ( 000186699A60 ModelClassType RuntimeHierarchy RuntimeHierarchy RuntimeHierarchy Pointer )
            value.Settings                                  = GetObjectList<RuntimeInspectorSettings>(new IntPtr(p + 0x078), ReversePrism.DataModels.RuntimeInspectorSettings.FromPointer); // 02466B1E3A40 0x78 Settings                    ( 000185CA1C48 ModelClassListType RuntimeInspectorSettings[] RuntimeInspectorSettings[] List<RuntimeInspectorSettings> Pointer )
            value.M_isLocked                                = GetBool(new IntPtr(p + 0x080)); // 02466B1E3A60 0x80 M_isLocked                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ScrollView                                = GetObject<ScrollRect>(new IntPtr(p + 0x088), ReversePrism.DataModels.ScrollRect.FromPointer); // 02466B1E3A80 0x88 ScrollView                  ( 0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.DrawArea                                  = GetObject<RectTransform>(new IntPtr(p + 0x090), ReversePrism.DataModels.RectTransform.FromPointer); // 02466B1E3AA0 0x90 DrawArea                    ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.Background                                = GetObject<Image>(new IntPtr(p + 0x098), ReversePrism.DataModels.Image.FromPointer); // 02466B1E3AC0 0x98 Background                  ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.Scrollbar                                 = GetObject<Image>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Image.FromPointer); // 02466B1E3AE0 0xA0 Scrollbar                   ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.Initialized                               = GetBool(new IntPtr(p + 0x0A8)); // 02466B1E3B20 0xA8 Initialized                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.EligibleDrawers                           = GetObjectList<InspectorField>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.InspectorField.FromPointer); // 02466B1E3B80 0xC0 EligibleDrawers             ( 000185CECA88 ModelClassListType List`1<InspectorField> List`1<InspectorField> List<InspectorField> Pointer )
            value.HiddenVariables                           = GetObjectList<VariableSet>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.VariableSet.FromPointer); // 02466B1E3BC0 0xC8 HiddenVariables             ( 000185D1A9D8 ModelClassListType List`1<VariableSet> List`1<VariableSet> List<VariableSet> Pointer )
            value.ExposedVariables                          = GetObjectList<VariableSet>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.VariableSet.FromPointer); // 02466B1E3BE0 0xD0 ExposedVariables            ( 000185D1A9D8 ModelClassListType List`1<VariableSet> List`1<VariableSet> List<VariableSet> Pointer )
            value.CurrentDrawer                             = GetObject<InspectorField>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.InspectorField.FromPointer); // 02466B1E3C00 0xD8 CurrentDrawer               ( 00018670A940 ModelClassType InspectorField InspectorField InspectorField Pointer )
            value.InspectLock                               = GetBool(new IntPtr(p + 0x0E0)); // 02466B1E3C20 0xE0 InspectLock                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsDirty                                   = GetBool(new IntPtr(p + 0x0E1)); // 02466B1E3C40 0xE1 IsDirty                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_canvas                                  = GetObject<Canvas>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.Canvas.FromPointer); // 02466B1E3C80 0xF0 M_canvas                    ( 00018653FDA0 ModelClassType Canvas Canvas Canvas Pointer )
            value.NullPointerEventData                      = GetObject<PointerEventData>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.PointerEventData.FromPointer); // 02466B1E3CA0 0xF8 NullPointerEventData        ( 000186642240 ModelClassType PointerEventData PointerEventData PointerEventData Pointer )
            value.OnInspectedObjectChanging                 = GetObject<InspectedObjectChangingDelegate>(new IntPtr(p + 0x100), ReversePrism.DataModels.InspectedObjectChangingDelegate.FromPointer); // 02466B1E3CC0 0x100 OnInspectedObjectChanging   ( 0001866ED990 ModelClassType InspectedObjectChangingDelegate InspectedObjectChangingDelegate InspectedObjectChangingDelegate Pointer )
            value.M_componentFilter                         = GetObject<ComponentFilterDelegate>(new IntPtr(p + 0x108), ReversePrism.DataModels.ComponentFilterDelegate.FromPointer); // 02466B1E3CE0 0x108 M_componentFilter           ( 0001866ECD20 ModelClassType ComponentFilterDelegate ComponentFilterDelegate ComponentFilterDelegate Pointer )

            return value;
        }
    }
}
