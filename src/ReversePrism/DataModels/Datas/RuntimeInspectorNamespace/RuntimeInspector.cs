using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 POOL_OBJECT_NAME                         string IL2CPP_TYPE_STRING
    // 030 M_refreshInterval                        ModelPrimitiveType float float float Single
    // 034 NextRefreshTime                          ModelPrimitiveType float float float Single
    // 038 M_exposeFields                           ModelEnumType VariableVisibility VariableVisibility VariableVisibility Int32
    // 03C M_exposeProperties                       ModelEnumType VariableVisibility VariableVisibility VariableVisibility Int32
    // 040 M_arrayIndicesStartAtOne                 ModelPrimitiveType bool bool bool Bool
    // 041 M_useTitleCaseNaming                     ModelPrimitiveType bool bool bool Bool
    // 042 M_showAddComponentButton                 ModelPrimitiveType bool bool bool Bool
    // 043 M_showRemoveComponentButton              ModelPrimitiveType bool bool bool Bool
    // 044 M_showTooltips                           ModelPrimitiveType bool bool bool Bool
    // 048 M_tooltipDelay                           ModelPrimitiveType float float float Single
    // 050 TooltipListener                          ModelClassType TooltipListener TooltipListener TooltipListener Pointer
    // 058 M_nestLimit                              ModelPrimitiveType int int int Int32
    // 05C M_inspectedObjectHeaderVisibility        ModelEnumType HeaderVisibility HeaderVisibility HeaderVisibility Int32
    // 060 PoolCapacity                             ModelPrimitiveType int int int Int32
    // 068 PoolParent                               ModelClassType Transform Transform Transform Pointer
    // 070 M_connectedHierarchy                     ModelClassType RuntimeHierarchy RuntimeHierarchy RuntimeHierarchy Pointer
    // 078 Settings                                 ModelClassListType RuntimeInspectorSettings[] RuntimeInspectorSettings[] List<RuntimeInspectorSettings> Pointer
    // 080 M_isLocked                               ModelPrimitiveType bool bool bool Bool
    // 088 ScrollView                               ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 090 DrawArea                                 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 098 Background                               ModelClassType Image Image Image Pointer
    // 0A0 Scrollbar                                ModelClassType Image Image Image Pointer
    // 000 aliveInspectors                          int IL2CPP_TYPE_I4
    // 0A8 Initialized                              ModelPrimitiveType bool bool bool Bool
    // 0B0 typeToDrawers                            Dictionary`2<Type, InspectorField[]> IL2CPP_TYPE_GENERICINST
    // 0B8 typeToReferenceDrawers                   Dictionary`2<Type, InspectorField[]> IL2CPP_TYPE_GENERICINST
    // 0C0 EligibleDrawers                          ModelClassListType List`1<InspectorField> List`1<InspectorField> List<InspectorField> Pointer
    // 008 drawersPool                              Dictionary`2<Type, List`1<InspectorField>> IL2CPP_TYPE_GENERICINST
    // 0C8 HiddenVariables                          ModelClassListType List`1<VariableSet> List`1<VariableSet> List<VariableSet> Pointer
    // 0D0 ExposedVariables                         ModelClassListType List`1<VariableSet> List`1<VariableSet> List<VariableSet> Pointer
    // 0D8 CurrentDrawer                            ModelClassType InspectorField InspectorField InspectorField Pointer
    // 0E0 InspectLock                              ModelPrimitiveType bool bool bool Bool
    // 0E1 IsDirty                                  ModelPrimitiveType bool bool bool Bool
    // 0E8 m_inspectedObject                        <object> IL2CPP_TYPE_OBJECT
    // 0F0 M_canvas                                 ModelClassType Canvas Canvas Canvas Pointer
    // 0F8 NullPointerEventData                     ModelClassType PointerEventData PointerEventData PointerEventData Pointer
    // 100 OnInspectedObjectChanging                ModelClassType InspectedObjectChangingDelegate InspectedObjectChangingDelegate InspectedObjectChangingDelegate Pointer
    // 108 M_componentFilter                        ModelClassType ComponentFilterDelegate ComponentFilterDelegate ComponentFilterDelegate Pointer
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

            value.M_refreshInterval                         = GetSingle(new IntPtr(p + 0x030)); // 0x30 M_refreshInterval           ( ModelPrimitiveType float float float Single )
            value.NextRefreshTime                           = GetSingle(new IntPtr(p + 0x034)); // 0x34 NextRefreshTime             ( ModelPrimitiveType float float float Single )
            value.M_exposeFields                            = (VariableVisibility)GetInt32(new IntPtr(p + 0x038)); // 0x38 M_exposeFields              ( ModelEnumType VariableVisibility VariableVisibility VariableVisibility Int32 )
            value.M_exposeProperties                        = (VariableVisibility)GetInt32(new IntPtr(p + 0x03C)); // 0x3C M_exposeProperties          ( ModelEnumType VariableVisibility VariableVisibility VariableVisibility Int32 )
            value.M_arrayIndicesStartAtOne                  = GetBool(new IntPtr(p + 0x040)); // 0x40 M_arrayIndicesStartAtOne    ( ModelPrimitiveType bool bool bool Bool )
            value.M_useTitleCaseNaming                      = GetBool(new IntPtr(p + 0x041)); // 0x41 M_useTitleCaseNaming        ( ModelPrimitiveType bool bool bool Bool )
            value.M_showAddComponentButton                  = GetBool(new IntPtr(p + 0x042)); // 0x42 M_showAddComponentButton    ( ModelPrimitiveType bool bool bool Bool )
            value.M_showRemoveComponentButton               = GetBool(new IntPtr(p + 0x043)); // 0x43 M_showRemoveComponentButton ( ModelPrimitiveType bool bool bool Bool )
            value.M_showTooltips                            = GetBool(new IntPtr(p + 0x044)); // 0x44 M_showTooltips              ( ModelPrimitiveType bool bool bool Bool )
            value.M_tooltipDelay                            = GetSingle(new IntPtr(p + 0x048)); // 0x48 M_tooltipDelay              ( ModelPrimitiveType float float float Single )
            value.TooltipListener                           = GetObject<TooltipListener>(new IntPtr(p + 0x050), ReversePrism.DataModels.TooltipListener.FromPointer); // 0x50 TooltipListener             ( ModelClassType TooltipListener TooltipListener TooltipListener Pointer )
            value.M_nestLimit                               = GetInt32(new IntPtr(p + 0x058)); // 0x58 M_nestLimit                 ( ModelPrimitiveType int int int Int32 )
            value.M_inspectedObjectHeaderVisibility         = (HeaderVisibility)GetInt32(new IntPtr(p + 0x05C)); // 0x5C M_inspectedObjectHeaderVisibility ( ModelEnumType HeaderVisibility HeaderVisibility HeaderVisibility Int32 )
            value.PoolCapacity                              = GetInt32(new IntPtr(p + 0x060)); // 0x60 PoolCapacity                ( ModelPrimitiveType int int int Int32 )
            value.PoolParent                                = GetObject<Transform>(new IntPtr(p + 0x068), ReversePrism.DataModels.Transform.FromPointer); // 0x68 PoolParent                  ( ModelClassType Transform Transform Transform Pointer )
            value.M_connectedHierarchy                      = GetObject<RuntimeHierarchy>(new IntPtr(p + 0x070), ReversePrism.DataModels.RuntimeHierarchy.FromPointer); // 0x70 M_connectedHierarchy        ( ModelClassType RuntimeHierarchy RuntimeHierarchy RuntimeHierarchy Pointer )
            value.Settings                                  = GetObjectList<RuntimeInspectorSettings>(new IntPtr(p + 0x078), ReversePrism.DataModels.RuntimeInspectorSettings.FromPointer); // 0x78 Settings                    ( ModelClassListType RuntimeInspectorSettings[] RuntimeInspectorSettings[] List<RuntimeInspectorSettings> Pointer )
            value.M_isLocked                                = GetBool(new IntPtr(p + 0x080)); // 0x80 M_isLocked                  ( ModelPrimitiveType bool bool bool Bool )
            value.ScrollView                                = GetObject<ScrollRect>(new IntPtr(p + 0x088), ReversePrism.DataModels.ScrollRect.FromPointer); // 0x88 ScrollView                  ( ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.DrawArea                                  = GetObject<RectTransform>(new IntPtr(p + 0x090), ReversePrism.DataModels.RectTransform.FromPointer); // 0x90 DrawArea                    ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.Background                                = GetObject<Image>(new IntPtr(p + 0x098), ReversePrism.DataModels.Image.FromPointer); // 0x98 Background                  ( ModelClassType Image Image Image Pointer )
            value.Scrollbar                                 = GetObject<Image>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Image.FromPointer); // 0xA0 Scrollbar                   ( ModelClassType Image Image Image Pointer )
            value.Initialized                               = GetBool(new IntPtr(p + 0x0A8)); // 0xA8 Initialized                 ( ModelPrimitiveType bool bool bool Bool )
            value.EligibleDrawers                           = GetObjectList<InspectorField>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.InspectorField.FromPointer); // 0xC0 EligibleDrawers             ( ModelClassListType List`1<InspectorField> List`1<InspectorField> List<InspectorField> Pointer )
            value.HiddenVariables                           = GetObjectList<VariableSet>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.VariableSet.FromPointer); // 0xC8 HiddenVariables             ( ModelClassListType List`1<VariableSet> List`1<VariableSet> List<VariableSet> Pointer )
            value.ExposedVariables                          = GetObjectList<VariableSet>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.VariableSet.FromPointer); // 0xD0 ExposedVariables            ( ModelClassListType List`1<VariableSet> List`1<VariableSet> List<VariableSet> Pointer )
            value.CurrentDrawer                             = GetObject<InspectorField>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.InspectorField.FromPointer); // 0xD8 CurrentDrawer               ( ModelClassType InspectorField InspectorField InspectorField Pointer )
            value.InspectLock                               = GetBool(new IntPtr(p + 0x0E0)); // 0xE0 InspectLock                 ( ModelPrimitiveType bool bool bool Bool )
            value.IsDirty                                   = GetBool(new IntPtr(p + 0x0E1)); // 0xE1 IsDirty                     ( ModelPrimitiveType bool bool bool Bool )
            value.M_canvas                                  = GetObject<Canvas>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.Canvas.FromPointer); // 0xF0 M_canvas                    ( ModelClassType Canvas Canvas Canvas Pointer )
            value.NullPointerEventData                      = GetObject<PointerEventData>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.PointerEventData.FromPointer); // 0xF8 NullPointerEventData        ( ModelClassType PointerEventData PointerEventData PointerEventData Pointer )
            value.OnInspectedObjectChanging                 = GetObject<InspectedObjectChangingDelegate>(new IntPtr(p + 0x100), ReversePrism.DataModels.InspectedObjectChangingDelegate.FromPointer); // 0x100 OnInspectedObjectChanging   ( ModelClassType InspectedObjectChangingDelegate InspectedObjectChangingDelegate InspectedObjectChangingDelegate Pointer )
            value.M_componentFilter                         = GetObject<ComponentFilterDelegate>(new IntPtr(p + 0x108), ReversePrism.DataModels.ComponentFilterDelegate.FromPointer); // 0x108 M_componentFilter           ( ModelClassType ComponentFilterDelegate ComponentFilterDelegate ComponentFilterDelegate Pointer )

            return value;
        }
    }
}
