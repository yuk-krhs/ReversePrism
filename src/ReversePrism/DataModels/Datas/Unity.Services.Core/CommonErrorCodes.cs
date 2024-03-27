using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Unknown                                  int IL2CPP_TYPE_I4
    // 000 TransportError                           int IL2CPP_TYPE_I4
    // 000 Timeout                                  int IL2CPP_TYPE_I4
    // 000 ServiceUnavailable                       int IL2CPP_TYPE_I4
    // 000 ApiMissing                               int IL2CPP_TYPE_I4
    // 000 RequestRejected                          int IL2CPP_TYPE_I4
    // 000 TooManyRequests                          int IL2CPP_TYPE_I4
    // 000 InvalidToken                             int IL2CPP_TYPE_I4
    // 000 TokenExpired                             int IL2CPP_TYPE_I4
    // 000 Forbidden                                int IL2CPP_TYPE_I4
    // 000 NotFound                                 int IL2CPP_TYPE_I4
    // 000 InvalidRequest                           int IL2CPP_TYPE_I4
    // 000 ProjectPolicyAccessDenied                int IL2CPP_TYPE_I4
    // 000 PlayerPolicyAccessDenied                 int IL2CPP_TYPE_I4
    public partial class CommonErrorCodes
    {

        public static CommonErrorCodes? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CommonErrorCodes();


            return value;
        }
    }
}
