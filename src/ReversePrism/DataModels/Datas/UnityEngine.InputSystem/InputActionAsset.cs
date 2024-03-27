using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Extension                                string IL2CPP_TYPE_STRING
    // 018 M_ActionMaps                             000185B8BD10 ModelClassListType InputActionMap[] InputActionMap[] List<InputActionMap> Pointer
    // 020 M_ControlSchemes                         000185B8CA70 ModelEnumListType InputControlScheme[] InputControlScheme[] List<InputControlScheme> Pointer
    // 028 M_SharedStateForAllMaps                  0001866F7680 ModelClassType InputActionState InputActionState InputActionState Pointer
    // 030 m_BindingMask                            Nullable`1<InputBinding> IL2CPP_TYPE_GENERICINST
    // 090 M_ParameterOverridesCount                0001865F5530 ModelPrimitiveType int int int Int32
    // 098 M_ParameterOverrides                     000185B85470 ModelEnumListType ParameterOverride[] ParameterOverride[] List<ParameterOverride> Pointer
    // 0A0 M_Devices                                00018661ECB0 ModelEnumType DeviceArray DeviceArray DeviceArray Int32
    public partial class InputActionAsset
    {
        public List<InputActionMap>?                    M_ActionMaps                            { get; set; }
        public List<InputControlScheme>?                M_ControlSchemes                        { get; set; }
        public InputActionState?                        M_SharedStateForAllMaps                 { get; set; }
        public int                                      M_ParameterOverridesCount               { get; set; }
        public List<ParameterOverride>?                 M_ParameterOverrides                    { get; set; }
        public DeviceArray                              M_Devices                               { get; set; }

        public static InputActionAsset? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputActionAsset();

            value.M_ActionMaps                              = GetObjectList<InputActionMap>(new IntPtr(p + 0x018), ReversePrism.DataModels.InputActionMap.FromPointer); // 0270D763DF18 0x18 M_ActionMaps                ( 000185B8BD10 ModelClassListType InputActionMap[] InputActionMap[] List<InputActionMap> Pointer )
            value.M_ControlSchemes                          = GetEnumList<InputControlScheme>(new IntPtr(p + 0x020)); // 0270D763DF38 0x20 M_ControlSchemes            ( 000185B8CA70 ModelEnumListType InputControlScheme[] InputControlScheme[] List<InputControlScheme> Pointer )
            value.M_SharedStateForAllMaps                   = GetObject<InputActionState>(new IntPtr(p + 0x028), ReversePrism.DataModels.InputActionState.FromPointer); // 0270D763DF58 0x28 M_SharedStateForAllMaps     ( 0001866F7680 ModelClassType InputActionState InputActionState InputActionState Pointer )
            value.M_ParameterOverridesCount                 = GetInt32(new IntPtr(p + 0x090)); // 0270D763DF98 0x90 M_ParameterOverridesCount   ( 0001865F5530 ModelPrimitiveType int int int Int32 )
            value.M_ParameterOverrides                      = GetEnumList<ParameterOverride>(new IntPtr(p + 0x098)); // 0270D763DFB8 0x98 M_ParameterOverrides        ( 000185B85470 ModelEnumListType ParameterOverride[] ParameterOverride[] List<ParameterOverride> Pointer )
            value.M_Devices                                 = (DeviceArray)GetInt32(new IntPtr(p + 0x0A0)); // 0270D763DFD8 0xA0 M_Devices                   ( 00018661ECB0 ModelEnumType DeviceArray DeviceArray DeviceArray Int32 )

            return value;
        }
    }
}
