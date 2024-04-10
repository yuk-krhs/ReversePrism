using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 OnCanceledDelegate                       Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 000 source                                   IObservable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 cancellationToken                        CancellationToken IL2CPP_TYPE_VALUETYPE
    // 000 useCachedCurrent                         bool IL2CPP_TYPE_BOOLEAN
    // 000 current                                  <var> IL2CPP_TYPE_VAR
    // 000 subscribeCompleted                       bool IL2CPP_TYPE_BOOLEAN
    // 000 queuedResult                             Queue`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 error                                    Exception IL2CPP_TYPE_CLASS
    // 000 subscription                             IDisposable IL2CPP_TYPE_CLASS
    // 000 cancellationTokenRegistration            CancellationTokenRegistration IL2CPP_TYPE_VALUETYPE
    public partial class _ToUniTaskAsyncEnumerableObservable : DataModel
    {

        public static _ToUniTaskAsyncEnumerableObservable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new _ToUniTaskAsyncEnumerableObservable() { Pointer= p0 };


            return value;
        }
    }
}
