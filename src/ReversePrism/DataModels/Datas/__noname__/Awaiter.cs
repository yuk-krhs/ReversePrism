using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 switchToCallback                         SendOrPostCallback IL2CPP_TYPE_CLASS
    // 010 SynchronizationContext                   ModelClassType SynchronizationContext SynchronizationContext SynchronizationContext Pointer
    // 018 DontPostWhenSameContext                  ModelPrimitiveType bool bool bool Bool
    // 020 CancellationToken                        ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    public partial class Awaiter : DataModel
    {
        public SynchronizationContext?                  SynchronizationContext                  { get; set; }
        public bool                                     DontPostWhenSameContext                 { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }

        public static Awaiter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Awaiter() { Pointer= p0 };

            value.SynchronizationContext                    = GetObject<SynchronizationContext>(new IntPtr(p + 0x010), ReversePrism.DataModels.SynchronizationContext.FromPointer); // 0x10 SynchronizationContext      ( ModelClassType SynchronizationContext SynchronizationContext SynchronizationContext Pointer )
            value.DontPostWhenSameContext                   = GetBool(new IntPtr(p + 0x018)); // 0x18 DontPostWhenSameContext     ( ModelPrimitiveType bool bool bool Bool )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x020)); // 0x20 CancellationToken           ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )

            return value;
        }
    }
}
