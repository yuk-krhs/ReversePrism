using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MaxDateTimeChars                         int IL2CPP_TYPE_I4
    // 000 MaxInt32Chars                            int IL2CPP_TYPE_I4
    // 000 MaxInt64Chars                            int IL2CPP_TYPE_I4
    // 000 MaxBoolChars                             int IL2CPP_TYPE_I4
    // 000 MaxFloatChars                            int IL2CPP_TYPE_I4
    // 000 MaxDoubleChars                           int IL2CPP_TYPE_I4
    // 000 MaxDecimalChars                          int IL2CPP_TYPE_I4
    // 000 MaxUInt64Chars                           int IL2CPP_TYPE_I4
    // 000 MaxPrimitiveChars                        int IL2CPP_TYPE_I4
    // 000 whiteSpaceChars                          char[] IL2CPP_TYPE_SZARRAY
    // 008 utf8Encoding                             UTF8Encoding IL2CPP_TYPE_CLASS
    // 010 UnicodeEncoding                          ModelClassType UnicodeEncoding UnicodeEncoding UnicodeEncoding Pointer
    // 018 Base64Encoding                           ModelClassType Base64Encoding Base64Encoding Base64Encoding Pointer
    public partial class XmlConverter : DataModel
    {
        public UnicodeEncoding?                         UnicodeEncoding                         { get; set; }
        public Base64Encoding?                          Base64Encoding                          { get; set; }

        public static XmlConverter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlConverter() { Pointer= p0 };

            value.UnicodeEncoding                           = GetObject<UnicodeEncoding>(new IntPtr(p + 0x010), ReversePrism.DataModels.UnicodeEncoding.FromPointer); // 0x10 UnicodeEncoding             ( ModelClassType UnicodeEncoding UnicodeEncoding UnicodeEncoding Pointer )
            value.Base64Encoding                            = GetObject<Base64Encoding>(new IntPtr(p + 0x018), ReversePrism.DataModels.Base64Encoding.FromPointer); // 0x18 Base64Encoding              ( ModelClassType Base64Encoding Base64Encoding Base64Encoding Pointer )

            return value;
        }
    }
}
