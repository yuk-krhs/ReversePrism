using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum CalendarId
    {
        UNINITIALIZED_VALUE,
        GREGORIAN,
        GREGORIAN_US,
        JAPAN,
        TAIWAN,
        KOREA,
        HIJRI,
        THAI,
        HEBREW,
        GREGORIAN_ME_FRENCH,
        GREGORIAN_ARABIC,
        GREGORIAN_XLIT_ENGLISH,
        GREGORIAN_XLIT_FRENCH,
        JULIAN,
        JAPANESELUNISOLAR,
        CHINESELUNISOLAR,
        SAKA,
        LUNAR_ETO_CHN,
        LUNAR_ETO_KOR,
        LUNAR_ETO_ROKUYOU,
        KOREANLUNISOLAR,
        TAIWANLUNISOLAR,
        PERSIAN,
        UMALQURA,
        LAST_CALENDAR,
    }
}
