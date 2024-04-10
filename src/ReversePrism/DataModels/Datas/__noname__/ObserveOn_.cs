using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 parent                                   ObserveOnObservable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 scheduler                                ISchedulerQueueing IL2CPP_TYPE_CLASS
    // 000 isDisposed                               BooleanDisposable IL2CPP_TYPE_CLASS
    // 000 onNext                                   Action`1<<var>> IL2CPP_TYPE_GENERICINST
    public partial class ObserveOn_ : DataModel
    {

        public static ObserveOn_? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObserveOn_() { Pointer= p0 };


            return value;
        }
    }
}
