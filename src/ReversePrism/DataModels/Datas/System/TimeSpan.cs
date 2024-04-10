using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 TicksPerMillisecond                      long IL2CPP_TYPE_I8
    // 000 MillisecondsPerTick                      double IL2CPP_TYPE_R8
    // 000 TicksPerSecond                           long IL2CPP_TYPE_I8
    // 000 SecondsPerTick                           double IL2CPP_TYPE_R8
    // 000 TicksPerMinute                           long IL2CPP_TYPE_I8
    // 000 MinutesPerTick                           double IL2CPP_TYPE_R8
    // 000 TicksPerHour                             long IL2CPP_TYPE_I8
    // 000 HoursPerTick                             double IL2CPP_TYPE_R8
    // 000 TicksPerDay                              long IL2CPP_TYPE_I8
    // 000 DaysPerTick                              double IL2CPP_TYPE_R8
    // 000 MillisPerSecond                          int IL2CPP_TYPE_I4
    // 000 MillisPerMinute                          int IL2CPP_TYPE_I4
    // 000 MillisPerHour                            int IL2CPP_TYPE_I4
    // 000 MillisPerDay                             int IL2CPP_TYPE_I4
    // 000 MaxSeconds                               long IL2CPP_TYPE_I8
    // 000 MinSeconds                               long IL2CPP_TYPE_I8
    // 000 MaxMilliSeconds                          long IL2CPP_TYPE_I8
    // 000 MinMilliSeconds                          long IL2CPP_TYPE_I8
    // 000 TicksPerTenthSecond                      long IL2CPP_TYPE_I8
    // 000 Zero                                     TimeSpan IL2CPP_TYPE_VALUETYPE
    // 008 MaxValue                                 TimeSpan IL2CPP_TYPE_VALUETYPE
    // 010 MinValue                                 00018668BEB0 ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 010 Ticks                                    0001865F8520 ModelPrimitiveType long long long Int64
    public partial class TimeSpan : DataModel
    {
        public TimeSpan                                 MinValue                                { get; set; }
        public long                                     Ticks                                   { get; set; }

        public static TimeSpan? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimeSpan() { Pointer= p0 };

            value.MinValue                                  = (TimeSpan)GetInt32(new IntPtr(p + 0x010)); // 0245A33D1370 0x10 MinValue                    ( 00018668BEB0 ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.Ticks                                     = GetInt64(new IntPtr(p + 0x010)); // 0245A33D1390 0x10 Ticks                       ( 0001865F8520 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
