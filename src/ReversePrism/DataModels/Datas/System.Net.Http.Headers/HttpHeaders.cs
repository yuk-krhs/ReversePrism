using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 known_headers                            Dictionary`2<string, HeaderInfo> IL2CPP_TYPE_GENERICINST
    // 010 headers                                  Dictionary`2<string, HeaderBucket> IL2CPP_TYPE_GENERICINST
    // 018 HeaderKind                               ModelEnumType HttpHeaderKind HttpHeaderKind HttpHeaderKind Int32
    // 01C connectionclose                          Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 01E transferEncodingChunked                  Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    public partial class HttpHeaders : DataModel
    {
        public HttpHeaderKind                           HeaderKind                              { get; set; }

        public static HttpHeaders? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HttpHeaders() { Pointer= p0 };

            value.HeaderKind                                = (HttpHeaderKind)GetInt32(new IntPtr(p + 0x018)); // 0x18 HeaderKind                  ( ModelEnumType HttpHeaderKind HttpHeaderKind HttpHeaderKind Int32 )

            return value;
        }
    }
}
