using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_postCallback                           SendOrPostCallback IL2CPP_TYPE_CLASS
    // 008 s_postActionCallback                     ContextCallback IL2CPP_TYPE_CLASS
    // 020 M_syncContext                            ModelClassType SynchronizationContext SynchronizationContext SynchronizationContext Pointer
    public partial class SynchronizationContextAwaitTaskContinuation : DataModel
    {
        public SynchronizationContext?                  M_syncContext                           { get; set; }

        public static SynchronizationContextAwaitTaskContinuation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SynchronizationContextAwaitTaskContinuation() { Pointer= p0 };

            value.M_syncContext                             = GetObject<SynchronizationContext>(new IntPtr(p + 0x020), ReversePrism.DataModels.SynchronizationContext.FromPointer); // 0x20 M_syncContext               ( ModelClassType SynchronizationContext SynchronizationContext SynchronizationContext Pointer )

            return value;
        }
    }
}
