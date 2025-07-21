using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_LayoutRegistrationVersion              ModelPrimitiveType int int int Int32
    // 014 M_PollingFrequency                       ModelPrimitiveType float float float Single
    // 018 M_Layouts                                ModelEnumType Collection Collection Collection Int32
    // 058 M_Processors                             ModelEnumType TypeTable TypeTable TypeTable Int32
    // 060 M_Interactions                           ModelEnumType TypeTable TypeTable TypeTable Int32
    // 068 M_Composites                             ModelEnumType TypeTable TypeTable TypeTable Int32
    // 070 M_DevicesCount                           ModelPrimitiveType int int int Int32
    // 078 M_Devices                                ModelClassListType InputDevice[] InputDevice[] List<InputDevice> Pointer
    // 080 m_DevicesById                            Dictionary`2<int, InputDevice> IL2CPP_TYPE_GENERICINST
    // 088 M_AvailableDeviceCount                   ModelPrimitiveType int int int Int32
    // 090 M_AvailableDevices                       ModelEnumListType AvailableDevice[] AvailableDevice[] List<AvailableDevice> Pointer
    // 098 M_DisconnectedDevicesCount               ModelPrimitiveType int int int Int32
    // 0A0 M_DisconnectedDevices                    ModelClassListType InputDevice[] InputDevice[] List<InputDevice> Pointer
    // 0A8 M_UpdateMask                             ModelEnumType InputUpdateType InputUpdateType InputUpdateType Int32
    // 0AC M_CurrentUpdate                          ModelEnumType InputUpdateType InputUpdateType InputUpdateType Int32
    // 0B0 M_StateBuffers                           ModelEnumType InputStateBuffers InputStateBuffers InputStateBuffers Int32
    // 0E0 m_DeviceChangeListeners                  CallbackArray`1<Action`2<InputDevice, InputDeviceChange>> IL2CPP_TYPE_GENERICINST
    // 130 m_DeviceStateChangeListeners             CallbackArray`1<Action`2<InputDevice, InputEventPtr>> IL2CPP_TYPE_GENERICINST
    // 180 m_DeviceFindLayoutCallbacks              CallbackArray`1<InputDeviceFindControlLayoutDelegate> IL2CPP_TYPE_GENERICINST
    // 1D0 m_DeviceCommandCallbacks                 CallbackArray`1<InputDeviceCommandDelegate> IL2CPP_TYPE_GENERICINST
    // 220 m_LayoutChangeListeners                  CallbackArray`1<Action`2<string, InputControlLayoutChange>> IL2CPP_TYPE_GENERICINST
    // 270 m_EventListeners                         CallbackArray`1<Action`2<InputEventPtr, InputDevice>> IL2CPP_TYPE_GENERICINST
    // 2C0 m_BeforeUpdateListeners                  CallbackArray`1<Action> IL2CPP_TYPE_GENERICINST
    // 310 m_AfterUpdateListeners                   CallbackArray`1<Action> IL2CPP_TYPE_GENERICINST
    // 360 m_SettingsChangedListeners               CallbackArray`1<Action> IL2CPP_TYPE_GENERICINST
    // 3B0 M_NativeBeforeUpdateHooked               ModelPrimitiveType bool bool bool Bool
    // 3B1 M_HaveDevicesWithStateCallbackReceivers  ModelPrimitiveType bool bool bool Bool
    // 3B2 M_HasFocus                               ModelPrimitiveType bool bool bool Bool
    // 3B8 M_InputEventStream                       ModelEnumType InputEventStream InputEventStream InputEventStream Int32
    // 430 M_DeviceFindExecuteCommandDelegate       ModelClassType InputDeviceExecuteCommandDelegate InputDeviceExecuteCommandDelegate InputDeviceExecuteCommandDelegate Pointer
    // 438 M_DeviceFindExecuteCommandDeviceId       ModelPrimitiveType int int int Int32
    // 43C M_HaveSentStartupAnalytics               ModelPrimitiveType bool bool bool Bool
    // 440 M_Runtime                                ModelClassType IInputRuntime IInputRuntime IInputRuntime Pointer
    // 448 M_Metrics                                ModelEnumType InputMetrics InputMetrics InputMetrics Int32
    // 480 M_Settings                               ModelClassType InputSettings InputSettings InputSettings Pointer
    // 488 M_ShouldMakeCurrentlyUpdatingDeviceCurrent ModelPrimitiveType bool bool bool Bool
    // 490 M_StateChangeMonitors                    ModelEnumListType StateChangeMonitorsForDevice[] StateChangeMonitorsForDevice[] List<StateChangeMonitorsForDevice> Pointer
    // 498 m_StateChangeMonitorTimeouts             InlinedArray`1<StateChangeMonitorTimeout> IL2CPP_TYPE_GENERICINST
    public partial class InputManager : DataModel
    {
        public int                                      M_LayoutRegistrationVersion             { get; set; }
        public float                                    M_PollingFrequency                      { get; set; }
        public Collection                               M_Layouts                               { get; set; }
        public TypeTable                                M_Processors                            { get; set; }
        public TypeTable                                M_Interactions                          { get; set; }
        public TypeTable                                M_Composites                            { get; set; }
        public int                                      M_DevicesCount                          { get; set; }
        public List<InputDevice>?                       M_Devices                               { get; set; }
        public int                                      M_AvailableDeviceCount                  { get; set; }
        public List<AvailableDevice>?                   M_AvailableDevices                      { get; set; }
        public int                                      M_DisconnectedDevicesCount              { get; set; }
        public List<InputDevice>?                       M_DisconnectedDevices                   { get; set; }
        public InputUpdateType                          M_UpdateMask                            { get; set; }
        public InputUpdateType                          M_CurrentUpdate                         { get; set; }
        public InputStateBuffers                        M_StateBuffers                          { get; set; }
        public bool                                     M_NativeBeforeUpdateHooked              { get; set; }
        public bool                                     M_HaveDevicesWithStateCallbackReceivers { get; set; }
        public bool                                     M_HasFocus                              { get; set; }
        public InputEventStream                         M_InputEventStream                      { get; set; }
        public InputDeviceExecuteCommandDelegate?       M_DeviceFindExecuteCommandDelegate      { get; set; }
        public int                                      M_DeviceFindExecuteCommandDeviceId      { get; set; }
        public bool                                     M_HaveSentStartupAnalytics              { get; set; }
        public IInputRuntime?                           M_Runtime                               { get; set; }
        public InputMetrics                             M_Metrics                               { get; set; }
        public InputSettings?                           M_Settings                              { get; set; }
        public bool                                     M_ShouldMakeCurrentlyUpdatingDeviceCurrent { get; set; }
        public List<StateChangeMonitorsForDevice>?      M_StateChangeMonitors                   { get; set; }

        public static InputManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputManager() { Pointer= p0 };

            value.M_LayoutRegistrationVersion               = GetInt32(new IntPtr(p + 0x010)); // 0x10 M_LayoutRegistrationVersion ( ModelPrimitiveType int int int Int32 )
            value.M_PollingFrequency                        = GetSingle(new IntPtr(p + 0x014)); // 0x14 M_PollingFrequency          ( ModelPrimitiveType float float float Single )
            value.M_Layouts                                 = (Collection)GetInt32(new IntPtr(p + 0x018)); // 0x18 M_Layouts                   ( ModelEnumType Collection Collection Collection Int32 )
            value.M_Processors                              = (TypeTable)GetInt32(new IntPtr(p + 0x058)); // 0x58 M_Processors                ( ModelEnumType TypeTable TypeTable TypeTable Int32 )
            value.M_Interactions                            = (TypeTable)GetInt32(new IntPtr(p + 0x060)); // 0x60 M_Interactions              ( ModelEnumType TypeTable TypeTable TypeTable Int32 )
            value.M_Composites                              = (TypeTable)GetInt32(new IntPtr(p + 0x068)); // 0x68 M_Composites                ( ModelEnumType TypeTable TypeTable TypeTable Int32 )
            value.M_DevicesCount                            = GetInt32(new IntPtr(p + 0x070)); // 0x70 M_DevicesCount              ( ModelPrimitiveType int int int Int32 )
            value.M_Devices                                 = GetObjectList<InputDevice>(new IntPtr(p + 0x078), ReversePrism.DataModels.InputDevice.FromPointer); // 0x78 M_Devices                   ( ModelClassListType InputDevice[] InputDevice[] List<InputDevice> Pointer )
            value.M_AvailableDeviceCount                    = GetInt32(new IntPtr(p + 0x088)); // 0x88 M_AvailableDeviceCount      ( ModelPrimitiveType int int int Int32 )
            value.M_AvailableDevices                        = GetEnumList<AvailableDevice>(new IntPtr(p + 0x090)); // 0x90 M_AvailableDevices          ( ModelEnumListType AvailableDevice[] AvailableDevice[] List<AvailableDevice> Pointer )
            value.M_DisconnectedDevicesCount                = GetInt32(new IntPtr(p + 0x098)); // 0x98 M_DisconnectedDevicesCount  ( ModelPrimitiveType int int int Int32 )
            value.M_DisconnectedDevices                     = GetObjectList<InputDevice>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.InputDevice.FromPointer); // 0xA0 M_DisconnectedDevices       ( ModelClassListType InputDevice[] InputDevice[] List<InputDevice> Pointer )
            value.M_UpdateMask                              = (InputUpdateType)GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 M_UpdateMask                ( ModelEnumType InputUpdateType InputUpdateType InputUpdateType Int32 )
            value.M_CurrentUpdate                           = (InputUpdateType)GetInt32(new IntPtr(p + 0x0AC)); // 0xAC M_CurrentUpdate             ( ModelEnumType InputUpdateType InputUpdateType InputUpdateType Int32 )
            value.M_StateBuffers                            = (InputStateBuffers)GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 M_StateBuffers              ( ModelEnumType InputStateBuffers InputStateBuffers InputStateBuffers Int32 )
            value.M_NativeBeforeUpdateHooked                = GetBool(new IntPtr(p + 0x3B0)); // 0x3B0 M_NativeBeforeUpdateHooked  ( ModelPrimitiveType bool bool bool Bool )
            value.M_HaveDevicesWithStateCallbackReceivers   = GetBool(new IntPtr(p + 0x3B1)); // 0x3B1 M_HaveDevicesWithStateCallbackReceivers ( ModelPrimitiveType bool bool bool Bool )
            value.M_HasFocus                                = GetBool(new IntPtr(p + 0x3B2)); // 0x3B2 M_HasFocus                  ( ModelPrimitiveType bool bool bool Bool )
            value.M_InputEventStream                        = (InputEventStream)GetInt32(new IntPtr(p + 0x3B8)); // 0x3B8 M_InputEventStream          ( ModelEnumType InputEventStream InputEventStream InputEventStream Int32 )
            value.M_DeviceFindExecuteCommandDelegate        = GetObject<InputDeviceExecuteCommandDelegate>(new IntPtr(p + 0x430), ReversePrism.DataModels.InputDeviceExecuteCommandDelegate.FromPointer); // 0x430 M_DeviceFindExecuteCommandDelegate ( ModelClassType InputDeviceExecuteCommandDelegate InputDeviceExecuteCommandDelegate InputDeviceExecuteCommandDelegate Pointer )
            value.M_DeviceFindExecuteCommandDeviceId        = GetInt32(new IntPtr(p + 0x438)); // 0x438 M_DeviceFindExecuteCommandDeviceId ( ModelPrimitiveType int int int Int32 )
            value.M_HaveSentStartupAnalytics                = GetBool(new IntPtr(p + 0x43C)); // 0x43C M_HaveSentStartupAnalytics  ( ModelPrimitiveType bool bool bool Bool )
            value.M_Runtime                                 = GetObject<IInputRuntime>(new IntPtr(p + 0x440), ReversePrism.DataModels.IInputRuntime.FromPointer); // 0x440 M_Runtime                   ( ModelClassType IInputRuntime IInputRuntime IInputRuntime Pointer )
            value.M_Metrics                                 = (InputMetrics)GetInt32(new IntPtr(p + 0x448)); // 0x448 M_Metrics                   ( ModelEnumType InputMetrics InputMetrics InputMetrics Int32 )
            value.M_Settings                                = GetObject<InputSettings>(new IntPtr(p + 0x480), ReversePrism.DataModels.InputSettings.FromPointer); // 0x480 M_Settings                  ( ModelClassType InputSettings InputSettings InputSettings Pointer )
            value.M_ShouldMakeCurrentlyUpdatingDeviceCurrent = GetBool(new IntPtr(p + 0x488)); // 0x488 M_ShouldMakeCurrentlyUpdatingDeviceCurrent ( ModelPrimitiveType bool bool bool Bool )
            value.M_StateChangeMonitors                     = GetEnumList<StateChangeMonitorsForDevice>(new IntPtr(p + 0x490)); // 0x490 M_StateChangeMonitors       ( ModelEnumListType StateChangeMonitorsForDevice[] StateChangeMonitorsForDevice[] List<StateChangeMonitorsForDevice> Pointer )

            return value;
        }
    }
}
