using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 instance                                 SystemDependencyProvider IL2CPP_TYPE_CLASS
    // 008 syncRoot                                 <object> IL2CPP_TYPE_OBJECT
    // 010 CertificateProvider                      ModelClassType SystemCertificateProvider SystemCertificateProvider SystemCertificateProvider Pointer
    public partial class SystemDependencyProvider : DataModel
    {
        public SystemCertificateProvider?               CertificateProvider                     { get; set; }

        public static SystemDependencyProvider? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SystemDependencyProvider() { Pointer= p0 };

            value.CertificateProvider                       = GetObject<SystemCertificateProvider>(new IntPtr(p + 0x010), ReversePrism.DataModels.SystemCertificateProvider.FromPointer); // 0x10 CertificateProvider         ( ModelClassType SystemCertificateProvider SystemCertificateProvider SystemCertificateProvider Pointer )

            return value;
        }
    }
}
