using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DataType                                 ModelPrimitiveType string string string String
    // 018 ElementName                              ModelPrimitiveType string string string String
    // 020 Form                                     ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32
    // 028 Ns                                       ModelPrimitiveType string string string String
    // 030 IsNullable                               ModelPrimitiveType bool bool bool Bool
    // 038 Type                                     ModelClassType Type Type Type Pointer
    // 040 Order                                    ModelPrimitiveType int int int Int32
    public partial class XmlElementAttribute : DataModel
    {
        public string                                   DataType                                { get; set; }
        public string                                   ElementName                             { get; set; }
        public XmlSchemaForm                            Form                                    { get; set; }
        public string                                   Ns                                      { get; set; }
        public bool                                     IsNullable                              { get; set; }
        public Type?                                    Type                                    { get; set; }
        public int                                      Order                                   { get; set; }

        public static XmlElementAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlElementAttribute() { Pointer= p0 };

            value.DataType                                  = GetString(new IntPtr(p + 0x010)); // 0x10 DataType                    ( ModelPrimitiveType string string string String )
            value.ElementName                               = GetString(new IntPtr(p + 0x018)); // 0x18 ElementName                 ( ModelPrimitiveType string string string String )
            value.Form                                      = (XmlSchemaForm)GetInt32(new IntPtr(p + 0x020)); // 0x20 Form                        ( ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32 )
            value.Ns                                        = GetString(new IntPtr(p + 0x028)); // 0x28 Ns                          ( ModelPrimitiveType string string string String )
            value.IsNullable                                = GetBool(new IntPtr(p + 0x030)); // 0x30 IsNullable                  ( ModelPrimitiveType bool bool bool Bool )
            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x038), ReversePrism.DataModels.Type.FromPointer); // 0x38 Type                        ( ModelClassType Type Type Type Pointer )
            value.Order                                     = GetInt32(new IntPtr(p + 0x040)); // 0x40 Order                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
