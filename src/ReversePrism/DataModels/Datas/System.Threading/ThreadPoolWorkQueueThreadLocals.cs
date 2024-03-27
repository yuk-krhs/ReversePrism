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
    public partial class ThreadPoolWorkQueueThreadLocals
    {
        public ThreadPoolWorkQueue?                     WorkQueue                               { get; set; }
        public WorkStealingQueue?                       WorkStealingQueue                       { get; set; }
        public Random?                                  Random                                  { get; set; }

        public static ThreadPoolWorkQueueThreadLocals? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ThreadPoolWorkQueueThreadLocals();

            value.WorkQueue                                 = GetObject<ThreadPoolWorkQueue>(new IntPtr(p + 0x010), ReversePrism.DataModels.ThreadPoolWorkQueue.FromPointer); // 027003B02568 0x10 WorkQueue                   ( 00018665B7E0 ModelClassType ThreadPoolWorkQueue ThreadPoolWorkQueue ThreadPoolWorkQueue Pointer )
            value.WorkStealingQueue                         = GetObject<WorkStealingQueue>(new IntPtr(p + 0x018), ReversePrism.DataModels.WorkStealingQueue.FromPointer); // 027003B02588 0x18 WorkStealingQueue           ( 000186600250 ModelClassType WorkStealingQueue WorkStealingQueue WorkStealingQueue Pointer )
            value.Random                                    = GetObject<Random>(new IntPtr(p + 0x020), ReversePrism.DataModels.Random.FromPointer); // 027003B025A8 0x20 Random                      ( 000186609AA0 ModelClassType Random Random Random Pointer )

            return value;
        }
    }
}
