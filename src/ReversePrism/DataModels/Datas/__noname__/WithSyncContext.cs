using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 TargetSyncContext                        ModelClassType SynchronizationContext SynchronizationContext SynchronizationContext Pointer
    public partial class WithSyncContext : DataModel
    {
        public SynchronizationContext?                  TargetSyncContext                       { get; set; }

        public static WithSyncContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WithSyncContext() { Pointer= p0 };

            value.TargetSyncContext                         = GetObject<SynchronizationContext>(new IntPtr(p + 0x030), ReversePrism.DataModels.SynchronizationContext.FromPointer); // 0x30 TargetSyncContext           ( ModelClassType SynchronizationContext SynchronizationContext SynchronizationContext Pointer )

            return value;
        }
    }
}
