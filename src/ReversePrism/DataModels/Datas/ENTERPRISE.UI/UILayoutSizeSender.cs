using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SenderHorizontalSize                     00018665E780 ModelClassType FloatEvent FloatEvent FloatEvent Pointer
    // 028 SenderVerticalSize                       00018665E780 ModelClassType FloatEvent FloatEvent FloatEvent Pointer
    public partial class UILayoutSizeSender
    {
        public FloatEvent?                              SenderHorizontalSize                    { get; set; }
        public FloatEvent?                              SenderVerticalSize                      { get; set; }

        public static UILayoutSizeSender? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UILayoutSizeSender();

            value.SenderHorizontalSize                      = GetObject<FloatEvent>(new IntPtr(p + 0x020), ReversePrism.DataModels.FloatEvent.FromPointer); // 0270D0DC3088 0x20 SenderHorizontalSize        ( 00018665E780 ModelClassType FloatEvent FloatEvent FloatEvent Pointer )
            value.SenderVerticalSize                        = GetObject<FloatEvent>(new IntPtr(p + 0x028), ReversePrism.DataModels.FloatEvent.FromPointer); // 0270D0DC30A8 0x28 SenderVerticalSize          ( 00018665E780 ModelClassType FloatEvent FloatEvent FloatEvent Pointer )

            return value;
        }
    }
}
