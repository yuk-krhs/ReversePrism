using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kEnableDebugBtn1                         string IL2CPP_TYPE_STRING
    // 000 kEnableDebugBtn2                         string IL2CPP_TYPE_STRING
    // 000 kDebugPreviousBtn                        string IL2CPP_TYPE_STRING
    // 000 kDebugNextBtn                            string IL2CPP_TYPE_STRING
    // 000 kValidateBtn                             string IL2CPP_TYPE_STRING
    // 000 kPersistentBtn                           string IL2CPP_TYPE_STRING
    // 000 kDPadVertical                            string IL2CPP_TYPE_STRING
    // 000 kDPadHorizontal                          string IL2CPP_TYPE_STRING
    // 000 kMultiplierBtn                           string IL2CPP_TYPE_STRING
    // 000 kResetBtn                                string IL2CPP_TYPE_STRING
    // 000 kEnableDebug                             string IL2CPP_TYPE_STRING
    // 010 M_DebugActions                           ModelClassListType DebugActionDesc[] DebugActionDesc[] List<DebugActionDesc> Pointer
    // 018 M_DebugActionStates                      ModelClassListType DebugActionState[] DebugActionState[] List<DebugActionState> Pointer
    // 020 DebugActionMap                           ModelClassType InputActionMap InputActionMap InputActionMap Pointer
    // 000 s_Instance                               Lazy`1<DebugManager> IL2CPP_TYPE_GENERICINST
    // 028 m_ReadOnlyPanels                         ReadOnlyCollection`1<Panel> IL2CPP_TYPE_GENERICINST
    // 030 M_Panels                                 ModelClassListType List`1<Panel> List`1<Panel> List<Panel> Pointer
    // 038 onDisplayRuntimeUIChanged                Action`1<bool> IL2CPP_TYPE_GENERICINST
    // 040 OnSetDirty                               ModelClassType Action Action Action Pointer
    // 048 ResetData                                ModelClassType Action Action Action Pointer
    // 050 RefreshEditorRequested                   ModelPrimitiveType bool bool bool Bool
    // 054 m_RequestedPanelIndex                    Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 060 M_Root                                   ModelClassType GameObject GameObject GameObject Pointer
    // 068 M_RootUICanvas                           ModelClassType DebugUIHandlerCanvas DebugUIHandlerCanvas DebugUIHandlerCanvas Pointer
    // 070 M_PersistentRoot                         ModelClassType GameObject GameObject GameObject Pointer
    // 078 M_RootUIPersistentCanvas                 ModelClassType DebugUIHandlerPersistentCanvas DebugUIHandlerPersistentCanvas DebugUIHandlerPersistentCanvas Pointer
    // 008 windowStateChanged                       Action`2<UIMode, bool> IL2CPP_TYPE_GENERICINST
    // 080 EditorUIState                            ModelClassType UIState UIState UIState Pointer
    // 088 M_EnableRuntimeUI                        ModelPrimitiveType bool bool bool Bool
    // 090 RuntimeUIState                           ModelClassType UIState UIState UIState Pointer
    public partial class DebugManager : DataModel
    {
        public List<DebugActionDesc>?                   M_DebugActions                          { get; set; }
        public List<DebugActionState>?                  M_DebugActionStates                     { get; set; }
        public InputActionMap?                          DebugActionMap                          { get; set; }
        public List<Panel>?                             M_Panels                                { get; set; }
        public Action?                                  OnSetDirty                              { get; set; }
        public Action?                                  ResetData                               { get; set; }
        public bool                                     RefreshEditorRequested                  { get; set; }
        public GameObject?                              M_Root                                  { get; set; }
        public DebugUIHandlerCanvas?                    M_RootUICanvas                          { get; set; }
        public GameObject?                              M_PersistentRoot                        { get; set; }
        public DebugUIHandlerPersistentCanvas?          M_RootUIPersistentCanvas                { get; set; }
        public UIState?                                 EditorUIState                           { get; set; }
        public bool                                     M_EnableRuntimeUI                       { get; set; }
        public UIState?                                 RuntimeUIState                          { get; set; }

        public static DebugManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugManager() { Pointer= p0 };

            value.M_DebugActions                            = GetObjectList<DebugActionDesc>(new IntPtr(p + 0x010), ReversePrism.DataModels.DebugActionDesc.FromPointer); // 0x10 M_DebugActions              ( ModelClassListType DebugActionDesc[] DebugActionDesc[] List<DebugActionDesc> Pointer )
            value.M_DebugActionStates                       = GetObjectList<DebugActionState>(new IntPtr(p + 0x018), ReversePrism.DataModels.DebugActionState.FromPointer); // 0x18 M_DebugActionStates         ( ModelClassListType DebugActionState[] DebugActionState[] List<DebugActionState> Pointer )
            value.DebugActionMap                            = GetObject<InputActionMap>(new IntPtr(p + 0x020), ReversePrism.DataModels.InputActionMap.FromPointer); // 0x20 DebugActionMap              ( ModelClassType InputActionMap InputActionMap InputActionMap Pointer )
            value.M_Panels                                  = GetObjectList<Panel>(new IntPtr(p + 0x030), ReversePrism.DataModels.Panel.FromPointer); // 0x30 M_Panels                    ( ModelClassListType List`1<Panel> List`1<Panel> List<Panel> Pointer )
            value.OnSetDirty                                = GetObject<Action>(new IntPtr(p + 0x040), ReversePrism.DataModels.Action.FromPointer); // 0x40 OnSetDirty                  ( ModelClassType Action Action Action Pointer )
            value.ResetData                                 = GetObject<Action>(new IntPtr(p + 0x048), ReversePrism.DataModels.Action.FromPointer); // 0x48 ResetData                   ( ModelClassType Action Action Action Pointer )
            value.RefreshEditorRequested                    = GetBool(new IntPtr(p + 0x050)); // 0x50 RefreshEditorRequested      ( ModelPrimitiveType bool bool bool Bool )
            value.M_Root                                    = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0x60 M_Root                      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.M_RootUICanvas                            = GetObject<DebugUIHandlerCanvas>(new IntPtr(p + 0x068), ReversePrism.DataModels.DebugUIHandlerCanvas.FromPointer); // 0x68 M_RootUICanvas              ( ModelClassType DebugUIHandlerCanvas DebugUIHandlerCanvas DebugUIHandlerCanvas Pointer )
            value.M_PersistentRoot                          = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 M_PersistentRoot            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.M_RootUIPersistentCanvas                  = GetObject<DebugUIHandlerPersistentCanvas>(new IntPtr(p + 0x078), ReversePrism.DataModels.DebugUIHandlerPersistentCanvas.FromPointer); // 0x78 M_RootUIPersistentCanvas    ( ModelClassType DebugUIHandlerPersistentCanvas DebugUIHandlerPersistentCanvas DebugUIHandlerPersistentCanvas Pointer )
            value.EditorUIState                             = GetObject<UIState>(new IntPtr(p + 0x080), ReversePrism.DataModels.UIState.FromPointer); // 0x80 EditorUIState               ( ModelClassType UIState UIState UIState Pointer )
            value.M_EnableRuntimeUI                         = GetBool(new IntPtr(p + 0x088)); // 0x88 M_EnableRuntimeUI           ( ModelPrimitiveType bool bool bool Bool )
            value.RuntimeUIState                            = GetObject<UIState>(new IntPtr(p + 0x090), ReversePrism.DataModels.UIState.FromPointer); // 0x90 RuntimeUIState              ( ModelClassType UIState UIState UIState Pointer )

            return value;
        }
    }
}
