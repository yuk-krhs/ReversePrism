using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MaxTextChunk                             int IL2CPP_TYPE_I4
    // 0F8 Prefix                                   ModelClassType PrefixHandle PrefixHandle PrefixHandle Pointer
    // 100 LocalName                                ModelClassType StringHandle StringHandle StringHandle Pointer
    // 108 RowOffsets                               ModelPrimitiveListType int[] int[] List<int> Pointer
    // 110 OnClose                                  ModelClassType OnXmlDictionaryReaderClose OnXmlDictionaryReaderClose OnXmlDictionaryReaderClose Pointer
    // 118 Buffered                                 ModelPrimitiveType bool bool bool Bool
    // 11C MaxBytesPerRead                          ModelPrimitiveType int int int Int32
    // 000 charType                                 sbyte[] IL2CPP_TYPE_SZARRAY
    public partial class XmlUTF8TextReader : DataModel
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
            var value   = new XmlUTF8TextReader() { Pointer= p0 };

            value.Prefix                                    = GetObject<PrefixHandle>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.PrefixHandle.FromPointer); // 0xF8 Prefix                      ( ModelClassType PrefixHandle PrefixHandle PrefixHandle Pointer )
            value.LocalName                                 = GetObject<StringHandle>(new IntPtr(p + 0x100), ReversePrism.DataModels.StringHandle.FromPointer); // 0x100 LocalName                   ( ModelClassType StringHandle StringHandle StringHandle Pointer )
            value.RowOffsets                                = GetInt32List(new IntPtr(p + 0x108)); // 0x108 RowOffsets                  ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.OnClose                                   = GetObject<OnXmlDictionaryReaderClose>(new IntPtr(p + 0x110), ReversePrism.DataModels.OnXmlDictionaryReaderClose.FromPointer); // 0x110 OnClose                     ( ModelClassType OnXmlDictionaryReaderClose OnXmlDictionaryReaderClose OnXmlDictionaryReaderClose Pointer )
            value.Buffered                                  = GetBool(new IntPtr(p + 0x118)); // 0x118 Buffered                    ( ModelPrimitiveType bool bool bool Bool )
            value.MaxBytesPerRead                           = GetInt32(new IntPtr(p + 0x11C)); // 0x11C MaxBytesPerRead             ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
