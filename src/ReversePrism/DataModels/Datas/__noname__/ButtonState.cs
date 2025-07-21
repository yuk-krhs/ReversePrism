using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Button                                 ModelEnumType InputButton InputButton InputButton Int32
    // 018 M_EventData                              ModelClassType MouseButtonEventData MouseButtonEventData MouseButtonEventData Pointer
    public partial class ButtonState : DataModel
    {
        public InputButton                              M_Button                                { get; set; }
        public MouseButtonEventData?                    M_EventData                             { get; set; }

        public static ButtonState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ButtonState() { Pointer= p0 };

            value.M_Button                                  = (InputButton)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Button                    ( ModelEnumType InputButton InputButton InputButton Int32 )
            value.M_EventData                               = GetObject<MouseButtonEventData>(new IntPtr(p + 0x018), ReversePrism.DataModels.MouseButtonEventData.FromPointer); // 0x18 M_EventData                 ( ModelClassType MouseButtonEventData MouseButtonEventData MouseButtonEventData Pointer )

            return value;
        }
    }
}
