using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // FFFFFFFF threadLocals                             ThreadPoolWorkQueueThreadLocals IL2CPP_TYPE_CLASS
    // 010 WorkQueue                                00018665B7E0 ModelClassType ThreadPoolWorkQueue ThreadPoolWorkQueue ThreadPoolWorkQueue Pointer
    // 018 WorkStealingQueue                        000186600250 ModelClassType WorkStealingQueue WorkStealingQueue WorkStealingQueue Pointer
    // 020 Random                                   000186609AA0 ModelClassType Random Random Random Pointer
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

            value.WorkQueue                                 = GetObject<ThreadPoolWorkQueue>(new IntPtr(p + 0x010), ReversePrism.DataModels.ThreadPoolWorkQueue.FromPointer); // 0245A3B01020 0x10 WorkQueue                   ( 00018665B7E0 ModelClassType ThreadPoolWorkQueue ThreadPoolWorkQueue ThreadPoolWorkQueue Pointer )
            value.WorkStealingQueue                         = GetObject<WorkStealingQueue>(new IntPtr(p + 0x018), ReversePrism.DataModels.WorkStealingQueue.FromPointer); // 0245A3B01040 0x18 WorkStealingQueue           ( 000186600250 ModelClassType WorkStealingQueue WorkStealingQueue WorkStealingQueue Pointer )
            value.Random                                    = GetObject<Random>(new IntPtr(p + 0x020), ReversePrism.DataModels.Random.FromPointer); // 0245A3B01060 0x20 Random                      ( 000186609AA0 ModelClassType Random Random Random Pointer )

            return value;
        }
    }
}
