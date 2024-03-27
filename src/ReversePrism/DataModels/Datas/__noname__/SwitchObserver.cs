using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 parent                                   SwitchObservable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 gate                                     <object> IL2CPP_TYPE_OBJECT
    // 000 innerSubscription                        SerialDisposable IL2CPP_TYPE_CLASS
    // 000 isStopped                                bool IL2CPP_TYPE_BOOLEAN
    // 000 latest                                   ulong IL2CPP_TYPE_U8
    // 000 hasLatest                                bool IL2CPP_TYPE_BOOLEAN
    public partial class SwitchObserver
    {

        public static SwitchObserver? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SwitchObserver();


            return value;
        }
    }
}
