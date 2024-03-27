using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 KeyCount                                 int IL2CPP_TYPE_I4
    // 170 AnyKey                                   0001866C5940 ModelClassType AnyKeyControl AnyKeyControl AnyKeyControl Pointer
    // 178 ShiftKey                                 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 180 CtrlKey                                  0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 188 AltKey                                   0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 190 ImeSelected                              0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 000 <current>k__BackingField                 Keyboard IL2CPP_TYPE_CLASS
    // 198 m_TextInputListeners                     InlinedArray`1<Action`1<char>> IL2CPP_TYPE_GENERICINST
    // 1B0 M_KeyboardLayoutName                     000186671910 ModelPrimitiveType string string string String
    // 1B8 M_Keys                                   000185B8F780 ModelClassListType KeyControl[] KeyControl[] List<KeyControl> Pointer
    // 1C0 m_ImeCompositionListeners                InlinedArray`1<Action`1<IMECompositionString>> IL2CPP_TYPE_GENERICINST
    public partial class Keyboard
    {
        public AnyKeyControl?                           AnyKey                                  { get; set; }
        public ButtonControl?                           ShiftKey                                { get; set; }
        public ButtonControl?                           CtrlKey                                 { get; set; }
        public ButtonControl?                           AltKey                                  { get; set; }
        public ButtonControl?                           ImeSelected                             { get; set; }
        public string                                   M_KeyboardLayoutName                    { get; set; }
        public List<KeyControl>?                        M_Keys                                  { get; set; }

        public static Keyboard? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Keyboard();

            value.AnyKey                                    = GetObject<AnyKeyControl>(new IntPtr(p + 0x170), ReversePrism.DataModels.AnyKeyControl.FromPointer); // 0270033A4180 0x170 AnyKey                      ( 0001866C5940 ModelClassType AnyKeyControl AnyKeyControl AnyKeyControl Pointer )
            value.ShiftKey                                  = GetObject<ButtonControl>(new IntPtr(p + 0x178), ReversePrism.DataModels.ButtonControl.FromPointer); // 0270033A41A0 0x178 ShiftKey                    ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.CtrlKey                                   = GetObject<ButtonControl>(new IntPtr(p + 0x180), ReversePrism.DataModels.ButtonControl.FromPointer); // 0270033A41C0 0x180 CtrlKey                     ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.AltKey                                    = GetObject<ButtonControl>(new IntPtr(p + 0x188), ReversePrism.DataModels.ButtonControl.FromPointer); // 0270033A41E0 0x188 AltKey                      ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.ImeSelected                               = GetObject<ButtonControl>(new IntPtr(p + 0x190), ReversePrism.DataModels.ButtonControl.FromPointer); // 0270033A4200 0x190 ImeSelected                 ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.M_KeyboardLayoutName                      = GetString(new IntPtr(p + 0x1B0)); // 0270033A4260 0x1B0 M_KeyboardLayoutName        ( 000186671910 ModelPrimitiveType string string string String )
            value.M_Keys                                    = GetObjectList<KeyControl>(new IntPtr(p + 0x1B8), ReversePrism.DataModels.KeyControl.FromPointer); // 0270033A4280 0x1B8 M_Keys                      ( 000185B8F780 ModelClassListType KeyControl[] KeyControl[] List<KeyControl> Pointer )

            return value;
        }
    }
}
