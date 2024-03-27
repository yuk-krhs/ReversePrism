using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MaxTextChunk                             int IL2CPP_TYPE_I4
    // 000 charType                                 sbyte[] IL2CPP_TYPE_SZARRAY
    // 0F8 Buffered                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 100 CharactersToSkipOnNextRead               000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 108 ComplexTextMode                          000186737A50 ModelEnumType JsonComplexTextMode JsonComplexTextMode JsonComplexTextMode Int32
    // 10C ExpectingFirstElementInNonPrimitiveChild 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 110 MaxBytesPerRead                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 118 OnReaderClose                            0001866DD0C0 ModelClassType OnXmlDictionaryReaderClose OnXmlDictionaryReaderClose OnXmlDictionaryReaderClose Pointer
    // 120 ReadServerTypeElement                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 124 ScopeDepth                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 128 Scopes                                   000185B8F180 ModelEnumListType JsonNodeType[] JsonNodeType[] List<JsonNodeType> Pointer
    public partial class XmlJsonReader
    {
        public bool                                     Buffered                                { get; set; }
        public List<sbyte>?                             CharactersToSkipOnNextRead              { get; set; }
        public JsonComplexTextMode                      ComplexTextMode                         { get; set; }
        public bool                                     ExpectingFirstElementInNonPrimitiveChild { get; set; }
        public int                                      MaxBytesPerRead                         { get; set; }
        public OnXmlDictionaryReaderClose?              OnReaderClose                           { get; set; }
        public bool                                     ReadServerTypeElement                   { get; set; }
        public int                                      ScopeDepth                              { get; set; }
        public List<JsonNodeType>?                      Scopes                                  { get; set; }

        public static XmlJsonReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlJsonReader();

            value.Buffered                                  = GetBool(new IntPtr(p + 0x0F8)); // 027004C4D9C8 0xF8 Buffered                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CharactersToSkipOnNextRead                = GetSByteList(new IntPtr(p + 0x100)); // 027004C4D9E8 0x100 CharactersToSkipOnNextRead  ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.ComplexTextMode                           = (JsonComplexTextMode)GetInt32(new IntPtr(p + 0x108)); // 027004C4DA08 0x108 ComplexTextMode             ( 000186737A50 ModelEnumType JsonComplexTextMode JsonComplexTextMode JsonComplexTextMode Int32 )
            value.ExpectingFirstElementInNonPrimitiveChild  = GetBool(new IntPtr(p + 0x10C)); // 027004C4DA28 0x10C ExpectingFirstElementInNonPrimitiveChild ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MaxBytesPerRead                           = GetInt32(new IntPtr(p + 0x110)); // 027004C4DA48 0x110 MaxBytesPerRead             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OnReaderClose                             = GetObject<OnXmlDictionaryReaderClose>(new IntPtr(p + 0x118), ReversePrism.DataModels.OnXmlDictionaryReaderClose.FromPointer); // 027004C4DA68 0x118 OnReaderClose               ( 0001866DD0C0 ModelClassType OnXmlDictionaryReaderClose OnXmlDictionaryReaderClose OnXmlDictionaryReaderClose Pointer )
            value.ReadServerTypeElement                     = GetBool(new IntPtr(p + 0x120)); // 027004C4DA88 0x120 ReadServerTypeElement       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ScopeDepth                                = GetInt32(new IntPtr(p + 0x124)); // 027004C4DAA8 0x124 ScopeDepth                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Scopes                                    = GetEnumList<JsonNodeType>(new IntPtr(p + 0x128)); // 027004C4DAC8 0x128 Scopes                      ( 000185B8F180 ModelEnumListType JsonNodeType[] JsonNodeType[] List<JsonNodeType> Pointer )

            return value;
        }
    }
}
