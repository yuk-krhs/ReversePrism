using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public partial class unitytls_tlsctx_get_ciphersuite_t : DataModel
    {

        public static unitytls_tlsctx_get_ciphersuite_t? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new unitytls_tlsctx_get_ciphersuite_t() { Pointer= p0 };


            return value;
        }
    }
}
