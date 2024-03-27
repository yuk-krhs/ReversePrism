using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 timerUpdateStopCondition                 Func`1<bool> IL2CPP_TYPE_GENERICINST
    // 000 OnceCondition                            Func`1<bool> IL2CPP_TYPE_GENERICINST
    // 008 ForeverCondition                         Func`1<bool> IL2CPP_TYPE_GENERICINST
    // 018 StartMs                                  0001865F7700 ModelPrimitiveType long long long Int64
    // 020 DelayMs                                  0001865F7700 ModelPrimitiveType long long long Int64
    // 028 IntervalMs                               0001865F7700 ModelPrimitiveType long long long Int64
    // 030 EndTimeMs                                0001865F7700 ModelPrimitiveType long long long Int64
    public partial class ScheduledItem
    {
        public long                                     StartMs                                 { get; set; }
        public long                                     DelayMs                                 { get; set; }
        public long                                     IntervalMs                              { get; set; }
        public long                                     EndTimeMs                               { get; set; }

        public static ScheduledItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduledItem();

            value.StartMs                                   = GetInt64(new IntPtr(p + 0x018)); // 0270067EA828 0x18 StartMs                     ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.DelayMs                                   = GetInt64(new IntPtr(p + 0x020)); // 0270067EA848 0x20 DelayMs                     ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.IntervalMs                                = GetInt64(new IntPtr(p + 0x028)); // 0270067EA868 0x28 IntervalMs                  ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.EndTimeMs                                 = GetInt64(new IntPtr(p + 0x030)); // 0270067EA888 0x30 EndTimeMs                   ( 0001865F7700 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
