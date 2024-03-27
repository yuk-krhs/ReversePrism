using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Data                                     00018673C850 ModelEnumType UnsafeQueueDispose UnsafeQueueDispose UnsafeQueueDispose Int32
    public partial class UnsafeQueueDisposeJob
    {
        public UnsafeQueueDispose                       Data                                    { get; set; }

        public static UnsafeQueueDisposeJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnsafeQueueDisposeJob();

            value.Data                                      = (UnsafeQueueDispose)GetInt32(new IntPtr(p + 0x010)); // 0270D0870348 0x10 Data                        ( 00018673C850 ModelEnumType UnsafeQueueDispose UnsafeQueueDispose UnsafeQueueDispose Int32 )

            return value;
        }
    }
}
