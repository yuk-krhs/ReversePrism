using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 430 M_EnumType                               000186692850 ModelClassType Type Type Type Pointer
    // 438 M_IncludeObsoleteValues                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 440 M_TextElement                            000186638B30 ModelClassType TextElement TextElement TextElement Pointer
    // 448 M_ArrowElement                           0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 450 M_EnumData                               0001865C7EE0 ModelEnumType EnumData EnumData EnumData Int32
    // 490 createMenuCallback                       Func`1<IGenericMenu> IL2CPP_TYPE_GENERICINST
    // 000 ussClassName                             string IL2CPP_TYPE_STRING
    // 008 textUssClassName                         string IL2CPP_TYPE_STRING
    // 010 ArrowUssClassName                        000186674040 ModelPrimitiveType string string string String
    // 018 LabelUssClassName                        000186674040 ModelPrimitiveType string string string String
    // 020 InputUssClassName                        000186674040 ModelPrimitiveType string string string String
    public partial class EnumField
    {
        public Type?                                    M_EnumType                              { get; set; }
        public bool                                     M_IncludeObsoleteValues                 { get; set; }
        public TextElement?                             M_TextElement                           { get; set; }
        public VisualElement?                           M_ArrowElement                          { get; set; }
        public EnumData                                 M_EnumData                              { get; set; }
        public string                                   ArrowUssClassName                       { get; set; }
        public string                                   LabelUssClassName                       { get; set; }
        public string                                   InputUssClassName                       { get; set; }

        public static EnumField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnumField();

            value.M_EnumType                                = GetObject<Type>(new IntPtr(p + 0x430), ReversePrism.DataModels.Type.FromPointer); // 0270050ADA98 0x430 M_EnumType                  ( 000186692850 ModelClassType Type Type Type Pointer )
            value.M_IncludeObsoleteValues                   = GetBool(new IntPtr(p + 0x438)); // 0270050ADAB8 0x438 M_IncludeObsoleteValues     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_TextElement                             = GetObject<TextElement>(new IntPtr(p + 0x440), ReversePrism.DataModels.TextElement.FromPointer); // 0270050ADAD8 0x440 M_TextElement               ( 000186638B30 ModelClassType TextElement TextElement TextElement Pointer )
            value.M_ArrowElement                            = GetObject<VisualElement>(new IntPtr(p + 0x448), ReversePrism.DataModels.VisualElement.FromPointer); // 0270050ADAF8 0x448 M_ArrowElement              ( 0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_EnumData                                = (EnumData)GetInt32(new IntPtr(p + 0x450)); // 0270050ADB18 0x450 M_EnumData                  ( 0001865C7EE0 ModelEnumType EnumData EnumData EnumData Int32 )
            value.ArrowUssClassName                         = GetString(new IntPtr(p + 0x010)); // 0270050ADB98 0x10 ArrowUssClassName           ( 000186674040 ModelPrimitiveType string string string String )
            value.LabelUssClassName                         = GetString(new IntPtr(p + 0x018)); // 0270050ADBB8 0x18 LabelUssClassName           ( 000186674040 ModelPrimitiveType string string string String )
            value.InputUssClassName                         = GetString(new IntPtr(p + 0x020)); // 0270050ADBD8 0x20 InputUssClassName           ( 000186674040 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
