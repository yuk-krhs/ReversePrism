using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DeviceLostMessage                        string IL2CPP_TYPE_STRING
    // 000 DeviceRegainedMessage                    string IL2CPP_TYPE_STRING
    // 000 ControlsChangedMessage                   string IL2CPP_TYPE_STRING
    // 020 M_Actions                                0001866F4E30 ModelClassType InputActionAsset InputActionAsset InputActionAsset Pointer
    // 028 M_NotificationBehavior                   000186755800 ModelEnumType PlayerNotifications PlayerNotifications PlayerNotifications Int32
    // 030 M_UIInputModule                          000186704670 ModelClassType InputSystemUIInputModule InputSystemUIInputModule InputSystemUIInputModule Pointer
    // 038 M_DeviceLostEvent                        00018657E9B0 ModelClassType DeviceLostEvent DeviceLostEvent DeviceLostEvent Pointer
    // 040 M_DeviceRegainedEvent                    00018657EE90 ModelClassType DeviceRegainedEvent DeviceRegainedEvent DeviceRegainedEvent Pointer
    // 048 M_ControlsChangedEvent                   00018657E4F0 ModelClassType ControlsChangedEvent ControlsChangedEvent ControlsChangedEvent Pointer
    // 050 M_ActionEvents                           000185CC00D8 ModelClassListType ActionEvent[] ActionEvent[] List<ActionEvent> Pointer
    // 058 M_NeverAutoSwitchControlSchemes          000186595210 ModelPrimitiveType bool bool bool Bool
    // 060 M_DefaultControlScheme                   000186671BA0 ModelPrimitiveType string string string String
    // 068 M_DefaultActionMap                       000186671BA0 ModelPrimitiveType string string string String
    // 070 M_SplitScreenIndex                       0001865F2F90 ModelPrimitiveType int int int Int32
    // 078 M_Camera                                 0001865A1EC0 ModelClassType Camera Camera Camera Pointer
    // 080 M_InputValueObject                       000186708810 ModelClassType InputValue InputValue InputValue Pointer
    // 088 M_CurrentActionMap                       0001866F6080 ModelClassType InputActionMap InputActionMap InputActionMap Pointer
    // 090 M_PlayerIndex                            0001865F5290 ModelPrimitiveType int int int Int32
    // 094 M_InputActive                            0001865974C0 ModelPrimitiveType bool bool bool Bool
    // 095 M_Enabled                                0001865974C0 ModelPrimitiveType bool bool bool Bool
    // 096 M_ActionsInitialized                     0001865976C0 ModelPrimitiveType bool bool bool Bool
    // 098 m_ActionMessageNames                     Dictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    // 0A0 M_InputUser                              000186706A40 ModelEnumType InputUser InputUser InputUser Int32
    // 0A8 m_ActionTriggeredDelegate                Action`1<CallbackContext> IL2CPP_TYPE_GENERICINST
    // 0B0 m_DeviceLostCallbacks                    CallbackArray`1<Action`1<PlayerInput>> IL2CPP_TYPE_GENERICINST
    // 100 m_DeviceRegainedCallbacks                CallbackArray`1<Action`1<PlayerInput>> IL2CPP_TYPE_GENERICINST
    // 150 m_ControlsChangedCallbacks               CallbackArray`1<Action`1<PlayerInput>> IL2CPP_TYPE_GENERICINST
    // 1A0 m_ActionTriggeredCallbacks               CallbackArray`1<Action`1<CallbackContext>> IL2CPP_TYPE_GENERICINST
    // 1F0 m_UnpairedDeviceUsedDelegate             Action`2<InputControl, InputEventPtr> IL2CPP_TYPE_GENERICINST
    // 1F8 m_PreFilterUnpairedDeviceUsedDelegate    Func`3<InputDevice, InputEventPtr, bool> IL2CPP_TYPE_GENERICINST
    // 200 M_OnUnpairedDeviceUsedHooked             0001865974C0 ModelPrimitiveType bool bool bool Bool
    // 208 m_DeviceChangeDelegate                   Action`2<InputDevice, InputDeviceChange> IL2CPP_TYPE_GENERICINST
    // 210 M_OnDeviceChangeHooked                   0001865974C0 ModelPrimitiveType bool bool bool Bool
    // 000 s_AllActivePlayersCount                  int IL2CPP_TYPE_I4
    // 008 s_AllActivePlayers                       PlayerInput[] IL2CPP_TYPE_SZARRAY
    // 010 s_UserChangeDelegate                     Action`3<InputUser, InputUserChange, InputDevice> IL2CPP_TYPE_GENERICINST
    // 018 S_InitPairWithDevicesCount               0001865F38E0 ModelPrimitiveType int int int Int32
    // 020 S_InitPairWithDevices                    000185B8CE40 ModelClassListType InputDevice[] InputDevice[] List<InputDevice> Pointer
    // 028 S_InitPlayerIndex                        0001865F38E0 ModelPrimitiveType int int int Int32
    // 02C S_InitSplitScreenIndex                   0001865F38E0 ModelPrimitiveType int int int Int32
    // 030 S_InitControlScheme                      000186672530 ModelPrimitiveType string string string String
    // 038 S_DestroyIfDeviceSetupUnsuccessful       000186595E60 ModelPrimitiveType bool bool bool Bool
    public partial class PlayerInput
    {
        public InputActionAsset?                        M_Actions                               { get; set; }
        public PlayerNotifications                      M_NotificationBehavior                  { get; set; }
        public InputSystemUIInputModule?                M_UIInputModule                         { get; set; }
        public DeviceLostEvent?                         M_DeviceLostEvent                       { get; set; }
        public DeviceRegainedEvent?                     M_DeviceRegainedEvent                   { get; set; }
        public ControlsChangedEvent?                    M_ControlsChangedEvent                  { get; set; }
        public List<ActionEvent>?                       M_ActionEvents                          { get; set; }
        public bool                                     M_NeverAutoSwitchControlSchemes         { get; set; }
        public string                                   M_DefaultControlScheme                  { get; set; }
        public string                                   M_DefaultActionMap                      { get; set; }
        public int                                      M_SplitScreenIndex                      { get; set; }
        public Camera?                                  M_Camera                                { get; set; }
        public InputValue?                              M_InputValueObject                      { get; set; }
        public InputActionMap?                          M_CurrentActionMap                      { get; set; }
        public int                                      M_PlayerIndex                           { get; set; }
        public bool                                     M_InputActive                           { get; set; }
        public bool                                     M_Enabled                               { get; set; }
        public bool                                     M_ActionsInitialized                    { get; set; }
        public InputUser                                M_InputUser                             { get; set; }
        public bool                                     M_OnUnpairedDeviceUsedHooked            { get; set; }
        public bool                                     M_OnDeviceChangeHooked                  { get; set; }
        public int                                      S_InitPairWithDevicesCount              { get; set; }
        public List<InputDevice>?                       S_InitPairWithDevices                   { get; set; }
        public int                                      S_InitPlayerIndex                       { get; set; }
        public int                                      S_InitSplitScreenIndex                  { get; set; }
        public string                                   S_InitControlScheme                     { get; set; }
        public bool                                     S_DestroyIfDeviceSetupUnsuccessful      { get; set; }

        public static PlayerInput? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlayerInput();

            value.M_Actions                                 = GetObject<InputActionAsset>(new IntPtr(p + 0x020), ReversePrism.DataModels.InputActionAsset.FromPointer); // 0270D7723858 0x20 M_Actions                   ( 0001866F4E30 ModelClassType InputActionAsset InputActionAsset InputActionAsset Pointer )
            value.M_NotificationBehavior                    = (PlayerNotifications)GetInt32(new IntPtr(p + 0x028)); // 0270D7723878 0x28 M_NotificationBehavior      ( 000186755800 ModelEnumType PlayerNotifications PlayerNotifications PlayerNotifications Int32 )
            value.M_UIInputModule                           = GetObject<InputSystemUIInputModule>(new IntPtr(p + 0x030), ReversePrism.DataModels.InputSystemUIInputModule.FromPointer); // 0270D7723898 0x30 M_UIInputModule             ( 000186704670 ModelClassType InputSystemUIInputModule InputSystemUIInputModule InputSystemUIInputModule Pointer )
            value.M_DeviceLostEvent                         = GetObject<DeviceLostEvent>(new IntPtr(p + 0x038), ReversePrism.DataModels.DeviceLostEvent.FromPointer); // 0270D77238B8 0x38 M_DeviceLostEvent           ( 00018657E9B0 ModelClassType DeviceLostEvent DeviceLostEvent DeviceLostEvent Pointer )
            value.M_DeviceRegainedEvent                     = GetObject<DeviceRegainedEvent>(new IntPtr(p + 0x040), ReversePrism.DataModels.DeviceRegainedEvent.FromPointer); // 0270D77238D8 0x40 M_DeviceRegainedEvent       ( 00018657EE90 ModelClassType DeviceRegainedEvent DeviceRegainedEvent DeviceRegainedEvent Pointer )
            value.M_ControlsChangedEvent                    = GetObject<ControlsChangedEvent>(new IntPtr(p + 0x048), ReversePrism.DataModels.ControlsChangedEvent.FromPointer); // 0270D77238F8 0x48 M_ControlsChangedEvent      ( 00018657E4F0 ModelClassType ControlsChangedEvent ControlsChangedEvent ControlsChangedEvent Pointer )
            value.M_ActionEvents                            = GetObjectList<ActionEvent>(new IntPtr(p + 0x050), ReversePrism.DataModels.ActionEvent.FromPointer); // 0270D7723918 0x50 M_ActionEvents              ( 000185CC00D8 ModelClassListType ActionEvent[] ActionEvent[] List<ActionEvent> Pointer )
            value.M_NeverAutoSwitchControlSchemes           = GetBool(new IntPtr(p + 0x058)); // 0270D7723938 0x58 M_NeverAutoSwitchControlSchemes ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.M_DefaultControlScheme                    = GetString(new IntPtr(p + 0x060)); // 0270D7723958 0x60 M_DefaultControlScheme      ( 000186671BA0 ModelPrimitiveType string string string String )
            value.M_DefaultActionMap                        = GetString(new IntPtr(p + 0x068)); // 0270D7723978 0x68 M_DefaultActionMap          ( 000186671BA0 ModelPrimitiveType string string string String )
            value.M_SplitScreenIndex                        = GetInt32(new IntPtr(p + 0x070)); // 0270D7723998 0x70 M_SplitScreenIndex          ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_Camera                                  = GetObject<Camera>(new IntPtr(p + 0x078), ReversePrism.DataModels.Camera.FromPointer); // 0270D77239B8 0x78 M_Camera                    ( 0001865A1EC0 ModelClassType Camera Camera Camera Pointer )
            value.M_InputValueObject                        = GetObject<InputValue>(new IntPtr(p + 0x080), ReversePrism.DataModels.InputValue.FromPointer); // 0270D77239D8 0x80 M_InputValueObject          ( 000186708810 ModelClassType InputValue InputValue InputValue Pointer )
            value.M_CurrentActionMap                        = GetObject<InputActionMap>(new IntPtr(p + 0x088), ReversePrism.DataModels.InputActionMap.FromPointer); // 0270D77239F8 0x88 M_CurrentActionMap          ( 0001866F6080 ModelClassType InputActionMap InputActionMap InputActionMap Pointer )
            value.M_PlayerIndex                             = GetInt32(new IntPtr(p + 0x090)); // 0270D7723A18 0x90 M_PlayerIndex               ( 0001865F5290 ModelPrimitiveType int int int Int32 )
            value.M_InputActive                             = GetBool(new IntPtr(p + 0x094)); // 0270D7723A38 0x94 M_InputActive               ( 0001865974C0 ModelPrimitiveType bool bool bool Bool )
            value.M_Enabled                                 = GetBool(new IntPtr(p + 0x095)); // 0270D7723A58 0x95 M_Enabled                   ( 0001865974C0 ModelPrimitiveType bool bool bool Bool )
            value.M_ActionsInitialized                      = GetBool(new IntPtr(p + 0x096)); // 0270D7723A78 0x96 M_ActionsInitialized        ( 0001865976C0 ModelPrimitiveType bool bool bool Bool )
            value.M_InputUser                               = (InputUser)GetInt32(new IntPtr(p + 0x0A0)); // 0270D7723AB8 0xA0 M_InputUser                 ( 000186706A40 ModelEnumType InputUser InputUser InputUser Int32 )
            value.M_OnUnpairedDeviceUsedHooked              = GetBool(new IntPtr(p + 0x200)); // 0270D7723BB8 0x200 M_OnUnpairedDeviceUsedHooked ( 0001865974C0 ModelPrimitiveType bool bool bool Bool )
            value.M_OnDeviceChangeHooked                    = GetBool(new IntPtr(p + 0x210)); // 0270D7723BF8 0x210 M_OnDeviceChangeHooked      ( 0001865974C0 ModelPrimitiveType bool bool bool Bool )
            value.S_InitPairWithDevicesCount                = GetInt32(new IntPtr(p + 0x018)); // 0270D7723C78 0x18 S_InitPairWithDevicesCount  ( 0001865F38E0 ModelPrimitiveType int int int Int32 )
            value.S_InitPairWithDevices                     = GetObjectList<InputDevice>(new IntPtr(p + 0x020), ReversePrism.DataModels.InputDevice.FromPointer); // 0270D7723C98 0x20 S_InitPairWithDevices       ( 000185B8CE40 ModelClassListType InputDevice[] InputDevice[] List<InputDevice> Pointer )
            value.S_InitPlayerIndex                         = GetInt32(new IntPtr(p + 0x028)); // 0270D7723CB8 0x28 S_InitPlayerIndex           ( 0001865F38E0 ModelPrimitiveType int int int Int32 )
            value.S_InitSplitScreenIndex                    = GetInt32(new IntPtr(p + 0x02C)); // 0270D7723CD8 0x2C S_InitSplitScreenIndex      ( 0001865F38E0 ModelPrimitiveType int int int Int32 )
            value.S_InitControlScheme                       = GetString(new IntPtr(p + 0x030)); // 0270D7723CF8 0x30 S_InitControlScheme         ( 000186672530 ModelPrimitiveType string string string String )
            value.S_DestroyIfDeviceSetupUnsuccessful        = GetBool(new IntPtr(p + 0x038)); // 0270D7723D18 0x38 S_DestroyIfDeviceSetupUnsuccessful ( 000186595E60 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
