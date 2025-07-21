using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Implementation                           ModelClassType XmlImplementation XmlImplementation XmlImplementation Pointer
    // 020 DomNameTable                             ModelClassType DomNameTable DomNameTable DomNameTable Pointer
    // 028 LastChild                                ModelClassType XmlLinkedNode XmlLinkedNode XmlLinkedNode Pointer
    // 030 Entities                                 ModelClassType XmlNamedNodeMap XmlNamedNodeMap XmlNamedNodeMap Pointer
    // 038 HtElementIdMap                           ModelClassType Hashtable Hashtable Hashtable Pointer
    // 040 HtElementIDAttrDecl                      ModelClassType Hashtable Hashtable Hashtable Pointer
    // 048 SchemaInfo                               ModelClassType SchemaInfo SchemaInfo SchemaInfo Pointer
    // 050 Schemas                                  ModelClassType XmlSchemaSet XmlSchemaSet XmlSchemaSet Pointer
    // 058 ReportValidity                           ModelPrimitiveType bool bool bool Bool
    // 059 ActualLoadingStatus                      ModelPrimitiveType bool bool bool Bool
    // 060 OnNodeInsertingDelegate                  ModelClassType XmlNodeChangedEventHandler XmlNodeChangedEventHandler XmlNodeChangedEventHandler Pointer
    // 068 OnNodeInsertedDelegate                   ModelClassType XmlNodeChangedEventHandler XmlNodeChangedEventHandler XmlNodeChangedEventHandler Pointer
    // 070 OnNodeRemovingDelegate                   ModelClassType XmlNodeChangedEventHandler XmlNodeChangedEventHandler XmlNodeChangedEventHandler Pointer
    // 078 OnNodeRemovedDelegate                    ModelClassType XmlNodeChangedEventHandler XmlNodeChangedEventHandler XmlNodeChangedEventHandler Pointer
    // 080 OnNodeChangingDelegate                   ModelClassType XmlNodeChangedEventHandler XmlNodeChangedEventHandler XmlNodeChangedEventHandler Pointer
    // 088 OnNodeChangedDelegate                    ModelClassType XmlNodeChangedEventHandler XmlNodeChangedEventHandler XmlNodeChangedEventHandler Pointer
    // 090 FEntRefNodesPresent                      ModelPrimitiveType bool bool bool Bool
    // 091 FCDataNodesPresent                       ModelPrimitiveType bool bool bool Bool
    // 092 PreserveWhitespace                       ModelPrimitiveType bool bool bool Bool
    // 093 IsLoading                                ModelPrimitiveType bool bool bool Bool
    // 098 StrDocumentName                          ModelPrimitiveType string string string String
    // 0A0 StrDocumentFragmentName                  ModelPrimitiveType string string string String
    // 0A8 StrCommentName                           ModelPrimitiveType string string string String
    // 0B0 StrTextName                              ModelPrimitiveType string string string String
    // 0B8 StrCDataSectionName                      ModelPrimitiveType string string string String
    // 0C0 StrEntityName                            ModelPrimitiveType string string string String
    // 0C8 StrID                                    ModelPrimitiveType string string string String
    // 0D0 StrXmlns                                 ModelPrimitiveType string string string String
    // 0D8 StrXml                                   ModelPrimitiveType string string string String
    // 0E0 StrSpace                                 ModelPrimitiveType string string string String
    // 0E8 StrLang                                  ModelPrimitiveType string string string String
    // 0F0 StrEmpty                                 ModelPrimitiveType string string string String
    // 0F8 StrNonSignificantWhitespaceName          ModelPrimitiveType string string string String
    // 100 StrSignificantWhitespaceName             ModelPrimitiveType string string string String
    // 108 StrReservedXmlns                         ModelPrimitiveType string string string String
    // 110 StrReservedXml                           ModelPrimitiveType string string string String
    // 118 BaseURI                                  ModelPrimitiveType string string string String
    // 120 Resolver                                 ModelClassType XmlResolver XmlResolver XmlResolver Pointer
    // 128 BSetResolver                             ModelPrimitiveType bool bool bool Bool
    // 130 objLock                                  <object> IL2CPP_TYPE_OBJECT
    // 138 NamespaceXml                             ModelClassType XmlAttribute XmlAttribute XmlAttribute Pointer
    // 000 EmptyEnumerator                          EmptyEnumerator IL2CPP_TYPE_CLASS
    // 008 NotKnownSchemaInfo                       IXmlSchemaInfo IL2CPP_TYPE_CLASS
    // 010 ValidSchemaInfo                          ModelClassType IXmlSchemaInfo IXmlSchemaInfo IXmlSchemaInfo Pointer
    // 018 InvalidSchemaInfo                        ModelClassType IXmlSchemaInfo IXmlSchemaInfo IXmlSchemaInfo Pointer
    public partial class XmlDocument : DataModel
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
            var value   = new XmlDocument() { Pointer= p0 };

            value.Implementation                            = GetObject<XmlImplementation>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlImplementation.FromPointer); // 0x18 Implementation              ( ModelClassType XmlImplementation XmlImplementation XmlImplementation Pointer )
            value.DomNameTable                              = GetObject<DomNameTable>(new IntPtr(p + 0x020), ReversePrism.DataModels.DomNameTable.FromPointer); // 0x20 DomNameTable                ( ModelClassType DomNameTable DomNameTable DomNameTable Pointer )
            value.LastChild                                 = GetObject<XmlLinkedNode>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlLinkedNode.FromPointer); // 0x28 LastChild                   ( ModelClassType XmlLinkedNode XmlLinkedNode XmlLinkedNode Pointer )
            value.Entities                                  = GetObject<XmlNamedNodeMap>(new IntPtr(p + 0x030), ReversePrism.DataModels.XmlNamedNodeMap.FromPointer); // 0x30 Entities                    ( ModelClassType XmlNamedNodeMap XmlNamedNodeMap XmlNamedNodeMap Pointer )
            value.HtElementIdMap                            = GetObject<Hashtable>(new IntPtr(p + 0x038), ReversePrism.DataModels.Hashtable.FromPointer); // 0x38 HtElementIdMap              ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.HtElementIDAttrDecl                       = GetObject<Hashtable>(new IntPtr(p + 0x040), ReversePrism.DataModels.Hashtable.FromPointer); // 0x40 HtElementIDAttrDecl         ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.SchemaInfo                                = GetObject<SchemaInfo>(new IntPtr(p + 0x048), ReversePrism.DataModels.SchemaInfo.FromPointer); // 0x48 SchemaInfo                  ( ModelClassType SchemaInfo SchemaInfo SchemaInfo Pointer )
            value.Schemas                                   = GetObject<XmlSchemaSet>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlSchemaSet.FromPointer); // 0x50 Schemas                     ( ModelClassType XmlSchemaSet XmlSchemaSet XmlSchemaSet Pointer )
            value.ReportValidity                            = GetBool(new IntPtr(p + 0x058)); // 0x58 ReportValidity              ( ModelPrimitiveType bool bool bool Bool )
            value.ActualLoadingStatus                       = GetBool(new IntPtr(p + 0x059)); // 0x59 ActualLoadingStatus         ( ModelPrimitiveType bool bool bool Bool )
            value.OnNodeInsertingDelegate                   = GetObject<XmlNodeChangedEventHandler>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlNodeChangedEventHandler.FromPointer); // 0x60 OnNodeInsertingDelegate     ( ModelClassType XmlNodeChangedEventHandler XmlNodeChangedEventHandler XmlNodeChangedEventHandler Pointer )
            value.OnNodeInsertedDelegate                    = GetObject<XmlNodeChangedEventHandler>(new IntPtr(p + 0x068), ReversePrism.DataModels.XmlNodeChangedEventHandler.FromPointer); // 0x68 OnNodeInsertedDelegate      ( ModelClassType XmlNodeChangedEventHandler XmlNodeChangedEventHandler XmlNodeChangedEventHandler Pointer )
            value.OnNodeRemovingDelegate                    = GetObject<XmlNodeChangedEventHandler>(new IntPtr(p + 0x070), ReversePrism.DataModels.XmlNodeChangedEventHandler.FromPointer); // 0x70 OnNodeRemovingDelegate      ( ModelClassType XmlNodeChangedEventHandler XmlNodeChangedEventHandler XmlNodeChangedEventHandler Pointer )
            value.OnNodeRemovedDelegate                     = GetObject<XmlNodeChangedEventHandler>(new IntPtr(p + 0x078), ReversePrism.DataModels.XmlNodeChangedEventHandler.FromPointer); // 0x78 OnNodeRemovedDelegate       ( ModelClassType XmlNodeChangedEventHandler XmlNodeChangedEventHandler XmlNodeChangedEventHandler Pointer )
            value.OnNodeChangingDelegate                    = GetObject<XmlNodeChangedEventHandler>(new IntPtr(p + 0x080), ReversePrism.DataModels.XmlNodeChangedEventHandler.FromPointer); // 0x80 OnNodeChangingDelegate      ( ModelClassType XmlNodeChangedEventHandler XmlNodeChangedEventHandler XmlNodeChangedEventHandler Pointer )
            value.OnNodeChangedDelegate                     = GetObject<XmlNodeChangedEventHandler>(new IntPtr(p + 0x088), ReversePrism.DataModels.XmlNodeChangedEventHandler.FromPointer); // 0x88 OnNodeChangedDelegate       ( ModelClassType XmlNodeChangedEventHandler XmlNodeChangedEventHandler XmlNodeChangedEventHandler Pointer )
            value.FEntRefNodesPresent                       = GetBool(new IntPtr(p + 0x090)); // 0x90 FEntRefNodesPresent         ( ModelPrimitiveType bool bool bool Bool )
            value.FCDataNodesPresent                        = GetBool(new IntPtr(p + 0x091)); // 0x91 FCDataNodesPresent          ( ModelPrimitiveType bool bool bool Bool )
            value.PreserveWhitespace                        = GetBool(new IntPtr(p + 0x092)); // 0x92 PreserveWhitespace          ( ModelPrimitiveType bool bool bool Bool )
            value.IsLoading                                 = GetBool(new IntPtr(p + 0x093)); // 0x93 IsLoading                   ( ModelPrimitiveType bool bool bool Bool )
            value.StrDocumentName                           = GetString(new IntPtr(p + 0x098)); // 0x98 StrDocumentName             ( ModelPrimitiveType string string string String )
            value.StrDocumentFragmentName                   = GetString(new IntPtr(p + 0x0A0)); // 0xA0 StrDocumentFragmentName     ( ModelPrimitiveType string string string String )
            value.StrCommentName                            = GetString(new IntPtr(p + 0x0A8)); // 0xA8 StrCommentName              ( ModelPrimitiveType string string string String )
            value.StrTextName                               = GetString(new IntPtr(p + 0x0B0)); // 0xB0 StrTextName                 ( ModelPrimitiveType string string string String )
            value.StrCDataSectionName                       = GetString(new IntPtr(p + 0x0B8)); // 0xB8 StrCDataSectionName         ( ModelPrimitiveType string string string String )
            value.StrEntityName                             = GetString(new IntPtr(p + 0x0C0)); // 0xC0 StrEntityName               ( ModelPrimitiveType string string string String )
            value.StrID                                     = GetString(new IntPtr(p + 0x0C8)); // 0xC8 StrID                       ( ModelPrimitiveType string string string String )
            value.StrXmlns                                  = GetString(new IntPtr(p + 0x0D0)); // 0xD0 StrXmlns                    ( ModelPrimitiveType string string string String )
            value.StrXml                                    = GetString(new IntPtr(p + 0x0D8)); // 0xD8 StrXml                      ( ModelPrimitiveType string string string String )
            value.StrSpace                                  = GetString(new IntPtr(p + 0x0E0)); // 0xE0 StrSpace                    ( ModelPrimitiveType string string string String )
            value.StrLang                                   = GetString(new IntPtr(p + 0x0E8)); // 0xE8 StrLang                     ( ModelPrimitiveType string string string String )
            value.StrEmpty                                  = GetString(new IntPtr(p + 0x0F0)); // 0xF0 StrEmpty                    ( ModelPrimitiveType string string string String )
            value.StrNonSignificantWhitespaceName           = GetString(new IntPtr(p + 0x0F8)); // 0xF8 StrNonSignificantWhitespaceName ( ModelPrimitiveType string string string String )
            value.StrSignificantWhitespaceName              = GetString(new IntPtr(p + 0x100)); // 0x100 StrSignificantWhitespaceName ( ModelPrimitiveType string string string String )
            value.StrReservedXmlns                          = GetString(new IntPtr(p + 0x108)); // 0x108 StrReservedXmlns            ( ModelPrimitiveType string string string String )
            value.StrReservedXml                            = GetString(new IntPtr(p + 0x110)); // 0x110 StrReservedXml              ( ModelPrimitiveType string string string String )
            value.BaseURI                                   = GetString(new IntPtr(p + 0x118)); // 0x118 BaseURI                     ( ModelPrimitiveType string string string String )
            value.Resolver                                  = GetObject<XmlResolver>(new IntPtr(p + 0x120), ReversePrism.DataModels.XmlResolver.FromPointer); // 0x120 Resolver                    ( ModelClassType XmlResolver XmlResolver XmlResolver Pointer )
            value.BSetResolver                              = GetBool(new IntPtr(p + 0x128)); // 0x128 BSetResolver                ( ModelPrimitiveType bool bool bool Bool )
            value.NamespaceXml                              = GetObject<XmlAttribute>(new IntPtr(p + 0x138), ReversePrism.DataModels.XmlAttribute.FromPointer); // 0x138 NamespaceXml                ( ModelClassType XmlAttribute XmlAttribute XmlAttribute Pointer )
            value.ValidSchemaInfo                           = GetObject<IXmlSchemaInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.IXmlSchemaInfo.FromPointer); // 0x10 ValidSchemaInfo             ( ModelClassType IXmlSchemaInfo IXmlSchemaInfo IXmlSchemaInfo Pointer )
            value.InvalidSchemaInfo                         = GetObject<IXmlSchemaInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.IXmlSchemaInfo.FromPointer); // 0x18 InvalidSchemaInfo           ( ModelClassType IXmlSchemaInfo IXmlSchemaInfo IXmlSchemaInfo Pointer )

            return value;
        }
    }
}
