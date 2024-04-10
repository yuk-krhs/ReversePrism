using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // FFFFFFFF pendingException                         Exception IL2CPP_TYPE_CLASS
    // 000 numExceptionsPending                     int IL2CPP_TYPE_I4
    // 008 exceptionsLock                           <object> IL2CPP_TYPE_OBJECT
    public partial class SWIGPendingException : DataModel
    {

        public static SWIGPendingException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SWIGPendingException() { Pointer= p0 };


            return value;
        }
    }
}
