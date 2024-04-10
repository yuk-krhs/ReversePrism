using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 parent                                   SelectManyObservable`3<<var>, <var>, <var>> IL2CPP_TYPE_GENERICINST
    // 000 collectionDisposable                     CompositeDisposable IL2CPP_TYPE_CLASS
    // 000 gate                                     <object> IL2CPP_TYPE_OBJECT
    // 000 isStopped                                bool IL2CPP_TYPE_BOOLEAN
    // 000 sourceDisposable                         SingleAssignmentDisposable IL2CPP_TYPE_CLASS
    public partial class SelectManyOuterObserver : DataModel
    {

        public static SelectManyOuterObserver? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelectManyOuterObserver() { Pointer= p0 };


            return value;
        }
    }
}
