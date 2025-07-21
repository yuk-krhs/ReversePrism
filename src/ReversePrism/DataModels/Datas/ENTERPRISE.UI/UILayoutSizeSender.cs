using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SenderHorizontalSize                     ModelClassType FloatEvent FloatEvent FloatEvent Pointer
    // 028 SenderVerticalSize                       ModelClassType FloatEvent FloatEvent FloatEvent Pointer
    public partial class UILayoutSizeSender : DataModel
    {
        public FloatEvent?                              SenderHorizontalSize                    { get; set; }
        public FloatEvent?                              SenderVerticalSize                      { get; set; }

        public static UILayoutSizeSender? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UILayoutSizeSender() { Pointer= p0 };

            value.SenderHorizontalSize                      = GetObject<FloatEvent>(new IntPtr(p + 0x020), ReversePrism.DataModels.FloatEvent.FromPointer); // 0x20 SenderHorizontalSize        ( ModelClassType FloatEvent FloatEvent FloatEvent Pointer )
            value.SenderVerticalSize                        = GetObject<FloatEvent>(new IntPtr(p + 0x028), ReversePrism.DataModels.FloatEvent.FromPointer); // 0x28 SenderVerticalSize          ( ModelClassType FloatEvent FloatEvent FloatEvent Pointer )

            return value;
        }
    }
}
