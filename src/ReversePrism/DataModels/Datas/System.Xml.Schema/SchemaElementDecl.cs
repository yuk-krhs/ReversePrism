using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 attdefs                                  Dictionary`2<XmlQualifiedName, SchemaAttDef> IL2CPP_TYPE_GENERICINST
    // 068 DefaultAttdefs                           000185CE2758 ModelClassListType List`1<IDtdDefaultAttributeInfo> List`1<IDtdDefaultAttributeInfo> List<IDtdDefaultAttributeInfo> Pointer
    // 070 IsIdDeclared                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 071 HasNonCDataAttribute                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 072 IsAbstract                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 073 IsNillable                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 074 HasRequiredAttribute                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 075 IsNotationDeclared                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 078 prohibitedAttributes                     Dictionary`2<XmlQualifiedName, XmlQualifiedName> IL2CPP_TYPE_GENERICINST
    // 080 ContentValidator                         0001866128B0 ModelClassType ContentValidator ContentValidator ContentValidator Pointer
    // 088 AnyAttribute                             0001865ADBC0 ModelClassType XmlSchemaAnyAttribute XmlSchemaAnyAttribute XmlSchemaAnyAttribute Pointer
    // 090 Block                                    0001865B4BE0 ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32
    // 098 Constraints                              000185B766D0 ModelClassListType CompiledIdentityConstraint[] CompiledIdentityConstraint[] List<CompiledIdentityConstraint> Pointer
    // 0A0 SchemaElement                            0001866BED30 ModelClassType XmlSchemaElement XmlSchemaElement XmlSchemaElement Pointer
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

            value.DefaultAttdefs                            = GetObjectList<IDtdDefaultAttributeInfo>(new IntPtr(p + 0x068), ReversePrism.DataModels.IDtdDefaultAttributeInfo.FromPointer); // 0246674B0310 0x68 DefaultAttdefs              ( 000185CE2758 ModelClassListType List`1<IDtdDefaultAttributeInfo> List`1<IDtdDefaultAttributeInfo> List<IDtdDefaultAttributeInfo> Pointer )
            value.IsIdDeclared                              = GetBool(new IntPtr(p + 0x070)); // 0246674B0330 0x70 IsIdDeclared                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.HasNonCDataAttribute                      = GetBool(new IntPtr(p + 0x071)); // 0246674B0350 0x71 HasNonCDataAttribute        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsAbstract                                = GetBool(new IntPtr(p + 0x072)); // 0246674B0370 0x72 IsAbstract                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsNillable                                = GetBool(new IntPtr(p + 0x073)); // 0246674B0390 0x73 IsNillable                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.HasRequiredAttribute                      = GetBool(new IntPtr(p + 0x074)); // 0246674B03B0 0x74 HasRequiredAttribute        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsNotationDeclared                        = GetBool(new IntPtr(p + 0x075)); // 0246674B03D0 0x75 IsNotationDeclared          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ContentValidator                          = GetObject<ContentValidator>(new IntPtr(p + 0x080), ReversePrism.DataModels.ContentValidator.FromPointer); // 0246674B0410 0x80 ContentValidator            ( 0001866128B0 ModelClassType ContentValidator ContentValidator ContentValidator Pointer )
            value.AnyAttribute                              = GetObject<XmlSchemaAnyAttribute>(new IntPtr(p + 0x088), ReversePrism.DataModels.XmlSchemaAnyAttribute.FromPointer); // 0246674B0430 0x88 AnyAttribute                ( 0001865ADBC0 ModelClassType XmlSchemaAnyAttribute XmlSchemaAnyAttribute XmlSchemaAnyAttribute Pointer )
            value.Block                                     = (XmlSchemaDerivationMethod)GetInt32(new IntPtr(p + 0x090)); // 0246674B0450 0x90 Block                       ( 0001865B4BE0 ModelEnumType XmlSchemaDerivationMethod XmlSchemaDerivationMethod XmlSchemaDerivationMethod Int32 )
            value.Constraints                               = GetObjectList<CompiledIdentityConstraint>(new IntPtr(p + 0x098), ReversePrism.DataModels.CompiledIdentityConstraint.FromPointer); // 0246674B0470 0x98 Constraints                 ( 000185B766D0 ModelClassListType CompiledIdentityConstraint[] CompiledIdentityConstraint[] List<CompiledIdentityConstraint> Pointer )
            value.SchemaElement                             = GetObject<XmlSchemaElement>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.XmlSchemaElement.FromPointer); // 0246674B0490 0xA0 SchemaElement               ( 0001866BED30 ModelClassType XmlSchemaElement XmlSchemaElement XmlSchemaElement Pointer )

            return value;
        }
    }
}
