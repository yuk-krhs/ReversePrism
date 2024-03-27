using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AttributeName                            000186671910 ModelPrimitiveType string string string String
    // 018 DataType                                 000186671910 ModelPrimitiveType string string string String
    // 020 Type                                     000186692850 ModelClassType Type Type Type Pointer
    // 028 Form                                     0001865B66F0 ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32
    // 030 Ns                                       000186671910 ModelPrimitiveType string string string String
    public partial class XmlAttributeAttribute
    {
        public string                                   AttributeName                           { get; set; }
        public string                                   DataType                                { get; set; }
        public Type?                                    Type                                    { get; set; }
        public XmlSchemaForm                            Form                                    { get; set; }
        public string                                   Ns                                      { get; set; }

        public static XmlAttributeAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlAttributeAttribute();

            value.AttributeName                             = GetString(new IntPtr(p + 0x010)); // 0270D74B6BB0 0x10 AttributeName               ( 000186671910 ModelPrimitiveType string string string String )
            value.DataType                                  = GetString(new IntPtr(p + 0x018)); // 0270D74B6BD0 0x18 DataType                    ( 000186671910 ModelPrimitiveType string string string String )
            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 0270D74B6BF0 0x20 Type                        ( 000186692850 ModelClassType Type Type Type Pointer )
            value.Form                                      = (XmlSchemaForm)GetInt32(new IntPtr(p + 0x028)); // 0270D74B6C10 0x28 Form                        ( 0001865B66F0 ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32 )
            value.Ns                                        = GetString(new IntPtr(p + 0x030)); // 0270D74B6C30 0x30 Ns                          ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
