using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 DefaultValue                             000186671910 ModelPrimitiveType string string string String
    // 058 FixedValue                               000186671910 ModelPrimitiveType string string string String
    // 060 Name                                     000186671910 ModelPrimitiveType string string string String
    // 068 Form                                     0001865B66F0 ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32
    // 06C Use                                      0001865C1F80 ModelEnumType XmlSchemaUse XmlSchemaUse XmlSchemaUse Int32
    // 070 RefName                                  0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 078 TypeName                                 0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 080 QualifiedName                            0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 088 Type                                     0001866BF5F0 ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer
    // 090 AttributeType                            0001866BF5F0 ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer
    // 098 AttDef                                   0001866E6E40 ModelClassType SchemaAttDef SchemaAttDef SchemaAttDef Pointer
    public partial class XmlSchemaAttribute : DataModel
    {
        public string                                   DefaultValue                            { get; set; }
        public string                                   FixedValue                              { get; set; }
        public string                                   Name                                    { get; set; }
        public XmlSchemaForm                            Form                                    { get; set; }
        public XmlSchemaUse                             Use                                     { get; set; }
        public XmlQualifiedName?                        RefName                                 { get; set; }
        public XmlQualifiedName?                        TypeName                                { get; set; }
        public XmlQualifiedName?                        QualifiedName                           { get; set; }
        public XmlSchemaSimpleType?                     Type                                    { get; set; }
        public XmlSchemaSimpleType?                     AttributeType                           { get; set; }
        public SchemaAttDef?                            AttDef                                  { get; set; }

        public static XmlSchemaAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaAttribute() { Pointer= p0 };

            value.DefaultValue                              = GetString(new IntPtr(p + 0x050)); // 0246673EA190 0x50 DefaultValue                ( 000186671910 ModelPrimitiveType string string string String )
            value.FixedValue                                = GetString(new IntPtr(p + 0x058)); // 0246673EA1B0 0x58 FixedValue                  ( 000186671910 ModelPrimitiveType string string string String )
            value.Name                                      = GetString(new IntPtr(p + 0x060)); // 0246673EA1D0 0x60 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Form                                      = (XmlSchemaForm)GetInt32(new IntPtr(p + 0x068)); // 0246673EA1F0 0x68 Form                        ( 0001865B66F0 ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32 )
            value.Use                                       = (XmlSchemaUse)GetInt32(new IntPtr(p + 0x06C)); // 0246673EA210 0x6C Use                         ( 0001865C1F80 ModelEnumType XmlSchemaUse XmlSchemaUse XmlSchemaUse Int32 )
            value.RefName                                   = GetObject<XmlQualifiedName>(new IntPtr(p + 0x070), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0246673EA230 0x70 RefName                     ( 0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.TypeName                                  = GetObject<XmlQualifiedName>(new IntPtr(p + 0x078), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0246673EA250 0x78 TypeName                    ( 0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QualifiedName                             = GetObject<XmlQualifiedName>(new IntPtr(p + 0x080), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0246673EA270 0x80 QualifiedName               ( 0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.Type                                      = GetObject<XmlSchemaSimpleType>(new IntPtr(p + 0x088), ReversePrism.DataModels.XmlSchemaSimpleType.FromPointer); // 0246673EA290 0x88 Type                        ( 0001866BF5F0 ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer )
            value.AttributeType                             = GetObject<XmlSchemaSimpleType>(new IntPtr(p + 0x090), ReversePrism.DataModels.XmlSchemaSimpleType.FromPointer); // 0246673EA2B0 0x90 AttributeType               ( 0001866BF5F0 ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer )
            value.AttDef                                    = GetObject<SchemaAttDef>(new IntPtr(p + 0x098), ReversePrism.DataModels.SchemaAttDef.FromPointer); // 0246673EA2D0 0x98 AttDef                      ( 0001866E6E40 ModelClassType SchemaAttDef SchemaAttDef SchemaAttDef Pointer )

            return value;
        }
    }
}
