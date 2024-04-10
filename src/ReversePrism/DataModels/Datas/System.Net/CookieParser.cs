using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_tokenizer                              00018661FCB0 ModelClassType CookieTokenizer CookieTokenizer CookieTokenizer Pointer
    public partial class CookieParser : DataModel
    {
        public CookieTokenizer?                         M_tokenizer                             { get; set; }

        public static CookieParser? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CookieParser() { Pointer= p0 };

            value.M_tokenizer                               = GetObject<CookieTokenizer>(new IntPtr(p + 0x010), ReversePrism.DataModels.CookieTokenizer.FromPointer); // 024667A962C8 0x10 M_tokenizer                 ( 00018661FCB0 ModelClassType CookieTokenizer CookieTokenizer CookieTokenizer Pointer )

            return value;
        }
    }
}
