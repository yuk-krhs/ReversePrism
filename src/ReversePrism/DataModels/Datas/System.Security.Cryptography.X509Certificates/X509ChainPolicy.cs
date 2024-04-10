using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Apps                                     0001866D8AE0 ModelClassType OidCollection OidCollection OidCollection Pointer
    // 018 Cert                                     0001866D8AE0 ModelClassType OidCollection OidCollection OidCollection Pointer
    // 020 Store                                    0001865656A0 ModelClassType X509CertificateCollection X509CertificateCollection X509CertificateCollection Pointer
    // 028 Store2                                   0001865642C0 ModelClassType X509Certificate2Collection X509Certificate2Collection X509Certificate2Collection Pointer
    // 030 Rflag                                    00018656EC80 ModelEnumType X509RevocationFlag X509RevocationFlag X509RevocationFlag Int32
    // 034 Mode                                     00018656F3E0 ModelEnumType X509RevocationMode X509RevocationMode X509RevocationMode Int32
    // 038 Timeout                                  00018668A8A0 ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 040 Vflags                                   0001865714B0 ModelEnumType X509VerificationFlags X509VerificationFlags X509VerificationFlags Int32
    // 048 Vtime                                    0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime
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

            value.Apps                                      = GetObject<OidCollection>(new IntPtr(p + 0x010), ReversePrism.DataModels.OidCollection.FromPointer); // 02466795F1F0 0x10 Apps                        ( 0001866D8AE0 ModelClassType OidCollection OidCollection OidCollection Pointer )
            value.Cert                                      = GetObject<OidCollection>(new IntPtr(p + 0x018), ReversePrism.DataModels.OidCollection.FromPointer); // 02466795F210 0x18 Cert                        ( 0001866D8AE0 ModelClassType OidCollection OidCollection OidCollection Pointer )
            value.Store                                     = GetObject<X509CertificateCollection>(new IntPtr(p + 0x020), ReversePrism.DataModels.X509CertificateCollection.FromPointer); // 02466795F230 0x20 Store                       ( 0001865656A0 ModelClassType X509CertificateCollection X509CertificateCollection X509CertificateCollection Pointer )
            value.Store2                                    = GetObject<X509Certificate2Collection>(new IntPtr(p + 0x028), ReversePrism.DataModels.X509Certificate2Collection.FromPointer); // 02466795F250 0x28 Store2                      ( 0001865642C0 ModelClassType X509Certificate2Collection X509Certificate2Collection X509Certificate2Collection Pointer )
            value.Rflag                                     = (X509RevocationFlag)GetInt32(new IntPtr(p + 0x030)); // 02466795F270 0x30 Rflag                       ( 00018656EC80 ModelEnumType X509RevocationFlag X509RevocationFlag X509RevocationFlag Int32 )
            value.Mode                                      = (X509RevocationMode)GetInt32(new IntPtr(p + 0x034)); // 02466795F290 0x34 Mode                        ( 00018656F3E0 ModelEnumType X509RevocationMode X509RevocationMode X509RevocationMode Int32 )
            value.Timeout                                   = (TimeSpan)GetInt32(new IntPtr(p + 0x038)); // 02466795F2B0 0x38 Timeout                     ( 00018668A8A0 ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.Vflags                                    = (X509VerificationFlags)GetInt32(new IntPtr(p + 0x040)); // 02466795F2D0 0x40 Vflags                      ( 0001865714B0 ModelEnumType X509VerificationFlags X509VerificationFlags X509VerificationFlags Int32 )
            value.Vtime                                     = GetDateTime(new IntPtr(p + 0x048)); // 02466795F2F0 0x48 Vtime                       ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
