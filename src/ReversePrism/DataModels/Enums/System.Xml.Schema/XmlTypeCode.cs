using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum XmlTypeCode
    {
        None,
        Item,
        Node,
        Document,
        Element,
        Attribute,
        Namespace,
        ProcessingInstruction,
        Comment,
        Text,
        AnyAtomicType,
        UntypedAtomic,
        String,
        Boolean,
        Decimal,
        Float,
        Double,
        Duration,
        DateTime,
        Time,
        Date,
        GYearMonth,
        GYear,
        GMonthDay,
        GDay,
        GMonth,
        HexBinary,
        Base64Binary,
        AnyUri,
        QName,
        Notation,
        NormalizedString,
        Token,
        Language,
        NmToken,
        Name,
        NCName,
        Id,
        Idref,
        Entity,
        Integer,
        NonPositiveInteger,
        NegativeInteger,
        Long,
        Int,
        Short,
        Byte,
        NonNegativeInteger,
        UnsignedLong,
        UnsignedInt,
        UnsignedShort,
        UnsignedByte,
        PositiveInteger,
        YearMonthDuration,
        DayTimeDuration,
    }
}
