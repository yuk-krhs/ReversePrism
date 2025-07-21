using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Encodings                                ModelClassListType Encoding[] Encoding[] List<Encoding> Pointer
    // 018 XmlReader                                ModelClassType XmlDictionaryReader XmlDictionaryReader XmlDictionaryReader Pointer
    // 020 InfosetReader                            ModelClassType XmlDictionaryReader XmlDictionaryReader XmlDictionaryReader Pointer
    // 028 MimeReader                               ModelClassType MimeReader MimeReader MimeReader Pointer
    // 030 mimeParts                                Dictionary`2<string, MimePart> IL2CPP_TYPE_GENERICINST
    // 038 OnClose                                  ModelClassType OnXmlDictionaryReaderClose OnXmlDictionaryReaderClose OnXmlDictionaryReaderClose Pointer
    // 040 ReadingBinaryElement                     ModelPrimitiveType bool bool bool Bool
    // 044 MaxBufferSize                            ModelPrimitiveType int int int Int32
    // 048 BufferRemaining                          ModelPrimitiveType int int int Int32
    // 050 Part                                     ModelClassType MimePart MimePart MimePart Pointer
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

            value.Encodings                                 = GetObjectList<Encoding>(new IntPtr(p + 0x010), ReversePrism.DataModels.Encoding.FromPointer); // 0x10 Encodings                   ( ModelClassListType Encoding[] Encoding[] List<Encoding> Pointer )
            value.XmlReader                                 = GetObject<XmlDictionaryReader>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlDictionaryReader.FromPointer); // 0x18 XmlReader                   ( ModelClassType XmlDictionaryReader XmlDictionaryReader XmlDictionaryReader Pointer )
            value.InfosetReader                             = GetObject<XmlDictionaryReader>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlDictionaryReader.FromPointer); // 0x20 InfosetReader               ( ModelClassType XmlDictionaryReader XmlDictionaryReader XmlDictionaryReader Pointer )
            value.MimeReader                                = GetObject<MimeReader>(new IntPtr(p + 0x028), ReversePrism.DataModels.MimeReader.FromPointer); // 0x28 MimeReader                  ( ModelClassType MimeReader MimeReader MimeReader Pointer )
            value.OnClose                                   = GetObject<OnXmlDictionaryReaderClose>(new IntPtr(p + 0x038), ReversePrism.DataModels.OnXmlDictionaryReaderClose.FromPointer); // 0x38 OnClose                     ( ModelClassType OnXmlDictionaryReaderClose OnXmlDictionaryReaderClose OnXmlDictionaryReaderClose Pointer )
            value.ReadingBinaryElement                      = GetBool(new IntPtr(p + 0x040)); // 0x40 ReadingBinaryElement        ( ModelPrimitiveType bool bool bool Bool )
            value.MaxBufferSize                             = GetInt32(new IntPtr(p + 0x044)); // 0x44 MaxBufferSize               ( ModelPrimitiveType int int int Int32 )
            value.BufferRemaining                           = GetInt32(new IntPtr(p + 0x048)); // 0x48 BufferRemaining             ( ModelPrimitiveType int int int Int32 )
            value.Part                                      = GetObject<MimePart>(new IntPtr(p + 0x050), ReversePrism.DataModels.MimePart.FromPointer); // 0x50 Part                        ( ModelClassType MimePart MimePart MimePart Pointer )

            return value;
        }
    }
}
