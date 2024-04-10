using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_waitCallbackRunAction                  WaitCallback IL2CPP_TYPE_CLASS
    // 008 s_sendOrPostCallbackRunAction            SendOrPostCallback IL2CPP_TYPE_CLASS
    public partial class YieldAwaiter : DataModel
    {

        public static YieldAwaiter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new YieldAwaiter() { Pointer= p0 };


            return value;
        }
    }
}
