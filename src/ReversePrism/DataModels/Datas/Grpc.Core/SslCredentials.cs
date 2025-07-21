using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RootCertificates                         ModelPrimitiveType string string string String
    // 018 KeyCertificatePair                       ModelClassType KeyCertificatePair KeyCertificatePair KeyCertificatePair Pointer
    // 020 VerifyPeerCallback                       ModelClassType VerifyPeerCallback VerifyPeerCallback VerifyPeerCallback Pointer
    public partial class SslCredentials : DataModel
    {
        public string                                   RootCertificates                        { get; set; }
        public KeyCertificatePair?                      KeyCertificatePair                      { get; set; }
        public VerifyPeerCallback?                      VerifyPeerCallback                      { get; set; }

        public static SslCredentials? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SslCredentials() { Pointer= p0 };

            value.RootCertificates                          = GetString(new IntPtr(p + 0x010)); // 0x10 RootCertificates            ( ModelPrimitiveType string string string String )
            value.KeyCertificatePair                        = GetObject<KeyCertificatePair>(new IntPtr(p + 0x018), ReversePrism.DataModels.KeyCertificatePair.FromPointer); // 0x18 KeyCertificatePair          ( ModelClassType KeyCertificatePair KeyCertificatePair KeyCertificatePair Pointer )
            value.VerifyPeerCallback                        = GetObject<VerifyPeerCallback>(new IntPtr(p + 0x020), ReversePrism.DataModels.VerifyPeerCallback.FromPointer); // 0x20 VerifyPeerCallback          ( ModelClassType VerifyPeerCallback VerifyPeerCallback VerifyPeerCallback Pointer )

            return value;
        }
    }
}
