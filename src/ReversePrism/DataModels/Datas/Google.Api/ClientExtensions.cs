using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MethodSignature                          RepeatedExtension`2<MethodOptions, string> IL2CPP_TYPE_GENERICINST
    // 008 DefaultHost                              Extension`2<ServiceOptions, string> IL2CPP_TYPE_GENERICINST
    // 010 OauthScopes                              Extension`2<ServiceOptions, string> IL2CPP_TYPE_GENERICINST
    public partial class ClientExtensions
    {

        public static ClientExtensions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ClientExtensions();


            return value;
        }
    }
}
