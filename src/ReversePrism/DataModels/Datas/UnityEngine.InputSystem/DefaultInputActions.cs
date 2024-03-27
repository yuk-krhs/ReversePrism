using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Asset                                    0001866F5370 ModelClassType InputActionAsset InputActionAsset InputActionAsset Pointer
    // 018 M_Player                                 0001866F5E10 ModelClassType InputActionMap InputActionMap InputActionMap Pointer
    // 020 M_PlayerActionsCallbackInterface         0001865969F0 ModelClassType IPlayerActions IPlayerActions IPlayerActions Pointer
    // 028 M_Player_Move                            0001865E82E0 ModelClassType InputAction InputAction InputAction Pointer
    // 030 M_Player_Look                            0001865E82E0 ModelClassType InputAction InputAction InputAction Pointer
    // 038 M_Player_Fire                            0001865E82E0 ModelClassType InputAction InputAction InputAction Pointer
    // 040 M_UI                                     0001866F5E10 ModelClassType InputActionMap InputActionMap InputActionMap Pointer
    // 048 M_UIActionsCallbackInterface             000186596EE0 ModelClassType IUIActions IUIActions IUIActions Pointer
    // 050 M_UI_Navigate                            0001865E82E0 ModelClassType InputAction InputAction InputAction Pointer
    // 058 M_UI_Submit                              0001865E82E0 ModelClassType InputAction InputAction InputAction Pointer
    // 060 M_UI_Cancel                              0001865E82E0 ModelClassType InputAction InputAction InputAction Pointer
    // 068 M_UI_Point                               0001865E82E0 ModelClassType InputAction InputAction InputAction Pointer
    // 070 M_UI_Click                               0001865E82E0 ModelClassType InputAction InputAction InputAction Pointer
    // 078 M_UI_ScrollWheel                         0001865E82E0 ModelClassType InputAction InputAction InputAction Pointer
    // 080 M_UI_MiddleClick                         0001865E82E0 ModelClassType InputAction InputAction InputAction Pointer
    // 088 M_UI_RightClick                          0001865E82E0 ModelClassType InputAction InputAction InputAction Pointer
    // 090 M_UI_TrackedDevicePosition               0001865E82E0 ModelClassType InputAction InputAction InputAction Pointer
    // 098 M_UI_TrackedDeviceOrientation            0001865E82E0 ModelClassType InputAction InputAction InputAction Pointer
    // 0A0 M_KeyboardMouseSchemeIndex               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0A4 M_GamepadSchemeIndex                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0A8 M_TouchSchemeIndex                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0AC M_JoystickSchemeIndex                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0B0 M_XRSchemeIndex                          0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class DefaultInputActions
    {
        public InputActionAsset?                        Asset                                   { get; set; }
        public InputActionMap?                          M_Player                                { get; set; }
        public IPlayerActions?                          M_PlayerActionsCallbackInterface        { get; set; }
        public InputAction?                             M_Player_Move                           { get; set; }
        public InputAction?                             M_Player_Look                           { get; set; }
        public InputAction?                             M_Player_Fire                           { get; set; }
        public InputActionMap?                          M_UI                                    { get; set; }
        public IUIActions?                              M_UIActionsCallbackInterface            { get; set; }
        public InputAction?                             M_UI_Navigate                           { get; set; }
        public InputAction?                             M_UI_Submit                             { get; set; }
        public InputAction?                             M_UI_Cancel                             { get; set; }
        public InputAction?                             M_UI_Point                              { get; set; }
        public InputAction?                             M_UI_Click                              { get; set; }
        public InputAction?                             M_UI_ScrollWheel                        { get; set; }
        public InputAction?                             M_UI_MiddleClick                        { get; set; }
        public InputAction?                             M_UI_RightClick                         { get; set; }
        public InputAction?                             M_UI_TrackedDevicePosition              { get; set; }
        public InputAction?                             M_UI_TrackedDeviceOrientation           { get; set; }
        public int                                      M_KeyboardMouseSchemeIndex              { get; set; }
        public int                                      M_GamepadSchemeIndex                    { get; set; }
        public int                                      M_TouchSchemeIndex                      { get; set; }
        public int                                      M_JoystickSchemeIndex                   { get; set; }
        public int                                      M_XRSchemeIndex                         { get; set; }

        public static DefaultInputActions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DefaultInputActions();

            value.Asset                                     = GetObject<InputActionAsset>(new IntPtr(p + 0x010), ReversePrism.DataModels.InputActionAsset.FromPointer); // 0270D7721388 0x10 Asset                       ( 0001866F5370 ModelClassType InputActionAsset InputActionAsset InputActionAsset Pointer )
            value.M_Player                                  = GetObject<InputActionMap>(new IntPtr(p + 0x018), ReversePrism.DataModels.InputActionMap.FromPointer); // 0270D77213A8 0x18 M_Player                    ( 0001866F5E10 ModelClassType InputActionMap InputActionMap InputActionMap Pointer )
            value.M_PlayerActionsCallbackInterface          = GetObject<IPlayerActions>(new IntPtr(p + 0x020), ReversePrism.DataModels.IPlayerActions.FromPointer); // 0270D77213C8 0x20 M_PlayerActionsCallbackInterface ( 0001865969F0 ModelClassType IPlayerActions IPlayerActions IPlayerActions Pointer )
            value.M_Player_Move                             = GetObject<InputAction>(new IntPtr(p + 0x028), ReversePrism.DataModels.InputAction.FromPointer); // 0270D77213E8 0x28 M_Player_Move               ( 0001865E82E0 ModelClassType InputAction InputAction InputAction Pointer )
            value.M_Player_Look                             = GetObject<InputAction>(new IntPtr(p + 0x030), ReversePrism.DataModels.InputAction.FromPointer); // 0270D7721408 0x30 M_Player_Look               ( 0001865E82E0 ModelClassType InputAction InputAction InputAction Pointer )
            value.M_Player_Fire                             = GetObject<InputAction>(new IntPtr(p + 0x038), ReversePrism.DataModels.InputAction.FromPointer); // 0270D7721428 0x38 M_Player_Fire               ( 0001865E82E0 ModelClassType InputAction InputAction InputAction Pointer )
            value.M_UI                                      = GetObject<InputActionMap>(new IntPtr(p + 0x040), ReversePrism.DataModels.InputActionMap.FromPointer); // 0270D7721448 0x40 M_UI                        ( 0001866F5E10 ModelClassType InputActionMap InputActionMap InputActionMap Pointer )
            value.M_UIActionsCallbackInterface              = GetObject<IUIActions>(new IntPtr(p + 0x048), ReversePrism.DataModels.IUIActions.FromPointer); // 0270D7721468 0x48 M_UIActionsCallbackInterface ( 000186596EE0 ModelClassType IUIActions IUIActions IUIActions Pointer )
            value.M_UI_Navigate                             = GetObject<InputAction>(new IntPtr(p + 0x050), ReversePrism.DataModels.InputAction.FromPointer); // 0270D7721488 0x50 M_UI_Navigate               ( 0001865E82E0 ModelClassType InputAction InputAction InputAction Pointer )
            value.M_UI_Submit                               = GetObject<InputAction>(new IntPtr(p + 0x058), ReversePrism.DataModels.InputAction.FromPointer); // 0270D77214A8 0x58 M_UI_Submit                 ( 0001865E82E0 ModelClassType InputAction InputAction InputAction Pointer )
            value.M_UI_Cancel                               = GetObject<InputAction>(new IntPtr(p + 0x060), ReversePrism.DataModels.InputAction.FromPointer); // 0270D77214C8 0x60 M_UI_Cancel                 ( 0001865E82E0 ModelClassType InputAction InputAction InputAction Pointer )
            value.M_UI_Point                                = GetObject<InputAction>(new IntPtr(p + 0x068), ReversePrism.DataModels.InputAction.FromPointer); // 0270D77214E8 0x68 M_UI_Point                  ( 0001865E82E0 ModelClassType InputAction InputAction InputAction Pointer )
            value.M_UI_Click                                = GetObject<InputAction>(new IntPtr(p + 0x070), ReversePrism.DataModels.InputAction.FromPointer); // 0270D7721508 0x70 M_UI_Click                  ( 0001865E82E0 ModelClassType InputAction InputAction InputAction Pointer )
            value.M_UI_ScrollWheel                          = GetObject<InputAction>(new IntPtr(p + 0x078), ReversePrism.DataModels.InputAction.FromPointer); // 0270D7721528 0x78 M_UI_ScrollWheel            ( 0001865E82E0 ModelClassType InputAction InputAction InputAction Pointer )
            value.M_UI_MiddleClick                          = GetObject<InputAction>(new IntPtr(p + 0x080), ReversePrism.DataModels.InputAction.FromPointer); // 0270D7721548 0x80 M_UI_MiddleClick            ( 0001865E82E0 ModelClassType InputAction InputAction InputAction Pointer )
            value.M_UI_RightClick                           = GetObject<InputAction>(new IntPtr(p + 0x088), ReversePrism.DataModels.InputAction.FromPointer); // 0270D7721568 0x88 M_UI_RightClick             ( 0001865E82E0 ModelClassType InputAction InputAction InputAction Pointer )
            value.M_UI_TrackedDevicePosition                = GetObject<InputAction>(new IntPtr(p + 0x090), ReversePrism.DataModels.InputAction.FromPointer); // 0270D7721588 0x90 M_UI_TrackedDevicePosition  ( 0001865E82E0 ModelClassType InputAction InputAction InputAction Pointer )
            value.M_UI_TrackedDeviceOrientation             = GetObject<InputAction>(new IntPtr(p + 0x098), ReversePrism.DataModels.InputAction.FromPointer); // 0270D77215A8 0x98 M_UI_TrackedDeviceOrientation ( 0001865E82E0 ModelClassType InputAction InputAction InputAction Pointer )
            value.M_KeyboardMouseSchemeIndex                = GetInt32(new IntPtr(p + 0x0A0)); // 0270D77215C8 0xA0 M_KeyboardMouseSchemeIndex  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_GamepadSchemeIndex                      = GetInt32(new IntPtr(p + 0x0A4)); // 0270D77215E8 0xA4 M_GamepadSchemeIndex        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_TouchSchemeIndex                        = GetInt32(new IntPtr(p + 0x0A8)); // 0270D7721608 0xA8 M_TouchSchemeIndex          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_JoystickSchemeIndex                     = GetInt32(new IntPtr(p + 0x0AC)); // 0270D7721628 0xAC M_JoystickSchemeIndex       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_XRSchemeIndex                           = GetInt32(new IntPtr(p + 0x0B0)); // 0270D7721648 0xB0 M_XRSchemeIndex             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
