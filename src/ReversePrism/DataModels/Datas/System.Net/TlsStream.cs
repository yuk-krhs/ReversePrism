using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 048 SslStream                                00018655DF50 ModelClassType SslStream SslStream SslStream Pointer
    // 050 Host                                     000186671910 ModelPrimitiveType string string string String
    // 058 ClientCertificates                       0001865656A0 ModelClassType X509CertificateCollection X509CertificateCollection X509CertificateCollection Pointer
    public partial class TlsStream
    {
        public SslStream?                               SslStream                               { get; set; }
        public string                                   Host                                    { get; set; }
        public X509CertificateCollection?               ClientCertificates                      { get; set; }

        public static TlsStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TlsStream();

            value.SslStream                                 = GetObject<SslStream>(new IntPtr(p + 0x048), ReversePrism.DataModels.SslStream.FromPointer); // 0270D7A09808 0x48 SslStream                   ( 00018655DF50 ModelClassType SslStream SslStream SslStream Pointer )
            value.Host                                      = GetString(new IntPtr(p + 0x050)); // 0270D7A09828 0x50 Host                        ( 000186671910 ModelPrimitiveType string string string String )
            value.ClientCertificates                        = GetObject<X509CertificateCollection>(new IntPtr(p + 0x058), ReversePrism.DataModels.X509CertificateCollection.FromPointer); // 0270D7A09848 0x58 ClientCertificates          ( 0001865656A0 ModelClassType X509CertificateCollection X509CertificateCollection X509CertificateCollection Pointer )

            return value;
        }
    }
}
