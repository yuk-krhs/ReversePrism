using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 238 LeftTriggerButton                        ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 240 RightTriggerButton                       ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 248 PlayStationButton                        ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    public partial class DualShock3GamepadHID : DataModel
    {
        public ButtonControl?                           LeftTriggerButton                       { get; set; }
        public ButtonControl?                           RightTriggerButton                      { get; set; }
        public ButtonControl?                           PlayStationButton                       { get; set; }

        public static DualShock3GamepadHID? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DualShock3GamepadHID() { Pointer= p0 };

            value.LeftTriggerButton                         = GetObject<ButtonControl>(new IntPtr(p + 0x238), ReversePrism.DataModels.ButtonControl.FromPointer); // 0x238 LeftTriggerButton           ( ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.RightTriggerButton                        = GetObject<ButtonControl>(new IntPtr(p + 0x240), ReversePrism.DataModels.ButtonControl.FromPointer); // 0x240 RightTriggerButton          ( ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.PlayStationButton                         = GetObject<ButtonControl>(new IntPtr(p + 0x248), ReversePrism.DataModels.ButtonControl.FromPointer); // 0x248 PlayStationButton           ( ModelClassType ButtonControl ButtonControl ButtonControl Pointer )

            return value;
        }
    }
}
