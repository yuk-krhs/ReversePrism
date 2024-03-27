using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AuthObject                               00018670C6F0 ModelClassType IAuthenticationModule IAuthenticationModule IAuthenticationModule Pointer
    public partial class NtlmClient
    {
        public IAuthenticationModule?                   AuthObject                              { get; set; }

        public static NtlmClient? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NtlmClient();

            value.AuthObject                                = GetObject<IAuthenticationModule>(new IntPtr(p + 0x010), ReversePrism.DataModels.IAuthenticationModule.FromPointer); // 0270D7A905E8 0x10 AuthObject                  ( 00018670C6F0 ModelClassType IAuthenticationModule IAuthenticationModule IAuthenticationModule Pointer )

            return value;
        }
    }
}
