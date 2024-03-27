using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 source                                   IUniTaskAsyncEnumerable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 keySelector                              Func`2<<var>, UniTask`1<<var>>> IL2CPP_TYPE_GENERICINST
    // 000 comparer                                 IEqualityComparer`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 cancellationToken                        CancellationToken IL2CPP_TYPE_VALUETYPE
    // 000 state                                    int IL2CPP_TYPE_I4
    // 000 enumerator                               IUniTaskAsyncEnumerator`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 awaiter                                  Awaiter<bool> IL2CPP_TYPE_GENERICINST
    // 000 awaiter2                                 Awaiter<<var>> IL2CPP_TYPE_GENERICINST
    // 000 moveNextAction                           Action IL2CPP_TYPE_CLASS
    // 000 enumeratorCurrent                        <var> IL2CPP_TYPE_VAR
    // 000 prev                                     <var> IL2CPP_TYPE_VAR
    // 000 <Current>k__BackingField                 <var> IL2CPP_TYPE_VAR
    public partial class _DistinctUntilChangedAwait
    {

        public static _DistinctUntilChangedAwait? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new _DistinctUntilChangedAwait();


            return value;
        }
    }
}
