using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 onCreatePanel                            Action`1<BaseRuntimePanel> IL2CPP_TYPE_GENERICINST
    // 008 s_RegisteredPlayerloopCallback           bool IL2CPP_TYPE_BOOLEAN
    // 010 S_SortedRuntimePanels                    ModelClassListType List`1<Panel> List`1<Panel> List<Panel> Pointer
    // 018 S_PanelOrderingDirty                     ModelPrimitiveType bool bool bool Bool
    // 01C S_ResolvedSortingIndexMax                ModelPrimitiveType int int int Int32
    // 020 S_RepaintProfilerMarkerName              ModelPrimitiveType string string string String
    // 028 S_RepaintProfilerMarker                  ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 030 CurrentOverlayIndex                      ModelPrimitiveType int int int Int32
    // 038 ActiveEventSystem                        ModelClassType Object Object Object Pointer
    // 040 S_DefaultEventSystem                     ModelClassType DefaultEventSystem DefaultEventSystem DefaultEventSystem Pointer
    // 048 S_PotentiallyEmptyPanelSettings          ModelClassListType List`1<PanelSettings> List`1<PanelSettings> List<PanelSettings> Pointer
    public partial class UIElementsRuntimeUtility : DataModel
    {
        public List<Panel>?                             S_SortedRuntimePanels                   { get; set; }
        public bool                                     S_PanelOrderingDirty                    { get; set; }
        public int                                      S_ResolvedSortingIndexMax               { get; set; }
        public string                                   S_RepaintProfilerMarkerName             { get; set; }
        public ProfilerMarker                           S_RepaintProfilerMarker                 { get; set; }
        public int                                      CurrentOverlayIndex                     { get; set; }
        public Object?                                  ActiveEventSystem                       { get; set; }
        public DefaultEventSystem?                      S_DefaultEventSystem                    { get; set; }
        public List<PanelSettings>?                     S_PotentiallyEmptyPanelSettings         { get; set; }

        public static UIElementsRuntimeUtility? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIElementsRuntimeUtility() { Pointer= p0 };

            value.S_SortedRuntimePanels                     = GetObjectList<Panel>(new IntPtr(p + 0x010), ReversePrism.DataModels.Panel.FromPointer); // 0x10 S_SortedRuntimePanels       ( ModelClassListType List`1<Panel> List`1<Panel> List<Panel> Pointer )
            value.S_PanelOrderingDirty                      = GetBool(new IntPtr(p + 0x018)); // 0x18 S_PanelOrderingDirty        ( ModelPrimitiveType bool bool bool Bool )
            value.S_ResolvedSortingIndexMax                 = GetInt32(new IntPtr(p + 0x01C)); // 0x1C S_ResolvedSortingIndexMax   ( ModelPrimitiveType int int int Int32 )
            value.S_RepaintProfilerMarkerName               = GetString(new IntPtr(p + 0x020)); // 0x20 S_RepaintProfilerMarkerName ( ModelPrimitiveType string string string String )
            value.S_RepaintProfilerMarker                   = (ProfilerMarker)GetInt32(new IntPtr(p + 0x028)); // 0x28 S_RepaintProfilerMarker     ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.CurrentOverlayIndex                       = GetInt32(new IntPtr(p + 0x030)); // 0x30 CurrentOverlayIndex         ( ModelPrimitiveType int int int Int32 )
            value.ActiveEventSystem                         = GetObject<Object>(new IntPtr(p + 0x038), ReversePrism.DataModels.Object.FromPointer); // 0x38 ActiveEventSystem           ( ModelClassType Object Object Object Pointer )
            value.S_DefaultEventSystem                      = GetObject<DefaultEventSystem>(new IntPtr(p + 0x040), ReversePrism.DataModels.DefaultEventSystem.FromPointer); // 0x40 S_DefaultEventSystem        ( ModelClassType DefaultEventSystem DefaultEventSystem DefaultEventSystem Pointer )
            value.S_PotentiallyEmptyPanelSettings           = GetObjectList<PanelSettings>(new IntPtr(p + 0x048), ReversePrism.DataModels.PanelSettings.FromPointer); // 0x48 S_PotentiallyEmptyPanelSettings ( ModelClassListType List`1<PanelSettings> List`1<PanelSettings> List<PanelSettings> Pointer )

            return value;
        }
    }
}
