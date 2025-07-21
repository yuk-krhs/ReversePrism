using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Content                                  ModelClassType HttpContent HttpContent HttpContent Pointer
    public partial class HttpContentHeaders : DataModel
    {
        public HttpContent?                             Content                                 { get; set; }

        public static HttpContentHeaders? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HttpContentHeaders() { Pointer= p0 };

            value.Content                                   = GetObject<HttpContent>(new IntPtr(p + 0x020), ReversePrism.DataModels.HttpContent.FromPointer); // 0x20 Content                     ( ModelClassType HttpContent HttpContent HttpContent Pointer )

            return value;
        }
    }
}
