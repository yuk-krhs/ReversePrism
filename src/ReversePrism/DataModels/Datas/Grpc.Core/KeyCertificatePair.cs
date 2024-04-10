using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CertificateChain                         000186672F10 ModelPrimitiveType string string string String
    // 018 PrivateKey                               000186672F10 ModelPrimitiveType string string string String
    public partial class KeyCertificatePair : DataModel
    {
        public string                                   CertificateChain                        { get; set; }
        public string                                   PrivateKey                              { get; set; }

        public static KeyCertificatePair? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new KeyCertificatePair() { Pointer= p0 };

            value.CertificateChain                          = GetString(new IntPtr(p + 0x010)); // 0246693D1970 0x10 CertificateChain            ( 000186672F10 ModelPrimitiveType string string string String )
            value.PrivateKey                                = GetString(new IntPtr(p + 0x018)); // 0246693D1990 0x18 PrivateKey                  ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
