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
    // 0F8 Buffered                                 ModelPrimitiveType bool bool bool Bool
    // 100 CharactersToSkipOnNextRead               ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 108 ComplexTextMode                          ModelEnumType JsonComplexTextMode JsonComplexTextMode JsonComplexTextMode Int32
    // 10C ExpectingFirstElementInNonPrimitiveChild ModelPrimitiveType bool bool bool Bool
    // 110 MaxBytesPerRead                          ModelPrimitiveType int int int Int32
    // 118 OnReaderClose                            ModelClassType OnXmlDictionaryReaderClose OnXmlDictionaryReaderClose OnXmlDictionaryReaderClose Pointer
    // 120 ReadServerTypeElement                    ModelPrimitiveType bool bool bool Bool
    // 124 ScopeDepth                               ModelPrimitiveType int int int Int32
    // 128 Scopes                                   ModelEnumListType JsonNodeType[] JsonNodeType[] List<JsonNodeType> Pointer
    public partial class XmlJsonReader : DataModel
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
            var value   = new XmlJsonReader() { Pointer= p0 };

            value.Buffered                                  = GetBool(new IntPtr(p + 0x0F8)); // 0xF8 Buffered                    ( ModelPrimitiveType bool bool bool Bool )
            value.CharactersToSkipOnNextRead                = GetSByteList(new IntPtr(p + 0x100)); // 0x100 CharactersToSkipOnNextRead  ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.ComplexTextMode                           = (JsonComplexTextMode)GetInt32(new IntPtr(p + 0x108)); // 0x108 ComplexTextMode             ( ModelEnumType JsonComplexTextMode JsonComplexTextMode JsonComplexTextMode Int32 )
            value.ExpectingFirstElementInNonPrimitiveChild  = GetBool(new IntPtr(p + 0x10C)); // 0x10C ExpectingFirstElementInNonPrimitiveChild ( ModelPrimitiveType bool bool bool Bool )
            value.MaxBytesPerRead                           = GetInt32(new IntPtr(p + 0x110)); // 0x110 MaxBytesPerRead             ( ModelPrimitiveType int int int Int32 )
            value.OnReaderClose                             = GetObject<OnXmlDictionaryReaderClose>(new IntPtr(p + 0x118), ReversePrism.DataModels.OnXmlDictionaryReaderClose.FromPointer); // 0x118 OnReaderClose               ( ModelClassType OnXmlDictionaryReaderClose OnXmlDictionaryReaderClose OnXmlDictionaryReaderClose Pointer )
            value.ReadServerTypeElement                     = GetBool(new IntPtr(p + 0x120)); // 0x120 ReadServerTypeElement       ( ModelPrimitiveType bool bool bool Bool )
            value.ScopeDepth                                = GetInt32(new IntPtr(p + 0x124)); // 0x124 ScopeDepth                  ( ModelPrimitiveType int int int Int32 )
            value.Scopes                                    = GetEnumList<JsonNodeType>(new IntPtr(p + 0x128)); // 0x128 Scopes                      ( ModelEnumListType JsonNodeType[] JsonNodeType[] List<JsonNodeType> Pointer )

            return value;
        }
    }
}
