using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 parent                                   ThrottleObservable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 gate                                     <object> IL2CPP_TYPE_OBJECT
    // 000 latestValue                              <var> IL2CPP_TYPE_VAR
    // 000 hasValue                                 bool IL2CPP_TYPE_BOOLEAN
    // 000 cancelable                               SerialDisposable IL2CPP_TYPE_CLASS
    // 000 id                                       ulong IL2CPP_TYPE_U8
    public partial class Throttle
    {

        public static Throttle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Throttle();


            return value;
        }
    }
}
