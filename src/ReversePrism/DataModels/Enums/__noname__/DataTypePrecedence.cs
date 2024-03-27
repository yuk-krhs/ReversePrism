using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum DataTypePrecedence
    {
        SqlDateTime,
        DateTimeOffset,
        DateTime,
        TimeSpan,
        SqlDouble,
        Double,
        SqlSingle,
        Single,
        SqlDecimal,
        Decimal,
        SqlMoney,
        UInt64,
        SqlInt64,
        Int64,
        UInt32,
        SqlInt32,
        Int32,
        UInt16,
        SqlInt16,
        Int16,
        Byte,
        SqlByte,
        SByte,
        Error,
        SqlBoolean,
        Boolean,
        SqlGuid,
        SqlString,
        String,
        SqlXml,
        SqlChars,
        Char,
        SqlBytes,
        SqlBinary,
    }
}
