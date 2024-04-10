using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ReadCertData                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 CertData                                 0001865545D0 ModelEnumType CertificateData CertificateData CertificateData Int32
    public partial class X509Certificate2ImplUnix : DataModel
    {
        public bool                                     ReadCertData                            { get; set; }
        public CertificateData                          CertData                                { get; set; }

        public static X509Certificate2ImplUnix? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new X509Certificate2ImplUnix() { Pointer= p0 };

            value.ReadCertData                              = GetBool(new IntPtr(p + 0x010)); // 0246679A7D78 0x10 ReadCertData                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CertData                                  = (CertificateData)GetInt32(new IntPtr(p + 0x018)); // 0246679A7D98 0x18 CertData                    ( 0001865545D0 ModelEnumType CertificateData CertificateData CertificateData Int32 )

            return value;
        }
    }
}
