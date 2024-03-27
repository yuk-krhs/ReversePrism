using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MaxTextChunk                             int IL2CPP_TYPE_I4
    // 0F8 Prefix                                   000186775C20 ModelClassType PrefixHandle PrefixHandle PrefixHandle Pointer
    // 100 LocalName                                0001865BFE90 ModelClassType StringHandle StringHandle StringHandle Pointer
    // 108 RowOffsets                               000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 110 OnClose                                  0001866DD0C0 ModelClassType OnXmlDictionaryReaderClose OnXmlDictionaryReaderClose OnXmlDictionaryReaderClose Pointer
    // 118 Buffered                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 11C MaxBytesPerRead                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 charType                                 sbyte[] IL2CPP_TYPE_SZARRAY
    public partial class XmlUTF8TextReader
    {
        public PrefixHandle?                            Prefix                                  { get; set; }
        public StringHandle?                            LocalName                               { get; set; }
        public List<int>?                               RowOffsets                              { get; set; }
        public OnXmlDictionaryReaderClose?              OnClose                                 { get; set; }
        public bool                                     Buffered                                { get; set; }
        public int                                      MaxBytesPerRead                         { get; set; }

        public static XmlUTF8TextReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlUTF8TextReader();

            value.Prefix                                    = GetObject<PrefixHandle>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.PrefixHandle.FromPointer); // 0270D7CB3570 0xF8 Prefix                      ( 000186775C20 ModelClassType PrefixHandle PrefixHandle PrefixHandle Pointer )
            value.LocalName                                 = GetObject<StringHandle>(new IntPtr(p + 0x100), ReversePrism.DataModels.StringHandle.FromPointer); // 0270D7CB3590 0x100 LocalName                   ( 0001865BFE90 ModelClassType StringHandle StringHandle StringHandle Pointer )
            value.RowOffsets                                = GetInt32List(new IntPtr(p + 0x108)); // 0270D7CB35B0 0x108 RowOffsets                  ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.OnClose                                   = GetObject<OnXmlDictionaryReaderClose>(new IntPtr(p + 0x110), ReversePrism.DataModels.OnXmlDictionaryReaderClose.FromPointer); // 0270D7CB35D0 0x110 OnClose                     ( 0001866DD0C0 ModelClassType OnXmlDictionaryReaderClose OnXmlDictionaryReaderClose OnXmlDictionaryReaderClose Pointer )
            value.Buffered                                  = GetBool(new IntPtr(p + 0x118)); // 0270D7CB35F0 0x118 Buffered                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MaxBytesPerRead                           = GetInt32(new IntPtr(p + 0x11C)); // 0270D7CB3610 0x11C MaxBytesPerRead             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
