using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 cancellationCallback                     Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 000 pool                                     TaskPool`1<WaitAsyncSource<<var>>> IL2CPP_TYPE_GENERICINST
    // 000 nextNode                                 WaitAsyncSource<<var>> IL2CPP_TYPE_GENERICINST
    // 000 parent                                   ReadOnlyAsyncReactiveProperty`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 cancellationToken                        CancellationToken IL2CPP_TYPE_VALUETYPE
    // 000 cancellationTokenRegistration            CancellationTokenRegistration IL2CPP_TYPE_VALUETYPE
    // 000 core                                     UniTaskCompletionSourceCore`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 <Cysharp.Threading.Tasks.ITriggerHandler<T>.Prev>k__BackingField ITriggerHandler`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 <Cysharp.Threading.Tasks.ITriggerHandler<T>.Next>k__BackingField ITriggerHandler`1<<var>> IL2CPP_TYPE_GENERICINST
    public partial class WaitAsyncSource
    {

        public static WaitAsyncSource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WaitAsyncSource();


            return value;
        }
    }
}
