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
    // 000 defaultValue                             <var> IL2CPP_TYPE_VAR
    // 000 cancellationToken                        CancellationToken IL2CPP_TYPE_VALUETYPE
    // 000 iteratingState                           IteratingState<<var>> IL2CPP_TYPE_GENERICINST
    // 000 enumerator                               IUniTaskAsyncEnumerator`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 awaiter                                  Awaiter<bool> IL2CPP_TYPE_GENERICINST
    // 000 <Current>k__BackingField                 <var> IL2CPP_TYPE_VAR
    public partial class _DefaultIfEmpty : DataModel
    {

        public static _DefaultIfEmpty? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new _DefaultIfEmpty() { Pointer= p0 };


            return value;
        }
    }
}
