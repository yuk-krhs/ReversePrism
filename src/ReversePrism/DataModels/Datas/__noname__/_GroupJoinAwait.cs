using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MoveNextCoreDelegate                     Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 000 ResultSelectCoreDelegate                 Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 000 OuterKeySelectCoreDelegate               Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 000 outer                                    IUniTaskAsyncEnumerable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 inner                                    IUniTaskAsyncEnumerable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 outerKeySelector                         Func`2<<var>, UniTask`1<<var>>> IL2CPP_TYPE_GENERICINST
    // 000 innerKeySelector                         Func`2<<var>, UniTask`1<<var>>> IL2CPP_TYPE_GENERICINST
    // 000 resultSelector                           Func`3<<var>, IEnumerable`1<<var>>, UniTask`1<<var>>> IL2CPP_TYPE_GENERICINST
    // 000 comparer                                 IEqualityComparer`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 cancellationToken                        CancellationToken IL2CPP_TYPE_VALUETYPE
    // 000 lookup                                   ILookup`2<<var>, <var>> IL2CPP_TYPE_GENERICINST
    // 000 enumerator                               IUniTaskAsyncEnumerator`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 outerValue                               <var> IL2CPP_TYPE_VAR
    // 000 awaiter                                  Awaiter<bool> IL2CPP_TYPE_GENERICINST
    // 000 outerKeyAwaiter                          Awaiter<<var>> IL2CPP_TYPE_GENERICINST
    // 000 resultAwaiter                            Awaiter<<var>> IL2CPP_TYPE_GENERICINST
    // 000 <Current>k__BackingField                 <var> IL2CPP_TYPE_VAR
    public partial class _GroupJoinAwait : DataModel
    {

        public static _GroupJoinAwait? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new _GroupJoinAwait() { Pointer= p0 };


            return value;
        }
    }
}
