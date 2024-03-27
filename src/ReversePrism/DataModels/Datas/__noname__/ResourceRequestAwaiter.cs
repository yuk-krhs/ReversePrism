using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AsyncOperation                           000186671E40 ModelClassType ResourceRequest ResourceRequest ResourceRequest Pointer
    // 018 continuationAction                       Action`1<AsyncOperation> IL2CPP_TYPE_GENERICINST
    public partial class ResourceRequestAwaiter
    {
        public ResourceRequest?                         AsyncOperation                          { get; set; }

        public static ResourceRequestAwaiter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResourceRequestAwaiter();

            value.AsyncOperation                            = GetObject<ResourceRequest>(new IntPtr(p + 0x010), ReversePrism.DataModels.ResourceRequest.FromPointer); // 0270D8F89BD0 0x10 AsyncOperation              ( 000186671E40 ModelClassType ResourceRequest ResourceRequest ResourceRequest Pointer )

            return value;
        }
    }
}
