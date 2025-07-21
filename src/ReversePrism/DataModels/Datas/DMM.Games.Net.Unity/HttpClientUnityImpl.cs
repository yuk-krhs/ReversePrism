using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Context                                  ModelClassType SynchronizationContext SynchronizationContext SynchronizationContext Pointer
    public partial class HttpClientUnityImpl : DataModel
    {
        public SynchronizationContext?                  Context                                 { get; set; }

        public static HttpClientUnityImpl? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HttpClientUnityImpl() { Pointer= p0 };

            value.Context                                   = GetObject<SynchronizationContext>(new IntPtr(p + 0x010), ReversePrism.DataModels.SynchronizationContext.FromPointer); // 0x10 Context                     ( ModelClassType SynchronizationContext SynchronizationContext SynchronizationContext Pointer )

            return value;
        }
    }
}
