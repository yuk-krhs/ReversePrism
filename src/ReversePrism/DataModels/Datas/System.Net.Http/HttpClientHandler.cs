using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DelegatingHandler                        ModelClassType IMonoHttpClientHandler IMonoHttpClientHandler IMonoHttpClientHandler Pointer
    // 018 ClientCertificateOptions                 ModelEnumType ClientCertificateOption ClientCertificateOption ClientCertificateOption Int32
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

            value.DelegatingHandler                         = GetObject<IMonoHttpClientHandler>(new IntPtr(p + 0x010), ReversePrism.DataModels.IMonoHttpClientHandler.FromPointer); // 0x10 DelegatingHandler           ( ModelClassType IMonoHttpClientHandler IMonoHttpClientHandler IMonoHttpClientHandler Pointer )
            value.ClientCertificateOptions                  = (ClientCertificateOption)GetInt32(new IntPtr(p + 0x018)); // 0x18 ClientCertificateOptions    ( ModelEnumType ClientCertificateOption ClientCertificateOption ClientCertificateOption Int32 )

            return value;
        }
    }
}
