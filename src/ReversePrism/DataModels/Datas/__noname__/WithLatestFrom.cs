using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 parent                                   WithLatestFromObservable`3<<var>, <var>, <var>> IL2CPP_TYPE_GENERICINST
    // 000 gate                                     <object> IL2CPP_TYPE_OBJECT
    // 000 hasLatest                                bool IL2CPP_TYPE_BOOLEAN
    // 000 latestValue                              <var> IL2CPP_TYPE_VAR
    public partial class WithLatestFrom : DataModel
    {

        public static WithLatestFrom? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WithLatestFrom() { Pointer= p0 };


            return value;
        }
    }
}
