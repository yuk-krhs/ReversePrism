using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Invoker                                  00018652ADF0 ModelClassType CallInvoker CallInvoker CallInvoker Pointer
    // 018 Interceptor                              000186716C60 ModelClassType Interceptor Interceptor Interceptor Pointer
    public partial class InterceptingCallInvoker : DataModel
    {
        public CallInvoker?                             Invoker                                 { get; set; }
        public Interceptor?                             Interceptor                             { get; set; }

        public static InterceptingCallInvoker? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InterceptingCallInvoker() { Pointer= p0 };

            value.Invoker                                   = GetObject<CallInvoker>(new IntPtr(p + 0x010), ReversePrism.DataModels.CallInvoker.FromPointer); // 02466BBEDEF0 0x10 Invoker                     ( 00018652ADF0 ModelClassType CallInvoker CallInvoker CallInvoker Pointer )
            value.Interceptor                               = GetObject<Interceptor>(new IntPtr(p + 0x018), ReversePrism.DataModels.Interceptor.FromPointer); // 02466BBEDF10 0x18 Interceptor                 ( 000186716C60 ModelClassType Interceptor Interceptor Interceptor Pointer )

            return value;
        }
    }
}
