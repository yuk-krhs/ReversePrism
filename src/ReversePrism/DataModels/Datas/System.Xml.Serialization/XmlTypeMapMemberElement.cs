using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 ElementInfo                              0001865CFBB0 ModelClassType XmlTypeMapElementInfoList XmlTypeMapElementInfoList XmlTypeMapElementInfoList Pointer
    // 060 ChoiceMember                             000186671910 ModelPrimitiveType string string string String
    // 068 IsTextCollector                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 070 ChoiceTypeData                           0001866D2C90 ModelClassType TypeData TypeData TypeData Pointer
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

            value.ElementInfo                               = GetObject<XmlTypeMapElementInfoList>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlTypeMapElementInfoList.FromPointer); // 024667530448 0x58 ElementInfo                 ( 0001865CFBB0 ModelClassType XmlTypeMapElementInfoList XmlTypeMapElementInfoList XmlTypeMapElementInfoList Pointer )
            value.ChoiceMember                              = GetString(new IntPtr(p + 0x060)); // 024667530468 0x60 ChoiceMember                ( 000186671910 ModelPrimitiveType string string string String )
            value.IsTextCollector                           = GetBool(new IntPtr(p + 0x068)); // 024667530488 0x68 IsTextCollector             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ChoiceTypeData                            = GetObject<TypeData>(new IntPtr(p + 0x070), ReversePrism.DataModels.TypeData.FromPointer); // 0246675304A8 0x70 ChoiceTypeData              ( 0001866D2C90 ModelClassType TypeData TypeData TypeData Pointer )

            return value;
        }
    }
}
