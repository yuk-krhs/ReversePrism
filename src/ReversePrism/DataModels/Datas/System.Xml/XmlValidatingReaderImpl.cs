using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CoreReader                               ModelClassType XmlReader XmlReader XmlReader Pointer
    // 018 CoreReaderImpl                           ModelClassType XmlTextReaderImpl XmlTextReaderImpl XmlTextReaderImpl Pointer
    // 020 CoreReaderNSResolver                     ModelClassType IXmlNamespaceResolver IXmlNamespaceResolver IXmlNamespaceResolver Pointer
    // 028 ValidationType                           ModelEnumType ValidationType ValidationType ValidationType Int32
    // 030 Validator                                ModelClassType BaseValidator BaseValidator BaseValidator Pointer
    // 038 SchemaCollection                         ModelClassType XmlSchemaCollection XmlSchemaCollection XmlSchemaCollection Pointer
    // 040 ProcessIdentityConstraints               ModelPrimitiveType bool bool bool Bool
    // 044 ParsingFunction                          ModelEnumType ParsingFunction ParsingFunction ParsingFunction Int32
    // 048 EventHandling                            ModelClassType ValidationEventHandling ValidationEventHandling ValidationEventHandling Pointer
    // 050 ParserContext                            ModelClassType XmlParserContext XmlParserContext XmlParserContext Pointer
    // 058 ReadBinaryHelper                         ModelClassType ReadContentAsBinaryHelper ReadContentAsBinaryHelper ReadContentAsBinaryHelper Pointer
    // 060 OuterReader                              ModelClassType XmlReader XmlReader XmlReader Pointer
    // 000 s_tempResolver                           XmlResolver IL2CPP_TYPE_CLASS
    public partial class XmlValidatingReaderImpl : DataModel
    {
        public XmlReader?                               CoreReader                              { get; set; }
        public XmlTextReaderImpl?                       CoreReaderImpl                          { get; set; }
        public IXmlNamespaceResolver?                   CoreReaderNSResolver                    { get; set; }
        public ValidationType                           ValidationType                          { get; set; }
        public BaseValidator?                           Validator                               { get; set; }
        public XmlSchemaCollection?                     SchemaCollection                        { get; set; }
        public bool                                     ProcessIdentityConstraints              { get; set; }
        public ParsingFunction                          ParsingFunction                         { get; set; }
        public ValidationEventHandling?                 EventHandling                           { get; set; }
        public XmlParserContext?                        ParserContext                           { get; set; }
        public ReadContentAsBinaryHelper?               ReadBinaryHelper                        { get; set; }
        public XmlReader?                               OuterReader                             { get; set; }

        public static XmlValidatingReaderImpl? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlValidatingReaderImpl() { Pointer= p0 };

            value.CoreReader                                = GetObject<XmlReader>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlReader.FromPointer); // 0x10 CoreReader                  ( ModelClassType XmlReader XmlReader XmlReader Pointer )
            value.CoreReaderImpl                            = GetObject<XmlTextReaderImpl>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlTextReaderImpl.FromPointer); // 0x18 CoreReaderImpl              ( ModelClassType XmlTextReaderImpl XmlTextReaderImpl XmlTextReaderImpl Pointer )
            value.CoreReaderNSResolver                      = GetObject<IXmlNamespaceResolver>(new IntPtr(p + 0x020), ReversePrism.DataModels.IXmlNamespaceResolver.FromPointer); // 0x20 CoreReaderNSResolver        ( ModelClassType IXmlNamespaceResolver IXmlNamespaceResolver IXmlNamespaceResolver Pointer )
            value.ValidationType                            = (ValidationType)GetInt32(new IntPtr(p + 0x028)); // 0x28 ValidationType              ( ModelEnumType ValidationType ValidationType ValidationType Int32 )
            value.Validator                                 = GetObject<BaseValidator>(new IntPtr(p + 0x030), ReversePrism.DataModels.BaseValidator.FromPointer); // 0x30 Validator                   ( ModelClassType BaseValidator BaseValidator BaseValidator Pointer )
            value.SchemaCollection                          = GetObject<XmlSchemaCollection>(new IntPtr(p + 0x038), ReversePrism.DataModels.XmlSchemaCollection.FromPointer); // 0x38 SchemaCollection            ( ModelClassType XmlSchemaCollection XmlSchemaCollection XmlSchemaCollection Pointer )
            value.ProcessIdentityConstraints                = GetBool(new IntPtr(p + 0x040)); // 0x40 ProcessIdentityConstraints  ( ModelPrimitiveType bool bool bool Bool )
            value.ParsingFunction                           = (ParsingFunction)GetInt32(new IntPtr(p + 0x044)); // 0x44 ParsingFunction             ( ModelEnumType ParsingFunction ParsingFunction ParsingFunction Int32 )
            value.EventHandling                             = GetObject<ValidationEventHandling>(new IntPtr(p + 0x048), ReversePrism.DataModels.ValidationEventHandling.FromPointer); // 0x48 EventHandling               ( ModelClassType ValidationEventHandling ValidationEventHandling ValidationEventHandling Pointer )
            value.ParserContext                             = GetObject<XmlParserContext>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlParserContext.FromPointer); // 0x50 ParserContext               ( ModelClassType XmlParserContext XmlParserContext XmlParserContext Pointer )
            value.ReadBinaryHelper                          = GetObject<ReadContentAsBinaryHelper>(new IntPtr(p + 0x058), ReversePrism.DataModels.ReadContentAsBinaryHelper.FromPointer); // 0x58 ReadBinaryHelper            ( ModelClassType ReadContentAsBinaryHelper ReadContentAsBinaryHelper ReadContentAsBinaryHelper Pointer )
            value.OuterReader                               = GetObject<XmlReader>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlReader.FromPointer); // 0x60 OuterReader                 ( ModelClassType XmlReader XmlReader XmlReader Pointer )

            return value;
        }
    }
}
