using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 430 M_Label                                  000186774FE0 ModelClassType Label Label Label Pointer
    // 438 M_CheckMark                              0001866B3770 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 440 M_Clickable                              0001865B4CF0 ModelClassType Clickable Clickable Clickable Pointer
    // 448 M_OriginalText                           000186671910 ModelPrimitiveType string string string String
    public partial class BaseBoolField
    {
        public Label?                                   M_Label                                 { get; set; }
        public VisualElement?                           M_CheckMark                             { get; set; }
        public Clickable?                               M_Clickable                             { get; set; }
        public string                                   M_OriginalText                          { get; set; }

        public static BaseBoolField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BaseBoolField();

            value.M_Label                                   = GetObject<Label>(new IntPtr(p + 0x430), ReversePrism.DataModels.Label.FromPointer); // 0270066F0C28 0x430 M_Label                     ( 000186774FE0 ModelClassType Label Label Label Pointer )
            value.M_CheckMark                               = GetObject<VisualElement>(new IntPtr(p + 0x438), ReversePrism.DataModels.VisualElement.FromPointer); // 0270066F0C48 0x438 M_CheckMark                 ( 0001866B3770 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_Clickable                               = GetObject<Clickable>(new IntPtr(p + 0x440), ReversePrism.DataModels.Clickable.FromPointer); // 0270066F0C68 0x440 M_Clickable                 ( 0001865B4CF0 ModelClassType Clickable Clickable Clickable Pointer )
            value.M_OriginalText                            = GetString(new IntPtr(p + 0x448)); // 0270066F0C88 0x448 M_OriginalText              ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
