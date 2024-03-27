using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 CancellationCallback1Delegate            Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 000 CancellationCallback2Delegate            Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 000 parent                                   SingleConsumerUnboundedChannelReader<<var>> IL2CPP_TYPE_GENERICINST
    // 000 cancellationToken1                       CancellationToken IL2CPP_TYPE_VALUETYPE
    // 000 cancellationToken2                       CancellationToken IL2CPP_TYPE_VALUETYPE
    // 000 cancellationTokenRegistration1           CancellationTokenRegistration IL2CPP_TYPE_VALUETYPE
    // 000 cancellationTokenRegistration2           CancellationTokenRegistration IL2CPP_TYPE_VALUETYPE
    // 000 current                                  <var> IL2CPP_TYPE_VAR
    // 000 cacheValue                               bool IL2CPP_TYPE_BOOLEAN
    // 000 running                                  bool IL2CPP_TYPE_BOOLEAN
    public partial class ReadAllAsyncEnumerable
    {

        public static ReadAllAsyncEnumerable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReadAllAsyncEnumerable();


            return value;
        }
    }
}
