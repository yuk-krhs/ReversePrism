using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_SystemInputModules                     000185CCE988 ModelClassListType List`1<BaseInputModule> List`1<BaseInputModule> List<BaseInputModule> Pointer
    // 028 M_CurrentInputModule                     00018673F7E0 ModelClassType BaseInputModule BaseInputModule BaseInputModule Pointer
    // 000 m_EventSystems                           List`1<EventSystem> IL2CPP_TYPE_GENERICINST
    // 030 M_FirstSelected                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 M_sendNavigationEvents                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03C M_DragThreshold                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 040 M_CurrentSelected                        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 M_HasFocus                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 049 M_SelectionGuard                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 050 M_DummyData                              00018673DDA0 ModelClassType BaseEventData BaseEventData BaseEventData Pointer
    // 008 s_RaycastComparer                        Comparison`1<RaycastResult> IL2CPP_TYPE_GENERICINST
    // 010 S_UIToolkitOverride                      00018663D370 ModelEnumType UIToolkitOverrideConfig UIToolkitOverrideConfig UIToolkitOverrideConfig Int32
    // 058 M_Started                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 059 M_IsTrackingUIToolkitPanels              000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class EventSystem
    {
        public List<BaseInputModule>?                   M_SystemInputModules                    { get; set; }
        public BaseInputModule?                         M_CurrentInputModule                    { get; set; }
        public GameObject?                              M_FirstSelected                         { get; set; }
        public bool                                     M_sendNavigationEvents                  { get; set; }
        public int                                      M_DragThreshold                         { get; set; }
        public GameObject?                              M_CurrentSelected                       { get; set; }
        public bool                                     M_HasFocus                              { get; set; }
        public bool                                     M_SelectionGuard                        { get; set; }
        public BaseEventData?                           M_DummyData                             { get; set; }
        public UIToolkitOverrideConfig                  S_UIToolkitOverride                     { get; set; }
        public bool                                     M_Started                               { get; set; }
        public bool                                     M_IsTrackingUIToolkitPanels             { get; set; }

        public static EventSystem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventSystem();

            value.M_SystemInputModules                      = GetObjectList<BaseInputModule>(new IntPtr(p + 0x020), ReversePrism.DataModels.BaseInputModule.FromPointer); // 027003E88E10 0x20 M_SystemInputModules        ( 000185CCE988 ModelClassListType List`1<BaseInputModule> List`1<BaseInputModule> List<BaseInputModule> Pointer )
            value.M_CurrentInputModule                      = GetObject<BaseInputModule>(new IntPtr(p + 0x028), ReversePrism.DataModels.BaseInputModule.FromPointer); // 027003E88E30 0x28 M_CurrentInputModule        ( 00018673F7E0 ModelClassType BaseInputModule BaseInputModule BaseInputModule Pointer )
            value.M_FirstSelected                           = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 027003E88E70 0x30 M_FirstSelected             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.M_sendNavigationEvents                    = GetBool(new IntPtr(p + 0x038)); // 027003E88E90 0x38 M_sendNavigationEvents      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_DragThreshold                           = GetInt32(new IntPtr(p + 0x03C)); // 027003E88EB0 0x3C M_DragThreshold             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_CurrentSelected                         = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 027003E88ED0 0x40 M_CurrentSelected           ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.M_HasFocus                                = GetBool(new IntPtr(p + 0x048)); // 027003E88EF0 0x48 M_HasFocus                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_SelectionGuard                          = GetBool(new IntPtr(p + 0x049)); // 027003E88F10 0x49 M_SelectionGuard            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_DummyData                               = GetObject<BaseEventData>(new IntPtr(p + 0x050), ReversePrism.DataModels.BaseEventData.FromPointer); // 027003E88F30 0x50 M_DummyData                 ( 00018673DDA0 ModelClassType BaseEventData BaseEventData BaseEventData Pointer )
            value.S_UIToolkitOverride                       = (UIToolkitOverrideConfig)GetInt32(new IntPtr(p + 0x010)); // 027003E88F70 0x10 S_UIToolkitOverride         ( 00018663D370 ModelEnumType UIToolkitOverrideConfig UIToolkitOverrideConfig UIToolkitOverrideConfig Int32 )
            value.M_Started                                 = GetBool(new IntPtr(p + 0x058)); // 027003E88F90 0x58 M_Started                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_IsTrackingUIToolkitPanels               = GetBool(new IntPtr(p + 0x059)); // 027003E88FB0 0x59 M_IsTrackingUIToolkitPanels ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
