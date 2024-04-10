using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 parent                                   ConcatObservable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 gate                                     <object> IL2CPP_TYPE_OBJECT
    // 000 isDisposed                               bool IL2CPP_TYPE_BOOLEAN
    // 000 e                                        IEnumerator`1<IObservable`1<<var>>> IL2CPP_TYPE_GENERICINST
    // 000 subscription                             SerialDisposable IL2CPP_TYPE_CLASS
    // 000 nextSelf                                 Action IL2CPP_TYPE_CLASS
    public partial class Concat : DataModel
    {

        public static Concat? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Concat() { Pointer= p0 };


            return value;
        }
    }
}
