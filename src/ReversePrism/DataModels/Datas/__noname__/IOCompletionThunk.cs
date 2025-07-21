using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Callback                                 ModelClassType IOCompletionCallback IOCompletionCallback IOCompletionCallback Pointer
    public partial class IOCompletionThunk : DataModel
    {
        public IOCompletionCallback?                    Callback                                { get; set; }

        public static IOCompletionThunk? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IOCompletionThunk() { Pointer= p0 };

            value.Callback                                  = GetObject<IOCompletionCallback>(new IntPtr(p + 0x010), ReversePrism.DataModels.IOCompletionCallback.FromPointer); // 0x10 Callback                    ( ModelClassType IOCompletionCallback IOCompletionCallback IOCompletionCallback Pointer )

            return value;
        }
    }
}
