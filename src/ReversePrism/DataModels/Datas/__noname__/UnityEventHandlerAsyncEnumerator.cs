using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 cancel1                                  Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 000 cancel2                                  Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 000 unityEvent                               UnityEvent`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 cancellationToken1                       CancellationToken IL2CPP_TYPE_VALUETYPE
    // 000 cancellationToken2                       CancellationToken IL2CPP_TYPE_VALUETYPE
    // 000 unityAction                              UnityAction`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 registration1                            CancellationTokenRegistration IL2CPP_TYPE_VALUETYPE
    // 000 registration2                            CancellationTokenRegistration IL2CPP_TYPE_VALUETYPE
    // 000 isDisposed                               bool IL2CPP_TYPE_BOOLEAN
    // 000 <Current>k__BackingField                 <var> IL2CPP_TYPE_VAR
    public partial class UnityEventHandlerAsyncEnumerator : DataModel
    {

        public static UnityEventHandlerAsyncEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnityEventHandlerAsyncEnumerator() { Pointer= p0 };


            return value;
        }
    }
}
