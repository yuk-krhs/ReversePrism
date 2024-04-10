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
    // 010 IconUssClassName                         000186674040 ModelPrimitiveType string string string String
    // 018 IconInfoUssClassName                     000186674040 ModelPrimitiveType string string string String
    // 020 IconwarningUssClassName                  000186674040 ModelPrimitiveType string string string String
    // 028 IconErrorUssClassName                    000186674040 ModelPrimitiveType string string string String
    // 3C8 M_HelpBoxMessageType                     0001866B03E0 ModelEnumType HelpBoxMessageType HelpBoxMessageType HelpBoxMessageType Int32
    // 3D0 M_Icon                                   0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 3D8 M_IconClass                              000186671910 ModelPrimitiveType string string string String
    // 3E0 M_Label                                  000186774D80 ModelClassType Label Label Label Pointer
    public partial class HelpBox : DataModel
    {
        public string                                   IconUssClassName                        { get; set; }
        public string                                   IconInfoUssClassName                    { get; set; }
        public string                                   IconwarningUssClassName                 { get; set; }
        public string                                   IconErrorUssClassName                   { get; set; }
        public HelpBoxMessageType                       M_HelpBoxMessageType                    { get; set; }
        public VisualElement?                           M_Icon                                  { get; set; }
        public string                                   M_IconClass                             { get; set; }
        public Label?                                   M_Label                                 { get; set; }

        public static HelpBox? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HelpBox() { Pointer= p0 };

            value.IconUssClassName                          = GetString(new IntPtr(p + 0x010)); // 0245A66D6950 0x10 IconUssClassName            ( 000186674040 ModelPrimitiveType string string string String )
            value.IconInfoUssClassName                      = GetString(new IntPtr(p + 0x018)); // 0245A66D6970 0x18 IconInfoUssClassName        ( 000186674040 ModelPrimitiveType string string string String )
            value.IconwarningUssClassName                   = GetString(new IntPtr(p + 0x020)); // 0245A66D6990 0x20 IconwarningUssClassName     ( 000186674040 ModelPrimitiveType string string string String )
            value.IconErrorUssClassName                     = GetString(new IntPtr(p + 0x028)); // 0245A66D69B0 0x28 IconErrorUssClassName       ( 000186674040 ModelPrimitiveType string string string String )
            value.M_HelpBoxMessageType                      = (HelpBoxMessageType)GetInt32(new IntPtr(p + 0x3C8)); // 0245A66D69D0 0x3C8 M_HelpBoxMessageType        ( 0001866B03E0 ModelEnumType HelpBoxMessageType HelpBoxMessageType HelpBoxMessageType Int32 )
            value.M_Icon                                    = GetObject<VisualElement>(new IntPtr(p + 0x3D0), ReversePrism.DataModels.VisualElement.FromPointer); // 0245A66D69F0 0x3D0 M_Icon                      ( 0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_IconClass                               = GetString(new IntPtr(p + 0x3D8)); // 0245A66D6A10 0x3D8 M_IconClass                 ( 000186671910 ModelPrimitiveType string string string String )
            value.M_Label                                   = GetObject<Label>(new IntPtr(p + 0x3E0), ReversePrism.DataModels.Label.FromPointer); // 0245A66D6A30 0x3E0 M_Label                     ( 000186774D80 ModelClassType Label Label Label Pointer )

            return value;
        }
    }
}
