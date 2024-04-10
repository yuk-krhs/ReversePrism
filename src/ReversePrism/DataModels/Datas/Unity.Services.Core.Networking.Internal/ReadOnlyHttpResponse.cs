using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Response                               0001866E3620 ModelClassType HttpResponse HttpResponse HttpResponse Pointer
    public partial class ReadOnlyHttpResponse : DataModel
    {
        public HttpResponse?                            M_Response                              { get; set; }

        public static ReadOnlyHttpResponse? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReadOnlyHttpResponse() { Pointer= p0 };

            value.M_Response                                = GetObject<HttpResponse>(new IntPtr(p + 0x010), ReversePrism.DataModels.HttpResponse.FromPointer); // 02466BAE5338 0x10 M_Response                  ( 0001866E3620 ModelClassType HttpResponse HttpResponse HttpResponse Pointer )

            return value;
        }
    }
}
