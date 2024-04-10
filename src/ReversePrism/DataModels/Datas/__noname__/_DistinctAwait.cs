using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 set                                      HashSet`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 keySelector                              Func`2<<var>, UniTask`1<<var>>> IL2CPP_TYPE_GENERICINST
    public partial class _DistinctAwait : DataModel
    {

        public static _DistinctAwait? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new _DistinctAwait() { Pointer= p0 };


            return value;
        }
    }
}
