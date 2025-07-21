using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 constantTime                             IScheduler IL2CPP_TYPE_CLASS
    // 008 tailRecursion                            IScheduler IL2CPP_TYPE_CLASS
    // 010 Iteration                                ModelClassType IScheduler IScheduler IScheduler Pointer
    // 018 TimeBasedOperations                      ModelClassType IScheduler IScheduler IScheduler Pointer
    // 020 AsyncConversions                         ModelClassType IScheduler IScheduler IScheduler Pointer
    public partial class DefaultSchedulers : DataModel
    {
        public IScheduler?                              Iteration                               { get; set; }
        public IScheduler?                              TimeBasedOperations                     { get; set; }
        public IScheduler?                              AsyncConversions                        { get; set; }

        public static DefaultSchedulers? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DefaultSchedulers() { Pointer= p0 };

            value.Iteration                                 = GetObject<IScheduler>(new IntPtr(p + 0x010), ReversePrism.DataModels.IScheduler.FromPointer); // 0x10 Iteration                   ( ModelClassType IScheduler IScheduler IScheduler Pointer )
            value.TimeBasedOperations                       = GetObject<IScheduler>(new IntPtr(p + 0x018), ReversePrism.DataModels.IScheduler.FromPointer); // 0x18 TimeBasedOperations         ( ModelClassType IScheduler IScheduler IScheduler Pointer )
            value.AsyncConversions                          = GetObject<IScheduler>(new IntPtr(p + 0x020), ReversePrism.DataModels.IScheduler.FromPointer); // 0x20 AsyncConversions            ( ModelClassType IScheduler IScheduler IScheduler Pointer )

            return value;
        }
    }
}
