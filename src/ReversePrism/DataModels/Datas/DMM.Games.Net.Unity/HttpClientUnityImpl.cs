using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Context                                  000186601DB0 ModelClassType SynchronizationContext SynchronizationContext SynchronizationContext Pointer
    public partial class HttpClientUnityImpl
    {
        public SynchronizationContext?                  Context                                 { get; set; }

        public static HttpClientUnityImpl? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HttpClientUnityImpl();

            value.Context                                   = GetObject<SynchronizationContext>(new IntPtr(p + 0x010), ReversePrism.DataModels.SynchronizationContext.FromPointer); // 027004C0EC58 0x10 Context                     ( 000186601DB0 ModelClassType SynchronizationContext SynchronizationContext SynchronizationContext Pointer )

            return value;
        }
    }
}
