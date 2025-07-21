using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // FFFFFFFF threadLocals                             ThreadPoolWorkQueueThreadLocals IL2CPP_TYPE_CLASS
    // 010 WorkQueue                                ModelClassType ThreadPoolWorkQueue ThreadPoolWorkQueue ThreadPoolWorkQueue Pointer
    // 018 WorkStealingQueue                        ModelClassType WorkStealingQueue WorkStealingQueue WorkStealingQueue Pointer
    // 020 Random                                   ModelClassType Random Random Random Pointer
    public partial class ThreadPoolWorkQueueThreadLocals : DataModel
    {
        public ThreadPoolWorkQueue?                     WorkQueue                               { get; set; }
        public WorkStealingQueue?                       WorkStealingQueue                       { get; set; }
        public Random?                                  Random                                  { get; set; }

        public static ThreadPoolWorkQueueThreadLocals? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ThreadPoolWorkQueueThreadLocals() { Pointer= p0 };

            value.WorkQueue                                 = GetObject<ThreadPoolWorkQueue>(new IntPtr(p + 0x010), ReversePrism.DataModels.ThreadPoolWorkQueue.FromPointer); // 0x10 WorkQueue                   ( ModelClassType ThreadPoolWorkQueue ThreadPoolWorkQueue ThreadPoolWorkQueue Pointer )
            value.WorkStealingQueue                         = GetObject<WorkStealingQueue>(new IntPtr(p + 0x018), ReversePrism.DataModels.WorkStealingQueue.FromPointer); // 0x18 WorkStealingQueue           ( ModelClassType WorkStealingQueue WorkStealingQueue WorkStealingQueue Pointer )
            value.Random                                    = GetObject<Random>(new IntPtr(p + 0x020), ReversePrism.DataModels.Random.FromPointer); // 0x20 Random                      ( ModelClassType Random Random Random Pointer )

            return value;
        }
    }
}
