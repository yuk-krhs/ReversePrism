using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 HashSetAsyncCoreDelegate                 Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 000 comparer                                 IEqualityComparer`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 second                                   IUniTaskAsyncEnumerable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 set                                      HashSet`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 awaiter                                  Awaiter<HashSet`1<<var>>> IL2CPP_TYPE_GENERICINST
    public partial class _Except
    {

        public static _Except? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new _Except();


            return value;
        }
    }
}
