using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 170 Trigger                                  0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 178 Stick                                    00018658CCA0 ModelClassType StickControl StickControl StickControl Pointer
    // 180 Twist                                    000186730F50 ModelClassType AxisControl AxisControl AxisControl Pointer
    // 188 Hatswitch                                000186774A20 ModelClassType Vector2Control Vector2Control Vector2Control Pointer
    // 000 <current>k__BackingField                 Joystick IL2CPP_TYPE_CLASS
    // 008 s_JoystickCount                          int IL2CPP_TYPE_I4
    // 010 S_Joysticks                              000185B8EBD0 ModelClassListType Joystick[] Joystick[] List<Joystick> Pointer
    public partial class Joystick
    {
        public ButtonControl?                           Trigger                                 { get; set; }
        public StickControl?                            Stick                                   { get; set; }
        public AxisControl?                             Twist                                   { get; set; }
        public Vector2Control?                          Hatswitch                               { get; set; }
        public List<Joystick>?                          S_Joysticks                             { get; set; }

        public static Joystick? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Joystick();

            value.Trigger                                   = GetObject<ButtonControl>(new IntPtr(p + 0x170), ReversePrism.DataModels.ButtonControl.FromPointer); // 0270033A0770 0x170 Trigger                     ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.Stick                                     = GetObject<StickControl>(new IntPtr(p + 0x178), ReversePrism.DataModels.StickControl.FromPointer); // 0270033A0790 0x178 Stick                       ( 00018658CCA0 ModelClassType StickControl StickControl StickControl Pointer )
            value.Twist                                     = GetObject<AxisControl>(new IntPtr(p + 0x180), ReversePrism.DataModels.AxisControl.FromPointer); // 0270033A07B0 0x180 Twist                       ( 000186730F50 ModelClassType AxisControl AxisControl AxisControl Pointer )
            value.Hatswitch                                 = GetObject<Vector2Control>(new IntPtr(p + 0x188), ReversePrism.DataModels.Vector2Control.FromPointer); // 0270033A07D0 0x188 Hatswitch                   ( 000186774A20 ModelClassType Vector2Control Vector2Control Vector2Control Pointer )
            value.S_Joysticks                               = GetObjectList<Joystick>(new IntPtr(p + 0x010), ReversePrism.DataModels.Joystick.FromPointer); // 0270033A0830 0x10 S_Joysticks                 ( 000185B8EBD0 ModelClassListType Joystick[] Joystick[] List<Joystick> Pointer )

            return value;
        }
    }
}
