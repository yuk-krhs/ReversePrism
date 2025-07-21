using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SyncContext                              ModelClassType SynchronizationContext SynchronizationContext SynchronizationContext Pointer
    // 018 DontPostWhenSameContext                  ModelPrimitiveType bool bool bool Bool
    // 020 CancellationToken                        ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    public partial class ReturnToSynchronizationContext : DataModel
    {
        public SynchronizationContext?                  SyncContext                             { get; set; }
        public bool                                     DontPostWhenSameContext                 { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }

        public static ReturnToSynchronizationContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReturnToSynchronizationContext() { Pointer= p0 };

            value.SyncContext                               = GetObject<SynchronizationContext>(new IntPtr(p + 0x010), ReversePrism.DataModels.SynchronizationContext.FromPointer); // 0x10 SyncContext                 ( ModelClassType SynchronizationContext SynchronizationContext SynchronizationContext Pointer )
            value.DontPostWhenSameContext                   = GetBool(new IntPtr(p + 0x018)); // 0x18 DontPostWhenSameContext     ( ModelPrimitiveType bool bool bool Bool )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x020)); // 0x20 CancellationToken           ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )

            return value;
        }
    }
}
