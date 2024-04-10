using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 firstMoveNextCoreDelegate                Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 000 secondMoveNextCoreDelegate               Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 000 first                                    IUniTaskAsyncEnumerable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 second                                   IUniTaskAsyncEnumerable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 resultSelector                           Func`3<<var>, <var>, <var>> IL2CPP_TYPE_GENERICINST
    // 000 cancellationToken                        CancellationToken IL2CPP_TYPE_VALUETYPE
    // 000 firstEnumerator                          IUniTaskAsyncEnumerator`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 secondEnumerator                         IUniTaskAsyncEnumerator`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 firstAwaiter                             Awaiter<bool> IL2CPP_TYPE_GENERICINST
    // 000 secondAwaiter                            Awaiter<bool> IL2CPP_TYPE_GENERICINST
    // 000 <Current>k__BackingField                 <var> IL2CPP_TYPE_VAR
    public partial class _Zip : DataModel
    {

        public static _Zip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new _Zip() { Pointer= p0 };


            return value;
        }
    }
}
