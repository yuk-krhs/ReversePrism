using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Name                                     000186671910 ModelPrimitiveType string string string String
    // 058 Final                                    0001865B4BE0 ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32
    // 05C DerivedBy                                0001865B4BE0 ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32
    // 060 BaseSchemaType                           0001866BFF90 ModelClassType XmlSchemaType XmlSchemaType XmlSchemaType Pointer
    // 068 Datatype                                 0001865B3820 ModelClassType XmlSchemaDatatype XmlSchemaDatatype XmlSchemaDatatype Pointer
    // 070 FinalResolved                            0001865B4BE0 ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32
    // 078 ElementDecl                              0001866E83C0 ModelClassType SchemaElementDecl SchemaElementDecl SchemaElementDecl Pointer
    // 080 Qname                                    0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 088 Redefined                                0001866BFF90 ModelClassType XmlSchemaType XmlSchemaType XmlSchemaType Pointer
    // 090 ContentType                              0001865B30E0 ModelEnumType XmlSchemaContentType XmlSchemaContentType XmlSchemaContentType Int32
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

            value.Name                                      = GetString(new IntPtr(p + 0x050)); // 0246673DE698 0x50 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Final                                     = (XmlSchemaDerivationMethod)GetInt32(new IntPtr(p + 0x058)); // 0246673DE6B8 0x58 Final                       ( 0001865B4BE0 ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32 )
            value.DerivedBy                                 = (XmlSchemaDerivationMethod)GetInt32(new IntPtr(p + 0x05C)); // 0246673DE6D8 0x5C DerivedBy                   ( 0001865B4BE0 ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32 )
            value.BaseSchemaType                            = GetObject<XmlSchemaType>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlSchemaType.FromPointer); // 0246673DE6F8 0x60 BaseSchemaType              ( 0001866BFF90 ModelClassType XmlSchemaType XmlSchemaType XmlSchemaType Pointer )
            value.Datatype                                  = GetObject<XmlSchemaDatatype>(new IntPtr(p + 0x068), ReversePrism.DataModels.XmlSchemaDatatype.FromPointer); // 0246673DE718 0x68 Datatype                    ( 0001865B3820 ModelClassType XmlSchemaDatatype XmlSchemaDatatype XmlSchemaDatatype Pointer )
            value.FinalResolved                             = (XmlSchemaDerivationMethod)GetInt32(new IntPtr(p + 0x070)); // 0246673DE738 0x70 FinalResolved               ( 0001865B4BE0 ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32 )
            value.ElementDecl                               = GetObject<SchemaElementDecl>(new IntPtr(p + 0x078), ReversePrism.DataModels.SchemaElementDecl.FromPointer); // 0246673DE758 0x78 ElementDecl                 ( 0001866E83C0 ModelClassType SchemaElementDecl SchemaElementDecl SchemaElementDecl Pointer )
            value.Qname                                     = GetObject<XmlQualifiedName>(new IntPtr(p + 0x080), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0246673DE778 0x80 Qname                       ( 0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.Redefined                                 = GetObject<XmlSchemaType>(new IntPtr(p + 0x088), ReversePrism.DataModels.XmlSchemaType.FromPointer); // 0246673DE798 0x88 Redefined                   ( 0001866BFF90 ModelClassType XmlSchemaType XmlSchemaType XmlSchemaType Pointer )
            value.ContentType                               = (XmlSchemaContentType)GetInt32(new IntPtr(p + 0x090)); // 0246673DE7B8 0x90 ContentType                 ( 0001865B30E0 ModelEnumType XmlSchemaContentType XmlSchemaContentType XmlSchemaContentType Int32 )

            return value;
        }
    }
}
