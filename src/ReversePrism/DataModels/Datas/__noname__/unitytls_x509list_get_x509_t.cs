using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public partial class unitytls_x509list_get_x509_t
    {

        public static unitytls_x509list_get_x509_t? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new unitytls_x509list_get_x509_t();


            return value;
        }
    }
}
