using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 tlsContext                               IntPtr IL2CPP_TYPE_PTR
    // 060 requestedClientCertChain                 IntPtr IL2CPP_TYPE_PTR
    // 068 requestedClientKey                       IntPtr IL2CPP_TYPE_PTR
    // 070 ReadCallback                             0001866AF700 ModelClassType unitytls_tlsctx_read_callback unitytls_tlsctx_read_callback unitytls_tlsctx_read_callback Pointer
    // 078 WriteCallback                            0001866B00C0 ModelClassType unitytls_tlsctx_write_callback unitytls_tlsctx_write_callback unitytls_tlsctx_write_callback Pointer
    // 080 CertificateCallback                      0001866AED30 ModelClassType unitytls_tlsctx_certificate_callback unitytls_tlsctx_certificate_callback unitytls_tlsctx_certificate_callback Pointer
    // 088 VerifyCallback                           0001866B0850 ModelClassType unitytls_tlsctx_x509verify_callback unitytls_tlsctx_x509verify_callback unitytls_tlsctx_x509verify_callback Pointer
    // 090 LocalClientCertificate                   0001866B7D80 ModelClassType X509Certificate X509Certificate X509Certificate Pointer
    // 098 RemoteCertificate                        000186563D80 ModelClassType X509Certificate2 X509Certificate2 X509Certificate2 Pointer
    // 0A0 Connectioninfo                           00018664C970 ModelClassType MonoTlsConnectionInfo MonoTlsConnectionInfo MonoTlsConnectionInfo Pointer
    // 0A8 IsAuthenticated                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0A9 HasContext                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0AA ClosedGraceful                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0B0 WriteBuffer                              000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 0B8 ReadBuffer                               000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 0C0 Handle                                   0001865D9120 ModelEnumType GCHandle GCHandle GCHandle Int32
    // 0C8 LastException                            0001865CA820 ModelClassType Exception Exception Exception Pointer
    public partial class UnityTlsContext
    {
        public unitytls_tlsctx_read_callback?           ReadCallback                            { get; set; }
        public unitytls_tlsctx_write_callback?          WriteCallback                           { get; set; }
        public unitytls_tlsctx_certificate_callback?    CertificateCallback                     { get; set; }
        public unitytls_tlsctx_x509verify_callback?     VerifyCallback                          { get; set; }
        public X509Certificate?                         LocalClientCertificate                  { get; set; }
        public X509Certificate2?                        RemoteCertificate                       { get; set; }
        public MonoTlsConnectionInfo?                   Connectioninfo                          { get; set; }
        public bool                                     IsAuthenticated                         { get; set; }
        public bool                                     HasContext                              { get; set; }
        public bool                                     ClosedGraceful                          { get; set; }
        public List<sbyte>?                             WriteBuffer                             { get; set; }
        public List<sbyte>?                             ReadBuffer                              { get; set; }
        public GCHandle                                 Handle                                  { get; set; }
        public Exception?                               LastException                           { get; set; }

        public static UnityTlsContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnityTlsContext();

            value.ReadCallback                              = GetObject<unitytls_tlsctx_read_callback>(new IntPtr(p + 0x070), ReversePrism.DataModels.unitytls_tlsctx_read_callback.FromPointer); // 0270D78ECF50 0x70 ReadCallback                ( 0001866AF700 ModelClassType unitytls_tlsctx_read_callback unitytls_tlsctx_read_callback unitytls_tlsctx_read_callback Pointer )
            value.WriteCallback                             = GetObject<unitytls_tlsctx_write_callback>(new IntPtr(p + 0x078), ReversePrism.DataModels.unitytls_tlsctx_write_callback.FromPointer); // 0270D78ECF70 0x78 WriteCallback               ( 0001866B00C0 ModelClassType unitytls_tlsctx_write_callback unitytls_tlsctx_write_callback unitytls_tlsctx_write_callback Pointer )
            value.CertificateCallback                       = GetObject<unitytls_tlsctx_certificate_callback>(new IntPtr(p + 0x080), ReversePrism.DataModels.unitytls_tlsctx_certificate_callback.FromPointer); // 0270D78ECF90 0x80 CertificateCallback         ( 0001866AED30 ModelClassType unitytls_tlsctx_certificate_callback unitytls_tlsctx_certificate_callback unitytls_tlsctx_certificate_callback Pointer )
            value.VerifyCallback                            = GetObject<unitytls_tlsctx_x509verify_callback>(new IntPtr(p + 0x088), ReversePrism.DataModels.unitytls_tlsctx_x509verify_callback.FromPointer); // 0270D78ECFB0 0x88 VerifyCallback              ( 0001866B0850 ModelClassType unitytls_tlsctx_x509verify_callback unitytls_tlsctx_x509verify_callback unitytls_tlsctx_x509verify_callback Pointer )
            value.LocalClientCertificate                    = GetObject<X509Certificate>(new IntPtr(p + 0x090), ReversePrism.DataModels.X509Certificate.FromPointer); // 0270D78ECFD0 0x90 LocalClientCertificate      ( 0001866B7D80 ModelClassType X509Certificate X509Certificate X509Certificate Pointer )
            value.RemoteCertificate                         = GetObject<X509Certificate2>(new IntPtr(p + 0x098), ReversePrism.DataModels.X509Certificate2.FromPointer); // 0270D78ECFF0 0x98 RemoteCertificate           ( 000186563D80 ModelClassType X509Certificate2 X509Certificate2 X509Certificate2 Pointer )
            value.Connectioninfo                            = GetObject<MonoTlsConnectionInfo>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.MonoTlsConnectionInfo.FromPointer); // 0270D78ED010 0xA0 Connectioninfo              ( 00018664C970 ModelClassType MonoTlsConnectionInfo MonoTlsConnectionInfo MonoTlsConnectionInfo Pointer )
            value.IsAuthenticated                           = GetBool(new IntPtr(p + 0x0A8)); // 0270D78ED030 0xA8 IsAuthenticated             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.HasContext                                = GetBool(new IntPtr(p + 0x0A9)); // 0270D78ED050 0xA9 HasContext                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ClosedGraceful                            = GetBool(new IntPtr(p + 0x0AA)); // 0270D78ED070 0xAA ClosedGraceful              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.WriteBuffer                               = GetSByteList(new IntPtr(p + 0x0B0)); // 0270D78ED090 0xB0 WriteBuffer                 ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.ReadBuffer                                = GetSByteList(new IntPtr(p + 0x0B8)); // 0270D78ED0B0 0xB8 ReadBuffer                  ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Handle                                    = (GCHandle)GetInt32(new IntPtr(p + 0x0C0)); // 0270D78ED0D0 0xC0 Handle                      ( 0001865D9120 ModelEnumType GCHandle GCHandle GCHandle Int32 )
            value.LastException                             = GetObject<Exception>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.Exception.FromPointer); // 0270D78ED0F0 0xC8 LastException               ( 0001865CA820 ModelClassType Exception Exception Exception Pointer )

            return value;
        }
    }
}
