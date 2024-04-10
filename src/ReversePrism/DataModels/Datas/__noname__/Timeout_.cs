using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 parent                                   TimeoutObservable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 gate                                     <object> IL2CPP_TYPE_OBJECT
    // 000 isFinished                               bool IL2CPP_TYPE_BOOLEAN
    // 000 sourceSubscription                       SingleAssignmentDisposable IL2CPP_TYPE_CLASS
    // 000 timerSubscription                        IDisposable IL2CPP_TYPE_CLASS
    public partial class Timeout_ : DataModel
    {

        public static Timeout_? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Timeout_() { Pointer= p0 };


            return value;
        }
    }
}
