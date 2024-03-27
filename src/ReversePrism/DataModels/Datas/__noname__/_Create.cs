using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 create                                   Func`3<IAsyncWriter`1<<var>>, CancellationToken, UniTask> IL2CPP_TYPE_GENERICINST
    // 000 cancellationToken                        CancellationToken IL2CPP_TYPE_VALUETYPE
    // 000 state                                    int IL2CPP_TYPE_I4
    // 000 writer                                   AsyncWriter<<var>> IL2CPP_TYPE_GENERICINST
    // 000 <Current>k__BackingField                 <var> IL2CPP_TYPE_VAR
    public partial class _Create
    {

        public static _Create? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new _Create();


            return value;
        }
    }
}
