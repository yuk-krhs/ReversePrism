using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 keyCertificatePairs                      IList`1<KeyCertificatePair> IL2CPP_TYPE_GENERICINST
    // 018 RootCertificates                         000186672F10 ModelPrimitiveType string string string String
    // 020 ClientCertificateRequest                 00018655C8B0 ModelEnumType SslClientCertificateRequestType SslClientCertificateRequestType SslClientCertificateRequestType Int32
    public partial class SslServerCredentials
    {
        public string                                   RootCertificates                        { get; set; }
        public SslClientCertificateRequestType          ClientCertificateRequest                { get; set; }

        public static SslServerCredentials? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SslServerCredentials();

            value.RootCertificates                          = GetString(new IntPtr(p + 0x018)); // 0270D937EED8 0x18 RootCertificates            ( 000186672F10 ModelPrimitiveType string string string String )
            value.ClientCertificateRequest                  = (SslClientCertificateRequestType)GetInt32(new IntPtr(p + 0x020)); // 0270D937EEF8 0x20 ClientCertificateRequest    ( 00018655C8B0 ModelEnumType SslClientCertificateRequestType SslClientCertificateRequestType SslClientCertificateRequestType Int32 )

            return value;
        }
    }
}
