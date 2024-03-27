using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 parent                                   LastObservable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 notPublished                             bool IL2CPP_TYPE_BOOLEAN
    // 000 lastValue                                <var> IL2CPP_TYPE_VAR
    public partial class Last_
    {

        public static Last_? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Last_();


            return value;
        }
    }
}
