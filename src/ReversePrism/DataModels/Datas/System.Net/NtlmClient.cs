using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AuthObject                               ModelClassType IAuthenticationModule IAuthenticationModule IAuthenticationModule Pointer
    public partial class NtlmClient : DataModel
    {
        public IAuthenticationModule?                   AuthObject                              { get; set; }

        public static NtlmClient? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NtlmClient() { Pointer= p0 };

            value.AuthObject                                = GetObject<IAuthenticationModule>(new IntPtr(p + 0x010), ReversePrism.DataModels.IAuthenticationModule.FromPointer); // 0x10 AuthObject                  ( ModelClassType IAuthenticationModule IAuthenticationModule IAuthenticationModule Pointer )

            return value;
        }
    }
}
