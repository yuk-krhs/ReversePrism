using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0B0 IntermediateCerts                        000186566880 ModelClassType X509CertificateImplCollection X509CertificateImplCollection X509CertificateImplCollection Pointer
    // 0B8 Cert                                     0001865639C0 ModelClassType X509Certificate X509Certificate X509Certificate Pointer
    // 000 empty_error                              string IL2CPP_TYPE_STRING
    // 008 signedData                               sbyte[] IL2CPP_TYPE_SZARRAY
    public partial class X509Certificate2ImplMono : DataModel
    {
        public X509CertificateImplCollection?           IntermediateCerts                       { get; set; }
        public X509Certificate?                         Cert                                    { get; set; }

        public static X509Certificate2ImplMono? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new X509Certificate2ImplMono() { Pointer= p0 };

            value.IntermediateCerts                         = GetObject<X509CertificateImplCollection>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.X509CertificateImplCollection.FromPointer); // 024667A3BC48 0xB0 IntermediateCerts           ( 000186566880 ModelClassType X509CertificateImplCollection X509CertificateImplCollection X509CertificateImplCollection Pointer )
            value.Cert                                      = GetObject<X509Certificate>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.X509Certificate.FromPointer); // 024667A3BC68 0xB8 Cert                        ( 0001865639C0 ModelClassType X509Certificate X509Certificate X509Certificate Pointer )

            return value;
        }
    }
}
