using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 078 IsAbstract                               ModelPrimitiveType bool bool bool Bool
    // 079 HasAbstractAttribute                     ModelPrimitiveType bool bool bool Bool
    // 07A IsNillable                               ModelPrimitiveType bool bool bool Bool
    // 07B HasNillableAttribute                     ModelPrimitiveType bool bool bool Bool
    // 07C IsLocalTypeDerivationChecked             ModelPrimitiveType bool bool bool Bool
    // 080 Block                                    ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32
    // 084 Final                                    ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32
    // 088 Form                                     ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32
    // 090 DefaultValue                             ModelPrimitiveType string string string String
    // 098 FixedValue                               ModelPrimitiveType string string string String
    // 0A0 Name                                     ModelPrimitiveType string string string String
    // 0A8 RefName                                  ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 0B0 SubstitutionGroup                        ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 0B8 TypeName                                 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 0C0 Type                                     ModelClassType XmlSchemaType XmlSchemaType XmlSchemaType Pointer
    // 0C8 QualifiedName                            ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 0D0 ElementType                              ModelClassType XmlSchemaType XmlSchemaType XmlSchemaType Pointer
    // 0D8 BlockResolved                            ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32
    // 0DC FinalResolved                            ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32
    // 0E0 Constraints                              ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer
    // 0E8 ElementDecl                              ModelClassType SchemaElementDecl SchemaElementDecl SchemaElementDecl Pointer
    public partial class XmlSchemaElement : DataModel
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
            var value   = new XmlSchemaElement() { Pointer= p0 };

            value.IsAbstract                                = GetBool(new IntPtr(p + 0x078)); // 0x78 IsAbstract                  ( ModelPrimitiveType bool bool bool Bool )
            value.HasAbstractAttribute                      = GetBool(new IntPtr(p + 0x079)); // 0x79 HasAbstractAttribute        ( ModelPrimitiveType bool bool bool Bool )
            value.IsNillable                                = GetBool(new IntPtr(p + 0x07A)); // 0x7A IsNillable                  ( ModelPrimitiveType bool bool bool Bool )
            value.HasNillableAttribute                      = GetBool(new IntPtr(p + 0x07B)); // 0x7B HasNillableAttribute        ( ModelPrimitiveType bool bool bool Bool )
            value.IsLocalTypeDerivationChecked              = GetBool(new IntPtr(p + 0x07C)); // 0x7C IsLocalTypeDerivationChecked ( ModelPrimitiveType bool bool bool Bool )
            value.Block                                     = (XmlSchemaDerivationMethod)GetInt32(new IntPtr(p + 0x080)); // 0x80 Block                       ( ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32 )
            value.Final                                     = (XmlSchemaDerivationMethod)GetInt32(new IntPtr(p + 0x084)); // 0x84 Final                       ( ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32 )
            value.Form                                      = (XmlSchemaForm)GetInt32(new IntPtr(p + 0x088)); // 0x88 Form                        ( ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32 )
            value.DefaultValue                              = GetString(new IntPtr(p + 0x090)); // 0x90 DefaultValue                ( ModelPrimitiveType string string string String )
            value.FixedValue                                = GetString(new IntPtr(p + 0x098)); // 0x98 FixedValue                  ( ModelPrimitiveType string string string String )
            value.Name                                      = GetString(new IntPtr(p + 0x0A0)); // 0xA0 Name                        ( ModelPrimitiveType string string string String )
            value.RefName                                   = GetObject<XmlQualifiedName>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0xA8 RefName                     ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.SubstitutionGroup                         = GetObject<XmlQualifiedName>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0xB0 SubstitutionGroup           ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.TypeName                                  = GetObject<XmlQualifiedName>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0xB8 TypeName                    ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.Type                                      = GetObject<XmlSchemaType>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.XmlSchemaType.FromPointer); // 0xC0 Type                        ( ModelClassType XmlSchemaType XmlSchemaType XmlSchemaType Pointer )
            value.QualifiedName                             = GetObject<XmlQualifiedName>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0xC8 QualifiedName               ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.ElementType                               = GetObject<XmlSchemaType>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.XmlSchemaType.FromPointer); // 0xD0 ElementType                 ( ModelClassType XmlSchemaType XmlSchemaType XmlSchemaType Pointer )
            value.BlockResolved                             = (XmlSchemaDerivationMethod)GetInt32(new IntPtr(p + 0x0D8)); // 0xD8 BlockResolved               ( ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32 )
            value.FinalResolved                             = (XmlSchemaDerivationMethod)GetInt32(new IntPtr(p + 0x0DC)); // 0xDC FinalResolved               ( ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32 )
            value.Constraints                               = GetObject<XmlSchemaObjectCollection>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.XmlSchemaObjectCollection.FromPointer); // 0xE0 Constraints                 ( ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer )
            value.ElementDecl                               = GetObject<SchemaElementDecl>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.SchemaElementDecl.FromPointer); // 0xE8 ElementDecl                 ( ModelClassType SchemaElementDecl SchemaElementDecl SchemaElementDecl Pointer )

            return value;
        }
    }
}
