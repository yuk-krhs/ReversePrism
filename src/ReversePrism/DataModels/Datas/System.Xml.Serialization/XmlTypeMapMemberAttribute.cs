using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 AttributeName                            000186671910 ModelPrimitiveType string string string String
    // 060 Namespace                                000186671910 ModelPrimitiveType string string string String
    // 068 Form                                     0001865B66F0 ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32
    // 070 MappedType                               0001865D1D40 ModelClassType XmlTypeMapping XmlTypeMapping XmlTypeMapping Pointer
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

            value.AttributeName                             = GetString(new IntPtr(p + 0x058)); // 024667539AC0 0x58 AttributeName               ( 000186671910 ModelPrimitiveType string string string String )
            value.Namespace                                 = GetString(new IntPtr(p + 0x060)); // 024667539AE0 0x60 Namespace                   ( 000186671910 ModelPrimitiveType string string string String )
            value.Form                                      = (XmlSchemaForm)GetInt32(new IntPtr(p + 0x068)); // 024667539B00 0x68 Form                        ( 0001865B66F0 ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32 )
            value.MappedType                                = GetObject<XmlTypeMapping>(new IntPtr(p + 0x070), ReversePrism.DataModels.XmlTypeMapping.FromPointer); // 024667539B20 0x70 MappedType                  ( 0001865D1D40 ModelClassType XmlTypeMapping XmlTypeMapping XmlTypeMapping Pointer )

            return value;
        }
    }
}
