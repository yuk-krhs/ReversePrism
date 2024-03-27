using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_LayoutRegistrationVersion              0001865F2F90 ModelPrimitiveType int int int Int32
    // 014 M_PollingFrequency                       0001866656B0 ModelPrimitiveType float float float Single
    // 018 M_Layouts                                000186628980 ModelEnumType Collection Collection Collection Int32
    // 058 M_Processors                             0001866DCFF0 ModelEnumType TypeTable TypeTable TypeTable Int32
    // 060 M_Interactions                           0001866DCFF0 ModelEnumType TypeTable TypeTable TypeTable Int32
    // 068 M_Composites                             0001866DCFF0 ModelEnumType TypeTable TypeTable TypeTable Int32
    // 070 M_DevicesCount                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 078 M_Devices                                000185B8CC70 ModelClassListType InputDevice[] InputDevice[] List<InputDevice> Pointer
    // 080 m_DevicesById                            Dictionary`2<int, InputDevice> IL2CPP_TYPE_GENERICINST
    // 088 M_AvailableDeviceCount                   0001865F2F90 ModelPrimitiveType int int int Int32
    // 090 M_AvailableDevices                       000185CBDC68 ModelEnumListType AvailableDevice[] AvailableDevice[] List<AvailableDevice> Pointer
    // 098 M_DisconnectedDevicesCount               0001865F2F90 ModelPrimitiveType int int int Int32
    // 0A0 M_DisconnectedDevices                    000185B8CD80 ModelClassListType InputDevice[] InputDevice[] List<InputDevice> Pointer
    // 0A8 M_UpdateMask                             000186705CC0 ModelEnumType InputUpdateType InputUpdateType InputUpdateType Int32
    // 0AC M_CurrentUpdate                          0001867059D0 ModelEnumType InputUpdateType InputUpdateType InputUpdateType Int32
    // 0B0 M_StateBuffers                           0001867037A0 ModelEnumType InputStateBuffers InputStateBuffers InputStateBuffers Int32
    // 0E0 m_DeviceChangeListeners                  CallbackArray`1<Action`2<InputDevice, InputDeviceChange>> IL2CPP_TYPE_GENERICINST
    // 130 m_DeviceStateChangeListeners             CallbackArray`1<Action`2<InputDevice, InputEventPtr>> IL2CPP_TYPE_GENERICINST
    // 180 m_DeviceFindLayoutCallbacks              CallbackArray`1<InputDeviceFindControlLayoutDelegate> IL2CPP_TYPE_GENERICINST
    // 1D0 m_DeviceCommandCallbacks                 CallbackArray`1<InputDeviceCommandDelegate> IL2CPP_TYPE_GENERICINST
    // 220 m_LayoutChangeListeners                  CallbackArray`1<Action`2<string, InputControlLayoutChange>> IL2CPP_TYPE_GENERICINST
    // 270 m_EventListeners                         CallbackArray`1<Action`2<InputEventPtr, InputDevice>> IL2CPP_TYPE_GENERICINST
    // 2C0 m_BeforeUpdateListeners                  CallbackArray`1<Action> IL2CPP_TYPE_GENERICINST
    // 310 m_AfterUpdateListeners                   CallbackArray`1<Action> IL2CPP_TYPE_GENERICINST
    // 360 m_SettingsChangedListeners               CallbackArray`1<Action> IL2CPP_TYPE_GENERICINST
    // 3B0 M_NativeBeforeUpdateHooked               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 3B1 M_HaveDevicesWithStateCallbackReceivers  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 3B2 M_HasFocus                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 3B8 M_InputEventStream                       0001866FD8A0 ModelEnumType InputEventStream InputEventStream InputEventStream Int32
    // 430 M_DeviceFindExecuteCommandDelegate       0001866FC6A0 ModelClassType InputDeviceExecuteCommandDelegate InputDeviceExecuteCommandDelegate InputDeviceExecuteCommandDelegate Pointer
    // 438 M_DeviceFindExecuteCommandDeviceId       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 43C M_HaveSentStartupAnalytics               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 440 M_Runtime                                000186582A90 ModelClassType IInputRuntime IInputRuntime IInputRuntime Pointer
    // 448 M_Metrics                                000186701420 ModelEnumType InputMetrics InputMetrics InputMetrics Int32
    // 480 M_Settings                               000186702DC0 ModelClassType InputSettings InputSettings InputSettings Pointer
    // 488 M_ShouldMakeCurrentlyUpdatingDeviceCurrent 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 490 M_StateChangeMonitors                    000185CBDE48 ModelEnumListType StateChangeMonitorsForDevice[] StateChangeMonitorsForDevice[] List<StateChangeMonitorsForDevice> Pointer
    // 498 m_StateChangeMonitorTimeouts             InlinedArray`1<StateChangeMonitorTimeout> IL2CPP_TYPE_GENERICINST
    public partial class InputManager
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
            var value   = new InputManager();

            value.M_LayoutRegistrationVersion               = GetInt32(new IntPtr(p + 0x010)); // 02700334BE30 0x10 M_LayoutRegistrationVersion ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_PollingFrequency                        = GetSingle(new IntPtr(p + 0x014)); // 02700334BE50 0x14 M_PollingFrequency          ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_Layouts                                 = (Collection)GetInt32(new IntPtr(p + 0x018)); // 02700334BE70 0x18 M_Layouts                   ( 000186628980 ModelEnumType Collection Collection Collection Int32 )
            value.M_Processors                              = (TypeTable)GetInt32(new IntPtr(p + 0x058)); // 02700334BE90 0x58 M_Processors                ( 0001866DCFF0 ModelEnumType TypeTable TypeTable TypeTable Int32 )
            value.M_Interactions                            = (TypeTable)GetInt32(new IntPtr(p + 0x060)); // 02700334BEB0 0x60 M_Interactions              ( 0001866DCFF0 ModelEnumType TypeTable TypeTable TypeTable Int32 )
            value.M_Composites                              = (TypeTable)GetInt32(new IntPtr(p + 0x068)); // 02700334BED0 0x68 M_Composites                ( 0001866DCFF0 ModelEnumType TypeTable TypeTable TypeTable Int32 )
            value.M_DevicesCount                            = GetInt32(new IntPtr(p + 0x070)); // 02700334BEF0 0x70 M_DevicesCount              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_Devices                                 = GetObjectList<InputDevice>(new IntPtr(p + 0x078), ReversePrism.DataModels.InputDevice.FromPointer); // 02700334BF10 0x78 M_Devices                   ( 000185B8CC70 ModelClassListType InputDevice[] InputDevice[] List<InputDevice> Pointer )
            value.M_AvailableDeviceCount                    = GetInt32(new IntPtr(p + 0x088)); // 02700334BF50 0x88 M_AvailableDeviceCount      ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_AvailableDevices                        = GetEnumList<AvailableDevice>(new IntPtr(p + 0x090)); // 02700334BF70 0x90 M_AvailableDevices          ( 000185CBDC68 ModelEnumListType AvailableDevice[] AvailableDevice[] List<AvailableDevice> Pointer )
            value.M_DisconnectedDevicesCount                = GetInt32(new IntPtr(p + 0x098)); // 02700334BF90 0x98 M_DisconnectedDevicesCount  ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_DisconnectedDevices                     = GetObjectList<InputDevice>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.InputDevice.FromPointer); // 02700334BFB0 0xA0 M_DisconnectedDevices       ( 000185B8CD80 ModelClassListType InputDevice[] InputDevice[] List<InputDevice> Pointer )
            value.M_UpdateMask                              = (InputUpdateType)GetInt32(new IntPtr(p + 0x0A8)); // 02700334BFD0 0xA8 M_UpdateMask                ( 000186705CC0 ModelEnumType InputUpdateType InputUpdateType InputUpdateType Int32 )
            value.M_CurrentUpdate                           = (InputUpdateType)GetInt32(new IntPtr(p + 0x0AC)); // 02700334BFF0 0xAC M_CurrentUpdate             ( 0001867059D0 ModelEnumType InputUpdateType InputUpdateType InputUpdateType Int32 )
            value.M_StateBuffers                            = (InputStateBuffers)GetInt32(new IntPtr(p + 0x0B0)); // 02700334C010 0xB0 M_StateBuffers              ( 0001867037A0 ModelEnumType InputStateBuffers InputStateBuffers InputStateBuffers Int32 )
            value.M_NativeBeforeUpdateHooked                = GetBool(new IntPtr(p + 0x3B0)); // 02700334C150 0x3B0 M_NativeBeforeUpdateHooked  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_HaveDevicesWithStateCallbackReceivers   = GetBool(new IntPtr(p + 0x3B1)); // 02700334C170 0x3B1 M_HaveDevicesWithStateCallbackReceivers ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_HasFocus                                = GetBool(new IntPtr(p + 0x3B2)); // 02700334C190 0x3B2 M_HasFocus                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_InputEventStream                        = (InputEventStream)GetInt32(new IntPtr(p + 0x3B8)); // 02700334C1B0 0x3B8 M_InputEventStream          ( 0001866FD8A0 ModelEnumType InputEventStream InputEventStream InputEventStream Int32 )
            value.M_DeviceFindExecuteCommandDelegate        = GetObject<InputDeviceExecuteCommandDelegate>(new IntPtr(p + 0x430), ReversePrism.DataModels.InputDeviceExecuteCommandDelegate.FromPointer); // 02700334C1D0 0x430 M_DeviceFindExecuteCommandDelegate ( 0001866FC6A0 ModelClassType InputDeviceExecuteCommandDelegate InputDeviceExecuteCommandDelegate InputDeviceExecuteCommandDelegate Pointer )
            value.M_DeviceFindExecuteCommandDeviceId        = GetInt32(new IntPtr(p + 0x438)); // 02700334C1F0 0x438 M_DeviceFindExecuteCommandDeviceId ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_HaveSentStartupAnalytics                = GetBool(new IntPtr(p + 0x43C)); // 02700334C210 0x43C M_HaveSentStartupAnalytics  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_Runtime                                 = GetObject<IInputRuntime>(new IntPtr(p + 0x440), ReversePrism.DataModels.IInputRuntime.FromPointer); // 02700334C230 0x440 M_Runtime                   ( 000186582A90 ModelClassType IInputRuntime IInputRuntime IInputRuntime Pointer )
            value.M_Metrics                                 = (InputMetrics)GetInt32(new IntPtr(p + 0x448)); // 02700334C250 0x448 M_Metrics                   ( 000186701420 ModelEnumType InputMetrics InputMetrics InputMetrics Int32 )
            value.M_Settings                                = GetObject<InputSettings>(new IntPtr(p + 0x480), ReversePrism.DataModels.InputSettings.FromPointer); // 02700334C270 0x480 M_Settings                  ( 000186702DC0 ModelClassType InputSettings InputSettings InputSettings Pointer )
            value.M_ShouldMakeCurrentlyUpdatingDeviceCurrent = GetBool(new IntPtr(p + 0x488)); // 02700334C290 0x488 M_ShouldMakeCurrentlyUpdatingDeviceCurrent ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_StateChangeMonitors                     = GetEnumList<StateChangeMonitorsForDevice>(new IntPtr(p + 0x490)); // 02700334C2B0 0x490 M_StateChangeMonitors       ( 000185CBDE48 ModelEnumListType StateChangeMonitorsForDevice[] StateChangeMonitorsForDevice[] List<StateChangeMonitorsForDevice> Pointer )

            return value;
        }
    }
}
