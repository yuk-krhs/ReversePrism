using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum TokenType
    {
        NumberToken,
        YearNumberToken,
        Am,
        Pm,
        MonthToken,
        EndOfString,
        DayOfWeekToken,
        TimeZoneToken,
        EraToken,
        DateWordToken,
        UnknownToken,
        HebrewNumber,
        JapaneseEraToken,
        TEraToken,
        IgnorableSymbol,
        SEP_Unk,
        SEP_End,
        SEP_Space,
        SEP_Am,
        SEP_Pm,
        SEP_Date,
        SEP_Time,
        SEP_YearSuff,
        SEP_MonthSuff,
        SEP_DaySuff,
        SEP_HourSuff,
        SEP_MinuteSuff,
        SEP_SecondSuff,
        SEP_LocalTimeMark,
        SEP_DateOrOffset,
        RegularTokenMask,
        SeparatorTokenMask,
    }
}
