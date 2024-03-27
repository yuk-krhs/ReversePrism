using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum ValueHandleType
    {
        Empty,
        True,
        False,
        Zero,
        One,
        Int8,
        Int16,
        Int32,
        Int64,
        UInt64,
        Single,
        Double,
        Decimal,
        DateTime,
        TimeSpan,
        Guid,
        UniqueId,
        UTF8,
        EscapedUTF8,
        Base64,
        Dictionary,
        List,
        Char,
        Unicode,
        QName,
        ConstString,
    }
}
