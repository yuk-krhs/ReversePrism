using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 DefaultValue                             ModelPrimitiveType string string string String
    // 058 FixedValue                               ModelPrimitiveType string string string String
    // 060 Name                                     ModelPrimitiveType string string string String
    // 068 Form                                     ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32
    // 06C Use                                      ModelEnumType XmlSchemaUse XmlSchemaUse XmlSchemaUse Int32
    // 070 RefName                                  ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 078 TypeName                                 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 080 QualifiedName                            ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 088 Type                                     ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer
    // 090 AttributeType                            ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer
    // 098 AttDef                                   ModelClassType SchemaAttDef SchemaAttDef SchemaAttDef Pointer
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

            value.DefaultValue                              = GetString(new IntPtr(p + 0x050)); // 0x50 DefaultValue                ( ModelPrimitiveType string string string String )
            value.FixedValue                                = GetString(new IntPtr(p + 0x058)); // 0x58 FixedValue                  ( ModelPrimitiveType string string string String )
            value.Name                                      = GetString(new IntPtr(p + 0x060)); // 0x60 Name                        ( ModelPrimitiveType string string string String )
            value.Form                                      = (XmlSchemaForm)GetInt32(new IntPtr(p + 0x068)); // 0x68 Form                        ( ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32 )
            value.Use                                       = (XmlSchemaUse)GetInt32(new IntPtr(p + 0x06C)); // 0x6C Use                         ( ModelEnumType XmlSchemaUse XmlSchemaUse XmlSchemaUse Int32 )
            value.RefName                                   = GetObject<XmlQualifiedName>(new IntPtr(p + 0x070), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x70 RefName                     ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.TypeName                                  = GetObject<XmlQualifiedName>(new IntPtr(p + 0x078), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x78 TypeName                    ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.QualifiedName                             = GetObject<XmlQualifiedName>(new IntPtr(p + 0x080), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x80 QualifiedName               ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.Type                                      = GetObject<XmlSchemaSimpleType>(new IntPtr(p + 0x088), ReversePrism.DataModels.XmlSchemaSimpleType.FromPointer); // 0x88 Type                        ( ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer )
            value.AttributeType                             = GetObject<XmlSchemaSimpleType>(new IntPtr(p + 0x090), ReversePrism.DataModels.XmlSchemaSimpleType.FromPointer); // 0x90 AttributeType               ( ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer )
            value.AttDef                                    = GetObject<SchemaAttDef>(new IntPtr(p + 0x098), ReversePrism.DataModels.SchemaAttDef.FromPointer); // 0x98 AttDef                      ( ModelClassType SchemaAttDef SchemaAttDef SchemaAttDef Pointer )

            return value;
        }
    }
}
