using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 170 ButtonWest                               0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 178 ButtonNorth                              0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 180 ButtonSouth                              0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 188 ButtonEast                               0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 190 LeftStickButton                          0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 198 RightStickButton                         0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 1A0 StartButton                              0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 1A8 SelectButton                             0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 1B0 Dpad                                     0001866F3AC0 ModelClassType DpadControl DpadControl DpadControl Pointer
    // 1B8 LeftShoulder                             0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 1C0 RightShoulder                            0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 1C8 LeftStick                                00018658CCA0 ModelClassType StickControl StickControl StickControl Pointer
    // 1D0 RightStick                               00018658CCA0 ModelClassType StickControl StickControl StickControl Pointer
    // 1D8 LeftTrigger                              0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 1E0 RightTrigger                             0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 000 <current>k__BackingField                 Gamepad IL2CPP_TYPE_CLASS
    // 1E8 M_Rumble                                 0001867099F0 ModelEnumType DualMotorRumble DualMotorRumble DualMotorRumble Int32
    // 008 s_GamepadCount                           int IL2CPP_TYPE_I4
    // 010 S_Gamepads                               000185B818F0 ModelClassListType Gamepad[] Gamepad[] List<Gamepad> Pointer
    public partial class Gamepad
    {
        public ButtonControl?                           ButtonWest                              { get; set; }
        public ButtonControl?                           ButtonNorth                             { get; set; }
        public ButtonControl?                           ButtonSouth                             { get; set; }
        public ButtonControl?                           ButtonEast                              { get; set; }
        public ButtonControl?                           LeftStickButton                         { get; set; }
        public ButtonControl?                           RightStickButton                        { get; set; }
        public ButtonControl?                           StartButton                             { get; set; }
        public ButtonControl?                           SelectButton                            { get; set; }
        public DpadControl?                             Dpad                                    { get; set; }
        public ButtonControl?                           LeftShoulder                            { get; set; }
        public ButtonControl?                           RightShoulder                           { get; set; }
        public StickControl?                            LeftStick                               { get; set; }
        public StickControl?                            RightStick                              { get; set; }
        public ButtonControl?                           LeftTrigger                             { get; set; }
        public ButtonControl?                           RightTrigger                            { get; set; }
        public DualMotorRumble                          M_Rumble                                { get; set; }
        public List<Gamepad>?                           S_Gamepads                              { get; set; }

        public static Gamepad? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Gamepad();

            value.ButtonWest                                = GetObject<ButtonControl>(new IntPtr(p + 0x170), ReversePrism.DataModels.ButtonControl.FromPointer); // 02700339F680 0x170 ButtonWest                  ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.ButtonNorth                               = GetObject<ButtonControl>(new IntPtr(p + 0x178), ReversePrism.DataModels.ButtonControl.FromPointer); // 02700339F6A0 0x178 ButtonNorth                 ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.ButtonSouth                               = GetObject<ButtonControl>(new IntPtr(p + 0x180), ReversePrism.DataModels.ButtonControl.FromPointer); // 02700339F6C0 0x180 ButtonSouth                 ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.ButtonEast                                = GetObject<ButtonControl>(new IntPtr(p + 0x188), ReversePrism.DataModels.ButtonControl.FromPointer); // 02700339F6E0 0x188 ButtonEast                  ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.LeftStickButton                           = GetObject<ButtonControl>(new IntPtr(p + 0x190), ReversePrism.DataModels.ButtonControl.FromPointer); // 02700339F700 0x190 LeftStickButton             ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.RightStickButton                          = GetObject<ButtonControl>(new IntPtr(p + 0x198), ReversePrism.DataModels.ButtonControl.FromPointer); // 02700339F720 0x198 RightStickButton            ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.StartButton                               = GetObject<ButtonControl>(new IntPtr(p + 0x1A0), ReversePrism.DataModels.ButtonControl.FromPointer); // 02700339F740 0x1A0 StartButton                 ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.SelectButton                              = GetObject<ButtonControl>(new IntPtr(p + 0x1A8), ReversePrism.DataModels.ButtonControl.FromPointer); // 02700339F760 0x1A8 SelectButton                ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.Dpad                                      = GetObject<DpadControl>(new IntPtr(p + 0x1B0), ReversePrism.DataModels.DpadControl.FromPointer); // 02700339F780 0x1B0 Dpad                        ( 0001866F3AC0 ModelClassType DpadControl DpadControl DpadControl Pointer )
            value.LeftShoulder                              = GetObject<ButtonControl>(new IntPtr(p + 0x1B8), ReversePrism.DataModels.ButtonControl.FromPointer); // 02700339F7A0 0x1B8 LeftShoulder                ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.RightShoulder                             = GetObject<ButtonControl>(new IntPtr(p + 0x1C0), ReversePrism.DataModels.ButtonControl.FromPointer); // 02700339F7C0 0x1C0 RightShoulder               ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.LeftStick                                 = GetObject<StickControl>(new IntPtr(p + 0x1C8), ReversePrism.DataModels.StickControl.FromPointer); // 02700339F7E0 0x1C8 LeftStick                   ( 00018658CCA0 ModelClassType StickControl StickControl StickControl Pointer )
            value.RightStick                                = GetObject<StickControl>(new IntPtr(p + 0x1D0), ReversePrism.DataModels.StickControl.FromPointer); // 02700339F800 0x1D0 RightStick                  ( 00018658CCA0 ModelClassType StickControl StickControl StickControl Pointer )
            value.LeftTrigger                               = GetObject<ButtonControl>(new IntPtr(p + 0x1D8), ReversePrism.DataModels.ButtonControl.FromPointer); // 02700339F820 0x1D8 LeftTrigger                 ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.RightTrigger                              = GetObject<ButtonControl>(new IntPtr(p + 0x1E0), ReversePrism.DataModels.ButtonControl.FromPointer); // 02700339F840 0x1E0 RightTrigger                ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.M_Rumble                                  = (DualMotorRumble)GetInt32(new IntPtr(p + 0x1E8)); // 02700339F880 0x1E8 M_Rumble                    ( 0001867099F0 ModelEnumType DualMotorRumble DualMotorRumble DualMotorRumble Int32 )
            value.S_Gamepads                                = GetObjectList<Gamepad>(new IntPtr(p + 0x010), ReversePrism.DataModels.Gamepad.FromPointer); // 02700339F8C0 0x10 S_Gamepads                  ( 000185B818F0 ModelClassListType Gamepad[] Gamepad[] List<Gamepad> Pointer )

            return value;
        }
    }
}
