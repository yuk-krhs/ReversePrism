using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 parent                                   AmbOuterObserver<<var>> IL2CPP_TYPE_GENERICINST
    // 000 me                                       AmbState<<var>> IL2CPP_TYPE_GENERICINST
    // 000 otherSubscription                        IDisposable IL2CPP_TYPE_CLASS
    // 000 self                                     Amb<<var>> IL2CPP_TYPE_GENERICINST
    public partial class AmbDecisionObserver : DataModel
    {

        public static AmbDecisionObserver? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AmbDecisionObserver() { Pointer= p0 };


            return value;
        }
    }
}
