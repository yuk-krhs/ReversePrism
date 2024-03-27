using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 078 IsAbstract                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 079 HasAbstractAttribute                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 07A IsNillable                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 07B HasNillableAttribute                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 07C IsLocalTypeDerivationChecked             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 080 Block                                    0001865B4BE0 ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32
    // 084 Final                                    0001865B4BE0 ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32
    // 088 Form                                     0001865B66F0 ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32
    // 090 DefaultValue                             000186671910 ModelPrimitiveType string string string String
    // 098 FixedValue                               000186671910 ModelPrimitiveType string string string String
    // 0A0 Name                                     000186671910 ModelPrimitiveType string string string String
    // 0A8 RefName                                  0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 0B0 SubstitutionGroup                        0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 0B8 TypeName                                 0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 0C0 Type                                     0001866BFF90 ModelClassType XmlSchemaType XmlSchemaType XmlSchemaType Pointer
    // 0C8 QualifiedName                            0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 0D0 ElementType                              0001866BFF90 ModelClassType XmlSchemaType XmlSchemaType XmlSchemaType Pointer
    // 0D8 BlockResolved                            0001865B4BE0 ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32
    // 0DC FinalResolved                            0001865B4BE0 ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32
    // 0E0 Constraints                              0001865BC5D0 ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer
    // 0E8 ElementDecl                              0001866E83C0 ModelClassType SchemaElementDecl SchemaElementDecl SchemaElementDecl Pointer
    public partial class XmlSchemaElement
    {
        public bool                                     IsAbstract                              { get; set; }
        public bool                                     HasAbstractAttribute                    { get; set; }
        public bool                                     IsNillable                              { get; set; }
        public bool                                     HasNillableAttribute                    { get; set; }
        public bool                                     IsLocalTypeDerivationChecked            { get; set; }
        public XmlSchemaDerivationMethod                Block                                   { get; set; }
        public XmlSchemaDerivationMethod                Final                                   { get; set; }
        public XmlSchemaForm                            Form                                    { get; set; }
        public string                                   DefaultValue                            { get; set; }
        public string                                   FixedValue                              { get; set; }
        public string                                   Name                                    { get; set; }
        public XmlQualifiedName?                        RefName                                 { get; set; }
        public XmlQualifiedName?                        SubstitutionGroup                       { get; set; }
        public XmlQualifiedName?                        TypeName                                { get; set; }
        public XmlSchemaType?                           Type                                    { get; set; }
        public XmlQualifiedName?                        QualifiedName                           { get; set; }
        public XmlSchemaType?                           ElementType                             { get; set; }
        public XmlSchemaDerivationMethod                BlockResolved                           { get; set; }
        public XmlSchemaDerivationMethod                FinalResolved                           { get; set; }
        public XmlSchemaObjectCollection?               Constraints                             { get; set; }
        public SchemaElementDecl?                       ElementDecl                             { get; set; }

        public static XmlSchemaElement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaElement();

            value.IsAbstract                                = GetBool(new IntPtr(p + 0x078)); // 0270D73990B0 0x78 IsAbstract                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.HasAbstractAttribute                      = GetBool(new IntPtr(p + 0x079)); // 0270D73990D0 0x79 HasAbstractAttribute        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsNillable                                = GetBool(new IntPtr(p + 0x07A)); // 0270D73990F0 0x7A IsNillable                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.HasNillableAttribute                      = GetBool(new IntPtr(p + 0x07B)); // 0270D7399110 0x7B HasNillableAttribute        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsLocalTypeDerivationChecked              = GetBool(new IntPtr(p + 0x07C)); // 0270D7399130 0x7C IsLocalTypeDerivationChecked ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Block                                     = (XmlSchemaDerivationMethod)GetInt32(new IntPtr(p + 0x080)); // 0270D7399150 0x80 Block                       ( 0001865B4BE0 ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32 )
            value.Final                                     = (XmlSchemaDerivationMethod)GetInt32(new IntPtr(p + 0x084)); // 0270D7399170 0x84 Final                       ( 0001865B4BE0 ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32 )
            value.Form                                      = (XmlSchemaForm)GetInt32(new IntPtr(p + 0x088)); // 0270D7399190 0x88 Form                        ( 0001865B66F0 ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32 )
            value.DefaultValue                              = GetString(new IntPtr(p + 0x090)); // 0270D73991B0 0x90 DefaultValue                ( 000186671910 ModelPrimitiveType string string string String )
            value.FixedValue                                = GetString(new IntPtr(p + 0x098)); // 0270D73991D0 0x98 FixedValue                  ( 000186671910 ModelPrimitiveType string string string String )
            value.Name                                      = GetString(new IntPtr(p + 0x0A0)); // 0270D73991F0 0xA0 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.RefName                                   = GetObject<XmlQualifiedName>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0270D7399210 0xA8 RefName                     ( 0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.SubstitutionGroup                         = GetObject<XmlQualifiedName>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0270D7399230 0xB0 SubstitutionGroup           ( 0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.TypeName                                  = GetObject<XmlQualifiedName>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0270D7399250 0xB8 TypeName                    ( 0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.Type                                      = GetObject<XmlSchemaType>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.XmlSchemaType.FromPointer); // 0270D7399270 0xC0 Type                        ( 0001866BFF90 ModelClassType XmlSchemaType XmlSchemaType XmlSchemaType Pointer )
            value.QualifiedName                             = GetObject<XmlQualifiedName>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0270D7399290 0xC8 QualifiedName               ( 0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.ElementType                               = GetObject<XmlSchemaType>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.XmlSchemaType.FromPointer); // 0270D73992B0 0xD0 ElementType                 ( 0001866BFF90 ModelClassType XmlSchemaType XmlSchemaType XmlSchemaType Pointer )
            value.BlockResolved                             = (XmlSchemaDerivationMethod)GetInt32(new IntPtr(p + 0x0D8)); // 0270D73992D0 0xD8 BlockResolved               ( 0001865B4BE0 ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32 )
            value.FinalResolved                             = (XmlSchemaDerivationMethod)GetInt32(new IntPtr(p + 0x0DC)); // 0270D73992F0 0xDC FinalResolved               ( 0001865B4BE0 ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32 )
            value.Constraints                               = GetObject<XmlSchemaObjectCollection>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.XmlSchemaObjectCollection.FromPointer); // 0270D7399310 0xE0 Constraints                 ( 0001865BC5D0 ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer )
            value.ElementDecl                               = GetObject<SchemaElementDecl>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.SchemaElementDecl.FromPointer); // 0270D7399330 0xE8 ElementDecl                 ( 0001866E83C0 ModelClassType SchemaElementDecl SchemaElementDecl SchemaElementDecl Pointer )

            return value;
        }
    }
}
