using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CoreReader                               0001865A9BB0 ModelClassType XmlReader XmlReader XmlReader Pointer
    // 018 CoreReaderImpl                           0001865CD480 ModelClassType XmlTextReaderImpl XmlTextReaderImpl XmlTextReaderImpl Pointer
    // 020 CoreReaderNSResolver                     0001866A07A0 ModelClassType IXmlNamespaceResolver IXmlNamespaceResolver IXmlNamespaceResolver Pointer
    // 028 ValidationType                           000186766BD0 ModelEnumType ValidationType ValidationType ValidationType Int32
    // 030 Validator                                000186744BE0 ModelClassType BaseValidator BaseValidator BaseValidator Pointer
    // 038 SchemaCollection                         0001865AF840 ModelClassType XmlSchemaCollection XmlSchemaCollection XmlSchemaCollection Pointer
    // 040 ProcessIdentityConstraints               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 044 ParsingFunction                          00018674D370 ModelEnumType ParsingFunction ParsingFunction ParsingFunction Int32
    // 048 EventHandling                            00018674DAB0 ModelClassType ValidationEventHandling ValidationEventHandling ValidationEventHandling Pointer
    // 050 ParserContext                            0001865A80B0 ModelClassType XmlParserContext XmlParserContext XmlParserContext Pointer
    // 058 ReadBinaryHelper                         000186616EF0 ModelClassType ReadContentAsBinaryHelper ReadContentAsBinaryHelper ReadContentAsBinaryHelper Pointer
    // 060 OuterReader                              0001865A9BB0 ModelClassType XmlReader XmlReader XmlReader Pointer
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

            value.CoreReader                                = GetObject<XmlReader>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlReader.FromPointer); // 024667423350 0x10 CoreReader                  ( 0001865A9BB0 ModelClassType XmlReader XmlReader XmlReader Pointer )
            value.CoreReaderImpl                            = GetObject<XmlTextReaderImpl>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlTextReaderImpl.FromPointer); // 024667423370 0x18 CoreReaderImpl              ( 0001865CD480 ModelClassType XmlTextReaderImpl XmlTextReaderImpl XmlTextReaderImpl Pointer )
            value.CoreReaderNSResolver                      = GetObject<IXmlNamespaceResolver>(new IntPtr(p + 0x020), ReversePrism.DataModels.IXmlNamespaceResolver.FromPointer); // 024667423390 0x20 CoreReaderNSResolver        ( 0001866A07A0 ModelClassType IXmlNamespaceResolver IXmlNamespaceResolver IXmlNamespaceResolver Pointer )
            value.ValidationType                            = (ValidationType)GetInt32(new IntPtr(p + 0x028)); // 0246674233B0 0x28 ValidationType              ( 000186766BD0 ModelEnumType ValidationType ValidationType ValidationType Int32 )
            value.Validator                                 = GetObject<BaseValidator>(new IntPtr(p + 0x030), ReversePrism.DataModels.BaseValidator.FromPointer); // 0246674233D0 0x30 Validator                   ( 000186744BE0 ModelClassType BaseValidator BaseValidator BaseValidator Pointer )
            value.SchemaCollection                          = GetObject<XmlSchemaCollection>(new IntPtr(p + 0x038), ReversePrism.DataModels.XmlSchemaCollection.FromPointer); // 0246674233F0 0x38 SchemaCollection            ( 0001865AF840 ModelClassType XmlSchemaCollection XmlSchemaCollection XmlSchemaCollection Pointer )
            value.ProcessIdentityConstraints                = GetBool(new IntPtr(p + 0x040)); // 024667423410 0x40 ProcessIdentityConstraints  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ParsingFunction                           = (ParsingFunction)GetInt32(new IntPtr(p + 0x044)); // 024667423430 0x44 ParsingFunction             ( 00018674D370 ModelEnumType ParsingFunction ParsingFunction ParsingFunction Int32 )
            value.EventHandling                             = GetObject<ValidationEventHandling>(new IntPtr(p + 0x048), ReversePrism.DataModels.ValidationEventHandling.FromPointer); // 024667423450 0x48 EventHandling               ( 00018674DAB0 ModelClassType ValidationEventHandling ValidationEventHandling ValidationEventHandling Pointer )
            value.ParserContext                             = GetObject<XmlParserContext>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlParserContext.FromPointer); // 024667423470 0x50 ParserContext               ( 0001865A80B0 ModelClassType XmlParserContext XmlParserContext XmlParserContext Pointer )
            value.ReadBinaryHelper                          = GetObject<ReadContentAsBinaryHelper>(new IntPtr(p + 0x058), ReversePrism.DataModels.ReadContentAsBinaryHelper.FromPointer); // 024667423490 0x58 ReadBinaryHelper            ( 000186616EF0 ModelClassType ReadContentAsBinaryHelper ReadContentAsBinaryHelper ReadContentAsBinaryHelper Pointer )
            value.OuterReader                               = GetObject<XmlReader>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlReader.FromPointer); // 0246674234B0 0x60 OuterReader                 ( 0001865A9BB0 ModelClassType XmlReader XmlReader XmlReader Pointer )

            return value;
        }
    }
}
