using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DataType                                 000186671910 ModelPrimitiveType string string string String
    // 018 ElementName                              000186671910 ModelPrimitiveType string string string String
    // 020 Form                                     0001865B66F0 ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32
    // 028 Ns                                       000186671910 ModelPrimitiveType string string string String
    // 030 IsNullable                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 Type                                     000186692850 ModelClassType Type Type Type Pointer
    // 040 Order                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class XmlElementAttribute
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
            var value   = new XmlElementAttribute();

            value.DataType                                  = GetString(new IntPtr(p + 0x010)); // 0270D74B8A68 0x10 DataType                    ( 000186671910 ModelPrimitiveType string string string String )
            value.ElementName                               = GetString(new IntPtr(p + 0x018)); // 0270D74B8A88 0x18 ElementName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.Form                                      = (XmlSchemaForm)GetInt32(new IntPtr(p + 0x020)); // 0270D74B8AA8 0x20 Form                        ( 0001865B66F0 ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32 )
            value.Ns                                        = GetString(new IntPtr(p + 0x028)); // 0270D74B8AC8 0x28 Ns                          ( 000186671910 ModelPrimitiveType string string string String )
            value.IsNullable                                = GetBool(new IntPtr(p + 0x030)); // 0270D74B8AE8 0x30 IsNullable                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x038), ReversePrism.DataModels.Type.FromPointer); // 0270D74B8B08 0x38 Type                        ( 000186692850 ModelClassType Type Type Type Pointer )
            value.Order                                     = GetInt32(new IntPtr(p + 0x040)); // 0270D74B8B28 0x40 Order                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
