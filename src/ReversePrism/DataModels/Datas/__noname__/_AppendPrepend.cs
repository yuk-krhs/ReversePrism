using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MoveNextCoreDelegate                     Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 000 source                                   IUniTaskAsyncEnumerable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 element                                  <var> IL2CPP_TYPE_VAR
    // 000 cancellationToken                        CancellationToken IL2CPP_TYPE_VALUETYPE
    // 000 state                                    State<<var>> IL2CPP_TYPE_GENERICINST
    // 000 enumerator                               IUniTaskAsyncEnumerator`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 awaiter                                  Awaiter<bool> IL2CPP_TYPE_GENERICINST
    // 000 <Current>k__BackingField                 <var> IL2CPP_TYPE_VAR
    public partial class _AppendPrepend
    {

        public static _AppendPrepend? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new _AppendPrepend();


            return value;
        }
    }
}
