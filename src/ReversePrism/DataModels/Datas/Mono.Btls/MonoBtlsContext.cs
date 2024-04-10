using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 RemoteCertificate                        000186563D80 ModelClassType X509Certificate2 X509Certificate2 X509Certificate2 Pointer
    // 060 ClientCertificate                        0001866B7D80 ModelClassType X509Certificate X509Certificate X509Certificate Pointer
    // 068 NativeServerCertificate                  000186566340 ModelClassType X509CertificateImplBtls X509CertificateImplBtls X509CertificateImplBtls Pointer
    // 070 NativeClientCertificate                  000186566340 ModelClassType X509CertificateImplBtls X509CertificateImplBtls X509CertificateImplBtls Pointer
    // 078 Ctx                                      000186641550 ModelClassType MonoBtlsSslCtx MonoBtlsSslCtx MonoBtlsSslCtx Pointer
    // 080 Ssl                                      000186641080 ModelClassType MonoBtlsSsl MonoBtlsSsl MonoBtlsSsl Pointer
    // 088 Bio                                      00018663E6E0 ModelClassType MonoBtlsBio MonoBtlsBio MonoBtlsBio Pointer
    // 090 Errbio                                   00018663E6E0 ModelClassType MonoBtlsBio MonoBtlsBio MonoBtlsBio Pointer
    // 098 ConnectionInfo                           00018664C970 ModelClassType MonoTlsConnectionInfo MonoTlsConnectionInfo MonoTlsConnectionInfo Pointer
    // 0A0 CertificateValidated                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0A1 IsAuthenticated                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0A2 Connected                                000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class MonoBtlsContext : DataModel
    {
        public X509Certificate2?                        RemoteCertificate                       { get; set; }
        public X509Certificate?                         ClientCertificate                       { get; set; }
        public X509CertificateImplBtls?                 NativeServerCertificate                 { get; set; }
        public X509CertificateImplBtls?                 NativeClientCertificate                 { get; set; }
        public MonoBtlsSslCtx?                          Ctx                                     { get; set; }
        public MonoBtlsSsl?                             Ssl                                     { get; set; }
        public MonoBtlsBio?                             Bio                                     { get; set; }
        public MonoBtlsBio?                             Errbio                                  { get; set; }
        public MonoTlsConnectionInfo?                   ConnectionInfo                          { get; set; }
        public bool                                     CertificateValidated                    { get; set; }
        public bool                                     IsAuthenticated                         { get; set; }
        public bool                                     Connected                               { get; set; }

        public static MonoBtlsContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MonoBtlsContext() { Pointer= p0 };

            value.RemoteCertificate                         = GetObject<X509Certificate2>(new IntPtr(p + 0x058), ReversePrism.DataModels.X509Certificate2.FromPointer); // 0246679A7310 0x58 RemoteCertificate           ( 000186563D80 ModelClassType X509Certificate2 X509Certificate2 X509Certificate2 Pointer )
            value.ClientCertificate                         = GetObject<X509Certificate>(new IntPtr(p + 0x060), ReversePrism.DataModels.X509Certificate.FromPointer); // 0246679A7330 0x60 ClientCertificate           ( 0001866B7D80 ModelClassType X509Certificate X509Certificate X509Certificate Pointer )
            value.NativeServerCertificate                   = GetObject<X509CertificateImplBtls>(new IntPtr(p + 0x068), ReversePrism.DataModels.X509CertificateImplBtls.FromPointer); // 0246679A7350 0x68 NativeServerCertificate     ( 000186566340 ModelClassType X509CertificateImplBtls X509CertificateImplBtls X509CertificateImplBtls Pointer )
            value.NativeClientCertificate                   = GetObject<X509CertificateImplBtls>(new IntPtr(p + 0x070), ReversePrism.DataModels.X509CertificateImplBtls.FromPointer); // 0246679A7370 0x70 NativeClientCertificate     ( 000186566340 ModelClassType X509CertificateImplBtls X509CertificateImplBtls X509CertificateImplBtls Pointer )
            value.Ctx                                       = GetObject<MonoBtlsSslCtx>(new IntPtr(p + 0x078), ReversePrism.DataModels.MonoBtlsSslCtx.FromPointer); // 0246679A7390 0x78 Ctx                         ( 000186641550 ModelClassType MonoBtlsSslCtx MonoBtlsSslCtx MonoBtlsSslCtx Pointer )
            value.Ssl                                       = GetObject<MonoBtlsSsl>(new IntPtr(p + 0x080), ReversePrism.DataModels.MonoBtlsSsl.FromPointer); // 0246679A73B0 0x80 Ssl                         ( 000186641080 ModelClassType MonoBtlsSsl MonoBtlsSsl MonoBtlsSsl Pointer )
            value.Bio                                       = GetObject<MonoBtlsBio>(new IntPtr(p + 0x088), ReversePrism.DataModels.MonoBtlsBio.FromPointer); // 0246679A73D0 0x88 Bio                         ( 00018663E6E0 ModelClassType MonoBtlsBio MonoBtlsBio MonoBtlsBio Pointer )
            value.Errbio                                    = GetObject<MonoBtlsBio>(new IntPtr(p + 0x090), ReversePrism.DataModels.MonoBtlsBio.FromPointer); // 0246679A73F0 0x90 Errbio                      ( 00018663E6E0 ModelClassType MonoBtlsBio MonoBtlsBio MonoBtlsBio Pointer )
            value.ConnectionInfo                            = GetObject<MonoTlsConnectionInfo>(new IntPtr(p + 0x098), ReversePrism.DataModels.MonoTlsConnectionInfo.FromPointer); // 0246679A7410 0x98 ConnectionInfo              ( 00018664C970 ModelClassType MonoTlsConnectionInfo MonoTlsConnectionInfo MonoTlsConnectionInfo Pointer )
            value.CertificateValidated                      = GetBool(new IntPtr(p + 0x0A0)); // 0246679A7430 0xA0 CertificateValidated        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsAuthenticated                           = GetBool(new IntPtr(p + 0x0A1)); // 0246679A7450 0xA1 IsAuthenticated             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Connected                                 = GetBool(new IntPtr(p + 0x0A2)); // 0246679A7470 0xA2 Connected                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
