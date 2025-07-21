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
    // 000 DaysTo10000                              int IL2CPP_TYPE_I4
    // 000 MaxMillis                                long IL2CPP_TYPE_I8
    // 000 CAL_GREGORIAN                            int IL2CPP_TYPE_I4
    // 000 CAL_GREGORIAN_US                         int IL2CPP_TYPE_I4
    // 000 CAL_JAPAN                                int IL2CPP_TYPE_I4
    // 000 CAL_TAIWAN                               int IL2CPP_TYPE_I4
    // 000 CAL_KOREA                                int IL2CPP_TYPE_I4
    // 000 CAL_HIJRI                                int IL2CPP_TYPE_I4
    // 000 CAL_THAI                                 int IL2CPP_TYPE_I4
    // 000 CAL_HEBREW                               int IL2CPP_TYPE_I4
    // 000 CAL_GREGORIAN_ME_FRENCH                  int IL2CPP_TYPE_I4
    // 000 CAL_GREGORIAN_ARABIC                     int IL2CPP_TYPE_I4
    // 000 CAL_GREGORIAN_XLIT_ENGLISH               int IL2CPP_TYPE_I4
    // 000 CAL_GREGORIAN_XLIT_FRENCH                int IL2CPP_TYPE_I4
    // 000 CAL_JULIAN                               int IL2CPP_TYPE_I4
    // 000 CAL_JAPANESELUNISOLAR                    int IL2CPP_TYPE_I4
    // 000 CAL_CHINESELUNISOLAR                     int IL2CPP_TYPE_I4
    // 000 CAL_SAKA                                 int IL2CPP_TYPE_I4
    // 000 CAL_LUNAR_ETO_CHN                        int IL2CPP_TYPE_I4
    // 000 CAL_LUNAR_ETO_KOR                        int IL2CPP_TYPE_I4
    // 000 CAL_LUNAR_ETO_ROKUYOU                    int IL2CPP_TYPE_I4
    // 000 CAL_KOREANLUNISOLAR                      int IL2CPP_TYPE_I4
    // 000 CAL_TAIWANLUNISOLAR                      int IL2CPP_TYPE_I4
    // 000 CAL_PERSIAN                              int IL2CPP_TYPE_I4
    // 000 CAL_UMALQURA                             int IL2CPP_TYPE_I4
    // 010 M_currentEraValue                        ModelPrimitiveType int int int Int32
    // 014 M_isReadOnly                             ModelPrimitiveType bool bool bool Bool
    // 000 CurrentEra                               int IL2CPP_TYPE_I4
    // 018 TwoDigitYearMax                          ModelPrimitiveType int int int Int32
    public partial class Calendar : DataModel
    {
        public int                                      M_currentEraValue                       { get; set; }
        public bool                                     M_isReadOnly                            { get; set; }
        public int                                      TwoDigitYearMax                         { get; set; }

        public static Calendar? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Calendar() { Pointer= p0 };

            value.M_currentEraValue                         = GetInt32(new IntPtr(p + 0x010)); // 0x10 M_currentEraValue           ( ModelPrimitiveType int int int Int32 )
            value.M_isReadOnly                              = GetBool(new IntPtr(p + 0x014)); // 0x14 M_isReadOnly                ( ModelPrimitiveType bool bool bool Bool )
            value.TwoDigitYearMax                           = GetInt32(new IntPtr(p + 0x018)); // 0x18 TwoDigitYearMax             ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
