using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Data                                     000186691970 ModelEnumType NativeRingQueueDispose NativeRingQueueDispose NativeRingQueueDispose Int32
    public partial class NativeRingQueueDisposeJob : DataModel
    {
        public NativeRingQueueDispose                   Data                                    { get; set; }

        public static NativeRingQueueDisposeJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeRingQueueDisposeJob() { Pointer= p0 };

            value.Data                                      = (NativeRingQueueDispose)GetInt32(new IntPtr(p + 0x010)); // 0246608B2890 0x10 Data                        ( 000186691970 ModelEnumType NativeRingQueueDispose NativeRingQueueDispose NativeRingQueueDispose Int32 )

            return value;
        }
    }
}
