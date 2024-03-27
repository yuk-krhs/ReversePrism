using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Name                                   000186671BA0 ModelPrimitiveType string string string String
    // 018 M_Id                                     000186671BA0 ModelPrimitiveType string string string String
    // 020 M_Asset                                  0001866F4E30 ModelClassType InputActionAsset InputActionAsset InputActionAsset Pointer
    // 028 M_Actions                                000185B8BA30 ModelClassListType InputAction[] InputAction[] List<InputAction> Pointer
    // 030 M_Bindings                               000185B8BFC0 ModelEnumListType InputBinding[] InputBinding[] List<InputBinding> Pointer
    // 038 M_BindingsForEachAction                  000185B8C0E0 ModelEnumListType InputBinding[] InputBinding[] List<InputBinding> Pointer
    // 040 M_ControlsForEachAction                  000185B8C790 ModelClassListType InputControl[] InputControl[] List<InputControl> Pointer
    // 048 M_EnabledActionsCount                    0001865F5530 ModelPrimitiveType int int int Int32
    // 050 M_SingletonAction                        0001865E8780 ModelClassType InputAction InputAction InputAction Pointer
    // 058 M_MapIndexInState                        0001865F5530 ModelPrimitiveType int int int Int32
    // 060 M_State                                  0001866F7680 ModelClassType InputActionState InputActionState InputActionState Pointer
    // 068 m_BindingMask                            Nullable`1<InputBinding> IL2CPP_TYPE_GENERICINST
    // 0C8 M_Flags                                  00018661F170 ModelEnumType Flags Flags Flags Int32
    // 0CC M_ParameterOverridesCount                0001865F5530 ModelPrimitiveType int int int Int32
    // 0D0 M_ParameterOverrides                     000185B85470 ModelEnumListType ParameterOverride[] ParameterOverride[] List<ParameterOverride> Pointer
    // 0D8 M_Devices                                00018661ECB0 ModelEnumType DeviceArray DeviceArray DeviceArray Int32
    // 0E8 m_ActionCallbacks                        CallbackArray`1<Action`1<CallbackContext>> IL2CPP_TYPE_GENERICINST
    // 138 m_ActionIndexByNameOrId                  Dictionary`2<string, int> IL2CPP_TYPE_GENERICINST
    // 000 s_DeferBindingResolution                 int IL2CPP_TYPE_I4
    public partial class InputActionMap
    {
        public string                                   M_Name                                  { get; set; }
        public string                                   M_Id                                    { get; set; }
        public InputActionAsset?                        M_Asset                                 { get; set; }
        public List<InputAction>?                       M_Actions                               { get; set; }
        public List<InputBinding>?                      M_Bindings                              { get; set; }
        public List<InputBinding>?                      M_BindingsForEachAction                 { get; set; }
        public List<InputControl>?                      M_ControlsForEachAction                 { get; set; }
        public int                                      M_EnabledActionsCount                   { get; set; }
        public InputAction?                             M_SingletonAction                       { get; set; }
        public int                                      M_MapIndexInState                       { get; set; }
        public InputActionState?                        M_State                                 { get; set; }
        public Flags                                    M_Flags                                 { get; set; }
        public int                                      M_ParameterOverridesCount               { get; set; }
        public List<ParameterOverride>?                 M_ParameterOverrides                    { get; set; }
        public DeviceArray                              M_Devices                               { get; set; }

        public static InputActionMap? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputActionMap();

            value.M_Name                                    = GetString(new IntPtr(p + 0x010)); // 0270D763BB28 0x10 M_Name                      ( 000186671BA0 ModelPrimitiveType string string string String )
            value.M_Id                                      = GetString(new IntPtr(p + 0x018)); // 0270D763BB48 0x18 M_Id                        ( 000186671BA0 ModelPrimitiveType string string string String )
            value.M_Asset                                   = GetObject<InputActionAsset>(new IntPtr(p + 0x020), ReversePrism.DataModels.InputActionAsset.FromPointer); // 0270D763BB68 0x20 M_Asset                     ( 0001866F4E30 ModelClassType InputActionAsset InputActionAsset InputActionAsset Pointer )
            value.M_Actions                                 = GetObjectList<InputAction>(new IntPtr(p + 0x028), ReversePrism.DataModels.InputAction.FromPointer); // 0270D763BB88 0x28 M_Actions                   ( 000185B8BA30 ModelClassListType InputAction[] InputAction[] List<InputAction> Pointer )
            value.M_Bindings                                = GetEnumList<InputBinding>(new IntPtr(p + 0x030)); // 0270D763BBA8 0x30 M_Bindings                  ( 000185B8BFC0 ModelEnumListType InputBinding[] InputBinding[] List<InputBinding> Pointer )
            value.M_BindingsForEachAction                   = GetEnumList<InputBinding>(new IntPtr(p + 0x038)); // 0270D763BBC8 0x38 M_BindingsForEachAction     ( 000185B8C0E0 ModelEnumListType InputBinding[] InputBinding[] List<InputBinding> Pointer )
            value.M_ControlsForEachAction                   = GetObjectList<InputControl>(new IntPtr(p + 0x040), ReversePrism.DataModels.InputControl.FromPointer); // 0270D763BBE8 0x40 M_ControlsForEachAction     ( 000185B8C790 ModelClassListType InputControl[] InputControl[] List<InputControl> Pointer )
            value.M_EnabledActionsCount                     = GetInt32(new IntPtr(p + 0x048)); // 0270D763BC08 0x48 M_EnabledActionsCount       ( 0001865F5530 ModelPrimitiveType int int int Int32 )
            value.M_SingletonAction                         = GetObject<InputAction>(new IntPtr(p + 0x050), ReversePrism.DataModels.InputAction.FromPointer); // 0270D763BC28 0x50 M_SingletonAction           ( 0001865E8780 ModelClassType InputAction InputAction InputAction Pointer )
            value.M_MapIndexInState                         = GetInt32(new IntPtr(p + 0x058)); // 0270D763BC48 0x58 M_MapIndexInState           ( 0001865F5530 ModelPrimitiveType int int int Int32 )
            value.M_State                                   = GetObject<InputActionState>(new IntPtr(p + 0x060), ReversePrism.DataModels.InputActionState.FromPointer); // 0270D763BC68 0x60 M_State                     ( 0001866F7680 ModelClassType InputActionState InputActionState InputActionState Pointer )
            value.M_Flags                                   = (Flags)GetInt32(new IntPtr(p + 0x0C8)); // 0270D763BCA8 0xC8 M_Flags                     ( 00018661F170 ModelEnumType Flags Flags Flags Int32 )
            value.M_ParameterOverridesCount                 = GetInt32(new IntPtr(p + 0x0CC)); // 0270D763BCC8 0xCC M_ParameterOverridesCount   ( 0001865F5530 ModelPrimitiveType int int int Int32 )
            value.M_ParameterOverrides                      = GetEnumList<ParameterOverride>(new IntPtr(p + 0x0D0)); // 0270D763BCE8 0xD0 M_ParameterOverrides        ( 000185B85470 ModelEnumListType ParameterOverride[] ParameterOverride[] List<ParameterOverride> Pointer )
            value.M_Devices                                 = (DeviceArray)GetInt32(new IntPtr(p + 0x0D8)); // 0270D763BD08 0xD8 M_Devices                   ( 00018661ECB0 ModelEnumType DeviceArray DeviceArray DeviceArray Int32 )

            return value;
        }
    }
}
