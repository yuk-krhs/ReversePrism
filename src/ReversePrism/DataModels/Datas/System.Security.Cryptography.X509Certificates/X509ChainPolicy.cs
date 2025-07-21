using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Apps                                     ModelClassType OidCollection OidCollection OidCollection Pointer
    // 018 Cert                                     ModelClassType OidCollection OidCollection OidCollection Pointer
    // 020 Store                                    ModelClassType X509CertificateCollection X509CertificateCollection X509CertificateCollection Pointer
    // 028 Store2                                   ModelClassType X509Certificate2Collection X509Certificate2Collection X509Certificate2Collection Pointer
    // 030 Rflag                                    ModelEnumType X509RevocationFlag X509RevocationFlag X509RevocationFlag Int32
    // 034 Mode                                     ModelEnumType X509RevocationMode X509RevocationMode X509RevocationMode Int32
    // 038 Timeout                                  ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 040 Vflags                                   ModelEnumType X509VerificationFlags X509VerificationFlags X509VerificationFlags Int32
    // 048 Vtime                                    ModelPrimitiveType DateTime DateTime DateTime DateTime
    public partial class X509ChainPolicy : DataModel
    {
        public OidCollection?                           Apps                                    { get; set; }
        public OidCollection?                           Cert                                    { get; set; }
        public X509CertificateCollection?               Store                                   { get; set; }
        public X509Certificate2Collection?              Store2                                  { get; set; }
        public X509RevocationFlag                       Rflag                                   { get; set; }
        public X509RevocationMode                       Mode                                    { get; set; }
        public TimeSpan                                 Timeout                                 { get; set; }
        public X509VerificationFlags                    Vflags                                  { get; set; }
        public DateTime                                 Vtime                                   { get; set; }

        public static X509ChainPolicy? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new X509ChainPolicy() { Pointer= p0 };

            value.Apps                                      = GetObject<OidCollection>(new IntPtr(p + 0x010), ReversePrism.DataModels.OidCollection.FromPointer); // 0x10 Apps                        ( ModelClassType OidCollection OidCollection OidCollection Pointer )
            value.Cert                                      = GetObject<OidCollection>(new IntPtr(p + 0x018), ReversePrism.DataModels.OidCollection.FromPointer); // 0x18 Cert                        ( ModelClassType OidCollection OidCollection OidCollection Pointer )
            value.Store                                     = GetObject<X509CertificateCollection>(new IntPtr(p + 0x020), ReversePrism.DataModels.X509CertificateCollection.FromPointer); // 0x20 Store                       ( ModelClassType X509CertificateCollection X509CertificateCollection X509CertificateCollection Pointer )
            value.Store2                                    = GetObject<X509Certificate2Collection>(new IntPtr(p + 0x028), ReversePrism.DataModels.X509Certificate2Collection.FromPointer); // 0x28 Store2                      ( ModelClassType X509Certificate2Collection X509Certificate2Collection X509Certificate2Collection Pointer )
            value.Rflag                                     = (X509RevocationFlag)GetInt32(new IntPtr(p + 0x030)); // 0x30 Rflag                       ( ModelEnumType X509RevocationFlag X509RevocationFlag X509RevocationFlag Int32 )
            value.Mode                                      = (X509RevocationMode)GetInt32(new IntPtr(p + 0x034)); // 0x34 Mode                        ( ModelEnumType X509RevocationMode X509RevocationMode X509RevocationMode Int32 )
            value.Timeout                                   = (TimeSpan)GetInt32(new IntPtr(p + 0x038)); // 0x38 Timeout                     ( ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.Vflags                                    = (X509VerificationFlags)GetInt32(new IntPtr(p + 0x040)); // 0x40 Vflags                      ( ModelEnumType X509VerificationFlags X509VerificationFlags X509VerificationFlags Int32 )
            value.Vtime                                     = GetDateTime(new IntPtr(p + 0x048)); // 0x48 Vtime                       ( ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
