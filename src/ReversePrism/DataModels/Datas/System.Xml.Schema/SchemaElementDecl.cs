using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 attdefs                                  Dictionary`2<XmlQualifiedName, SchemaAttDef> IL2CPP_TYPE_GENERICINST
    // 068 DefaultAttdefs                           ModelClassListType List`1<IDtdDefaultAttributeInfo> List`1<IDtdDefaultAttributeInfo> List<IDtdDefaultAttributeInfo> Pointer
    // 070 IsIdDeclared                             ModelPrimitiveType bool bool bool Bool
    // 071 HasNonCDataAttribute                     ModelPrimitiveType bool bool bool Bool
    // 072 IsAbstract                               ModelPrimitiveType bool bool bool Bool
    // 073 IsNillable                               ModelPrimitiveType bool bool bool Bool
    // 074 HasRequiredAttribute                     ModelPrimitiveType bool bool bool Bool
    // 075 IsNotationDeclared                       ModelPrimitiveType bool bool bool Bool
    // 078 prohibitedAttributes                     Dictionary`2<XmlQualifiedName, XmlQualifiedName> IL2CPP_TYPE_GENERICINST
    // 080 ContentValidator                         ModelClassType ContentValidator ContentValidator ContentValidator Pointer
    // 088 AnyAttribute                             ModelClassType XmlSchemaAnyAttribute XmlSchemaAnyAttribute XmlSchemaAnyAttribute Pointer
    // 090 Block                                    ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32
    // 098 Constraints                              ModelClassListType CompiledIdentityConstraint[] CompiledIdentityConstraint[] List<CompiledIdentityConstraint> Pointer
    // 0A0 SchemaElement                            ModelClassType XmlSchemaElement XmlSchemaElement XmlSchemaElement Pointer
    // 000 Empty                                    SchemaElementDecl IL2CPP_TYPE_CLASS
    public partial class SchemaElementDecl : DataModel
    {
        public List<IDtdDefaultAttributeInfo>?          DefaultAttdefs                          { get; set; }
        public bool                                     IsIdDeclared                            { get; set; }
        public bool                                     HasNonCDataAttribute                    { get; set; }
        public bool                                     IsAbstract                              { get; set; }
        public bool                                     IsNillable                              { get; set; }
        public bool                                     HasRequiredAttribute                    { get; set; }
        public bool                                     IsNotationDeclared                      { get; set; }
        public ContentValidator?                        ContentValidator                        { get; set; }
        public XmlSchemaAnyAttribute?                   AnyAttribute                            { get; set; }
        public XmlSchemaDerivationMethod                Block                                   { get; set; }
        public List<CompiledIdentityConstraint>?        Constraints                             { get; set; }
        public XmlSchemaElement?                        SchemaElement                           { get; set; }

        public static SchemaElementDecl? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SchemaElementDecl() { Pointer= p0 };

            value.DefaultAttdefs                            = GetObjectList<IDtdDefaultAttributeInfo>(new IntPtr(p + 0x068), ReversePrism.DataModels.IDtdDefaultAttributeInfo.FromPointer); // 0x68 DefaultAttdefs              ( ModelClassListType List`1<IDtdDefaultAttributeInfo> List`1<IDtdDefaultAttributeInfo> List<IDtdDefaultAttributeInfo> Pointer )
            value.IsIdDeclared                              = GetBool(new IntPtr(p + 0x070)); // 0x70 IsIdDeclared                ( ModelPrimitiveType bool bool bool Bool )
            value.HasNonCDataAttribute                      = GetBool(new IntPtr(p + 0x071)); // 0x71 HasNonCDataAttribute        ( ModelPrimitiveType bool bool bool Bool )
            value.IsAbstract                                = GetBool(new IntPtr(p + 0x072)); // 0x72 IsAbstract                  ( ModelPrimitiveType bool bool bool Bool )
            value.IsNillable                                = GetBool(new IntPtr(p + 0x073)); // 0x73 IsNillable                  ( ModelPrimitiveType bool bool bool Bool )
            value.HasRequiredAttribute                      = GetBool(new IntPtr(p + 0x074)); // 0x74 HasRequiredAttribute        ( ModelPrimitiveType bool bool bool Bool )
            value.IsNotationDeclared                        = GetBool(new IntPtr(p + 0x075)); // 0x75 IsNotationDeclared          ( ModelPrimitiveType bool bool bool Bool )
            value.ContentValidator                          = GetObject<ContentValidator>(new IntPtr(p + 0x080), ReversePrism.DataModels.ContentValidator.FromPointer); // 0x80 ContentValidator            ( ModelClassType ContentValidator ContentValidator ContentValidator Pointer )
            value.AnyAttribute                              = GetObject<XmlSchemaAnyAttribute>(new IntPtr(p + 0x088), ReversePrism.DataModels.XmlSchemaAnyAttribute.FromPointer); // 0x88 AnyAttribute                ( ModelClassType XmlSchemaAnyAttribute XmlSchemaAnyAttribute XmlSchemaAnyAttribute Pointer )
            value.Block                                     = (XmlSchemaDerivationMethod)GetInt32(new IntPtr(p + 0x090)); // 0x90 Block                       ( ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32 )
            value.Constraints                               = GetObjectList<CompiledIdentityConstraint>(new IntPtr(p + 0x098), ReversePrism.DataModels.CompiledIdentityConstraint.FromPointer); // 0x98 Constraints                 ( ModelClassListType CompiledIdentityConstraint[] CompiledIdentityConstraint[] List<CompiledIdentityConstraint> Pointer )
            value.SchemaElement                             = GetObject<XmlSchemaElement>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.XmlSchemaElement.FromPointer); // 0xA0 SchemaElement               ( ModelClassType XmlSchemaElement XmlSchemaElement XmlSchemaElement Pointer )

            return value;
        }
    }
}
