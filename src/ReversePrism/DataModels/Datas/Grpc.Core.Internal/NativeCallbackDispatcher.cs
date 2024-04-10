using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Logger                                   ILogger IL2CPP_TYPE_CLASS
    // 008 dispatcherCallback                       NativeCallbackDispatcherCallback IL2CPP_TYPE_CLASS
    public partial class NativeCallbackDispatcher : DataModel
    {

        public static NativeCallbackDispatcher? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeCallbackDispatcher() { Pointer= p0 };


            return value;
        }
    }
}
