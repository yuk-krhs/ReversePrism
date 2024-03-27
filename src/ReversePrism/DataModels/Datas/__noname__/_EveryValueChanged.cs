using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 target                                   WeakReference`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 equalityComparer                         IEqualityComparer`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 propertySelector                         Func`2<<var>, <var>> IL2CPP_TYPE_GENERICINST
    // 000 cancellationToken                        CancellationToken IL2CPP_TYPE_VALUETYPE
    // 000 first                                    bool IL2CPP_TYPE_BOOLEAN
    // 000 currentValue                             <var> IL2CPP_TYPE_VAR
    // 000 disposed                                 bool IL2CPP_TYPE_BOOLEAN
    public partial class _EveryValueChanged
    {

        public static _EveryValueChanged? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new _EveryValueChanged();


            return value;
        }
    }
}
