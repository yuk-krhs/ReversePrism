using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 ElementInfo                              ModelClassType XmlTypeMapElementInfoList XmlTypeMapElementInfoList XmlTypeMapElementInfoList Pointer
    // 060 ChoiceMember                             ModelPrimitiveType string string string String
    // 068 IsTextCollector                          ModelPrimitiveType bool bool bool Bool
    // 070 ChoiceTypeData                           ModelClassType TypeData TypeData TypeData Pointer
    public partial class XmlTypeMapMemberElement : DataModel
    {
        public XmlTypeMapElementInfoList?               ElementInfo                             { get; set; }
        public string                                   ChoiceMember                            { get; set; }
        public bool                                     IsTextCollector                         { get; set; }
        public TypeData?                                ChoiceTypeData                          { get; set; }

        public static XmlTypeMapMemberElement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlTypeMapMemberElement() { Pointer= p0 };

            value.ElementInfo                               = GetObject<XmlTypeMapElementInfoList>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlTypeMapElementInfoList.FromPointer); // 0x58 ElementInfo                 ( ModelClassType XmlTypeMapElementInfoList XmlTypeMapElementInfoList XmlTypeMapElementInfoList Pointer )
            value.ChoiceMember                              = GetString(new IntPtr(p + 0x060)); // 0x60 ChoiceMember                ( ModelPrimitiveType string string string String )
            value.IsTextCollector                           = GetBool(new IntPtr(p + 0x068)); // 0x68 IsTextCollector             ( ModelPrimitiveType bool bool bool Bool )
            value.ChoiceTypeData                            = GetObject<TypeData>(new IntPtr(p + 0x070), ReversePrism.DataModels.TypeData.FromPointer); // 0x70 ChoiceTypeData              ( ModelClassType TypeData TypeData TypeData Pointer )

            return value;
        }
    }
}
