using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 TicksPerMillisecond                      long IL2CPP_TYPE_I8
    // 000 TicksPerSecond                           long IL2CPP_TYPE_I8
    // 000 TicksPerMinute                           long IL2CPP_TYPE_I8
    // 000 TicksPerHour                             long IL2CPP_TYPE_I8
    // 000 TicksPerDay                              long IL2CPP_TYPE_I8
    // 000 MillisPerSecond                          int IL2CPP_TYPE_I4
    // 000 MillisPerMinute                          int IL2CPP_TYPE_I4
    // 000 MillisPerHour                            int IL2CPP_TYPE_I4
    // 000 MillisPerDay                             int IL2CPP_TYPE_I4
    // 000 DaysPerYear                              int IL2CPP_TYPE_I4
    // 000 DaysPer4Years                            int IL2CPP_TYPE_I4
    // 000 DaysPer100Years                          int IL2CPP_TYPE_I4
    // 000 DaysPer400Years                          int IL2CPP_TYPE_I4
    // 000 DaysTo1601                               int IL2CPP_TYPE_I4
    // 000 DaysTo1899                               int IL2CPP_TYPE_I4
    // 000 DaysTo1970                               int IL2CPP_TYPE_I4
    // 000 DaysTo10000                              int IL2CPP_TYPE_I4
    // 000 MinTicks                                 long IL2CPP_TYPE_I8
    // 000 MaxTicks                                 long IL2CPP_TYPE_I8
    // 000 MaxMillis                                long IL2CPP_TYPE_I8
    // 000 UnixEpochTicks                           long IL2CPP_TYPE_I8
    // 000 FileTimeOffset                           long IL2CPP_TYPE_I8
    // 000 DoubleDateOffset                         long IL2CPP_TYPE_I8
    // 000 OADateMinAsTicks                         long IL2CPP_TYPE_I8
    // 000 OADateMinAsDouble                        double IL2CPP_TYPE_R8
    // 000 OADateMaxAsDouble                        double IL2CPP_TYPE_R8
    // 000 DatePartYear                             int IL2CPP_TYPE_I4
    // 000 DatePartDayOfYear                        int IL2CPP_TYPE_I4
    // 000 DatePartMonth                            int IL2CPP_TYPE_I4
    // 000 DatePartDay                              int IL2CPP_TYPE_I4
    // 000 s_daysToMonth365                         int[] IL2CPP_TYPE_SZARRAY
    // 008 s_daysToMonth366                         int[] IL2CPP_TYPE_SZARRAY
    // 010 MinValue                                 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 018 MaxValue                                 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 020 UnixEpoch                                ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 000 TicksMask                                ulong IL2CPP_TYPE_U8
    // 000 FlagsMask                                ulong IL2CPP_TYPE_U8
    // 000 LocalMask                                ulong IL2CPP_TYPE_U8
    // 000 TicksCeiling                             long IL2CPP_TYPE_I8
    // 000 KindUnspecified                          ulong IL2CPP_TYPE_U8
    // 000 KindUtc                                  ulong IL2CPP_TYPE_U8
    // 000 KindLocal                                ulong IL2CPP_TYPE_U8
    // 000 KindLocalAmbiguousDst                    ulong IL2CPP_TYPE_U8
    // 000 KindShift                                int IL2CPP_TYPE_I4
    // 000 TicksField                               string IL2CPP_TYPE_STRING
    // 000 DateDataField                            string IL2CPP_TYPE_STRING
    // 010 DateData                                 ModelPrimitiveType ulong ulong ulong UInt64
    public partial class DateTime : DataModel
    {
        public DateTime                                 MinValue                                { get; set; }
        public DateTime                                 MaxValue                                { get; set; }
        public DateTime                                 UnixEpoch                               { get; set; }
        public ulong                                    DateData                                { get; set; }

        public static DateTime? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DateTime() { Pointer= p0 };

            value.MinValue                                  = GetDateTime(new IntPtr(p + 0x010)); // 0x10 MinValue                    ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.MaxValue                                  = GetDateTime(new IntPtr(p + 0x018)); // 0x18 MaxValue                    ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.UnixEpoch                                 = GetDateTime(new IntPtr(p + 0x020)); // 0x20 UnixEpoch                   ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.DateData                                  = GetUInt64(new IntPtr(p + 0x010)); // 0x10 DateData                    ( ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
