using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Interceptor                              ModelClassType AsyncAuthInterceptor AsyncAuthInterceptor AsyncAuthInterceptor Pointer
    public partial class AsyncAuthInterceptorCredentials : DataModel
    {
        public AsyncAuthInterceptor?                    Interceptor                             { get; set; }

        public static AsyncAuthInterceptorCredentials? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncAuthInterceptorCredentials() { Pointer= p0 };

            value.Interceptor                               = GetObject<AsyncAuthInterceptor>(new IntPtr(p + 0x010), ReversePrism.DataModels.AsyncAuthInterceptor.FromPointer); // 0x10 Interceptor                 ( ModelClassType AsyncAuthInterceptor AsyncAuthInterceptor AsyncAuthInterceptor Pointer )

            return value;
        }
    }
}
