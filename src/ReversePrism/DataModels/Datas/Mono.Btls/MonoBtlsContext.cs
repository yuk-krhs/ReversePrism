using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 RemoteCertificate                        ModelClassType X509Certificate2 X509Certificate2 X509Certificate2 Pointer
    // 060 ClientCertificate                        ModelClassType X509Certificate X509Certificate X509Certificate Pointer
    // 068 NativeServerCertificate                  ModelClassType X509CertificateImplBtls X509CertificateImplBtls X509CertificateImplBtls Pointer
    // 070 NativeClientCertificate                  ModelClassType X509CertificateImplBtls X509CertificateImplBtls X509CertificateImplBtls Pointer
    // 078 Ctx                                      ModelClassType MonoBtlsSslCtx MonoBtlsSslCtx MonoBtlsSslCtx Pointer
    // 080 Ssl                                      ModelClassType MonoBtlsSsl MonoBtlsSsl MonoBtlsSsl Pointer
    // 088 Bio                                      ModelClassType MonoBtlsBio MonoBtlsBio MonoBtlsBio Pointer
    // 090 Errbio                                   ModelClassType MonoBtlsBio MonoBtlsBio MonoBtlsBio Pointer
    // 098 ConnectionInfo                           ModelClassType MonoTlsConnectionInfo MonoTlsConnectionInfo MonoTlsConnectionInfo Pointer
    // 0A0 CertificateValidated                     ModelPrimitiveType bool bool bool Bool
    // 0A1 IsAuthenticated                          ModelPrimitiveType bool bool bool Bool
    // 0A2 Connected                                ModelPrimitiveType bool bool bool Bool
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

            value.RemoteCertificate                         = GetObject<X509Certificate2>(new IntPtr(p + 0x058), ReversePrism.DataModels.X509Certificate2.FromPointer); // 0x58 RemoteCertificate           ( ModelClassType X509Certificate2 X509Certificate2 X509Certificate2 Pointer )
            value.ClientCertificate                         = GetObject<X509Certificate>(new IntPtr(p + 0x060), ReversePrism.DataModels.X509Certificate.FromPointer); // 0x60 ClientCertificate           ( ModelClassType X509Certificate X509Certificate X509Certificate Pointer )
            value.NativeServerCertificate                   = GetObject<X509CertificateImplBtls>(new IntPtr(p + 0x068), ReversePrism.DataModels.X509CertificateImplBtls.FromPointer); // 0x68 NativeServerCertificate     ( ModelClassType X509CertificateImplBtls X509CertificateImplBtls X509CertificateImplBtls Pointer )
            value.NativeClientCertificate                   = GetObject<X509CertificateImplBtls>(new IntPtr(p + 0x070), ReversePrism.DataModels.X509CertificateImplBtls.FromPointer); // 0x70 NativeClientCertificate     ( ModelClassType X509CertificateImplBtls X509CertificateImplBtls X509CertificateImplBtls Pointer )
            value.Ctx                                       = GetObject<MonoBtlsSslCtx>(new IntPtr(p + 0x078), ReversePrism.DataModels.MonoBtlsSslCtx.FromPointer); // 0x78 Ctx                         ( ModelClassType MonoBtlsSslCtx MonoBtlsSslCtx MonoBtlsSslCtx Pointer )
            value.Ssl                                       = GetObject<MonoBtlsSsl>(new IntPtr(p + 0x080), ReversePrism.DataModels.MonoBtlsSsl.FromPointer); // 0x80 Ssl                         ( ModelClassType MonoBtlsSsl MonoBtlsSsl MonoBtlsSsl Pointer )
            value.Bio                                       = GetObject<MonoBtlsBio>(new IntPtr(p + 0x088), ReversePrism.DataModels.MonoBtlsBio.FromPointer); // 0x88 Bio                         ( ModelClassType MonoBtlsBio MonoBtlsBio MonoBtlsBio Pointer )
            value.Errbio                                    = GetObject<MonoBtlsBio>(new IntPtr(p + 0x090), ReversePrism.DataModels.MonoBtlsBio.FromPointer); // 0x90 Errbio                      ( ModelClassType MonoBtlsBio MonoBtlsBio MonoBtlsBio Pointer )
            value.ConnectionInfo                            = GetObject<MonoTlsConnectionInfo>(new IntPtr(p + 0x098), ReversePrism.DataModels.MonoTlsConnectionInfo.FromPointer); // 0x98 ConnectionInfo              ( ModelClassType MonoTlsConnectionInfo MonoTlsConnectionInfo MonoTlsConnectionInfo Pointer )
            value.CertificateValidated                      = GetBool(new IntPtr(p + 0x0A0)); // 0xA0 CertificateValidated        ( ModelPrimitiveType bool bool bool Bool )
            value.IsAuthenticated                           = GetBool(new IntPtr(p + 0x0A1)); // 0xA1 IsAuthenticated             ( ModelPrimitiveType bool bool bool Bool )
            value.Connected                                 = GetBool(new IntPtr(p + 0x0A2)); // 0xA2 Connected                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
