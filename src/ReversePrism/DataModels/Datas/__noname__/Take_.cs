using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 parent                                   TakeObservable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 gate                                     <object> IL2CPP_TYPE_OBJECT
    public partial class Take_
    {

        public static Take_? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Take_();


            return value;
        }
    }
}
