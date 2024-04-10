using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0F8 EmitXsiType                              000186726330 ModelEnumType EmitTypeInformation EmitTypeInformation EmitTypeInformation Int32
    // 0FC PerCallXsiTypeAlreadyEmitted             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0FD UseSimpleDictionaryFormat                000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class XmlObjectSerializerWriteContextComplexJson : DataModel
    {
        public EmitTypeInformation                      EmitXsiType                             { get; set; }
        public bool                                     PerCallXsiTypeAlreadyEmitted            { get; set; }
        public bool                                     UseSimpleDictionaryFormat               { get; set; }

        public static XmlObjectSerializerWriteContextComplexJson? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlObjectSerializerWriteContextComplexJson() { Pointer= p0 };

            value.EmitXsiType                               = (EmitTypeInformation)GetInt32(new IntPtr(p + 0x0F8)); // 0245A4DD0F20 0xF8 EmitXsiType                 ( 000186726330 ModelEnumType EmitTypeInformation EmitTypeInformation EmitTypeInformation Int32 )
            value.PerCallXsiTypeAlreadyEmitted              = GetBool(new IntPtr(p + 0x0FC)); // 0245A4DD0F40 0xFC PerCallXsiTypeAlreadyEmitted ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UseSimpleDictionaryFormat                 = GetBool(new IntPtr(p + 0x0FD)); // 0245A4DD0F60 0xFD UseSimpleDictionaryFormat   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
