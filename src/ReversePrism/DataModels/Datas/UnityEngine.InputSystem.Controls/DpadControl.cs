using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 120 Up                                       0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 128 Down                                     0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 130 Left                                     0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 138 Right                                    0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    public partial class DpadControl : DataModel
    {
        public ButtonControl?                           Up                                      { get; set; }
        public ButtonControl?                           Down                                    { get; set; }
        public ButtonControl?                           Left                                    { get; set; }
        public ButtonControl?                           Right                                   { get; set; }

        public static DpadControl? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DpadControl() { Pointer= p0 };

            value.Up                                        = GetObject<ButtonControl>(new IntPtr(p + 0x120), ReversePrism.DataModels.ButtonControl.FromPointer); // 0245A33953D0 0x120 Up                          ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.Down                                      = GetObject<ButtonControl>(new IntPtr(p + 0x128), ReversePrism.DataModels.ButtonControl.FromPointer); // 0245A33953F0 0x128 Down                        ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.Left                                      = GetObject<ButtonControl>(new IntPtr(p + 0x130), ReversePrism.DataModels.ButtonControl.FromPointer); // 0245A3395410 0x130 Left                        ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.Right                                     = GetObject<ButtonControl>(new IntPtr(p + 0x138), ReversePrism.DataModels.ButtonControl.FromPointer); // 0245A3395430 0x138 Right                       ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )

            return value;
        }
    }
}
