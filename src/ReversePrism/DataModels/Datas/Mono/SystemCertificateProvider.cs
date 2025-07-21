using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 provider                                 MonoTlsProvider IL2CPP_TYPE_CLASS
    // 008 initialized                              int IL2CPP_TYPE_I4
    // 010 X509pal                                  ModelClassType X509PalImpl X509PalImpl X509PalImpl Pointer
    // 018 syncRoot                                 <object> IL2CPP_TYPE_OBJECT
    public partial class SystemCertificateProvider : DataModel
    {
        public X509PalImpl?                             X509pal                                 { get; set; }

        public static SystemCertificateProvider? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SystemCertificateProvider() { Pointer= p0 };

            value.X509pal                                   = GetObject<X509PalImpl>(new IntPtr(p + 0x010), ReversePrism.DataModels.X509PalImpl.FromPointer); // 0x10 X509pal                     ( ModelClassType X509PalImpl X509PalImpl X509PalImpl Pointer )

            return value;
        }
    }
}
