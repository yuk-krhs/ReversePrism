using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum ParseFlags
    {
        HaveYear,
        HaveMonth,
        HaveDay,
        HaveHour,
        HaveMinute,
        HaveSecond,
        HaveTime,
        HaveDate,
        TimeZoneUsed,
        TimeZoneUtc,
        ParsedMonthName,
        CaptureOffset,
        YearDefault,
        Rfc1123Pattern,
        UtcSortPattern,
    }
}
