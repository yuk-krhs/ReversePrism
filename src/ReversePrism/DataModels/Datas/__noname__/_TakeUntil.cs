using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 CancelDelegate1                          Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 000 MoveNextCoreDelegate                     Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 000 source                                   IUniTaskAsyncEnumerable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 cancellationToken1                       CancellationToken IL2CPP_TYPE_VALUETYPE
    // 000 cancellationTokenRegistration1           CancellationTokenRegistration IL2CPP_TYPE_VALUETYPE
    // 000 completed                                bool IL2CPP_TYPE_BOOLEAN
    // 000 exception                                Exception IL2CPP_TYPE_CLASS
    // 000 enumerator                               IUniTaskAsyncEnumerator`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 awaiter                                  Awaiter<bool> IL2CPP_TYPE_GENERICINST
    // 000 <Current>k__BackingField                 <var> IL2CPP_TYPE_VAR
    public partial class _TakeUntil : DataModel
    {

        public static _TakeUntil? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new _TakeUntil() { Pointer= p0 };


            return value;
        }
    }
}
