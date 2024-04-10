using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0B0 X509                                     000186642C00 ModelClassType MonoBtlsX509 MonoBtlsX509 MonoBtlsX509 Pointer
    // 0B8 NativePrivateKey                         00018663F7F0 ModelClassType MonoBtlsKey MonoBtlsKey MonoBtlsKey Pointer
    // 0C0 IntermediateCerts                        000186566880 ModelClassType X509CertificateImplCollection X509CertificateImplCollection X509CertificateImplCollection Pointer
    public partial class X509CertificateImplBtls : DataModel
    {
        public MonoBtlsX509?                            X509                                    { get; set; }
        public MonoBtlsKey?                             NativePrivateKey                        { get; set; }
        public X509CertificateImplCollection?           IntermediateCerts                       { get; set; }

        public static X509CertificateImplBtls? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new X509CertificateImplBtls() { Pointer= p0 };

            value.X509                                      = GetObject<MonoBtlsX509>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.MonoBtlsX509.FromPointer); // 0246679A8C80 0xB0 X509                        ( 000186642C00 ModelClassType MonoBtlsX509 MonoBtlsX509 MonoBtlsX509 Pointer )
            value.NativePrivateKey                          = GetObject<MonoBtlsKey>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.MonoBtlsKey.FromPointer); // 0246679A8CA0 0xB8 NativePrivateKey            ( 00018663F7F0 ModelClassType MonoBtlsKey MonoBtlsKey MonoBtlsKey Pointer )
            value.IntermediateCerts                         = GetObject<X509CertificateImplCollection>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.X509CertificateImplCollection.FromPointer); // 0246679A8CC0 0xC0 IntermediateCerts           ( 000186566880 ModelClassType X509CertificateImplCollection X509CertificateImplCollection X509CertificateImplCollection Pointer )

            return value;
        }
    }
}
