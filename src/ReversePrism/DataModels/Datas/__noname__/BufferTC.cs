using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 EmptyArray                               <var>[] IL2CPP_TYPE_SZARRAY
    // 000 parent                                   BufferObservable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 gate                                     <object> IL2CPP_TYPE_OBJECT
    // 000 list                                     List`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 timerId                                  long IL2CPP_TYPE_I8
    // 000 timerD                                   SerialDisposable IL2CPP_TYPE_CLASS
    public partial class BufferTC
    {

        public static BufferTC? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BufferTC();


            return value;
        }
    }
}
