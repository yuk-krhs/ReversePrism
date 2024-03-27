using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CertificateValidator                     00018656B8C0 ModelClassType ChainValidationHelper ChainValidationHelper ChainValidationHelper Pointer
    // 018 Options                                  00018664B800 ModelClassType MonoSslAuthenticationOptions MonoSslAuthenticationOptions MonoSslAuthenticationOptions Pointer
    // 020 Parent                                   00018662CBA0 ModelClassType MobileAuthenticatedStream MobileAuthenticatedStream MobileAuthenticatedStream Pointer
    // 028 IsServer                                 0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 030 TargetHost                               000186672F10 ModelPrimitiveType string string string String
    // 038 ServerName                               000186672F10 ModelPrimitiveType string string string String
    // 040 AskForClientCertificate                  0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 044 EnabledProtocols                         00018655D540 ModelEnumType SslProtocols SslProtocols SslProtocols Int32
    // 048 ClientCertificates                       000186565980 ModelClassType X509CertificateCollection X509CertificateCollection X509CertificateCollection Pointer
    // 050 LocalServerCertificate                   0001866B7D80 ModelClassType X509Certificate X509Certificate X509Certificate Pointer
    public partial class MobileTlsContext
    {
        public ChainValidationHelper?                   CertificateValidator                    { get; set; }
        public MonoSslAuthenticationOptions?            Options                                 { get; set; }
        public MobileAuthenticatedStream?               Parent                                  { get; set; }
        public bool                                     IsServer                                { get; set; }
        public string                                   TargetHost                              { get; set; }
        public string                                   ServerName                              { get; set; }
        public bool                                     AskForClientCertificate                 { get; set; }
        public SslProtocols                             EnabledProtocols                        { get; set; }
        public X509CertificateCollection?               ClientCertificates                      { get; set; }
        public X509Certificate?                         LocalServerCertificate                  { get; set; }

        public static MobileTlsContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MobileTlsContext();

            value.CertificateValidator                      = GetObject<ChainValidationHelper>(new IntPtr(p + 0x010), ReversePrism.DataModels.ChainValidationHelper.FromPointer); // 0270D78ECDB0 0x10 CertificateValidator        ( 00018656B8C0 ModelClassType ChainValidationHelper ChainValidationHelper ChainValidationHelper Pointer )
            value.Options                                   = GetObject<MonoSslAuthenticationOptions>(new IntPtr(p + 0x018), ReversePrism.DataModels.MonoSslAuthenticationOptions.FromPointer); // 0270D78ECDD0 0x18 Options                     ( 00018664B800 ModelClassType MonoSslAuthenticationOptions MonoSslAuthenticationOptions MonoSslAuthenticationOptions Pointer )
            value.Parent                                    = GetObject<MobileAuthenticatedStream>(new IntPtr(p + 0x020), ReversePrism.DataModels.MobileAuthenticatedStream.FromPointer); // 0270D78ECDF0 0x20 Parent                      ( 00018662CBA0 ModelClassType MobileAuthenticatedStream MobileAuthenticatedStream MobileAuthenticatedStream Pointer )
            value.IsServer                                  = GetBool(new IntPtr(p + 0x028)); // 0270D78ECE10 0x28 IsServer                    ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.TargetHost                                = GetString(new IntPtr(p + 0x030)); // 0270D78ECE30 0x30 TargetHost                  ( 000186672F10 ModelPrimitiveType string string string String )
            value.ServerName                                = GetString(new IntPtr(p + 0x038)); // 0270D78ECE50 0x38 ServerName                  ( 000186672F10 ModelPrimitiveType string string string String )
            value.AskForClientCertificate                   = GetBool(new IntPtr(p + 0x040)); // 0270D78ECE70 0x40 AskForClientCertificate     ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.EnabledProtocols                          = (SslProtocols)GetInt32(new IntPtr(p + 0x044)); // 0270D78ECE90 0x44 EnabledProtocols            ( 00018655D540 ModelEnumType SslProtocols SslProtocols SslProtocols Int32 )
            value.ClientCertificates                        = GetObject<X509CertificateCollection>(new IntPtr(p + 0x048), ReversePrism.DataModels.X509CertificateCollection.FromPointer); // 0270D78ECEB0 0x48 ClientCertificates          ( 000186565980 ModelClassType X509CertificateCollection X509CertificateCollection X509CertificateCollection Pointer )
            value.LocalServerCertificate                    = GetObject<X509Certificate>(new IntPtr(p + 0x050), ReversePrism.DataModels.X509Certificate.FromPointer); // 0270D78ECED0 0x50 LocalServerCertificate      ( 0001866B7D80 ModelClassType X509Certificate X509Certificate X509Certificate Pointer )

            return value;
        }
    }
}
