using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SyncContext                              000186602270 ModelClassType SynchronizationContext SynchronizationContext SynchronizationContext Pointer
    // 018 _userSuppliedState                       <object> IL2CPP_TYPE_OBJECT
    // 020 AlreadyCompleted                         000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class AsyncOperation : DataModel
    {
        public SynchronizationContext?                  SyncContext                             { get; set; }
        public bool                                     AlreadyCompleted                        { get; set; }

        public static AsyncOperation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncOperation() { Pointer= p0 };

            value.SyncContext                               = GetObject<SynchronizationContext>(new IntPtr(p + 0x010), ReversePrism.DataModels.SynchronizationContext.FromPointer); // 024667A6ED78 0x10 SyncContext                 ( 000186602270 ModelClassType SynchronizationContext SynchronizationContext SynchronizationContext Pointer )
            value.AlreadyCompleted                          = GetBool(new IntPtr(p + 0x020)); // 024667A6EDB8 0x20 AlreadyCompleted            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
