using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 parent                                   DistinctUntilChangedObservable`2<<var>, <var>> IL2CPP_TYPE_GENERICINST
    // 000 isFirst                                  bool IL2CPP_TYPE_BOOLEAN
    // 000 prevKey                                  <var> IL2CPP_TYPE_VAR
    public partial class DistinctUntilChanged : DataModel
    {

        public static DistinctUntilChanged? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DistinctUntilChanged() { Pointer= p0 };


            return value;
        }
    }
}
