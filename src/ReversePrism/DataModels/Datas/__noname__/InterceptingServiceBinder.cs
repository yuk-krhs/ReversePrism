using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Builder                                  ModelClassType Builder Builder Builder Pointer
    // 018 Interceptor                              ModelClassType Interceptor Interceptor Interceptor Pointer
    public partial class InterceptingServiceBinder : DataModel
    {
        public Builder?                                 Builder                                 { get; set; }
        public Interceptor?                             Interceptor                             { get; set; }

        public static InterceptingServiceBinder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InterceptingServiceBinder() { Pointer= p0 };

            value.Builder                                   = GetObject<Builder>(new IntPtr(p + 0x010), ReversePrism.DataModels.Builder.FromPointer); // 0x10 Builder                     ( ModelClassType Builder Builder Builder Pointer )
            value.Interceptor                               = GetObject<Interceptor>(new IntPtr(p + 0x018), ReversePrism.DataModels.Interceptor.FromPointer); // 0x18 Interceptor                 ( ModelClassType Interceptor Interceptor Interceptor Pointer )

            return value;
        }
    }
}
