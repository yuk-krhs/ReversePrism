using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 SchemaElement                            State[] IL2CPP_TYPE_SZARRAY
    // 008 SchemaSubelements                        State[] IL2CPP_TYPE_SZARRAY
    // 010 AttributeSubelements                     000185CC96F8 ModelEnumListType State[] State[] List<State> Pointer
    // 018 ElementSubelements                       000185CC96F8 ModelEnumListType State[] State[] List<State> Pointer
    // 020 ComplexTypeSubelements                   000185CC96F8 ModelEnumListType State[] State[] List<State> Pointer
    // 028 SimpleContentSubelements                 000185CC96F8 ModelEnumListType State[] State[] List<State> Pointer
    // 030 SimpleContentExtensionSubelements        000185CC96F8 ModelEnumListType State[] State[] List<State> Pointer
    // 038 SimpleContentRestrictionSubelements      000185CC96F8 ModelEnumListType State[] State[] List<State> Pointer
    // 040 ComplexContentSubelements                000185CC96F8 ModelEnumListType State[] State[] List<State> Pointer
    // 048 ComplexContentExtensionSubelements       000185CC96F8 ModelEnumListType State[] State[] List<State> Pointer
    // 050 ComplexContentRestrictionSubelements     000185CC96F8 ModelEnumListType State[] State[] List<State> Pointer
    // 058 SimpleTypeSubelements                    000185CC96F8 ModelEnumListType State[] State[] List<State> Pointer
    // 060 SimpleTypeRestrictionSubelements         000185CC96F8 ModelEnumListType State[] State[] List<State> Pointer
    // 068 SimpleTypeListSubelements                000185CC96F8 ModelEnumListType State[] State[] List<State> Pointer
    // 070 SimpleTypeUnionSubelements               000185CC96F8 ModelEnumListType State[] State[] List<State> Pointer
    // 078 RedefineSubelements                      000185CC96F8 ModelEnumListType State[] State[] List<State> Pointer
    // 080 AttributeGroupSubelements                000185CC96F8 ModelEnumListType State[] State[] List<State> Pointer
    // 088 GroupSubelements                         000185CC96F8 ModelEnumListType State[] State[] List<State> Pointer
    // 090 AllSubelements                           000185CC96F8 ModelEnumListType State[] State[] List<State> Pointer
    // 098 ChoiceSequenceSubelements                000185CC96F8 ModelEnumListType State[] State[] List<State> Pointer
    // 0A0 IdentityConstraintSubelements            000185CC96F8 ModelEnumListType State[] State[] List<State> Pointer
    // 0A8 AnnotationSubelements                    000185CC96F8 ModelEnumListType State[] State[] List<State> Pointer
    // 0B0 AnnotatedSubelements                     000185CC96F8 ModelEnumListType State[] State[] List<State> Pointer
    // 0B8 SchemaAttributes                         000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 0C0 AttributeAttributes                      000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 0C8 ElementAttributes                        000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 0D0 ComplexTypeAttributes                    000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 0D8 SimpleContentAttributes                  000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 0E0 SimpleContentExtensionAttributes         000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 0E8 SimpleContentRestrictionAttributes       000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 0F0 ComplexContentAttributes                 000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 0F8 ComplexContentExtensionAttributes        000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 100 ComplexContentRestrictionAttributes      000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 108 SimpleTypeAttributes                     000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 110 SimpleTypeRestrictionAttributes          000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 118 SimpleTypeUnionAttributes                000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 120 SimpleTypeListAttributes                 000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 128 AttributeGroupAttributes                 000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 130 AttributeGroupRefAttributes              000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 138 GroupAttributes                          000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 140 GroupRefAttributes                       000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 148 ParticleAttributes                       000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 150 AnyAttributes                            000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 158 IdentityConstraintAttributes             000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 160 SelectorAttributes                       000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 168 FieldAttributes                          000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 170 NotationAttributes                       000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 178 IncludeAttributes                        000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 180 ImportAttributes                         000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 188 FacetAttributes                          000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 190 AnyAttributeAttributes                   000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 198 DocumentationAttributes                  000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 1A0 AppinfoAttributes                        000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 1A8 RedefineAttributes                       000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 1B0 AnnotationAttributes                     000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 1B8 SchemaEntries                            000185CC9B18 ModelClassListType XsdEntry[] XsdEntry[] List<XsdEntry> Pointer
    // 1C0 DerivationMethodValues                   000185B7DCD0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 1C8 DerivationMethodStrings                  000185B820A0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 1D0 FormStringValues                         000185B820A0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 1D8 UseStringValues                          000185B820A0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 1E0 ProcessContentsStringValues              000185B820A0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 010 Reader                                   0001865A9BB0 ModelClassType XmlReader XmlReader XmlReader Pointer
    // 018 PositionInfo                             000186768940 ModelClassType PositionInfo PositionInfo PositionInfo Pointer
    // 020 CurrentEntry                             000186754750 ModelClassType XsdEntry XsdEntry XsdEntry Pointer
    // 028 NextEntry                                000186754750 ModelClassType XsdEntry XsdEntry XsdEntry Pointer
    // 030 HasChild                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 StateHistory                             0001866A4660 ModelClassType HWStack HWStack HWStack Pointer
    // 040 ContainerStack                           00018655EBF0 ModelClassType Stack Stack Stack Pointer
    // 048 NameTable                                0001865A0930 ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer
    // 050 SchemaNames                              0001866EA5B0 ModelClassType SchemaNames SchemaNames SchemaNames Pointer
    // 058 NamespaceManager                         0001866BAB00 ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer
    // 060 CanIncludeImport                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 068 Schema                                   0001866BE120 ModelClassType XmlSchema XmlSchema XmlSchema Pointer
    // 070 Xso                                      0001865BB990 ModelClassType XmlSchemaObject XmlSchemaObject XmlSchemaObject Pointer
    // 078 Element                                  0001866BED30 ModelClassType XmlSchemaElement XmlSchemaElement XmlSchemaElement Pointer
    // 080 AnyElement                               0001865AD6E0 ModelClassType XmlSchemaAny XmlSchemaAny XmlSchemaAny Pointer
    // 088 Attribute                                0001865AE470 ModelClassType XmlSchemaAttribute XmlSchemaAttribute XmlSchemaAttribute Pointer
    // 090 AnyAttribute                             0001865ADBC0 ModelClassType XmlSchemaAnyAttribute XmlSchemaAnyAttribute XmlSchemaAnyAttribute Pointer
    // 098 ComplexType                              0001865B15A0 ModelClassType XmlSchemaComplexType XmlSchemaComplexType XmlSchemaComplexType Pointer
    // 0A0 SimpleType                               0001866BF5F0 ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer
    // 0A8 ComplexContent                           0001865B0710 ModelClassType XmlSchemaComplexContent XmlSchemaComplexContent XmlSchemaComplexContent Pointer
    // 0B0 ComplexContentExtension                  0001865B0BF0 ModelClassType XmlSchemaComplexContentExtension XmlSchemaComplexContentExtension XmlSchemaComplexContentExtension Pointer
    // 0B8 ComplexContentRestriction                0001865B10B0 ModelClassType XmlSchemaComplexContentRestriction XmlSchemaComplexContentRestriction XmlSchemaComplexContentRestriction Pointer
    // 0C0 SimpleContent                            0001865BF310 ModelClassType XmlSchemaSimpleContent XmlSchemaSimpleContent XmlSchemaSimpleContent Pointer
    // 0C8 SimpleContentExtension                   0001865BF850 ModelClassType XmlSchemaSimpleContentExtension XmlSchemaSimpleContentExtension XmlSchemaSimpleContentExtension Pointer
    // 0D0 SimpleContentRestriction                 0001865BFD50 ModelClassType XmlSchemaSimpleContentRestriction XmlSchemaSimpleContentRestriction XmlSchemaSimpleContentRestriction Pointer
    // 0D8 SimpleTypeUnion                          0001865C1130 ModelClassType XmlSchemaSimpleTypeUnion XmlSchemaSimpleTypeUnion XmlSchemaSimpleTypeUnion Pointer
    // 0E0 SimpleTypeList                           0001865C0710 ModelClassType XmlSchemaSimpleTypeList XmlSchemaSimpleTypeList XmlSchemaSimpleTypeList Pointer
    // 0E8 SimpleTypeRestriction                    0001865C0C10 ModelClassType XmlSchemaSimpleTypeRestriction XmlSchemaSimpleTypeRestriction XmlSchemaSimpleTypeRestriction Pointer
    // 0F0 Group                                    0001865B70D0 ModelClassType XmlSchemaGroup XmlSchemaGroup XmlSchemaGroup Pointer
    // 0F8 GroupRef                                 0001865B7A90 ModelClassType XmlSchemaGroupRef XmlSchemaGroupRef XmlSchemaGroupRef Pointer
    // 100 All                                      0001865ACAA0 ModelClassType XmlSchemaAll XmlSchemaAll XmlSchemaAll Pointer
    // 108 Choice                                   0001865AF340 ModelClassType XmlSchemaChoice XmlSchemaChoice XmlSchemaChoice Pointer
    // 110 Sequence                                 0001865BE990 ModelClassType XmlSchemaSequence XmlSchemaSequence XmlSchemaSequence Pointer
    // 118 Particle                                 0001865BD330 ModelClassType XmlSchemaParticle XmlSchemaParticle XmlSchemaParticle Pointer
    // 120 AttributeGroup                           0001865AE960 ModelClassType XmlSchemaAttributeGroup XmlSchemaAttributeGroup XmlSchemaAttributeGroup Pointer
    // 128 AttributeGroupRef                        0001865AEE40 ModelClassType XmlSchemaAttributeGroupRef XmlSchemaAttributeGroupRef XmlSchemaAttributeGroupRef Pointer
    // 130 Notation                                 0001865BB330 ModelClassType XmlSchemaNotation XmlSchemaNotation XmlSchemaNotation Pointer
    // 138 IdentityConstraint                       0001865B7F40 ModelClassType XmlSchemaIdentityConstraint XmlSchemaIdentityConstraint XmlSchemaIdentityConstraint Pointer
    // 140 Xpath                                    0001865C4920 ModelClassType XmlSchemaXPath XmlSchemaXPath XmlSchemaXPath Pointer
    // 148 Include                                  0001865B8B70 ModelClassType XmlSchemaInclude XmlSchemaInclude XmlSchemaInclude Pointer
    // 150 Import                                   0001865B8690 ModelClassType XmlSchemaImport XmlSchemaImport XmlSchemaImport Pointer
    // 158 Annotation                               0001865AD1E0 ModelClassType XmlSchemaAnnotation XmlSchemaAnnotation XmlSchemaAnnotation Pointer
    // 160 AppInfo                                  0001865AE0A0 ModelClassType XmlSchemaAppInfo XmlSchemaAppInfo XmlSchemaAppInfo Pointer
    // 168 Documentation                            0001865B5330 ModelClassType XmlSchemaDocumentation XmlSchemaDocumentation XmlSchemaDocumentation Pointer
    // 170 Facet                                    0001865B6230 ModelClassType XmlSchemaFacet XmlSchemaFacet XmlSchemaFacet Pointer
    // 178 Markup                                   000185CB3E78 ModelClassListType XmlNode[] XmlNode[] List<XmlNode> Pointer
    // 180 Redefine                                 0001865BE1F0 ModelClassType XmlSchemaRedefine XmlSchemaRedefine XmlSchemaRedefine Pointer
    // 188 ValidationEventHandler                   000186765AD0 ModelClassType ValidationEventHandler ValidationEventHandler ValidationEventHandler Pointer
    // 190 UnhandledAttributes                      00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 198 Namespaces                               0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    public partial class XsdBuilder : DataModel
    {
        public List<State>?                             AttributeSubelements                    { get; set; }
        public List<State>?                             ElementSubelements                      { get; set; }
        public List<State>?                             ComplexTypeSubelements                  { get; set; }
        public List<State>?                             SimpleContentSubelements                { get; set; }
        public List<State>?                             SimpleContentExtensionSubelements       { get; set; }
        public List<State>?                             SimpleContentRestrictionSubelements     { get; set; }
        public List<State>?                             ComplexContentSubelements               { get; set; }
        public List<State>?                             ComplexContentExtensionSubelements      { get; set; }
        public List<State>?                             ComplexContentRestrictionSubelements    { get; set; }
        public List<State>?                             SimpleTypeSubelements                   { get; set; }
        public List<State>?                             SimpleTypeRestrictionSubelements        { get; set; }
        public List<State>?                             SimpleTypeListSubelements               { get; set; }
        public List<State>?                             SimpleTypeUnionSubelements              { get; set; }
        public List<State>?                             RedefineSubelements                     { get; set; }
        public List<State>?                             AttributeGroupSubelements               { get; set; }
        public List<State>?                             GroupSubelements                        { get; set; }
        public List<State>?                             AllSubelements                          { get; set; }
        public List<State>?                             ChoiceSequenceSubelements               { get; set; }
        public List<State>?                             IdentityConstraintSubelements           { get; set; }
        public List<State>?                             AnnotationSubelements                   { get; set; }
        public List<State>?                             AnnotatedSubelements                    { get; set; }
        public List<XsdAttributeEntry>?                 SchemaAttributes                        { get; set; }
        public List<XsdAttributeEntry>?                 AttributeAttributes                     { get; set; }
        public List<XsdAttributeEntry>?                 ElementAttributes                       { get; set; }
        public List<XsdAttributeEntry>?                 ComplexTypeAttributes                   { get; set; }
        public List<XsdAttributeEntry>?                 SimpleContentAttributes                 { get; set; }
        public List<XsdAttributeEntry>?                 SimpleContentExtensionAttributes        { get; set; }
        public List<XsdAttributeEntry>?                 SimpleContentRestrictionAttributes      { get; set; }
        public List<XsdAttributeEntry>?                 ComplexContentAttributes                { get; set; }
        public List<XsdAttributeEntry>?                 ComplexContentExtensionAttributes       { get; set; }
        public List<XsdAttributeEntry>?                 ComplexContentRestrictionAttributes     { get; set; }
        public List<XsdAttributeEntry>?                 SimpleTypeAttributes                    { get; set; }
        public List<XsdAttributeEntry>?                 SimpleTypeRestrictionAttributes         { get; set; }
        public List<XsdAttributeEntry>?                 SimpleTypeUnionAttributes               { get; set; }
        public List<XsdAttributeEntry>?                 SimpleTypeListAttributes                { get; set; }
        public List<XsdAttributeEntry>?                 AttributeGroupAttributes                { get; set; }
        public List<XsdAttributeEntry>?                 AttributeGroupRefAttributes             { get; set; }
        public List<XsdAttributeEntry>?                 GroupAttributes                         { get; set; }
        public List<XsdAttributeEntry>?                 GroupRefAttributes                      { get; set; }
        public List<XsdAttributeEntry>?                 ParticleAttributes                      { get; set; }
        public List<XsdAttributeEntry>?                 AnyAttributes                           { get; set; }
        public List<XsdAttributeEntry>?                 IdentityConstraintAttributes            { get; set; }
        public List<XsdAttributeEntry>?                 SelectorAttributes                      { get; set; }
        public List<XsdAttributeEntry>?                 FieldAttributes                         { get; set; }
        public List<XsdAttributeEntry>?                 NotationAttributes                      { get; set; }
        public List<XsdAttributeEntry>?                 IncludeAttributes                       { get; set; }
        public List<XsdAttributeEntry>?                 ImportAttributes                        { get; set; }
        public List<XsdAttributeEntry>?                 FacetAttributes                         { get; set; }
        public List<XsdAttributeEntry>?                 AnyAttributeAttributes                  { get; set; }
        public List<XsdAttributeEntry>?                 DocumentationAttributes                 { get; set; }
        public List<XsdAttributeEntry>?                 AppinfoAttributes                       { get; set; }
        public List<XsdAttributeEntry>?                 RedefineAttributes                      { get; set; }
        public List<XsdAttributeEntry>?                 AnnotationAttributes                    { get; set; }
        public List<XsdEntry>?                          SchemaEntries                           { get; set; }
        public List<int>?                               DerivationMethodValues                  { get; set; }
        public List<string>?                            DerivationMethodStrings                 { get; set; }
        public List<string>?                            FormStringValues                        { get; set; }
        public List<string>?                            UseStringValues                         { get; set; }
        public List<string>?                            ProcessContentsStringValues             { get; set; }
        public XmlReader?                               Reader                                  { get; set; }
        public PositionInfo?                            PositionInfo                            { get; set; }
        public XsdEntry?                                CurrentEntry                            { get; set; }
        public XsdEntry?                                NextEntry                               { get; set; }
        public bool                                     HasChild                                { get; set; }
        public HWStack?                                 StateHistory                            { get; set; }
        public Stack?                                   ContainerStack                          { get; set; }
        public XmlNameTable?                            NameTable                               { get; set; }
        public SchemaNames?                             SchemaNames                             { get; set; }
        public XmlNamespaceManager?                     NamespaceManager                        { get; set; }
        public bool                                     CanIncludeImport                        { get; set; }
        public XmlSchema?                               Schema                                  { get; set; }
        public XmlSchemaObject?                         Xso                                     { get; set; }
        public XmlSchemaElement?                        Element                                 { get; set; }
        public XmlSchemaAny?                            AnyElement                              { get; set; }
        public XmlSchemaAttribute?                      Attribute                               { get; set; }
        public XmlSchemaAnyAttribute?                   AnyAttribute                            { get; set; }
        public XmlSchemaComplexType?                    ComplexType                             { get; set; }
        public XmlSchemaSimpleType?                     SimpleType                              { get; set; }
        public XmlSchemaComplexContent?                 ComplexContent                          { get; set; }
        public XmlSchemaComplexContentExtension?        ComplexContentExtension                 { get; set; }
        public XmlSchemaComplexContentRestriction?      ComplexContentRestriction               { get; set; }
        public XmlSchemaSimpleContent?                  SimpleContent                           { get; set; }
        public XmlSchemaSimpleContentExtension?         SimpleContentExtension                  { get; set; }
        public XmlSchemaSimpleContentRestriction?       SimpleContentRestriction                { get; set; }
        public XmlSchemaSimpleTypeUnion?                SimpleTypeUnion                         { get; set; }
        public XmlSchemaSimpleTypeList?                 SimpleTypeList                          { get; set; }
        public XmlSchemaSimpleTypeRestriction?          SimpleTypeRestriction                   { get; set; }
        public XmlSchemaGroup?                          Group                                   { get; set; }
        public XmlSchemaGroupRef?                       GroupRef                                { get; set; }
        public XmlSchemaAll?                            All                                     { get; set; }
        public XmlSchemaChoice?                         Choice                                  { get; set; }
        public XmlSchemaSequence?                       Sequence                                { get; set; }
        public XmlSchemaParticle?                       Particle                                { get; set; }
        public XmlSchemaAttributeGroup?                 AttributeGroup                          { get; set; }
        public XmlSchemaAttributeGroupRef?              AttributeGroupRef                       { get; set; }
        public XmlSchemaNotation?                       Notation                                { get; set; }
        public XmlSchemaIdentityConstraint?             IdentityConstraint                      { get; set; }
        public XmlSchemaXPath?                          Xpath                                   { get; set; }
        public XmlSchemaInclude?                        Include                                 { get; set; }
        public XmlSchemaImport?                         Import                                  { get; set; }
        public XmlSchemaAnnotation?                     Annotation                              { get; set; }
        public XmlSchemaAppInfo?                        AppInfo                                 { get; set; }
        public XmlSchemaDocumentation?                  Documentation                           { get; set; }
        public XmlSchemaFacet?                          Facet                                   { get; set; }
        public List<XmlNode>?                           Markup                                  { get; set; }
        public XmlSchemaRedefine?                       Redefine                                { get; set; }
        public ValidationEventHandler?                  ValidationEventHandler                  { get; set; }
        public ArrayList?                               UnhandledAttributes                     { get; set; }
        public Hashtable?                               Namespaces                              { get; set; }

        public static XsdBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XsdBuilder() { Pointer= p0 };

            value.AttributeSubelements                      = GetEnumList<State>(new IntPtr(p + 0x010)); // 024667660398 0x10 AttributeSubelements        ( 000185CC96F8 ModelEnumListType State[] State[] List<State> Pointer )
            value.ElementSubelements                        = GetEnumList<State>(new IntPtr(p + 0x018)); // 0246676603B8 0x18 ElementSubelements          ( 000185CC96F8 ModelEnumListType State[] State[] List<State> Pointer )
            value.ComplexTypeSubelements                    = GetEnumList<State>(new IntPtr(p + 0x020)); // 0246676603D8 0x20 ComplexTypeSubelements      ( 000185CC96F8 ModelEnumListType State[] State[] List<State> Pointer )
            value.SimpleContentSubelements                  = GetEnumList<State>(new IntPtr(p + 0x028)); // 0246676603F8 0x28 SimpleContentSubelements    ( 000185CC96F8 ModelEnumListType State[] State[] List<State> Pointer )
            value.SimpleContentExtensionSubelements         = GetEnumList<State>(new IntPtr(p + 0x030)); // 024667660418 0x30 SimpleContentExtensionSubelements ( 000185CC96F8 ModelEnumListType State[] State[] List<State> Pointer )
            value.SimpleContentRestrictionSubelements       = GetEnumList<State>(new IntPtr(p + 0x038)); // 024667660438 0x38 SimpleContentRestrictionSubelements ( 000185CC96F8 ModelEnumListType State[] State[] List<State> Pointer )
            value.ComplexContentSubelements                 = GetEnumList<State>(new IntPtr(p + 0x040)); // 024667660458 0x40 ComplexContentSubelements   ( 000185CC96F8 ModelEnumListType State[] State[] List<State> Pointer )
            value.ComplexContentExtensionSubelements        = GetEnumList<State>(new IntPtr(p + 0x048)); // 024667660478 0x48 ComplexContentExtensionSubelements ( 000185CC96F8 ModelEnumListType State[] State[] List<State> Pointer )
            value.ComplexContentRestrictionSubelements      = GetEnumList<State>(new IntPtr(p + 0x050)); // 024667660498 0x50 ComplexContentRestrictionSubelements ( 000185CC96F8 ModelEnumListType State[] State[] List<State> Pointer )
            value.SimpleTypeSubelements                     = GetEnumList<State>(new IntPtr(p + 0x058)); // 0246676604B8 0x58 SimpleTypeSubelements       ( 000185CC96F8 ModelEnumListType State[] State[] List<State> Pointer )
            value.SimpleTypeRestrictionSubelements          = GetEnumList<State>(new IntPtr(p + 0x060)); // 0246676604D8 0x60 SimpleTypeRestrictionSubelements ( 000185CC96F8 ModelEnumListType State[] State[] List<State> Pointer )
            value.SimpleTypeListSubelements                 = GetEnumList<State>(new IntPtr(p + 0x068)); // 0246676604F8 0x68 SimpleTypeListSubelements   ( 000185CC96F8 ModelEnumListType State[] State[] List<State> Pointer )
            value.SimpleTypeUnionSubelements                = GetEnumList<State>(new IntPtr(p + 0x070)); // 024667660518 0x70 SimpleTypeUnionSubelements  ( 000185CC96F8 ModelEnumListType State[] State[] List<State> Pointer )
            value.RedefineSubelements                       = GetEnumList<State>(new IntPtr(p + 0x078)); // 024667660538 0x78 RedefineSubelements         ( 000185CC96F8 ModelEnumListType State[] State[] List<State> Pointer )
            value.AttributeGroupSubelements                 = GetEnumList<State>(new IntPtr(p + 0x080)); // 024667660558 0x80 AttributeGroupSubelements   ( 000185CC96F8 ModelEnumListType State[] State[] List<State> Pointer )
            value.GroupSubelements                          = GetEnumList<State>(new IntPtr(p + 0x088)); // 024667660578 0x88 GroupSubelements            ( 000185CC96F8 ModelEnumListType State[] State[] List<State> Pointer )
            value.AllSubelements                            = GetEnumList<State>(new IntPtr(p + 0x090)); // 024667660598 0x90 AllSubelements              ( 000185CC96F8 ModelEnumListType State[] State[] List<State> Pointer )
            value.ChoiceSequenceSubelements                 = GetEnumList<State>(new IntPtr(p + 0x098)); // 0246676605B8 0x98 ChoiceSequenceSubelements   ( 000185CC96F8 ModelEnumListType State[] State[] List<State> Pointer )
            value.IdentityConstraintSubelements             = GetEnumList<State>(new IntPtr(p + 0x0A0)); // 0246676605D8 0xA0 IdentityConstraintSubelements ( 000185CC96F8 ModelEnumListType State[] State[] List<State> Pointer )
            value.AnnotationSubelements                     = GetEnumList<State>(new IntPtr(p + 0x0A8)); // 0246676605F8 0xA8 AnnotationSubelements       ( 000185CC96F8 ModelEnumListType State[] State[] List<State> Pointer )
            value.AnnotatedSubelements                      = GetEnumList<State>(new IntPtr(p + 0x0B0)); // 024667660618 0xB0 AnnotatedSubelements        ( 000185CC96F8 ModelEnumListType State[] State[] List<State> Pointer )
            value.SchemaAttributes                          = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 024667660638 0xB8 SchemaAttributes            ( 000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.AttributeAttributes                       = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 024667660658 0xC0 AttributeAttributes         ( 000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.ElementAttributes                         = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 024667660678 0xC8 ElementAttributes           ( 000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.ComplexTypeAttributes                     = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 024667660698 0xD0 ComplexTypeAttributes       ( 000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.SimpleContentAttributes                   = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0246676606B8 0xD8 SimpleContentAttributes     ( 000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.SimpleContentExtensionAttributes          = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0246676606D8 0xE0 SimpleContentExtensionAttributes ( 000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.SimpleContentRestrictionAttributes        = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0246676606F8 0xE8 SimpleContentRestrictionAttributes ( 000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.ComplexContentAttributes                  = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 024667660718 0xF0 ComplexContentAttributes    ( 000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.ComplexContentExtensionAttributes         = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 024667660738 0xF8 ComplexContentExtensionAttributes ( 000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.ComplexContentRestrictionAttributes       = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x100), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 024667660758 0x100 ComplexContentRestrictionAttributes ( 000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.SimpleTypeAttributes                      = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x108), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 024667660778 0x108 SimpleTypeAttributes        ( 000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.SimpleTypeRestrictionAttributes           = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x110), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 024667660798 0x110 SimpleTypeRestrictionAttributes ( 000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.SimpleTypeUnionAttributes                 = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x118), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0246676607B8 0x118 SimpleTypeUnionAttributes   ( 000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.SimpleTypeListAttributes                  = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x120), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0246676607D8 0x120 SimpleTypeListAttributes    ( 000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.AttributeGroupAttributes                  = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x128), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0246676607F8 0x128 AttributeGroupAttributes    ( 000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.AttributeGroupRefAttributes               = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x130), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 024667660818 0x130 AttributeGroupRefAttributes ( 000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.GroupAttributes                           = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x138), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 024667660838 0x138 GroupAttributes             ( 000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.GroupRefAttributes                        = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x140), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 024667660858 0x140 GroupRefAttributes          ( 000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.ParticleAttributes                        = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x148), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 024667660878 0x148 ParticleAttributes          ( 000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.AnyAttributes                             = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x150), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 024667660898 0x150 AnyAttributes               ( 000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.IdentityConstraintAttributes              = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x158), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0246676608B8 0x158 IdentityConstraintAttributes ( 000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.SelectorAttributes                        = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x160), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0246676608D8 0x160 SelectorAttributes          ( 000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.FieldAttributes                           = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x168), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0246676608F8 0x168 FieldAttributes             ( 000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.NotationAttributes                        = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x170), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 024667660918 0x170 NotationAttributes          ( 000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.IncludeAttributes                         = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x178), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 024667660938 0x178 IncludeAttributes           ( 000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.ImportAttributes                          = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x180), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 024667660958 0x180 ImportAttributes            ( 000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.FacetAttributes                           = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x188), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 024667660978 0x188 FacetAttributes             ( 000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.AnyAttributeAttributes                    = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x190), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 024667660998 0x190 AnyAttributeAttributes      ( 000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.DocumentationAttributes                   = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x198), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0246676609B8 0x198 DocumentationAttributes     ( 000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.AppinfoAttributes                         = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x1A0), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0246676609D8 0x1A0 AppinfoAttributes           ( 000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.RedefineAttributes                        = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x1A8), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0246676609F8 0x1A8 RedefineAttributes          ( 000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.AnnotationAttributes                      = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x1B0), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 024667660A18 0x1B0 AnnotationAttributes        ( 000185CC99C8 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.SchemaEntries                             = GetObjectList<XsdEntry>(new IntPtr(p + 0x1B8), ReversePrism.DataModels.XsdEntry.FromPointer); // 024667660A38 0x1B8 SchemaEntries               ( 000185CC9B18 ModelClassListType XsdEntry[] XsdEntry[] List<XsdEntry> Pointer )
            value.DerivationMethodValues                    = GetInt32List(new IntPtr(p + 0x1C0)); // 024667660A58 0x1C0 DerivationMethodValues      ( 000185B7DCD0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.DerivationMethodStrings                   = GetStringList(new IntPtr(p + 0x1C8)); // 024667660A78 0x1C8 DerivationMethodStrings     ( 000185B820A0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.FormStringValues                          = GetStringList(new IntPtr(p + 0x1D0)); // 024667660A98 0x1D0 FormStringValues            ( 000185B820A0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.UseStringValues                           = GetStringList(new IntPtr(p + 0x1D8)); // 024667660AB8 0x1D8 UseStringValues             ( 000185B820A0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.ProcessContentsStringValues               = GetStringList(new IntPtr(p + 0x1E0)); // 024667660AD8 0x1E0 ProcessContentsStringValues ( 000185B820A0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Reader                                    = GetObject<XmlReader>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlReader.FromPointer); // 024667660AF8 0x10 Reader                      ( 0001865A9BB0 ModelClassType XmlReader XmlReader XmlReader Pointer )
            value.PositionInfo                              = GetObject<PositionInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.PositionInfo.FromPointer); // 024667660B18 0x18 PositionInfo                ( 000186768940 ModelClassType PositionInfo PositionInfo PositionInfo Pointer )
            value.CurrentEntry                              = GetObject<XsdEntry>(new IntPtr(p + 0x020), ReversePrism.DataModels.XsdEntry.FromPointer); // 024667660B38 0x20 CurrentEntry                ( 000186754750 ModelClassType XsdEntry XsdEntry XsdEntry Pointer )
            value.NextEntry                                 = GetObject<XsdEntry>(new IntPtr(p + 0x028), ReversePrism.DataModels.XsdEntry.FromPointer); // 024667660B58 0x28 NextEntry                   ( 000186754750 ModelClassType XsdEntry XsdEntry XsdEntry Pointer )
            value.HasChild                                  = GetBool(new IntPtr(p + 0x030)); // 024667660B78 0x30 HasChild                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.StateHistory                              = GetObject<HWStack>(new IntPtr(p + 0x038), ReversePrism.DataModels.HWStack.FromPointer); // 024667660B98 0x38 StateHistory                ( 0001866A4660 ModelClassType HWStack HWStack HWStack Pointer )
            value.ContainerStack                            = GetObject<Stack>(new IntPtr(p + 0x040), ReversePrism.DataModels.Stack.FromPointer); // 024667660BB8 0x40 ContainerStack              ( 00018655EBF0 ModelClassType Stack Stack Stack Pointer )
            value.NameTable                                 = GetObject<XmlNameTable>(new IntPtr(p + 0x048), ReversePrism.DataModels.XmlNameTable.FromPointer); // 024667660BD8 0x48 NameTable                   ( 0001865A0930 ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer )
            value.SchemaNames                               = GetObject<SchemaNames>(new IntPtr(p + 0x050), ReversePrism.DataModels.SchemaNames.FromPointer); // 024667660BF8 0x50 SchemaNames                 ( 0001866EA5B0 ModelClassType SchemaNames SchemaNames SchemaNames Pointer )
            value.NamespaceManager                          = GetObject<XmlNamespaceManager>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlNamespaceManager.FromPointer); // 024667660C18 0x58 NamespaceManager            ( 0001866BAB00 ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer )
            value.CanIncludeImport                          = GetBool(new IntPtr(p + 0x060)); // 024667660C38 0x60 CanIncludeImport            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Schema                                    = GetObject<XmlSchema>(new IntPtr(p + 0x068), ReversePrism.DataModels.XmlSchema.FromPointer); // 024667660C58 0x68 Schema                      ( 0001866BE120 ModelClassType XmlSchema XmlSchema XmlSchema Pointer )
            value.Xso                                       = GetObject<XmlSchemaObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.XmlSchemaObject.FromPointer); // 024667660C78 0x70 Xso                         ( 0001865BB990 ModelClassType XmlSchemaObject XmlSchemaObject XmlSchemaObject Pointer )
            value.Element                                   = GetObject<XmlSchemaElement>(new IntPtr(p + 0x078), ReversePrism.DataModels.XmlSchemaElement.FromPointer); // 024667660C98 0x78 Element                     ( 0001866BED30 ModelClassType XmlSchemaElement XmlSchemaElement XmlSchemaElement Pointer )
            value.AnyElement                                = GetObject<XmlSchemaAny>(new IntPtr(p + 0x080), ReversePrism.DataModels.XmlSchemaAny.FromPointer); // 024667660CB8 0x80 AnyElement                  ( 0001865AD6E0 ModelClassType XmlSchemaAny XmlSchemaAny XmlSchemaAny Pointer )
            value.Attribute                                 = GetObject<XmlSchemaAttribute>(new IntPtr(p + 0x088), ReversePrism.DataModels.XmlSchemaAttribute.FromPointer); // 024667660CD8 0x88 Attribute                   ( 0001865AE470 ModelClassType XmlSchemaAttribute XmlSchemaAttribute XmlSchemaAttribute Pointer )
            value.AnyAttribute                              = GetObject<XmlSchemaAnyAttribute>(new IntPtr(p + 0x090), ReversePrism.DataModels.XmlSchemaAnyAttribute.FromPointer); // 024667660CF8 0x90 AnyAttribute                ( 0001865ADBC0 ModelClassType XmlSchemaAnyAttribute XmlSchemaAnyAttribute XmlSchemaAnyAttribute Pointer )
            value.ComplexType                               = GetObject<XmlSchemaComplexType>(new IntPtr(p + 0x098), ReversePrism.DataModels.XmlSchemaComplexType.FromPointer); // 024667660D18 0x98 ComplexType                 ( 0001865B15A0 ModelClassType XmlSchemaComplexType XmlSchemaComplexType XmlSchemaComplexType Pointer )
            value.SimpleType                                = GetObject<XmlSchemaSimpleType>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.XmlSchemaSimpleType.FromPointer); // 024667660D38 0xA0 SimpleType                  ( 0001866BF5F0 ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer )
            value.ComplexContent                            = GetObject<XmlSchemaComplexContent>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.XmlSchemaComplexContent.FromPointer); // 024667660D58 0xA8 ComplexContent              ( 0001865B0710 ModelClassType XmlSchemaComplexContent XmlSchemaComplexContent XmlSchemaComplexContent Pointer )
            value.ComplexContentExtension                   = GetObject<XmlSchemaComplexContentExtension>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.XmlSchemaComplexContentExtension.FromPointer); // 024667660D78 0xB0 ComplexContentExtension     ( 0001865B0BF0 ModelClassType XmlSchemaComplexContentExtension XmlSchemaComplexContentExtension XmlSchemaComplexContentExtension Pointer )
            value.ComplexContentRestriction                 = GetObject<XmlSchemaComplexContentRestriction>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.XmlSchemaComplexContentRestriction.FromPointer); // 024667660D98 0xB8 ComplexContentRestriction   ( 0001865B10B0 ModelClassType XmlSchemaComplexContentRestriction XmlSchemaComplexContentRestriction XmlSchemaComplexContentRestriction Pointer )
            value.SimpleContent                             = GetObject<XmlSchemaSimpleContent>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.XmlSchemaSimpleContent.FromPointer); // 024667660DB8 0xC0 SimpleContent               ( 0001865BF310 ModelClassType XmlSchemaSimpleContent XmlSchemaSimpleContent XmlSchemaSimpleContent Pointer )
            value.SimpleContentExtension                    = GetObject<XmlSchemaSimpleContentExtension>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.XmlSchemaSimpleContentExtension.FromPointer); // 024667660DD8 0xC8 SimpleContentExtension      ( 0001865BF850 ModelClassType XmlSchemaSimpleContentExtension XmlSchemaSimpleContentExtension XmlSchemaSimpleContentExtension Pointer )
            value.SimpleContentRestriction                  = GetObject<XmlSchemaSimpleContentRestriction>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.XmlSchemaSimpleContentRestriction.FromPointer); // 024667660DF8 0xD0 SimpleContentRestriction    ( 0001865BFD50 ModelClassType XmlSchemaSimpleContentRestriction XmlSchemaSimpleContentRestriction XmlSchemaSimpleContentRestriction Pointer )
            value.SimpleTypeUnion                           = GetObject<XmlSchemaSimpleTypeUnion>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.XmlSchemaSimpleTypeUnion.FromPointer); // 024667660E18 0xD8 SimpleTypeUnion             ( 0001865C1130 ModelClassType XmlSchemaSimpleTypeUnion XmlSchemaSimpleTypeUnion XmlSchemaSimpleTypeUnion Pointer )
            value.SimpleTypeList                            = GetObject<XmlSchemaSimpleTypeList>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.XmlSchemaSimpleTypeList.FromPointer); // 024667660E38 0xE0 SimpleTypeList              ( 0001865C0710 ModelClassType XmlSchemaSimpleTypeList XmlSchemaSimpleTypeList XmlSchemaSimpleTypeList Pointer )
            value.SimpleTypeRestriction                     = GetObject<XmlSchemaSimpleTypeRestriction>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.XmlSchemaSimpleTypeRestriction.FromPointer); // 024667660E58 0xE8 SimpleTypeRestriction       ( 0001865C0C10 ModelClassType XmlSchemaSimpleTypeRestriction XmlSchemaSimpleTypeRestriction XmlSchemaSimpleTypeRestriction Pointer )
            value.Group                                     = GetObject<XmlSchemaGroup>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.XmlSchemaGroup.FromPointer); // 024667660E78 0xF0 Group                       ( 0001865B70D0 ModelClassType XmlSchemaGroup XmlSchemaGroup XmlSchemaGroup Pointer )
            value.GroupRef                                  = GetObject<XmlSchemaGroupRef>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.XmlSchemaGroupRef.FromPointer); // 024667660E98 0xF8 GroupRef                    ( 0001865B7A90 ModelClassType XmlSchemaGroupRef XmlSchemaGroupRef XmlSchemaGroupRef Pointer )
            value.All                                       = GetObject<XmlSchemaAll>(new IntPtr(p + 0x100), ReversePrism.DataModels.XmlSchemaAll.FromPointer); // 024667660EB8 0x100 All                         ( 0001865ACAA0 ModelClassType XmlSchemaAll XmlSchemaAll XmlSchemaAll Pointer )
            value.Choice                                    = GetObject<XmlSchemaChoice>(new IntPtr(p + 0x108), ReversePrism.DataModels.XmlSchemaChoice.FromPointer); // 024667660ED8 0x108 Choice                      ( 0001865AF340 ModelClassType XmlSchemaChoice XmlSchemaChoice XmlSchemaChoice Pointer )
            value.Sequence                                  = GetObject<XmlSchemaSequence>(new IntPtr(p + 0x110), ReversePrism.DataModels.XmlSchemaSequence.FromPointer); // 024667660EF8 0x110 Sequence                    ( 0001865BE990 ModelClassType XmlSchemaSequence XmlSchemaSequence XmlSchemaSequence Pointer )
            value.Particle                                  = GetObject<XmlSchemaParticle>(new IntPtr(p + 0x118), ReversePrism.DataModels.XmlSchemaParticle.FromPointer); // 024667660F18 0x118 Particle                    ( 0001865BD330 ModelClassType XmlSchemaParticle XmlSchemaParticle XmlSchemaParticle Pointer )
            value.AttributeGroup                            = GetObject<XmlSchemaAttributeGroup>(new IntPtr(p + 0x120), ReversePrism.DataModels.XmlSchemaAttributeGroup.FromPointer); // 024667660F38 0x120 AttributeGroup              ( 0001865AE960 ModelClassType XmlSchemaAttributeGroup XmlSchemaAttributeGroup XmlSchemaAttributeGroup Pointer )
            value.AttributeGroupRef                         = GetObject<XmlSchemaAttributeGroupRef>(new IntPtr(p + 0x128), ReversePrism.DataModels.XmlSchemaAttributeGroupRef.FromPointer); // 024667660F58 0x128 AttributeGroupRef           ( 0001865AEE40 ModelClassType XmlSchemaAttributeGroupRef XmlSchemaAttributeGroupRef XmlSchemaAttributeGroupRef Pointer )
            value.Notation                                  = GetObject<XmlSchemaNotation>(new IntPtr(p + 0x130), ReversePrism.DataModels.XmlSchemaNotation.FromPointer); // 024667660F78 0x130 Notation                    ( 0001865BB330 ModelClassType XmlSchemaNotation XmlSchemaNotation XmlSchemaNotation Pointer )
            value.IdentityConstraint                        = GetObject<XmlSchemaIdentityConstraint>(new IntPtr(p + 0x138), ReversePrism.DataModels.XmlSchemaIdentityConstraint.FromPointer); // 024667660F98 0x138 IdentityConstraint          ( 0001865B7F40 ModelClassType XmlSchemaIdentityConstraint XmlSchemaIdentityConstraint XmlSchemaIdentityConstraint Pointer )
            value.Xpath                                     = GetObject<XmlSchemaXPath>(new IntPtr(p + 0x140), ReversePrism.DataModels.XmlSchemaXPath.FromPointer); // 024667660FB8 0x140 Xpath                       ( 0001865C4920 ModelClassType XmlSchemaXPath XmlSchemaXPath XmlSchemaXPath Pointer )
            value.Include                                   = GetObject<XmlSchemaInclude>(new IntPtr(p + 0x148), ReversePrism.DataModels.XmlSchemaInclude.FromPointer); // 024667660FD8 0x148 Include                     ( 0001865B8B70 ModelClassType XmlSchemaInclude XmlSchemaInclude XmlSchemaInclude Pointer )
            value.Import                                    = GetObject<XmlSchemaImport>(new IntPtr(p + 0x150), ReversePrism.DataModels.XmlSchemaImport.FromPointer); // 024667660FF8 0x150 Import                      ( 0001865B8690 ModelClassType XmlSchemaImport XmlSchemaImport XmlSchemaImport Pointer )
            value.Annotation                                = GetObject<XmlSchemaAnnotation>(new IntPtr(p + 0x158), ReversePrism.DataModels.XmlSchemaAnnotation.FromPointer); // 024667661018 0x158 Annotation                  ( 0001865AD1E0 ModelClassType XmlSchemaAnnotation XmlSchemaAnnotation XmlSchemaAnnotation Pointer )
            value.AppInfo                                   = GetObject<XmlSchemaAppInfo>(new IntPtr(p + 0x160), ReversePrism.DataModels.XmlSchemaAppInfo.FromPointer); // 024667661038 0x160 AppInfo                     ( 0001865AE0A0 ModelClassType XmlSchemaAppInfo XmlSchemaAppInfo XmlSchemaAppInfo Pointer )
            value.Documentation                             = GetObject<XmlSchemaDocumentation>(new IntPtr(p + 0x168), ReversePrism.DataModels.XmlSchemaDocumentation.FromPointer); // 024667661058 0x168 Documentation               ( 0001865B5330 ModelClassType XmlSchemaDocumentation XmlSchemaDocumentation XmlSchemaDocumentation Pointer )
            value.Facet                                     = GetObject<XmlSchemaFacet>(new IntPtr(p + 0x170), ReversePrism.DataModels.XmlSchemaFacet.FromPointer); // 024667661078 0x170 Facet                       ( 0001865B6230 ModelClassType XmlSchemaFacet XmlSchemaFacet XmlSchemaFacet Pointer )
            value.Markup                                    = GetObjectList<XmlNode>(new IntPtr(p + 0x178), ReversePrism.DataModels.XmlNode.FromPointer); // 024667661098 0x178 Markup                      ( 000185CB3E78 ModelClassListType XmlNode[] XmlNode[] List<XmlNode> Pointer )
            value.Redefine                                  = GetObject<XmlSchemaRedefine>(new IntPtr(p + 0x180), ReversePrism.DataModels.XmlSchemaRedefine.FromPointer); // 0246676610B8 0x180 Redefine                    ( 0001865BE1F0 ModelClassType XmlSchemaRedefine XmlSchemaRedefine XmlSchemaRedefine Pointer )
            value.ValidationEventHandler                    = GetObject<ValidationEventHandler>(new IntPtr(p + 0x188), ReversePrism.DataModels.ValidationEventHandler.FromPointer); // 0246676610D8 0x188 ValidationEventHandler      ( 000186765AD0 ModelClassType ValidationEventHandler ValidationEventHandler ValidationEventHandler Pointer )
            value.UnhandledAttributes                       = GetObject<ArrayList>(new IntPtr(p + 0x190), ReversePrism.DataModels.ArrayList.FromPointer); // 0246676610F8 0x190 UnhandledAttributes         ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.Namespaces                                = GetObject<Hashtable>(new IntPtr(p + 0x198), ReversePrism.DataModels.Hashtable.FromPointer); // 024667661118 0x198 Namespaces                  ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )

            return value;
        }
    }
}
