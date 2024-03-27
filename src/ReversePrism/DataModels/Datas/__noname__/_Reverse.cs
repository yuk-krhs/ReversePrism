using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 source                                   IUniTaskAsyncEnumerable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 cancellationToken                        CancellationToken IL2CPP_TYPE_VALUETYPE
    // 000 array                                    <var>[] IL2CPP_TYPE_SZARRAY
    // 000 index                                    int IL2CPP_TYPE_I4
    // 000 <Current>k__BackingField                 <var> IL2CPP_TYPE_VAR
    public partial class _Reverse
    {

        public static _Reverse? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new _Reverse();


            return value;
        }
    }
}
