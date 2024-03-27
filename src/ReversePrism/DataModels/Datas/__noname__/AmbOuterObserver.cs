using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 parent                                   AmbObservable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 gate                                     <object> IL2CPP_TYPE_OBJECT
    // 000 leftSubscription                         SingleAssignmentDisposable IL2CPP_TYPE_CLASS
    // 000 rightSubscription                        SingleAssignmentDisposable IL2CPP_TYPE_CLASS
    // 000 choice                                   AmbState<<var>> IL2CPP_TYPE_GENERICINST
    public partial class AmbOuterObserver
    {

        public static AmbOuterObserver? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AmbOuterObserver();


            return value;
        }
    }
}
