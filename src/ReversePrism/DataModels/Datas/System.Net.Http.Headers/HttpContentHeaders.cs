using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Content                                  0001866DD990 ModelClassType HttpContent HttpContent HttpContent Pointer
    public partial class HttpContentHeaders
    {
        public HttpContent?                             Content                                 { get; set; }

        public static HttpContentHeaders? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HttpContentHeaders();

            value.Content                                   = GetObject<HttpContent>(new IntPtr(p + 0x020), ReversePrism.DataModels.HttpContent.FromPointer); // 0270DB82D3A8 0x20 Content                     ( 0001866DD990 ModelClassType HttpContent HttpContent HttpContent Pointer )

            return value;
        }
    }
}
