using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 modules                                  ArrayList IL2CPP_TYPE_CLASS
    // 008 locker                                   <object> IL2CPP_TYPE_OBJECT
    // 010 Credential_policy                        0001867454B0 ModelClassType ICredentialPolicy ICredentialPolicy ICredentialPolicy Pointer
    public partial class AuthenticationManager
    {
        public ICredentialPolicy?                       Credential_policy                       { get; set; }

        public static AuthenticationManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AuthenticationManager();

            value.Credential_policy                         = GetObject<ICredentialPolicy>(new IntPtr(p + 0x010), ReversePrism.DataModels.ICredentialPolicy.FromPointer); // 0270D7A5B120 0x10 Credential_policy           ( 0001867454B0 ModelClassType ICredentialPolicy ICredentialPolicy ICredentialPolicy Pointer )

            return value;
        }
    }
}
