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
    // 010 InputUssClassName                        ModelPrimitiveType string string string String
    // 018 CheckmarkBackgroundUssClassName          ModelPrimitiveType string string string String
    // 020 CheckmarkUssClassName                    ModelPrimitiveType string string string String
    // 028 TextUssClassName                         ModelPrimitiveType string string string String
    // 460 M_CheckmarkBackground                    ModelClassType VisualElement VisualElement VisualElement Pointer
    public partial class RadioButton : DataModel
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
            var value   = new RadioButton() { Pointer= p0 };

            value.InputUssClassName                         = GetString(new IntPtr(p + 0x010)); // 0x10 InputUssClassName           ( ModelPrimitiveType string string string String )
            value.CheckmarkBackgroundUssClassName           = GetString(new IntPtr(p + 0x018)); // 0x18 CheckmarkBackgroundUssClassName ( ModelPrimitiveType string string string String )
            value.CheckmarkUssClassName                     = GetString(new IntPtr(p + 0x020)); // 0x20 CheckmarkUssClassName       ( ModelPrimitiveType string string string String )
            value.TextUssClassName                          = GetString(new IntPtr(p + 0x028)); // 0x28 TextUssClassName            ( ModelPrimitiveType string string string String )
            value.M_CheckmarkBackground                     = GetObject<VisualElement>(new IntPtr(p + 0x460), ReversePrism.DataModels.VisualElement.FromPointer); // 0x460 M_CheckmarkBackground       ( ModelClassType VisualElement VisualElement VisualElement Pointer )

            return value;
        }
    }
}
