using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CoreReader                               ModelClassType XmlReader XmlReader XmlReader Pointer
    // 018 CoreReaderNSResolver                     ModelClassType IXmlNamespaceResolver IXmlNamespaceResolver IXmlNamespaceResolver Pointer
    // 020 ThisNSResolver                           ModelClassType IXmlNamespaceResolver IXmlNamespaceResolver IXmlNamespaceResolver Pointer
    // 028 Validator                                ModelClassType XmlSchemaValidator XmlSchemaValidator XmlSchemaValidator Pointer
    // 030 XmlResolver                              ModelClassType XmlResolver XmlResolver XmlResolver Pointer
    // 038 ValidationEvent                          ModelClassType ValidationEventHandler ValidationEventHandler ValidationEventHandler Pointer
    // 040 ValidationState                          ModelEnumType ValidatingReaderState ValidatingReaderState ValidatingReaderState Int32
    // 048 ValueGetter                              ModelClassType XmlValueGetter XmlValueGetter XmlValueGetter Pointer
    // 050 NsManager                                ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer
    // 058 ManageNamespaces                         ModelPrimitiveType bool bool bool Bool
    // 059 ProcessInlineSchema                      ModelPrimitiveType bool bool bool Bool
    // 05A ReplayCache                              ModelPrimitiveType bool bool bool Bool
    // 060 CachedNode                               ModelClassType ValidatingReaderNodeData ValidatingReaderNodeData ValidatingReaderNodeData Pointer
    // 068 AttributePSVI                            ModelClassType AttributePSVIInfo AttributePSVIInfo AttributePSVIInfo Pointer
    // 070 AttributeCount                           ModelPrimitiveType int int int Int32
    // 074 CoreReaderAttributeCount                 ModelPrimitiveType int int int Int32
    // 078 CurrentAttrIndex                         ModelPrimitiveType int int int Int32
    // 080 AttributePSVINodes                       ModelClassListType AttributePSVIInfo[] AttributePSVIInfo[] List<AttributePSVIInfo> Pointer
    // 088 DefaultAttributes                        ModelClassType ArrayList ArrayList ArrayList Pointer
    // 090 InlineSchemaParser                       ModelClassType Parser Parser Parser Pointer
    // 098 atomicValue                              <object> IL2CPP_TYPE_OBJECT
    // 0A0 XmlSchemaInfo                            ModelClassType XmlSchemaInfo XmlSchemaInfo XmlSchemaInfo Pointer
    // 0A8 OriginalAtomicValueString                ModelPrimitiveType string string string String
    // 0B0 CoreReaderNameTable                      ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer
    // 0B8 CachingReader                            ModelClassType XsdCachingReader XsdCachingReader XsdCachingReader Pointer
    // 0C0 TextNode                                 ModelClassType ValidatingReaderNodeData ValidatingReaderNodeData ValidatingReaderNodeData Pointer
    // 0C8 NsXmlNs                                  ModelPrimitiveType string string string String
    // 0D0 NsXs                                     ModelPrimitiveType string string string String
    // 0D8 NsXsi                                    ModelPrimitiveType string string string String
    // 0E0 XsiType                                  ModelPrimitiveType string string string String
    // 0E8 XsiNil                                   ModelPrimitiveType string string string String
    // 0F0 XsdSchema                                ModelPrimitiveType string string string String
    // 0F8 XsiSchemaLocation                        ModelPrimitiveType string string string String
    // 100 XsiNoNamespaceSchemaLocation             ModelPrimitiveType string string string String
    // 108 XmlCharType                              ModelEnumType XmlCharType XmlCharType XmlCharType Int32
    // 110 LineInfo                                 ModelClassType IXmlLineInfo IXmlLineInfo IXmlLineInfo Pointer
    // 118 ReadBinaryHelper                         ModelClassType ReadContentAsBinaryHelper ReadContentAsBinaryHelper ReadContentAsBinaryHelper Pointer
    // 120 SavedState                               ModelEnumType ValidatingReaderState ValidatingReaderState ValidatingReaderState Int32
    // 000 TypeOfString                             Type IL2CPP_TYPE_CLASS
    public partial class XsdValidatingReader : DataModel
    {
        public XmlReader?                               CoreReader                              { get; set; }
        public IXmlNamespaceResolver?                   CoreReaderNSResolver                    { get; set; }
        public IXmlNamespaceResolver?                   ThisNSResolver                          { get; set; }
        public XmlSchemaValidator?                      Validator                               { get; set; }
        public XmlResolver?                             XmlResolver                             { get; set; }
        public ValidationEventHandler?                  ValidationEvent                         { get; set; }
        public ValidatingReaderState                    ValidationState                         { get; set; }
        public XmlValueGetter?                          ValueGetter                             { get; set; }
        public XmlNamespaceManager?                     NsManager                               { get; set; }
        public bool                                     ManageNamespaces                        { get; set; }
        public bool                                     ProcessInlineSchema                     { get; set; }
        public bool                                     ReplayCache                             { get; set; }
        public ValidatingReaderNodeData?                CachedNode                              { get; set; }
        public AttributePSVIInfo?                       AttributePSVI                           { get; set; }
        public int                                      AttributeCount                          { get; set; }
        public int                                      CoreReaderAttributeCount                { get; set; }
        public int                                      CurrentAttrIndex                        { get; set; }
        public List<AttributePSVIInfo>?                 AttributePSVINodes                      { get; set; }
        public ArrayList?                               DefaultAttributes                       { get; set; }
        public Parser?                                  InlineSchemaParser                      { get; set; }
        public XmlSchemaInfo?                           XmlSchemaInfo                           { get; set; }
        public string                                   OriginalAtomicValueString               { get; set; }
        public XmlNameTable?                            CoreReaderNameTable                     { get; set; }
        public XsdCachingReader?                        CachingReader                           { get; set; }
        public ValidatingReaderNodeData?                TextNode                                { get; set; }
        public string                                   NsXmlNs                                 { get; set; }
        public string                                   NsXs                                    { get; set; }
        public string                                   NsXsi                                   { get; set; }
        public string                                   XsiType                                 { get; set; }
        public string                                   XsiNil                                  { get; set; }
        public string                                   XsdSchema                               { get; set; }
        public string                                   XsiSchemaLocation                       { get; set; }
        public string                                   XsiNoNamespaceSchemaLocation            { get; set; }
        public XmlCharType                              XmlCharType                             { get; set; }
        public IXmlLineInfo?                            LineInfo                                { get; set; }
        public ReadContentAsBinaryHelper?               ReadBinaryHelper                        { get; set; }
        public ValidatingReaderState                    SavedState                              { get; set; }

        public static XsdValidatingReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XsdValidatingReader() { Pointer= p0 };

            value.CoreReader                                = GetObject<XmlReader>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlReader.FromPointer); // 0x10 CoreReader                  ( ModelClassType XmlReader XmlReader XmlReader Pointer )
            value.CoreReaderNSResolver                      = GetObject<IXmlNamespaceResolver>(new IntPtr(p + 0x018), ReversePrism.DataModels.IXmlNamespaceResolver.FromPointer); // 0x18 CoreReaderNSResolver        ( ModelClassType IXmlNamespaceResolver IXmlNamespaceResolver IXmlNamespaceResolver Pointer )
            value.ThisNSResolver                            = GetObject<IXmlNamespaceResolver>(new IntPtr(p + 0x020), ReversePrism.DataModels.IXmlNamespaceResolver.FromPointer); // 0x20 ThisNSResolver              ( ModelClassType IXmlNamespaceResolver IXmlNamespaceResolver IXmlNamespaceResolver Pointer )
            value.Validator                                 = GetObject<XmlSchemaValidator>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlSchemaValidator.FromPointer); // 0x28 Validator                   ( ModelClassType XmlSchemaValidator XmlSchemaValidator XmlSchemaValidator Pointer )
            value.XmlResolver                               = GetObject<XmlResolver>(new IntPtr(p + 0x030), ReversePrism.DataModels.XmlResolver.FromPointer); // 0x30 XmlResolver                 ( ModelClassType XmlResolver XmlResolver XmlResolver Pointer )
            value.ValidationEvent                           = GetObject<ValidationEventHandler>(new IntPtr(p + 0x038), ReversePrism.DataModels.ValidationEventHandler.FromPointer); // 0x38 ValidationEvent             ( ModelClassType ValidationEventHandler ValidationEventHandler ValidationEventHandler Pointer )
            value.ValidationState                           = (ValidatingReaderState)GetInt32(new IntPtr(p + 0x040)); // 0x40 ValidationState             ( ModelEnumType ValidatingReaderState ValidatingReaderState ValidatingReaderState Int32 )
            value.ValueGetter                               = GetObject<XmlValueGetter>(new IntPtr(p + 0x048), ReversePrism.DataModels.XmlValueGetter.FromPointer); // 0x48 ValueGetter                 ( ModelClassType XmlValueGetter XmlValueGetter XmlValueGetter Pointer )
            value.NsManager                                 = GetObject<XmlNamespaceManager>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlNamespaceManager.FromPointer); // 0x50 NsManager                   ( ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer )
            value.ManageNamespaces                          = GetBool(new IntPtr(p + 0x058)); // 0x58 ManageNamespaces            ( ModelPrimitiveType bool bool bool Bool )
            value.ProcessInlineSchema                       = GetBool(new IntPtr(p + 0x059)); // 0x59 ProcessInlineSchema         ( ModelPrimitiveType bool bool bool Bool )
            value.ReplayCache                               = GetBool(new IntPtr(p + 0x05A)); // 0x5A ReplayCache                 ( ModelPrimitiveType bool bool bool Bool )
            value.CachedNode                                = GetObject<ValidatingReaderNodeData>(new IntPtr(p + 0x060), ReversePrism.DataModels.ValidatingReaderNodeData.FromPointer); // 0x60 CachedNode                  ( ModelClassType ValidatingReaderNodeData ValidatingReaderNodeData ValidatingReaderNodeData Pointer )
            value.AttributePSVI                             = GetObject<AttributePSVIInfo>(new IntPtr(p + 0x068), ReversePrism.DataModels.AttributePSVIInfo.FromPointer); // 0x68 AttributePSVI               ( ModelClassType AttributePSVIInfo AttributePSVIInfo AttributePSVIInfo Pointer )
            value.AttributeCount                            = GetInt32(new IntPtr(p + 0x070)); // 0x70 AttributeCount              ( ModelPrimitiveType int int int Int32 )
            value.CoreReaderAttributeCount                  = GetInt32(new IntPtr(p + 0x074)); // 0x74 CoreReaderAttributeCount    ( ModelPrimitiveType int int int Int32 )
            value.CurrentAttrIndex                          = GetInt32(new IntPtr(p + 0x078)); // 0x78 CurrentAttrIndex            ( ModelPrimitiveType int int int Int32 )
            value.AttributePSVINodes                        = GetObjectList<AttributePSVIInfo>(new IntPtr(p + 0x080), ReversePrism.DataModels.AttributePSVIInfo.FromPointer); // 0x80 AttributePSVINodes          ( ModelClassListType AttributePSVIInfo[] AttributePSVIInfo[] List<AttributePSVIInfo> Pointer )
            value.DefaultAttributes                         = GetObject<ArrayList>(new IntPtr(p + 0x088), ReversePrism.DataModels.ArrayList.FromPointer); // 0x88 DefaultAttributes           ( ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.InlineSchemaParser                        = GetObject<Parser>(new IntPtr(p + 0x090), ReversePrism.DataModels.Parser.FromPointer); // 0x90 InlineSchemaParser          ( ModelClassType Parser Parser Parser Pointer )
            value.XmlSchemaInfo                             = GetObject<XmlSchemaInfo>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.XmlSchemaInfo.FromPointer); // 0xA0 XmlSchemaInfo               ( ModelClassType XmlSchemaInfo XmlSchemaInfo XmlSchemaInfo Pointer )
            value.OriginalAtomicValueString                 = GetString(new IntPtr(p + 0x0A8)); // 0xA8 OriginalAtomicValueString   ( ModelPrimitiveType string string string String )
            value.CoreReaderNameTable                       = GetObject<XmlNameTable>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.XmlNameTable.FromPointer); // 0xB0 CoreReaderNameTable         ( ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer )
            value.CachingReader                             = GetObject<XsdCachingReader>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.XsdCachingReader.FromPointer); // 0xB8 CachingReader               ( ModelClassType XsdCachingReader XsdCachingReader XsdCachingReader Pointer )
            value.TextNode                                  = GetObject<ValidatingReaderNodeData>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.ValidatingReaderNodeData.FromPointer); // 0xC0 TextNode                    ( ModelClassType ValidatingReaderNodeData ValidatingReaderNodeData ValidatingReaderNodeData Pointer )
            value.NsXmlNs                                   = GetString(new IntPtr(p + 0x0C8)); // 0xC8 NsXmlNs                     ( ModelPrimitiveType string string string String )
            value.NsXs                                      = GetString(new IntPtr(p + 0x0D0)); // 0xD0 NsXs                        ( ModelPrimitiveType string string string String )
            value.NsXsi                                     = GetString(new IntPtr(p + 0x0D8)); // 0xD8 NsXsi                       ( ModelPrimitiveType string string string String )
            value.XsiType                                   = GetString(new IntPtr(p + 0x0E0)); // 0xE0 XsiType                     ( ModelPrimitiveType string string string String )
            value.XsiNil                                    = GetString(new IntPtr(p + 0x0E8)); // 0xE8 XsiNil                      ( ModelPrimitiveType string string string String )
            value.XsdSchema                                 = GetString(new IntPtr(p + 0x0F0)); // 0xF0 XsdSchema                   ( ModelPrimitiveType string string string String )
            value.XsiSchemaLocation                         = GetString(new IntPtr(p + 0x0F8)); // 0xF8 XsiSchemaLocation           ( ModelPrimitiveType string string string String )
            value.XsiNoNamespaceSchemaLocation              = GetString(new IntPtr(p + 0x100)); // 0x100 XsiNoNamespaceSchemaLocation ( ModelPrimitiveType string string string String )
            value.XmlCharType                               = (XmlCharType)GetInt32(new IntPtr(p + 0x108)); // 0x108 XmlCharType                 ( ModelEnumType XmlCharType XmlCharType XmlCharType Int32 )
            value.LineInfo                                  = GetObject<IXmlLineInfo>(new IntPtr(p + 0x110), ReversePrism.DataModels.IXmlLineInfo.FromPointer); // 0x110 LineInfo                    ( ModelClassType IXmlLineInfo IXmlLineInfo IXmlLineInfo Pointer )
            value.ReadBinaryHelper                          = GetObject<ReadContentAsBinaryHelper>(new IntPtr(p + 0x118), ReversePrism.DataModels.ReadContentAsBinaryHelper.FromPointer); // 0x118 ReadBinaryHelper            ( ModelClassType ReadContentAsBinaryHelper ReadContentAsBinaryHelper ReadContentAsBinaryHelper Pointer )
            value.SavedState                                = (ValidatingReaderState)GetInt32(new IntPtr(p + 0x120)); // 0x120 SavedState                  ( ModelEnumType ValidatingReaderState ValidatingReaderState ValidatingReaderState Int32 )

            return value;
        }
    }
}
