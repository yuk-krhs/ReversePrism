using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DelegatingHandler                        0001865BA920 ModelClassType IMonoHttpClientHandler IMonoHttpClientHandler IMonoHttpClientHandler Pointer
    // 018 ClientCertificateOptions                 0001865B5E20 ModelEnumType ClientCertificateOption ClientCertificateOption ClientCertificateOption Int32
    public partial class HttpClientHandler : DataModel
    {
        public IMonoHttpClientHandler?                  DelegatingHandler                       { get; set; }
        public ClientCertificateOption                  ClientCertificateOptions                { get; set; }

        public static HttpClientHandler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HttpClientHandler() { Pointer= p0 };

            value.DelegatingHandler                         = GetObject<IMonoHttpClientHandler>(new IntPtr(p + 0x010), ReversePrism.DataModels.IMonoHttpClientHandler.FromPointer); // 02466B896760 0x10 DelegatingHandler           ( 0001865BA920 ModelClassType IMonoHttpClientHandler IMonoHttpClientHandler IMonoHttpClientHandler Pointer )
            value.ClientCertificateOptions                  = (ClientCertificateOption)GetInt32(new IntPtr(p + 0x018)); // 02466B896780 0x18 ClientCertificateOptions    ( 0001865B5E20 ModelEnumType ClientCertificateOption ClientCertificateOption ClientCertificateOption Int32 )

            return value;
        }
    }
}
