using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 parent                                   ThrottleFirstObservable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 gate                                     <object> IL2CPP_TYPE_OBJECT
    // 000 open                                     bool IL2CPP_TYPE_BOOLEAN
    // 000 cancelable                               SerialDisposable IL2CPP_TYPE_CLASS
    public partial class ThrottleFirst : DataModel
    {

        public static ThrottleFirst? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ThrottleFirst() { Pointer= p0 };


            return value;
        }
    }
}
