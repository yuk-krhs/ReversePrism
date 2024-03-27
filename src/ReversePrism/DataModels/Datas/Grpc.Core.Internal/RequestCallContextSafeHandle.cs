using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Native                                   NativeMethods IL2CPP_TYPE_CLASS
    // 008 Logger                                   ILogger IL2CPP_TYPE_CLASS
    // 020 returnToPoolAction                       Action`1<RequestCallContextSafeHandle> IL2CPP_TYPE_GENERICINST
    // 028 CompletionCallback                       000186667020 ModelClassType RequestCallCompletionDelegate RequestCallCompletionDelegate RequestCallCompletionDelegate Pointer
    public partial class RequestCallContextSafeHandle
    {
        public RequestCallCompletionDelegate?           CompletionCallback                      { get; set; }

        public static RequestCallContextSafeHandle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RequestCallContextSafeHandle();

            value.CompletionCallback                        = GetObject<RequestCallCompletionDelegate>(new IntPtr(p + 0x028), ReversePrism.DataModels.RequestCallCompletionDelegate.FromPointer); // 02700409BE58 0x28 CompletionCallback          ( 000186667020 ModelClassType RequestCallCompletionDelegate RequestCallCompletionDelegate RequestCallCompletionDelegate Pointer )

            return value;
        }
    }
}
