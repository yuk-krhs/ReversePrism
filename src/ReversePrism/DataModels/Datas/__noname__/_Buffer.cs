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
    // 000 count                                    int IL2CPP_TYPE_I4
    // 000 cancellationToken                        CancellationToken IL2CPP_TYPE_VALUETYPE
    // 000 enumerator                               IUniTaskAsyncEnumerator`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 awaiter                                  Awaiter<bool> IL2CPP_TYPE_GENERICINST
    // 000 continueNext                             bool IL2CPP_TYPE_BOOLEAN
    // 000 completed                                bool IL2CPP_TYPE_BOOLEAN
    // 000 buffer                                   List`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 <Current>k__BackingField                 IList`1<<var>> IL2CPP_TYPE_GENERICINST
    public partial class _Buffer : DataModel
    {

        public static _Buffer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new _Buffer() { Pointer= p0 };


            return value;
        }
    }
}
