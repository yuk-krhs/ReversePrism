using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 is_macosx                                bool IL2CPP_TYPE_BOOLEAN
    // 004 s_flags                                  X509KeyUsageFlags IL2CPP_TYPE_VALUETYPE
    public partial class SystemCertificateValidator
    {

        public static SystemCertificateValidator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SystemCertificateValidator();


            return value;
        }
    }
}
