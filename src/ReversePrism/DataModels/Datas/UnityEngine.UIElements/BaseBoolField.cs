using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 440 M_Label                                  ModelClassType Label Label Label Pointer
    // 448 M_CheckMark                              ModelClassType VisualElement VisualElement VisualElement Pointer
    // 450 M_Clickable                              ModelClassType Clickable Clickable Clickable Pointer
    // 458 M_OriginalText                           ModelPrimitiveType string string string String
    public partial class BaseBoolField : DataModel
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
            var value   = new BaseBoolField() { Pointer= p0 };

            value.M_Label                                   = GetObject<Label>(new IntPtr(p + 0x440), ReversePrism.DataModels.Label.FromPointer); // 0x440 M_Label                     ( ModelClassType Label Label Label Pointer )
            value.M_CheckMark                               = GetObject<VisualElement>(new IntPtr(p + 0x448), ReversePrism.DataModels.VisualElement.FromPointer); // 0x448 M_CheckMark                 ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_Clickable                               = GetObject<Clickable>(new IntPtr(p + 0x450), ReversePrism.DataModels.Clickable.FromPointer); // 0x450 M_Clickable                 ( ModelClassType Clickable Clickable Clickable Pointer )
            value.M_OriginalText                            = GetString(new IntPtr(p + 0x458)); // 0x458 M_OriginalText              ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
