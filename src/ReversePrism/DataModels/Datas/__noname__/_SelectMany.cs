using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 sourceMoveNextCoreDelegate               Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 000 selectedSourceMoveNextCoreDelegate       Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 000 selectedEnumeratorDisposeAsyncCoreDelegate Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 000 source                                   IUniTaskAsyncEnumerable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 selector1                                Func`2<<var>, IUniTaskAsyncEnumerable`1<<var>>> IL2CPP_TYPE_GENERICINST
    // 000 selector2                                Func`3<<var>, int, IUniTaskAsyncEnumerable`1<<var>>> IL2CPP_TYPE_GENERICINST
    // 000 resultSelector                           Func`3<<var>, <var>, <var>> IL2CPP_TYPE_GENERICINST
    // 000 cancellationToken                        CancellationToken IL2CPP_TYPE_VALUETYPE
    // 000 sourceCurrent                            <var> IL2CPP_TYPE_VAR
    // 000 sourceIndex                              int IL2CPP_TYPE_I4
    // 000 sourceEnumerator                         IUniTaskAsyncEnumerator`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 selectedEnumerator                       IUniTaskAsyncEnumerator`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 sourceAwaiter                            Awaiter<bool> IL2CPP_TYPE_GENERICINST
    // 000 selectedAwaiter                          Awaiter<bool> IL2CPP_TYPE_GENERICINST
    // 000 selectedDisposeAsyncAwaiter              Awaiter IL2CPP_TYPE_VALUETYPE
    // 000 <Current>k__BackingField                 <var> IL2CPP_TYPE_VAR
    public partial class _SelectMany
    {

        public static _SelectMany? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new _SelectMany();


            return value;
        }
    }
}
