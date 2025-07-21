using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AttributeName                            ModelPrimitiveType string string string String
    // 018 DataType                                 ModelPrimitiveType string string string String
    // 020 Type                                     ModelClassType Type Type Type Pointer
    // 028 Form                                     ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32
    // 030 Ns                                       ModelPrimitiveType string string string String
    public partial class XmlAttributeAttribute : DataModel
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
            var value   = new XmlAttributeAttribute() { Pointer= p0 };

            value.AttributeName                             = GetString(new IntPtr(p + 0x010)); // 0x10 AttributeName               ( ModelPrimitiveType string string string String )
            value.DataType                                  = GetString(new IntPtr(p + 0x018)); // 0x18 DataType                    ( ModelPrimitiveType string string string String )
            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 0x20 Type                        ( ModelClassType Type Type Type Pointer )
            value.Form                                      = (XmlSchemaForm)GetInt32(new IntPtr(p + 0x028)); // 0x28 Form                        ( ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32 )
            value.Ns                                        = GetString(new IntPtr(p + 0x030)); // 0x30 Ns                          ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
