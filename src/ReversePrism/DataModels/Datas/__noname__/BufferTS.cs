using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 parent                                   BufferObservable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 gate                                     <object> IL2CPP_TYPE_OBJECT
    // 000 q                                        Queue`1<IList`1<<var>>> IL2CPP_TYPE_GENERICINST
    // 000 totalTime                                TimeSpan IL2CPP_TYPE_VALUETYPE
    // 000 nextShift                                TimeSpan IL2CPP_TYPE_VALUETYPE
    // 000 nextSpan                                 TimeSpan IL2CPP_TYPE_VALUETYPE
    // 000 timerD                                   SerialDisposable IL2CPP_TYPE_CLASS
    public partial class BufferTS
    {

        public static BufferTS? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BufferTS();


            return value;
        }
    }
}
