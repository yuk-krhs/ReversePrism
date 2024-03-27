using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ussClassName                             string IL2CPP_TYPE_STRING
    // 008 labelUssClassName                        string IL2CPP_TYPE_STRING
    // 010 InputUssClassName                        000186674040 ModelPrimitiveType string string string String
    // 018 CheckmarkBackgroundUssClassName          000186674040 ModelPrimitiveType string string string String
    // 020 CheckmarkUssClassName                    000186674040 ModelPrimitiveType string string string String
    // 028 TextUssClassName                         000186674040 ModelPrimitiveType string string string String
    // 450 M_CheckmarkBackground                    0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer
    public partial class RadioButton
    {
        public string                                   InputUssClassName                       { get; set; }
        public string                                   CheckmarkBackgroundUssClassName         { get; set; }
        public string                                   CheckmarkUssClassName                   { get; set; }
        public string                                   TextUssClassName                        { get; set; }
        public VisualElement?                           M_CheckmarkBackground                   { get; set; }

        public static RadioButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RadioButton();

            value.InputUssClassName                         = GetString(new IntPtr(p + 0x010)); // 02700672F500 0x10 InputUssClassName           ( 000186674040 ModelPrimitiveType string string string String )
            value.CheckmarkBackgroundUssClassName           = GetString(new IntPtr(p + 0x018)); // 02700672F520 0x18 CheckmarkBackgroundUssClassName ( 000186674040 ModelPrimitiveType string string string String )
            value.CheckmarkUssClassName                     = GetString(new IntPtr(p + 0x020)); // 02700672F540 0x20 CheckmarkUssClassName       ( 000186674040 ModelPrimitiveType string string string String )
            value.TextUssClassName                          = GetString(new IntPtr(p + 0x028)); // 02700672F560 0x28 TextUssClassName            ( 000186674040 ModelPrimitiveType string string string String )
            value.M_CheckmarkBackground                     = GetObject<VisualElement>(new IntPtr(p + 0x450), ReversePrism.DataModels.VisualElement.FromPointer); // 02700672F580 0x450 M_CheckmarkBackground       ( 0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer )

            return value;
        }
    }
}
