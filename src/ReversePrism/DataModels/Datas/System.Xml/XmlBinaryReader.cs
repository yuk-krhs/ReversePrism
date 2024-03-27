using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0F8 IsTextWithEndElement                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0F9 Buffered                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0FC ArrayState                               000186730000 ModelEnumType ArrayState ArrayState ArrayState Int32
    // 100 ArrayCount                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 104 MaxBytesPerRead                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 108 ArrayNodeType                            00018658C4F0 ModelEnumType XmlBinaryNodeType XmlBinaryNodeType XmlBinaryNodeType Int32
    // 110 OnClose                                  0001866DD0C0 ModelClassType OnXmlDictionaryReaderClose OnXmlDictionaryReaderClose OnXmlDictionaryReaderClose Pointer
    public partial class XmlBinaryReader
    {
        public bool                                     IsTextWithEndElement                    { get; set; }
        public bool                                     Buffered                                { get; set; }
        public ArrayState                               ArrayState                              { get; set; }
        public int                                      ArrayCount                              { get; set; }
        public int                                      MaxBytesPerRead                         { get; set; }
        public XmlBinaryNodeType                        ArrayNodeType                           { get; set; }
        public OnXmlDictionaryReaderClose?              OnClose                                 { get; set; }

        public static XmlBinaryReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlBinaryReader();

            value.IsTextWithEndElement                      = GetBool(new IntPtr(p + 0x0F8)); // 0270D7C3C360 0xF8 IsTextWithEndElement        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Buffered                                  = GetBool(new IntPtr(p + 0x0F9)); // 0270D7C3C380 0xF9 Buffered                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ArrayState                                = (ArrayState)GetInt32(new IntPtr(p + 0x0FC)); // 0270D7C3C3A0 0xFC ArrayState                  ( 000186730000 ModelEnumType ArrayState ArrayState ArrayState Int32 )
            value.ArrayCount                                = GetInt32(new IntPtr(p + 0x100)); // 0270D7C3C3C0 0x100 ArrayCount                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MaxBytesPerRead                           = GetInt32(new IntPtr(p + 0x104)); // 0270D7C3C3E0 0x104 MaxBytesPerRead             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ArrayNodeType                             = (XmlBinaryNodeType)GetInt32(new IntPtr(p + 0x108)); // 0270D7C3C400 0x108 ArrayNodeType               ( 00018658C4F0 ModelEnumType XmlBinaryNodeType XmlBinaryNodeType XmlBinaryNodeType Int32 )
            value.OnClose                                   = GetObject<OnXmlDictionaryReaderClose>(new IntPtr(p + 0x110), ReversePrism.DataModels.OnXmlDictionaryReaderClose.FromPointer); // 0270D7C3C420 0x110 OnClose                     ( 0001866DD0C0 ModelClassType OnXmlDictionaryReaderClose OnXmlDictionaryReaderClose OnXmlDictionaryReaderClose Pointer )

            return value;
        }
    }
}
