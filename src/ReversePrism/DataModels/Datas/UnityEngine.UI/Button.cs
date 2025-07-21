using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 100 M_OnClick                                ModelClassType ButtonClickedEvent ButtonClickedEvent ButtonClickedEvent Pointer
    public partial class Button : DataModel
    {
        public ButtonClickedEvent?                      M_OnClick                               { get; set; }

        public static Button? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Button() { Pointer= p0 };

            value.M_OnClick                                 = GetObject<ButtonClickedEvent>(new IntPtr(p + 0x100), ReversePrism.DataModels.ButtonClickedEvent.FromPointer); // 0x100 M_OnClick                   ( ModelClassType ButtonClickedEvent ButtonClickedEvent ButtonClickedEvent Pointer )

            return value;
        }
    }
}
