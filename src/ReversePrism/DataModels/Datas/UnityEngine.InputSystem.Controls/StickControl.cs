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
    public partial class StickControl : DataModel
    {
        public ButtonControl?                           Up                                      { get; set; }
        public ButtonControl?                           Down                                    { get; set; }
        public ButtonControl?                           Left                                    { get; set; }
        public ButtonControl?                           Right                                   { get; set; }

        public static StickControl? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StickControl() { Pointer= p0 };

            value.Up                                        = GetObject<ButtonControl>(new IntPtr(p + 0x120), ReversePrism.DataModels.ButtonControl.FromPointer); // 0245A3394CF0 0x120 Up                          ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.Down                                      = GetObject<ButtonControl>(new IntPtr(p + 0x128), ReversePrism.DataModels.ButtonControl.FromPointer); // 0245A3394D10 0x128 Down                        ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.Left                                      = GetObject<ButtonControl>(new IntPtr(p + 0x130), ReversePrism.DataModels.ButtonControl.FromPointer); // 0245A3394D30 0x130 Left                        ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.Right                                     = GetObject<ButtonControl>(new IntPtr(p + 0x138), ReversePrism.DataModels.ButtonControl.FromPointer); // 0245A3394D50 0x138 Right                       ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )

            return value;
        }
    }
}
