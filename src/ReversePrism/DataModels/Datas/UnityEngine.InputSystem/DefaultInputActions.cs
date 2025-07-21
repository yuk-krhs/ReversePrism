using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Asset                                    ModelClassType InputActionAsset InputActionAsset InputActionAsset Pointer
    // 018 M_Player                                 ModelClassType InputActionMap InputActionMap InputActionMap Pointer
    // 020 M_PlayerActionsCallbackInterface         ModelClassType IPlayerActions IPlayerActions IPlayerActions Pointer
    // 028 M_Player_Move                            ModelClassType InputAction InputAction InputAction Pointer
    // 030 M_Player_Look                            ModelClassType InputAction InputAction InputAction Pointer
    // 038 M_Player_Fire                            ModelClassType InputAction InputAction InputAction Pointer
    // 040 M_UI                                     ModelClassType InputActionMap InputActionMap InputActionMap Pointer
    // 048 M_UIActionsCallbackInterface             ModelClassType IUIActions IUIActions IUIActions Pointer
    // 050 M_UI_Navigate                            ModelClassType InputAction InputAction InputAction Pointer
    // 058 M_UI_Submit                              ModelClassType InputAction InputAction InputAction Pointer
    // 060 M_UI_Cancel                              ModelClassType InputAction InputAction InputAction Pointer
    // 068 M_UI_Point                               ModelClassType InputAction InputAction InputAction Pointer
    // 070 M_UI_Click                               ModelClassType InputAction InputAction InputAction Pointer
    // 078 M_UI_ScrollWheel                         ModelClassType InputAction InputAction InputAction Pointer
    // 080 M_UI_MiddleClick                         ModelClassType InputAction InputAction InputAction Pointer
    // 088 M_UI_RightClick                          ModelClassType InputAction InputAction InputAction Pointer
    // 090 M_UI_TrackedDevicePosition               ModelClassType InputAction InputAction InputAction Pointer
    // 098 M_UI_TrackedDeviceOrientation            ModelClassType InputAction InputAction InputAction Pointer
    // 0A0 M_KeyboardMouseSchemeIndex               ModelPrimitiveType int int int Int32
    // 0A4 M_GamepadSchemeIndex                     ModelPrimitiveType int int int Int32
    // 0A8 M_TouchSchemeIndex                       ModelPrimitiveType int int int Int32
    // 0AC M_JoystickSchemeIndex                    ModelPrimitiveType int int int Int32
    // 0B0 M_XRSchemeIndex                          ModelPrimitiveType int int int Int32
    public partial class DefaultInputActions : DataModel
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
            var value   = new DefaultInputActions() { Pointer= p0 };

            value.Asset                                     = GetObject<InputActionAsset>(new IntPtr(p + 0x010), ReversePrism.DataModels.InputActionAsset.FromPointer); // 0x10 Asset                       ( ModelClassType InputActionAsset InputActionAsset InputActionAsset Pointer )
            value.M_Player                                  = GetObject<InputActionMap>(new IntPtr(p + 0x018), ReversePrism.DataModels.InputActionMap.FromPointer); // 0x18 M_Player                    ( ModelClassType InputActionMap InputActionMap InputActionMap Pointer )
            value.M_PlayerActionsCallbackInterface          = GetObject<IPlayerActions>(new IntPtr(p + 0x020), ReversePrism.DataModels.IPlayerActions.FromPointer); // 0x20 M_PlayerActionsCallbackInterface ( ModelClassType IPlayerActions IPlayerActions IPlayerActions Pointer )
            value.M_Player_Move                             = GetObject<InputAction>(new IntPtr(p + 0x028), ReversePrism.DataModels.InputAction.FromPointer); // 0x28 M_Player_Move               ( ModelClassType InputAction InputAction InputAction Pointer )
            value.M_Player_Look                             = GetObject<InputAction>(new IntPtr(p + 0x030), ReversePrism.DataModels.InputAction.FromPointer); // 0x30 M_Player_Look               ( ModelClassType InputAction InputAction InputAction Pointer )
            value.M_Player_Fire                             = GetObject<InputAction>(new IntPtr(p + 0x038), ReversePrism.DataModels.InputAction.FromPointer); // 0x38 M_Player_Fire               ( ModelClassType InputAction InputAction InputAction Pointer )
            value.M_UI                                      = GetObject<InputActionMap>(new IntPtr(p + 0x040), ReversePrism.DataModels.InputActionMap.FromPointer); // 0x40 M_UI                        ( ModelClassType InputActionMap InputActionMap InputActionMap Pointer )
            value.M_UIActionsCallbackInterface              = GetObject<IUIActions>(new IntPtr(p + 0x048), ReversePrism.DataModels.IUIActions.FromPointer); // 0x48 M_UIActionsCallbackInterface ( ModelClassType IUIActions IUIActions IUIActions Pointer )
            value.M_UI_Navigate                             = GetObject<InputAction>(new IntPtr(p + 0x050), ReversePrism.DataModels.InputAction.FromPointer); // 0x50 M_UI_Navigate               ( ModelClassType InputAction InputAction InputAction Pointer )
            value.M_UI_Submit                               = GetObject<InputAction>(new IntPtr(p + 0x058), ReversePrism.DataModels.InputAction.FromPointer); // 0x58 M_UI_Submit                 ( ModelClassType InputAction InputAction InputAction Pointer )
            value.M_UI_Cancel                               = GetObject<InputAction>(new IntPtr(p + 0x060), ReversePrism.DataModels.InputAction.FromPointer); // 0x60 M_UI_Cancel                 ( ModelClassType InputAction InputAction InputAction Pointer )
            value.M_UI_Point                                = GetObject<InputAction>(new IntPtr(p + 0x068), ReversePrism.DataModels.InputAction.FromPointer); // 0x68 M_UI_Point                  ( ModelClassType InputAction InputAction InputAction Pointer )
            value.M_UI_Click                                = GetObject<InputAction>(new IntPtr(p + 0x070), ReversePrism.DataModels.InputAction.FromPointer); // 0x70 M_UI_Click                  ( ModelClassType InputAction InputAction InputAction Pointer )
            value.M_UI_ScrollWheel                          = GetObject<InputAction>(new IntPtr(p + 0x078), ReversePrism.DataModels.InputAction.FromPointer); // 0x78 M_UI_ScrollWheel            ( ModelClassType InputAction InputAction InputAction Pointer )
            value.M_UI_MiddleClick                          = GetObject<InputAction>(new IntPtr(p + 0x080), ReversePrism.DataModels.InputAction.FromPointer); // 0x80 M_UI_MiddleClick            ( ModelClassType InputAction InputAction InputAction Pointer )
            value.M_UI_RightClick                           = GetObject<InputAction>(new IntPtr(p + 0x088), ReversePrism.DataModels.InputAction.FromPointer); // 0x88 M_UI_RightClick             ( ModelClassType InputAction InputAction InputAction Pointer )
            value.M_UI_TrackedDevicePosition                = GetObject<InputAction>(new IntPtr(p + 0x090), ReversePrism.DataModels.InputAction.FromPointer); // 0x90 M_UI_TrackedDevicePosition  ( ModelClassType InputAction InputAction InputAction Pointer )
            value.M_UI_TrackedDeviceOrientation             = GetObject<InputAction>(new IntPtr(p + 0x098), ReversePrism.DataModels.InputAction.FromPointer); // 0x98 M_UI_TrackedDeviceOrientation ( ModelClassType InputAction InputAction InputAction Pointer )
            value.M_KeyboardMouseSchemeIndex                = GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 M_KeyboardMouseSchemeIndex  ( ModelPrimitiveType int int int Int32 )
            value.M_GamepadSchemeIndex                      = GetInt32(new IntPtr(p + 0x0A4)); // 0xA4 M_GamepadSchemeIndex        ( ModelPrimitiveType int int int Int32 )
            value.M_TouchSchemeIndex                        = GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 M_TouchSchemeIndex          ( ModelPrimitiveType int int int Int32 )
            value.M_JoystickSchemeIndex                     = GetInt32(new IntPtr(p + 0x0AC)); // 0xAC M_JoystickSchemeIndex       ( ModelPrimitiveType int int int Int32 )
            value.M_XRSchemeIndex                           = GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 M_XRSchemeIndex             ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
