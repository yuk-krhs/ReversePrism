using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 440 M_EnumType                               ModelClassType Type Type Type Pointer
    // 448 M_IncludeObsoleteValues                  ModelPrimitiveType bool bool bool Bool
    // 450 M_TextElement                            ModelClassType TextElement TextElement TextElement Pointer
    // 458 M_ArrowElement                           ModelClassType VisualElement VisualElement VisualElement Pointer
    // 460 M_EnumData                               ModelEnumType EnumData EnumData EnumData Int32
    // 4A0 createMenuCallback                       Func`1<IGenericMenu> IL2CPP_TYPE_GENERICINST
    // 000 ussClassName                             string IL2CPP_TYPE_STRING
    // 008 textUssClassName                         string IL2CPP_TYPE_STRING
    // 010 ArrowUssClassName                        ModelPrimitiveType string string string String
    // 018 LabelUssClassName                        ModelPrimitiveType string string string String
    // 020 InputUssClassName                        ModelPrimitiveType string string string String
    public partial class EnumField : DataModel
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
            var value   = new EnumField() { Pointer= p0 };

            value.M_EnumType                                = GetObject<Type>(new IntPtr(p + 0x440), ReversePrism.DataModels.Type.FromPointer); // 0x440 M_EnumType                  ( ModelClassType Type Type Type Pointer )
            value.M_IncludeObsoleteValues                   = GetBool(new IntPtr(p + 0x448)); // 0x448 M_IncludeObsoleteValues     ( ModelPrimitiveType bool bool bool Bool )
            value.M_TextElement                             = GetObject<TextElement>(new IntPtr(p + 0x450), ReversePrism.DataModels.TextElement.FromPointer); // 0x450 M_TextElement               ( ModelClassType TextElement TextElement TextElement Pointer )
            value.M_ArrowElement                            = GetObject<VisualElement>(new IntPtr(p + 0x458), ReversePrism.DataModels.VisualElement.FromPointer); // 0x458 M_ArrowElement              ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_EnumData                                = (EnumData)GetInt32(new IntPtr(p + 0x460)); // 0x460 M_EnumData                  ( ModelEnumType EnumData EnumData EnumData Int32 )
            value.ArrowUssClassName                         = GetString(new IntPtr(p + 0x010)); // 0x10 ArrowUssClassName           ( ModelPrimitiveType string string string String )
            value.LabelUssClassName                         = GetString(new IntPtr(p + 0x018)); // 0x18 LabelUssClassName           ( ModelPrimitiveType string string string String )
            value.InputUssClassName                         = GetString(new IntPtr(p + 0x020)); // 0x20 InputUssClassName           ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
