using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 gridMap                                  NativeParallelMultiHashMap`2<int3, <var>> IL2CPP_TYPE_GENERICINST
    // 000 startGrid                                int3 IL2CPP_TYPE_VALUETYPE
    // 000 endGrid                                  int3 IL2CPP_TYPE_VALUETYPE
    // 000 currentGrid                              int3 IL2CPP_TYPE_VALUETYPE
    // 000 isFirst                                  bool IL2CPP_TYPE_BOOLEAN
    public partial class GridEnumerator : DataModel
    {

        public static GridEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GridEnumerator() { Pointer= p0 };


            return value;
        }
    }
}
