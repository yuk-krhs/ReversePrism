using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 1F0 TouchpadButton                           0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 1F8 OptionsButton                            0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 200 ShareButton                              0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 208 L1                                       0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 210 R1                                       0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 218 L2                                       0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 220 R2                                       0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 228 L3                                       0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 230 R3                                       0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 000 <current>k__BackingField                 DualShockGamepad IL2CPP_TYPE_CLASS
    public partial class DualShockGamepad
    {
        public ButtonControl?                           TouchpadButton                          { get; set; }
        public ButtonControl?                           OptionsButton                           { get; set; }
        public ButtonControl?                           ShareButton                             { get; set; }
        public ButtonControl?                           L1                                      { get; set; }
        public ButtonControl?                           R1                                      { get; set; }
        public ButtonControl?                           L2                                      { get; set; }
        public ButtonControl?                           R2                                      { get; set; }
        public ButtonControl?                           L3                                      { get; set; }
        public ButtonControl?                           R3                                      { get; set; }

        public static DualShockGamepad? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DualShockGamepad();

            value.TouchpadButton                            = GetObject<ButtonControl>(new IntPtr(p + 0x1F0), ReversePrism.DataModels.ButtonControl.FromPointer); // 0270033D7F10 0x1F0 TouchpadButton              ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.OptionsButton                             = GetObject<ButtonControl>(new IntPtr(p + 0x1F8), ReversePrism.DataModels.ButtonControl.FromPointer); // 0270033D7F30 0x1F8 OptionsButton               ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.ShareButton                               = GetObject<ButtonControl>(new IntPtr(p + 0x200), ReversePrism.DataModels.ButtonControl.FromPointer); // 0270033D7F50 0x200 ShareButton                 ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.L1                                        = GetObject<ButtonControl>(new IntPtr(p + 0x208), ReversePrism.DataModels.ButtonControl.FromPointer); // 0270033D7F70 0x208 L1                          ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.R1                                        = GetObject<ButtonControl>(new IntPtr(p + 0x210), ReversePrism.DataModels.ButtonControl.FromPointer); // 0270033D7F90 0x210 R1                          ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.L2                                        = GetObject<ButtonControl>(new IntPtr(p + 0x218), ReversePrism.DataModels.ButtonControl.FromPointer); // 0270033D7FB0 0x218 L2                          ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.R2                                        = GetObject<ButtonControl>(new IntPtr(p + 0x220), ReversePrism.DataModels.ButtonControl.FromPointer); // 0270033D7FD0 0x220 R2                          ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.L3                                        = GetObject<ButtonControl>(new IntPtr(p + 0x228), ReversePrism.DataModels.ButtonControl.FromPointer); // 0270033D7FF0 0x228 L3                          ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.R3                                        = GetObject<ButtonControl>(new IntPtr(p + 0x230), ReversePrism.DataModels.ButtonControl.FromPointer); // 0270033D8010 0x230 R3                          ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )

            return value;
        }
    }
}
