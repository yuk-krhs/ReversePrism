using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 AttributeName                            ModelPrimitiveType string string string String
    // 060 Namespace                                ModelPrimitiveType string string string String
    // 068 Form                                     ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32
    // 070 MappedType                               ModelClassType XmlTypeMapping XmlTypeMapping XmlTypeMapping Pointer
    public partial class XmlTypeMapMemberAttribute : DataModel
    {
        public string                                   AttributeName                           { get; set; }
        public string                                   Namespace                               { get; set; }
        public XmlSchemaForm                            Form                                    { get; set; }
        public XmlTypeMapping?                          MappedType                              { get; set; }

        public static XmlTypeMapMemberAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlTypeMapMemberAttribute() { Pointer= p0 };

            value.AttributeName                             = GetString(new IntPtr(p + 0x058)); // 0x58 AttributeName               ( ModelPrimitiveType string string string String )
            value.Namespace                                 = GetString(new IntPtr(p + 0x060)); // 0x60 Namespace                   ( ModelPrimitiveType string string string String )
            value.Form                                      = (XmlSchemaForm)GetInt32(new IntPtr(p + 0x068)); // 0x68 Form                        ( ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32 )
            value.MappedType                                = GetObject<XmlTypeMapping>(new IntPtr(p + 0x070), ReversePrism.DataModels.XmlTypeMapping.FromPointer); // 0x70 MappedType                  ( ModelClassType XmlTypeMapping XmlTypeMapping XmlTypeMapping Pointer )

            return value;
        }
    }
}
