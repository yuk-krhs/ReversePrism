using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 parent                                   SkipObservable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 open                                     bool IL2CPP_TYPE_BOOLEAN
    public partial class Skip_
    {

        public static Skip_? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Skip_();


            return value;
        }
    }
}
