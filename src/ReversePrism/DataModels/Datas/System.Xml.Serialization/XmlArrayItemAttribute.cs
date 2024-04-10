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
    // 031 IsNullableSpecified                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 034 NestingLevel                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 Type                                     000186692850 ModelClassType Type Type Type Pointer
    public partial class XmlArrayItemAttribute : DataModel
    {
        public string                                   DataType                                { get; set; }
        public string                                   ElementName                             { get; set; }
        public XmlSchemaForm                            Form                                    { get; set; }
        public string                                   Ns                                      { get; set; }
        public bool                                     IsNullable                              { get; set; }
        public bool                                     IsNullableSpecified                     { get; set; }
        public int                                      NestingLevel                            { get; set; }
        public Type?                                    Type                                    { get; set; }

        public static XmlArrayItemAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlArrayItemAttribute() { Pointer= p0 };

            value.DataType                                  = GetString(new IntPtr(p + 0x010)); // 024667516308 0x10 DataType                    ( 000186671910 ModelPrimitiveType string string string String )
            value.ElementName                               = GetString(new IntPtr(p + 0x018)); // 024667516328 0x18 ElementName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.Form                                      = (XmlSchemaForm)GetInt32(new IntPtr(p + 0x020)); // 024667516348 0x20 Form                        ( 0001865B66F0 ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32 )
            value.Ns                                        = GetString(new IntPtr(p + 0x028)); // 024667516368 0x28 Ns                          ( 000186671910 ModelPrimitiveType string string string String )
            value.IsNullable                                = GetBool(new IntPtr(p + 0x030)); // 024667516388 0x30 IsNullable                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsNullableSpecified                       = GetBool(new IntPtr(p + 0x031)); // 0246675163A8 0x31 IsNullableSpecified         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.NestingLevel                              = GetInt32(new IntPtr(p + 0x034)); // 0246675163C8 0x34 NestingLevel                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x038), ReversePrism.DataModels.Type.FromPointer); // 0246675163E8 0x38 Type                        ( 000186692850 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
