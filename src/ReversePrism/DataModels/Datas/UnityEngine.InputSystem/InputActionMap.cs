using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Name                                   ModelPrimitiveType string string string String
    // 018 M_Id                                     ModelPrimitiveType string string string String
    // 020 M_Asset                                  ModelClassType InputActionAsset InputActionAsset InputActionAsset Pointer
    // 028 M_Actions                                ModelClassListType InputAction[] InputAction[] List<InputAction> Pointer
    // 030 M_Bindings                               ModelEnumListType InputBinding[] InputBinding[] List<InputBinding> Pointer
    // 038 M_BindingsForEachAction                  ModelEnumListType InputBinding[] InputBinding[] List<InputBinding> Pointer
    // 040 M_ControlsForEachAction                  ModelClassListType InputControl[] InputControl[] List<InputControl> Pointer
    // 048 M_EnabledActionsCount                    ModelPrimitiveType int int int Int32
    // 050 M_SingletonAction                        ModelClassType InputAction InputAction InputAction Pointer
    // 058 M_MapIndexInState                        ModelPrimitiveType int int int Int32
    // 060 M_State                                  ModelClassType InputActionState InputActionState InputActionState Pointer
    // 068 m_BindingMask                            Nullable`1<InputBinding> IL2CPP_TYPE_GENERICINST
    // 0C8 M_Flags                                  ModelEnumType Flags Flags Flags Int32
    // 0CC M_ParameterOverridesCount                ModelPrimitiveType int int int Int32
    // 0D0 M_ParameterOverrides                     ModelEnumListType ParameterOverride[] ParameterOverride[] List<ParameterOverride> Pointer
    // 0D8 M_Devices                                ModelEnumType DeviceArray DeviceArray DeviceArray Int32
    // 0E8 m_ActionCallbacks                        CallbackArray`1<Action`1<CallbackContext>> IL2CPP_TYPE_GENERICINST
    // 138 m_ActionIndexByNameOrId                  Dictionary`2<string, int> IL2CPP_TYPE_GENERICINST
    // 000 s_DeferBindingResolution                 int IL2CPP_TYPE_I4
    public partial class InputActionMap : DataModel
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
            var value   = new InputActionMap() { Pointer= p0 };

            value.M_Name                                    = GetString(new IntPtr(p + 0x010)); // 0x10 M_Name                      ( ModelPrimitiveType string string string String )
            value.M_Id                                      = GetString(new IntPtr(p + 0x018)); // 0x18 M_Id                        ( ModelPrimitiveType string string string String )
            value.M_Asset                                   = GetObject<InputActionAsset>(new IntPtr(p + 0x020), ReversePrism.DataModels.InputActionAsset.FromPointer); // 0x20 M_Asset                     ( ModelClassType InputActionAsset InputActionAsset InputActionAsset Pointer )
            value.M_Actions                                 = GetObjectList<InputAction>(new IntPtr(p + 0x028), ReversePrism.DataModels.InputAction.FromPointer); // 0x28 M_Actions                   ( ModelClassListType InputAction[] InputAction[] List<InputAction> Pointer )
            value.M_Bindings                                = GetEnumList<InputBinding>(new IntPtr(p + 0x030)); // 0x30 M_Bindings                  ( ModelEnumListType InputBinding[] InputBinding[] List<InputBinding> Pointer )
            value.M_BindingsForEachAction                   = GetEnumList<InputBinding>(new IntPtr(p + 0x038)); // 0x38 M_BindingsForEachAction     ( ModelEnumListType InputBinding[] InputBinding[] List<InputBinding> Pointer )
            value.M_ControlsForEachAction                   = GetObjectList<InputControl>(new IntPtr(p + 0x040), ReversePrism.DataModels.InputControl.FromPointer); // 0x40 M_ControlsForEachAction     ( ModelClassListType InputControl[] InputControl[] List<InputControl> Pointer )
            value.M_EnabledActionsCount                     = GetInt32(new IntPtr(p + 0x048)); // 0x48 M_EnabledActionsCount       ( ModelPrimitiveType int int int Int32 )
            value.M_SingletonAction                         = GetObject<InputAction>(new IntPtr(p + 0x050), ReversePrism.DataModels.InputAction.FromPointer); // 0x50 M_SingletonAction           ( ModelClassType InputAction InputAction InputAction Pointer )
            value.M_MapIndexInState                         = GetInt32(new IntPtr(p + 0x058)); // 0x58 M_MapIndexInState           ( ModelPrimitiveType int int int Int32 )
            value.M_State                                   = GetObject<InputActionState>(new IntPtr(p + 0x060), ReversePrism.DataModels.InputActionState.FromPointer); // 0x60 M_State                     ( ModelClassType InputActionState InputActionState InputActionState Pointer )
            value.M_Flags                                   = (Flags)GetInt32(new IntPtr(p + 0x0C8)); // 0xC8 M_Flags                     ( ModelEnumType Flags Flags Flags Int32 )
            value.M_ParameterOverridesCount                 = GetInt32(new IntPtr(p + 0x0CC)); // 0xCC M_ParameterOverridesCount   ( ModelPrimitiveType int int int Int32 )
            value.M_ParameterOverrides                      = GetEnumList<ParameterOverride>(new IntPtr(p + 0x0D0)); // 0xD0 M_ParameterOverrides        ( ModelEnumListType ParameterOverride[] ParameterOverride[] List<ParameterOverride> Pointer )
            value.M_Devices                                 = (DeviceArray)GetInt32(new IntPtr(p + 0x0D8)); // 0xD8 M_Devices                   ( ModelEnumType DeviceArray DeviceArray DeviceArray Int32 )

            return value;
        }
    }
}
