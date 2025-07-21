using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0F8 IsTextWithEndElement                     ModelPrimitiveType bool bool bool Bool
    // 0F9 Buffered                                 ModelPrimitiveType bool bool bool Bool
    // 0FC ArrayState                               ModelEnumType ArrayState ArrayState ArrayState Int32
    // 100 ArrayCount                               ModelPrimitiveType int int int Int32
    // 104 MaxBytesPerRead                          ModelPrimitiveType int int int Int32
    // 108 ArrayNodeType                            ModelEnumType XmlBinaryNodeType XmlBinaryNodeType XmlBinaryNodeType Int32
    // 110 OnClose                                  ModelClassType OnXmlDictionaryReaderClose OnXmlDictionaryReaderClose OnXmlDictionaryReaderClose Pointer
    public partial class XmlBinaryReader : DataModel
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
            var value   = new XmlBinaryReader() { Pointer= p0 };

            value.IsTextWithEndElement                      = GetBool(new IntPtr(p + 0x0F8)); // 0xF8 IsTextWithEndElement        ( ModelPrimitiveType bool bool bool Bool )
            value.Buffered                                  = GetBool(new IntPtr(p + 0x0F9)); // 0xF9 Buffered                    ( ModelPrimitiveType bool bool bool Bool )
            value.ArrayState                                = (ArrayState)GetInt32(new IntPtr(p + 0x0FC)); // 0xFC ArrayState                  ( ModelEnumType ArrayState ArrayState ArrayState Int32 )
            value.ArrayCount                                = GetInt32(new IntPtr(p + 0x100)); // 0x100 ArrayCount                  ( ModelPrimitiveType int int int Int32 )
            value.MaxBytesPerRead                           = GetInt32(new IntPtr(p + 0x104)); // 0x104 MaxBytesPerRead             ( ModelPrimitiveType int int int Int32 )
            value.ArrayNodeType                             = (XmlBinaryNodeType)GetInt32(new IntPtr(p + 0x108)); // 0x108 ArrayNodeType               ( ModelEnumType XmlBinaryNodeType XmlBinaryNodeType XmlBinaryNodeType Int32 )
            value.OnClose                                   = GetObject<OnXmlDictionaryReaderClose>(new IntPtr(p + 0x110), ReversePrism.DataModels.OnXmlDictionaryReaderClose.FromPointer); // 0x110 OnClose                     ( ModelClassType OnXmlDictionaryReaderClose OnXmlDictionaryReaderClose OnXmlDictionaryReaderClose Pointer )

            return value;
        }
    }
}
