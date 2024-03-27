using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 source                                   IUniTaskAsyncEnumerable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 keySelector                              Func`2<<var>, <var>> IL2CPP_TYPE_GENERICINST
    // 000 elementSelector                          Func`2<<var>, <var>> IL2CPP_TYPE_GENERICINST
    // 000 resultSelector                           Func`3<<var>, IEnumerable`1<<var>>, <var>> IL2CPP_TYPE_GENERICINST
    // 000 comparer                                 IEqualityComparer`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 cancellationToken                        CancellationToken IL2CPP_TYPE_VALUETYPE
    // 000 groupEnumerator                          IEnumerator`1<IGrouping`2<<var>, <var>>> IL2CPP_TYPE_GENERICINST
    // 000 <Current>k__BackingField                 <var> IL2CPP_TYPE_VAR
    public partial class _GroupBy
    {

        public static _GroupBy? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new _GroupBy();


            return value;
        }
    }
}
