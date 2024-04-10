using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 CancellationCallbackDelegate             Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 000 parent                                   SingleConsumerUnboundedChannel`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 cancellationToken                        CancellationToken IL2CPP_TYPE_VALUETYPE
    // 000 cancellationTokenRegistration            CancellationTokenRegistration IL2CPP_TYPE_VALUETYPE
    // 000 core                                     UniTaskCompletionSourceCore`1<bool> IL2CPP_TYPE_GENERICINST
    // 000 isWaiting                                bool IL2CPP_TYPE_BOOLEAN
    public partial class SingleConsumerUnboundedChannelReader : DataModel
    {

        public static SingleConsumerUnboundedChannelReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SingleConsumerUnboundedChannelReader() { Pointer= p0 };


            return value;
        }
    }
}
