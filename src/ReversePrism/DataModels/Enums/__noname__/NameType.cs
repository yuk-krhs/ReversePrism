using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum NameType
    {
        RemainDays,
        RemainHours,
        RemainMinutes,
        RemainSeconds,
        RemainNone,
        Days,
        Hours,
        Minutes,
        Seconds,
        None,
        Out,
    }
}
