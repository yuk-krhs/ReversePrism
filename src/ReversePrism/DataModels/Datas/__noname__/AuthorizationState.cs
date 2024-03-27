using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Request                                  0001866E5D00 ModelClassType HttpWebRequest HttpWebRequest HttpWebRequest Pointer
    // 018 IsProxy                                  0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 019 IsCompleted                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 01C Ntlm_auth_state                          000186567760 ModelEnumType NtlmAuthState NtlmAuthState NtlmAuthState Int32
    public partial class AuthorizationState
    {
        public HttpWebRequest?                          Request                                 { get; set; }
        public bool                                     IsProxy                                 { get; set; }
        public bool                                     IsCompleted                             { get; set; }
        public NtlmAuthState                            Ntlm_auth_state                         { get; set; }

        public static AuthorizationState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AuthorizationState();

            value.Request                                   = GetObject<HttpWebRequest>(new IntPtr(p + 0x010), ReversePrism.DataModels.HttpWebRequest.FromPointer); // 0270D7915578 0x10 Request                     ( 0001866E5D00 ModelClassType HttpWebRequest HttpWebRequest HttpWebRequest Pointer )
            value.IsProxy                                   = GetBool(new IntPtr(p + 0x018)); // 0270D7915598 0x18 IsProxy                     ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.IsCompleted                               = GetBool(new IntPtr(p + 0x019)); // 0270D79155B8 0x19 IsCompleted                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Ntlm_auth_state                           = (NtlmAuthState)GetInt32(new IntPtr(p + 0x01C)); // 0270D79155D8 0x1C Ntlm_auth_state             ( 000186567760 ModelEnumType NtlmAuthState NtlmAuthState NtlmAuthState Int32 )

            return value;
        }
    }
}
