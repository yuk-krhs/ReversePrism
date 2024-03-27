using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 parent                                   MergeObservable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 collectionDisposable                     CompositeDisposable IL2CPP_TYPE_CLASS
    // 000 sourceDisposable                         SingleAssignmentDisposable IL2CPP_TYPE_CLASS
    // 000 gate                                     <object> IL2CPP_TYPE_OBJECT
    // 000 isStopped                                bool IL2CPP_TYPE_BOOLEAN
    // 000 q                                        Queue`1<IObservable`1<<var>>> IL2CPP_TYPE_GENERICINST
    // 000 activeCount                              int IL2CPP_TYPE_I4
    public partial class MergeConcurrentObserver
    {

        public static MergeConcurrentObserver? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MergeConcurrentObserver();


            return value;
        }
    }
}
