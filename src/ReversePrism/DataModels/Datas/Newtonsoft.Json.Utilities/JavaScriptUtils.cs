using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 SingleQuoteCharEscapeFlags               bool[] IL2CPP_TYPE_SZARRAY
    // 008 DoubleQuoteCharEscapeFlags               bool[] IL2CPP_TYPE_SZARRAY
    // 010 HtmlCharEscapeFlags                      000185B791B0 ModelPrimitiveListType bool[] bool[] List<bool> Pointer
    // 000 UnicodeTextLength                        int IL2CPP_TYPE_I4
    // 000 EscapedUnicodeText                       string IL2CPP_TYPE_STRING
    public partial class JavaScriptUtils : DataModel
    {
        public List<bool>?                              HtmlCharEscapeFlags                     { get; set; }

        public static JavaScriptUtils? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JavaScriptUtils() { Pointer= p0 };

            value.HtmlCharEscapeFlags                       = GetBoolList(new IntPtr(p + 0x010)); // 0245A6072D88 0x10 HtmlCharEscapeFlags         ( 000185B791B0 ModelPrimitiveListType bool[] bool[] List<bool> Pointer )

            return value;
        }
    }
}
