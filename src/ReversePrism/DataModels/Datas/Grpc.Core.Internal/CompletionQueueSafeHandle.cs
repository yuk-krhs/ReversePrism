using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Native                                   NativeMethods IL2CPP_TYPE_CLASS
    // 020 ShutdownRefcount                         00018670DCF0 ModelClassType AtomicCounter AtomicCounter AtomicCounter Pointer
    // 028 CompletionRegistry                       0001865F1C70 ModelClassType CompletionRegistry CompletionRegistry CompletionRegistry Pointer
    public partial class CompletionQueueSafeHandle
    {
        public AtomicCounter?                           ShutdownRefcount                        { get; set; }
        public CompletionRegistry?                      CompletionRegistry                      { get; set; }

        public static CompletionQueueSafeHandle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CompletionQueueSafeHandle();

            value.ShutdownRefcount                          = GetObject<AtomicCounter>(new IntPtr(p + 0x020), ReversePrism.DataModels.AtomicCounter.FromPointer); // 02700410D868 0x20 ShutdownRefcount            ( 00018670DCF0 ModelClassType AtomicCounter AtomicCounter AtomicCounter Pointer )
            value.CompletionRegistry                        = GetObject<CompletionRegistry>(new IntPtr(p + 0x028), ReversePrism.DataModels.CompletionRegistry.FromPointer); // 02700410D888 0x28 CompletionRegistry          ( 0001865F1C70 ModelClassType CompletionRegistry CompletionRegistry CompletionRegistry Pointer )

            return value;
        }
    }
}
