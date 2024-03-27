using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SynchronizationContext                   000186602270 ModelClassType SynchronizationContext SynchronizationContext SynchronizationContext Pointer
    // 018 CancellationToken                        00018653D5A0 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    public partial class SwitchToSynchronizationContextAwaitable
    {
        public SynchronizationContext?                  SynchronizationContext                  { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }

        public static SwitchToSynchronizationContextAwaitable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SwitchToSynchronizationContextAwaitable();

            value.SynchronizationContext                    = GetObject<SynchronizationContext>(new IntPtr(p + 0x010), ReversePrism.DataModels.SynchronizationContext.FromPointer); // 0270D8DA3630 0x10 SynchronizationContext      ( 000186602270 ModelClassType SynchronizationContext SynchronizationContext SynchronizationContext Pointer )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x018)); // 0270D8DA3650 0x18 CancellationToken           ( 00018653D5A0 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )

            return value;
        }
    }
}
