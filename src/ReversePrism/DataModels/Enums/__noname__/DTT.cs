using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum DTT
    {
        End,
        NumEnd,
        NumAmpm,
        NumSpace,
        NumDatesep,
        NumTimesep,
        MonthEnd,
        MonthSpace,
        MonthDatesep,
        NumDatesuff,
        NumTimesuff,
        DayOfWeek,
        YearSpace,
        YearDateSep,
        YearEnd,
        TimeZone,
        Era,
        NumUTCTimeMark,
        Unk,
        NumLocalTimeMark,
        Max,
    }
}
