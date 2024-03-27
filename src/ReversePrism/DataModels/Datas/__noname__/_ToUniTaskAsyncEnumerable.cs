using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 source                                   IEnumerable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 cancellationToken                        CancellationToken IL2CPP_TYPE_VALUETYPE
    // 000 enumerator                               IEnumerator`1<<var>> IL2CPP_TYPE_GENERICINST
    public partial class _ToUniTaskAsyncEnumerable
    {

        public static _ToUniTaskAsyncEnumerable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new _ToUniTaskAsyncEnumerable();


            return value;
        }
    }
}
