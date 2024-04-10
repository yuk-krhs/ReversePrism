using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 Stopwatch                                00018676AE80 ModelEnumType ValueStopwatch ValueStopwatch ValueStopwatch Int32
    // 038 IntervalTicks                            0001865F7700 ModelPrimitiveType long long long Int64
    public partial class RealtimePlayerLoopTimer : DataModel
    {
        public ValueStopwatch                           Stopwatch                               { get; set; }
        public long                                     IntervalTicks                           { get; set; }

        public static RealtimePlayerLoopTimer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RealtimePlayerLoopTimer() { Pointer= p0 };

            value.Stopwatch                                 = (ValueStopwatch)GetInt32(new IntPtr(p + 0x030)); // 0245A4E56F08 0x30 Stopwatch                   ( 00018676AE80 ModelEnumType ValueStopwatch ValueStopwatch ValueStopwatch Int32 )
            value.IntervalTicks                             = GetInt64(new IntPtr(p + 0x038)); // 0245A4E56F28 0x38 IntervalTicks               ( 0001865F7700 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
