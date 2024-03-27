using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_ContainerStack                         Stack`1<IMGUIContainer> IL2CPP_TYPE_GENERICINST
    // 008 s_UIElementsCache                        Dictionary`2<int, Panel> IL2CPP_TYPE_GENERICINST
    // 010 S_EventInstance                          00018674CE30 ModelClassType Event Event Event Pointer
    // 018 EditorPlayModeTintColor                  0001865AB580 ModelEnumType Color Color Color Int32
    // 028 SingleLineHeight                         000186666530 ModelPrimitiveType float float float Single
    // 030 S_Instance                               0001866E67C0 ModelClassType UIElementsUtility UIElementsUtility UIElementsUtility Pointer
    // 038 S_PanelsIterationList                    000185CF7D88 ModelClassListType List`1<Panel> List`1<Panel> List<Panel> Pointer
    // 040 S_RepaintProfilerMarkerName              000186673B80 ModelPrimitiveType string string string String
    // 048 S_EventProfilerMarkerName                000186673B80 ModelPrimitiveType string string string String
    // 050 S_RepaintProfilerMarker                  0001865C9C30 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 058 S_EventProfilerMarker                    0001865C9C30 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    public partial class UIElementsUtility
    {
        public Event?                                   S_EventInstance                         { get; set; }
        public Color                                    EditorPlayModeTintColor                 { get; set; }
        public float                                    SingleLineHeight                        { get; set; }
        public UIElementsUtility?                       S_Instance                              { get; set; }
        public List<Panel>?                             S_PanelsIterationList                   { get; set; }
        public string                                   S_RepaintProfilerMarkerName             { get; set; }
        public string                                   S_EventProfilerMarkerName               { get; set; }
        public ProfilerMarker                           S_RepaintProfilerMarker                 { get; set; }
        public ProfilerMarker                           S_EventProfilerMarker                   { get; set; }

        public static UIElementsUtility? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIElementsUtility();

            value.S_EventInstance                           = GetObject<Event>(new IntPtr(p + 0x010), ReversePrism.DataModels.Event.FromPointer); // 027003F017F8 0x10 S_EventInstance             ( 00018674CE30 ModelClassType Event Event Event Pointer )
            value.EditorPlayModeTintColor                   = (Color)GetInt32(new IntPtr(p + 0x018)); // 027003F01818 0x18 EditorPlayModeTintColor     ( 0001865AB580 ModelEnumType Color Color Color Int32 )
            value.SingleLineHeight                          = GetSingle(new IntPtr(p + 0x028)); // 027003F01838 0x28 SingleLineHeight            ( 000186666530 ModelPrimitiveType float float float Single )
            value.S_Instance                                = GetObject<UIElementsUtility>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIElementsUtility.FromPointer); // 027003F01858 0x30 S_Instance                  ( 0001866E67C0 ModelClassType UIElementsUtility UIElementsUtility UIElementsUtility Pointer )
            value.S_PanelsIterationList                     = GetObjectList<Panel>(new IntPtr(p + 0x038), ReversePrism.DataModels.Panel.FromPointer); // 027003F01878 0x38 S_PanelsIterationList       ( 000185CF7D88 ModelClassListType List`1<Panel> List`1<Panel> List<Panel> Pointer )
            value.S_RepaintProfilerMarkerName               = GetString(new IntPtr(p + 0x040)); // 027003F01898 0x40 S_RepaintProfilerMarkerName ( 000186673B80 ModelPrimitiveType string string string String )
            value.S_EventProfilerMarkerName                 = GetString(new IntPtr(p + 0x048)); // 027003F018B8 0x48 S_EventProfilerMarkerName   ( 000186673B80 ModelPrimitiveType string string string String )
            value.S_RepaintProfilerMarker                   = (ProfilerMarker)GetInt32(new IntPtr(p + 0x050)); // 027003F018D8 0x50 S_RepaintProfilerMarker     ( 0001865C9C30 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.S_EventProfilerMarker                     = (ProfilerMarker)GetInt32(new IntPtr(p + 0x058)); // 027003F018F8 0x58 S_EventProfilerMarker       ( 0001865C9C30 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )

            return value;
        }
    }
}
