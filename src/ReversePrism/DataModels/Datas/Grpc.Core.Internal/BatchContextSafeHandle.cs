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
    // 020 returnToPoolAction                       Action`1<BatchContextSafeHandle> IL2CPP_TYPE_GENERICINST
    // 028 CompletionCallbackData                   0001866F76C0 ModelEnumType CompletionCallbackData CompletionCallbackData CompletionCallbackData Int32
    public partial class BatchContextSafeHandle
    {
        public CompletionCallbackData                   CompletionCallbackData                  { get; set; }

        public static BatchContextSafeHandle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BatchContextSafeHandle();

            value.CompletionCallbackData                    = (CompletionCallbackData)GetInt32(new IntPtr(p + 0x028)); // 02700409DE10 0x28 CompletionCallbackData      ( 0001866F76C0 ModelEnumType CompletionCallbackData CompletionCallbackData CompletionCallbackData Int32 )

            return value;
        }
    }
}
