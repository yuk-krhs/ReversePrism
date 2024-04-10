using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CoreReader                               0001865A9BB0 ModelClassType XmlReader XmlReader XmlReader Pointer
    // 018 CoreReaderNSResolver                     0001866A07A0 ModelClassType IXmlNamespaceResolver IXmlNamespaceResolver IXmlNamespaceResolver Pointer
    // 020 ThisNSResolver                           0001866A07A0 ModelClassType IXmlNamespaceResolver IXmlNamespaceResolver IXmlNamespaceResolver Pointer
    // 028 Validator                                0001865C30D0 ModelClassType XmlSchemaValidator XmlSchemaValidator XmlSchemaValidator Pointer
    // 030 XmlResolver                              0001865ABBE0 ModelClassType XmlResolver XmlResolver XmlResolver Pointer
    // 038 ValidationEvent                          000186765AD0 ModelClassType ValidationEventHandler ValidationEventHandler ValidationEventHandler Pointer
    // 040 ValidationState                          000186757230 ModelEnumType ValidatingReaderState ValidatingReaderState ValidatingReaderState Int32
    // 048 ValueGetter                              0001865D5460 ModelClassType XmlValueGetter XmlValueGetter XmlValueGetter Pointer
    // 050 NsManager                                0001866BAB00 ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer
    // 058 ManageNamespaces                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 059 ProcessInlineSchema                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 05A ReplayCache                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 060 CachedNode                               000186764C70 ModelClassType ValidatingReaderNodeData ValidatingReaderNodeData ValidatingReaderNodeData Pointer
    // 068 AttributePSVI                            000186712D60 ModelClassType AttributePSVIInfo AttributePSVIInfo AttributePSVIInfo Pointer
    // 070 AttributeCount                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 074 CoreReaderAttributeCount                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 078 CurrentAttrIndex                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 080 AttributePSVINodes                       000185B712F0 ModelClassListType AttributePSVIInfo[] AttributePSVIInfo[] List<AttributePSVIInfo> Pointer
    // 088 DefaultAttributes                        00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 090 InlineSchemaParser                       000186721710 ModelClassType Parser Parser Parser Pointer
    // 098 atomicValue                              <object> IL2CPP_TYPE_OBJECT
    // 0A0 XmlSchemaInfo                            0001865B9560 ModelClassType XmlSchemaInfo XmlSchemaInfo XmlSchemaInfo Pointer
    // 0A8 OriginalAtomicValueString                000186671910 ModelPrimitiveType string string string String
    // 0B0 CoreReaderNameTable                      0001865A0930 ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer
    // 0B8 CachingReader                            0001865D8800 ModelClassType XsdCachingReader XsdCachingReader XsdCachingReader Pointer
    // 0C0 TextNode                                 000186764C70 ModelClassType ValidatingReaderNodeData ValidatingReaderNodeData ValidatingReaderNodeData Pointer
    // 0C8 NsXmlNs                                  000186671910 ModelPrimitiveType string string string String
    // 0D0 NsXs                                     000186671910 ModelPrimitiveType string string string String
    // 0D8 NsXsi                                    000186671910 ModelPrimitiveType string string string String
    // 0E0 XsiType                                  000186671910 ModelPrimitiveType string string string String
    // 0E8 XsiNil                                   000186671910 ModelPrimitiveType string string string String
    // 0F0 XsdSchema                                000186671910 ModelPrimitiveType string string string String
    // 0F8 XsiSchemaLocation                        000186671910 ModelPrimitiveType string string string String
    // 100 XsiNoNamespaceSchemaLocation             000186671910 ModelPrimitiveType string string string String
    // 108 XmlCharType                              00018658F4B0 ModelEnumType XmlCharType XmlCharType XmlCharType Int32
    // 110 LineInfo                                 00018669FB60 ModelClassType IXmlLineInfo IXmlLineInfo IXmlLineInfo Pointer
    // 118 ReadBinaryHelper                         000186616EF0 ModelClassType ReadContentAsBinaryHelper ReadContentAsBinaryHelper ReadContentAsBinaryHelper Pointer
    // 120 SavedState                               000186757230 ModelEnumType ValidatingReaderState ValidatingReaderState ValidatingReaderState Int32
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

            value.CoreReader                                = GetObject<XmlReader>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlReader.FromPointer); // 0246674954A0 0x10 CoreReader                  ( 0001865A9BB0 ModelClassType XmlReader XmlReader XmlReader Pointer )
            value.CoreReaderNSResolver                      = GetObject<IXmlNamespaceResolver>(new IntPtr(p + 0x018), ReversePrism.DataModels.IXmlNamespaceResolver.FromPointer); // 0246674954C0 0x18 CoreReaderNSResolver        ( 0001866A07A0 ModelClassType IXmlNamespaceResolver IXmlNamespaceResolver IXmlNamespaceResolver Pointer )
            value.ThisNSResolver                            = GetObject<IXmlNamespaceResolver>(new IntPtr(p + 0x020), ReversePrism.DataModels.IXmlNamespaceResolver.FromPointer); // 0246674954E0 0x20 ThisNSResolver              ( 0001866A07A0 ModelClassType IXmlNamespaceResolver IXmlNamespaceResolver IXmlNamespaceResolver Pointer )
            value.Validator                                 = GetObject<XmlSchemaValidator>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlSchemaValidator.FromPointer); // 024667495500 0x28 Validator                   ( 0001865C30D0 ModelClassType XmlSchemaValidator XmlSchemaValidator XmlSchemaValidator Pointer )
            value.XmlResolver                               = GetObject<XmlResolver>(new IntPtr(p + 0x030), ReversePrism.DataModels.XmlResolver.FromPointer); // 024667495520 0x30 XmlResolver                 ( 0001865ABBE0 ModelClassType XmlResolver XmlResolver XmlResolver Pointer )
            value.ValidationEvent                           = GetObject<ValidationEventHandler>(new IntPtr(p + 0x038), ReversePrism.DataModels.ValidationEventHandler.FromPointer); // 024667495540 0x38 ValidationEvent             ( 000186765AD0 ModelClassType ValidationEventHandler ValidationEventHandler ValidationEventHandler Pointer )
            value.ValidationState                           = (ValidatingReaderState)GetInt32(new IntPtr(p + 0x040)); // 024667495560 0x40 ValidationState             ( 000186757230 ModelEnumType ValidatingReaderState ValidatingReaderState ValidatingReaderState Int32 )
            value.ValueGetter                               = GetObject<XmlValueGetter>(new IntPtr(p + 0x048), ReversePrism.DataModels.XmlValueGetter.FromPointer); // 024667495580 0x48 ValueGetter                 ( 0001865D5460 ModelClassType XmlValueGetter XmlValueGetter XmlValueGetter Pointer )
            value.NsManager                                 = GetObject<XmlNamespaceManager>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlNamespaceManager.FromPointer); // 0246674955A0 0x50 NsManager                   ( 0001866BAB00 ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer )
            value.ManageNamespaces                          = GetBool(new IntPtr(p + 0x058)); // 0246674955C0 0x58 ManageNamespaces            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ProcessInlineSchema                       = GetBool(new IntPtr(p + 0x059)); // 0246674955E0 0x59 ProcessInlineSchema         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ReplayCache                               = GetBool(new IntPtr(p + 0x05A)); // 024667495600 0x5A ReplayCache                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CachedNode                                = GetObject<ValidatingReaderNodeData>(new IntPtr(p + 0x060), ReversePrism.DataModels.ValidatingReaderNodeData.FromPointer); // 024667495620 0x60 CachedNode                  ( 000186764C70 ModelClassType ValidatingReaderNodeData ValidatingReaderNodeData ValidatingReaderNodeData Pointer )
            value.AttributePSVI                             = GetObject<AttributePSVIInfo>(new IntPtr(p + 0x068), ReversePrism.DataModels.AttributePSVIInfo.FromPointer); // 024667495640 0x68 AttributePSVI               ( 000186712D60 ModelClassType AttributePSVIInfo AttributePSVIInfo AttributePSVIInfo Pointer )
            value.AttributeCount                            = GetInt32(new IntPtr(p + 0x070)); // 024667495660 0x70 AttributeCount              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CoreReaderAttributeCount                  = GetInt32(new IntPtr(p + 0x074)); // 024667495680 0x74 CoreReaderAttributeCount    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentAttrIndex                          = GetInt32(new IntPtr(p + 0x078)); // 0246674956A0 0x78 CurrentAttrIndex            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AttributePSVINodes                        = GetObjectList<AttributePSVIInfo>(new IntPtr(p + 0x080), ReversePrism.DataModels.AttributePSVIInfo.FromPointer); // 0246674956C0 0x80 AttributePSVINodes          ( 000185B712F0 ModelClassListType AttributePSVIInfo[] AttributePSVIInfo[] List<AttributePSVIInfo> Pointer )
            value.DefaultAttributes                         = GetObject<ArrayList>(new IntPtr(p + 0x088), ReversePrism.DataModels.ArrayList.FromPointer); // 0246674956E0 0x88 DefaultAttributes           ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.InlineSchemaParser                        = GetObject<Parser>(new IntPtr(p + 0x090), ReversePrism.DataModels.Parser.FromPointer); // 024667495700 0x90 InlineSchemaParser          ( 000186721710 ModelClassType Parser Parser Parser Pointer )
            value.XmlSchemaInfo                             = GetObject<XmlSchemaInfo>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.XmlSchemaInfo.FromPointer); // 024667495740 0xA0 XmlSchemaInfo               ( 0001865B9560 ModelClassType XmlSchemaInfo XmlSchemaInfo XmlSchemaInfo Pointer )
            value.OriginalAtomicValueString                 = GetString(new IntPtr(p + 0x0A8)); // 024667495760 0xA8 OriginalAtomicValueString   ( 000186671910 ModelPrimitiveType string string string String )
            value.CoreReaderNameTable                       = GetObject<XmlNameTable>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.XmlNameTable.FromPointer); // 024667495780 0xB0 CoreReaderNameTable         ( 0001865A0930 ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer )
            value.CachingReader                             = GetObject<XsdCachingReader>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.XsdCachingReader.FromPointer); // 0246674957A0 0xB8 CachingReader               ( 0001865D8800 ModelClassType XsdCachingReader XsdCachingReader XsdCachingReader Pointer )
            value.TextNode                                  = GetObject<ValidatingReaderNodeData>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.ValidatingReaderNodeData.FromPointer); // 0246674957C0 0xC0 TextNode                    ( 000186764C70 ModelClassType ValidatingReaderNodeData ValidatingReaderNodeData ValidatingReaderNodeData Pointer )
            value.NsXmlNs                                   = GetString(new IntPtr(p + 0x0C8)); // 0246674957E0 0xC8 NsXmlNs                     ( 000186671910 ModelPrimitiveType string string string String )
            value.NsXs                                      = GetString(new IntPtr(p + 0x0D0)); // 024667495800 0xD0 NsXs                        ( 000186671910 ModelPrimitiveType string string string String )
            value.NsXsi                                     = GetString(new IntPtr(p + 0x0D8)); // 024667495820 0xD8 NsXsi                       ( 000186671910 ModelPrimitiveType string string string String )
            value.XsiType                                   = GetString(new IntPtr(p + 0x0E0)); // 024667495840 0xE0 XsiType                     ( 000186671910 ModelPrimitiveType string string string String )
            value.XsiNil                                    = GetString(new IntPtr(p + 0x0E8)); // 024667495860 0xE8 XsiNil                      ( 000186671910 ModelPrimitiveType string string string String )
            value.XsdSchema                                 = GetString(new IntPtr(p + 0x0F0)); // 024667495880 0xF0 XsdSchema                   ( 000186671910 ModelPrimitiveType string string string String )
            value.XsiSchemaLocation                         = GetString(new IntPtr(p + 0x0F8)); // 0246674958A0 0xF8 XsiSchemaLocation           ( 000186671910 ModelPrimitiveType string string string String )
            value.XsiNoNamespaceSchemaLocation              = GetString(new IntPtr(p + 0x100)); // 0246674958C0 0x100 XsiNoNamespaceSchemaLocation ( 000186671910 ModelPrimitiveType string string string String )
            value.XmlCharType                               = (XmlCharType)GetInt32(new IntPtr(p + 0x108)); // 0246674958E0 0x108 XmlCharType                 ( 00018658F4B0 ModelEnumType XmlCharType XmlCharType XmlCharType Int32 )
            value.LineInfo                                  = GetObject<IXmlLineInfo>(new IntPtr(p + 0x110), ReversePrism.DataModels.IXmlLineInfo.FromPointer); // 024667495900 0x110 LineInfo                    ( 00018669FB60 ModelClassType IXmlLineInfo IXmlLineInfo IXmlLineInfo Pointer )
            value.ReadBinaryHelper                          = GetObject<ReadContentAsBinaryHelper>(new IntPtr(p + 0x118), ReversePrism.DataModels.ReadContentAsBinaryHelper.FromPointer); // 024667495920 0x118 ReadBinaryHelper            ( 000186616EF0 ModelClassType ReadContentAsBinaryHelper ReadContentAsBinaryHelper ReadContentAsBinaryHelper Pointer )
            value.SavedState                                = (ValidatingReaderState)GetInt32(new IntPtr(p + 0x120)); // 024667495940 0x120 SavedState                  ( 000186757230 ModelEnumType ValidatingReaderState ValidatingReaderState ValidatingReaderState Int32 )

            return value;
        }
    }
}
