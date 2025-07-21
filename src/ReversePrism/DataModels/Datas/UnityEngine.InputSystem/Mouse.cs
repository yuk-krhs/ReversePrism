using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 1A0 Scroll                                   ModelClassType DeltaControl DeltaControl DeltaControl Pointer
    // 1A8 LeftButton                               ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 1B0 MiddleButton                             ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 1B8 RightButton                              ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 1C0 BackButton                               ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 1C8 ForwardButton                            ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 1D0 ClickCount                               ModelClassType IntegerControl IntegerControl IntegerControl Pointer
    // 000 <current>k__BackingField                 Mouse IL2CPP_TYPE_CLASS
    // 008 s_PlatformMouseDevice                    Mouse IL2CPP_TYPE_CLASS
    public partial class Mouse : DataModel
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
            var value   = new Mouse() { Pointer= p0 };

            value.Scroll                                    = GetObject<DeltaControl>(new IntPtr(p + 0x1A0), ReversePrism.DataModels.DeltaControl.FromPointer); // 0x1A0 Scroll                      ( ModelClassType DeltaControl DeltaControl DeltaControl Pointer )
            value.LeftButton                                = GetObject<ButtonControl>(new IntPtr(p + 0x1A8), ReversePrism.DataModels.ButtonControl.FromPointer); // 0x1A8 LeftButton                  ( ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.MiddleButton                              = GetObject<ButtonControl>(new IntPtr(p + 0x1B0), ReversePrism.DataModels.ButtonControl.FromPointer); // 0x1B0 MiddleButton                ( ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.RightButton                               = GetObject<ButtonControl>(new IntPtr(p + 0x1B8), ReversePrism.DataModels.ButtonControl.FromPointer); // 0x1B8 RightButton                 ( ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.BackButton                                = GetObject<ButtonControl>(new IntPtr(p + 0x1C0), ReversePrism.DataModels.ButtonControl.FromPointer); // 0x1C0 BackButton                  ( ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.ForwardButton                             = GetObject<ButtonControl>(new IntPtr(p + 0x1C8), ReversePrism.DataModels.ButtonControl.FromPointer); // 0x1C8 ForwardButton               ( ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.ClickCount                                = GetObject<IntegerControl>(new IntPtr(p + 0x1D0), ReversePrism.DataModels.IntegerControl.FromPointer); // 0x1D0 ClickCount                  ( ModelClassType IntegerControl IntegerControl IntegerControl Pointer )

            return value;
        }
    }
}
