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
    // 010 AttributeSubelements                     ModelEnumListType State[] State[] List<State> Pointer
    // 018 ElementSubelements                       ModelEnumListType State[] State[] List<State> Pointer
    // 020 ComplexTypeSubelements                   ModelEnumListType State[] State[] List<State> Pointer
    // 028 SimpleContentSubelements                 ModelEnumListType State[] State[] List<State> Pointer
    // 030 SimpleContentExtensionSubelements        ModelEnumListType State[] State[] List<State> Pointer
    // 038 SimpleContentRestrictionSubelements      ModelEnumListType State[] State[] List<State> Pointer
    // 040 ComplexContentSubelements                ModelEnumListType State[] State[] List<State> Pointer
    // 048 ComplexContentExtensionSubelements       ModelEnumListType State[] State[] List<State> Pointer
    // 050 ComplexContentRestrictionSubelements     ModelEnumListType State[] State[] List<State> Pointer
    // 058 SimpleTypeSubelements                    ModelEnumListType State[] State[] List<State> Pointer
    // 060 SimpleTypeRestrictionSubelements         ModelEnumListType State[] State[] List<State> Pointer
    // 068 SimpleTypeListSubelements                ModelEnumListType State[] State[] List<State> Pointer
    // 070 SimpleTypeUnionSubelements               ModelEnumListType State[] State[] List<State> Pointer
    // 078 RedefineSubelements                      ModelEnumListType State[] State[] List<State> Pointer
    // 080 AttributeGroupSubelements                ModelEnumListType State[] State[] List<State> Pointer
    // 088 GroupSubelements                         ModelEnumListType State[] State[] List<State> Pointer
    // 090 AllSubelements                           ModelEnumListType State[] State[] List<State> Pointer
    // 098 ChoiceSequenceSubelements                ModelEnumListType State[] State[] List<State> Pointer
    // 0A0 IdentityConstraintSubelements            ModelEnumListType State[] State[] List<State> Pointer
    // 0A8 AnnotationSubelements                    ModelEnumListType State[] State[] List<State> Pointer
    // 0B0 AnnotatedSubelements                     ModelEnumListType State[] State[] List<State> Pointer
    // 0B8 SchemaAttributes                         ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 0C0 AttributeAttributes                      ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 0C8 ElementAttributes                        ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 0D0 ComplexTypeAttributes                    ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 0D8 SimpleContentAttributes                  ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 0E0 SimpleContentExtensionAttributes         ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 0E8 SimpleContentRestrictionAttributes       ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 0F0 ComplexContentAttributes                 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 0F8 ComplexContentExtensionAttributes        ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 100 ComplexContentRestrictionAttributes      ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 108 SimpleTypeAttributes                     ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 110 SimpleTypeRestrictionAttributes          ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 118 SimpleTypeUnionAttributes                ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 120 SimpleTypeListAttributes                 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 128 AttributeGroupAttributes                 ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 130 AttributeGroupRefAttributes              ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 138 GroupAttributes                          ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 140 GroupRefAttributes                       ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 148 ParticleAttributes                       ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 150 AnyAttributes                            ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 158 IdentityConstraintAttributes             ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 160 SelectorAttributes                       ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 168 FieldAttributes                          ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 170 NotationAttributes                       ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 178 IncludeAttributes                        ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 180 ImportAttributes                         ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 188 FacetAttributes                          ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 190 AnyAttributeAttributes                   ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 198 DocumentationAttributes                  ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 1A0 AppinfoAttributes                        ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 1A8 RedefineAttributes                       ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 1B0 AnnotationAttributes                     ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer
    // 1B8 SchemaEntries                            ModelClassListType XsdEntry[] XsdEntry[] List<XsdEntry> Pointer
    // 1C0 DerivationMethodValues                   ModelPrimitiveListType int[] int[] List<int> Pointer
    // 1C8 DerivationMethodStrings                  ModelPrimitiveListType string[] string[] List<string> Pointer
    // 1D0 FormStringValues                         ModelPrimitiveListType string[] string[] List<string> Pointer
    // 1D8 UseStringValues                          ModelPrimitiveListType string[] string[] List<string> Pointer
    // 1E0 ProcessContentsStringValues              ModelPrimitiveListType string[] string[] List<string> Pointer
    // 010 Reader                                   ModelClassType XmlReader XmlReader XmlReader Pointer
    // 018 PositionInfo                             ModelClassType PositionInfo PositionInfo PositionInfo Pointer
    // 020 CurrentEntry                             ModelClassType XsdEntry XsdEntry XsdEntry Pointer
    // 028 NextEntry                                ModelClassType XsdEntry XsdEntry XsdEntry Pointer
    // 030 HasChild                                 ModelPrimitiveType bool bool bool Bool
    // 038 StateHistory                             ModelClassType HWStack HWStack HWStack Pointer
    // 040 ContainerStack                           ModelClassType Stack Stack Stack Pointer
    // 048 NameTable                                ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer
    // 050 SchemaNames                              ModelClassType SchemaNames SchemaNames SchemaNames Pointer
    // 058 NamespaceManager                         ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer
    // 060 CanIncludeImport                         ModelPrimitiveType bool bool bool Bool
    // 068 Schema                                   ModelClassType XmlSchema XmlSchema XmlSchema Pointer
    // 070 Xso                                      ModelClassType XmlSchemaObject XmlSchemaObject XmlSchemaObject Pointer
    // 078 Element                                  ModelClassType XmlSchemaElement XmlSchemaElement XmlSchemaElement Pointer
    // 080 AnyElement                               ModelClassType XmlSchemaAny XmlSchemaAny XmlSchemaAny Pointer
    // 088 Attribute                                ModelClassType XmlSchemaAttribute XmlSchemaAttribute XmlSchemaAttribute Pointer
    // 090 AnyAttribute                             ModelClassType XmlSchemaAnyAttribute XmlSchemaAnyAttribute XmlSchemaAnyAttribute Pointer
    // 098 ComplexType                              ModelClassType XmlSchemaComplexType XmlSchemaComplexType XmlSchemaComplexType Pointer
    // 0A0 SimpleType                               ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer
    // 0A8 ComplexContent                           ModelClassType XmlSchemaComplexContent XmlSchemaComplexContent XmlSchemaComplexContent Pointer
    // 0B0 ComplexContentExtension                  ModelClassType XmlSchemaComplexContentExtension XmlSchemaComplexContentExtension XmlSchemaComplexContentExtension Pointer
    // 0B8 ComplexContentRestriction                ModelClassType XmlSchemaComplexContentRestriction XmlSchemaComplexContentRestriction XmlSchemaComplexContentRestriction Pointer
    // 0C0 SimpleContent                            ModelClassType XmlSchemaSimpleContent XmlSchemaSimpleContent XmlSchemaSimpleContent Pointer
    // 0C8 SimpleContentExtension                   ModelClassType XmlSchemaSimpleContentExtension XmlSchemaSimpleContentExtension XmlSchemaSimpleContentExtension Pointer
    // 0D0 SimpleContentRestriction                 ModelClassType XmlSchemaSimpleContentRestriction XmlSchemaSimpleContentRestriction XmlSchemaSimpleContentRestriction Pointer
    // 0D8 SimpleTypeUnion                          ModelClassType XmlSchemaSimpleTypeUnion XmlSchemaSimpleTypeUnion XmlSchemaSimpleTypeUnion Pointer
    // 0E0 SimpleTypeList                           ModelClassType XmlSchemaSimpleTypeList XmlSchemaSimpleTypeList XmlSchemaSimpleTypeList Pointer
    // 0E8 SimpleTypeRestriction                    ModelClassType XmlSchemaSimpleTypeRestriction XmlSchemaSimpleTypeRestriction XmlSchemaSimpleTypeRestriction Pointer
    // 0F0 Group                                    ModelClassType XmlSchemaGroup XmlSchemaGroup XmlSchemaGroup Pointer
    // 0F8 GroupRef                                 ModelClassType XmlSchemaGroupRef XmlSchemaGroupRef XmlSchemaGroupRef Pointer
    // 100 All                                      ModelClassType XmlSchemaAll XmlSchemaAll XmlSchemaAll Pointer
    // 108 Choice                                   ModelClassType XmlSchemaChoice XmlSchemaChoice XmlSchemaChoice Pointer
    // 110 Sequence                                 ModelClassType XmlSchemaSequence XmlSchemaSequence XmlSchemaSequence Pointer
    // 118 Particle                                 ModelClassType XmlSchemaParticle XmlSchemaParticle XmlSchemaParticle Pointer
    // 120 AttributeGroup                           ModelClassType XmlSchemaAttributeGroup XmlSchemaAttributeGroup XmlSchemaAttributeGroup Pointer
    // 128 AttributeGroupRef                        ModelClassType XmlSchemaAttributeGroupRef XmlSchemaAttributeGroupRef XmlSchemaAttributeGroupRef Pointer
    // 130 Notation                                 ModelClassType XmlSchemaNotation XmlSchemaNotation XmlSchemaNotation Pointer
    // 138 IdentityConstraint                       ModelClassType XmlSchemaIdentityConstraint XmlSchemaIdentityConstraint XmlSchemaIdentityConstraint Pointer
    // 140 Xpath                                    ModelClassType XmlSchemaXPath XmlSchemaXPath XmlSchemaXPath Pointer
    // 148 Include                                  ModelClassType XmlSchemaInclude XmlSchemaInclude XmlSchemaInclude Pointer
    // 150 Import                                   ModelClassType XmlSchemaImport XmlSchemaImport XmlSchemaImport Pointer
    // 158 Annotation                               ModelClassType XmlSchemaAnnotation XmlSchemaAnnotation XmlSchemaAnnotation Pointer
    // 160 AppInfo                                  ModelClassType XmlSchemaAppInfo XmlSchemaAppInfo XmlSchemaAppInfo Pointer
    // 168 Documentation                            ModelClassType XmlSchemaDocumentation XmlSchemaDocumentation XmlSchemaDocumentation Pointer
    // 170 Facet                                    ModelClassType XmlSchemaFacet XmlSchemaFacet XmlSchemaFacet Pointer
    // 178 Markup                                   ModelClassListType XmlNode[] XmlNode[] List<XmlNode> Pointer
    // 180 Redefine                                 ModelClassType XmlSchemaRedefine XmlSchemaRedefine XmlSchemaRedefine Pointer
    // 188 ValidationEventHandler                   ModelClassType ValidationEventHandler ValidationEventHandler ValidationEventHandler Pointer
    // 190 UnhandledAttributes                      ModelClassType ArrayList ArrayList ArrayList Pointer
    // 198 Namespaces                               ModelClassType Hashtable Hashtable Hashtable Pointer
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

            value.AttributeSubelements                      = GetEnumList<State>(new IntPtr(p + 0x010)); // 0x10 AttributeSubelements        ( ModelEnumListType State[] State[] List<State> Pointer )
            value.ElementSubelements                        = GetEnumList<State>(new IntPtr(p + 0x018)); // 0x18 ElementSubelements          ( ModelEnumListType State[] State[] List<State> Pointer )
            value.ComplexTypeSubelements                    = GetEnumList<State>(new IntPtr(p + 0x020)); // 0x20 ComplexTypeSubelements      ( ModelEnumListType State[] State[] List<State> Pointer )
            value.SimpleContentSubelements                  = GetEnumList<State>(new IntPtr(p + 0x028)); // 0x28 SimpleContentSubelements    ( ModelEnumListType State[] State[] List<State> Pointer )
            value.SimpleContentExtensionSubelements         = GetEnumList<State>(new IntPtr(p + 0x030)); // 0x30 SimpleContentExtensionSubelements ( ModelEnumListType State[] State[] List<State> Pointer )
            value.SimpleContentRestrictionSubelements       = GetEnumList<State>(new IntPtr(p + 0x038)); // 0x38 SimpleContentRestrictionSubelements ( ModelEnumListType State[] State[] List<State> Pointer )
            value.ComplexContentSubelements                 = GetEnumList<State>(new IntPtr(p + 0x040)); // 0x40 ComplexContentSubelements   ( ModelEnumListType State[] State[] List<State> Pointer )
            value.ComplexContentExtensionSubelements        = GetEnumList<State>(new IntPtr(p + 0x048)); // 0x48 ComplexContentExtensionSubelements ( ModelEnumListType State[] State[] List<State> Pointer )
            value.ComplexContentRestrictionSubelements      = GetEnumList<State>(new IntPtr(p + 0x050)); // 0x50 ComplexContentRestrictionSubelements ( ModelEnumListType State[] State[] List<State> Pointer )
            value.SimpleTypeSubelements                     = GetEnumList<State>(new IntPtr(p + 0x058)); // 0x58 SimpleTypeSubelements       ( ModelEnumListType State[] State[] List<State> Pointer )
            value.SimpleTypeRestrictionSubelements          = GetEnumList<State>(new IntPtr(p + 0x060)); // 0x60 SimpleTypeRestrictionSubelements ( ModelEnumListType State[] State[] List<State> Pointer )
            value.SimpleTypeListSubelements                 = GetEnumList<State>(new IntPtr(p + 0x068)); // 0x68 SimpleTypeListSubelements   ( ModelEnumListType State[] State[] List<State> Pointer )
            value.SimpleTypeUnionSubelements                = GetEnumList<State>(new IntPtr(p + 0x070)); // 0x70 SimpleTypeUnionSubelements  ( ModelEnumListType State[] State[] List<State> Pointer )
            value.RedefineSubelements                       = GetEnumList<State>(new IntPtr(p + 0x078)); // 0x78 RedefineSubelements         ( ModelEnumListType State[] State[] List<State> Pointer )
            value.AttributeGroupSubelements                 = GetEnumList<State>(new IntPtr(p + 0x080)); // 0x80 AttributeGroupSubelements   ( ModelEnumListType State[] State[] List<State> Pointer )
            value.GroupSubelements                          = GetEnumList<State>(new IntPtr(p + 0x088)); // 0x88 GroupSubelements            ( ModelEnumListType State[] State[] List<State> Pointer )
            value.AllSubelements                            = GetEnumList<State>(new IntPtr(p + 0x090)); // 0x90 AllSubelements              ( ModelEnumListType State[] State[] List<State> Pointer )
            value.ChoiceSequenceSubelements                 = GetEnumList<State>(new IntPtr(p + 0x098)); // 0x98 ChoiceSequenceSubelements   ( ModelEnumListType State[] State[] List<State> Pointer )
            value.IdentityConstraintSubelements             = GetEnumList<State>(new IntPtr(p + 0x0A0)); // 0xA0 IdentityConstraintSubelements ( ModelEnumListType State[] State[] List<State> Pointer )
            value.AnnotationSubelements                     = GetEnumList<State>(new IntPtr(p + 0x0A8)); // 0xA8 AnnotationSubelements       ( ModelEnumListType State[] State[] List<State> Pointer )
            value.AnnotatedSubelements                      = GetEnumList<State>(new IntPtr(p + 0x0B0)); // 0xB0 AnnotatedSubelements        ( ModelEnumListType State[] State[] List<State> Pointer )
            value.SchemaAttributes                          = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0xB8 SchemaAttributes            ( ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.AttributeAttributes                       = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0xC0 AttributeAttributes         ( ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.ElementAttributes                         = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0xC8 ElementAttributes           ( ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.ComplexTypeAttributes                     = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0xD0 ComplexTypeAttributes       ( ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.SimpleContentAttributes                   = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0xD8 SimpleContentAttributes     ( ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.SimpleContentExtensionAttributes          = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0xE0 SimpleContentExtensionAttributes ( ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.SimpleContentRestrictionAttributes        = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0xE8 SimpleContentRestrictionAttributes ( ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.ComplexContentAttributes                  = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0xF0 ComplexContentAttributes    ( ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.ComplexContentExtensionAttributes         = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0xF8 ComplexContentExtensionAttributes ( ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.ComplexContentRestrictionAttributes       = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x100), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0x100 ComplexContentRestrictionAttributes ( ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.SimpleTypeAttributes                      = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x108), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0x108 SimpleTypeAttributes        ( ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.SimpleTypeRestrictionAttributes           = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x110), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0x110 SimpleTypeRestrictionAttributes ( ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.SimpleTypeUnionAttributes                 = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x118), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0x118 SimpleTypeUnionAttributes   ( ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.SimpleTypeListAttributes                  = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x120), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0x120 SimpleTypeListAttributes    ( ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.AttributeGroupAttributes                  = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x128), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0x128 AttributeGroupAttributes    ( ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.AttributeGroupRefAttributes               = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x130), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0x130 AttributeGroupRefAttributes ( ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.GroupAttributes                           = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x138), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0x138 GroupAttributes             ( ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.GroupRefAttributes                        = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x140), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0x140 GroupRefAttributes          ( ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.ParticleAttributes                        = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x148), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0x148 ParticleAttributes          ( ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.AnyAttributes                             = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x150), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0x150 AnyAttributes               ( ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.IdentityConstraintAttributes              = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x158), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0x158 IdentityConstraintAttributes ( ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.SelectorAttributes                        = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x160), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0x160 SelectorAttributes          ( ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.FieldAttributes                           = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x168), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0x168 FieldAttributes             ( ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.NotationAttributes                        = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x170), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0x170 NotationAttributes          ( ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.IncludeAttributes                         = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x178), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0x178 IncludeAttributes           ( ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.ImportAttributes                          = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x180), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0x180 ImportAttributes            ( ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.FacetAttributes                           = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x188), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0x188 FacetAttributes             ( ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.AnyAttributeAttributes                    = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x190), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0x190 AnyAttributeAttributes      ( ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.DocumentationAttributes                   = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x198), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0x198 DocumentationAttributes     ( ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.AppinfoAttributes                         = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x1A0), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0x1A0 AppinfoAttributes           ( ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.RedefineAttributes                        = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x1A8), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0x1A8 RedefineAttributes          ( ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.AnnotationAttributes                      = GetObjectList<XsdAttributeEntry>(new IntPtr(p + 0x1B0), ReversePrism.DataModels.XsdAttributeEntry.FromPointer); // 0x1B0 AnnotationAttributes        ( ModelClassListType XsdAttributeEntry[] XsdAttributeEntry[] List<XsdAttributeEntry> Pointer )
            value.SchemaEntries                             = GetObjectList<XsdEntry>(new IntPtr(p + 0x1B8), ReversePrism.DataModels.XsdEntry.FromPointer); // 0x1B8 SchemaEntries               ( ModelClassListType XsdEntry[] XsdEntry[] List<XsdEntry> Pointer )
            value.DerivationMethodValues                    = GetInt32List(new IntPtr(p + 0x1C0)); // 0x1C0 DerivationMethodValues      ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.DerivationMethodStrings                   = GetStringList(new IntPtr(p + 0x1C8)); // 0x1C8 DerivationMethodStrings     ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.FormStringValues                          = GetStringList(new IntPtr(p + 0x1D0)); // 0x1D0 FormStringValues            ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.UseStringValues                           = GetStringList(new IntPtr(p + 0x1D8)); // 0x1D8 UseStringValues             ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.ProcessContentsStringValues               = GetStringList(new IntPtr(p + 0x1E0)); // 0x1E0 ProcessContentsStringValues ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Reader                                    = GetObject<XmlReader>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlReader.FromPointer); // 0x10 Reader                      ( ModelClassType XmlReader XmlReader XmlReader Pointer )
            value.PositionInfo                              = GetObject<PositionInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.PositionInfo.FromPointer); // 0x18 PositionInfo                ( ModelClassType PositionInfo PositionInfo PositionInfo Pointer )
            value.CurrentEntry                              = GetObject<XsdEntry>(new IntPtr(p + 0x020), ReversePrism.DataModels.XsdEntry.FromPointer); // 0x20 CurrentEntry                ( ModelClassType XsdEntry XsdEntry XsdEntry Pointer )
            value.NextEntry                                 = GetObject<XsdEntry>(new IntPtr(p + 0x028), ReversePrism.DataModels.XsdEntry.FromPointer); // 0x28 NextEntry                   ( ModelClassType XsdEntry XsdEntry XsdEntry Pointer )
            value.HasChild                                  = GetBool(new IntPtr(p + 0x030)); // 0x30 HasChild                    ( ModelPrimitiveType bool bool bool Bool )
            value.StateHistory                              = GetObject<HWStack>(new IntPtr(p + 0x038), ReversePrism.DataModels.HWStack.FromPointer); // 0x38 StateHistory                ( ModelClassType HWStack HWStack HWStack Pointer )
            value.ContainerStack                            = GetObject<Stack>(new IntPtr(p + 0x040), ReversePrism.DataModels.Stack.FromPointer); // 0x40 ContainerStack              ( ModelClassType Stack Stack Stack Pointer )
            value.NameTable                                 = GetObject<XmlNameTable>(new IntPtr(p + 0x048), ReversePrism.DataModels.XmlNameTable.FromPointer); // 0x48 NameTable                   ( ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer )
            value.SchemaNames                               = GetObject<SchemaNames>(new IntPtr(p + 0x050), ReversePrism.DataModels.SchemaNames.FromPointer); // 0x50 SchemaNames                 ( ModelClassType SchemaNames SchemaNames SchemaNames Pointer )
            value.NamespaceManager                          = GetObject<XmlNamespaceManager>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlNamespaceManager.FromPointer); // 0x58 NamespaceManager            ( ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer )
            value.CanIncludeImport                          = GetBool(new IntPtr(p + 0x060)); // 0x60 CanIncludeImport            ( ModelPrimitiveType bool bool bool Bool )
            value.Schema                                    = GetObject<XmlSchema>(new IntPtr(p + 0x068), ReversePrism.DataModels.XmlSchema.FromPointer); // 0x68 Schema                      ( ModelClassType XmlSchema XmlSchema XmlSchema Pointer )
            value.Xso                                       = GetObject<XmlSchemaObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.XmlSchemaObject.FromPointer); // 0x70 Xso                         ( ModelClassType XmlSchemaObject XmlSchemaObject XmlSchemaObject Pointer )
            value.Element                                   = GetObject<XmlSchemaElement>(new IntPtr(p + 0x078), ReversePrism.DataModels.XmlSchemaElement.FromPointer); // 0x78 Element                     ( ModelClassType XmlSchemaElement XmlSchemaElement XmlSchemaElement Pointer )
            value.AnyElement                                = GetObject<XmlSchemaAny>(new IntPtr(p + 0x080), ReversePrism.DataModels.XmlSchemaAny.FromPointer); // 0x80 AnyElement                  ( ModelClassType XmlSchemaAny XmlSchemaAny XmlSchemaAny Pointer )
            value.Attribute                                 = GetObject<XmlSchemaAttribute>(new IntPtr(p + 0x088), ReversePrism.DataModels.XmlSchemaAttribute.FromPointer); // 0x88 Attribute                   ( ModelClassType XmlSchemaAttribute XmlSchemaAttribute XmlSchemaAttribute Pointer )
            value.AnyAttribute                              = GetObject<XmlSchemaAnyAttribute>(new IntPtr(p + 0x090), ReversePrism.DataModels.XmlSchemaAnyAttribute.FromPointer); // 0x90 AnyAttribute                ( ModelClassType XmlSchemaAnyAttribute XmlSchemaAnyAttribute XmlSchemaAnyAttribute Pointer )
            value.ComplexType                               = GetObject<XmlSchemaComplexType>(new IntPtr(p + 0x098), ReversePrism.DataModels.XmlSchemaComplexType.FromPointer); // 0x98 ComplexType                 ( ModelClassType XmlSchemaComplexType XmlSchemaComplexType XmlSchemaComplexType Pointer )
            value.SimpleType                                = GetObject<XmlSchemaSimpleType>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.XmlSchemaSimpleType.FromPointer); // 0xA0 SimpleType                  ( ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer )
            value.ComplexContent                            = GetObject<XmlSchemaComplexContent>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.XmlSchemaComplexContent.FromPointer); // 0xA8 ComplexContent              ( ModelClassType XmlSchemaComplexContent XmlSchemaComplexContent XmlSchemaComplexContent Pointer )
            value.ComplexContentExtension                   = GetObject<XmlSchemaComplexContentExtension>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.XmlSchemaComplexContentExtension.FromPointer); // 0xB0 ComplexContentExtension     ( ModelClassType XmlSchemaComplexContentExtension XmlSchemaComplexContentExtension XmlSchemaComplexContentExtension Pointer )
            value.ComplexContentRestriction                 = GetObject<XmlSchemaComplexContentRestriction>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.XmlSchemaComplexContentRestriction.FromPointer); // 0xB8 ComplexContentRestriction   ( ModelClassType XmlSchemaComplexContentRestriction XmlSchemaComplexContentRestriction XmlSchemaComplexContentRestriction Pointer )
            value.SimpleContent                             = GetObject<XmlSchemaSimpleContent>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.XmlSchemaSimpleContent.FromPointer); // 0xC0 SimpleContent               ( ModelClassType XmlSchemaSimpleContent XmlSchemaSimpleContent XmlSchemaSimpleContent Pointer )
            value.SimpleContentExtension                    = GetObject<XmlSchemaSimpleContentExtension>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.XmlSchemaSimpleContentExtension.FromPointer); // 0xC8 SimpleContentExtension      ( ModelClassType XmlSchemaSimpleContentExtension XmlSchemaSimpleContentExtension XmlSchemaSimpleContentExtension Pointer )
            value.SimpleContentRestriction                  = GetObject<XmlSchemaSimpleContentRestriction>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.XmlSchemaSimpleContentRestriction.FromPointer); // 0xD0 SimpleContentRestriction    ( ModelClassType XmlSchemaSimpleContentRestriction XmlSchemaSimpleContentRestriction XmlSchemaSimpleContentRestriction Pointer )
            value.SimpleTypeUnion                           = GetObject<XmlSchemaSimpleTypeUnion>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.XmlSchemaSimpleTypeUnion.FromPointer); // 0xD8 SimpleTypeUnion             ( ModelClassType XmlSchemaSimpleTypeUnion XmlSchemaSimpleTypeUnion XmlSchemaSimpleTypeUnion Pointer )
            value.SimpleTypeList                            = GetObject<XmlSchemaSimpleTypeList>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.XmlSchemaSimpleTypeList.FromPointer); // 0xE0 SimpleTypeList              ( ModelClassType XmlSchemaSimpleTypeList XmlSchemaSimpleTypeList XmlSchemaSimpleTypeList Pointer )
            value.SimpleTypeRestriction                     = GetObject<XmlSchemaSimpleTypeRestriction>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.XmlSchemaSimpleTypeRestriction.FromPointer); // 0xE8 SimpleTypeRestriction       ( ModelClassType XmlSchemaSimpleTypeRestriction XmlSchemaSimpleTypeRestriction XmlSchemaSimpleTypeRestriction Pointer )
            value.Group                                     = GetObject<XmlSchemaGroup>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.XmlSchemaGroup.FromPointer); // 0xF0 Group                       ( ModelClassType XmlSchemaGroup XmlSchemaGroup XmlSchemaGroup Pointer )
            value.GroupRef                                  = GetObject<XmlSchemaGroupRef>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.XmlSchemaGroupRef.FromPointer); // 0xF8 GroupRef                    ( ModelClassType XmlSchemaGroupRef XmlSchemaGroupRef XmlSchemaGroupRef Pointer )
            value.All                                       = GetObject<XmlSchemaAll>(new IntPtr(p + 0x100), ReversePrism.DataModels.XmlSchemaAll.FromPointer); // 0x100 All                         ( ModelClassType XmlSchemaAll XmlSchemaAll XmlSchemaAll Pointer )
            value.Choice                                    = GetObject<XmlSchemaChoice>(new IntPtr(p + 0x108), ReversePrism.DataModels.XmlSchemaChoice.FromPointer); // 0x108 Choice                      ( ModelClassType XmlSchemaChoice XmlSchemaChoice XmlSchemaChoice Pointer )
            value.Sequence                                  = GetObject<XmlSchemaSequence>(new IntPtr(p + 0x110), ReversePrism.DataModels.XmlSchemaSequence.FromPointer); // 0x110 Sequence                    ( ModelClassType XmlSchemaSequence XmlSchemaSequence XmlSchemaSequence Pointer )
            value.Particle                                  = GetObject<XmlSchemaParticle>(new IntPtr(p + 0x118), ReversePrism.DataModels.XmlSchemaParticle.FromPointer); // 0x118 Particle                    ( ModelClassType XmlSchemaParticle XmlSchemaParticle XmlSchemaParticle Pointer )
            value.AttributeGroup                            = GetObject<XmlSchemaAttributeGroup>(new IntPtr(p + 0x120), ReversePrism.DataModels.XmlSchemaAttributeGroup.FromPointer); // 0x120 AttributeGroup              ( ModelClassType XmlSchemaAttributeGroup XmlSchemaAttributeGroup XmlSchemaAttributeGroup Pointer )
            value.AttributeGroupRef                         = GetObject<XmlSchemaAttributeGroupRef>(new IntPtr(p + 0x128), ReversePrism.DataModels.XmlSchemaAttributeGroupRef.FromPointer); // 0x128 AttributeGroupRef           ( ModelClassType XmlSchemaAttributeGroupRef XmlSchemaAttributeGroupRef XmlSchemaAttributeGroupRef Pointer )
            value.Notation                                  = GetObject<XmlSchemaNotation>(new IntPtr(p + 0x130), ReversePrism.DataModels.XmlSchemaNotation.FromPointer); // 0x130 Notation                    ( ModelClassType XmlSchemaNotation XmlSchemaNotation XmlSchemaNotation Pointer )
            value.IdentityConstraint                        = GetObject<XmlSchemaIdentityConstraint>(new IntPtr(p + 0x138), ReversePrism.DataModels.XmlSchemaIdentityConstraint.FromPointer); // 0x138 IdentityConstraint          ( ModelClassType XmlSchemaIdentityConstraint XmlSchemaIdentityConstraint XmlSchemaIdentityConstraint Pointer )
            value.Xpath                                     = GetObject<XmlSchemaXPath>(new IntPtr(p + 0x140), ReversePrism.DataModels.XmlSchemaXPath.FromPointer); // 0x140 Xpath                       ( ModelClassType XmlSchemaXPath XmlSchemaXPath XmlSchemaXPath Pointer )
            value.Include                                   = GetObject<XmlSchemaInclude>(new IntPtr(p + 0x148), ReversePrism.DataModels.XmlSchemaInclude.FromPointer); // 0x148 Include                     ( ModelClassType XmlSchemaInclude XmlSchemaInclude XmlSchemaInclude Pointer )
            value.Import                                    = GetObject<XmlSchemaImport>(new IntPtr(p + 0x150), ReversePrism.DataModels.XmlSchemaImport.FromPointer); // 0x150 Import                      ( ModelClassType XmlSchemaImport XmlSchemaImport XmlSchemaImport Pointer )
            value.Annotation                                = GetObject<XmlSchemaAnnotation>(new IntPtr(p + 0x158), ReversePrism.DataModels.XmlSchemaAnnotation.FromPointer); // 0x158 Annotation                  ( ModelClassType XmlSchemaAnnotation XmlSchemaAnnotation XmlSchemaAnnotation Pointer )
            value.AppInfo                                   = GetObject<XmlSchemaAppInfo>(new IntPtr(p + 0x160), ReversePrism.DataModels.XmlSchemaAppInfo.FromPointer); // 0x160 AppInfo                     ( ModelClassType XmlSchemaAppInfo XmlSchemaAppInfo XmlSchemaAppInfo Pointer )
            value.Documentation                             = GetObject<XmlSchemaDocumentation>(new IntPtr(p + 0x168), ReversePrism.DataModels.XmlSchemaDocumentation.FromPointer); // 0x168 Documentation               ( ModelClassType XmlSchemaDocumentation XmlSchemaDocumentation XmlSchemaDocumentation Pointer )
            value.Facet                                     = GetObject<XmlSchemaFacet>(new IntPtr(p + 0x170), ReversePrism.DataModels.XmlSchemaFacet.FromPointer); // 0x170 Facet                       ( ModelClassType XmlSchemaFacet XmlSchemaFacet XmlSchemaFacet Pointer )
            value.Markup                                    = GetObjectList<XmlNode>(new IntPtr(p + 0x178), ReversePrism.DataModels.XmlNode.FromPointer); // 0x178 Markup                      ( ModelClassListType XmlNode[] XmlNode[] List<XmlNode> Pointer )
            value.Redefine                                  = GetObject<XmlSchemaRedefine>(new IntPtr(p + 0x180), ReversePrism.DataModels.XmlSchemaRedefine.FromPointer); // 0x180 Redefine                    ( ModelClassType XmlSchemaRedefine XmlSchemaRedefine XmlSchemaRedefine Pointer )
            value.ValidationEventHandler                    = GetObject<ValidationEventHandler>(new IntPtr(p + 0x188), ReversePrism.DataModels.ValidationEventHandler.FromPointer); // 0x188 ValidationEventHandler      ( ModelClassType ValidationEventHandler ValidationEventHandler ValidationEventHandler Pointer )
            value.UnhandledAttributes                       = GetObject<ArrayList>(new IntPtr(p + 0x190), ReversePrism.DataModels.ArrayList.FromPointer); // 0x190 UnhandledAttributes         ( ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.Namespaces                                = GetObject<Hashtable>(new IntPtr(p + 0x198), ReversePrism.DataModels.Hashtable.FromPointer); // 0x198 Namespaces                  ( ModelClassType Hashtable Hashtable Hashtable Pointer )

            return value;
        }
    }
}
