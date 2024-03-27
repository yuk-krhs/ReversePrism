using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 1A0 Scroll                                   0001866BE040 ModelClassType DeltaControl DeltaControl DeltaControl Pointer
    // 1A8 LeftButton                               0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 1B0 MiddleButton                             0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 1B8 RightButton                              0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 1C0 BackButton                               0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 1C8 ForwardButton                            0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 1D0 ClickCount                               000186715740 ModelClassType IntegerControl IntegerControl IntegerControl Pointer
    // 000 <current>k__BackingField                 Mouse IL2CPP_TYPE_CLASS
    // 008 s_PlatformMouseDevice                    Mouse IL2CPP_TYPE_CLASS
    public partial class Mouse
    {
        public DeltaControl?                            Scroll                                  { get; set; }
        public ButtonControl?                           LeftButton                              { get; set; }
        public ButtonControl?                           MiddleButton                            { get; set; }
        public ButtonControl?                           RightButton                             { get; set; }
        public ButtonControl?                           BackButton                              { get; set; }
        public ButtonControl?                           ForwardButton                           { get; set; }
        public IntegerControl?                          ClickCount                              { get; set; }

        public static Mouse? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Mouse();

            value.Scroll                                    = GetObject<DeltaControl>(new IntPtr(p + 0x1A0), ReversePrism.DataModels.DeltaControl.FromPointer); // 0270033AC640 0x1A0 Scroll                      ( 0001866BE040 ModelClassType DeltaControl DeltaControl DeltaControl Pointer )
            value.LeftButton                                = GetObject<ButtonControl>(new IntPtr(p + 0x1A8), ReversePrism.DataModels.ButtonControl.FromPointer); // 0270033AC660 0x1A8 LeftButton                  ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.MiddleButton                              = GetObject<ButtonControl>(new IntPtr(p + 0x1B0), ReversePrism.DataModels.ButtonControl.FromPointer); // 0270033AC680 0x1B0 MiddleButton                ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.RightButton                               = GetObject<ButtonControl>(new IntPtr(p + 0x1B8), ReversePrism.DataModels.ButtonControl.FromPointer); // 0270033AC6A0 0x1B8 RightButton                 ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.BackButton                                = GetObject<ButtonControl>(new IntPtr(p + 0x1C0), ReversePrism.DataModels.ButtonControl.FromPointer); // 0270033AC6C0 0x1C0 BackButton                  ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.ForwardButton                             = GetObject<ButtonControl>(new IntPtr(p + 0x1C8), ReversePrism.DataModels.ButtonControl.FromPointer); // 0270033AC6E0 0x1C8 ForwardButton               ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.ClickCount                                = GetObject<IntegerControl>(new IntPtr(p + 0x1D0), ReversePrism.DataModels.IntegerControl.FromPointer); // 0270033AC700 0x1D0 ClickCount                  ( 000186715740 ModelClassType IntegerControl IntegerControl IntegerControl Pointer )

            return value;
        }
    }
}
