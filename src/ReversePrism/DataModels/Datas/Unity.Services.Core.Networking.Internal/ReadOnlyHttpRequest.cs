using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Request                                0001866E1900 ModelClassType HttpRequest HttpRequest HttpRequest Pointer
    public partial class ReadOnlyHttpRequest
    {
        public HttpRequest?                             M_Request                               { get; set; }

        public static ReadOnlyHttpRequest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReadOnlyHttpRequest();

            value.M_Request                                 = GetObject<HttpRequest>(new IntPtr(p + 0x010), ReversePrism.DataModels.HttpRequest.FromPointer); // 0270DBA5CD18 0x10 M_Request                   ( 0001866E1900 ModelClassType HttpRequest HttpRequest HttpRequest Pointer )

            return value;
        }
    }
}
