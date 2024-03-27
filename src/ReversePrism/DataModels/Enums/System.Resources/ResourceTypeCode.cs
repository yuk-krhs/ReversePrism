using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum ResourceTypeCode
    {
        Null,
        String,
        Boolean,
        Char,
        Byte,
        SByte,
        Int16,
        UInt16,
        Int32,
        UInt32,
        Int64,
        UInt64,
        Single,
        Double,
        Decimal,
        DateTime,
        TimeSpan,
        LastPrimitive,
        ByteArray,
        Stream,
        StartOfUserTypes,
    }
}
