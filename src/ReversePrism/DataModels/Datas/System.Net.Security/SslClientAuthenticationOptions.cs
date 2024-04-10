using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EncryptionPolicy                         00018672FD10 ModelEnumType EncryptionPolicy EncryptionPolicy EncryptionPolicy Int32
    // 014 CheckCertificateRevocation               00018656F3E0 ModelEnumType X509RevocationMode X509RevocationMode X509RevocationMode Int32
    // 018 EnabledSslProtocols                      00018655D2F0 ModelEnumType SslProtocols SslProtocols SslProtocols Int32
    // 01C AllowRenegotiation                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 020 LocalCertificateSelectionCallback        0001865A2C80 ModelClassType LocalCertificateSelectionCallback LocalCertificateSelectionCallback LocalCertificateSelectionCallback Pointer
    // 028 TargetHost                               000186671910 ModelPrimitiveType string string string String
    // 030 ClientCertificates                       0001865656A0 ModelClassType X509CertificateCollection X509CertificateCollection X509CertificateCollection Pointer
    public partial class SslClientAuthenticationOptions : DataModel
    {
        public EncryptionPolicy                         EncryptionPolicy                        { get; set; }
        public X509RevocationMode                       CheckCertificateRevocation              { get; set; }
        public SslProtocols                             EnabledSslProtocols                     { get; set; }
        public bool                                     AllowRenegotiation                      { get; set; }
        public LocalCertificateSelectionCallback?       LocalCertificateSelectionCallback       { get; set; }
        public string                                   TargetHost                              { get; set; }
        public X509CertificateCollection?               ClientCertificates                      { get; set; }

        public static SslClientAuthenticationOptions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SslClientAuthenticationOptions() { Pointer= p0 };

            value.EncryptionPolicy                          = (EncryptionPolicy)GetInt32(new IntPtr(p + 0x010)); // 024667990530 0x10 EncryptionPolicy            ( 00018672FD10 ModelEnumType EncryptionPolicy EncryptionPolicy EncryptionPolicy Int32 )
            value.CheckCertificateRevocation                = (X509RevocationMode)GetInt32(new IntPtr(p + 0x014)); // 024667990550 0x14 CheckCertificateRevocation  ( 00018656F3E0 ModelEnumType X509RevocationMode X509RevocationMode X509RevocationMode Int32 )
            value.EnabledSslProtocols                       = (SslProtocols)GetInt32(new IntPtr(p + 0x018)); // 024667990570 0x18 EnabledSslProtocols         ( 00018655D2F0 ModelEnumType SslProtocols SslProtocols SslProtocols Int32 )
            value.AllowRenegotiation                        = GetBool(new IntPtr(p + 0x01C)); // 024667990590 0x1C AllowRenegotiation          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.LocalCertificateSelectionCallback         = GetObject<LocalCertificateSelectionCallback>(new IntPtr(p + 0x020), ReversePrism.DataModels.LocalCertificateSelectionCallback.FromPointer); // 0246679905B0 0x20 LocalCertificateSelectionCallback ( 0001865A2C80 ModelClassType LocalCertificateSelectionCallback LocalCertificateSelectionCallback LocalCertificateSelectionCallback Pointer )
            value.TargetHost                                = GetString(new IntPtr(p + 0x028)); // 0246679905D0 0x28 TargetHost                  ( 000186671910 ModelPrimitiveType string string string String )
            value.ClientCertificates                        = GetObject<X509CertificateCollection>(new IntPtr(p + 0x030), ReversePrism.DataModels.X509CertificateCollection.FromPointer); // 0246679905F0 0x30 ClientCertificates          ( 0001865656A0 ModelClassType X509CertificateCollection X509CertificateCollection X509CertificateCollection Pointer )

            return value;
        }
    }
}
