using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Encodings                                000185B7B270 ModelClassListType Encoding[] Encoding[] List<Encoding> Pointer
    // 018 XmlReader                                000186593BB0 ModelClassType XmlDictionaryReader XmlDictionaryReader XmlDictionaryReader Pointer
    // 020 InfosetReader                            000186593BB0 ModelClassType XmlDictionaryReader XmlDictionaryReader XmlDictionaryReader Pointer
    // 028 MimeReader                               000186618C20 ModelClassType MimeReader MimeReader MimeReader Pointer
    // 030 mimeParts                                Dictionary`2<string, MimePart> IL2CPP_TYPE_GENERICINST
    // 038 OnClose                                  0001866DD0C0 ModelClassType OnXmlDictionaryReaderClose OnXmlDictionaryReaderClose OnXmlDictionaryReaderClose Pointer
    // 040 ReadingBinaryElement                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 044 MaxBufferSize                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 048 BufferRemaining                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 050 Part                                     000186739480 ModelClassType MimePart MimePart MimePart Pointer
    public partial class XmlMtomReader : DataModel
    {
        public List<Encoding>?                          Encodings                               { get; set; }
        public XmlDictionaryReader?                     XmlReader                               { get; set; }
        public XmlDictionaryReader?                     InfosetReader                           { get; set; }
        public MimeReader?                              MimeReader                              { get; set; }
        public OnXmlDictionaryReaderClose?              OnClose                                 { get; set; }
        public bool                                     ReadingBinaryElement                    { get; set; }
        public int                                      MaxBufferSize                           { get; set; }
        public int                                      BufferRemaining                         { get; set; }
        public MimePart?                                Part                                    { get; set; }

        public static XmlMtomReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlMtomReader() { Pointer= p0 };

            value.Encodings                                 = GetObjectList<Encoding>(new IntPtr(p + 0x010), ReversePrism.DataModels.Encoding.FromPointer); // 024667CC06C0 0x10 Encodings                   ( 000185B7B270 ModelClassListType Encoding[] Encoding[] List<Encoding> Pointer )
            value.XmlReader                                 = GetObject<XmlDictionaryReader>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlDictionaryReader.FromPointer); // 024667CC06E0 0x18 XmlReader                   ( 000186593BB0 ModelClassType XmlDictionaryReader XmlDictionaryReader XmlDictionaryReader Pointer )
            value.InfosetReader                             = GetObject<XmlDictionaryReader>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlDictionaryReader.FromPointer); // 024667CC0700 0x20 InfosetReader               ( 000186593BB0 ModelClassType XmlDictionaryReader XmlDictionaryReader XmlDictionaryReader Pointer )
            value.MimeReader                                = GetObject<MimeReader>(new IntPtr(p + 0x028), ReversePrism.DataModels.MimeReader.FromPointer); // 024667CC0720 0x28 MimeReader                  ( 000186618C20 ModelClassType MimeReader MimeReader MimeReader Pointer )
            value.OnClose                                   = GetObject<OnXmlDictionaryReaderClose>(new IntPtr(p + 0x038), ReversePrism.DataModels.OnXmlDictionaryReaderClose.FromPointer); // 024667CC0760 0x38 OnClose                     ( 0001866DD0C0 ModelClassType OnXmlDictionaryReaderClose OnXmlDictionaryReaderClose OnXmlDictionaryReaderClose Pointer )
            value.ReadingBinaryElement                      = GetBool(new IntPtr(p + 0x040)); // 024667CC0780 0x40 ReadingBinaryElement        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MaxBufferSize                             = GetInt32(new IntPtr(p + 0x044)); // 024667CC07A0 0x44 MaxBufferSize               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BufferRemaining                           = GetInt32(new IntPtr(p + 0x048)); // 024667CC07C0 0x48 BufferRemaining             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Part                                      = GetObject<MimePart>(new IntPtr(p + 0x050), ReversePrism.DataModels.MimePart.FromPointer); // 024667CC07E0 0x50 Part                        ( 000186739480 ModelClassType MimePart MimePart MimePart Pointer )

            return value;
        }
    }
}
