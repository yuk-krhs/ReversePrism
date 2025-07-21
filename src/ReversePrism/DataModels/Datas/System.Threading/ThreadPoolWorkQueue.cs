using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 QueueHead                                ModelClassType QueueSegment QueueSegment QueueSegment Pointer
    // 018 QueueTail                                ModelClassType QueueSegment QueueSegment QueueSegment Pointer
    // 000 allThreadQueues                          SparseArray`1<WorkStealingQueue> IL2CPP_TYPE_GENERICINST
    // 020 NumOutstandingThreadRequests             ModelPrimitiveType int int int Int32
    public partial class ThreadPoolWorkQueue : DataModel
    {
        public QueueSegment?                            QueueHead                               { get; set; }
        public QueueSegment?                            QueueTail                               { get; set; }
        public int                                      NumOutstandingThreadRequests            { get; set; }

        public static ThreadPoolWorkQueue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ThreadPoolWorkQueue() { Pointer= p0 };

            value.QueueHead                                 = GetObject<QueueSegment>(new IntPtr(p + 0x010), ReversePrism.DataModels.QueueSegment.FromPointer); // 0x10 QueueHead                   ( ModelClassType QueueSegment QueueSegment QueueSegment Pointer )
            value.QueueTail                                 = GetObject<QueueSegment>(new IntPtr(p + 0x018), ReversePrism.DataModels.QueueSegment.FromPointer); // 0x18 QueueTail                   ( ModelClassType QueueSegment QueueSegment QueueSegment Pointer )
            value.NumOutstandingThreadRequests              = GetInt32(new IntPtr(p + 0x020)); // 0x20 NumOutstandingThreadRequests ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
