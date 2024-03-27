using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Callback                                 0001865C5890 ModelClassType IOCompletionCallback IOCompletionCallback IOCompletionCallback Pointer
    public partial class IOCompletionThunk
    {
        public IOCompletionCallback?                    Callback                                { get; set; }

        public static IOCompletionThunk? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IOCompletionThunk();

            value.Callback                                  = GetObject<IOCompletionCallback>(new IntPtr(p + 0x010), ReversePrism.DataModels.IOCompletionCallback.FromPointer); // 0270DBA2AC30 0x10 Callback                    ( 0001865C5890 ModelClassType IOCompletionCallback IOCompletionCallback IOCompletionCallback Pointer )

            return value;
        }
    }
}
