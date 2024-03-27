using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_synchronizationContext                 000186601DB0 ModelClassType SynchronizationContext SynchronizationContext SynchronizationContext Pointer
    // 000 s_postCallback                           SendOrPostCallback IL2CPP_TYPE_CLASS
    public partial class SynchronizationContextTaskScheduler
    {
        public SynchronizationContext?                  M_synchronizationContext                { get; set; }

        public static SynchronizationContextTaskScheduler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SynchronizationContextTaskScheduler();

            value.M_synchronizationContext                  = GetObject<SynchronizationContext>(new IntPtr(p + 0x018), ReversePrism.DataModels.SynchronizationContext.FromPointer); // 027003498A60 0x18 M_synchronizationContext    ( 000186601DB0 ModelClassType SynchronizationContext SynchronizationContext SynchronizationContext Pointer )

            return value;
        }
    }
}
