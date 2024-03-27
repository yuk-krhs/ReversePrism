using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Principal                                0001865DDD40 ModelClassType IPrincipal IPrincipal IPrincipal Pointer
    public partial class CallContextSecurityData
    {
        public IPrincipal?                              Principal                               { get; set; }

        public static CallContextSecurityData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CallContextSecurityData();

            value.Principal                                 = GetObject<IPrincipal>(new IntPtr(p + 0x010), ReversePrism.DataModels.IPrincipal.FromPointer); // 0270D6BE7D68 0x10 Principal                   ( 0001865DDD40 ModelClassType IPrincipal IPrincipal IPrincipal Pointer )

            return value;
        }
    }
}
