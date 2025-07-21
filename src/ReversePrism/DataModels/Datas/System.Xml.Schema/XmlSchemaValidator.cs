using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SchemaSet                                ModelClassType XmlSchemaSet XmlSchemaSet XmlSchemaSet Pointer
    // 018 ValidationFlags                          ModelEnumType XmlSchemaValidationFlags XmlSchemaValidationFlags XmlSchemaValidationFlags Int32
    // 01C StartIDConstraint                        ModelPrimitiveType int int int Int32
    // 020 IsRoot                                   ModelPrimitiveType bool bool bool Bool
    // 021 RootHasSchema                            ModelPrimitiveType bool bool bool Bool
    // 022 AttrValid                                ModelPrimitiveType bool bool bool Bool
    // 023 CheckEntity                              ModelPrimitiveType bool bool bool Bool
    // 028 CompiledSchemaInfo                       ModelClassType SchemaInfo SchemaInfo SchemaInfo Pointer
    // 030 DtdSchemaInfo                            ModelClassType IDtdInfo IDtdInfo IDtdInfo Pointer
    // 038 ValidatedNamespaces                      ModelClassType Hashtable Hashtable Hashtable Pointer
    // 040 ValidationStack                          ModelClassType HWStack HWStack HWStack Pointer
    // 048 Context                                  ModelClassType ValidationState ValidationState ValidationState Pointer
    // 050 CurrentState                             ModelEnumType ValidatorState ValidatorState ValidatorState Int32
    // 058 AttPresence                              ModelClassType Hashtable Hashtable Hashtable Pointer
    // 060 WildID                                   ModelClassType SchemaAttDef SchemaAttDef SchemaAttDef Pointer
    // 068 IDs                                      ModelClassType Hashtable Hashtable Hashtable Pointer
    // 070 IdRefListHead                            ModelClassType IdRefNode IdRefNode IdRefNode Pointer
    // 078 ContextQName                             ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 080 NsXs                                     ModelPrimitiveType string string string String
    // 088 NsXsi                                    ModelPrimitiveType string string string String
    // 090 NsXmlNs                                  ModelPrimitiveType string string string String
    // 098 NsXml                                    ModelPrimitiveType string string string String
    // 0A0 PartialValidationType                    ModelClassType XmlSchemaObject XmlSchemaObject XmlSchemaObject Pointer
    // 0A8 TextValue                                ModelClassType StringBuilder StringBuilder StringBuilder Pointer
    // 0B0 EventHandler                             ModelClassType ValidationEventHandler ValidationEventHandler ValidationEventHandler Pointer
    // 0B8 validationEventSender                    <object> IL2CPP_TYPE_OBJECT
    // 0C0 NameTable                                ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer
    // 0C8 PositionInfo                             ModelClassType IXmlLineInfo IXmlLineInfo IXmlLineInfo Pointer
    // 0D0 DummyPositionInfo                        ModelClassType IXmlLineInfo IXmlLineInfo IXmlLineInfo Pointer
    // 0D8 XmlResolver                              ModelClassType XmlResolver XmlResolver XmlResolver Pointer
    // 0E0 SourceUri                                ModelClassType Uri Uri Uri Pointer
    // 0E8 SourceUriString                          ModelPrimitiveType string string string String
    // 0F0 NsResolver                               ModelClassType IXmlNamespaceResolver IXmlNamespaceResolver IXmlNamespaceResolver Pointer
    // 0F8 ProcessContents                          ModelEnumType XmlSchemaContentProcessing XmlSchemaContentProcessing XmlSchemaContentProcessing Int32
    // 100 XsiTypeString                            ModelPrimitiveType string string string String
    // 108 XsiNilString                             ModelPrimitiveType string string string String
    // 110 XsiSchemaLocationString                  ModelPrimitiveType string string string String
    // 118 XsiNoNamespaceSchemaLocationString       ModelPrimitiveType string string string String
    // 000 dtQName                                  XmlSchemaDatatype IL2CPP_TYPE_CLASS
    // 008 dtCDATA                                  XmlSchemaDatatype IL2CPP_TYPE_CLASS
    // 010 DtStringArray                            ModelClassType XmlSchemaDatatype XmlSchemaDatatype XmlSchemaDatatype Pointer
    // 018 EmptyParticleArray                       ModelClassListType XmlSchemaParticle[] XmlSchemaParticle[] List<XmlSchemaParticle> Pointer
    // 020 EmptyAttributeArray                      ModelClassListType XmlSchemaAttribute[] XmlSchemaAttribute[] List<XmlSchemaAttribute> Pointer
    // 120 XmlCharType                              ModelEnumType XmlCharType XmlCharType XmlCharType Int32
    // 028 ValidStates                              <Array> IL2CPP_TYPE_ARRAY
    // 030 MethodNames                              ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class XmlSchemaValidator : DataModel
    {
        public XmlSchemaSet?                            SchemaSet                               { get; set; }
        public XmlSchemaValidationFlags                 ValidationFlags                         { get; set; }
        public int                                      StartIDConstraint                       { get; set; }
        public bool                                     IsRoot                                  { get; set; }
        public bool                                     RootHasSchema                           { get; set; }
        public bool                                     AttrValid                               { get; set; }
        public bool                                     CheckEntity                             { get; set; }
        public SchemaInfo?                              CompiledSchemaInfo                      { get; set; }
        public IDtdInfo?                                DtdSchemaInfo                           { get; set; }
        public Hashtable?                               ValidatedNamespaces                     { get; set; }
        public HWStack?                                 ValidationStack                         { get; set; }
        public ValidationState?                         Context                                 { get; set; }
        public ValidatorState                           CurrentState                            { get; set; }
        public Hashtable?                               AttPresence                             { get; set; }
        public SchemaAttDef?                            WildID                                  { get; set; }
        public Hashtable?                               IDs                                     { get; set; }
        public IdRefNode?                               IdRefListHead                           { get; set; }
        public XmlQualifiedName?                        ContextQName                            { get; set; }
        public string                                   NsXs                                    { get; set; }
        public string                                   NsXsi                                   { get; set; }
        public string                                   NsXmlNs                                 { get; set; }
        public string                                   NsXml                                   { get; set; }
        public XmlSchemaObject?                         PartialValidationType                   { get; set; }
        public StringBuilder?                           TextValue                               { get; set; }
        public ValidationEventHandler?                  EventHandler                            { get; set; }
        public XmlNameTable?                            NameTable                               { get; set; }
        public IXmlLineInfo?                            PositionInfo                            { get; set; }
        public IXmlLineInfo?                            DummyPositionInfo                       { get; set; }
        public XmlResolver?                             XmlResolver                             { get; set; }
        public Uri?                                     SourceUri                               { get; set; }
        public string                                   SourceUriString                         { get; set; }
        public IXmlNamespaceResolver?                   NsResolver                              { get; set; }
        public XmlSchemaContentProcessing               ProcessContents                         { get; set; }
        public string                                   XsiTypeString                           { get; set; }
        public string                                   XsiNilString                            { get; set; }
        public string                                   XsiSchemaLocationString                 { get; set; }
        public string                                   XsiNoNamespaceSchemaLocationString      { get; set; }
        public XmlSchemaDatatype?                       DtStringArray                           { get; set; }
        public List<XmlSchemaParticle>?                 EmptyParticleArray                      { get; set; }
        public List<XmlSchemaAttribute>?                EmptyAttributeArray                     { get; set; }
        public XmlCharType                              XmlCharType                             { get; set; }
        public List<string>?                            MethodNames                             { get; set; }

        public static XmlSchemaValidator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaValidator() { Pointer= p0 };

            value.SchemaSet                                 = GetObject<XmlSchemaSet>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlSchemaSet.FromPointer); // 0x10 SchemaSet                   ( ModelClassType XmlSchemaSet XmlSchemaSet XmlSchemaSet Pointer )
            value.ValidationFlags                           = (XmlSchemaValidationFlags)GetInt32(new IntPtr(p + 0x018)); // 0x18 ValidationFlags             ( ModelEnumType XmlSchemaValidationFlags XmlSchemaValidationFlags XmlSchemaValidationFlags Int32 )
            value.StartIDConstraint                         = GetInt32(new IntPtr(p + 0x01C)); // 0x1C StartIDConstraint           ( ModelPrimitiveType int int int Int32 )
            value.IsRoot                                    = GetBool(new IntPtr(p + 0x020)); // 0x20 IsRoot                      ( ModelPrimitiveType bool bool bool Bool )
            value.RootHasSchema                             = GetBool(new IntPtr(p + 0x021)); // 0x21 RootHasSchema               ( ModelPrimitiveType bool bool bool Bool )
            value.AttrValid                                 = GetBool(new IntPtr(p + 0x022)); // 0x22 AttrValid                   ( ModelPrimitiveType bool bool bool Bool )
            value.CheckEntity                               = GetBool(new IntPtr(p + 0x023)); // 0x23 CheckEntity                 ( ModelPrimitiveType bool bool bool Bool )
            value.CompiledSchemaInfo                        = GetObject<SchemaInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.SchemaInfo.FromPointer); // 0x28 CompiledSchemaInfo          ( ModelClassType SchemaInfo SchemaInfo SchemaInfo Pointer )
            value.DtdSchemaInfo                             = GetObject<IDtdInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.IDtdInfo.FromPointer); // 0x30 DtdSchemaInfo               ( ModelClassType IDtdInfo IDtdInfo IDtdInfo Pointer )
            value.ValidatedNamespaces                       = GetObject<Hashtable>(new IntPtr(p + 0x038), ReversePrism.DataModels.Hashtable.FromPointer); // 0x38 ValidatedNamespaces         ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.ValidationStack                           = GetObject<HWStack>(new IntPtr(p + 0x040), ReversePrism.DataModels.HWStack.FromPointer); // 0x40 ValidationStack             ( ModelClassType HWStack HWStack HWStack Pointer )
            value.Context                                   = GetObject<ValidationState>(new IntPtr(p + 0x048), ReversePrism.DataModels.ValidationState.FromPointer); // 0x48 Context                     ( ModelClassType ValidationState ValidationState ValidationState Pointer )
            value.CurrentState                              = (ValidatorState)GetInt32(new IntPtr(p + 0x050)); // 0x50 CurrentState                ( ModelEnumType ValidatorState ValidatorState ValidatorState Int32 )
            value.AttPresence                               = GetObject<Hashtable>(new IntPtr(p + 0x058), ReversePrism.DataModels.Hashtable.FromPointer); // 0x58 AttPresence                 ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.WildID                                    = GetObject<SchemaAttDef>(new IntPtr(p + 0x060), ReversePrism.DataModels.SchemaAttDef.FromPointer); // 0x60 WildID                      ( ModelClassType SchemaAttDef SchemaAttDef SchemaAttDef Pointer )
            value.IDs                                       = GetObject<Hashtable>(new IntPtr(p + 0x068), ReversePrism.DataModels.Hashtable.FromPointer); // 0x68 IDs                         ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.IdRefListHead                             = GetObject<IdRefNode>(new IntPtr(p + 0x070), ReversePrism.DataModels.IdRefNode.FromPointer); // 0x70 IdRefListHead               ( ModelClassType IdRefNode IdRefNode IdRefNode Pointer )
            value.ContextQName                              = GetObject<XmlQualifiedName>(new IntPtr(p + 0x078), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x78 ContextQName                ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.NsXs                                      = GetString(new IntPtr(p + 0x080)); // 0x80 NsXs                        ( ModelPrimitiveType string string string String )
            value.NsXsi                                     = GetString(new IntPtr(p + 0x088)); // 0x88 NsXsi                       ( ModelPrimitiveType string string string String )
            value.NsXmlNs                                   = GetString(new IntPtr(p + 0x090)); // 0x90 NsXmlNs                     ( ModelPrimitiveType string string string String )
            value.NsXml                                     = GetString(new IntPtr(p + 0x098)); // 0x98 NsXml                       ( ModelPrimitiveType string string string String )
            value.PartialValidationType                     = GetObject<XmlSchemaObject>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.XmlSchemaObject.FromPointer); // 0xA0 PartialValidationType       ( ModelClassType XmlSchemaObject XmlSchemaObject XmlSchemaObject Pointer )
            value.TextValue                                 = GetObject<StringBuilder>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.StringBuilder.FromPointer); // 0xA8 TextValue                   ( ModelClassType StringBuilder StringBuilder StringBuilder Pointer )
            value.EventHandler                              = GetObject<ValidationEventHandler>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.ValidationEventHandler.FromPointer); // 0xB0 EventHandler                ( ModelClassType ValidationEventHandler ValidationEventHandler ValidationEventHandler Pointer )
            value.NameTable                                 = GetObject<XmlNameTable>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.XmlNameTable.FromPointer); // 0xC0 NameTable                   ( ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer )
            value.PositionInfo                              = GetObject<IXmlLineInfo>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.IXmlLineInfo.FromPointer); // 0xC8 PositionInfo                ( ModelClassType IXmlLineInfo IXmlLineInfo IXmlLineInfo Pointer )
            value.DummyPositionInfo                         = GetObject<IXmlLineInfo>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.IXmlLineInfo.FromPointer); // 0xD0 DummyPositionInfo           ( ModelClassType IXmlLineInfo IXmlLineInfo IXmlLineInfo Pointer )
            value.XmlResolver                               = GetObject<XmlResolver>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.XmlResolver.FromPointer); // 0xD8 XmlResolver                 ( ModelClassType XmlResolver XmlResolver XmlResolver Pointer )
            value.SourceUri                                 = GetObject<Uri>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.Uri.FromPointer); // 0xE0 SourceUri                   ( ModelClassType Uri Uri Uri Pointer )
            value.SourceUriString                           = GetString(new IntPtr(p + 0x0E8)); // 0xE8 SourceUriString             ( ModelPrimitiveType string string string String )
            value.NsResolver                                = GetObject<IXmlNamespaceResolver>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.IXmlNamespaceResolver.FromPointer); // 0xF0 NsResolver                  ( ModelClassType IXmlNamespaceResolver IXmlNamespaceResolver IXmlNamespaceResolver Pointer )
            value.ProcessContents                           = (XmlSchemaContentProcessing)GetInt32(new IntPtr(p + 0x0F8)); // 0xF8 ProcessContents             ( ModelEnumType XmlSchemaContentProcessing XmlSchemaContentProcessing XmlSchemaContentProcessing Int32 )
            value.XsiTypeString                             = GetString(new IntPtr(p + 0x100)); // 0x100 XsiTypeString               ( ModelPrimitiveType string string string String )
            value.XsiNilString                              = GetString(new IntPtr(p + 0x108)); // 0x108 XsiNilString                ( ModelPrimitiveType string string string String )
            value.XsiSchemaLocationString                   = GetString(new IntPtr(p + 0x110)); // 0x110 XsiSchemaLocationString     ( ModelPrimitiveType string string string String )
            value.XsiNoNamespaceSchemaLocationString        = GetString(new IntPtr(p + 0x118)); // 0x118 XsiNoNamespaceSchemaLocationString ( ModelPrimitiveType string string string String )
            value.DtStringArray                             = GetObject<XmlSchemaDatatype>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlSchemaDatatype.FromPointer); // 0x10 DtStringArray               ( ModelClassType XmlSchemaDatatype XmlSchemaDatatype XmlSchemaDatatype Pointer )
            value.EmptyParticleArray                        = GetObjectList<XmlSchemaParticle>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlSchemaParticle.FromPointer); // 0x18 EmptyParticleArray          ( ModelClassListType XmlSchemaParticle[] XmlSchemaParticle[] List<XmlSchemaParticle> Pointer )
            value.EmptyAttributeArray                       = GetObjectList<XmlSchemaAttribute>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlSchemaAttribute.FromPointer); // 0x20 EmptyAttributeArray         ( ModelClassListType XmlSchemaAttribute[] XmlSchemaAttribute[] List<XmlSchemaAttribute> Pointer )
            value.XmlCharType                               = (XmlCharType)GetInt32(new IntPtr(p + 0x120)); // 0x120 XmlCharType                 ( ModelEnumType XmlCharType XmlCharType XmlCharType Int32 )
            value.MethodNames                               = GetStringList(new IntPtr(p + 0x030)); // 0x30 MethodNames                 ( ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
