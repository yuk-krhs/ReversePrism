using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Roots                                    0001865651A0 ModelClassType X509CertificateCollection X509CertificateCollection X509CertificateCollection Pointer
    // 018 Certs                                    0001865651A0 ModelClassType X509CertificateCollection X509CertificateCollection X509CertificateCollection Pointer
    // 020 Root                                     0001865639C0 ModelClassType X509Certificate X509Certificate X509Certificate Pointer
    // 028 Chain                                    0001865651A0 ModelClassType X509CertificateCollection X509CertificateCollection X509CertificateCollection Pointer
    // 030 Status                                   000186569130 ModelEnumType X509ChainStatusFlags X509ChainStatusFlags X509ChainStatusFlags Int32
    public partial class X509Chain
    {
        public X509CertificateCollection?               Roots                                   { get; set; }
        public X509CertificateCollection?               Certs                                   { get; set; }
        public X509Certificate?                         Root                                    { get; set; }
        public X509CertificateCollection?               Chain                                   { get; set; }
        public X509ChainStatusFlags                     Status                                  { get; set; }

        public static X509Chain? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new X509Chain();

            value.Roots                                     = GetObject<X509CertificateCollection>(new IntPtr(p + 0x010), ReversePrism.DataModels.X509CertificateCollection.FromPointer); // 0270DB37CCE8 0x10 Roots                       ( 0001865651A0 ModelClassType X509CertificateCollection X509CertificateCollection X509CertificateCollection Pointer )
            value.Certs                                     = GetObject<X509CertificateCollection>(new IntPtr(p + 0x018), ReversePrism.DataModels.X509CertificateCollection.FromPointer); // 0270DB37CD08 0x18 Certs                       ( 0001865651A0 ModelClassType X509CertificateCollection X509CertificateCollection X509CertificateCollection Pointer )
            value.Root                                      = GetObject<X509Certificate>(new IntPtr(p + 0x020), ReversePrism.DataModels.X509Certificate.FromPointer); // 0270DB37CD28 0x20 Root                        ( 0001865639C0 ModelClassType X509Certificate X509Certificate X509Certificate Pointer )
            value.Chain                                     = GetObject<X509CertificateCollection>(new IntPtr(p + 0x028), ReversePrism.DataModels.X509CertificateCollection.FromPointer); // 0270DB37CD48 0x28 Chain                       ( 0001865651A0 ModelClassType X509CertificateCollection X509CertificateCollection X509CertificateCollection Pointer )
            value.Status                                    = (X509ChainStatusFlags)GetInt32(new IntPtr(p + 0x030)); // 0270DB37CD68 0x30 Status                      ( 000186569130 ModelEnumType X509ChainStatusFlags X509ChainStatusFlags X509ChainStatusFlags Int32 )

            return value;
        }
    }
}
