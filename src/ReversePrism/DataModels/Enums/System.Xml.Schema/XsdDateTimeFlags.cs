using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum XsdDateTimeFlags
    {
        DateTime,
        Time,
        Date,
        GYearMonth,
        GYear,
        GMonthDay,
        GDay,
        GMonth,
        XdrDateTimeNoTz,
        XdrDateTime,
        XdrTimeNoTz,
        AllXsd,
    }
}
