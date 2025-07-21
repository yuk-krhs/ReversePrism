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
    // 010 IconUssClassName                         ModelPrimitiveType string string string String
    // 018 IconInfoUssClassName                     ModelPrimitiveType string string string String
    // 020 IconwarningUssClassName                  ModelPrimitiveType string string string String
    // 028 IconErrorUssClassName                    ModelPrimitiveType string string string String
    // 3C8 M_HelpBoxMessageType                     ModelEnumType HelpBoxMessageType HelpBoxMessageType HelpBoxMessageType Int32
    // 3D0 M_Icon                                   ModelClassType VisualElement VisualElement VisualElement Pointer
    // 3D8 M_IconClass                              ModelPrimitiveType string string string String
    // 3E0 M_Label                                  ModelClassType Label Label Label Pointer
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

            value.IconUssClassName                          = GetString(new IntPtr(p + 0x010)); // 0x10 IconUssClassName            ( ModelPrimitiveType string string string String )
            value.IconInfoUssClassName                      = GetString(new IntPtr(p + 0x018)); // 0x18 IconInfoUssClassName        ( ModelPrimitiveType string string string String )
            value.IconwarningUssClassName                   = GetString(new IntPtr(p + 0x020)); // 0x20 IconwarningUssClassName     ( ModelPrimitiveType string string string String )
            value.IconErrorUssClassName                     = GetString(new IntPtr(p + 0x028)); // 0x28 IconErrorUssClassName       ( ModelPrimitiveType string string string String )
            value.M_HelpBoxMessageType                      = (HelpBoxMessageType)GetInt32(new IntPtr(p + 0x3C8)); // 0x3C8 M_HelpBoxMessageType        ( ModelEnumType HelpBoxMessageType HelpBoxMessageType HelpBoxMessageType Int32 )
            value.M_Icon                                    = GetObject<VisualElement>(new IntPtr(p + 0x3D0), ReversePrism.DataModels.VisualElement.FromPointer); // 0x3D0 M_Icon                      ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_IconClass                               = GetString(new IntPtr(p + 0x3D8)); // 0x3D8 M_IconClass                 ( ModelPrimitiveType string string string String )
            value.M_Label                                   = GetObject<Label>(new IntPtr(p + 0x3E0), ReversePrism.DataModels.Label.FromPointer); // 0x3E0 M_Label                     ( ModelClassType Label Label Label Pointer )

            return value;
        }
    }
}
