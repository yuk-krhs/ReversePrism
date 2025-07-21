using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Name                                     ModelPrimitiveType string string string String
    // 058 Final                                    ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32
    // 05C DerivedBy                                ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32
    // 060 BaseSchemaType                           ModelClassType XmlSchemaType XmlSchemaType XmlSchemaType Pointer
    // 068 Datatype                                 ModelClassType XmlSchemaDatatype XmlSchemaDatatype XmlSchemaDatatype Pointer
    // 070 FinalResolved                            ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32
    // 078 ElementDecl                              ModelClassType SchemaElementDecl SchemaElementDecl SchemaElementDecl Pointer
    // 080 Qname                                    ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 088 Redefined                                ModelClassType XmlSchemaType XmlSchemaType XmlSchemaType Pointer
    // 090 ContentType                              ModelEnumType XmlSchemaContentType XmlSchemaContentType XmlSchemaContentType Int32
    public partial class XmlSchemaType : DataModel
    {
        public string                                   Name                                    { get; set; }
        public XmlSchemaDerivationMethod                Final                                   { get; set; }
        public XmlSchemaDerivationMethod                DerivedBy                               { get; set; }
        public XmlSchemaType?                           BaseSchemaType                          { get; set; }
        public XmlSchemaDatatype?                       Datatype                                { get; set; }
        public XmlSchemaDerivationMethod                FinalResolved                           { get; set; }
        public SchemaElementDecl?                       ElementDecl                             { get; set; }
        public XmlQualifiedName?                        Qname                                   { get; set; }
        public XmlSchemaType?                           Redefined                               { get; set; }
        public XmlSchemaContentType                     ContentType                             { get; set; }

        public static XmlSchemaType? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaType() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x050)); // 0x50 Name                        ( ModelPrimitiveType string string string String )
            value.Final                                     = (XmlSchemaDerivationMethod)GetInt32(new IntPtr(p + 0x058)); // 0x58 Final                       ( ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32 )
            value.DerivedBy                                 = (XmlSchemaDerivationMethod)GetInt32(new IntPtr(p + 0x05C)); // 0x5C DerivedBy                   ( ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32 )
            value.BaseSchemaType                            = GetObject<XmlSchemaType>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlSchemaType.FromPointer); // 0x60 BaseSchemaType              ( ModelClassType XmlSchemaType XmlSchemaType XmlSchemaType Pointer )
            value.Datatype                                  = GetObject<XmlSchemaDatatype>(new IntPtr(p + 0x068), ReversePrism.DataModels.XmlSchemaDatatype.FromPointer); // 0x68 Datatype                    ( ModelClassType XmlSchemaDatatype XmlSchemaDatatype XmlSchemaDatatype Pointer )
            value.FinalResolved                             = (XmlSchemaDerivationMethod)GetInt32(new IntPtr(p + 0x070)); // 0x70 FinalResolved               ( ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32 )
            value.ElementDecl                               = GetObject<SchemaElementDecl>(new IntPtr(p + 0x078), ReversePrism.DataModels.SchemaElementDecl.FromPointer); // 0x78 ElementDecl                 ( ModelClassType SchemaElementDecl SchemaElementDecl SchemaElementDecl Pointer )
            value.Qname                                     = GetObject<XmlQualifiedName>(new IntPtr(p + 0x080), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x80 Qname                       ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.Redefined                                 = GetObject<XmlSchemaType>(new IntPtr(p + 0x088), ReversePrism.DataModels.XmlSchemaType.FromPointer); // 0x88 Redefined                   ( ModelClassType XmlSchemaType XmlSchemaType XmlSchemaType Pointer )
            value.ContentType                               = (XmlSchemaContentType)GetInt32(new IntPtr(p + 0x090)); // 0x90 ContentType                 ( ModelEnumType XmlSchemaContentType XmlSchemaContentType XmlSchemaContentType Int32 )

            return value;
        }
    }
}
