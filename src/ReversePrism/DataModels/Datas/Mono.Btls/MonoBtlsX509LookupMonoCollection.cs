using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 048 Hashes                                   000185B7E2C0 ModelPrimitiveListType long[] long[] List<long> Pointer
    // 050 Certificates                             000185B94130 ModelClassListType MonoBtlsX509[] MonoBtlsX509[] List<MonoBtlsX509> Pointer
    // 058 Collection                               0001865656A0 ModelClassType X509CertificateCollection X509CertificateCollection X509CertificateCollection Pointer
    // 060 Trust                                    000186646E40 ModelEnumType MonoBtlsX509TrustKind MonoBtlsX509TrustKind MonoBtlsX509TrustKind Int32
    public partial class MonoBtlsX509LookupMonoCollection
    {
        public List<long>?                              Hashes                                  { get; set; }
        public List<MonoBtlsX509>?                      Certificates                            { get; set; }
        public X509CertificateCollection?               Collection                              { get; set; }
        public MonoBtlsX509TrustKind                    Trust                                   { get; set; }

        public static MonoBtlsX509LookupMonoCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MonoBtlsX509LookupMonoCollection();

            value.Hashes                                    = GetInt64List(new IntPtr(p + 0x048)); // 0270D795E868 0x48 Hashes                      ( 000185B7E2C0 ModelPrimitiveListType long[] long[] List<long> Pointer )
            value.Certificates                              = GetObjectList<MonoBtlsX509>(new IntPtr(p + 0x050), ReversePrism.DataModels.MonoBtlsX509.FromPointer); // 0270D795E888 0x50 Certificates                ( 000185B94130 ModelClassListType MonoBtlsX509[] MonoBtlsX509[] List<MonoBtlsX509> Pointer )
            value.Collection                                = GetObject<X509CertificateCollection>(new IntPtr(p + 0x058), ReversePrism.DataModels.X509CertificateCollection.FromPointer); // 0270D795E8A8 0x58 Collection                  ( 0001865656A0 ModelClassType X509CertificateCollection X509CertificateCollection X509CertificateCollection Pointer )
            value.Trust                                     = (MonoBtlsX509TrustKind)GetInt32(new IntPtr(p + 0x060)); // 0270D795E8C8 0x60 Trust                       ( 000186646E40 ModelEnumType MonoBtlsX509TrustKind MonoBtlsX509TrustKind MonoBtlsX509TrustKind Int32 )

            return value;
        }
    }
}
