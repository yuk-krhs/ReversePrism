using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SchemaSet                                0001865BEE30 ModelClassType XmlSchemaSet XmlSchemaSet XmlSchemaSet Pointer
    // 018 ValidationFlags                          0001865C2980 ModelEnumType XmlSchemaValidationFlags XmlSchemaValidationFlags XmlSchemaValidationFlags Int32
    // 01C StartIDConstraint                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 IsRoot                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 021 RootHasSchema                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 022 AttrValid                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 023 CheckEntity                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 CompiledSchemaInfo                       0001866E9EB0 ModelClassType SchemaInfo SchemaInfo SchemaInfo Pointer
    // 030 DtdSchemaInfo                            00018675AD20 ModelClassType IDtdInfo IDtdInfo IDtdInfo Pointer
    // 038 ValidatedNamespaces                      0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 040 ValidationStack                          0001866A4660 ModelClassType HWStack HWStack HWStack Pointer
    // 048 Context                                  000186766490 ModelClassType ValidationState ValidationState ValidationState Pointer
    // 050 CurrentState                             000186767560 ModelEnumType ValidatorState ValidatorState ValidatorState Int32
    // 058 AttPresence                              0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 060 WildID                                   0001866E6E40 ModelClassType SchemaAttDef SchemaAttDef SchemaAttDef Pointer
    // 068 IDs                                      0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 070 IdRefListHead                            0001866A33C0 ModelClassType IdRefNode IdRefNode IdRefNode Pointer
    // 078 ContextQName                             0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 080 NsXs                                     000186671910 ModelPrimitiveType string string string String
    // 088 NsXsi                                    000186671910 ModelPrimitiveType string string string String
    // 090 NsXmlNs                                  000186671910 ModelPrimitiveType string string string String
    // 098 NsXml                                    000186671910 ModelPrimitiveType string string string String
    // 0A0 PartialValidationType                    0001865BB990 ModelClassType XmlSchemaObject XmlSchemaObject XmlSchemaObject Pointer
    // 0A8 TextValue                                000186676650 ModelClassType StringBuilder StringBuilder StringBuilder Pointer
    // 0B0 EventHandler                             000186765AD0 ModelClassType ValidationEventHandler ValidationEventHandler ValidationEventHandler Pointer
    // 0B8 validationEventSender                    <object> IL2CPP_TYPE_OBJECT
    // 0C0 NameTable                                0001865A0930 ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer
    // 0C8 PositionInfo                             00018669FB60 ModelClassType IXmlLineInfo IXmlLineInfo IXmlLineInfo Pointer
    // 0D0 DummyPositionInfo                        00018669FB60 ModelClassType IXmlLineInfo IXmlLineInfo IXmlLineInfo Pointer
    // 0D8 XmlResolver                              0001865ABBE0 ModelClassType XmlResolver XmlResolver XmlResolver Pointer
    // 0E0 SourceUri                                0001866A4270 ModelClassType Uri Uri Uri Pointer
    // 0E8 SourceUriString                          000186671910 ModelPrimitiveType string string string String
    // 0F0 NsResolver                               0001866A07A0 ModelClassType IXmlNamespaceResolver IXmlNamespaceResolver IXmlNamespaceResolver Pointer
    // 0F8 ProcessContents                          0001865B2700 ModelEnumType XmlSchemaContentProcessing XmlSchemaContentProcessing XmlSchemaContentProcessing Int32
    // 100 XsiTypeString                            000186671910 ModelPrimitiveType string string string String
    // 108 XsiNilString                             000186671910 ModelPrimitiveType string string string String
    // 110 XsiSchemaLocationString                  000186671910 ModelPrimitiveType string string string String
    // 118 XsiNoNamespaceSchemaLocationString       000186671910 ModelPrimitiveType string string string String
    // 000 dtQName                                  XmlSchemaDatatype IL2CPP_TYPE_CLASS
    // 008 dtCDATA                                  XmlSchemaDatatype IL2CPP_TYPE_CLASS
    // 010 DtStringArray                            0001865B3FA0 ModelClassType XmlSchemaDatatype XmlSchemaDatatype XmlSchemaDatatype Pointer
    // 018 EmptyParticleArray                       000185CB47B8 ModelClassListType XmlSchemaParticle[] XmlSchemaParticle[] List<XmlSchemaParticle> Pointer
    // 020 EmptyAttributeArray                      000185CB4468 ModelClassListType XmlSchemaAttribute[] XmlSchemaAttribute[] List<XmlSchemaAttribute> Pointer
    // 120 XmlCharType                              00018658F4B0 ModelEnumType XmlCharType XmlCharType XmlCharType Int32
    // 028 ValidStates                              <Array> IL2CPP_TYPE_ARRAY
    // 030 MethodNames                              000185B81AC0 ModelPrimitiveListType string[] string[] List<string> Pointer
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

            value.SchemaSet                                 = GetObject<XmlSchemaSet>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlSchemaSet.FromPointer); // 0246674985C0 0x10 SchemaSet                   ( 0001865BEE30 ModelClassType XmlSchemaSet XmlSchemaSet XmlSchemaSet Pointer )
            value.ValidationFlags                           = (XmlSchemaValidationFlags)GetInt32(new IntPtr(p + 0x018)); // 0246674985E0 0x18 ValidationFlags             ( 0001865C2980 ModelEnumType XmlSchemaValidationFlags XmlSchemaValidationFlags XmlSchemaValidationFlags Int32 )
            value.StartIDConstraint                         = GetInt32(new IntPtr(p + 0x01C)); // 024667498600 0x1C StartIDConstraint           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsRoot                                    = GetBool(new IntPtr(p + 0x020)); // 024667498620 0x20 IsRoot                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.RootHasSchema                             = GetBool(new IntPtr(p + 0x021)); // 024667498640 0x21 RootHasSchema               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AttrValid                                 = GetBool(new IntPtr(p + 0x022)); // 024667498660 0x22 AttrValid                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CheckEntity                               = GetBool(new IntPtr(p + 0x023)); // 024667498680 0x23 CheckEntity                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CompiledSchemaInfo                        = GetObject<SchemaInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.SchemaInfo.FromPointer); // 0246674986A0 0x28 CompiledSchemaInfo          ( 0001866E9EB0 ModelClassType SchemaInfo SchemaInfo SchemaInfo Pointer )
            value.DtdSchemaInfo                             = GetObject<IDtdInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.IDtdInfo.FromPointer); // 0246674986C0 0x30 DtdSchemaInfo               ( 00018675AD20 ModelClassType IDtdInfo IDtdInfo IDtdInfo Pointer )
            value.ValidatedNamespaces                       = GetObject<Hashtable>(new IntPtr(p + 0x038), ReversePrism.DataModels.Hashtable.FromPointer); // 0246674986E0 0x38 ValidatedNamespaces         ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.ValidationStack                           = GetObject<HWStack>(new IntPtr(p + 0x040), ReversePrism.DataModels.HWStack.FromPointer); // 024667498700 0x40 ValidationStack             ( 0001866A4660 ModelClassType HWStack HWStack HWStack Pointer )
            value.Context                                   = GetObject<ValidationState>(new IntPtr(p + 0x048), ReversePrism.DataModels.ValidationState.FromPointer); // 024667498720 0x48 Context                     ( 000186766490 ModelClassType ValidationState ValidationState ValidationState Pointer )
            value.CurrentState                              = (ValidatorState)GetInt32(new IntPtr(p + 0x050)); // 024667498740 0x50 CurrentState                ( 000186767560 ModelEnumType ValidatorState ValidatorState ValidatorState Int32 )
            value.AttPresence                               = GetObject<Hashtable>(new IntPtr(p + 0x058), ReversePrism.DataModels.Hashtable.FromPointer); // 024667498760 0x58 AttPresence                 ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.WildID                                    = GetObject<SchemaAttDef>(new IntPtr(p + 0x060), ReversePrism.DataModels.SchemaAttDef.FromPointer); // 024667498780 0x60 WildID                      ( 0001866E6E40 ModelClassType SchemaAttDef SchemaAttDef SchemaAttDef Pointer )
            value.IDs                                       = GetObject<Hashtable>(new IntPtr(p + 0x068), ReversePrism.DataModels.Hashtable.FromPointer); // 0246674987A0 0x68 IDs                         ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.IdRefListHead                             = GetObject<IdRefNode>(new IntPtr(p + 0x070), ReversePrism.DataModels.IdRefNode.FromPointer); // 0246674987C0 0x70 IdRefListHead               ( 0001866A33C0 ModelClassType IdRefNode IdRefNode IdRefNode Pointer )
            value.ContextQName                              = GetObject<XmlQualifiedName>(new IntPtr(p + 0x078), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0246674987E0 0x78 ContextQName                ( 0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.NsXs                                      = GetString(new IntPtr(p + 0x080)); // 024667498800 0x80 NsXs                        ( 000186671910 ModelPrimitiveType string string string String )
            value.NsXsi                                     = GetString(new IntPtr(p + 0x088)); // 024667498820 0x88 NsXsi                       ( 000186671910 ModelPrimitiveType string string string String )
            value.NsXmlNs                                   = GetString(new IntPtr(p + 0x090)); // 024667498840 0x90 NsXmlNs                     ( 000186671910 ModelPrimitiveType string string string String )
            value.NsXml                                     = GetString(new IntPtr(p + 0x098)); // 024667498860 0x98 NsXml                       ( 000186671910 ModelPrimitiveType string string string String )
            value.PartialValidationType                     = GetObject<XmlSchemaObject>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.XmlSchemaObject.FromPointer); // 024667498880 0xA0 PartialValidationType       ( 0001865BB990 ModelClassType XmlSchemaObject XmlSchemaObject XmlSchemaObject Pointer )
            value.TextValue                                 = GetObject<StringBuilder>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.StringBuilder.FromPointer); // 0246674988A0 0xA8 TextValue                   ( 000186676650 ModelClassType StringBuilder StringBuilder StringBuilder Pointer )
            value.EventHandler                              = GetObject<ValidationEventHandler>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.ValidationEventHandler.FromPointer); // 0246674988C0 0xB0 EventHandler                ( 000186765AD0 ModelClassType ValidationEventHandler ValidationEventHandler ValidationEventHandler Pointer )
            value.NameTable                                 = GetObject<XmlNameTable>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.XmlNameTable.FromPointer); // 024667498900 0xC0 NameTable                   ( 0001865A0930 ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer )
            value.PositionInfo                              = GetObject<IXmlLineInfo>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.IXmlLineInfo.FromPointer); // 024667498920 0xC8 PositionInfo                ( 00018669FB60 ModelClassType IXmlLineInfo IXmlLineInfo IXmlLineInfo Pointer )
            value.DummyPositionInfo                         = GetObject<IXmlLineInfo>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.IXmlLineInfo.FromPointer); // 024667498940 0xD0 DummyPositionInfo           ( 00018669FB60 ModelClassType IXmlLineInfo IXmlLineInfo IXmlLineInfo Pointer )
            value.XmlResolver                               = GetObject<XmlResolver>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.XmlResolver.FromPointer); // 024667498960 0xD8 XmlResolver                 ( 0001865ABBE0 ModelClassType XmlResolver XmlResolver XmlResolver Pointer )
            value.SourceUri                                 = GetObject<Uri>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.Uri.FromPointer); // 024667498980 0xE0 SourceUri                   ( 0001866A4270 ModelClassType Uri Uri Uri Pointer )
            value.SourceUriString                           = GetString(new IntPtr(p + 0x0E8)); // 0246674989A0 0xE8 SourceUriString             ( 000186671910 ModelPrimitiveType string string string String )
            value.NsResolver                                = GetObject<IXmlNamespaceResolver>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.IXmlNamespaceResolver.FromPointer); // 0246674989C0 0xF0 NsResolver                  ( 0001866A07A0 ModelClassType IXmlNamespaceResolver IXmlNamespaceResolver IXmlNamespaceResolver Pointer )
            value.ProcessContents                           = (XmlSchemaContentProcessing)GetInt32(new IntPtr(p + 0x0F8)); // 0246674989E0 0xF8 ProcessContents             ( 0001865B2700 ModelEnumType XmlSchemaContentProcessing XmlSchemaContentProcessing XmlSchemaContentProcessing Int32 )
            value.XsiTypeString                             = GetString(new IntPtr(p + 0x100)); // 024667498A00 0x100 XsiTypeString               ( 000186671910 ModelPrimitiveType string string string String )
            value.XsiNilString                              = GetString(new IntPtr(p + 0x108)); // 024667498A20 0x108 XsiNilString                ( 000186671910 ModelPrimitiveType string string string String )
            value.XsiSchemaLocationString                   = GetString(new IntPtr(p + 0x110)); // 024667498A40 0x110 XsiSchemaLocationString     ( 000186671910 ModelPrimitiveType string string string String )
            value.XsiNoNamespaceSchemaLocationString        = GetString(new IntPtr(p + 0x118)); // 024667498A60 0x118 XsiNoNamespaceSchemaLocationString ( 000186671910 ModelPrimitiveType string string string String )
            value.DtStringArray                             = GetObject<XmlSchemaDatatype>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlSchemaDatatype.FromPointer); // 024667498AC0 0x10 DtStringArray               ( 0001865B3FA0 ModelClassType XmlSchemaDatatype XmlSchemaDatatype XmlSchemaDatatype Pointer )
            value.EmptyParticleArray                        = GetObjectList<XmlSchemaParticle>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlSchemaParticle.FromPointer); // 024667498AE0 0x18 EmptyParticleArray          ( 000185CB47B8 ModelClassListType XmlSchemaParticle[] XmlSchemaParticle[] List<XmlSchemaParticle> Pointer )
            value.EmptyAttributeArray                       = GetObjectList<XmlSchemaAttribute>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlSchemaAttribute.FromPointer); // 024667498B00 0x20 EmptyAttributeArray         ( 000185CB4468 ModelClassListType XmlSchemaAttribute[] XmlSchemaAttribute[] List<XmlSchemaAttribute> Pointer )
            value.XmlCharType                               = (XmlCharType)GetInt32(new IntPtr(p + 0x120)); // 024667498B20 0x120 XmlCharType                 ( 00018658F4B0 ModelEnumType XmlCharType XmlCharType XmlCharType Int32 )
            value.MethodNames                               = GetStringList(new IntPtr(p + 0x030)); // 024667498B60 0x30 MethodNames                 ( 000185B81AC0 ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
