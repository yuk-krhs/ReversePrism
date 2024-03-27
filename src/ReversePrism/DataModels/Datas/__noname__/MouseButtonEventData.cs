using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ButtonState                              000186584290 ModelEnumType FramePressState FramePressState FramePressState Int32
    // 018 ButtonData                               000186642720 ModelClassType PointerEventData PointerEventData PointerEventData Pointer
    public partial class MouseButtonEventData
    {
        public FramePressState                          ButtonState                             { get; set; }
        public PointerEventData?                        ButtonData                              { get; set; }

        public static MouseButtonEventData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MouseButtonEventData();

            value.ButtonState                               = (FramePressState)GetInt32(new IntPtr(p + 0x010)); // 027004A4EA40 0x10 ButtonState                 ( 000186584290 ModelEnumType FramePressState FramePressState FramePressState Int32 )
            value.ButtonData                                = GetObject<PointerEventData>(new IntPtr(p + 0x018), ReversePrism.DataModels.PointerEventData.FromPointer); // 027004A4EA60 0x18 ButtonData                  ( 000186642720 ModelClassType PointerEventData PointerEventData PointerEventData Pointer )

            return value;
        }
    }
}
