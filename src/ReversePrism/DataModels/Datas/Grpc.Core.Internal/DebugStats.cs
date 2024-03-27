using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PendingBatchCompletions                  00018670E1C0 ModelClassType AtomicCounter AtomicCounter AtomicCounter Pointer
    public partial class DebugStats
    {
        public AtomicCounter?                           PendingBatchCompletions                 { get; set; }

        public static DebugStats? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugStats();

            value.PendingBatchCompletions                   = GetObject<AtomicCounter>(new IntPtr(p + 0x010), ReversePrism.DataModels.AtomicCounter.FromPointer); // 027004099EE8 0x10 PendingBatchCompletions     ( 00018670E1C0 ModelClassType AtomicCounter AtomicCounter AtomicCounter Pointer )

            return value;
        }
    }
}
