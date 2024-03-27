using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 QueueHead                                0001865FF900 ModelClassType QueueSegment QueueSegment QueueSegment Pointer
    // 018 QueueTail                                0001865FF900 ModelClassType QueueSegment QueueSegment QueueSegment Pointer
    // 000 allThreadQueues                          SparseArray`1<WorkStealingQueue> IL2CPP_TYPE_GENERICINST
    // 020 NumOutstandingThreadRequests             0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ThreadPoolWorkQueue
    {
        public QueueSegment?                            QueueHead                               { get; set; }
        public QueueSegment?                            QueueTail                               { get; set; }
        public int                                      NumOutstandingThreadRequests            { get; set; }

        public static ThreadPoolWorkQueue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ThreadPoolWorkQueue();

            value.QueueHead                                 = GetObject<QueueSegment>(new IntPtr(p + 0x010), ReversePrism.DataModels.QueueSegment.FromPointer); // 027003AFEEE0 0x10 QueueHead                   ( 0001865FF900 ModelClassType QueueSegment QueueSegment QueueSegment Pointer )
            value.QueueTail                                 = GetObject<QueueSegment>(new IntPtr(p + 0x018), ReversePrism.DataModels.QueueSegment.FromPointer); // 027003AFEF00 0x18 QueueTail                   ( 0001865FF900 ModelClassType QueueSegment QueueSegment QueueSegment Pointer )
            value.NumOutstandingThreadRequests              = GetInt32(new IntPtr(p + 0x020)); // 027003AFEF40 0x20 NumOutstandingThreadRequests ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
