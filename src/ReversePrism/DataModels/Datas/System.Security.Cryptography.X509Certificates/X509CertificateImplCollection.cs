using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 List                                     000185D1CE98 ModelClassListType List`1<X509CertificateImpl> List`1<X509CertificateImpl> List<X509CertificateImpl> Pointer
    public partial class X509CertificateImplCollection : DataModel
    {
        public List<X509CertificateImpl>?               List                                    { get; set; }

        public static X509CertificateImplCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new X509CertificateImplCollection() { Pointer= p0 };

            value.List                                      = GetObjectList<X509CertificateImpl>(new IntPtr(p + 0x010), ReversePrism.DataModels.X509CertificateImpl.FromPointer); // 0246679CC5D8 0x10 List                        ( 000185D1CE98 ModelClassListType List`1<X509CertificateImpl> List`1<X509CertificateImpl> List<X509CertificateImpl> Pointer )

            return value;
        }
    }
}
