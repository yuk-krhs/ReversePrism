using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Implementation                           00018659D910 ModelClassType XmlImplementation XmlImplementation XmlImplementation Pointer
    // 020 DomNameTable                             0001866EAD00 ModelClassType DomNameTable DomNameTable DomNameTable Pointer
    // 028 LastChild                                00018659E450 ModelClassType XmlLinkedNode XmlLinkedNode XmlLinkedNode Pointer
    // 030 Entities                                 0001865A0E30 ModelClassType XmlNamedNodeMap XmlNamedNodeMap XmlNamedNodeMap Pointer
    // 038 HtElementIdMap                           0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 040 HtElementIDAttrDecl                      0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 048 SchemaInfo                               0001866E9EB0 ModelClassType SchemaInfo SchemaInfo SchemaInfo Pointer
    // 050 Schemas                                  0001865BEE30 ModelClassType XmlSchemaSet XmlSchemaSet XmlSchemaSet Pointer
    // 058 ReportValidity                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 059 ActualLoadingStatus                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 060 OnNodeInsertingDelegate                  0001865A23D0 ModelClassType XmlNodeChangedEventHandler XmlNodeChangedEventHandler XmlNodeChangedEventHandler Pointer
    // 068 OnNodeInsertedDelegate                   0001865A23D0 ModelClassType XmlNodeChangedEventHandler XmlNodeChangedEventHandler XmlNodeChangedEventHandler Pointer
    // 070 OnNodeRemovingDelegate                   0001865A23D0 ModelClassType XmlNodeChangedEventHandler XmlNodeChangedEventHandler XmlNodeChangedEventHandler Pointer
    // 078 OnNodeRemovedDelegate                    0001865A23D0 ModelClassType XmlNodeChangedEventHandler XmlNodeChangedEventHandler XmlNodeChangedEventHandler Pointer
    // 080 OnNodeChangingDelegate                   0001865A23D0 ModelClassType XmlNodeChangedEventHandler XmlNodeChangedEventHandler XmlNodeChangedEventHandler Pointer
    // 088 OnNodeChangedDelegate                    0001865A23D0 ModelClassType XmlNodeChangedEventHandler XmlNodeChangedEventHandler XmlNodeChangedEventHandler Pointer
    // 090 FEntRefNodesPresent                      000186595210 ModelPrimitiveType bool bool bool Bool
    // 091 FCDataNodesPresent                       000186595210 ModelPrimitiveType bool bool bool Bool
    // 092 PreserveWhitespace                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 093 IsLoading                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 098 StrDocumentName                          000186671BA0 ModelPrimitiveType string string string String
    // 0A0 StrDocumentFragmentName                  000186671BA0 ModelPrimitiveType string string string String
    // 0A8 StrCommentName                           000186671BA0 ModelPrimitiveType string string string String
    // 0B0 StrTextName                              000186671BA0 ModelPrimitiveType string string string String
    // 0B8 StrCDataSectionName                      000186671BA0 ModelPrimitiveType string string string String
    // 0C0 StrEntityName                            000186671BA0 ModelPrimitiveType string string string String
    // 0C8 StrID                                    000186671BA0 ModelPrimitiveType string string string String
    // 0D0 StrXmlns                                 000186671BA0 ModelPrimitiveType string string string String
    // 0D8 StrXml                                   000186671BA0 ModelPrimitiveType string string string String
    // 0E0 StrSpace                                 000186671BA0 ModelPrimitiveType string string string String
    // 0E8 StrLang                                  000186671BA0 ModelPrimitiveType string string string String
    // 0F0 StrEmpty                                 000186671BA0 ModelPrimitiveType string string string String
    // 0F8 StrNonSignificantWhitespaceName          000186671BA0 ModelPrimitiveType string string string String
    // 100 StrSignificantWhitespaceName             000186671BA0 ModelPrimitiveType string string string String
    // 108 StrReservedXmlns                         000186671BA0 ModelPrimitiveType string string string String
    // 110 StrReservedXml                           000186671BA0 ModelPrimitiveType string string string String
    // 118 BaseURI                                  000186671BA0 ModelPrimitiveType string string string String
    // 120 Resolver                                 0001865ABBE0 ModelClassType XmlResolver XmlResolver XmlResolver Pointer
    // 128 BSetResolver                             000186595210 ModelPrimitiveType bool bool bool Bool
    // 130 objLock                                  <object> IL2CPP_TYPE_OBJECT
    // 138 NamespaceXml                             000186589BC0 ModelClassType XmlAttribute XmlAttribute XmlAttribute Pointer
    // 000 EmptyEnumerator                          EmptyEnumerator IL2CPP_TYPE_CLASS
    // 008 NotKnownSchemaInfo                       IXmlSchemaInfo IL2CPP_TYPE_CLASS
    // 010 ValidSchemaInfo                          0001866A13F0 ModelClassType IXmlSchemaInfo IXmlSchemaInfo IXmlSchemaInfo Pointer
    // 018 InvalidSchemaInfo                        0001866A13F0 ModelClassType IXmlSchemaInfo IXmlSchemaInfo IXmlSchemaInfo Pointer
    public partial class XmlDocument
    {
        public XmlImplementation?                       Implementation                          { get; set; }
        public DomNameTable?                            DomNameTable                            { get; set; }
        public XmlLinkedNode?                           LastChild                               { get; set; }
        public XmlNamedNodeMap?                         Entities                                { get; set; }
        public Hashtable?                               HtElementIdMap                          { get; set; }
        public Hashtable?                               HtElementIDAttrDecl                     { get; set; }
        public SchemaInfo?                              SchemaInfo                              { get; set; }
        public XmlSchemaSet?                            Schemas                                 { get; set; }
        public bool                                     ReportValidity                          { get; set; }
        public bool                                     ActualLoadingStatus                     { get; set; }
        public XmlNodeChangedEventHandler?              OnNodeInsertingDelegate                 { get; set; }
        public XmlNodeChangedEventHandler?              OnNodeInsertedDelegate                  { get; set; }
        public XmlNodeChangedEventHandler?              OnNodeRemovingDelegate                  { get; set; }
        public XmlNodeChangedEventHandler?              OnNodeRemovedDelegate                   { get; set; }
        public XmlNodeChangedEventHandler?              OnNodeChangingDelegate                  { get; set; }
        public XmlNodeChangedEventHandler?              OnNodeChangedDelegate                   { get; set; }
        public bool                                     FEntRefNodesPresent                     { get; set; }
        public bool                                     FCDataNodesPresent                      { get; set; }
        public bool                                     PreserveWhitespace                      { get; set; }
        public bool                                     IsLoading                               { get; set; }
        public string                                   StrDocumentName                         { get; set; }
        public string                                   StrDocumentFragmentName                 { get; set; }
        public string                                   StrCommentName                          { get; set; }
        public string                                   StrTextName                             { get; set; }
        public string                                   StrCDataSectionName                     { get; set; }
        public string                                   StrEntityName                           { get; set; }
        public string                                   StrID                                   { get; set; }
        public string                                   StrXmlns                                { get; set; }
        public string                                   StrXml                                  { get; set; }
        public string                                   StrSpace                                { get; set; }
        public string                                   StrLang                                 { get; set; }
        public string                                   StrEmpty                                { get; set; }
        public string                                   StrNonSignificantWhitespaceName         { get; set; }
        public string                                   StrSignificantWhitespaceName            { get; set; }
        public string                                   StrReservedXmlns                        { get; set; }
        public string                                   StrReservedXml                          { get; set; }
        public string                                   BaseURI                                 { get; set; }
        public XmlResolver?                             Resolver                                { get; set; }
        public bool                                     BSetResolver                            { get; set; }
        public XmlAttribute?                            NamespaceXml                            { get; set; }
        public IXmlSchemaInfo?                          ValidSchemaInfo                         { get; set; }
        public IXmlSchemaInfo?                          InvalidSchemaInfo                       { get; set; }

        public static XmlDocument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlDocument();

            value.Implementation                            = GetObject<XmlImplementation>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlImplementation.FromPointer); // 0270D743C130 0x18 Implementation              ( 00018659D910 ModelClassType XmlImplementation XmlImplementation XmlImplementation Pointer )
            value.DomNameTable                              = GetObject<DomNameTable>(new IntPtr(p + 0x020), ReversePrism.DataModels.DomNameTable.FromPointer); // 0270D743C150 0x20 DomNameTable                ( 0001866EAD00 ModelClassType DomNameTable DomNameTable DomNameTable Pointer )
            value.LastChild                                 = GetObject<XmlLinkedNode>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlLinkedNode.FromPointer); // 0270D743C170 0x28 LastChild                   ( 00018659E450 ModelClassType XmlLinkedNode XmlLinkedNode XmlLinkedNode Pointer )
            value.Entities                                  = GetObject<XmlNamedNodeMap>(new IntPtr(p + 0x030), ReversePrism.DataModels.XmlNamedNodeMap.FromPointer); // 0270D743C190 0x30 Entities                    ( 0001865A0E30 ModelClassType XmlNamedNodeMap XmlNamedNodeMap XmlNamedNodeMap Pointer )
            value.HtElementIdMap                            = GetObject<Hashtable>(new IntPtr(p + 0x038), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D743C1B0 0x38 HtElementIdMap              ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.HtElementIDAttrDecl                       = GetObject<Hashtable>(new IntPtr(p + 0x040), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D743C1D0 0x40 HtElementIDAttrDecl         ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.SchemaInfo                                = GetObject<SchemaInfo>(new IntPtr(p + 0x048), ReversePrism.DataModels.SchemaInfo.FromPointer); // 0270D743C1F0 0x48 SchemaInfo                  ( 0001866E9EB0 ModelClassType SchemaInfo SchemaInfo SchemaInfo Pointer )
            value.Schemas                                   = GetObject<XmlSchemaSet>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlSchemaSet.FromPointer); // 0270D743C210 0x50 Schemas                     ( 0001865BEE30 ModelClassType XmlSchemaSet XmlSchemaSet XmlSchemaSet Pointer )
            value.ReportValidity                            = GetBool(new IntPtr(p + 0x058)); // 0270D743C230 0x58 ReportValidity              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ActualLoadingStatus                       = GetBool(new IntPtr(p + 0x059)); // 0270D743C250 0x59 ActualLoadingStatus         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.OnNodeInsertingDelegate                   = GetObject<XmlNodeChangedEventHandler>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlNodeChangedEventHandler.FromPointer); // 0270D743C270 0x60 OnNodeInsertingDelegate     ( 0001865A23D0 ModelClassType XmlNodeChangedEventHandler XmlNodeChangedEventHandler XmlNodeChangedEventHandler Pointer )
            value.OnNodeInsertedDelegate                    = GetObject<XmlNodeChangedEventHandler>(new IntPtr(p + 0x068), ReversePrism.DataModels.XmlNodeChangedEventHandler.FromPointer); // 0270D743C290 0x68 OnNodeInsertedDelegate      ( 0001865A23D0 ModelClassType XmlNodeChangedEventHandler XmlNodeChangedEventHandler XmlNodeChangedEventHandler Pointer )
            value.OnNodeRemovingDelegate                    = GetObject<XmlNodeChangedEventHandler>(new IntPtr(p + 0x070), ReversePrism.DataModels.XmlNodeChangedEventHandler.FromPointer); // 0270D743C2B0 0x70 OnNodeRemovingDelegate      ( 0001865A23D0 ModelClassType XmlNodeChangedEventHandler XmlNodeChangedEventHandler XmlNodeChangedEventHandler Pointer )
            value.OnNodeRemovedDelegate                     = GetObject<XmlNodeChangedEventHandler>(new IntPtr(p + 0x078), ReversePrism.DataModels.XmlNodeChangedEventHandler.FromPointer); // 0270D743C2D0 0x78 OnNodeRemovedDelegate       ( 0001865A23D0 ModelClassType XmlNodeChangedEventHandler XmlNodeChangedEventHandler XmlNodeChangedEventHandler Pointer )
            value.OnNodeChangingDelegate                    = GetObject<XmlNodeChangedEventHandler>(new IntPtr(p + 0x080), ReversePrism.DataModels.XmlNodeChangedEventHandler.FromPointer); // 0270D743C2F0 0x80 OnNodeChangingDelegate      ( 0001865A23D0 ModelClassType XmlNodeChangedEventHandler XmlNodeChangedEventHandler XmlNodeChangedEventHandler Pointer )
            value.OnNodeChangedDelegate                     = GetObject<XmlNodeChangedEventHandler>(new IntPtr(p + 0x088), ReversePrism.DataModels.XmlNodeChangedEventHandler.FromPointer); // 0270D743C310 0x88 OnNodeChangedDelegate       ( 0001865A23D0 ModelClassType XmlNodeChangedEventHandler XmlNodeChangedEventHandler XmlNodeChangedEventHandler Pointer )
            value.FEntRefNodesPresent                       = GetBool(new IntPtr(p + 0x090)); // 0270D743C330 0x90 FEntRefNodesPresent         ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.FCDataNodesPresent                        = GetBool(new IntPtr(p + 0x091)); // 0270D743C350 0x91 FCDataNodesPresent          ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.PreserveWhitespace                        = GetBool(new IntPtr(p + 0x092)); // 0270D743C370 0x92 PreserveWhitespace          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsLoading                                 = GetBool(new IntPtr(p + 0x093)); // 0270D743C390 0x93 IsLoading                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.StrDocumentName                           = GetString(new IntPtr(p + 0x098)); // 0270D743C3B0 0x98 StrDocumentName             ( 000186671BA0 ModelPrimitiveType string string string String )
            value.StrDocumentFragmentName                   = GetString(new IntPtr(p + 0x0A0)); // 0270D743C3D0 0xA0 StrDocumentFragmentName     ( 000186671BA0 ModelPrimitiveType string string string String )
            value.StrCommentName                            = GetString(new IntPtr(p + 0x0A8)); // 0270D743C3F0 0xA8 StrCommentName              ( 000186671BA0 ModelPrimitiveType string string string String )
            value.StrTextName                               = GetString(new IntPtr(p + 0x0B0)); // 0270D743C410 0xB0 StrTextName                 ( 000186671BA0 ModelPrimitiveType string string string String )
            value.StrCDataSectionName                       = GetString(new IntPtr(p + 0x0B8)); // 0270D743C430 0xB8 StrCDataSectionName         ( 000186671BA0 ModelPrimitiveType string string string String )
            value.StrEntityName                             = GetString(new IntPtr(p + 0x0C0)); // 0270D743C450 0xC0 StrEntityName               ( 000186671BA0 ModelPrimitiveType string string string String )
            value.StrID                                     = GetString(new IntPtr(p + 0x0C8)); // 0270D743C470 0xC8 StrID                       ( 000186671BA0 ModelPrimitiveType string string string String )
            value.StrXmlns                                  = GetString(new IntPtr(p + 0x0D0)); // 0270D743C490 0xD0 StrXmlns                    ( 000186671BA0 ModelPrimitiveType string string string String )
            value.StrXml                                    = GetString(new IntPtr(p + 0x0D8)); // 0270D743C4B0 0xD8 StrXml                      ( 000186671BA0 ModelPrimitiveType string string string String )
            value.StrSpace                                  = GetString(new IntPtr(p + 0x0E0)); // 0270D743C4D0 0xE0 StrSpace                    ( 000186671BA0 ModelPrimitiveType string string string String )
            value.StrLang                                   = GetString(new IntPtr(p + 0x0E8)); // 0270D743C4F0 0xE8 StrLang                     ( 000186671BA0 ModelPrimitiveType string string string String )
            value.StrEmpty                                  = GetString(new IntPtr(p + 0x0F0)); // 0270D743C510 0xF0 StrEmpty                    ( 000186671BA0 ModelPrimitiveType string string string String )
            value.StrNonSignificantWhitespaceName           = GetString(new IntPtr(p + 0x0F8)); // 0270D743C530 0xF8 StrNonSignificantWhitespaceName ( 000186671BA0 ModelPrimitiveType string string string String )
            value.StrSignificantWhitespaceName              = GetString(new IntPtr(p + 0x100)); // 0270D743C550 0x100 StrSignificantWhitespaceName ( 000186671BA0 ModelPrimitiveType string string string String )
            value.StrReservedXmlns                          = GetString(new IntPtr(p + 0x108)); // 0270D743C570 0x108 StrReservedXmlns            ( 000186671BA0 ModelPrimitiveType string string string String )
            value.StrReservedXml                            = GetString(new IntPtr(p + 0x110)); // 0270D743C590 0x110 StrReservedXml              ( 000186671BA0 ModelPrimitiveType string string string String )
            value.BaseURI                                   = GetString(new IntPtr(p + 0x118)); // 0270D743C5B0 0x118 BaseURI                     ( 000186671BA0 ModelPrimitiveType string string string String )
            value.Resolver                                  = GetObject<XmlResolver>(new IntPtr(p + 0x120), ReversePrism.DataModels.XmlResolver.FromPointer); // 0270D743C5D0 0x120 Resolver                    ( 0001865ABBE0 ModelClassType XmlResolver XmlResolver XmlResolver Pointer )
            value.BSetResolver                              = GetBool(new IntPtr(p + 0x128)); // 0270D743C5F0 0x128 BSetResolver                ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.NamespaceXml                              = GetObject<XmlAttribute>(new IntPtr(p + 0x138), ReversePrism.DataModels.XmlAttribute.FromPointer); // 0270D743C630 0x138 NamespaceXml                ( 000186589BC0 ModelClassType XmlAttribute XmlAttribute XmlAttribute Pointer )
            value.ValidSchemaInfo                           = GetObject<IXmlSchemaInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.IXmlSchemaInfo.FromPointer); // 0270D743C690 0x10 ValidSchemaInfo             ( 0001866A13F0 ModelClassType IXmlSchemaInfo IXmlSchemaInfo IXmlSchemaInfo Pointer )
            value.InvalidSchemaInfo                         = GetObject<IXmlSchemaInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.IXmlSchemaInfo.FromPointer); // 0270D743C6B0 0x18 InvalidSchemaInfo           ( 0001866A13F0 ModelClassType IXmlSchemaInfo IXmlSchemaInfo IXmlSchemaInfo Pointer )

            return value;
        }
    }
}
